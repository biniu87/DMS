using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentsManagerRU.Controls;
using NLog;

namespace DocumentsManagerRU
{
    public partial class frmEditDocument : Form
    {
        private List<object[]> _tempIndexValues; // 0 - nazwa kolumny (identyfikator indeksu), 1 - Value (Wartośc indeksu)
        private IndexControl _indexControl;
        private IndexControl _indexControlTemp;
        private DataShare _ds;
        private bool _newDocument = false;
        private bool _changeClassAttempt;
        private Document _loadedDocument;
        private Document_Class _loadedClass;
        public static Logger _logger = LogManager.GetCurrentClassLogger();
        //private ResourceManager _locRM { get; set; }
        private ErrorProvider _errorProvider = new ErrorProvider();
        private frmMain _main;

        public frmEditDocument()
        {
            InitializeComponent();
        }

        public frmEditDocument(Int64 documentId, int classId, frmMain main, DataShare ds)
        {
            InitializeComponent();
            _main = main;
            _ds = ds;
            //poświadczenie do usuwania
            ercActive.Enabled = (_main.ClassPermissions.PrimaryPermission >= Permissions.ClassPrimaryPermissions.Delete) || Security.Admin;
            assignDocumentControl.InitializeComponent(_main, _ds);
            LoadDocumentContent(documentId, classId);
        }

        //public Int64 GetSelectedDocumentId()
        //{
        //    Int64 result = -1;
        //    var item = cbDocument.SelectedItem;
        //    try
        //    {
        //        if (item is DataRowView)
        //        {
        //            DataRowView view = (DataRowView)item;
        //            item = view.Row;
        //            var value = view["Id"];
        //            Int64.TryParse(value.ToString(), out result);
        //        }
        //    }
        //    catch (Exception) { }
        //    return result;
        //}

        public int GetSelectedClassId()
        {
            int result = -1;
            var item = cbClass.SelectedItem;
            try
            {
                if (item is DataRowView)
                {
                    DataRowView view = (DataRowView)item;
                    item = view.Row;
                    var value = view["Id"];
                    Int32.TryParse(value.ToString(), out result);
                }
            }
            catch (Exception)
            {
            }
            return result;
        }

        public void LoadDocumentContent(Int64 documentId, int classId)
        {
            if (documentId > 0)
            {
                LoadClassList();
                _loadedDocument = Data.GetDocumentById(documentId, classId);
                _loadedClass = Data.GetClassById(classId);
                if (_loadedDocument != null && _loadedClass != null && _loadedDocument.Id > 0 && _loadedClass.Id > 0)
                {
                    cbClass.SelectedValue = _loadedClass.Id;
                    txtDocumentName.Text = _loadedDocument.Name;
                    txtDocumentDescription.Text = _loadedDocument.Description;
                    txtURL.Text = _loadedDocument.URL;
                    if (_loadedDocument.Active.HasValue)
                        ercActive.Checked = _loadedDocument.Active.Value;
                    if (_loadedDocument.Release_Date.HasValue)
                    {
                        dtpReleaseDate.Value = _loadedDocument.Release_Date.Value;
                    }
                    if (_loadedDocument.AssignedClassId.HasValue && _loadedDocument.AssignedDocumentId.HasValue)
                    {
                        assignDocumentControl.SetSelectedClass(_loadedDocument.AssignedClassId.Value);
                        assignDocumentControl.SetSelectedDocument(_loadedDocument.AssignedDocumentId.Value);
                    }
                    else
                    {
                        assignDocumentControl.ClearAssign();
                    }
                    if (_loadedDocument.DocumentIndexes != null)
                    {
                        CreateAndApplyIndexControl(_loadedDocument.DocumentIndexes.ToList());
                        //stosowanie wartości indeksów do formularza indeksów
                        _indexControl.SetReadOnly(false);
                        SetIndexesToTemp();
                    }
                }
            }
        }

        public void LoadClassList()
        {
            taDocumentClass.FillToReadRelease(iTDataSet.Document_Class, _ds.Language, Security.SecurityObjects, 
                (int)Permissions.ClassPrimaryPermissions.Edit, (int)Permissions.ClassSecondaryPermissions.None);
        }

        private bool IsDocumentModified()
        {
            var mod = _loadedDocument.Name != txtDocumentName.Text ||
                _loadedDocument.Description != txtDocumentDescription.Text ||
                _loadedDocument.Class_Id != GetSelectedClassId() ||
                _loadedDocument.Name != txtDocumentName.Text ||
                _loadedDocument.Release_Date.Value.Date != dtpReleaseDate.Value.Date ||
                _loadedDocument.Active != ercActive.Checked ||
                _loadedDocument.AssignedDocumentId != assignDocumentControl.GetSelectedDocumentId() ||
                _loadedDocument.AssignedClassId != assignDocumentControl.GetSelectedClassId() ||
                _indexControl.IsModified();
            return mod;
        }

        public void SaveDocument()
        {
            //bool result = false;
            if (ValidateFormDocument())
            {
                int newClassId = GetSelectedClassId();
                int? assignedClassId = assignDocumentControl.GetSelectedClassId();
                Int64? assignedDocumentId = assignDocumentControl.GetSelectedDocumentId();
                if (assignedClassId < 1)
                {
                    assignedClassId = null;
                }
                if (assignedDocumentId < 1)
                {
                    assignedDocumentId = null;
                }
                Data.UpdateDocumentProcess(_loadedDocument.Id, _loadedClass.Id, _indexControl.GetIndexes(), _ds, newClassId, txtDocumentName.Text,
                    txtDocumentDescription.Text, txtURL.Text, ercActive.Checked, dtpReleaseDate.Value, assignedClassId, assignedDocumentId);
                //if (result)
                //{
                //    DialogBox.ShowDialog(_ds.LocRM.GetString(DialogBox.MESSAGE_SUCCESS), _ds.LocRM.GetString(DialogBox.ACTION_SAVE),
                //        _ds.LocRM, MessageBoxButtons.OK, DialogBox.Icons.Success);
                //    _ds.RefreshDocumentGridSimple();
                //    this.Close();
                //}
                //else
                //{
                //    DialogBox.ShowDialog(_ds.LocRM.GetString(DialogBox.MESSAGE_FAILED), _ds.LocRM.GetString(DialogBox.ACTION_SAVE),
                //        _ds.LocRM, MessageBoxButtons.OK, DialogBox.Icons.Error);
                //}
            }
            //return result;
        }

        public void DeleteDocument()
        {
            string txt = //string.Format("{0}\n{1}", _locRM.GetString("msg23"), cbDocument.Text);
            string.Format("{0}: {1}", _ds.LocRM.GetString(DialogBox.OBJECT_DOCUMENT), txtDocumentName.Text);

            DialogResult dialogResult = DialogBox.ShowDialog(txt, _ds.LocRM.GetString(DialogBox.MESSAGE_DELETE), _ds, MessageBoxButtons.YesNo, DialogBox.Icons.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (_loadedDocument.Id < 1 || _loadedClass.Id < 1) return;
                bool result = Data.DeleteDocumentProcess(_loadedDocument.Id, _loadedClass.Id);
                if (result)
                {
                    DialogBox.ShowDialog(_ds.LocRM.GetString(DialogBox.MESSAGE_SUCCESS), _ds.LocRM.GetString(DialogBox.ACTION_DELETE),
                        _ds, MessageBoxButtons.OK, DialogBox.Icons.Success);
                    _main.RefreshDocumentGridSimple();
                }
                else
                {
                    DialogBox.ShowDialog(_ds.LocRM.GetString(DialogBox.MESSAGE_FAILED), _ds.LocRM.GetString(DialogBox.ACTION_DELETE),
                        _ds, MessageBoxButtons.OK, DialogBox.Icons.Error);
                }
            }
        }

        private bool ValidateFormDocument()
        {
            _errorProvider.Clear();
            ///całkowite wyłączenie walidowania nazw dokumentów
            /*int selectedClass = GetSelectedClassId();
            //dopuszczamy puste pole nazwy dokumentu
            bool uniqueDocNameInClass = string.IsNullOrEmpty(txtDocumentName.Text) || Data.IsUniqueDocumentNameInClass(txtDocumentName.Text, selectedClass.ToString());
            //if (string.IsNullOrEmpty(txtDocumentName.Text))
            //{
            //    _errorProvider.SetError(txtDocumentName, _ds.LocRM.GetString("msg01")); //Musisz nadać nazwę dla Dokumentu!
            //    return false;
            //}
            //else 
                if (_loadedClass.Id != selectedClass && !uniqueDocNameInClass)
            {
                //walidowanie nazwy przy przenoszeniu do nowej klasy
                _errorProvider.SetError(txtDocumentName, _ds.LocRM.GetString("msg16")); //Nazwa dokumentu musi być unikalna w obrębie klasy!
                return false;
            }
            else if ((txtDocumentName.Text != _loadedDocument.Name) && !uniqueDocNameInClass)
            {
                //walidowanie nazwy w obrębie tej samej klasy z pominięciem przypadku, gdy nazwa nie została zmieniona
                _errorProvider.SetError(txtDocumentName, _ds.LocRM.GetString("msg16")); //Nazwa dokumentu musi być unikalna w obrębie klasy!
                return false;
            }
            else */

            if (!_indexControl.Validate())
            {
                return false;
            }
            else if (!assignDocumentControl.ValidateForm())
            {
                return false;
            }
            else
                return true;
        }

        public void ApplyIndexControl()
        {   if(_indexControl != null)
                _indexControl.Dock = DockStyle.Fill;
            pnlDocumentIndex.Controls.Clear();
            pnlDocumentIndex.Controls.Add(_indexControl);
        }

        public void CreateAndApplyIndexControl(List<Document_Index> indexes)
        {
            _indexControl = new IndexControl(indexes, _ds.LocRM, _ds.Language);
            ApplyIndexControl();
        }

        public List<object[]> GetCopyValuesOfIndexes(List<Document_Index> indexes)
        {
            List<object[]> temp = new List<object[]>();
            foreach (Document_Index index in indexes)
            {
                temp.Add(new object[] { index.Column_Name, index.Value });
            }
            return temp;
        }

        public void SetIndexesToTemp()
        {
            //zapamiętywanie aktualnych wartości pól formularza indeksów dostępnych na anulowanie edycji
            _tempIndexValues = GetCopyValuesOfIndexes(_indexControl.GetIndexes());
            _indexControlTemp = _indexControl;
        }

        public void SetIndexesFromTemp()
        {
            // przywrócenie formularza indeksów w zależności od próby zmiany klasy
            if (_changeClassAttempt)
            {
                _indexControl = _indexControlTemp;
                ApplyIndexControl();
            }
            else
            {
                _indexControl.ApplyValuesToControls(_tempIndexValues);
            }
        }

        private void btnSaveDocument_Click(object sender, EventArgs e)
        {
            //bool ok = true; // status edycji, false tylko przy niepowodzeniu zapisu
            if (_newDocument)
            {
                //można zrobić tworzenie nowego dokumentu
            }
            else if (IsDocumentModified())
            {
                //ok = 
                SaveDocument();
            }
        }

        private void cbChangeClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            int newClassId = GetSelectedClassId();
            if (_loadedClass.Id != newClassId)
            {
                //_indexControl = new IndexControl(, _locRM, _main.GetLanguage());
                CreateAndApplyIndexControl(Data.GetDocumentIndexesForClass(newClassId));
                _indexControl.SetReadOnly(false);
                _changeClassAttempt = true;
                Console.WriteLine("próba zmiany klasy");
            }
            else
            {
                if (_changeClassAttempt)
                {
                    //przywrócenie oryginalnego _indexControl
                    _indexControl = _indexControlTemp;
                    ApplyIndexControl();
                    _changeClassAttempt = false;
                }
            }
        }

        private void btnSaveDocument_Click_1(object sender, EventArgs e)
        {
            SaveDocument();
        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox)
            {
                CheckBox chk = (CheckBox)sender;
                if (chk.Checked)
                {
                    chk.Image = DocumentsManagerRU.Properties.Resources.circle_check_2x;
                }
                else
                {
                    chk.Image = DocumentsManagerRU.Properties.Resources.circle_x_2x;
                }
            }
        }
    }
}
