namespace DocumentsManagerRU
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDefinitionManager = new System.Windows.Forms.Button();
            this.btnReleaseDocument = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnPermissionsClass = new System.Windows.Forms.Button();
            this.btnContentManager = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btnPermissionsRecords = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnChangeColorLayout = new System.Windows.Forms.Button();
            this.statusStripInfo = new System.Windows.Forms.StatusStrip();
            this.tssLoggedUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssAppVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsMainStrip = new System.Windows.Forms.ToolStrip();
            this.tsddbAction = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiReleaseDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddbAdmin = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiNewClass = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiContentManager = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDefinitionManager = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPermissions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPermissionsRecords = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddbSuperAdmin = new System.Windows.Forms.ToolStripDropDownButton();
            this.narzędziaMigracjiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tslblSeparator = new System.Windows.Forms.ToolStripLabel();
            this.tsbRightPanelVisibility = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tslTestInfo = new System.Windows.Forms.ToolStripLabel();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpLeft = new System.Windows.Forms.TableLayoutPanel();
            this.ctrlSearch = new DocumentsManagerRU.Controls.SearchControl();
            this.lblClassTitle = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.dgvColumnClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnTableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnActiveClass = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvColumnClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnClassDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDocumentClass = new System.Windows.Forms.BindingSource(this.components);
            this.iTDataSet = new DocumentsManagerRU.ITDataSet();
            this.pnlRightPanel = new System.Windows.Forms.Panel();
            this.lblTestInfo = new System.Windows.Forms.Label();
            this.btnLang = new System.Windows.Forms.Button();
            this.taDocumentClass = new DocumentsManagerRU.ITDataSetTableAdapters.Document_ClassTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStripInfo.SuspendLayout();
            this.tsMainStrip.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.tlpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTDataSet)).BeginInit();
            this.pnlRightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.btnDefinitionManager, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnReleaseDocument, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRefresh, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPermissionsClass, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnContentManager, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAddClass, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnPermissionsRecords, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnUsers, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.btnSettings, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnChangeColorLayout, 0, 9);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // btnDefinitionManager
            // 
            resources.ApplyResources(this.btnDefinitionManager, "btnDefinitionManager");
            this.btnDefinitionManager.FlatAppearance.BorderSize = 0;
            this.btnDefinitionManager.Image = global::DocumentsManagerRU.Properties.Resources.tags_2x;
            this.btnDefinitionManager.Name = "btnDefinitionManager";
            this.btnDefinitionManager.UseVisualStyleBackColor = true;
            this.btnDefinitionManager.Click += new System.EventHandler(this.btnDefinitionManager_Click);
            // 
            // btnReleaseDocument
            // 
            resources.ApplyResources(this.btnReleaseDocument, "btnReleaseDocument");
            this.btnReleaseDocument.FlatAppearance.BorderSize = 0;
            this.btnReleaseDocument.Image = global::DocumentsManagerRU.Properties.Resources.paperclip_2x;
            this.btnReleaseDocument.Name = "btnReleaseDocument";
            this.btnReleaseDocument.UseVisualStyleBackColor = true;
            this.btnReleaseDocument.Click += new System.EventHandler(this.releaseDocument_Click);
            // 
            // btnRefresh
            // 
            resources.ApplyResources(this.btnRefresh, "btnRefresh");
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // btnPermissionsClass
            // 
            resources.ApplyResources(this.btnPermissionsClass, "btnPermissionsClass");
            this.btnPermissionsClass.FlatAppearance.BorderSize = 0;
            this.btnPermissionsClass.Image = global::DocumentsManagerRU.Properties.Resources.folder_2x;
            this.btnPermissionsClass.Name = "btnPermissionsClass";
            this.btnPermissionsClass.UseVisualStyleBackColor = true;
            this.btnPermissionsClass.Click += new System.EventHandler(this.btnPermissions_Click);
            // 
            // btnContentManager
            // 
            resources.ApplyResources(this.btnContentManager, "btnContentManager");
            this.btnContentManager.FlatAppearance.BorderSize = 0;
            this.btnContentManager.Name = "btnContentManager";
            this.btnContentManager.UseVisualStyleBackColor = true;
            this.btnContentManager.Click += new System.EventHandler(this.btnContentManager_Click);
            // 
            // btnAddClass
            // 
            resources.ApplyResources(this.btnAddClass, "btnAddClass");
            this.btnAddClass.FlatAppearance.BorderSize = 0;
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.newClass_Click);
            // 
            // btnPermissionsRecords
            // 
            resources.ApplyResources(this.btnPermissionsRecords, "btnPermissionsRecords");
            this.btnPermissionsRecords.FlatAppearance.BorderSize = 0;
            this.btnPermissionsRecords.Image = global::DocumentsManagerRU.Properties.Resources.spreadsheet_2x;
            this.btnPermissionsRecords.Name = "btnPermissionsRecords";
            this.btnPermissionsRecords.UseVisualStyleBackColor = true;
            this.btnPermissionsRecords.Click += new System.EventHandler(this.btnPermissionsRecords_Click);
            // 
            // btnUsers
            // 
            resources.ApplyResources(this.btnUsers, "btnUsers");
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.close_Click);
            // 
            // btnSettings
            // 
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnChangeColorLayout
            // 
            resources.ApplyResources(this.btnChangeColorLayout, "btnChangeColorLayout");
            this.btnChangeColorLayout.FlatAppearance.BorderSize = 0;
            this.btnChangeColorLayout.Image = global::DocumentsManagerRU.Properties.Resources.dms_layout_icon16;
            this.btnChangeColorLayout.Name = "btnChangeColorLayout";
            this.btnChangeColorLayout.UseVisualStyleBackColor = true;
            this.btnChangeColorLayout.Click += new System.EventHandler(this.btnChangeColorLayout_Click);
            // 
            // statusStripInfo
            // 
            resources.ApplyResources(this.statusStripInfo, "statusStripInfo");
            this.statusStripInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLoggedUser,
            this.toolStripStatusLabel2,
            this.tssAppVersion,
            this.toolStripStatusLabel1,
            this.tssDatabase});
            this.statusStripInfo.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStripInfo.Name = "statusStripInfo";
            this.statusStripInfo.SizingGrip = false;
            // 
            // tssLoggedUser
            // 
            this.tssLoggedUser.Name = "tssLoggedUser";
            resources.ApplyResources(this.tssLoggedUser, "tssLoggedUser");
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
            // 
            // tssAppVersion
            // 
            this.tssAppVersion.Name = "tssAppVersion";
            resources.ApplyResources(this.tssAppVersion, "tssAppVersion");
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // tssDatabase
            // 
            this.tssDatabase.Name = "tssDatabase";
            resources.ApplyResources(this.tssDatabase, "tssDatabase");
            // 
            // tsMainStrip
            // 
            this.tsMainStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.tsMainStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbAction,
            this.tsddbAdmin,
            this.tsddbSuperAdmin,
            this.tslblSeparator,
            this.tsbRightPanelVisibility,
            this.toolStripLabel1,
            this.tslTestInfo});
            resources.ApplyResources(this.tsMainStrip, "tsMainStrip");
            this.tsMainStrip.Name = "tsMainStrip";
            // 
            // tsddbAction
            // 
            this.tsddbAction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbAction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReleaseDocument,
            this.toolStripSeparator1,
            this.tsmiRefresh,
            this.tsmiAbout,
            this.tsmiClose});
            resources.ApplyResources(this.tsddbAction, "tsddbAction");
            this.tsddbAction.Name = "tsddbAction";
            // 
            // tsmiReleaseDocument
            // 
            this.tsmiReleaseDocument.Image = global::DocumentsManagerRU.Properties.Resources.paperclip_2x;
            this.tsmiReleaseDocument.Name = "tsmiReleaseDocument";
            resources.ApplyResources(this.tsmiReleaseDocument, "tsmiReleaseDocument");
            this.tsmiReleaseDocument.Click += new System.EventHandler(this.releaseDocument_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // tsmiRefresh
            // 
            resources.ApplyResources(this.tsmiRefresh, "tsmiRefresh");
            this.tsmiRefresh.Name = "tsmiRefresh";
            this.tsmiRefresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Image = global::DocumentsManagerRU.Properties.Resources.info_2x;
            this.tsmiAbout.Name = "tsmiAbout";
            resources.ApplyResources(this.tsmiAbout, "tsmiAbout");
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tsmiClose
            // 
            resources.ApplyResources(this.tsmiClose, "tsmiClose");
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.Click += new System.EventHandler(this.close_Click);
            // 
            // tsddbAdmin
            // 
            this.tsddbAdmin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewClass,
            this.tsmiContentManager,
            this.tsmiDefinitionManager,
            this.tsmiPermissions,
            this.tsmiPermissionsRecords,
            this.tsmiUsers,
            this.tsmiSettings});
            resources.ApplyResources(this.tsddbAdmin, "tsddbAdmin");
            this.tsddbAdmin.Name = "tsddbAdmin";
            // 
            // tsmiNewClass
            // 
            resources.ApplyResources(this.tsmiNewClass, "tsmiNewClass");
            this.tsmiNewClass.Name = "tsmiNewClass";
            this.tsmiNewClass.Click += new System.EventHandler(this.newClass_Click);
            // 
            // tsmiContentManager
            // 
            resources.ApplyResources(this.tsmiContentManager, "tsmiContentManager");
            this.tsmiContentManager.Name = "tsmiContentManager";
            this.tsmiContentManager.Click += new System.EventHandler(this.btnContentManager_Click);
            // 
            // tsmiDefinitionManager
            // 
            this.tsmiDefinitionManager.Image = global::DocumentsManagerRU.Properties.Resources.tags_2x;
            this.tsmiDefinitionManager.Name = "tsmiDefinitionManager";
            resources.ApplyResources(this.tsmiDefinitionManager, "tsmiDefinitionManager");
            this.tsmiDefinitionManager.Click += new System.EventHandler(this.btnDefinitionManager_Click);
            // 
            // tsmiPermissions
            // 
            this.tsmiPermissions.Image = global::DocumentsManagerRU.Properties.Resources.folder_2x;
            this.tsmiPermissions.Name = "tsmiPermissions";
            resources.ApplyResources(this.tsmiPermissions, "tsmiPermissions");
            this.tsmiPermissions.Click += new System.EventHandler(this.btnPermissions_Click);
            // 
            // tsmiPermissionsRecords
            // 
            this.tsmiPermissionsRecords.Image = global::DocumentsManagerRU.Properties.Resources.spreadsheet_2x;
            this.tsmiPermissionsRecords.Name = "tsmiPermissionsRecords";
            resources.ApplyResources(this.tsmiPermissionsRecords, "tsmiPermissionsRecords");
            this.tsmiPermissionsRecords.Click += new System.EventHandler(this.btnPermissionsRecords_Click);
            // 
            // tsmiUsers
            // 
            resources.ApplyResources(this.tsmiUsers, "tsmiUsers");
            this.tsmiUsers.Name = "tsmiUsers";
            this.tsmiUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // tsmiSettings
            // 
            resources.ApplyResources(this.tsmiSettings, "tsmiSettings");
            this.tsmiSettings.Name = "tsmiSettings";
            this.tsmiSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // tsddbSuperAdmin
            // 
            this.tsddbSuperAdmin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbSuperAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.narzędziaMigracjiToolStripMenuItem});
            resources.ApplyResources(this.tsddbSuperAdmin, "tsddbSuperAdmin");
            this.tsddbSuperAdmin.Name = "tsddbSuperAdmin";
            // 
            // narzędziaMigracjiToolStripMenuItem
            // 
            this.narzędziaMigracjiToolStripMenuItem.Image = global::DocumentsManagerRU.Properties.Resources.aperture_2x;
            this.narzędziaMigracjiToolStripMenuItem.Name = "narzędziaMigracjiToolStripMenuItem";
            resources.ApplyResources(this.narzędziaMigracjiToolStripMenuItem, "narzędziaMigracjiToolStripMenuItem");
            this.narzędziaMigracjiToolStripMenuItem.Click += new System.EventHandler(this.tsbMigrationTools_Click);
            // 
            // tslblSeparator
            // 
            this.tslblSeparator.Name = "tslblSeparator";
            resources.ApplyResources(this.tslblSeparator, "tslblSeparator");
            // 
            // tsbRightPanelVisibility
            // 
            this.tsbRightPanelVisibility.Image = global::DocumentsManagerRU.Properties.Resources.circle_check_2x;
            resources.ApplyResources(this.tsbRightPanelVisibility, "tsbRightPanelVisibility");
            this.tsbRightPanelVisibility.Name = "tsbRightPanelVisibility";
            this.tsbRightPanelVisibility.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            resources.ApplyResources(this.toolStripLabel1, "toolStripLabel1");
            // 
            // tslTestInfo
            // 
            resources.ApplyResources(this.tslTestInfo, "tslTestInfo");
            this.tslTestInfo.ForeColor = System.Drawing.Color.Red;
            this.tslTestInfo.Name = "tslTestInfo";
            // 
            // tlpMain
            // 
            resources.ApplyResources(this.tlpMain, "tlpMain");
            this.tlpMain.Controls.Add(this.tlpLeft, 0, 0);
            this.tlpMain.Controls.Add(this.pnlRightPanel, 2, 0);
            this.tlpMain.Name = "tlpMain";
            // 
            // tlpLeft
            // 
            resources.ApplyResources(this.tlpLeft, "tlpLeft");
            this.tlpLeft.Controls.Add(this.ctrlSearch, 0, 2);
            this.tlpLeft.Controls.Add(this.lblClassTitle, 0, 0);
            this.tlpLeft.Controls.Add(this.btnSearch, 0, 3);
            this.tlpLeft.Controls.Add(this.dgvClass, 0, 1);
            this.tlpLeft.Name = "tlpLeft";
            this.tlpLeft.SizeChanged += new System.EventHandler(this.tlpLeft_SizeChanged);
            // 
            // ctrlSearch
            // 
            resources.ApplyResources(this.ctrlSearch, "ctrlSearch");
            this.ctrlSearch.Name = "ctrlSearch";
            // 
            // lblClassTitle
            // 
            resources.ApplyResources(this.lblClassTitle, "lblClassTitle");
            this.lblClassTitle.Name = "lblClassTitle";
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvClass
            // 
            this.dgvClass.AllowUserToAddRows = false;
            this.dgvClass.AllowUserToDeleteRows = false;
            this.dgvClass.AllowUserToResizeColumns = false;
            this.dgvClass.AllowUserToResizeRows = false;
            this.dgvClass.AutoGenerateColumns = false;
            this.dgvClass.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClass.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumnClassId,
            this.dgvColumnTableName,
            this.dgvColumnActiveClass,
            this.dgvColumnClassName,
            this.dgvColumnClassDescription});
            this.dgvClass.DataSource = this.bsDocumentClass;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClass.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dgvClass, "dgvClass");
            this.dgvClass.MultiSelect = false;
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.ReadOnly = true;
            this.dgvClass.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClass.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClass.SelectionChanged += new System.EventHandler(this.lstClass_SelectedIndexChanged);
            // 
            // dgvColumnClassId
            // 
            this.dgvColumnClassId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnClassId.DataPropertyName = "Id";
            resources.ApplyResources(this.dgvColumnClassId, "dgvColumnClassId");
            this.dgvColumnClassId.Name = "dgvColumnClassId";
            this.dgvColumnClassId.ReadOnly = true;
            // 
            // dgvColumnTableName
            // 
            this.dgvColumnTableName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnTableName.DataPropertyName = "Table_Name";
            resources.ApplyResources(this.dgvColumnTableName, "dgvColumnTableName");
            this.dgvColumnTableName.Name = "dgvColumnTableName";
            this.dgvColumnTableName.ReadOnly = true;
            // 
            // dgvColumnActiveClass
            // 
            this.dgvColumnActiveClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnActiveClass.DataPropertyName = "Active";
            resources.ApplyResources(this.dgvColumnActiveClass, "dgvColumnActiveClass");
            this.dgvColumnActiveClass.Name = "dgvColumnActiveClass";
            this.dgvColumnActiveClass.ReadOnly = true;
            // 
            // dgvColumnClassName
            // 
            this.dgvColumnClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvColumnClassName.DataPropertyName = "CurrentName";
            resources.ApplyResources(this.dgvColumnClassName, "dgvColumnClassName");
            this.dgvColumnClassName.Name = "dgvColumnClassName";
            this.dgvColumnClassName.ReadOnly = true;
            // 
            // dgvColumnClassDescription
            // 
            this.dgvColumnClassDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnClassDescription.DataPropertyName = "CurrentDescription";
            resources.ApplyResources(this.dgvColumnClassDescription, "dgvColumnClassDescription");
            this.dgvColumnClassDescription.Name = "dgvColumnClassDescription";
            this.dgvColumnClassDescription.ReadOnly = true;
            // 
            // bsDocumentClass
            // 
            this.bsDocumentClass.DataMember = "Document_Class";
            this.bsDocumentClass.DataSource = this.iTDataSet;
            // 
            // iTDataSet
            // 
            this.iTDataSet.DataSetName = "ITDataSet";
            this.iTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlRightPanel
            // 
            this.pnlRightPanel.Controls.Add(this.lblTestInfo);
            this.pnlRightPanel.Controls.Add(this.tableLayoutPanel1);
            this.pnlRightPanel.Controls.Add(this.btnLang);
            resources.ApplyResources(this.pnlRightPanel, "pnlRightPanel");
            this.pnlRightPanel.Name = "pnlRightPanel";
            // 
            // lblTestInfo
            // 
            resources.ApplyResources(this.lblTestInfo, "lblTestInfo");
            this.lblTestInfo.ForeColor = System.Drawing.Color.Red;
            this.lblTestInfo.Name = "lblTestInfo";
            // 
            // btnLang
            // 
            resources.ApplyResources(this.btnLang, "btnLang");
            this.btnLang.FlatAppearance.BorderSize = 0;
            this.btnLang.Image = global::DocumentsManagerRU.Properties.Resources.book_2x;
            this.btnLang.Name = "btnLang";
            this.btnLang.UseVisualStyleBackColor = true;
            this.btnLang.Click += new System.EventHandler(this.btnLang0_Click);
            // 
            // taDocumentClass
            // 
            this.taDocumentClass.ClearBeforeFill = true;
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.tsMainStrip);
            this.Controls.Add(this.statusStripInfo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStripInfo.ResumeLayout(false);
            this.statusStripInfo.PerformLayout();
            this.tsMainStrip.ResumeLayout(false);
            this.tsMainStrip.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.tlpLeft.ResumeLayout(false);
            this.tlpLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTDataSet)).EndInit();
            this.pnlRightPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripInfo;
        private System.Windows.Forms.ToolStripStatusLabel tssLoggedUser;
        private System.Windows.Forms.ToolStripStatusLabel tssDatabase;
        private System.Windows.Forms.ToolStrip tsMainStrip;
        private System.Windows.Forms.ToolStripDropDownButton tsddbAction;
        private System.Windows.Forms.ToolStripMenuItem tsmiReleaseDocument;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpLeft;
        private System.Windows.Forms.Label lblClassTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnReleaseDocument;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefresh;
        private System.Windows.Forms.ToolStripStatusLabel tssAppVersion;
        private ITDataSet iTDataSet;
        //private ITDataSetTableAdapters.DocumentTableAdapter taDocuments;
        private System.Windows.Forms.Button btnPermissionsClass;
        private System.Windows.Forms.BindingSource bsDocumentClass;
        private ITDataSetTableAdapters.Document_ClassTableAdapter taDocumentClass;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ToolStripDropDownButton tsddbAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiPermissions;
        private System.Windows.Forms.ToolStripMenuItem tsmiSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsers;
        private System.Windows.Forms.Button btnSearch;
        //private ITDataSetTableAdapters.GetDocumentsSearchTableAdapter taGetDocumentsSearch;
        //private ITDataSetTableAdapters.Document_ContractorTableAdapter taSearchDocumentContractor;
        private System.Windows.Forms.Button btnContentManager;
        private Controls.SearchControl ctrlSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button btnLang;
        private System.Windows.Forms.Panel pnlRightPanel;
        private System.Windows.Forms.ToolStripButton tsbRightPanelVisibility;
        private System.Windows.Forms.ToolStripLabel tslblSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewClass;
        private System.Windows.Forms.ToolStripMenuItem tsmiContentManager;
        private System.Windows.Forms.Button btnDefinitionManager;
        private System.Windows.Forms.ToolStripMenuItem tsmiDefinitionManager;
        private System.Windows.Forms.Button btnPermissionsRecords;
        private System.Windows.Forms.ToolStripMenuItem tsmiPermissionsRecords;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnTableName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvColumnActiveClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnClassDescription;
        private System.Windows.Forms.Button btnChangeColorLayout;
        private System.Windows.Forms.ToolStripDropDownButton tsddbSuperAdmin;
        private System.Windows.Forms.ToolStripMenuItem narzędziaMigracjiToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel tslTestInfo;
        private System.Windows.Forms.Label lblTestInfo;
    }
}

