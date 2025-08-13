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

namespace DocumentsManagerRU.View
{
    public partial class frmListManager : Form
    {
        private DataShare _ds;
        //private ResourceManager _locRM { get; set; }
        private Document_Definitions _documentDefinition;
        private ErrorProvider _errorProvider = new ErrorProvider();
        private string messageError = "msg33";
        public frmListManager(DataShare ds, Document_Definitions definition)
        {
            InitializeComponent();
            _ds = ds;
            _documentDefinition = definition;
        }

        private void bntAddNew_Click(object sender, EventArgs e)
        {
            AddNewItem();
        }

        private void frmListManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTDataSet.Document_DefinitionList_Items' table. You can move, or remove it, as needed.
            this.taDocumentDefinitions.Fill(this.iTDataSet.GetDocumentDefinitions, _ds.Language);
            cbDefinition.SelectedValue = _documentDefinition.Id;
            this.taDocument_DefinitionList_Items.Fill(this.iTDataSet.GetDocumentDefinitionListItems, _documentDefinition.Id);
        }

        public bool IsAllItemsSaved()
        {
            foreach (DataGridViewRow row in dgvListItems.Rows)
            {
                if (row.Cells[dgvColumnItemId.Index].Value == DBNull.Value
                    || row.Cells[dgvColumnItemId.Index].Value == null
                    || Int32.Parse(row.Cells[dgvColumnItemId.Index].Value.ToString()) < 0)
                {
                    return false;
                }
            }
            return true;
        }

        public void AddNewItem()
        {
            /*if (IsAllItemsSaved())
            {
                var altairRow = bsDocumentDefinitionListItems.AddNew();
            }*/
            if (ValidateNewName(txtNewRecord.Text))
            {
                //insert
                taDocument_DefinitionList_Items.Insert(_documentDefinition.Id, txtNewRecord.Text, true);
                txtNewRecord.Text = string.Empty;
                this.taDocument_DefinitionList_Items.Fill(this.iTDataSet.GetDocumentDefinitionListItems, _documentDefinition.Id);
            }
            txtNewRecord.Focus();
        }

        public bool Delete(int index)
        {
            bool result = false;
            DataRowView view = dgvListItems.Rows[index].DataBoundItem as DataRowView;
            if (view.IsNew)
            {
                //usuwanie niedodanego do bazy rekordu nie będzie wymagać potwierdzenia
                //właściwa akcja usunięcia użytkownika
                taDocument_DefinitionList_Items.Delete(Convert.ToInt32(dgvListItems[dgvColumnItemId.Index, index].Value));
                result = true;
            }
            else
            {
                var name = dgvListItems[dgvColumnItemName.Index, index].Value.ToString();
                DialogResult res = DialogBox.ShowDialog(string.Format("{0}\n\t{1}", 
                    _ds.LocRM.GetString("msg21"), name), "", _ds, MessageBoxButtons.YesNo, DialogBox.Icons.Question);

                    //Show(string.Format("{0}\n\t{1}", _locRM.GetString("msg21"), name), "",
                    //MessageBoxButtons.YesNo, MessageBoxIcon.Question); //Czy na pewno chcesz usunąć rekord listy?
                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    //właściwa akcja usunięcia użytkownika
                    taDocument_DefinitionList_Items.Delete(Convert.ToInt32(dgvListItems[dgvColumnItemId.Index, index].Value));
                    result = true;
                }
            }
            return result;
        }

        public bool ValidateNewName(string newName)
        {
            foreach (DataGridViewRow row in dgvListItems.Rows)
            {
                var cellName = row.Cells[dgvColumnItemName.Index];
                if (cellName != null && cellName.Value != null && cellName.Value != DBNull.Value)
                {
                    if (newName.Equals(cellName.Value.ToString()) || newName == string.Empty || !Data.IsUniqueDocumentDefinitionRecordName(newName, 0, _documentDefinition.Id))
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

        private void dgvListItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvListItems.Rows[e.RowIndex];
            var cellValue = ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue;
            //sprawdzamy, czy wartość niepusta i czy edytowana jest kolumna nazwy
            if(row.Cells[dgvColumnItemId.Index].Value != null
                && row.Cells[dgvColumnItemId.Index].Value != DBNull.Value
                && e.ColumnIndex == dgvColumnItemName.Index
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
                    bool active = bool.Parse(dgvListItems.Rows[e.RowIndex].Cells[dgvColumnItemActive.Index].Value.ToString());
                    taDocument_DefinitionList_Items.Update(id, _documentDefinition.Id, cellValue.ToString(), active);
                }
            }
        }

        private void bsDocumentDefinitionListItems_AddingNew(object sender, AddingNewEventArgs e)
        {
            /*DataView dataTableView = bsDocumentDefinitionListItems.List as DataView;
            DataRowView rowView = dataTableView.AddNew();
            rowView[dgvColumnItemDefinitionId.Index] = cbDefinition.SelectedValue;
            e.NewObject = rowView;
            bsDocumentDefinitionListItems.MoveLast();*/
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

        private void dgvListItems_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = !Delete(e.Row.Index);
            bsDocumentDefinitionListItems.MoveLast();
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
                if (!Data.IsUniqueDocumentDefinitionRecordName(e.FormattedValue.ToString(), recordId, _documentDefinition.Id))
                {
                    dgvListItems.Rows[e.RowIndex].ErrorText = _ds.LocRM.GetString(messageError); //msg33 - musisz podać unikalną nazwę
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void txtNewRecord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddNewItem();
        }
    }
}
