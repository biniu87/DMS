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
    public partial class SecurityClassControl : UserControl
    {
        private int _classId;
        //private ResourceManager _locRm;
        private DataShare _ds;
        public static Logger _logger = LogManager.GetCurrentClassLogger();
        /// <summary>
        /// Zawartość: kolumna, nazwa kolumny z bazy danych do aktualizacji, wartość reprezentowana przez kolumnę
        /// </summary>
        List<Tuple<DataGridViewCheckBoxColumn, string, int>> _columnsList;
        List<DataGridViewColumn> _columnsData;

        public SecurityClassControl()
        {
            InitializeComponent();
        }

        public SecurityClassControl(DataShare ds)
        {
            //_locRm = rm;
            _ds = ds;
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
            _columnsList = new List<Tuple<DataGridViewCheckBoxColumn, string, int>>();
            //_columnsList.Add(new Tuple<DataGridViewCheckBoxColumn, string, int>(dgvChkColumnClassNone, "AccessLevel", (int)Permissions.ClassPrimaryPermissions.None));
            //_columnsList.Add(new Tuple<DataGridViewCheckBoxColumn, string, int>(dgvChkColumnClassRead, "AccessLevel", (int)Permissions.ClassPrimaryPermissions.Read));
            //_columnsList.Add(new Tuple<DataGridViewCheckBoxColumn, string, int>(dgvChkColumnClassRelease, "AccessLevel", (int)Permissions.ClassPrimaryPermissions.Edit));
            //_columnsList.Add(new Tuple<DataGridViewCheckBoxColumn, string, int>(dgvChkColumnClassDelete, "AccessLevel", (int)Permissions.ClassPrimaryPermissions.Delete));
            //_columnsList.Add(new Tuple<DataGridViewCheckBoxColumn, string, int>(dgvChkColumnCanRelease, "AccessLevel", (int)Permissions.ClassPrimaryPermissions.Full));

            _columnsList.Add(new Tuple<DataGridViewCheckBoxColumn, string, int>(dgvChkColumnPrintNone, "O_Print", 0));
            _columnsList.Add(new Tuple<DataGridViewCheckBoxColumn, string, int>(dgvChkColumnPrintOnlyWith, "O_Print", 1));
            _columnsList.Add(new Tuple<DataGridViewCheckBoxColumn, string, int>(dgvChkColumnPrintFull, "O_Print", 2));

            _columnsList.Add(new Tuple<DataGridViewCheckBoxColumn, string, int>(dgvChkColumnSaveNone, "O_Save", 0));
            _columnsList.Add(new Tuple<DataGridViewCheckBoxColumn, string, int>(dgvChkColumnSaveOnlyWith, "O_Save", 1));
            _columnsList.Add(new Tuple<DataGridViewCheckBoxColumn, string, int>(dgvChkColumnSaveFull, "O_Save", 2));

            _columnsList.Add(new Tuple<DataGridViewCheckBoxColumn, string, int>(dgvChkColumnSendNone, "O_Send", 0));
            _columnsList.Add(new Tuple<DataGridViewCheckBoxColumn, string, int>(dgvChkColumnSendOnlyWith, "O_Send", 1));
            _columnsList.Add(new Tuple<DataGridViewCheckBoxColumn, string, int>(dgvChkColumnSendFull, "O_Send", 2));
            
            //4 sekcje - kolumny danych z powiązaniem z kolumnami z bazy
            _columnsData = new List<DataGridViewColumn>();
            //_columnsData.Add(dgvColumClassAccess);
            _columnsData.Add(dgvColumnPrint);
            _columnsData.Add(dgvColumnSave);
            _columnsData.Add(dgvColumnSend);

            ///podsekcje z przyciskami,tytułami i opisami
            //klasy
            //SecurityClassSectionControl securityClass = new SecurityClassSectionControl(_ds.LocRM, "lblSecurityClassSectionTitle");
            //securityClass.Tag = dgvColumClassAccess.DataPropertyName;
            //securityClass.SecurityClass_Click += new System.EventHandler(this.SecurityButton_Click);
            //flpManageColumns.Controls.Add(securityClass);

            //operacja drukowania
            SecurityOperationSectionControl securityOperationPrint = new SecurityOperationSectionControl(_ds.LocRM, "lblSecurityPrintSectionTitle");
            securityOperationPrint.Tag = dgvColumnPrint.DataPropertyName;
            securityOperationPrint.SecurityOperation_Click += new System.EventHandler(this.SecurityButton_Click);
            flpManageColumns.Controls.Add(securityOperationPrint);

            //operacja zapisywania
            SecurityOperationSectionControl securityOperationSave = new SecurityOperationSectionControl(_ds.LocRM, "lblSecuritySaveSectionTitle");
            securityOperationSave.Tag = dgvColumnSave.DataPropertyName;
            securityOperationSave.SecurityOperation_Click += new System.EventHandler(this.SecurityButton_Click);
            flpManageColumns.Controls.Add(securityOperationSave);

            //operacja wysyłania
            SecurityOperationSectionControl securityOperationSend = new SecurityOperationSectionControl(_ds.LocRM, "lblSecuritySendSectionTitle");
            securityOperationSend.Tag = dgvColumnSend.DataPropertyName;
            securityOperationSend.SecurityOperation_Click += new System.EventHandler(this.SecurityButton_Click);
            flpManageColumns.Controls.Add(securityOperationSend);
        }

        /// <summary>
        /// Ustawienie checkboxów na kolumnach jednej sekcji.
        /// </summary>
        /// <param name="rowIndex">indeks wiersza, którego sekcja ma zostać ustawiona</param>
        /// <param name="column">kolumna sekcji, mająca przyjąć wartość true, reszta kolumn w sekcji przyjmie wartość false</param>
        public void SetRowInSingleSection(int rowIndex, DataGridViewCheckBoxColumn column)
        {
            string dataName = _columnsList.First(val => val.Item1 == column).Item2;
            foreach(DataGridViewCheckBoxColumn chkCol in _columnsList.Where(col => col.Item2 == dataName).Select(col => col.Item1).ToList())
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
            DataGridViewCheckBoxColumn calumn = _columnsList.FirstOrDefault(tup => tup.Item2 == databaseColumn && tup.Item3 == weight).Item1;
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
                    DataGridViewCheckBoxColumn col = _columnsList.First(tup => ((tup.Item2 == section) && (tup.Item3 == value))).Item1;
                    SetRowInSingleSection(rowIndex, col);
                }
            }
        }

        public void SetAllRows()
        {
            foreach (DataGridViewRow row in dgvPermissions.Rows)
            {
                SetRowFromData(row.Index);
            }
        }

        private void SecurityButton_Click(object sender, EventArgs e)
        {
            //string databaseColumn = dgvColumClassAccess.DataPropertyName;
            if (sender is Button)
            {
                //potwierdzenie dokonania zmiany
                //msgApplyToAllQuestion - Czy na pewno chcesz zastosować zmianę dla wszystkich użytkowników na liście?
                DialogResult doIt = DialogBox.ShowDialog(_ds.LocRM.GetString("msgApplyToAllQuestion"), string.Empty, _ds, MessageBoxButtons.YesNo, DialogBox.Icons.Question);
                if (doIt == DialogResult.No)
                    return;
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
            if (_columnsList.Select(tup => tup.Item1.Index).ToList().Contains(e.ColumnIndex) && e.RowIndex > -1)
            {
                int securityId = -1;
                Int32.TryParse(dgvPermissions.Rows[e.RowIndex].Cells[dgvColumnSecurityId.Index].Value.ToString(), out securityId);
                Tuple<DataGridViewCheckBoxColumn, string, int> tuple = _columnsList.SingleOrDefault(tup => tup.Item1.Index == e.ColumnIndex);
                bool success = Security.UpdateSecurity(_classId, securityId, tuple.Item2, tuple.Item3.ToString());
                if (success)
                {
                    SetRowInSingleSection(e.RowIndex, tuple.Item1);
                }
            }
        }

        private void dgvPermissions_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //SetRowFromData(e.RowIndex);
            SetAllRows();
        }
        
    }
}
