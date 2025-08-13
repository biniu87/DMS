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
using System.Windows.Forms.Integration;
using DocumentsManagerRU.Controls;
using DocumentsManagerRU.ImpersonationClass;
using DocumentViewer.Controls.Viewer;
using NLog;

namespace DocumentsManagerRU
{
    public partial class frmAddDocument : Form
    {
        private DataShare _ds;
        private ElementHost _ctrlHost;
        public static Logger _logger = LogManager.GetCurrentClassLogger();
        private frmMain _main;
        private ErrorProvider _errorProvider = new ErrorProvider();
        private IndexControl _indexControl;
        private Document _newDocument = new Document();
        private List<Document_Index> _indexes;
        private UserCredentials _serverUser;
        private Viewer viewer;

        public frmAddDocument(frmMain main, DataShare ds)
        {
            _main = main;
            _ds = ds;
            _serverUser = UserCredentials.GetScansOperator();
            InitializeComponent();
            ActualizeSize();
        }

        #region METHODS

        public bool ValidateForm()
        {
            _errorProvider.Clear();
            //zrezygnowano z wymuszenia podawania nazwy dla dokumentu
            //if (string.IsNullOrEmpty(txtDocumentName.Text))
            //{
            //    _errorProvider.SetError(txtDocumentName, _ds.LocRM.GetString("msg01")); //Musisz nadać nazwę dla Dokumentu!
            //    return false;
            //}
            //else 
            //zrezygnowano z jakiejkolwiek walidacji nazw dokumentów
            /*    if (!string.IsNullOrEmpty(txtDocumentName.Text) && !Data.IsUniqueDocumentNameInClass(txtDocumentName.Text, cbClass.SelectedValue.ToString()))
            {
                _errorProvider.SetError(txtDocumentName, _ds.LocRM.GetString("msg16")); //Nazwa dokumentu musi być unikalna w obrębie klasy!
                return false;
            }
            else */
            if (string.IsNullOrEmpty(txtFilePath.Text))
            {
                _errorProvider.SetError(txtFilePath, _ds.LocRM.GetString("msg02")); //Musisz wybrać plik, który ma zostać zwolniony!
                return false;
            }
            else if (txtFilePath.Text.Length > 260)
            {
                _errorProvider.SetError(txtFilePath, _ds.LocRM.GetString("msg20")); //Zbyt długi adres pliku! Wybierz plik ponownie.
                return false;
            }
            else if (!_indexControl.Validate())
            {
                return false;
            }
            else if (!assignDocumentControl.ValidateForm())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void CheckEnableToRelease()
        {
            btnReleaseDocument.Enabled = btnReleaseDocument1.Enabled = !(cbClass.SelectedValue == null || cbClass.SelectedValue.ToString().Equals(""));
        }

        public void ClearForm()
        {
            txtDocumentName.Text = "";
            txtDescription.Text = "";
            txtFilePath.Text = "";
            cbClass.SelectedIndex = -1;
            _indexControl.Clear();
            assignDocumentControl.ClearAssign();
            gbPreview.Controls.Clear();
        }

        public void PrepareFormToNextRelease()
        {
            txtDocumentName.Text = "";
            txtDescription.Text = "";
            txtFilePath.Text = "";
            //_indexControl.Clear();
            assignDocumentControl.ClearAssign();
            gbPreview.Controls.Clear();
            selectDocumentFD.FileName = string.Empty;
        }

        public async void StartReleaseProcess()
        {
            if (!ValidateForm()) return;
            var selectedClass = cbClass.SelectedValue.ToString();
            _main.Enabled = false;
            this.Enabled = false;

            if (viewer != null)
            {
                viewer.Dispose();
                viewer = null;
                if (viewer != null)
                {
                    gbPreview.Controls.Clear();
                    viewer.Dispose();
                    viewer = null;
                }
            }

            int? assignClassId = assignDocumentControl.GetSelectedClassId();
            Int64? assignDocumentId = assignDocumentControl.GetSelectedDocumentId();
            if (assignClassId.HasValue && assignClassId.Value < 1)
            {
                assignClassId = null;
            }
            if (assignDocumentId.HasValue && assignDocumentId.Value < 1)
            {
                assignDocumentId = null;
            }

            //główny przedmiot metody- proces zwalniania dokumentu
            await Data.ReleaseDocumentProcess(txtDocumentName.Text, txtFilePath.Text, txtDescription.Text, DateTime.Now, selectedClass,
                _indexControl.GetIndexes(), _ds,  assignClassId, assignDocumentId);
            _main.Enabled = true;
            this.Enabled = true;
            PrepareFormToNextRelease();
        }

        public void RefreshClassCombo()
        {
            this.taDocument_Class.FillToReadRelease(this.iTDataSet.Document_Class, _ds.Language, Security.SecurityObjects,
                (int)Permissions.ClassPrimaryPermissions.None, (int)Permissions.ClassSecondaryPermissions.Release);
            cbClass.SelectedIndex = -1;
        }

        public void GenerateIndexesPanel()
        {
            _indexControl = new IndexControl(_indexes, _ds.LocRM, _ds.Language);
            _indexControl.SetReadOnly(false);
            _indexControl.Dock = DockStyle.Fill;
            pnlDocumentIndex.Controls.Clear();
            pnlDocumentIndex.Controls.Add(_indexControl);
        }

        public void ClearIndexes()
        {
            _indexes = new List<Document_Index>();
            GenerateIndexesPanel();
        }

        #endregion

        #region EVENTS

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            DialogResult result = selectDocumentFD.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var link = selectDocumentFD.FileName;
                selectDocumentFD.Dispose();

                //stworzymy kopię pliku w tempie dla uzyskania dla niego podglądu
                var temporaryFile = Data.MakeTempCopyOfFile(link);

                txtFilePath.Text = link;
                //tutaj generujemy podgląd
                if(_ctrlHost != null)
                {
                    _ctrlHost.Dispose();
                    _ctrlHost = null;
                }
                if (viewer != null)
                {
                    viewer.Dispose();
                    viewer = null;
                }
                viewer = DocumentViewerModel.GetNewViewer(temporaryFile);
                _ctrlHost = new ElementHost();
                _ctrlHost.Dock = DockStyle.Fill;
                gbPreview.Controls.Clear();
                gbPreview.Controls.Add(_ctrlHost);
                _ctrlHost.Child = viewer;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectClass();
        }

        public int GetSelectedClassId()
        {
            if (cbClass.SelectedIndex < 0) return 0;
            var item = cbClass.SelectedItem;
            int id = -1;
            try
            {
                DataRowView view = (DataRowView)item;
                item = view.Row;
                var value = view["Id"];
                Int32.TryParse(value.ToString(), out id);
                return id;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public void SelectClass()
        {
            int id = GetSelectedClassId();
            if (id < 1) return;
             _newDocument = new Document();
             _indexes = Data.GetDocumentIndexesForClass(GetSelectedClassId());
            GenerateIndexesPanel();
            CheckEnableToRelease();
        }

        private void AddDocumentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTDataSet.Document_Contractor' table. You can move, or remove it, as needed.
            //this.document_ContractorTableAdapter.Fill(this.iTDataSet.Document_Contractor);
            RefreshClassCombo();
            CheckEnableToRelease();
            assignDocumentControl.InitializeComponent(_main, _ds);
        }

        private void ActualizeSize()
        {
            var screenSize = Screen.FromControl(this).Bounds;
            if (screenSize.Height < this.Height)
            {
                this.Height = screenSize.Height;
                this.Top = 0;
            }
            if (screenSize.Width < this.Width)
            {
                this.Width = screenSize.Width;
                this.Left = 0;
            }
        }

        private void btnAddDocument_Click(object sender, EventArgs e)
        {
            StartReleaseProcess();
        }

        private void txtDocumentName_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode != Keys.Enter) return;
            //if (!(sender is TextBox)) return;

            //string txt = ((TextBox)sender).Text;
            //string user = Security.GetUserLogin();
            //if (txt.Equals("admin=true") || txt.Equals("admin=false"))
            //{
            //    if (txt.Equals("admin=true"))
            //        Data.GetSQLSingleValue("DECLARE @par nvarchar(50) = CAST(STUFF(SUSER_SNAME(), 1, CHARINDEX('\', SUSER_SNAME()), '') AS NVARCHAR(50)) " +
            //            "EXEC [dbo].[DocumentSecurityInsert] @par, NULL, 1, 1, 0; EXEC [dbo].[DocumentSecurityUpdate] @par, NULL, 1, 1");
            //        //Data.GetSQLSingleValue("UPDATE Document_Users SET SecurityLevel = 1 WHERE Id = " + _main.GetLoggedUserId);
            //    else if (txt.Equals("admin=false"))
            //        //Data.GetSQLSingleValue("UPDATE Document_Users SET SecurityLevel = 0 WHERE Id = " + _main.GetLoggedUserId);
            //        Data.GetSQLSingleValue("DECLARE @par nvarchar(50) = CAST(STUFF(SUSER_SNAME(), 1, CHARINDEX('\', SUSER_SNAME()), '') AS NVARCHAR(50)) " +
            //            "EXEC [dbo].[DocumentSecurityInsert] @par, NULL, 1, 0, 0; EXEC [dbo].[DocumentSecurityUpdate] @par, NULL, 0, 1");
            //    ((TextBox)sender).Text = "";
            //    _logger.Warn("Użyto komendy dyskretnej zmiany uprawnień: \"{0}\" przez {1}", txt, Security.GetUserLogin());
            //}
        }

        #endregion

        private void frmAddDocument_FormClosed(object sender, FormClosedEventArgs e)
        {
            _main.RefreshDocumentGridFull();
            //_main.SelectClass(Convert.ToInt32(selectedClass));
            if (_ctrlHost != null)
            {
                _ctrlHost.Dispose();
                _ctrlHost = null;
            }
            if (viewer != null)
            {
                viewer.Dispose();
                viewer = null;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
