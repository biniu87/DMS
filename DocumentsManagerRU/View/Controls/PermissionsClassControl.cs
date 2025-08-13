using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Windows.Documents;
using NLog;


namespace DocumentsManagerRU.View.Controls
{
    public partial class PermissionsClassControl : UserControl
    {
        private int _classId;
        private ResourceManager _locRm;
        private DataShare _ds;
        public static Logger _logger = LogManager.GetCurrentClassLogger();
        /// <summary>
        /// Zawartość: kolumna, nazwa kolumny z bazy danych do aktualizacji, wartość reprezentowana przez kolumnę
        /// </summary>
        List<Tuple<DataGridViewCheckBoxColumn, string, int>> _securityColumnsList;
        List<Tuple<DataGridViewCheckBoxColumn, string>> _securityEnablingColumnsList;
        List<DataGridViewColumn> _columnsData;
        List<DataGridViewColumn> _columnsDataEnabling;

        public PermissionsClassControl()
        {
            InitializeComponent();
        }

        public PermissionsClassControl(DataShare ds)
        {
            _ds = ds;
            _locRm = ds.LocRM;
            InitializeComponent();
            BuildColumnSections();
        }

        public void SetNewClass(int classId)
        {
            if (classId > 0)
            {
                try
                {
                    _classId = classId;
                    taDocumentPermissionsForClass.Fill(this.iTDataSet.GetDocumentPermissionsForClass, _classId);
                    //bsDocumentPermissionsForClass.ToString();
                    SetAllRows();
                }
                catch (Exception e)
                {
                    _logger.Error(string.Format("Wystąpił błąd w trakcie wypełniania danymi, tabeli poświadczeń: klasa: {0}, e: {1}", _classId, e));
                }
            }
        }

        public void BuildColumnSections()
        {
            //lista kolumn, reprezentowanych wartości zostanie oparta na sklejkach
            _securityColumnsList = new List<Tuple<DataGridViewCheckBoxColumn, string, int>>();
            _securityEnablingColumnsList = new List<Tuple<DataGridViewCheckBoxColumn, string>>();

            //lista kolumn, reprezentowanych wartości zostanie oparta na sklejkach
            _securityColumnsList = new List<Tuple<DataGridViewCheckBoxColumn, string, int>>();
            _securityColumnsList.Add(new Tuple<DataGridViewCheckBoxColumn, string, int>(dgvChkColumnClassNone, "AccessLevel", (int)Permissions.ClassPrimaryPermissions.None));
            _securityColumnsList.Add(new Tuple<DataGridViewCheckBoxColumn, string, int>(dgvChkColumnClassRead, "AccessLevel", (int)Permissions.ClassPrimaryPermissions.Read));
            _securityColumnsList.Add(new Tuple<DataGridViewCheckBoxColumn, string, int>(dgvChkColumnClassRelease, "AccessLevel", (int)Permissions.ClassPrimaryPermissions.Edit));
            _securityColumnsList.Add(new Tuple<DataGridViewCheckBoxColumn, string, int>(dgvChkColumnClassDelete, "AccessLevel", (int)Permissions.ClassPrimaryPermissions.Delete));

            _securityEnablingColumnsList.Add(new Tuple<DataGridViewCheckBoxColumn, string>(dgvChkColumnMailOnRelease, dgvColumnCS_Mail.DataPropertyName));
            _securityEnablingColumnsList.Add(new Tuple<DataGridViewCheckBoxColumn, string>(dgvChkColumnCanRelease, dgvColumnDC_Release.DataPropertyName));

            //kolumny danych z powiązaniem z kolumnami z bazy
            _columnsData = new List<DataGridViewColumn>();
            _columnsData.Add(dgvColumClassAccess);
            _columnsDataEnabling = new List<DataGridViewColumn>();
            _columnsDataEnabling.Add(dgvColumnCS_Mail);
            _columnsDataEnabling.Add(dgvColumnDC_Release);

            ///podsekcje z przyciskami,tytułami i opisami
            //klasy
            SecurityClassSectionControl securityClass = new SecurityClassSectionControl(_locRm, "lblSecurityClassSectionTitle");
            securityClass.Tag = dgvColumClassAccess.DataPropertyName;
            securityClass.SecurityClass_Click += new System.EventHandler(this.PermissionButton_Click);
            flpManageColumns.Controls.Add(securityClass);

            //ustawianie opcji włączania i wyłączania maili na zwolnienie dokumentu w klasie
            ucSectionControlNotifications permissionSendEmailOnRelease =
                new ucSectionControlNotifications(_locRm, "lblPermissionsNotificationsTitle", dgvColumnDC_Release.DataPropertyName, dgvColumnCS_Mail.DataPropertyName);
            //permissionSendEmailOnRelease.Tag = dgvColumnCS_Mail.DataPropertyName;
            //akcja dla przycisku z ustawieniem maila na zwolnienie dokumentu
            permissionSendEmailOnRelease.PermissionEnableMailAndRelease += new System.EventHandler(this.PermissionButtonEnableOption_Click);
            flpManageColumns.Controls.Add(permissionSendEmailOnRelease);
        }

        /// <summary>
        /// Ustawienie checkboxów na kolumnach jednej sekcji.
        /// </summary>
        /// <param name="rowIndex">indeks wiersza, którego sekcja ma zostać ustawiona</param>
        /// <param name="column">kolumna sekcji, mająca przyjąć wartość true, reszta kolumn w sekcji przyjmie wartość false</param>
        public void SetRowInSingleSection(int rowIndex, DataGridViewCheckBoxColumn column)
        {
            string dataName = _securityColumnsList.FirstOrDefault(val => val.Item1 == column).Item2;
            foreach (DataGridViewCheckBoxColumn chkCol in _securityColumnsList.Where(col => col.Item2 == dataName).Select(col => col.Item1).ToList())
            {
                dgvPermissions.Rows[rowIndex].Cells[chkCol.Index].Value = (chkCol == column) ? true : false;
            }
        }

        public void SetWholeSection(DataGridViewCheckBoxColumn column)
        {
            foreach (DataGridViewRow row in dgvPermissions.Rows)
            {
                SetRowInSingleSection(row.Index, column);
            }
        }

        public void SetWholeSection(string databaseColumn, int weight)
        {
            DataGridViewCheckBoxColumn calumn = _securityColumnsList.FirstOrDefault(tup => tup.Item2 == databaseColumn && tup.Item3 == weight).Item1;
            SetWholeSection(calumn);
        }

        public void SetRowFromData(int rowIndex)
        {
            foreach (DataGridViewColumn column in _columnsData)
            {
                string section = column.DataPropertyName;
                var val = dgvPermissions.Rows[rowIndex].Cells[column.Index].Value;
                int value = -1;
                Int32.TryParse(val.ToString(), out value);
                if (value != -1)
                {
                    DataGridViewCheckBoxColumn col = _securityColumnsList.FirstOrDefault(tup => ((tup.Item2 == section) && (tup.Item3 == value))).Item1;
                    SetRowInSingleSection(rowIndex, col);
                }
            }
            foreach (DataGridViewColumn column in _columnsDataEnabling)
            {
                string section = column.DataPropertyName;
                var val = dgvPermissions.Rows[rowIndex].Cells[column.Index].Value;
                bool value = Convert.ToBoolean(val.ToString());
                int columnIndex = _securityEnablingColumnsList.FirstOrDefault(tup => (tup.Item2 == section)).Item1.Index;
                dgvPermissions.Rows[rowIndex].Cells[columnIndex].Value = value;
            }
        }

        public void SetAllRows()
        {
            foreach (DataGridViewRow row in dgvPermissions.Rows)
            {
                SetRowFromData(row.Index);
            }
        }

        private void PermissionButtonEnableOption_Click(object sender, EventArgs e)
        {
            //akcja dla zaznaczenia, bądź odznaczenia całej kolumny: dla wszystkich użytkowników i jednej klasy
            if (sender is Button)
            {
                //potwierdzenie dokonania zmiany
                //msgApplyToAllQuestion - Czy na pewno chcesz zastosować zmianę dla wszystkich użytkowników na liście?
                DialogResult doIt = DialogBox.ShowDialog(_locRm.GetString("msgApplyToAllQuestion"), string.Empty, _ds, MessageBoxButtons.YesNo, DialogBox.Icons.Question);
                if (doIt == DialogResult.No)
                    return;
                Button btn = (Button)sender;
                string databaseColumn = btn.Tag.ToString();
                int columnIndex = _securityEnablingColumnsList.First(tup => tup.Item2 == databaseColumn).Item1.Index;
                bool value = IsWholeCanHideColumnChecked(columnIndex);
                bool success = Security.UpdateSecurity(_classId, 0, databaseColumn, value ? "0" : "1"); //odwrócenie wartości
                if (success)
                {
                    SetCanHideWholeColumn(columnIndex, !value);
                }
            }
        }

        private void PermissionButton_Click(object sender, EventArgs e)
        {
            //string databaseColumn = dgvColumClassAccess.DataPropertyName;
            if (sender is Button)
            {
                //potwierdzenie dokonania zmiany
                //msgApplyToAllQuestion - Czy na pewno chcesz zastosować zmianę dla wszystkich użytkowników na liście?
                DialogResult doIt = DialogBox.ShowDialog(_locRm.GetString("msgApplyToAllQuestion"), string.Empty, _ds, MessageBoxButtons.YesNo, DialogBox.Icons.Question);
                if (doIt == DialogResult.No)
                    return;
                //update całej kolumny
                Button btn = (Button)sender;
                Control ctrl = btn.Parent;
                string databaseColumn = string.Empty;
                string value = btn.Tag.ToString();
                int intValue = Int32.Parse(value);
                while (ctrl.Parent != null)
                {
                    //wyszukiwanie głównego okna i tam zapisane jest pole bazy w tagu
                    if (ctrl.Tag != null)
                    {
                        databaseColumn = ctrl.Tag.ToString();
                    }
                    ctrl = ctrl.Parent;
                }
                bool success = Security.UpdateSecurity(_classId, 0, databaseColumn, value);
                if (success)
                    SetWholeSection(databaseColumn, intValue);
            }
        }

        private void dgvPermissions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_securityColumnsList.Select(tup => tup.Item1.Index).ToList().Contains(e.ColumnIndex) && e.RowIndex > -1)
            {
                //kliknięto na kolumnę jednego z kilku poziomów dostępu do obietku Adds (zaciemnienie, notka, podświetlenie)
                int userId = -1;
                Int32.TryParse(dgvPermissions.Rows[e.RowIndex].Cells[dgvColumnSecurityId.Index].Value.ToString(), out userId);
                Tuple<DataGridViewCheckBoxColumn, string, int> tuple = _securityColumnsList.SingleOrDefault(tup => tup.Item1.Index == e.ColumnIndex);
                bool success = Security.UpdateSecurity(_classId, userId, tuple.Item2, tuple.Item3.ToString());
                if (success)
                {
                    SetRowInSingleSection(e.RowIndex, tuple.Item1);
                }
            }
            else if (_securityEnablingColumnsList.Select(tup => tup.Item1.Index).ToList().Contains(e.ColumnIndex) && e.RowIndex > -1)
            {
                //kliknięto na komórkę kolumny typu canHide- pojedyncza kolumna- pojedyncze poświadczenie
                int userId = -1;
                Int32.TryParse(dgvPermissions.Rows[e.RowIndex].Cells[dgvColumnSecurityId.Index].Value.ToString(), out userId);
                Tuple<DataGridViewCheckBoxColumn, string> tuple = _securityEnablingColumnsList.SingleOrDefault(tup => tup.Item1.Index == e.ColumnIndex);
                bool value = Convert.ToBoolean(dgvPermissions.Rows[e.RowIndex].Cells[tuple.Item1.Index].Value.ToString()); //aktualna wartość
                bool success = Security.UpdateSecurity(_classId, userId, tuple.Item2, value ? "0" : "1"); //odrwócenie wartości
                if (success)
                {
                    dgvPermissions.Rows[e.RowIndex].Cells[tuple.Item1.Index].Value = !value;
                }
            }
        }

        private bool IsWholeCanHideColumnChecked(int columnIndex)
        {
            bool result = true;
            foreach (DataGridViewRow row in dgvPermissions.Rows)
            {
                bool val = Convert.ToBoolean(row.Cells[columnIndex].Value);
                if (!val)
                    return false;
            }
            return result;
        }

        public void SetCanHideWholeColumn(int columnIndex, bool value)
        {
            foreach (DataGridViewRow row in dgvPermissions.Rows)
            {
                row.Cells[columnIndex].Value = value;
            }
        }

        private void dgvPermissions_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            SetAllRows();
        }

    }
}
