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
using DocumentsManagerRU.View;
using NLog;

namespace DocumentsManagerRU
{
    public partial class frmDefinitionManager : Form
    {
        public static Logger _logger = LogManager.GetCurrentClassLogger();
        private DataShare _ds;
        private ErrorProvider _errorProvider = new ErrorProvider();
        private Document_Definitions _loadedDefinition;
        private ToolTip _ttEditDefinition;

        private bool _isNewClass = false; //rozwojowo - możliwość użycia po zaimplementowaniu tworzenia klas w tej sekcji
        private bool _isNewDefinition = false;
        private bool _isChanged = false;
        private bool _validateUniqueNames = false;

        private bool _canChangeSelectedDefinition = false;

        private string _tempListValues = string.Empty;

        private string messageError = "msg33";

        public frmDefinitionManager(DataShare ds)
        {
            _ds = ds;
            InitializeComponent();
        }

        #region Methods

        public int GetSelectedDefinionId()
        {
            int result = GetSelectedIdFromItem(cbDocumentDefinitions.SelectedItem);
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
            chkEditDefinition.Enabled = _loadedDefinition != null && _loadedDefinition.Id > 0;
            cbDocumentDefinitions.Enabled = !edit;
            //zaznaczenie zależne także od tego czy definicja jest nowa, czy istniejąca
            cbDocumentDataType.Enabled = edit && IsDefinitionNew();

            //ustawienie pól związanych z operacjami na rekordach list
            int selectedDataType = GetSelectedDataType();
            txtDefinitionList.ReadOnly = !(selectedDataType == (int)Data.IndexTypes.SimpleList && edit);
            dgvListItems.ReadOnly = txtNewRecord.ReadOnly = !(selectedDataType == (int)Data.IndexTypes.List && edit);
            btnAddNewRecord.Enabled = selectedDataType == (int)Data.IndexTypes.List && edit;

            txtDefinitionNamePL.ReadOnly = !edit;
            txtDefinitionNameRU.ReadOnly = !edit;
            txtDefinitionDescriptionPL.ReadOnly = !edit;
            txtDefinitionDescriptionRU.ReadOnly = !edit;
            SetDefinitionEditButtons(edit);
            //SetActiveEditList();
        }

        public void SetDefinitionEditButtons(bool edit, bool forceDisable = false)
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
                bool permitt = (_loadedDefinition != null && _loadedDefinition.Id > 0) || _isNewDefinition;
                btnDeleteDefinition.Enabled = chkEditDefinition.Checked && permitt && !edit;
                btnAddDefinition.Enabled = chkEditDefinition.Checked && !edit;
                btnSaveDefinition.Enabled = !chkEditDefinition.Checked && permitt && edit;
            }
        }

        private void SetVisibleDocumentDefinionListItemsComponent()
        {
            if (IsDefinitionNew() || (_loadedDefinition != null && _loadedDefinition.DataType.HasValue))
            {
                int dataType = _loadedDefinition != null ?  _loadedDefinition.DataType.Value : GetSelectedDataType();
                if (dataType == (int)Data.IndexTypes.List)
                {
                    pnlAdvancedList.Visible = true;
                    pnlSimpleList.Visible = false;
                    txtListRecordCount.Visible = lblListRecordCount.Visible = true;
                }
                else if (dataType == (int)Data.IndexTypes.SimpleList)
                {
                    pnlAdvancedList.Visible = false;
                    pnlSimpleList.Visible = true;
                    txtListRecordCount.Visible = lblListRecordCount.Visible = true;
                }
                else
                {
                    pnlAdvancedList.Visible = false;
                    pnlSimpleList.Visible = false;
                    txtListRecordCount.Visible = lblListRecordCount.Visible = false;
                }
            }
            else
            {
                pnlAdvancedList.Visible = false;
                pnlSimpleList.Visible = false;
                txtListRecordCount.Visible = lblListRecordCount.Visible = false;
            }
            if (IsDefinitionNew())
            {
                LoadDocumentDefinitionListItems();
            }
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

        public void LoadDefinitionList()
        {
            // tu wystąpił ostatnio błąd, definicje były nulem
            this.taDocumentDefinitions.Fill(this.iTDataSet.GetDocumentDefinitions, _ds.Language);
            cbDocumentDefinitions.DisplayMember = "Name";
            cbDocumentDefinitions.ValueMember = "Id";
            cbDocumentDefinitions.SelectedIndex = -1;
            lblDefinitionCount.Text = "(" + cbDocumentDefinitions.Items.Count.ToString() + ")";
        }

        public void LoadDefinitionContent()
        {
            int definitionId = GetSelectedDefinionId();
            _loadedDefinition = Data.GetDocumentDefinitionById(definitionId);
            //_loadedDefinition = _loadedClass.Document_DefinitionPerClass.Document_Definitions.FirstOrDefault(dd => dd.Id == definitionPerClassId);
            if (definitionId > 0 && _loadedDefinition != null && _loadedDefinition.Id > 0)
            {
                SetSelectedDataType((int)_loadedDefinition.DataType.Value);
                txtDefinitionList.Lines = _loadedDefinition.GetParsedItems();
                txtListRecordCount.Text = txtDefinitionList.Lines.Count().ToString();
                _tempListValues = txtDefinitionList.Text; // zapis do tempa
                txtDefinitionNamePL.Text = _loadedDefinition.Name_PL;
                txtDefinitionNameRU.Text = _loadedDefinition.Name_RU;
                txtDefinitionDescriptionPL.Text = _loadedDefinition.Description_PL;
                txtDefinitionDescriptionRU.Text = _loadedDefinition.Description_RU;
                //int selectedType = GetSelectedDataType();
                //txtListRecordCount.Text = _loadedDefinition.Document_DefinitionList_Items.Count.ToString();
                if (_loadedDefinition.DataType == (int)Data.IndexTypes.List)
                {
                    //lista zaawansowana, należy wypełnić listę danymi
                    LoadDocumentDefinitionListItems();
                    txtListRecordCount.Text = _loadedDefinition.Document_DefinitionList_Items.Count.ToString();
                }
            }
            else
            {
                _loadedDefinition = null;
                cbDocumentDefinitions.Text = "";
                txtDefinitionList.Text = "";
                _tempListValues = ""; // zerowanie tempa
                txtDefinitionNamePL.Text = "";
                txtDefinitionNameRU.Text = "";
                txtDefinitionDescriptionPL.Text = "";
                txtDefinitionDescriptionRU.Text = "";
            }
        }

        private void LoadDocumentDefinitionListItems()
        {
            txtListRecordCount.Text = "0";
            int definitionId = _loadedDefinition != null ? _loadedDefinition.Id : 0;
            this.taDocumentDefinitionListItems.Fill(this.iTDataSet.GetDocumentDefinitionListItems, definitionId);
        }

        private bool ValidateFormDefinition()
        {
            int selectedType = GetSelectedDataType();
            _errorProvider.Clear();
            if (selectedType == -1)
            {
                _errorProvider.SetError(cbDocumentDataType, _ds.LocRM.GetString("msg22")); //"Musisz podać typ indeksu!"
                return false;
            }
            else if (txtDefinitionNamePL.Visible && string.IsNullOrEmpty(txtDefinitionNamePL.Text))
            {
                _errorProvider.SetError(txtDefinitionNamePL, _ds.LocRM.GetString("msg27")); //"Musisz podać nazwę dla definicji po Polsku!"
                return false;
            }
            else if (_validateUniqueNames && txtDefinitionNamePL.Visible && (_isNewDefinition ? true : txtDefinitionNamePL.Text != _loadedDefinition.Name_PL) 
                && Data.IsDefinitionNamePLExistInDataBase(txtDefinitionNamePL.Text))
            {
                _errorProvider.SetError(txtDefinitionNamePL, _ds.LocRM.GetString("msg24")); //Musisz podać nazwę unikalną w obrębie klasy i języka!
                return false;
            }
            else if (txtDefinitionNameRU.Visible && string.IsNullOrEmpty(txtDefinitionNameRU.Text))
            {
                _errorProvider.SetError(txtDefinitionNameRU, _ds.LocRM.GetString("msg28")); //Musisz podać nazwę dla klasy w języku rosyjskim!
                return false;
            }
            else if (txtDefinitionNameRU.Visible && _validateUniqueNames && (_isNewDefinition ? true : txtDefinitionNameRU.Text != _loadedDefinition.Name_RU)
                && Data.IsDefinitionNameRUExistInDataBase(txtDefinitionNameRU.Text))
            {
                _errorProvider.SetError(txtDefinitionNameRU, _ds.LocRM.GetString("msg24")); //Musisz podać nazwę unikalną w obrębie klasy i języka!
                return false;
            }
            return true;
        }

        public void DeleteDefinition()
        {
            string txtOnBar = string.Format("{0}: {1}", _ds.LocRM.GetString(DialogBox.OBJECT_DEFINITION), cbDocumentDefinitions.Text);
            DialogResult dialogResult = DialogBox.ShowDialog(txtOnBar, _ds.LocRM.GetString(DialogBox.MESSAGE_DELETE), _ds, MessageBoxButtons.YesNo, DialogBox.Icons.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int definitionId = GetSelectedDefinionId();
                if (definitionId < 1) return;
                bool result = Data.DeleteDocumentDefinition(definitionId);
                if (result)
                {
                    DialogBox.ShowDialog(_ds.LocRM.GetString(DialogBox.MESSAGE_SUCCESS), _ds.LocRM.GetString(DialogBox.ACTION_DELETE), _ds,
                        MessageBoxButtons.OK, DialogBox.Icons.Success);
                    _canChangeSelectedDefinition = false;
                    LoadDefinitionList();
                    cbDocumentDefinitions.SelectedIndex = cbDocumentDefinitions.Items.Count > 0 ? cbDocumentDefinitions.Items.Count - 1 : -1;
                    LoadDefinitionContent();
                    _canChangeSelectedDefinition = true;

                    _ds.RefreshData();
                }
                else
                {
                    DialogBox.ShowDialog(_ds.LocRM.GetString(DialogBox.MESSAGE_FAILED), _ds.LocRM.GetString(DialogBox.ACTION_DELETE), _ds,
                        MessageBoxButtons.OK, DialogBox.Icons.Error);
                }
            }
        }

        public bool SaveDefinition()
        {
            bool result = false;
            if (ValidateFormDefinition())
            {
                //resetowanie pola default, gdy niewymagane
                if (IsDefinitionNew())
                {
                    result = Data.AddNewDocumentDefinition(txtDefinitionNamePL.Text, txtDefinitionDescriptionPL.Text, txtDefinitionNameRU.Text,
                        txtDefinitionDescriptionRU.Text, GetSelectedDataType(), Data.IndexItemsMerge(txtDefinitionList.Lines)); // zaktualizować items
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
                else if(IsDefinitionModified())
                {
                    int definitionId = GetSelectedDefinionId();
                    result = Data.UpdateDefinitionIndexOnly(definitionId, txtDefinitionNamePL.Text, txtDefinitionDescriptionPL.Text, txtDefinitionNameRU.Text,
                        txtDefinitionDescriptionRU.Text, Data.IndexItemsMerge(txtDefinitionList.Lines));  // do zaktualizowania 
                }
            }
            return result;
        }

        public void CancelEditDefinition()
        {
            //wszystkie pola przyjmują wartość domyślną z obiektu w pamięci
            _errorProvider.Clear();
            _isNewDefinition = false;
            if (_loadedDefinition == null) return;
            SetSelectedDataType((int)_loadedDefinition.DataType.Value);
            _tempListValues = txtDefinitionList.Text; // zapis nowej zawartości do tempa
            txtDefinitionNamePL.Text = _loadedDefinition.Name_PL;
            txtDefinitionNameRU.Text = _loadedDefinition.Name_RU;
            txtDefinitionDescriptionPL.Text = _loadedDefinition.Description_PL;
            txtDefinitionDescriptionRU.Text = _loadedDefinition.Description_RU;
        }

        public void CheckChanges()
        {
            //zachować kolejność sprawdzania
            if (IsDefinitionNew()) //sprawdzanie czy stworzono nową definicję
            {
                _canChangeSelectedDefinition = false;
                LoadDefinitionList();
                cbDocumentDefinitions.SelectedIndex = cbDocumentDefinitions.Items.Count - 1;
                 LoadDefinitionContent();
                _canChangeSelectedDefinition = true;
                //cbDocumentDefinitions.SelectedIndex = -1;
            }
            else if(!chkEditDefinition.Checked && (cbDocumentDefinitions.Text != txtDefinitionNamePL.Text && cbDocumentDefinitions.Text != txtDefinitionNameRU.Text))//sprawdzanie czy zmieniono nazwę definicji
            {
                _canChangeSelectedDefinition = false;
                int id = GetSelectedDefinionId();
                LoadDefinitionList();
                _canChangeSelectedDefinition = true;
                cbDocumentDefinitions.SelectedValue = id;
            }

            _isNewClass = false;
            _isNewDefinition = false;
        }

        private bool IsDefinitionModified()
        {
            bool mod = (_loadedDefinition != null &&(
                (int)_loadedDefinition.DataType != GetSelectedDataType() ||
                txtDefinitionNamePL.Text != _loadedDefinition.Name_PL ||
                txtDefinitionNameRU.Text != _loadedDefinition.Name_RU ||
                txtDefinitionDescriptionPL.Text != _loadedDefinition.Description_PL ||
                txtDefinitionDescriptionRU.Text != _loadedDefinition.Description_RU ||
                txtDefinitionList.Text != _loadedDefinition.Items
            ));
            return mod;
        }

        public bool IsClassNew()
        {
            return _isNewClass;
        }

        public bool IsDefinitionNew()
        {
            return _isNewDefinition;
        }

        public void ActualizeLoadedDefinition()
        {
            if (_loadedDefinition == null) return;
            _loadedDefinition.Id = GetSelectedDefinionId();
            _loadedDefinition.Name_PL = txtDefinitionNamePL.Text;
            _loadedDefinition.Name_RU = txtDefinitionNameRU.Text;
            _loadedDefinition.Description_PL = txtDefinitionDescriptionPL.Text;
            _loadedDefinition.Description_RU = txtDefinitionDescriptionRU.Text;
        }

        #endregion

        #region Events

        private void frmContentManager_Load(object sender, EventArgs e)
        {
            LoadDataTypesCB();
            LoadDefinitionList();
            _canChangeSelectedDefinition = true;
            if (cbDocumentDefinitions.Items.Count > 0)
            {
                cbDocumentDefinitions.SelectedIndex = 0;
            }
            _ttEditDefinition = Data.SetToolTip(this.chkEditDefinition, _ds.LocRM.GetString("lblEdit")); //będzie zmieniany
            chkEditDefinition.Text = _ds.LocRM.GetString("lblEdit");
            SetDefinitionUIToEdit(false);
            SetDefinitionEditButtons(false);
            SetActiveSpecificComponents();
        }

        private void chkEditDefinitions_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEditDefinition.Checked)
            {
                CancelEditDefinition();
            }
            SetDefinitionUIToEdit(!chkEditDefinition.Checked);
        }

        private void cbDocumentDefinitions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_canChangeSelectedDefinition)
            {
                LoadDefinitionContent();
                chkEditDefinition.Enabled = true;
            }
        }

        private void btnSaveDefinitions_Click(object sender, EventArgs e)
        {
            Save();
        }

        public void Save()
        {
            bool ok = true; // status edycji, false tylko przy niepowodzeniu zapisu
            if (IsDefinitionModified() || IsDefinitionNew())
            {
                ok = SaveDefinition();
                if (ok)
                {
                    //zapis zakończony sukcesem
                    CheckChanges();
                    ActualizeLoadedDefinition();
                    SetDefinitionUIToEdit(!chkEditDefinition.Checked);
                    _isChanged = true;
                }
            }
            chkEditDefinition.Checked = ok;
        }

        #endregion

        private void btnDeleteDefinitions_Click(object sender, EventArgs e)
        {
            DeleteDefinition();
        }

        private void btnAddDefinition_Click(object sender, EventArgs e)
        {
            _isNewDefinition = true;
            cbDocumentDefinitions.SelectedIndex = -1;
            LoadDefinitionContent();
            LoadDocumentDefinitionListItems();
            chkEditDefinition.Checked = false;
            chkEditDefinition.Enabled = true;
        }

        private void cbDocumentDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetActiveSpecificComponents();
            //SetActiveEditList();
            SetVisibleDocumentDefinionListItemsComponent();
        }

        public void SetActiveSpecificComponents()
        {
            int dataType = GetSelectedDataType();
            if (dataType != -1)
            {
                txtDefinitionList.ReadOnly = !(dataType == (int)Data.IndexTypes.SimpleList && !chkEditDefinition.Checked);
            }
        }

        public void SetActiveEditList()
        {
            btnEditRecords.Enabled = _loadedDefinition != null && _loadedDefinition.Id > 0 && GetSelectedDataType() == (int)Data.IndexTypes.List;
        }

        private void frmContentManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isChanged)
                _ds.RefreshData(); //odświeżenie głównego okna
        }

        private void btnEditRecords_Click(object sender, EventArgs e)
        {
            OpenRecordManager();
        }

        public void OpenRecordManager()
        {
            frmListManager listManager = new frmListManager(_ds, _loadedDefinition);
            _ds.SetColors(listManager);
            LanguageController.SetLanguage(listManager, _ds.LocRM);
            listManager.ShowDialog();
            //czekamy na zakończenie
            LoadDefinitionContent();
        }

        private void dgvListItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvListItems.Rows[e.RowIndex];
            var cellValue = ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue;
            //sprawdzamy, czy wartość niepusta i czy edytowana jest kolumna nazwy
            if (row.Cells[dgvColumnItemId.Index].Value != null
                && row.Cells[dgvColumnItemId.Index].Value != DBNull.Value
                && (e.ColumnIndex == dgvColumnItemName.Index || e.ColumnIndex == dgvColumnItemActive.Index)
                && ((DataRowView)row.DataBoundItem).Row.RowState == DataRowState.Modified
                )
            {

                //posiada wartość
                //if (Int32.Parse(altairRow.Cells[dgvColumnItemId.Index].Value.ToString()) < 0)
                //{
                //    //nowy rekord - insert
                //    //altairRow.Cells[dgvColumnItemId.Index].Value = 5;
                //    taDocument_DefinitionList_Items.Insert(_documentDefinition.Id, cellValue.ToString());
                //    this.taDocument_DefinitionList_Items.Fill(this.iTDataSet.GetDocumentDefinitionListItems, _documentDefinition.Id);
                //}
                //else
                {
                    //istnejący rekord - update
                    var id = Int32.Parse(dgvListItems.Rows[e.RowIndex].Cells[dgvColumnItemId.Index].Value.ToString());
                    var name = dgvListItems.Rows[e.RowIndex].Cells[dgvColumnItemName.Index].Value.ToString();
                    DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell) dgvListItems.Rows[e.RowIndex].Cells[dgvColumnItemActive.Index];
                    bool active = checkCell.Value != null ? bool.Parse(checkCell.Value.ToString()) : false;
                    taDocumentDefinitionListItems.Update(id, _loadedDefinition.Id, name, active);
                }
            }
        }

        private void dgvListItems_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == dgvColumnItemDelete.Index)
            {
                if (Delete(e.RowIndex))
                {
                    dgvListItems.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void dgvListItems_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //weryfikacja tylko dla nazw rekordów
            //weryfikujemy tylko, gdy wiersz został w jakiś sposób zmodyfikowany
            if (((DataRowView)bsDocumentDefinitionListItems.Current).Row.RowState == DataRowState.Unchanged)
                return;
            if (e.ColumnIndex == dgvColumnItemName.Index)
            {
                _errorProvider.Clear();
                //typedName = dgvListItems[e.ColumnIndex, e.RowIndex].Value.ToString();
                var typedName = e.FormattedValue.ToString();
                foreach (DataGridViewRow row in dgvListItems.Rows)
                {
                    //walidując nazwę dla rekordu z nazwami w tabeli, należy zrobić wyjątek na samą siebie
                    if (row.Index != e.RowIndex)
                    {
                        var comparingName = row.Cells[e.ColumnIndex].Value.ToString();
                        if (comparingName.Equals(e.FormattedValue.ToString()) || e.FormattedValue.ToString() == string.Empty)
                        {
                            dgvListItems.Rows[e.RowIndex].ErrorText = _ds.LocRM.GetString(messageError); //msg33 - musisz podać unikalną nazwę
                            e.Cancel = true;
                            return;
                        }
                        else
                        {
                            dgvListItems.Rows[e.RowIndex].ErrorText = string.Empty;
                        }
                    }
                }
                //weryfikacja, czy w bazie już istnieje taka nazwa dla rekordu dla określonej definicji
                var recordId = Int32.Parse(dgvListItems.Rows[e.RowIndex].Cells[dgvColumnItemId.Index].Value.ToString());
                if (!Data.IsUniqueDocumentDefinitionRecordName(e.FormattedValue.ToString(), recordId, _loadedDefinition.Id))
                {
                    dgvListItems.Rows[e.RowIndex].ErrorText = _ds.LocRM.GetString(messageError); //msg33 - musisz podać unikalną nazwę
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void dgvListItems_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = !Delete(e.Row.Index);
            if(!e.Cancel)
                bsDocumentDefinitionListItems.MoveLast();
        }

        private void txtNewRecord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddNewItem();
        }

        private void bntAddNew_Click(object sender, EventArgs e)
        {
            AddNewItem();
        }

        public void AddNewItem()
        {
            if (ValidateNewName(txtNewRecord.Text))
            {
                //insert
                taDocumentDefinitionListItems.Insert(_loadedDefinition.Id, txtNewRecord.Text, true);
                txtNewRecord.Text = string.Empty;
                this.taDocumentDefinitionListItems.Fill(this.iTDataSet.GetDocumentDefinitionListItems, _loadedDefinition.Id);
            }
            txtNewRecord.Focus();
        }

        public bool Delete(int index)
        {
            bool result = false;
            if (!dgvListItems.ReadOnly)
            {
                DataRowView view = dgvListItems.Rows[index].DataBoundItem as DataRowView;
                if (view.IsNew)
                {
                    //usuwanie niedodanego do bazy rekordu nie będzie wymagać potwierdzenia
                    //właściwa akcja usunięcia użytkownika
                    taDocumentDefinitionListItems.Delete(Convert.ToInt32(dgvListItems[dgvColumnItemId.Index, index].Value));
                    result = true;
                }
                else
                {
                    var id = Convert.ToInt32(dgvListItems[dgvColumnItemId.Index, index].Value);
                    var name = dgvListItems[dgvColumnItemName.Index, index].Value.ToString();
                    var countOfUsed = Data.GetCountUsedAdvancedListRecords(id);
                    //msg35 - Liczba wystąpień w bazie danych:
                    var dialogBody = string.Format("{0}\n\t{1}\n\t{2} {3}", _ds.LocRM.GetString("msg21"), name, _ds.LocRM.GetString("msg35"), countOfUsed);
                    DialogResult res = DialogBox.ShowDialog(dialogBody, "", _ds, MessageBoxButtons.YesNo, DialogBox.Icons.Question);

                    //Show(string.Format("{0}\n\t{1}", _locRM.GetString("msg21"), name), "",
                    //MessageBoxButtons.YesNo, MessageBoxIcon.Question); //Czy na pewno chcesz usunąć rekord listy?
                    if (res == System.Windows.Forms.DialogResult.Yes)
                    {
                        //właściwa akcja usunięcia użytkownika
                        taDocumentDefinitionListItems.Delete(id);
                        result = true;
                    }
                }
            }
            return result;
        }

        public bool ValidateNewName(string newName)
        {
            //wstępne sprawdzenie poprawności
            if (newName == string.Empty || !Data.IsUniqueDocumentDefinitionRecordName(newName, 0, _loadedDefinition.Id))
            {
                _errorProvider.SetError(txtNewRecord, _ds.LocRM.GetString(messageError));
                txtNewRecord.Margin = new Padding(txtNewRecord.Margin.Left, txtNewRecord.Margin.Top, 20, txtNewRecord.Margin.Bottom);
                return false;
            }
            foreach (DataGridViewRow row in dgvListItems.Rows)
            {
                var cellName = row.Cells[dgvColumnItemName.Index];
                if (cellName != null && cellName.Value != null && cellName.Value != DBNull.Value)
                {
                    if (newName.Equals(cellName.Value.ToString()))
                    {
                        _errorProvider.SetError(txtNewRecord, _ds.LocRM.GetString(messageError));
                        txtNewRecord.Margin = new Padding(txtNewRecord.Margin.Left, txtNewRecord.Margin.Top, 20, txtNewRecord.Margin.Bottom);
                        return false;
                    }
                }
            }
            _errorProvider.Clear();
            txtNewRecord.Margin = new Padding(txtNewRecord.Margin.Left, txtNewRecord.Margin.Top, txtNewRecord.Margin.Left, txtNewRecord.Margin.Bottom);
            return true;
        }
    }
}
