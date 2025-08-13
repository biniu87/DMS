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
    public partial class frmContentManager : Form
    {
        public static Logger _logger = LogManager.GetCurrentClassLogger();
        private DataShare _ds;
        private ErrorProvider _errorProvider = new ErrorProvider();
        private Document_Class _loadedClass;
        private Document_DefinitionPerClass _loadedDefinitionPerClass;
        private Document_Definitions _loadedDefinition;
        private ToolTip _ttEditClass;
        private ToolTip _ttEditDefinition;

        private bool _isNewClass = false; //rozwojowo - możliwość użycia po zaimplementowaniu tworzenia klas w tej sekcji
        private bool _isNewDefinitionPerClass = false;
        private bool _isChanged = false;

        private bool _canReloadSelectedItems = false;
        private bool _canEdit = false;
        private bool _canDelete = false;

        //private string _tempListValues = string.Empty;

        public frmContentManager(DataShare ds)
        {
            _ds = ds;
            InitializeComponent();
        }

        #region Methods

        public int GetSelectedClassId()
        {
            return GetSelectedIdFromItem(cbClass.SelectedItem);
            //try
            //{
            //    if (cbClass.SelectedIndex >= 0)
            //    {
            //        DataRowView view = (DataRowView)cbClass.SelectedItem;
            //        ITDataSet.Document_ClassRow altairRow = (ITDataSet.Document_ClassRow)view.Row;
            //        return ((ITDataSet.Document_ClassRow)view.Row).Id;
            //        //return ((DocumentsManagerRU.ITDataSet.Document_ClassRow)this.iTDataSet.Document_Class.Rows[cbClass.SelectedIndex]).Id;
            //    }
            //    else
            //        return -1;
            //}
            //catch (Exception)
            //{
            //    return -1;
            //}
        }

        public int GetSelectedDefinitionId()
        {
            return GetSelectedIdFromItem(cbExistingDefinitions.SelectedItem);
        }

        public int GetSelectedDefinionPerClassId()
        {
            int result = GetSelectedIdFromItem(cbDocumentDefinitionsPerClass.SelectedItem);
            return result;
        }

        public int GetSelectedDataType()
        {
            if(cbDocumentDataType.SelectedIndex > -1)
            {
                DataRowView view = (DataRowView)cbDocumentDataType.SelectedItem;
            }
            int result = -1;
            var item = cbDocumentDataType.SelectedItem;
            try
            {
                if (item is DataRowView)
                {
                    DataRowView view = (DataRowView)item;
                    item = view.Row;
                    var value = view["TypeValue"];
                    Int32.TryParse(value.ToString(), out result);
                }
                if (item is ITDataSet.Document_DataTypes_EnumRow)
                {
                    result = ((ITDataSet.Document_DataTypes_EnumRow)item).TypeValue;
                }
            }
            catch (Exception)
            {
            }
            return result;
        }

        private void SetSelectedDataType(int dataType)
        {
            cbDocumentDataType.SelectedValue = dataType;
            //string dataTypeName = itda
            //DataRowView view = (DataRowView)cbClass.SelectedItem;
            //ITDataSet.Document_ClassRow altairRow = (ITDataSet.Document_ClassRow)view.Row;
            //int idValue = ((ITDataSet.Document_ClassRow)view.Row).Id;
        }

        public int GetSelectedIdFromItem(object cbSelectedItem)
        {
            int result = -1;
            var item = cbSelectedItem;
            try
            {
                if (item is DataRowView)
                {
                    DataRowView view = (DataRowView)cbSelectedItem;
                    item = view.Row;
                    var value = view["Id"];
                    Int32.TryParse(value.ToString(), out result);
                }
                else if (item is ITDataSet.Document_ClassRow)
                {
                    result = ((ITDataSet.Document_ClassRow)item).Id;
                }
            }
            catch (Exception)
            {
            }
            return result;
        }

        private void SetClassUIToEdit(bool edit)
        {
            if (edit)
            {
                this.chkEditClass.Image = DocumentsManagerRU.Properties.Resources.circle_x_2x;
                _ttEditClass.RemoveAll();//najpierw trzeba usunąć poprzednie powiązanie
                _ttEditClass = Data.SetToolTip(this.chkEditClass, _ds.LocRM.GetString("btnCancel"));
                chkEditClass.Text = _ds.LocRM.GetString("btnCancel");
            }
            else
            {
                this.chkEditClass.Image = DocumentsManagerRU.Properties.Resources.pencil_2x;
                _ttEditClass.RemoveAll();//najpierw trzeba usunąć poprzednie powiązanie
                _ttEditClass = Data.SetToolTip(this.chkEditClass, _ds.LocRM.GetString("lblEdit"));
                chkEditClass.Text = _ds.LocRM.GetString("lblEdit");
            }
            txtClassName.ReadOnly = !(edit && _canEdit);
            txtClassNameRU.ReadOnly = !(edit && _canEdit);
            txtClassDescription.ReadOnly = !(edit && _canEdit);
            txtClassDescriptionRU.ReadOnly = !(edit && _canEdit);
            ercClassActive.Enabled = edit && _canDelete;
            cbClass.Enabled = !edit;
            cbDocumentDefinitionsPerClass.Enabled = !(edit && _canEdit);
            btnDeleteClass.Enabled = !(edit && _canEdit);
            btnSaveClass.Enabled = edit && _canEdit;
            SetClassEditButtons(edit);
        }

        private void SetDefinitionUIToEdit(bool edit)
        {
            if (edit)
            {
                this.chkEditDefinition.Image = DocumentsManagerRU.Properties.Resources.circle_x_2x;
                _ttEditDefinition.RemoveAll(); //najpierw trzeba usunąć poprzednie powiązanie
                _ttEditDefinition = Data.SetToolTip(this.chkEditDefinition, _ds.LocRM.GetString("btnCancel"));
                chkEditDefinition.Text = _ds.LocRM.GetString("btnCancel");
            }
            else
            {
                this.chkEditDefinition.Image = DocumentsManagerRU.Properties.Resources.pencil_2x;
                _ttEditDefinition.RemoveAll(); //najpierw trzeba usunąć poprzednie powiązanie
                _ttEditDefinition = Data.SetToolTip(this.chkEditDefinition, _ds.LocRM.GetString("lblEdit"));
                chkEditDefinition.Text = _ds.LocRM.GetString("lblEdit");
            }
            cbDocumentDefinitionsPerClass.Enabled = !(edit && _canEdit);
            cbExistingDefinitions.Enabled = edit && IsDefinitionPerClassNew() && _canEdit;
            //zaznaczenie zależne także od tego czy definicja jest nowa, czy istniejąca
            txtDefinitionList.ReadOnly = !(GetSelectedDataType() == (int)Data.IndexTypes.SimpleList && edit && _canEdit);
            dtpDefinitionDefault.Enabled = cbDefinitionDefault.Enabled = edit && _canEdit;
            cbDocumentDataType.Enabled = false; // edit && IsDefinitionPerClassNew() && _canEdit; //zawsze nieaktywne
            txtDefinitionNamePL.ReadOnly = true; // !(edit && _canEdit); //zawsze niekatywny
            txtDefinitionNameRU.ReadOnly = true; // !(edit && _canEdit);
            txtDefinitionDescriptionPL.ReadOnly = true; // !(edit && _canEdit);
            txtDefinitionDescriptionRU.ReadOnly = true; // !(edit && _canEdit);
            txtDefinitionList.ReadOnly = true;
            ercRequired.Enabled = edit && _canEdit;
            ercDefinitionActive.Enabled = edit && _canDelete;
            SetReadOnlyDefaultValueComponents();
            cbClass.Enabled = !edit;
            SetDefinitionPerClassEditButtons(edit);
        }

        public void SetClassEditButtons(bool edit, bool forceDisable = false)
        {
            if (forceDisable)
            {
                btnDeleteClass.Enabled = false;
                btnSaveClass.Enabled = false;
                chkEditClass.Enabled = false;
                chkEditClass.FlatAppearance.CheckedBackColor = _ds.ColorLayout.COLOR_OBJECTS;
            }
            else
            {
                bool permitt = _loadedClass.Id > 0 || _isNewClass;
                btnDeleteClass.Enabled = chkEditClass.Checked && permitt && !edit && _canDelete;
                btnSaveClass.Enabled = !chkEditClass.Checked && permitt && edit;
                SetDefinitionPerClassEditButtons(!edit, true);
                if(!edit)
                    ActualizeEditPossibility();
            }
        }

        public void SetDefinitionPerClassEditButtons(bool edit, bool forceDisable = false)
        {
            if (forceDisable)
            {
                btnDeleteDefinition.Enabled = false;
                btnSaveDefinition.Enabled = false;
                chkEditDefinition.Enabled = false;
                btnAddDefinition.Enabled = false;
                chkEditDefinition.FlatAppearance.CheckedBackColor = _ds.ColorLayout.COLOR_OBJECTS;
            }
            else
            {
                bool permitt = _loadedDefinitionPerClass != null || _isNewDefinitionPerClass;
                bool classExist = (_loadedClass != null && _loadedClass.Id > 0);
                btnDeleteDefinition.Enabled = chkEditDefinition.Checked && permitt && !edit;
                btnAddDefinition.Enabled = chkEditDefinition.Checked && !edit && classExist;
                btnSaveDefinition.Enabled = !chkEditDefinition.Checked && permitt && edit;

                SetClassEditButtons(!edit, true);
                if (!edit)
                    ActualizeEditPossibility();
            }
        }

        public void ActualizeEditPossibility()
        {
            if (_loadedClass.Id > 0 || _isNewClass)
            {
                chkEditClass.Enabled = _canEdit || _canDelete;
                btnDeleteClass.Enabled = _canDelete;
                chkEditClass.FlatAppearance.CheckedBackColor = _ds.ColorLayout.COLOR_SELECTED;
                btnAddDefinition.Enabled = true;
            }
            else
            {
                chkEditClass.Enabled = false;
                btnDeleteClass.Enabled = false;
                chkEditClass.FlatAppearance.CheckedBackColor = _ds.ColorLayout.COLOR_OBJECTS;
            }
            if ((_loadedDefinitionPerClass != null && _loadedDefinitionPerClass.Id > 0) || _isNewDefinitionPerClass)
            {
                chkEditDefinition.Enabled = _canEdit || _canDelete;
                btnDeleteDefinition.Enabled = _canDelete;
                chkEditDefinition.FlatAppearance.CheckedBackColor = _ds.ColorLayout.COLOR_SELECTED;
            }
            else
            {
                chkEditDefinition.Enabled = false;
                btnDeleteDefinition.Enabled = false;
                chkEditDefinition.FlatAppearance.CheckedBackColor = _ds.ColorLayout.COLOR_OBJECTS;
            }
        }

        public void LoadClassList()
        {
            this.taDocumentClass.FillToReadRelease(this.iTDataSet.Document_Class, _ds.Language, Security.SecurityObjects,
                (int)Permissions.ClassPrimaryPermissions.Edit, (int)Permissions.ClassSecondaryPermissions.AdminPermissions);
            cbClass.DisplayMember = "CurrentName";
            cbClass.ValueMember = "Id";
            lblClassCount.Text = "(" + cbClass.Items.Count.ToString() + ")";
            LoadDefinitionPerClassListBySelectedClass();
        }

        public void LoadSelectedClassContent()
        {
            //DataRowView view = (DataRowView)cbClass.SelectedItem;
            //ITDataSet.Document_ClassRow altairRow = (ITDataSet.Document_ClassRow)view.Row;
            //int idValue = ((ITDataSet.Document_ClassRow)view.Row).Id;
            LoadClassContent(GetSelectedClassId());
        }

        public void LoadSelectedDefinitionContent()
        {
            int id = GetSelectedIdFromItem(cbExistingDefinitions.SelectedItem);
            LoadDefinitionContent(id);
        }

        public void SetSelectedDefinitionById(int definitionId)
        {
            cbExistingDefinitions.SelectedValue = definitionId;
        }

        public void LoadDefinitionContent(int contentId)
        {
            if (contentId < 0)
            {
                //czyszczenie pól, gdy nie zaznaczono definicji
                SetSelectedDataType(-1);
                txtDefinitionNamePL.Text = "";
                txtDefinitionNameRU.Text = "";
                txtDefinitionDescriptionPL.Text = "";
                txtDefinitionDescriptionRU.Text = "";
                txtDefinitionList.Text = "";
                cbDefinitionDefault.DataSource = null;
                lblDefaultListCount.Text = "(0)";
                dgvListItems.DataSource = null;
                //bsDocumentDefinitionListItems = new BindingSource();
            }
            else
            {
                //_loadedDefinition = Data.GetDocumentDefinitionById(contentId);
                SetSelectedDataType(_loadedDefinition.DataType.Value);
                txtDefinitionNamePL.Text = _loadedDefinition.Name_PL;
                txtDefinitionNameRU.Text = _loadedDefinition.Name_RU;
                txtDefinitionDescriptionPL.Text = _loadedDefinition.Description_PL;
                txtDefinitionDescriptionRU.Text = _loadedDefinition.Description_RU;
                txtDefinitionList.Lines = _loadedDefinition.GetParsedItems();
                if (_loadedDefinition.DataType == (int)Data.IndexTypes.List)
                {
                    dgvListItems.DataSource = bsDocumentDefinitionListItems;
                    bsDocumentDefinitionListItems.DataMember = "GetDocumentDefinitionListItems";
                    bsDocumentDefinitionListItems.DataSource = iTDataSet;
                    taDocumentDefinitionListItems.Fill(iTDataSet.GetDocumentDefinitionListItems, _loadedDefinition.Id);
                }
                else
                {
                    dgvListItems.DataSource = null;
                }
                SetDefaultSource();
            }
            //zaleca się dorzucić jeszcze wczytywanie rekordów listy rozszerzonej
        }

        public void SetDefaultSource()
        {
            //ustawienie źródła pola default w zależności od typu
            if (_loadedDefinition != null)
            {
                if (_loadedDefinition.DataType == (int)Data.IndexTypes.SimpleList)
                {
                    cbDefinitionDefault.DataSource = _loadedDefinition.GetItemsDictionary();
                    lblDefaultListCount.Text = "(" + cbDefinitionDefault.Items.Count + ")";
                }
                else if (_loadedDefinition.DataType == (int)Data.IndexTypes.List)
                {
                    cbDefinitionDefault.DataSource = _loadedDefinition.GetAdvancedListDictionary();
                    lblDefaultListCount.Text = "(" + cbDefinitionDefault.Items.Count + ")";
                }
                else
                {
                    cbDefinitionDefault.DataSource = null;
                    lblDefaultListCount.Text = "(0)";
                }
            }
        }

        public void LoadDefinitionList()
        {
            this.taDocumentDefinitionsByDirective.Fill(this.iTDataSet.GetDocumentDefinitionsByDirective, _ds.Language, GetSelectedClassId(), (int)Data.DefinitionDirectives.All);
            cbExistingDefinitions.DisplayMember = "Name";
            cbExistingDefinitions.ValueMember = "Id";
            cbExistingDefinitions.SelectedIndex = -1;
            lblDefinitionCount.Text = "(" + cbExistingDefinitions.Items.Count.ToString() + ")";
        }

        public void LoadClassContent(int classId)
        {
            _loadedClass = Data.GetClassById(classId);
            if (_loadedClass != null && classId > 0)
            {
                txtClassName.Text = _loadedClass.Name;
                txtClassNameRU.Text = _loadedClass.Name_RU;
                txtClassDescription.Text = _loadedClass.Description;
                txtClassDescriptionRU.Text = _loadedClass.Description_RU;
                ercClassActive.Checked = _loadedClass.Active.HasValue ? _loadedClass.Active.Value : false;
            }
            else
            {
                txtClassName.Text = "";
                txtClassNameRU.Text = "";
                txtClassDescription.Text = "";
                txtClassDescriptionRU.Text = "";
                ercClassActive.Checked = false;
            }
            ActualizeEditPossibility();
        }

        public void LoadDataTypesCB()
        {
            try
            {
                taDocumentDataTypes.FillDataTypesByLanguage(iTDataSet.GetDocumentDataTypes, _ds.Language);
                cbDocumentDataType.SelectedIndex = -1;
            }
            catch (Exception)
            {
            }
        }

        public void LoadDefinitionPerClassListBySelectedClass()
        {
            // tu wystąpił ostatnio błąd, definicje były nulem
            var id = GetSelectedClassId();
            if(id > 0)
                this.taDocumentDefinitionsPerClass.Fill(this.iTDataSet.GetDocumentDefinitionsForClass, _ds.Language, id);
            cbDocumentDefinitionsPerClass.DisplayMember = "Name";
            cbDocumentDefinitionsPerClass.ValueMember = "Id";
            cbDocumentDefinitionsPerClass.SelectedIndex = -1;
            lblDefinitionPerClassCount.Text = "(" + cbDocumentDefinitionsPerClass.Items.Count.ToString() + ")";
        }

        public void LoadDefinitionPerClassContent()
        {
            int definitionPerClassId = GetSelectedDefinionPerClassId();
            _loadedDefinitionPerClass = Data.GetDocumentDefinitionPerClassById(definitionPerClassId);
            if (definitionPerClassId > 0 && _loadedDefinitionPerClass != null)
            {
                if (_loadedDefinitionPerClass.DefinitionId > 0 && (_loadedDefinition == null || _loadedDefinition.Id != _loadedDefinitionPerClass.DefinitionId))
                    //_loadedDefinition = _loadedDefinitionPerClass.Document_Definitions;
                    _loadedDefinition = Data.GetDocumentDefinitionById(_loadedDefinitionPerClass.Document_Definitions.Id);
                SetSelectedDefinitionById(_loadedDefinition.Id);                                                     
                if (_loadedDefinitionPerClass.IsRequired.HasValue)
                    ercRequired.Checked = _loadedDefinitionPerClass.IsRequired.Value;
                if (_loadedDefinitionPerClass.Active.HasValue)
                    ercDefinitionActive.Checked = _loadedDefinitionPerClass.Active.Value;
                SetDefaultValue(_loadedDefinitionPerClass.DefaultValue, GetSelectedDataType()); //ustawianie wymagalności zmieni wartość!!!!!!!!!!!!!
            }
            else
            {
                ClearDefinitionPerClass();
            }
            ActualizeEditPossibility();
            ActualizeEnableListCards();
        }

        private void ActualizeEnableListCards()
        {
            if(_loadedDefinition != null && _loadedDefinition.DataType != null)
            {
                int type = int.Parse(_loadedDefinition.DataType.ToString());
                if (type == (int) Data.IndexTypes.SimpleList) 
                {
                    //usuwamy zaawansowaną
                    if (tcDefinition.TabPages.Contains(pcAdvancedList))
                        tcDefinition.TabPages.Remove(pcAdvancedList);
                    //dodajemy prostą
                    if (!tcDefinition.TabPages.Contains(pcSimpleList))
                        tcDefinition.TabPages.Add(pcSimpleList);
                }
                else if (type == (int)Data.IndexTypes.List)
                {
                    //usuwamy prostą
                    if (tcDefinition.TabPages.Contains(pcSimpleList))
                        tcDefinition.TabPages.Remove(pcSimpleList);
                    //dodajemy zaawansowaną
                    if (!tcDefinition.TabPages.Contains(pcAdvancedList))
                        tcDefinition.TabPages.Add(pcAdvancedList);
                }
                else
                {
                    //usuwamy obie
                    if (tcDefinition.TabPages.Contains(pcAdvancedList))
                        tcDefinition.TabPages.Remove(pcAdvancedList);
                    if (tcDefinition.TabPages.Contains(pcSimpleList))
                        tcDefinition.TabPages.Remove(pcSimpleList);
                }
            }
                
        }

        public void ClearDefinitionPerClass()
        {
            _loadedDefinitionPerClass = null;
            cbDocumentDefinitionsPerClass.Text = "";
            SetSelectedDefinitionById(-1);
            //_tempListValues = ""; // zerowanie tempa
            ercRequired.Checked = false;
            ercDefinitionActive.Checked = true;
            SetDefaultValue("", -1);
        }

        public void ChangeSelectedClass()
        {
            SetPermissionsToClass();
            LoadDefinitionPerClassListBySelectedClass();
            //LoadDataTypesCB();
            LoadSelectedClassContent();
            ActualizeEditPossibility();
        }

        private bool ValidateFormClass()
        {
            _errorProvider.Clear();
            if (txtClassName.Visible && string.IsNullOrEmpty(txtClassName.Text))
            {
                _errorProvider.SetError(txtClassName, _ds.LocRM.GetString("msg5")); //"Musisz podać nazwę dla klasy!"
                return false;
            }
            else if (txtClassNameRU.Visible && string.IsNullOrEmpty(txtClassNameRU.Text))
            {
                _errorProvider.SetError(txtClassNameRU, _ds.LocRM.GetString("msg10")); //Musisz podać nazwę dla klasy w języku rosyjskim!
                return false;
            }
            else if (txtClassName.Visible && (txtClassName.Text != _loadedClass.Name && Data.IsClassNameExistInDatabase(txtClassName.Text)))
            {
                _errorProvider.SetError(txtClassName, _ds.LocRM.GetString("msg06")); //Podana nazwa dla klasy dokumentów już jest w użyciu!
                return false;
            }
            else if (txtClassNameRU.Visible && (txtClassNameRU.Text != _loadedClass.Name_RU && Data.IsClassNameRUExistInDatabase(txtClassNameRU.Text)))
            {
                _errorProvider.SetError(txtClassNameRU, _ds.LocRM.GetString("msg11")); //Podana nazwa dla klasy dokumentów w języku rosyjskim już jest w użyciu!
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidateFormDefinition() // poszerzyć walidację
        {
            //int selectedType = GetSelectedDataType();
            _errorProvider.Clear();
            int selectedType = GetSelectedDataType();
            if ((selectedType < 0))
            {
                _errorProvider.SetError(cbExistingDefinitions, _ds.LocRM.GetString("msg31")); //Musisz wybrać definicję indeksu
                return false;
            }
            else
                return true;// ValidateDefaultDefinitionFields();
        }

        public bool ValidateDefaultDefinitionFields()
        {
            if (ercRequired.Checked)
            {
                int selectedType = GetSelectedDataType();
                //if ((selectedType == (int)Data.IndexTypes.Number || selectedType == (int)Data.IndexTypes.String) && string.IsNullOrEmpty(txtDefinitionDefault.Text))
                //{
                //    _errorProvider.SetError(txtDefinitionDefault, _ds.LocRM.GetString("msg09")); //Musisz podać wartość domyślną (dla tekstu i liczby)
                //    return false;
                //}
                //else if ((selectedType == (int)Data.IndexTypes.List || selectedType == (int)Data.IndexTypes.SimpleList) && string.IsNullOrEmpty(cbDefinitionDefault.Text))
                //{
                //    _errorProvider.SetError(cbDefinitionDefault, _ds.LocRM.GetString("msg09")); ///Musisz podać wartość domyślną (dla obu typów list)
                //    return false;
                //}
                //else 
                    if (selectedType == (int)Data.IndexTypes.Number)
                {
                    //typ indeksu liczbowego
                    decimal val;
                    bool success = decimal.TryParse(txtDefinitionDefault.Text.Replace(" ", "").Replace(",", "."), out val);
                    if (!success)
                    {
                        _errorProvider.SetError(txtDefinitionDefault, _ds.LocRM.GetString("msg17")); //Podany ciąg nie spełnia regół formatowania
                        return false;
                    }
                }
                //else if (selectedType == (int)Data.IndexTypes.List && cbDefinitionDefault.Items.Count > 0 && cbDefinitionDefault.SelectedIndex < 0)
                //{
                //    _errorProvider.SetError(cbDefinitionDefault, _ds.LocRM.GetString("msg09")); //Musisz podać wartość domyślną
                //    return false;
                //}
            }
            return true;
        }

        public void SetPermissionsToClass()
        {
            var id =  GetSelectedClassId();
            var permissions = Permissions.GetPermissionsVector(id, Security.SecurityObjects);
            if (Security.Admin)
            {
                _canDelete = _canEdit = true;
            }
            else
            {
                _canEdit = _canDelete = false;
                if (permissions.PrimaryPermission >= Permissions.ClassPrimaryPermissions.Delete)
                {
                    _canDelete = _canEdit = true;
                }
                else if (permissions.PrimaryPermission >= Permissions.ClassPrimaryPermissions.Edit)
                {
                    _canEdit = true;
                }

            }
        }

        public void DeleteClass()
        {
            string txt = string.Format("{0}: {1}", _ds.LocRM.GetString(DialogBox.OBJECT_CLASS), cbClass.Text);
            DialogResult dialogResult = DialogBox.ShowDialog(txt, _ds.LocRM.GetString(DialogBox.MESSAGE_DELETE),
                _ds, MessageBoxButtons.YesNo, DialogBox.Icons.Question); // czy usunąć?
            if (dialogResult == DialogResult.Yes)
            {
                int classId = GetSelectedClassId();
                if(classId < 1) return;
                _canReloadSelectedItems = false;
                bool result = Data.DeleteClassProcess(classId);
                if (result)
                {
                    DialogBox.ShowDialog(_ds.LocRM.GetString(DialogBox.MESSAGE_SUCCESS), _ds.LocRM.GetString(DialogBox.ACTION_DELETE),
                        _ds, MessageBoxButtons.OK, DialogBox.Icons.Success); // sukces
                    LoadClassList();
                    _canReloadSelectedItems = true;
                    cbClass.SelectedIndex = cbClass.Items.Count > 0 ? 0 : -1;
                    LoadSelectedClassContent();
                    ChangeSelectedClass();
                    _ds.RefreshData();
                }
                else
                {
                    _canReloadSelectedItems = true;
                    DialogBox.ShowDialog(_ds.LocRM.GetString(DialogBox.MESSAGE_FAILED), _ds.LocRM.GetString(DialogBox.ACTION_DELETE),
                        _ds, MessageBoxButtons.OK, DialogBox.Icons.Error);
                }
            }
        }

        public void DeleteDefinitionPerClass()
        {
            string txt = string.Format("{0}: {1}", _ds.LocRM.GetString(DialogBox.OBJECT_DEFINITIONPERCLASS), cbDocumentDefinitionsPerClass.Text);
            DialogResult dialogResult = DialogBox.ShowDialog(txt, _ds.LocRM.GetString(DialogBox.MESSAGE_DELETE), _ds, MessageBoxButtons.YesNo, DialogBox.Icons.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int definitionId = GetSelectedDefinionPerClassId();
                if (definitionId < 1) return;
                bool result = Data.DeleteDocumentIndexDefinitionPerClass(definitionId);
                if (result)
                {
                    DialogBox.ShowDialog(_ds.LocRM.GetString(DialogBox.MESSAGE_SUCCESS), _ds.LocRM.GetString(DialogBox.ACTION_DELETE),
                        _ds, MessageBoxButtons.OK, DialogBox.Icons.Success);
                    _canReloadSelectedItems = false;
                    LoadDefinitionPerClassListBySelectedClass();
                    _canReloadSelectedItems = true;
                    cbDocumentDefinitionsPerClass.SelectedIndex = cbDocumentDefinitionsPerClass.Items.Count > 0 ? cbDocumentDefinitionsPerClass.Items.Count - 1 : -1;
                    LoadDefinitionPerClassContent();
                    _ds.RefreshData();
                }
                else
                {
                    DialogBox.ShowDialog(_ds.LocRM.GetString(DialogBox.MESSAGE_FAILED), _ds.LocRM.GetString(DialogBox.ACTION_DELETE),
                        _ds, MessageBoxButtons.OK, DialogBox.Icons.Error);
                }
            }
        }

        public bool SaveClass()
        {
            bool result = false;
            if (ValidateFormClass() && IsClassModified())
            {
                int classId = GetSelectedClassId();
                result = Data.UpdateDocumentClass(classId, txtClassName.Text, txtClassNameRU.Text, txtClassDescription.Text, txtClassDescriptionRU.Text, ercClassActive.Checked);
            }
            else if (IsClassNew())
            {
                //w przypadku, gdybyśmy mogli tworzyć już nowe klasy
            }
            else
            {
                chkEditClass.Checked = result;
            }
            if (result)
            {
                CheckChanges();
                ActualizeLoadedClass();
                _isChanged = true;
            }
            chkEditClass.Checked = result;
            return result;
        }

        public bool SaveDefinitionPerClass()
        {
            bool result = false;
            if (ValidateFormDefinition())
            {
                //resetowanie pola default, gdy niewymagane
                if (!ercRequired.Checked)
                    txtDefinitionDefault.Text = string.Empty;
                if (IsDefinitionPerClassNew())
                {
                    int classId = GetSelectedIdFromItem(cbClass.SelectedItem);
                    int definitionId = GetSelectedDefinitionId();
                    var defaultValue = GetDefaultValue();
                    result = Data.AddNewDocumentDefinitionPerClass(classId, definitionId, ercRequired.Checked, ercDefinitionActive.Checked, defaultValue);
                    if (result)
                    {
                        DialogBox.ShowDialog(_ds.LocRM.GetString(DialogBox.MESSAGE_SUCCESS), _ds.LocRM.GetString(DialogBox.ACTION_CREATE),
                            _ds, MessageBoxButtons.OK, DialogBox.Icons.Success);
                    }
                    else
                    {
                        DialogBox.ShowDialog(_ds.LocRM.GetString(DialogBox.MESSAGE_FAILED), _ds.LocRM.GetString(DialogBox.ACTION_CREATE),
                            _ds, MessageBoxButtons.OK, DialogBox.Icons.Error);
                    }
                }
                else if(IsDefinitionForClassModified())
                {
                    var defaultValue = GetDefaultValue();
                    result = Data.UpdateDefinitionIndexPerClass(_loadedDefinitionPerClass.Id, ercRequired.Checked, ercDefinitionActive.Checked, defaultValue);
                }
                if (result)
                {
                    //zapis zakończony sukcesem
                    CheckChanges();
                    SetDefinitionUIToEdit(!chkEditDefinition.Checked);
                    ActualizeLoadedDefinitionPerClass();
                    _isChanged = true;
                }
                else if (!IsDefinitionForClassModified())
                {
                    SetDefinitionUIToEdit(!chkEditDefinition.Checked);
                    result = true;
                }
                chkEditDefinition.Checked = result;
            }
            return result;
        }

        public void CancelEditClass()
        {
            _errorProvider.Clear();
            if (_loadedClass == null) return;
            txtClassName.Text = _loadedClass.Name;
            txtClassNameRU.Text = _loadedClass.Name_RU;
            txtClassDescription.Text = _loadedClass.Description;
            txtClassDescriptionRU.Text = _loadedClass.Description_RU;
            ercClassActive.Checked = _loadedClass.Active.Value;
            _errorProvider.Clear();
        }

        public void CancelEditDefinitionPerClass()
        {
            //wszystkie pola przyjmują wartość domyślną z obiektu w pamięci
            _errorProvider.Clear();
            _isNewDefinitionPerClass = false;
            if (_loadedDefinitionPerClass == null || _loadedDefinitionPerClass.Id < 0) return;
            SetSelectedDefinitionById(_loadedDefinitionPerClass.DefinitionId); //zawartość zaktualizuje się sama
            if (_loadedDefinitionPerClass.IsRequired.HasValue)
                ercRequired.Checked = _loadedDefinitionPerClass.IsRequired.Value;
            if (_loadedDefinitionPerClass.Active.HasValue)
                ercDefinitionActive.Checked = _loadedDefinitionPerClass.Active.Value;
            SetDefaultValue(_loadedDefinitionPerClass.DefaultValue, GetSelectedDataType());

            //SetSelectedDataType((int)_loadedDefinitionPerClass.DataType.Value);
            //cbDefinitionDefault.DataSource = _loadedDefinition.GetItemsDictionary();
            //_tempListValues = txtDefinitionList.Text; // zapis nowej zawartości do tempa
            //
            //SetDefaultValue(_loadedDefinition.DefaultValue, GetSelectedDataType());
            //txtDefinitionDefault.Text = _loadedDefinition.DefaultValue;
        }

        public void CheckChanges()
        {
            //zachować kolejność sprawdzania
            //sprzawdzanie czy zaktualizowano informacje wymagające przeładowywania danych z bazy
            if (!chkEditClass.Checked && (_loadedClass.Name == txtClassName.Text || _loadedClass.Name_RU == txtClassNameRU.Text)) //sprawdzanie czy zmieniono nazwę klasy
            {
                var id = GetSelectedClassId();
                //string tempClassName = txtClassName.Text;
                _canReloadSelectedItems = false;
                LoadClassList();
                _canReloadSelectedItems = true;
                cbClass.SelectedValue = id;
            }
            else if (IsDefinitionPerClassNew()) //sprawdzanie czy stworzono nową definicję na klasę
            {
                _canReloadSelectedItems = false;
                LoadClassContent(_loadedClass.Id); //odświeżenie klasy spowoduje zaciągnięcie z bazy stworzonej definicji
                LoadDefinitionPerClassListBySelectedClass();
                _canReloadSelectedItems = true;
                cbDocumentDefinitionsPerClass.SelectedIndex = cbDocumentDefinitionsPerClass.Items.Count - 1;
            }

            _isNewClass = false;
            _isNewDefinitionPerClass = false;
        }

        private bool IsClassModified()
        {
            return _loadedClass.Name != txtClassName.Text ||
                _loadedClass.Description != txtClassDescription.Text ||
                _loadedClass.Name_RU != txtClassNameRU.Text ||
                _loadedClass.Description_RU != txtClassDescriptionRU.Text ||
                _loadedClass.Active != ercClassActive.Checked;
        }

        private bool IsDefinitionForClassModified()
        {
            bool mod = (_loadedDefinitionPerClass != null &&(
                _loadedDefinitionPerClass.Active != ercDefinitionActive.Checked ||
                _loadedDefinitionPerClass.IsRequired != ercRequired.Checked ||
                _loadedDefinitionPerClass.DefaultValue != GetDefaultValue()

            ));
            return mod;
        }

        public bool IsClassNew()
        {
            return _isNewClass;
        }

        public bool IsDefinitionPerClassNew()
        {
            return _isNewDefinitionPerClass;
        }

        public void ActualizeLoadedClass()
        {
            if(_loadedClass == null)
                return;
            _loadedClass.Name = txtClassName.Text;
            _loadedClass.Name_RU = txtClassNameRU.Text;
            _loadedClass.Description = txtClassDescription.Text;
            _loadedClass.Description_RU = txtClassDescriptionRU.Text;
            _loadedClass.Active = ercClassActive.Checked;
        }

        public void ActualizeLoadedDefinitionPerClass()
        {
            if (_loadedDefinitionPerClass == null) return;
            var id = GetSelectedDefinionPerClassId();
            _loadedDefinitionPerClass = Data.GetDocumentDefinitionPerClassById(id);
        }

        #endregion

        #region Events

        private void frmContentManager_Load(object sender, EventArgs e)
        {
            LoadClassList();
            LoadSelectedClassContent();
            LoadDataTypesCB();
            LoadDefinitionList();
            LoadDefinitionPerClassListBySelectedClass();
            SetPermissionsToClass();
            Data.SetToolTip(this.btnSaveClass, _ds.LocRM.GetString("lblSaveClass"));
            _ttEditClass = Data.SetToolTip(this.chkEditClass, _ds.LocRM.GetString("lblEdit")); //będzie zmieniany
            _ttEditDefinition = Data.SetToolTip(this.chkEditDefinition, _ds.LocRM.GetString("lblEdit")); //będzie zmieniany
            _canReloadSelectedItems = true;
            SetClassUIToEdit(false);
            SetDefinitionUIToEdit(false);
            SetDefinitionPerClassEditButtons(false);
            //SetReadOnlyDefaultValueComponents(true);
            SetVisibleDefaultValueComponents();
            if (cbDocumentDefinitionsPerClass.Items.Count > 0)
            {
                cbDocumentDefinitionsPerClass.SelectedIndex = 0;
            }
        }

        private void chkEditClass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEditClass.Checked)
            {
                CancelEditClass();
            }
            SetClassUIToEdit(!chkEditClass.Checked);
        }

        private void chkEditDefinitions_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEditDefinition.Checked)
            {
                CancelEditDefinitionPerClass();
            }
            SetDefinitionUIToEdit(!chkEditDefinition.Checked);
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_canReloadSelectedItems)
                ChangeSelectedClass();
        }

        private void cbDocumentDefinitions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_canReloadSelectedItems)
                LoadDefinitionPerClassContent();
        }

        private void btnSaveClass_Click(object sender, EventArgs e)
        {
            SaveClass();
        }

        private void btnSaveDefinitions_Click(object sender, EventArgs e)
        {
            SaveDefinitionPerClass();
        }

        #endregion

        private void btnDeleteDefinitions_Click(object sender, EventArgs e)
        {
            DeleteDefinitionPerClass();
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            DeleteClass();
        }

        private void btnAddDefinition_Click(object sender, EventArgs e)
        {
            _isNewDefinitionPerClass = true;
            cbDocumentDefinitionsPerClass.SelectedIndex = -1;
            LoadDefinitionPerClassContent();
            chkEditDefinition.Checked = false;
        }

        private void chkRequired_CheckedChanged(object sender, EventArgs e)
        {
            bool readOnly = !(ercRequired.Checked && !chkEditDefinition.Checked);
            if (readOnly)
            {
                cbDefinitionDefault.SelectedIndex = -1;
                txtDefinitionDefault.Text = string.Empty;
            }
            SetReadOnlyDefaultValueComponents(readOnly);
        }

        public void SetReadOnlyDefaultValueComponents(bool? ReadOnly = null)
        {
            bool ro;
            if (ReadOnly.HasValue)
            {
                ro = ReadOnly.Value;
            }
            else
            {
                ro = !(ercRequired.Checked && !chkEditDefinition.Checked);
            }
            txtDefinitionDefault.ReadOnly = ro;
            dtpDefinitionDefault.Enabled = !ro;
            cbDefinitionDefault.Enabled = !ro;
        }

        private void cbDocumentDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetVisibleDefaultValueComponents();
        }

        public void SetVisibleDefaultValueComponents()
        {
            //int dataType = GetSelectedDataType();
            //if (dataType != -1)
            //{
            //    bool readOnly = !(dataType == (int)Data.IndexTypes.List && !chkEditDefinition.Checked);
            //    txtDefinitionList.Read = readOnly;
            //    dtpDefinitionDefault.Visible = chkUseDateDefault.Visible = dataType == (int)Data.IndexTypes.Date;
            //    txtDefinitionDefault.Visible = dataType == (int)Data.IndexTypes.Number || dataType == (int)Data.IndexTypes.String;
            //    cbDefinitionDefault.Visible = lblDefaultListCount.Visible = (dataType == (int)Data.IndexTypes.List) || (dataType == (int)Data.IndexTypes.SimpleList);
            //}
            //else
            //{
            //    dtpDefinitionDefault.Visible = cbDefinitionDefault.Visible = false;
            //    txtDefinitionDefault.Visible = txtDefinitionDefault.Read = true;
            //}
        }

        public string GetDefaultValue()
        {
            ////default jest zależny od pola określającego jego wymagalność
            //int selectedType = GetSelectedDataType();
            //if (ercRequired.Checked)
            //{
            //    if (selectedType == (int)Data.IndexTypes.Number)
            //    {
            //        //zabezpieczenie przed przyjęciem , - sql by to łyknął i był by potem problemiczek
            //        txtDefinitionDefault.Text = txtDefinitionDefault.Text.Replace(',', '.');
            //    }
            //    if (selectedType == (int)Data.IndexTypes.Date)
            //    {
            //        return chkUseDateDefault.Checked ? dtpDefinitionDefault.Value.ToShortDateString() : string.Empty;
            //    }
            //    else if ((selectedType == (int)Data.IndexTypes.SimpleList) || (selectedType == (int)Data.IndexTypes.List))
            //    {
            //        if (string.IsNullOrEmpty(cbDefinitionDefault.Text))
            //            return string.Empty;
            //        else
            //            return cbDefinitionDefault.Text;
            //    }
            //    else
            //    {
            //        if (string.IsNullOrEmpty(txtDefinitionDefault.Text))
            //            return string.Empty;
            //        else
            //            return txtDefinitionDefault.Text;
            //    }
            //}
            //else
            //{
            //    return string.Empty;
            //}
            return string.Empty;
            
        }

        public void SetDefaultValue(string value, int selectedType)
        {
            //if (selectedType == (int)Data.IndexTypes.Date)
            //{
            //    DateTime tmp;
            //    bool ok = DateTime.TryParse(value, out tmp);
            //    if (ok)
            //        dtpDefinitionDefault.Value = tmp;
            //    chkUseDateDefault.Checked = ok;
            //    cbDefinitionDefault.Text = string.Empty;
            //    txtDefinitionDefault.Text = string.Empty;
            //}
            //else if ((selectedType == (int)Data.IndexTypes.List) || (selectedType == (int)Data.IndexTypes.SimpleList))
            //{
            //    cbDefinitionDefault.Text = value;
            //    txtDefinitionDefault.Text = string.Empty;
            //}
            //else
            //{
            //    txtDefinitionDefault.Text = value;
            //    cbDefinitionDefault.Text = string.Empty;
            //}
        }

        private void frmContentManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isChanged)
                _ds.RefreshData(); //odświeżenie głównego okna
        }

        private void txtDefinitionList_Leave(object sender, EventArgs e)
        {
            //if (_tempListValues != txtDefinitionList.Text)
            //{
            //    //tutaj wykrywamy potrzebę aktualizacji listy
            //    //jeśli zmienił się obiekt listy, który wcześniej był wybany jako domyślny, wartość domyślna zostanie wyzerowana
            //    string tempDef = cbDefinitionDefault.Text;
            //    //cbDefinitionDefault.DataSource = Data.IndexAdvancedItemsDictionary(txtDefinitionList.Lines);
            //    _tempListValues = txtDefinitionList.Text;
            //    if(txtDefinitionList.Lines.Contains(tempDef))
            //    {
            //        cbDefinitionDefault.Text = tempDef;
            //    }
            //    else
            //    {
            //        cbDefinitionDefault.SelectedIndex = -1;
            //        //cbDefinitionDefault.Text = string.Empty;
            //    }
            //}
        }

        private void cbExistingDefinitions_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = GetSelectedDefinitionId();
            if (id < 1 || _loadedDefinition == null || _loadedDefinition.Id != id)
            {
                _loadedDefinition = Data.GetDocumentDefinitionById(id);
            }
            LoadSelectedDefinitionContent();
        }

        private void chkUseDateDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUseDateDefault.Checked)
                chkUseDateDefault.Image = DocumentsManagerRU.Properties.Resources.check_2x;
            else
                chkUseDateDefault.Image = DocumentsManagerRU.Properties.Resources.plus_2x;
            dtpDefinitionDefault.Enabled = chkUseDateDefault.Checked;
        }

    }
}
