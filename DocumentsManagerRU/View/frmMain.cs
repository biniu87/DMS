using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentsManagerRU.Controls;
using DocumentsManagerRU.View;
using NLog;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.DirectoryServices.AccountManagement;

namespace DocumentsManagerRU
{
    public partial class frmMain : Form
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        private frmDetails _frmDetails;
        private DataShare _ds;
        private int _currentClassId = -1;
        private int _tmpRightPanelWidth;
        private bool _canLoadClassList = false;
        public DataShare share;
        private ClassPermissions _classPermissions;
        public ClassPermissions ClassPermissions
        { get { return _classPermissions; } }
        private List<GetDocumentListItemsPermissionsToSelect_Result> _permisionToListItems;
        public List<GetDocumentListItemsPermissionsToSelect_Result> PermisionToListItems
        { get { return _permisionToListItems; } }
        private List<GetDocumentDefinitionsForClass_Result> _definitionList;
        public DGVDocumentControl _ctrlDocuments;
        private frmAddDocument addDocumentForm;

        public frmMain(DataShare ds)
        {
            _ds = ds;
            _ds.SetFrmMain(this);
            InitializeComponent();
            _tmpRightPanelWidth = btnLang.DisplayRectangle.Width;
            _ds.SetColors(this);
            SetColorsOfSearchPanel();
            SetToolStripInfos();
            ds.SetLanguageToDefault();

            if(Data.IsTestDatabase())
            {
                frmAbout about = new frmAbout(_ds);
                _ds.SetColors(about);
                LanguageController.SetLanguage(about, _ds.LocRM);
                about.StartPosition = FormStartPosition.CenterScreen;
                about.TopMost = true;
                about.ShowDialog();
            }
        }

        #region Public Methods

        public int GetSelectedClassId()
        {
            try
            {
                if (dgvClass.SelectedRows.Count == 1)
                {
                    int index = 0;
                    int.TryParse(dgvClass.SelectedRows[0].Cells[dgvColumnClassId.Index].Value.ToString(), out index);
                    return index;
                    //return ((DocumentsManagerRU.ITDataSet.Document_ClassRow)this.iTDataSet.Document_Class.Rows[dgvClass.SelectedRows[0].Index]).Id;
                }
                //if (lstClass.SelectedIndex >= 0)
                //    return ((DocumentsManagerRU.ITDataSet.Document_ClassRow)this.iTDataSet.Document_Class.Rows[lstClass.SelectedIndex]).Id;
                else
                    return -1;
            }
            catch (Exception e)
            {
                _logger.Error(e, "Błąd pobrania Id zaznaczonej klasy, e: {0}", e);
                return -1;
            }
        }

        public void RefreshClassList()
        {
            if (!_canLoadClassList) return;
            this.taDocumentClass.FillToReadRelease(this.iTDataSet.Document_Class, _ds.Language, Security.SecurityObjects, 
                (int)Permissions.ClassPrimaryPermissions.Read, (int)Permissions.ClassSecondaryPermissions.None);
        }

        public void RefreshDocumentGridFull()
        {
            ActiveSearch(false);
            var classId = GetSelectedClassId();
            if (classId > 0 && _currentClassId != classId)
            {
                _currentClassId = classId;
                _classPermissions = Permissions.GetPermissionsVector(classId, Security.SecurityObjects);
                _permisionToListItems = Permissions.GetDocumentListItemsPermissionsToSelectClass(classId, Security.SecurityObjects).ToList();
                _definitionList = Data.GetDocumentsDefinitionsForClassByLanguage(classId, _ds.Language);
            }
            SetDGVDocuments();
            SetUIForUser();
        }

        public void RefreshDocumentGridSimple()
        {
            _ctrlDocuments.RefreshGrid();
        }

        public void RefreshData()
        {
            RefreshClassList();
            //RefreshDocumentGridFull();
        }

        public void RefreshPermissions()
        {
            var id = GetSelectedClassId();
            _classPermissions = Permissions.GetPermissionsVector(id, Security.SecurityObjects);
            _permisionToListItems = Permissions.GetDocumentListItemsPermissionsToSelectClass(id, Security.SecurityObjects).ToList();
        }

        public void SelectClass(int classId)
        {
            if (classId == -1) dgvClass.ClearSelection();
            int i = 0;
            
            while (i < dgvClass.Rows.Count)
            {
                var val = dgvClass.Rows[i].Cells[dgvColumnClassId.Index].Value.ToString();
                if (val.Equals(classId.ToString()))
                {
                    dgvClass.Rows[i].Selected = true;
                    return;
                }
                //DataRowView drvRow = (DataRowView)lstClass.Items[i];
                //ITDataSet.Document_ClassRow row = (ITDataSet.Document_ClassRow) drvRow.Row;
                //if (row.Id == classId)
                //{
                //    lstClass.SelectedIndex = i;
                //    return;
                //}
                i++;
            }
        }

        public void OpenAddDocumentForm()
        {
            if (addDocumentForm == null || addDocumentForm.IsDisposed)
            {
                addDocumentForm = new frmAddDocument(this, _ds);
                _ds.SetColors(addDocumentForm);
                LanguageController.SetLanguage(addDocumentForm, _ds.LocRM);
                addDocumentForm.Show();
            }
            else if (addDocumentForm.WindowState == FormWindowState.Minimized)
            {
                addDocumentForm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                addDocumentForm.Visible = true;
                addDocumentForm.Focus();
            }
        }

        public void OpenAddClassFom()
        {
            frmAddClass addClassForm = new frmAddClass(_ds);
            _ds.SetColors(addClassForm);
            LanguageController.SetLanguage(addClassForm, _ds.LocRM);
            addClassForm.ShowDialog();
        }

        public void OpenPermissionsManagerForm()
        {
            frmPermissionManager permissionsManager = new frmPermissionManager(_ds);
            _ds.SetColors(permissionsManager);
            LanguageController.SetLanguage(permissionsManager, _ds.LocRM);
            permissionsManager.ShowDialog();
        }

        public void OpenPermissionListItemsManager()
        {
            frmPermissionListItemsManager permissionsManager = new frmPermissionListItemsManager(_ds);
            _ds.SetColors(permissionsManager);
            LanguageController.SetLanguage(permissionsManager, _ds.LocRM);
            permissionsManager.ShowDialog();
        }

        public void OpenSettingsForm()
        {
            frmSettings settings = new frmSettings(_ds);
            _ds.SetColors(settings);
            LanguageController.SetLanguage(settings, _ds.LocRM);
            settings.ShowDialog();
        }

        public void OpenMigrationTools()
        {
            frmMigrationTools migration = new frmMigrationTools(_ds);
            _ds.SetColors(migration);
            LanguageController.SetLanguage(migration, _ds.LocRM);
            migration.ShowDialog();
        }

        public void OpenDetailsForm()
        {
            if (_frmDetails != null)
            {
                _frmDetails.Close();
            }
            _frmDetails = new frmDetails(_ds);
            _ds.SetColors(_frmDetails);
            Int64 docId = _ctrlDocuments.GetSelectedDocumentId();
            int classId = GetSelectedClassId();
            Document_Class cl = Data.GetClassById(classId);
            Document doc = Data.GetDocumentById(docId, classId);
            _frmDetails.SetFields(doc, cl);
            LanguageController.SetLanguage(_frmDetails, _ds.LocRM);
            _frmDetails.Location = new Point(this.Location.X + (this.Width / 2) - (_frmDetails.Width / 2), this.Location.Y + (this.Height / 2) - (_frmDetails.Height / 2));
            _frmDetails.Show();
            _frmDetails.Activate();
        }

        public void OpenUsersManagerForm()
        {
            frmSecurityManager usersManager = new frmSecurityManager(_ds);
            _ds.SetColors(usersManager);
            LanguageController.SetLanguage(usersManager, _ds.LocRM);
            usersManager.ShowDialog();
        }

        public void OpenContentManagerForm()
        {
            frmContentManager contentManager = new frmContentManager(_ds);
            _ds.SetColors(contentManager);
            LanguageController.SetLanguage(contentManager, _ds.LocRM);
            contentManager.ShowDialog();
        }

        public void OpenDefinitionManager()
        {
            frmDefinitionManager definitionManager = new frmDefinitionManager(_ds);
            _ds.SetColors(definitionManager);
            LanguageController.SetLanguage(definitionManager, _ds.LocRM);
            definitionManager.ShowDialog();
        }

        public void OpenAbout()
        {
            frmAbout about = new frmAbout(_ds);
            _ds.SetColors(about);
            LanguageController.SetLanguage(about, _ds.LocRM);
            about.ShowDialog();
        }

        public void SetUIForUser()
        {
            //var canEdit = _admin || _classPermissions.Contains(Data.ClassPrimaryPermissions.Full) || _classPermissions.Contains(Data.ClassPrimaryPermissions.Edit);
            //var canDelete = _admin || _classPermissions.Contains(Data.ClassPrimaryPermissions.Full) || _classPermissions.Contains(Data.ClassPrimaryPermissions.Delete);
            btnAddClass.Visible = Security.Admin;
            btnContentManager.Visible = Security.Admin;
            btnPermissionsClass.Visible = Security.Admin;
            btnPermissionsRecords.Visible = Security.Admin;
            btnUsers.Visible = Security.Admin;
            btnSettings.Visible = Security.Admin;
            btnDefinitionManager.Visible = Security.Admin;
            tsddbAdmin.Visible = Security.Admin;
            tssDatabase.Visible = Security.Admin;

            tsddbSuperAdmin.Visible = Security.IsSuperUser();

            lblTestInfo.Visible = tslTestInfo.Visible = Data.IsTestDatabase();
        }

        public void ShowSearchPanel()
        {
            //aktywowanie panelu wyszukiwania
            if (!this.tlpLeft.Controls.Contains(ctrlSearch))
            {
                tlpLeft.SetRowSpan(dgvClass, 1);
                var classId = GetSelectedClassId();
                ctrlSearch = new SearchControl(this, _ds, _definitionList.Where(def => def.Active == true).ToList());
                _ds.SetColors(ctrlSearch);
                AdjustSearchPanel();
                this.tlpLeft.Controls.Add(ctrlSearch, 0, 2);
                ctrlSearch.Dock = DockStyle.Fill;
            }
        }

        public void HideSearchPanel()
        {
            //wyłączenie panelu wyszukiwania
            if (this.tlpLeft.Controls.Contains(ctrlSearch))
            {
                this.tlpLeft.Controls.Remove(ctrlSearch);
                tlpLeft.SetRowSpan(dgvClass, 2);
            }
        }

        public void ChangeRightPanelVisibility()
        {
            if (this.tlpMain.ColumnStyles[tlpMain.ColumnStyles.Count - 1].Width == 0)
            {
                //ukrywamy
                //this.tlpMain.Controls.Remove(pnlRightPanel);
                this.tlpMain.ColumnStyles[tlpMain.ColumnStyles.Count - 1].Width = _tmpRightPanelWidth;
                tsbRightPanelVisibility.Image = DocumentsManagerRU.Properties.Resources.circle_check_2x;

            }
            else
            {
                //pokazujemy
                this.tlpMain.ColumnStyles[tlpMain.ColumnStyles.Count - 1].Width = 0;
                tsbRightPanelVisibility.Image = DocumentsManagerRU.Properties.Resources.circle_x_2x;
                //this.tlpMain.Controls.ad
            }
        }

        public bool IsActiveSearchPanel()
        {
            return this.tlpLeft.Controls.Contains(ctrlSearch);
        }

        public string GetQueryConditions(bool isAdmin)
        {
            if (this.tlpLeft.Controls.Contains(ctrlSearch))
            {
                //jeżeli kontrolka jest wyświetlona
                return ctrlSearch.CreateQueryConditions(isAdmin);
            }
            else
            {
                if (isAdmin)
                    return "";
                else
                    return "WHERE Active = 1";
            }
        }

        #endregion

        #region Private Methods

        private void SetToolStripInfos()
        {
            SetUserInfo();
            SetDatabaseInfo();
            SetAppVersionInfo();
        }

        private void SetUserInfo()
        {
            var userLogin = Security.GetUserLogin();
            tssLoggedUser.Text = userLogin;
        }

        private void SetDatabaseInfo()
        {
            var info = Data.GetFormattedDatabaseName();
            tssDatabase.Text = info;
        }

        private void SetAppVersionInfo()
        {
            tssAppVersion.Text = _ds.LocRM.GetString("titleAppVersion") + Data.GetAppVersion(); //Wersja aplikacji: 
        }

        private void ActiveSearch(bool active)
        {
            if (active)
            {
                ShowSearchPanel();
            }
            else
            {
                HideSearchPanel();
            }
        }

        private void AdjustSearchPanel()
        {
            int h = ctrlSearch.GetComponentHeight();
            int hMax = this.tlpLeft.Height - 100;
            if (hMax < 0) hMax = 0;
            if (h > hMax) h = hMax;
            this.tlpLeft.RowStyles[2].Height = h;
        }

        private void SetDGVDocuments()
        {
            if (_ctrlDocuments == null)
            {
                _ctrlDocuments = new DGVDocumentControl(this, _ds);
                tlpMain.Controls.Add(_ctrlDocuments, 1, 0);
                _ctrlDocuments.Dock = System.Windows.Forms.DockStyle.Fill;
            }
            var id = this.GetSelectedClassId();
            _ctrlDocuments.SetSelectedClass(id, _definitionList);
            //if(id > 0)
            //    _definitionList = Data.GetDocumentsDefinitionsForClassByLanguage(id, _ds.Language);
        }

        private void SetColorsOfSearchPanel()
        {
            this.ctrlSearch.BackColor = _ds.ColorLayout.COLOR_OBJECTS;
            foreach (Control ctrl in ctrlSearch.Controls)
            {
                if (ctrl is Label)
                {
                    ctrl.BackColor = _ds.ColorLayout.COLOR_OBJECTS;
                }
            }
        }

        private void ClearSearchForm()
        {
            ctrlSearch.ClearControl();
        }

        private void DoSearch()
        {
            if (IsActiveSearchPanel())
            {
                //akcja dla wyszukiwania
                string conditions = ctrlSearch.CreateQueryConditions(Security.Admin);
                _ctrlDocuments.Search(conditions);
            }
            else
            {
                //SelectClass(-1);
                ClearSearchForm();
                ActiveSearch(true);
            }
        }

        #endregion

        #region Events

        private void frmMain_Load(object sender, EventArgs e)
        {
            _canLoadClassList = true;
            RefreshData();
        }

        private void newClass_Click(object sender, EventArgs e)
        {
            OpenAddClassFom();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void releaseDocument_Click(object sender, EventArgs e)
        {
            OpenAddDocumentForm();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPermissions_Click(object sender, EventArgs e)
        {
            OpenPermissionsManagerForm();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenUsersManagerForm();
        }

        private void lstClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDocumentGridFull();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenSettingsForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearch();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoSearch();
            }
        }

        private void btnContentManager_Click(object sender, EventArgs e)
        {
            OpenContentManagerForm();
        }

        private void tlpLeft_SizeChanged(object sender, EventArgs e)
        {
            AdjustSearchPanel();
        }


        private void btnDefinitionManager_Click(object sender, EventArgs e)
        {
            OpenDefinitionManager();
        }

        private void btnPermissionsRecords_Click(object sender, EventArgs e)
        {
            OpenPermissionListItemsManager();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            OpenAbout();
        }

        private void tsbMigrationTools_Click(object sender, EventArgs e)
        {
            OpenMigrationTools();
        }

        private void btnChangeColorLayout_Click(object sender, EventArgs e)
        {
            OpenChangeColorLayoutForm();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ChangeRightPanelVisibility();
        }

        #endregion

        #region Language Stuff

        public void SetLanguage()
        {
            try
            {
                //_language = lang.ToUpper();
                //_canChangeLanguagePermission = false; //zabezpieczenie dla zmiany zaznaczenia w combo boxie
                SetLanguageButton(_ds.Language);
                LanguageController.SetLanguage(this, _ds.LocRM);
                LanguageController.SetLanguage(tsMainStrip, _ds.LocRM);
                tssAppVersion.Text = _ds.LocRM.GetString("titleAppVersion") + Data.GetAppVersion();
                
                //poniższe polecenia zostaną usunięte po zaakceptowaniu zmian
                //tsddLanguage.Text = _ds.Language;
                //cbLanguage.DataSource = Data.GetLanguageTable(_ds.LocRM);
                //cbLanguage.ValueMember = "prefix";
                //cbLanguage.DisplayMember = "title";
                //cbLanguage.SelectedValue = _ds.Language;
            }
            catch (Exception)
            {
            }
            finally
            {
                //_canChangeLanguagePermission = true;
            }
            RefreshData();
        }

        private void tsddLanguage_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            _ds.SetLanguage(e.ClickedItem.Text);
        }

        #endregion

        private void SetLanguageButton(string lang)
        {
            DataTable langTable = LanguageController.GetLanguageTable(_ds.LocRM);
            btnLang.Text = LanguageController.GetLanguageTitle(_ds.LocRM, lang);
        }

        private void btnLang0_Click(object sender, EventArgs e)
        {
            //funkcjonalność tymczasowo nie będzie dostępna
            //LanguageBox langBox = new LanguageBox(_ds);
            //Data.SetColors(langBox);
            //langBox.Size = new System.Drawing.Size(btnLang.DisplayRectangle.Width, langBox.DisplayRectangle.Height);
            //langBox.Location = ((Control)sender).PointToScreen(new Point(0, 0 - langBox.DisplayRectangle.Height));
            //langBox.Show();
        }


        private void OpenChangeColorLayoutForm()
        {
            frmColorLayoutChooser colors = new frmColorLayoutChooser(_ds);
            colors.StartPosition = FormStartPosition.CenterParent;
            _ds.SetColors(colors);
            LanguageController.SetLanguage(colors, _ds.LocRM);
            colors.ShowDialog();
        }
    }

}
