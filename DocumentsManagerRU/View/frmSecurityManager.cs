using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentsManagerRU.View
{
    public partial class frmSecurityManager : Form
    {
        //private ResourceManager _locRM { get; set; }
        //private frmMain _main;
        private DataShare _ds;
        private string _userTitle;
        private string _groupTitle;
        private List<GroupPrincipal> _ADgroupList = Security.GetGroups();

        public frmSecurityManager(DataShare ds)
        {
            InitializeComponent();
            //_main = main;
            //_locRM = _main.LocRM;
            _ds = ds;
            _userTitle = _ds.LocRM.GetString("securityTypeUser");
            _groupTitle = _ds.LocRM.GetString("securityTypeGroup");
        }

        #region Public methods

        /// <summary>
        /// Sprawdzanie, czy Security Grid zawiera daną nazwę w kolumnie nazw
        /// </summary>
        /// <param name="obj">Nazwa poszukiwanego obiektu</param>
        /// <returns></returns>
        public bool IsDGVSecurityContainsObject(string obj)
        {
            foreach (DataGridViewRow row in dgvSecurity.Rows)
            {
                if (row.Cells[dgvColumnSecurityName.Index].Value != null)
                {
                    if (row.Cells[dgvColumnSecurityName.Index].Value.ToString().ToLower() == obj.ToLower())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void FillDGVGroups()
        {
            dgvGroups.Rows.Clear();
            int i = 1;
            foreach (GroupPrincipal gp in _ADgroupList)
            {
                int rowIndex = dgvGroups.Rows.Add(1);
                DataGridViewRow row = dgvGroups.Rows[rowIndex];
                row.Cells[dgvColumnGroupNumber.Index].Value = i;
                row.Cells[dgvColumnGroupName.Index].Value = gp.SamAccountName;
                row.Cells[dgvColumnGroupGuid.Index].Value = gp.Guid;
                row.Cells[dgvColumnGroupDecription.Index].Value = gp.Description;
                //zaznaczenie grupy, która już została dodana do Security
                row.Cells[dgvColumnGroupAdded.Index].Value = IsDGVSecurityContainsObject(gp.SamAccountName);
                i++;
            }
        }

        public void FillDGVUsersOnChangeGroup()
        {
            if (dgvGroups.SelectedRows.Count > 0 && dgvGroups.Rows[dgvGroups.SelectedRows[0].Index].Cells[dgvColumnGroupName.Index].Value != null)
            {
                //string selectedName = dgvGroups.Rows[dgvGroups.SelectedRows[0].Index].Cells[dgvColumnGroupName.Index].Value.ToString();
                string guid = dgvGroups.Rows[dgvGroups.SelectedRows[0].Index].Cells[dgvColumnGroupGuid.Index].Value.ToString();
                GroupPrincipal gp = _ADgroupList.FirstOrDefault(g => g.Guid.Value.ToString() == guid);
                FillDGVUsers(gp);
            }
        }

        public void FillDGVUsers(GroupPrincipal gp)
        {
            dgvUsers.Rows.Clear();

            int i = 1;
            
            List<UserPrincipal> upl = Security.GetUsersFromGroup(gp);
            foreach (UserPrincipal up in upl)
            {
                int rowIndex = dgvUsers.Rows.Add(1);
                DataGridViewRow row = dgvUsers.Rows[rowIndex];
                row.Cells[dgvColumnUserNumber.Index].Value = i;
                row.Cells[dgvColumnUserName.Index].Value = up.SamAccountName;
                //zaznaczenie grupy, która już została dodana do Security
                row.Cells[dgvColumnUserAdded.Index].Value = IsDGVSecurityContainsObject(up.SamAccountName);
                i++;
            }

        }

        public void UpdateAddedGroups()
        {
            foreach (DataGridViewRow row in dgvGroups.Rows)
            {
                row.Cells[dgvColumnGroupAdded.Index].Value = IsDGVSecurityContainsObject(row.Cells[dgvColumnGroupName.Index].Value.ToString());
            }
        }

        public void UpdateAddedUsers()
        {
            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                row.Cells[dgvColumnUserAdded.Index].Value = IsDGVSecurityContainsObject(row.Cells[dgvColumnUserName.Index].Value.ToString());
            }
        }

        public void FillData()
        {
            FillSecurityGrid();
            FillDGVGroups();
        }

        public void FillSecurityGrid()
        {
            this.taDocumentSecurity.Fill(this.iTDataSet.GetDocumentSecurity, _groupTitle, _userTitle);
        }

        public void RefreshGrids()
        {
            FillSecurityGrid();
            UpdateAddedGroups();
            UpdateAddedUsers();
        }

        public bool AddSingleGroup(string name, string description, bool refresh = true, Nullable<bool> confirmed = null)
        {
            if (!IsDGVSecurityContainsObject(name))
            {
                if (confirmed.HasValue == false)
                {
                    confirmed = GetUserConfirmChanges();
                }
                if (confirmed == false)
                {
                    return false;
                }
                //zapis do bazy
                bool active = true;
                bool admin = false;
                bool isGroup = true;
                bool success = Security.InsertSecurity(name, description, active, admin, isGroup);
                if (refresh)
                {
                    RefreshGrids();
                }
                return success;
                //nie można tak zrobić, trzeba zabezpieczyć ponownym zaciągnięciem tych dabnych z bazy
                //DataGridViewRow rrrr = (DataGridViewRow) bsDocumentSecurity.AddNew();
                //DataGridViewRow altairRow = dgvSecurity.Rows[dgvSecurity.Rows.Count - 1]; //nowy wierszyk
                //altairRow.Cells[dgvColumnSecurityName.Index].Value = name;
                //altairRow.Cells[dgvColumnSecurityDescription.Index].Value = description;
                //altairRow.Cells[dgvColumnSecurityIsGroup.Index].Value = isGroup;
                //altairRow.Cells[dgvColumnSecurityAdmin.Index].Value = admin;
                //altairRow.Cells[dgvColumnSecurityActive.Index].Value = active;
                //altairRow.Cells[dgvColumnSecurityType.Index].Value = _groupTitle;
            }
            return false;
        }

        public bool AddSingleGroup(int rowIndex, bool refresh = true, Nullable<bool> confirmed = null)
        {
            if (confirmed.HasValue == false)
            {
                confirmed = GetUserConfirmChanges();
            }
            if (confirmed == false)
            {
                return false;
            }
            string name = dgvGroups.Rows[rowIndex].Cells[dgvColumnGroupName.Index].Value.ToString();
            string description = null;
            if (dgvGroups.Rows[rowIndex].Cells[dgvColumnGroupDecription.Index].Value != null)
            {
                description = dgvGroups.Rows[rowIndex].Cells[dgvColumnGroupDecription.Index].Value.ToString();
            }
            return AddSingleGroup(name, description, refresh, confirmed);
        }

        public bool AddSingleUser(string name, bool refresh = true, Nullable<bool> confirmed = null)
        {
            if (!IsDGVSecurityContainsObject(name))
            {
                if (confirmed.HasValue == false)
                {
                    confirmed = GetUserConfirmChanges();
                }
                if (confirmed == false)
                {
                    return false;
                }
                bool active = true;
                bool admin = false;
                bool isGroup = false;
                string description = null;
                //zapis do bazy
                bool success = Security.InsertSecurity(name, description, active, admin, isGroup);
                if (refresh)
                {
                    RefreshGrids();
                }
                return success;
            }
            return false;
        }

        public bool AddSingleUser(int rowIndex, bool refresh = true, Nullable<bool> confirmed = null)
        {
            if (confirmed.HasValue == false)
            {
                confirmed = GetUserConfirmChanges();
            }
            if (confirmed == false)
            {
                return false;
            }
            string name = dgvUsers.Rows[rowIndex].Cells[dgvColumnUserName.Index].Value.ToString();
            return AddSingleUser(name, refresh, confirmed);
        }

        public bool RemoveSingleGroup(string name, bool refresh = true, Nullable<bool> confirmed = null)
        {
            if (confirmed.HasValue == false)
            {
                confirmed = GetUserConfirmChanges();
            }
            if (confirmed == false)
            {
                return false;
            }
            bool success = IsDGVSecurityContainsObject(name) ? Security.DeleteSecurity(name) : false;
            if (refresh)
            {
                RefreshGrids();
            }
            return success;
        }

        public bool RemoveSingleGroup(int rowIndex, bool refresh = true, Nullable<bool> confirmed = null)
        {
            if (confirmed.HasValue == false)
            {
                confirmed = GetUserConfirmChanges();
            }
            if (confirmed == false)
            {
                return false;
            }
            string name = dgvGroups.Rows[rowIndex].Cells[dgvColumnGroupName.Index].Value.ToString();
            //usunięcie z bazy
            return RemoveSingleGroup(name, refresh, confirmed);
        }

        public bool RemoveSingleUser(string name, bool refresh = true, Nullable<bool> confirmed = null)
        {
            if (confirmed.HasValue == false)
            {
                confirmed = GetUserConfirmChanges();
            }
            if (confirmed == false)
            {
                return false;
            }
            bool success = IsDGVSecurityContainsObject(name) ? Security.DeleteSecurity(name) : false;
            if (refresh)
            {
                RefreshGrids();
            }
            return success;
        }

        public bool RemoveSingleUser(int rowIndex, bool refresh = true, Nullable<bool> confirmed = null)
        {
            if (confirmed.HasValue == false)
            {
                confirmed = GetUserConfirmChanges();
            }
            if (confirmed == false)
            {
                return false;
            }
            string name = dgvUsers.Rows[rowIndex].Cells[dgvColumnUserName.Index].Value.ToString();
            //usunięcie z bazy
            return RemoveSingleUser(name, refresh, confirmed);
        }

        public bool AddSelectedGroups()
        {
            var confirmed = GetUserConfirmChanges();
            if (confirmed == false)
            {
                return false;
            }
            bool success = false;
            if (dgvGroups.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvGroups.SelectedRows)
                {
                    success = AddSingleGroup(row.Index, false, confirmed) ? true : success;
                }
                if(success)
                    RefreshGrids();
            }
            return success;
        }

        public bool AddSelectedUsers()
        {
            var confirmed = GetUserConfirmChanges();
            if (confirmed == false)
            {
                return false;
            }
            bool success = false;
            if (dgvUsers.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvUsers.SelectedRows)
                {
                    success = AddSingleUser(row.Index, false, confirmed) ? true : success;
                }
                if (success)
                    RefreshGrids();
            }
            return success;
        }

        public bool RemoveSelectedGroups()
        {
            var confirmed = GetUserConfirmChanges();
            if (confirmed == false)
            {
                return false;
            }
            bool success = false;
            if (dgvGroups.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvGroups.SelectedRows)
                {
                    success = RemoveSingleGroup(row.Index, false, confirmed) ? true : success;
                }
                if (success)
                    RefreshGrids();
            }
            return success;
        }

        public bool RemoveSelectedUsers()
        {
            bool success = false;
            if (dgvUsers.SelectedRows.Count > 0)
            {
                var confirmed = GetUserConfirmChanges();
                if (confirmed == false)
                {
                    return false;
                }
                foreach (DataGridViewRow row in dgvUsers.SelectedRows)
                {
                    success = RemoveSingleUser(row.Index, false, confirmed) ? true : success;
                }
                if (success)
                    RefreshGrids();
            }
            return success;
        }

        public bool RemoveSingleSecurity(int rowIndex, Nullable<bool> confirmed)
        {
            if (confirmed.HasValue == false)
            {
                confirmed = GetUserConfirmChanges();
            }
            if (confirmed == false)
            {
                return false;
            }
            bool success = false;
            string name = dgvSecurity.Rows[rowIndex].Cells[dgvColumnSecurityName.Index].Value.ToString();
            success = Security.DeleteSecurity(name);
            if (success)
                dgvSecurity.Rows.RemoveAt(rowIndex);
            return success;
        }

        public bool RemoveSelectedSecurity()
        {
            var confirmed = GetUserConfirmChanges();
            if (confirmed == false) return false; //przerwanie na brak potwierdzenia
            bool success = false;
            foreach (DataGridViewRow row in dgvSecurity.SelectedRows)
            {
                success = RemoveSingleSecurity(row.Index, confirmed) ? true : success;
            }
            if (success)
            {
                UpdateAddedGroups();
                UpdateAddedUsers();
            }
            return success;
        }

        public void SelectAllRowsInGrid(DataGridView dgv)
        {
            bool select = dgv.SelectedRows.Count != dgv.Rows.Count;
            foreach(DataGridViewRow row in dgv.Rows){
                row.Selected = select;
            }
        }

        public bool GetUserConfirmChanges()
        {
            //wymuszenie potwierdzenia przez użytkownika zmian za pomocą okna dialogowego
            var result = DialogBox.ShowDialog("Czy potwierdzasz świadomość konsekwencji dokonania zmiany w systemie?", "Potwierdź zmianę", _ds,
                        MessageBoxButtons.OKCancel, DialogBox.Icons.Question);
            return result == DialogResult.OK;
        }

        #endregion

        #region Events

        private void frmSecurityManager_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void dgvGroups_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGroups.SelectedRows.Count == 1)
                FillDGVUsersOnChangeGroup();
            else
                dgvUsers.Rows.Clear();
        }

        private void btnSecurityAddGroup_Click(object sender, EventArgs e)
        {
            AddSelectedGroups();
        }

        private void btnSecurityRemove_Click(object sender, EventArgs e)
        {
            RemoveSelectedSecurity();
        }

        private void btnSecurityRemoveGroup_Click(object sender, EventArgs e)
        {
            RemoveSelectedGroups();
        }

        private void btnSecurityAddUser_Click(object sender, EventArgs e)
        {
            AddSelectedUsers();
        }

        private void btnSecurityRemoveUser_Click(object sender, EventArgs e)
        {
            RemoveSelectedUsers();
        }

        private void dgvSecurity_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //usunięcie wpisu z security
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == dgvColumnSecurityDelete.Index)
            {
                var confirmed = GetUserConfirmChanges();
                if (confirmed == false)
                {
                    return;
                }
                string name = dgvSecurity.Rows[e.RowIndex].Cells[dgvColumnSecurityName.Index].Value.ToString();
                //del
                if (Security.DeleteSecurity(name))
                {
                    dgvSecurity.Rows.RemoveAt(e.RowIndex);
                    UpdateAddedGroups();
                    UpdateAddedUsers();
                }
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //zaznaczenie i odznaczenie wpisu w bazie
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == dgvColumnUserAdded.Index)
            {
                //pewność, że kolumna z zaznaczaniem
                bool value = Convert.ToBoolean(dgvUsers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                if (value)
                    RemoveSingleUser(e.RowIndex, false);
                else
                    AddSingleUser(e.RowIndex, false);
                //dgvUsers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !value;
                RefreshGrids();
            }

        }

        private void dgvGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //zaznaczenie i odznaczenie wpisu w bazie
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == dgvColumnGroupAdded.Index)
            {
                //pewność, że kolumna z zaznaczaniem
                bool value = Convert.ToBoolean(dgvGroups.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                if (value)
                    RemoveSingleGroup(e.RowIndex, false);
                else
                    AddSingleGroup(e.RowIndex, false);
                //dgvGroups.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !value;
                RefreshGrids();
            }
        }

        private void dgvSecurity_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bool admin;
            Boolean.TryParse(dgvSecurity.Rows[e.RowIndex].Cells[dgvColumnSecurityAdmin.Index].Value.ToString(), out admin);
            bool active;
            Boolean.TryParse(dgvSecurity.Rows[e.RowIndex].Cells[dgvColumnSecurityActive.Index].Value.ToString(), out active);
            string name = dgvSecurity.Rows[e.RowIndex].Cells[dgvColumnSecurityName.Index].Value.ToString();
            Security.UpdateSecurity(name, null, active, admin);
        }

        private void btnSelectAllSecurityRows_Click(object sender, EventArgs e)
        {
            SelectAllRowsInGrid(dgvSecurity);
        }

        private void btnSelectAllGroupRows_Click(object sender, EventArgs e)
        {
            SelectAllRowsInGrid(dgvGroups);
        }

        private void btnSelectAllUserRows_Click(object sender, EventArgs e)
        {
            SelectAllRowsInGrid(dgvUsers);
        }

        #endregion

    }
}
