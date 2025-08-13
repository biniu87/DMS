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
using NLog;

namespace DocumentsManagerRU.View
{
    public partial class frmPermissionListItemsManager : Form
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        //private ResourceManager _locRM { get; set; }
        //private frmMain _main;
        private DataShare _ds;
        private string _userTitle;
        private string _groupTitle;
        private bool _selectPermission = false;

        public frmPermissionListItemsManager()
        {
            InitializeComponent();
        }
        public frmPermissionListItemsManager(DataShare ds)
        {
            InitializeComponent();
            _ds = ds;
            //_main = main;
            //_locRM = _main.LocRM;
            _userTitle = _ds.LocRM.GetString("securityTypeUser");
            _groupTitle = _ds.LocRM.GetString("securityTypeGroup");
        }

        public void LoadClassDGV()
        {
            int definitionId = GetSelectedDefinition();
            //var lang = _main.GetLanguage();
            //var securityObjects = Security.GetSecurityObjects();
            //this.taDocumentClass.FillToReadRelease(this.iTDataSet.Document_Class, lang, securityObjects, (int)Data.ClassPrimaryPermissions.Full, (int)Data.ClassSecondaryPermissions.None);
            this.taDocumentClass.FillByDefinitionId(this.iTDataSet.Document_Class, _ds.Language, definitionId);
        }

        public void LoadDefinitionDGV()
        {
            this.taDefinitions.Fill(iTDataSet.GetDocumentDefinitionsByDirective, _ds.Language, 0, (int)Data.DefinitionDirectives.AdvancedListOnly);
        }

        public void LoadGroupDGV()
        {
            this.taDocumentSecurity.Fill(iTDataSet.GetDocumentSecurity, _groupTitle, _userTitle);
        }

        public void LoadListItemsDGV()
        {
            var classId = GetSelectedClass();
            var definitionId = GetSelectedDefinition();
            var security = GetSelectedSecurityObjects();
            dgvPermissions.DataSource = bsDocumentListItemsPermissions;
            bsDocumentListItemsPermissions.DataMember = "GetDocumentListItemsPermissions";
            bsDocumentListItemsPermissions.DataSource = this.iTDataSet;
            dgvPermissions.DataSource = bsDocumentListItemsPermissions;
            taDocumentListItemsPermissions.Fill(iTDataSet.GetDocumentListItemsPermissions, definitionId, classId, security);
            PrescribeValues();
            //bsDocumentListItemsPermissions.SuspendBinding();
            //dgvColumnPermissionClassId.DataPropertyName = string.Empty;
            //dgvColumnPermissionDefinitionId.DataPropertyName = string.Empty;
            //dgvColumnPermissionPermissionId.DataPropertyName = string.Empty;
            //dgvColumnPermission.DataPropertyName = string.Empty;
            //dgvColumnPermissionClassId.Read = false;
            //dgvColumnPermissionDefinitionId.Read = false;
            //dgvColumnPermissionPermissionId.Read = false;
            //dgvColumnPermission.Read = false;
        }

        public void AttemptRefreshRecords()
        {
            if(_selectPermission &&
                dgvDefinitions.SelectedRows.Count > 0 &&
                dgvClass.SelectedRows.Count > 0 &&
                dgvSecurity.SelectedRows.Count > 0)
            {
                Console.WriteLine("wczytuje");
                LoadListItemsDGV();
            }
            else
            {
                dgvPermissions.DataSource = null;
                Console.WriteLine("nie wczytałem");
            }
        }

        private void btnSelectAllRecords_Click(object sender, EventArgs e)
        {
            SelectAllRowsInGrid(dgvPermissions);
        }

        private void btnSelectAllGroups_Click(object sender, EventArgs e)
        {
            SelectAllRowsInGrid(dgvSecurity);
        }

        private void btnAddPermissions_Click(object sender, EventArgs e)
        {
            SetSelectedRowsPermissions(true);
        }

        private void btnRemovePermissions_Click(object sender, EventArgs e)
        {
            SetSelectedRowsPermissions(false);
        }

        private void frmPermissionListItemsManager_Load(object sender, EventArgs e)
        {
            LoadDefinitionDGV();
            //LoadClassDGV();
            LoadGroupDGV();
            _selectPermission = true;
            AttemptRefreshRecords();
            LoadNames();
        }

        public void SelectAllRowsInGrid(DataGridView dgv)
        {
            bool select = dgv.SelectedRows.Count != dgv.Rows.Count;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Selected = select;
            }
        }

        public int GetSelectedClass()
        {
            try
            {
                if (dgvClass.SelectedRows.Count >= 0)
                {
                    DataRowView drvRow = (DataRowView)dgvClass.SelectedRows[0].DataBoundItem;
                    ITDataSet.Document_ClassRow row = (ITDataSet.Document_ClassRow)drvRow.Row;
                    return row.Id;
                }
                else
                    return -1;
            }
            catch (Exception e)
            {
                _logger.Error(e, "Błąd pobrania Id zaznaczonej klasy, e: {0}", e);
                return -1;
            }
        }

        public string GetSelectedSecurityObjects()
        {
            string groups = string.Empty;
            foreach (DataGridViewRow row in dgvSecurity.SelectedRows)
            {
                if (groups.Length > 0)
                    groups = string.Format("{0},{1}", groups, row.Cells[dgvColumnSecurityName.Index].Value.ToString());
                else
                    groups = row.Cells[dgvColumnSecurityName.Index].Value.ToString();
            }
            return groups;
        }

        public int GetSelectedDefinition()
        {
            if (dgvDefinitions.SelectedRows.Count > 0)
            {
                DataRowView drvRow = (DataRowView)dgvDefinitions.SelectedRows[0].DataBoundItem;
                ITDataSet.GetDocumentDefinitionsByDirectiveRow row = (ITDataSet.GetDocumentDefinitionsByDirectiveRow)drvRow.Row;
                return row.Id;
            }
            else
            {
                return -1;
            }
        }

        public void DeletePermission(int permissionId)
        {
            Permissions.DeleteListItemPermission(permissionId);
        }

        public void PrescribeValues()
        {
            foreach (DataGridViewRow row in dgvPermissions.Rows)
            {
                row.Cells[dgvColPermissionId.Index].Value = row.Cells[dgvColumnPermissionPermissionId.Index].Value;
                row.Cells[dgvColPermission.Index].Value = row.Cells[dgvColumnPermission.Index].Value;
            }
        }

        //public void DeletePermission(int classId, int itemId, int securityId)
        //{
        //    foreach (DataGridViewRow altairRow in dgvPermissions.Rows)
        //    {
        //        if(altairRow.Cells[dgvColClassId.Index].Value.ToString() == classId.ToString()
        //            && altairRow.Cells[dgvColItemId.Index].Value.ToString() == itemId.ToString()
        //            && altairRow.Cells[dgvColSecurityId.Index].Value.ToString() == securityId.ToString()
        //            )
        //        {
        //            string sql = string.Format("SELECT Id FROM Document_ListItems_Permissions (NOLOCK) WHERE ClassId = {0} AND SecurityId = {1} AND ItemId = {2}",
        //                classId, securityId, itemId);
        //            var permission = Data.GetSQLSingleValue(sql);
        //            int permissionId = -1;
        //            Int32.TryParse(permission != null ? permission.ToString() : string.Empty, out permissionId);
        //            DeletePermission(permissionId);
        //            break;
        //        }
        //    }
        //}

        public void DeleteSinglePermission()
        {

        }

        public void DeleteManyPermission()
        {

        }

        public void AddPermission()
        {

        }

        public void AddManyPermission()
        {

        }

        private void dgvDefinitions_SelectionChanged(object sender, EventArgs e)
        {
            LoadClassDGV();
        }

        private void dgvClass_SelectionChanged(object sender, EventArgs e)
        {
            AttemptRefreshRecords();
        }

        private void dgvSecurity_SelectionChanged(object sender, EventArgs e)
        {
            AttemptRefreshRecords();
        }

        private void dgvSecurity_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            _selectPermission = false;
        }

        private void dgvSecurity_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            _selectPermission = true;
            AttemptRefreshRecords();
        }

        private void dgvSecurity_MouseLeave(object sender, EventArgs e)
        {
            _selectPermission = true;
            AttemptRefreshRecords();
        }

        private void SetPermission(bool permission, int permissionRowIndex)
        {
            var classId = GetSelectedClass();
            var item = dgvPermissions.Rows[permissionRowIndex].Cells[dgvColumnPermissionItemId.Index].Value;
            //bool actualPermission = dgvPermissions.Rows[permissionRowIndex].Cells[dgvColPermission.Index].Value != null &&
            //    dgvPermissions.Rows[permissionRowIndex].Cells[dgvColPermission.Index].Value != DBNull.Value ?
            //    Convert.ToBoolean(dgvPermissions.Rows[permissionRowIndex].Cells[dgvColPermission.Index].Value) : false;
            //Convert.ToBoolean(dgvPermissions.Rows[e.RowIndex].Cells[dgvColPermission.Index].Value);
            var itemId = item != null ? Int32.Parse(item.ToString()) : -1;
            int changed = 0;
            if (!permission)
            {
                //usuwanie poświadczeń
                //var permIdString = dgvPermissions.Rows[e.RowIndex].Cells[dgvColPermissionId.Index].Value.ToString();
                //int permissionId = Int32.Parse(dgvPermissions.Rows[e.RowIndex].Cells[dgvColPermissionId.Index].Value.ToString());//indeks temp
                foreach (DataGridViewRow row in dgvSecurity.SelectedRows)
                {
                    //classId dla każdego rekordu poświadczenia musi być pobierane z bazy osobno dla każdego rekordu Security
                    var security = row.Cells[dgvColumnSecurityId.Index].Value;
                    var securityId = security != null ? Int32.Parse(security.ToString()) : -1;
                    int permissionId = Permissions.GetPermissionForListItemId(classId, securityId, itemId);
                    if (taDocumentListItemsPermissions.Delete(permissionId) > 0)
                    {
                        changed++;
                    }
                }
                if (changed == dgvSecurity.SelectedRows.Count)
                {
                    //wszystkie operacje przebiegły pomyślnie
                    dgvPermissions.Rows[permissionRowIndex].Cells[dgvColPermission.Index].Value = false;
                    dgvPermissions.Rows[permissionRowIndex].Cells[dgvColPermissionId.Index].Value = null;
                }
            }
            else
            {
                //dodawanie poświadczeń
                foreach (DataGridViewRow row in dgvSecurity.SelectedRows)
                {
                    var security = row.Cells[dgvColumnSecurityId.Index].Value;
                    var securityId = security != null ? Int32.Parse(security.ToString()) : -1;
                    if (taDocumentListItemsPermissions.Insert(itemId, classId, securityId, true) > 0)
                    {
                        if (changed == 0)
                        {
                            //aktualizacja classId tylko jeden raz niezależnie od ilości pól security
                            int permissionId = Permissions.GetPermissionForListItemId(classId, securityId, itemId);
                            if (permissionId != -1)
                            {
                                dgvPermissions.Rows[permissionRowIndex].Cells[dgvColPermissionId.Index].Value = permissionId;
                                changed++;
                                dgvPermissions.Rows[permissionRowIndex].Cells[dgvColPermission.Index].Value = true;
                            }
                        }
                    }
                    else
                    {
                        dgvPermissions.Rows[permissionRowIndex].Cells[dgvColPermission.Index].Value = false;
                    }
                }
            }
        }

        public void SetSelectedRowsPermissions(bool permission)
        {
            if (dgvDefinitions.SelectedRows.Count > 0 &&
                dgvClass.SelectedRows.Count > 0 &&
                dgvSecurity.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvPermissions.SelectedRows)
                {
                    SetPermission(permission, row.Index);
                }
            }
        }

        public void LoadNames()
        {
            dgvColumnClassName.HeaderText = _ds.LocRM.GetString("dgvColumnName");
            dgvColumnDefinitionCurrentName.HeaderText = _ds.LocRM.GetString("dgvColumnName");
            dgvColumnPermissionName.HeaderText = _ds.LocRM.GetString("dgvColumnName");
            //dgvColumnDescription
            dgvColumnDefinitionCurrentDescription.HeaderText = _ds.LocRM.GetString("dgvColumnDescription");
            dgvColumnClassDescription.HeaderText = _ds.LocRM.GetString("dgvColumnDescription");
            dgvColPermission.HeaderText = "P";
        }

        private void dgvPermissions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvColPermission.Index && e.RowIndex >= 0)
            {
                bool actualPermission = dgvPermissions.Rows[e.RowIndex].Cells[dgvColPermission.Index].Value != null &&
                        dgvPermissions.Rows[e.RowIndex].Cells[dgvColPermission.Index].Value != DBNull.Value ?
                        Convert.ToBoolean(dgvPermissions.Rows[e.RowIndex].Cells[dgvColPermission.Index].Value) : false;
                SetPermission(!actualPermission, e.RowIndex);
            }
        }
    }
}
