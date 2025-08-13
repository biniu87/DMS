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
using DocumentViewer.Controls.Viewer;
using NLog;
using DocumentsManagerRU.View;

namespace DocumentsManagerRU
{
    public partial class DGVDocumentControl : UserControl
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        private DataShare _ds;
        //private ResourceManager _locRM;
        //public ResourceManager LocRM { get { return _locRM; } }
        private frmMain _main;

        //zastosowanie zbiorów kolumn pozwoli na wyłączenie ingerencji w kolumny standardowe, modyfikowane z poziomu bazy danych
        private List<DataGridViewColumn> _DocumentColumnsStandard = new List<DataGridViewColumn>();
        private List<DataGridViewColumn> _DocumentColumnsTools = new List<DataGridViewColumn>();
        private List<DataGridViewColumn> _DocumentColumnsIndex = new List<DataGridViewColumn>();

        private int _classId;
        ClassPermissions _classPermissions;
        //private Document _document;
        //private List<Document_Index> _documentIndexes;
        //private List<Document_Definitions> _documentDefinitions;

        System.Windows.Forms.DataGridViewCellStyle gridViewCellStyleDate = new System.Windows.Forms.DataGridViewCellStyle();

        List<GetDocumentDefinitionsForClass_Result> _definitionsForClass;

        private Document_Class _loadedClass;
        /// <summary>
        /// Całkowita liczba dokumentów klasy
        /// </summary>
        private Int64 _queryDocumentsCount = 1;
        /// <summary>
        /// Numer pierwszego dokumentu wyświetlanego na stronie
        /// </summary>
        private Int64 _queryPageBegin = 1;
        /// <summary>
        /// Numer ostatniego dokumentu wyświetlanego na stronie
        /// </summary>
        private Int64 _queryPageEnd = 100;
        /// <summary>
        /// Liczba dokumentów na stronie
        /// </summary>
        private int _queryPageSize = 50;
        /// <summary>
        /// Całkowita liczba stron w klasie
        /// </summary>
        private int _queryPageCount = 1;
        /// <summary>
        /// Aktualnie wyświetlana strona
        /// </summary>
        private int _queryPageActual = 1;
        /// <summary>
        /// Kwerenda pobierająca dokumenty do wyświetlenia
        /// </summary>
        private string _selectQuery;
        /// <summary>
        /// Warunek dodawany do kwerendy pobierającej dane jak i kwerendy zliczającej całkowitą liczbę dokumentów do wyświetlenia
        /// </summary>
        private string _queryConditions = "WHERE Active = 1";
        /// <summary>
        /// Warunki sortowania wyników
        /// </summary>
        private string _queryOrder;

        public enum QueryNavigation
        {
            Current = 0,
            First = 1,
            Previous = 2,
            Next = 3,
            Last = 4,
            Specific = 5
        }

        public DGVDocumentControl(frmMain main, DataShare ds)
        {
            InitializeComponent();
            //pobieranie wszystkich kolumn stworzonych na poziomie designera
            SetSortingColumnsModeToProgrammatic();
            foreach (DataGridViewColumn column in dgvDocuments.Columns)
            {
                if (column is DataGridViewImageColumn || column.Equals(dgvColumnRowNumber))// || column.Index == dgvChkColumnActivate.Index)
                {
                    _DocumentColumnsTools.Add(column);
                }
                else
                {
                    _DocumentColumnsStandard.Add(column);
                }
            }
            _main = main;
            _ds = ds;
            _classPermissions = _main.ClassPermissions;
            //_locRM = _main.LocRM;
            LanguageController.SetLanguage(this, _ds.LocRM);
            ColorLayoutController.SetColors(this, _ds.ColorLayout, new Control[] { flpUpperNavigator, flpLowerNavigator });
            flpUpperNavigator.BackColor = flpLowerNavigator.BackColor = _ds.ColorLayout.COLOR_OBJECTS;
            dgvColumnDetails.ToolTipText = _ds.LocRM.GetString("ttDetails");
            dgvColumnOpen.ToolTipText = _ds.LocRM.GetString("ttOpen");
        }

        private void PrepareDGVDocument()
        {
            //czyszczenie aktualnej listy kolumn. tworzenie nowej oraz nadanie nowej kolejności 
            dgvDocuments.Columns.Clear();
            dgvDocuments.Columns.AddRange(_DocumentColumnsTools.ToArray());
            dgvDocuments.Columns.AddRange(_DocumentColumnsStandard.ToArray());
            dgvDocuments.Columns.AddRange(_DocumentColumnsIndex.ToArray());
            int displayIndex = 0;
            foreach (DataGridViewColumn col in dgvDocuments.Columns)
            {
                col.DisplayIndex = displayIndex;
                displayIndex++;
            }
            //aktualizacja widoczności kolumny - admin widzi zawsze, zwykły user w zależności od uprawnień
            _classPermissions = _main.ClassPermissions;
            if (_classPermissions == null)
            {
                _classPermissions = new ClassPermissions();
            }
            dgvColumnEdit.Visible = Security.Admin || _classPermissions.PrimaryPermission >= Permissions.ClassPrimaryPermissions.Edit;
            dgvColumnEditFile.Visible = Security.Admin || _classPermissions.CanRelease; // _classPermissions.PrimaryPermission >= Permissions.ClassPrimaryPermissions.Edit;
            dgvChkColumnActivate.Visible = Security.Admin || _classPermissions.PrimaryPermission >= Permissions.ClassPrimaryPermissions.Delete;
            if (!Security.Admin)
                SetQueryConditions(" WHERE Active = 1");
            else
                SetQueryConditions("");

            //FreezeToolsColumns(); - jeszcze nie, ale już niedługo

            PrepareSQLParams();
            ClearSort();
            UpdateData();
        }

        public void SetSelectedClass(int classId, List<GetDocumentDefinitionsForClass_Result> definitionsList = null)
        {
            if (classId == -1)
            {
                SetSelectedClass(null, definitionsList);
            }
            else
            {
                SetSelectedClass(Data.GetClassById(classId), definitionsList);
            }
        }

        public void SetSelectedClass(Document_Class docClass, List<GetDocumentDefinitionsForClass_Result> definitionsList)
        {
            if (docClass == null)
            {
                _loadedClass = null;
                _classId = -1;
            }
            else
            {
                _loadedClass = docClass;
                _classId = _loadedClass.Id;
            }
            if (definitionsList != null)
            {
                _definitionsForClass = definitionsList;
            }
            InitializeIndexColumns();
            PrepareDGVDocument();
        }

        public Int64 GetSelectedDocumentId()
        {
            Int64 tmp = 0;
            Int64.TryParse(dgvDocuments.CurrentRow.Cells[dgvColumnId.Index].Value.ToString(), out tmp);
            return tmp;
        }

        public string GetSelectedDocumentName()
        {
            return dgvDocuments.CurrentRow.Cells[dgvColumnName.Index].Value.ToString();
        }

        private void PrepareSQLParams()
        {
            UpdateCount();
            Int32.TryParse(cbPager.Text, out _queryPageSize);
            _queryPageBegin = 1;
            _queryPageActual = 1;
            ReCalculateQueryParams();
        }

        private void InitializeIndexColumns()
        {
            //List<GetDocumentDefinitionsForClass_Result> ddRes = Data.GetDocumentsDefinitionsForClassByLanguage(_classId, _ds.Language).ToList();
            if (_definitionsForClass == null)
            {
                _definitionsForClass = Data.GetDocumentsDefinitionsForClassByLanguage(_classId, _ds.Language).ToList();
            }
            _DocumentColumnsIndex.Clear();
            foreach (GetDocumentDefinitionsForClass_Result dd in _definitionsForClass)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();
                //column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
                column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
                column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
                column.DataPropertyName = dd.ColumnName;
                column.HeaderText = dd.CurrentName;
                column.Name = dd.ColumnName;
                column.ReadOnly = false;
                column.Visible = dd.Active.Value;
                column.ToolTipText = dd.CurrentDescription;
                if (dd.DataType.Value == (int)Data.IndexTypes.Date)
                {
                    gridViewCellStyleDate = new DataGridViewCellStyle();
                    gridViewCellStyleDate.NullValue = null;
                    gridViewCellStyleDate.Format = "d";
                    column.DefaultCellStyle = gridViewCellStyleDate;
                }
                _DocumentColumnsIndex.Add(column);
            }
        }

        private void SetSortingColumnsModeToProgrammatic()
        {
            foreach (DataGridViewColumn column in dgvDocuments.Columns)
            {
                if (_DocumentColumnsIndex.Contains(column) || _DocumentColumnsStandard.Contains(column))
                {
                    column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
                }
                else
                {
                    //kolumny znajdujące się grupie kolumn-narzędzi, nie będą pozwalały na sortowania
                    column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
                }
            }
        }

        private void ClearSort()
        {
            foreach (DataGridViewColumn column in dgvDocuments.Columns)
            {
                if (_DocumentColumnsIndex.Contains(column) || _DocumentColumnsStandard.Contains(column))
                {
                    column.HeaderCell.SortGlyphDirection = SortOrder.None;
                    column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
                }
            }
            _queryOrder = "ORDER BY Id ASC";
        }

        private void UpdateQueryOrder(string columnName, string order)
        {
            _queryOrder = string.Format("ORDER BY {0} {1}", columnName == "lp" ? "Id" : columnName, order);
        }

        private void UpdateSorting(int columnIndex)
        {
            bool IsColumnTool = _DocumentColumnsTools.Select(ind => ind.Index).Contains(columnIndex) && columnIndex != dgvChkColumnActivate.Index; //wszystkie prócz dodatkowych
            if (columnIndex > -1 && !IsColumnTool)
            {
                SortOrder order = dgvDocuments.Columns[columnIndex].HeaderCell.SortGlyphDirection;
                string bindingColumn = dgvDocuments.Columns[columnIndex].DataPropertyName;
                string ord = string.Empty;
                if (order == SortOrder.None)
                {
                    order = SortOrder.Ascending;
                    ord = "ASC";
                }
                else if (order == SortOrder.Ascending)
                {
                    order = SortOrder.Descending;
                    ord = "DESC";
                }
                else if (order == SortOrder.Descending)
                {
                    order = SortOrder.Ascending;
                    ord = "ASC";
                }
                ClearSort();
                UpdateQueryOrder(bindingColumn, ord);
                UpdateData();
                dgvDocuments.Columns[columnIndex].HeaderCell.SortGlyphDirection = order;
            }
        }

        private void SetStatusNavigator()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(_queryPageBegin);
            builder.Append(" - ");
            builder.Append(_queryPageEnd);
            builder.Append(" / ");
            builder.Append(_queryDocumentsCount);
            builder.Append(string.Format(" ({0})", _queryPageActual));
            lblStatusNavigator.Text = lblStatusNavigator1.Text = builder.ToString();
        }

        /// <summary>
        /// Finalizuje wyświetlenie danych na gridzie
        /// </summary>
        private void UpdateData()
        {
            UpdateNavigation();
            CreateQueryConditions(Security.Admin); // zawsze sprawdza, czy user jest adminem
            //UpdateQuerySelect2(); // zaktualizowana wersja kwerendy pobierania danych z bazy
            ApplyData();
        }

        private void UpdateNavigation()
        {
            SetStatusNavigator();
            if (_queryPageBegin < 2)
            {
                btnFirst.Enabled = btnPrev.Enabled = btnFirst1.Enabled = btnPrev1.Enabled = false;
            }
            else
            {
                btnFirst.Enabled = btnPrev.Enabled = btnFirst1.Enabled = btnPrev1.Enabled = true;
            }
            if (_queryPageEnd >= _queryDocumentsCount)
            {
                btnLast.Enabled = btnNext.Enabled = btnLast1.Enabled = btnNext1.Enabled = false;
            }
            else
            {
                btnLast.Enabled = btnNext.Enabled = btnLast1.Enabled = btnNext1.Enabled = true;
            }
        }

        /// <summary>
        /// Aktualizacja całkowitej liczby dokumentów, oraz stron
        /// </summary>
        private void UpdateCount()
        {
            if (_classId == -1)
            {
                _queryPageCount = 1;
                return;
            }
            _queryDocumentsCount = Data.GetDocumentInClassCount(_loadedClass.Table_Name, _queryConditions);
            if (_queryDocumentsCount > -1)
            {
                _queryPageCount = (int)_queryDocumentsCount / _queryPageSize + (_queryPageCount % _queryPageSize > 0 ? 1 : 0);
            }
        }

        private void UpdateActualPage(QueryNavigation qn, int pageNumber = 0)
        {
            UpdateCount();
            switch (qn)
            {
                case QueryNavigation.First:
                    _queryPageBegin = 1;
                    break;
                case QueryNavigation.Previous:
                    _queryPageBegin = _queryPageBegin - _queryPageSize;
                    if (_queryPageBegin < 1)
                        _queryPageBegin = 1;
                    break;
                case QueryNavigation.Next:
                    _queryPageBegin = _queryPageBegin + _queryPageSize;
                    break;
                case QueryNavigation.Last:
                    _queryPageBegin = (_queryPageCount - 1) * _queryPageSize + 1;
                    break;
                case QueryNavigation.Specific:
                    if (pageNumber > 0)
                    {
                        _queryPageBegin = (pageNumber - 1) * _queryPageSize + 1;
                    }
                    break;
                default:
                    //tylko przekalkuluje strony
                    break;
            }
            //sprawdzanie, czy nie przekroczono zakresu ustawianych parametrów
            ReCalculateQueryParams();
            UpdateData();
        }
        
        private void ReCalculateQueryParams()
        {
            //walidacja początku i końca aktualnej strony
            if (_queryPageBegin > _queryDocumentsCount)
            {
                _queryPageBegin = _queryDocumentsCount;
            }
            if (_queryDocumentsCount > 0 && _queryPageBegin == 0)
            {
                _queryPageBegin = 1;
            }
            _queryPageEnd = _queryPageBegin + _queryPageSize - 1;
            if (_queryPageEnd > _queryDocumentsCount)
            {
                _queryPageEnd = _queryDocumentsCount;
            }
            //rekalkulacja stron
            _queryPageActual = (int)(_queryPageBegin / _queryPageSize) + (_queryPageBegin % _queryPageSize > 0 ? 1 : 0);
            if (_queryPageCount < _queryPageActual)
            {
                _queryPageActual = _queryPageCount;
            }
            if (_queryPageActual < 1)
            {
                _queryPageActual = 1;
            }
        }

        private void UpdateQuerySelect()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(string.Format(" SELECT TOP {0} * FROM ", _queryPageSize));
            builder.Append(string.Format("(SELECT ROW_NUMBER() OVER ({0}) AS nr ", _queryOrder));
            builder.Append(string.Format(", * "));
            builder.Append(string.Format(" FROM {0} {1}) AS tab ", _loadedClass.Table_Name, _queryConditions));
            builder.Append(string.Format("WHERE tab.nr >= {0} and tab.nr <= {1} ", _queryPageBegin, _queryPageEnd));
            _selectQuery = builder.ToString();
        }

        private void UpdateQuerySelect2kopia()
        {
            if (_loadedClass != null)
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(string.Format(" SELECT TOP {0} * FROM ", _queryPageSize));
                builder.Append(string.Format("(SELECT ROW_NUMBER() OVER ({0}) AS nr ", _queryOrder));
                builder.Append(string.Format(", * "));
                builder.Append(string.Format(" FROM (SELECT ROW_NUMBER() OVER (ORDER BY Id ASC) as lp, * FROM {0} (NOLOCK) {1}) AS tab0 ) AS tab ", _loadedClass.Table_Name, _queryConditions));
                builder.Append(string.Format("WHERE tab.nr >= {0} and tab.nr <= {1} ", _queryPageBegin, _queryPageEnd));
                _selectQuery = builder.ToString();
            }
        }

        private void UpdateQuerySelect2kopia2()
        {
            if (_loadedClass != null)
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(string.Format(" SELECT TOP {0} * FROM ", _queryPageSize));
                builder.Append(string.Format("(SELECT ROW_NUMBER() OVER ({0}) AS nr ", _queryOrder));
                builder.Append(string.Format(", * "));
                builder.Append(string.Format(" FROM (SELECT TOP {0} ROW_NUMBER() OVER (ORDER BY Id ASC) as lp, * FROM {1} (NOLOCK) {2}) AS tab0 ) AS tab ", _queryPageEnd, _loadedClass.Table_Name, _queryConditions));
                builder.Append(string.Format("WHERE tab.nr >= {0} and tab.nr <= {1} ", _queryPageBegin, _queryPageEnd));
                _selectQuery = builder.ToString();
            }
        }

        //W tej chwili wykorzystywana jest ta wersja
        private void UpdateQuerySelect2()
        {
            if (_loadedClass != null)
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(string.Format("SELECT TOP({0}) * FROM ", _queryPageSize));
                builder.Append(string.Format("(SELECT TOP({0}) ROW_NUMBER() OVER ({1}) AS lp, Id FROM {2} (NOLOCK) {3}) ", _queryPageEnd, _queryOrder, _loadedClass.Table_Name, _queryConditions));
                builder.Append(string.Format("AS tab JOIN {0} d (NOLOCK) on tab.Id = d.Id WHERE tab.lp >= {1} and tab.lp <= {2} ", _loadedClass.Table_Name, _queryPageBegin, _queryPageEnd));

                //builder.Append(string.Format(", * "));
                //builder.Append(string.Format(" FROM (SELECT TOP {0} ROW_NUMBER() OVER (ORDER BY Id ASC) as lp, * FROM {1} (NOLOCK) {2}) AS tab0 ) AS tab ", _queryPageEnd, _loadedClass.Table_Name, _conditions));
                //builder.Append(string.Format("WHERE tab.nr >= {0} and tab.nr <= {1} ", _queryPageBegin, _queryPageEnd));
                _selectQuery = builder.ToString();
            }
        }

        private void ApplyData()
        {
            if (_loadedClass != null)
            {
                //bsDocuments.DataSource = Data.GetSQLTableValue(_selectQuery);
                bsDocuments.DataSource = Data.GetDocumentsInClassByDirectives(_loadedClass.Table_Name, _queryOrder, _queryConditions, _queryPageSize, _queryPageBegin, _queryPageEnd);
                //Console.WriteLine(_selectQuery);
            }
            else
            {
                bsDocuments.DataSource = null;
            }
        }

        public void RefreshGrid()
        {
            UpdateActualPage(QueryNavigation.Current);
        }

        public void RunSelectedFile()
        {
            var @url = dgvDocuments.CurrentRow.Cells[dgvColumnURL.Index].Value.ToString();
            var docName = GetSelectedDocumentName();
            var docId = GetSelectedDocumentId();
            Data.ShowDocument(docId, _classId, Security.SecurityObjects, @url, _ds.Language, docName, Security.Admin, false, GlobalSettings.ScanOperator, _ds.UseExternalViewer);
        }

        public void OpenEditForm()
        {
            Int64 documentId;
            Int64.TryParse(dgvDocuments.CurrentRow.Cells[dgvColumnId.Index].Value.ToString(), out documentId);
            frmEditDocument editor = new frmEditDocument(documentId, _classId, _main, _ds);
            _ds.SetColors(editor);
            LanguageController.SetLanguage(editor, _ds.LocRM);
            editor.ShowDialog();
        }

        public void OpenEditFileForm()
        {
            Int64 documentId;
            Int64.TryParse(dgvDocuments.CurrentRow.Cells[dgvColumnId.Index].Value.ToString(), out documentId);
            frmEditDocumentFile editor = new frmEditDocumentFile(documentId, _classId, _main, _ds);
            _ds.SetColors(editor);
            LanguageController.SetLanguage(editor, _ds.LocRM);
            editor.ShowDialog();
        }

        public void ChangeActive(string tableName, Int64 documentId, bool active)
        {
            //UPDATE Document_000001 SET Active = 0 WHERE Id = 1
            string sql = string.Format("Update {0} SET Active = {1}, Deactivate_Date = {2} WHERE Id = {3}", tableName, 
                active ? 1 : 0, active ? "NULL" : ("'" + DateTime.Now.ToString() + "'"), documentId);
            Data.GetSQLSingleValue(sql);
        }

        public void SetActualPage(int pageNumber)
        {
            UpdateActualPage(QueryNavigation.Specific, pageNumber);
        }

        public void SetQueryConditions(string conditions)
        {
            _queryPageBegin = 1; //reset przy wyszukiwaniu
            _queryConditions = Permissions.IncludePermissionsItemsConditions(conditions, _main.PermisionToListItems, Security.Admin);
        }

        public void CreateQueryConditions(bool isAdmin)
        {
            _queryConditions = Permissions.IncludePermissionsItemsConditions(_main.GetQueryConditions(isAdmin), _main.PermisionToListItems, Security.Admin);
        }

        public void Search(string conditions)
        {
            if (_classId < 1)
                return;
            SetQueryConditions(conditions);
            UpdateData();
        }

        public void FreezeToolsColumns()
        {
            foreach (var col in _DocumentColumnsTools)
            {
                col.Frozen = true;
            }
        }

        public void UnfreezeToolsColumns()
        {
            foreach (var col in _DocumentColumnsTools)
            {
                col.Frozen = false;
            }
        }

        #region Events

        private void dgvDocuments_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                UpdateSorting(e.ColumnIndex);
            }
            else if (sender is DataGridView)
            {
                if (e.ColumnIndex == dgvColumnOpen.Index)
                {
                    RunSelectedFile();
                }
                else if (e.ColumnIndex == dgvColumnDetails.Index)
                {
                    _main.OpenDetailsForm();
                }
                else if (e.ColumnIndex == dgvColumnEdit.Index)
                {
                    OpenEditForm();
                }
                else if (e.ColumnIndex == dgvColumnEditFile.Index)
                {
                    OpenEditFileForm();
                }
                else if (e.ColumnIndex == dgvChkColumnActivate.Index)
                {
                    DialogResult result = DialogBox.ShowDialog(_ds.LocRM.GetString("msg30"), string.Empty, _ds, 
                        MessageBoxButtons.OKCancel, DialogBox.Icons.Question); //Potwierdź zmianę statusu aktywności dokumentu
                    if (result == DialogResult.OK)
                    {
                        Int64 selectedId = -1;
                        Int64.TryParse(dgvDocuments.Rows[e.RowIndex].Cells[dgvColumnId.Index].Value.ToString(), out selectedId);
                        bool actualActive;
                        bool.TryParse(dgvDocuments.Rows[e.RowIndex].Cells[dgvChkColumnActivate.Index].Value.ToString(), out actualActive);
                        //wywołanie polecenia modyfikującego flagę aktywności, oraz datę deaktywacji
                        ChangeActive(_loadedClass.Table_Name, selectedId, !actualActive);
                        dgvDocuments.Rows[e.RowIndex].Cells[dgvChkColumnActivate.Index].Value = !actualActive;
                    }
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            _queryPageSize = Convert.ToInt32(cbPager.Text);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            //FirstPage();
            UpdateActualPage(QueryNavigation.First);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            //PreviousPage();
            UpdateActualPage(QueryNavigation.Previous);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //NextPage();
            UpdateActualPage(QueryNavigation.Next);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            //LastPage();
            UpdateActualPage(QueryNavigation.Last);
        }

        private void cbPager_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPager1.Text = cbPager.Text;
            Int32.TryParse(cbPager.Text, out  _queryPageSize);
            UpdateActualPage(QueryNavigation.Current);
        }

        private void dgvDocuments_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex > -1)
                RunSelectedFile();
        }

        private void cbPager1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //wywoła aktualizację na głównym boksie zmiany liczby dokumentów na stronę
            cbPager.Text = cbPager1.Text;
        }

        private void lblStatusNavigator_Click(object sender, EventArgs e)
        {
            //wywołanie slidera na kliknięcie - szerokość odpowiadająca całemu paskowi
            PageBox box = new PageBox(this, _queryPageCount, _queryPageActual, _queryPageSize, _queryDocumentsCount);
            _ds.SetColors(box);
            box.Width = flpUpperNavigator.DisplayRectangle.Width;
            box.Location = flpUpperNavigator.PointToScreen(new Point(0, 0));/*new Point()X, flpUpperNavigator. Location.Y + flpUpperNavigator.DisplayRectangle.Height*/
            box.Show();
        }

        #endregion

        private void dgvDocuments_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        /*
         *       SELECT TOP 1000 * FROM                               --- zakres wyświetlania
         *       (SELECT ROW_NUMBER() OVER (ORDER BY Name ASC) AS nr  --- warunek sortowania
         *       , *                                                  --- lista kolumn do wyświetlenia
         *       FROM [IT].[dbo].[Document]) AS tab                   --- tabela źródłowa
         *       WHERE tab.nr > 10 and tab.nr < 20                    --- zakres strony
         *
         *       SELECT count(*) FROM [IT].[dbo].[Document]
         */
    }
}
