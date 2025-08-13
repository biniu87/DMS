namespace DocumentsManagerRU.View
{
    partial class frmPermissionListItemsManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpLeft = new System.Windows.Forms.TableLayoutPanel();
            this.tlpDefinitionClass = new System.Windows.Forms.TableLayoutPanel();
            this.lblDocumentClass = new System.Windows.Forms.Label();
            this.dgvDefinitions = new System.Windows.Forms.DataGridView();
            this.dgvColumnDefinitionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnDefinitionCurrentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnDefinitionCurrentDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDefinitions = new System.Windows.Forms.BindingSource(this.components);
            this.iTDataSet = new DocumentsManagerRU.ITDataSet();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.dgvColumnClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnClassDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDocumentClass = new System.Windows.Forms.BindingSource(this.components);
            this.lblDocumentDefinition = new System.Windows.Forms.Label();
            this.tlpSecurity = new System.Windows.Forms.TableLayoutPanel();
            this.btnSelectAllGroups = new System.Windows.Forms.Button();
            this.dgvSecurity = new System.Windows.Forms.DataGridView();
            this.dgvColumnSecurityType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnSecurityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnSecurityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnSecurityDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnSecurityIsGroup = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsDocumentSecurity = new System.Windows.Forms.BindingSource(this.components);
            this.lblGroups = new System.Windows.Forms.Label();
            this.tlpRight = new System.Windows.Forms.TableLayoutPanel();
            this.btnSelectAllRecords = new System.Windows.Forms.Button();
            this.lblDocumentListItems = new System.Windows.Forms.Label();
            this.tlpItemsButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddPermissions = new System.Windows.Forms.Button();
            this.btnRemovePermissions = new System.Windows.Forms.Button();
            this.dgvPermissions = new System.Windows.Forms.DataGridView();
            this.bsDocumentListItemsPermissions = new System.Windows.Forms.BindingSource(this.components);
            this.taDefinitions = new DocumentsManagerRU.ITDataSetTableAdapters.GetDocumentDefinitionsByDirectiveTableAdapter();
            this.taDocumentClass = new DocumentsManagerRU.ITDataSetTableAdapters.Document_ClassTableAdapter();
            this.taDocumentSecurity = new DocumentsManagerRU.ITDataSetTableAdapters.GetDocumentSecurityTableAdapter();
            this.taDocumentListItemsPermissions = new DocumentsManagerRU.ITDataSetTableAdapters.GetDocumentListItemsPermissionsTableAdapter();
            this.dgvColumnPermissionPermissionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnPermissionClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnPermissionSecurityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnPermissionDefinitionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnPermissionItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnPermissionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnPermission = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvColPermissionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColPermission = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tlpMain.SuspendLayout();
            this.tlpLeft.SuspendLayout();
            this.tlpDefinitionClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefinitions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDefinitions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentClass)).BeginInit();
            this.tlpSecurity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecurity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentSecurity)).BeginInit();
            this.tlpRight.SuspendLayout();
            this.tlpItemsButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentListItemsPermissions)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.Controls.Add(this.tlpLeft, 0, 0);
            this.tlpMain.Controls.Add(this.tlpRight, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1221, 661);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpLeft
            // 
            this.tlpLeft.ColumnCount = 1;
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeft.Controls.Add(this.tlpDefinitionClass, 0, 0);
            this.tlpLeft.Controls.Add(this.tlpSecurity, 0, 1);
            this.tlpLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeft.Location = new System.Drawing.Point(0, 0);
            this.tlpLeft.Margin = new System.Windows.Forms.Padding(0);
            this.tlpLeft.Name = "tlpLeft";
            this.tlpLeft.RowCount = 2;
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLeft.Size = new System.Drawing.Size(814, 661);
            this.tlpLeft.TabIndex = 0;
            // 
            // tlpDefinitionClass
            // 
            this.tlpDefinitionClass.ColumnCount = 2;
            this.tlpDefinitionClass.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDefinitionClass.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDefinitionClass.Controls.Add(this.lblDocumentClass, 1, 0);
            this.tlpDefinitionClass.Controls.Add(this.dgvDefinitions, 0, 1);
            this.tlpDefinitionClass.Controls.Add(this.dgvClass, 0, 1);
            this.tlpDefinitionClass.Controls.Add(this.lblDocumentDefinition, 0, 0);
            this.tlpDefinitionClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDefinitionClass.Location = new System.Drawing.Point(0, 0);
            this.tlpDefinitionClass.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDefinitionClass.Name = "tlpDefinitionClass";
            this.tlpDefinitionClass.RowCount = 2;
            this.tlpDefinitionClass.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpDefinitionClass.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDefinitionClass.Size = new System.Drawing.Size(814, 330);
            this.tlpDefinitionClass.TabIndex = 0;
            // 
            // lblDocumentClass
            // 
            this.lblDocumentClass.AutoSize = true;
            this.lblDocumentClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDocumentClass.Location = new System.Drawing.Point(410, 0);
            this.lblDocumentClass.Name = "lblDocumentClass";
            this.lblDocumentClass.Size = new System.Drawing.Size(401, 27);
            this.lblDocumentClass.TabIndex = 2;
            this.lblDocumentClass.Text = "lblDocumentClass";
            this.lblDocumentClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDefinitions
            // 
            this.dgvDefinitions.AllowUserToAddRows = false;
            this.dgvDefinitions.AllowUserToDeleteRows = false;
            this.dgvDefinitions.AllowUserToResizeRows = false;
            this.dgvDefinitions.AutoGenerateColumns = false;
            this.dgvDefinitions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDefinitions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDefinitions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDefinitions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDefinitions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumnDefinitionId,
            this.dgvColumnDefinitionCurrentName,
            this.dgvColumnDefinitionCurrentDescription});
            this.dgvDefinitions.DataSource = this.bsDefinitions;
            this.dgvDefinitions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDefinitions.Location = new System.Drawing.Point(0, 27);
            this.dgvDefinitions.Margin = new System.Windows.Forms.Padding(0);
            this.dgvDefinitions.MultiSelect = false;
            this.dgvDefinitions.Name = "dgvDefinitions";
            this.dgvDefinitions.ReadOnly = true;
            this.dgvDefinitions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDefinitions.Size = new System.Drawing.Size(407, 303);
            this.dgvDefinitions.TabIndex = 1;
            this.dgvDefinitions.SelectionChanged += new System.EventHandler(this.dgvDefinitions_SelectionChanged);
            // 
            // dgvColumnDefinitionId
            // 
            this.dgvColumnDefinitionId.DataPropertyName = "Id";
            this.dgvColumnDefinitionId.HeaderText = "dgvColumnDefinitionId";
            this.dgvColumnDefinitionId.Name = "dgvColumnDefinitionId";
            this.dgvColumnDefinitionId.ReadOnly = true;
            this.dgvColumnDefinitionId.Visible = false;
            // 
            // dgvColumnDefinitionCurrentName
            // 
            this.dgvColumnDefinitionCurrentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnDefinitionCurrentName.DataPropertyName = "CurrentName";
            this.dgvColumnDefinitionCurrentName.HeaderText = "dgvColumnDefinitionCurrentName";
            this.dgvColumnDefinitionCurrentName.Name = "dgvColumnDefinitionCurrentName";
            this.dgvColumnDefinitionCurrentName.ReadOnly = true;
            this.dgvColumnDefinitionCurrentName.Width = 200;
            // 
            // dgvColumnDefinitionCurrentDescription
            // 
            this.dgvColumnDefinitionCurrentDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvColumnDefinitionCurrentDescription.DataPropertyName = "CurrentDescription";
            this.dgvColumnDefinitionCurrentDescription.HeaderText = "dgvColumnDefinitionCurrentDescription";
            this.dgvColumnDefinitionCurrentDescription.Name = "dgvColumnDefinitionCurrentDescription";
            this.dgvColumnDefinitionCurrentDescription.ReadOnly = true;
            // 
            // bsDefinitions
            // 
            this.bsDefinitions.DataMember = "GetDocumentDefinitionsByDirective";
            this.bsDefinitions.DataSource = this.iTDataSet;
            // 
            // iTDataSet
            // 
            this.iTDataSet.DataSetName = "ITDataSet";
            this.iTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvClass
            // 
            this.dgvClass.AllowUserToAddRows = false;
            this.dgvClass.AllowUserToDeleteRows = false;
            this.dgvClass.AllowUserToResizeRows = false;
            this.dgvClass.AutoGenerateColumns = false;
            this.dgvClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClass.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumnClassId,
            this.dgvColumnClassName,
            this.dgvColumnClassDescription});
            this.dgvClass.DataSource = this.bsDocumentClass;
            this.dgvClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClass.Location = new System.Drawing.Point(407, 27);
            this.dgvClass.Margin = new System.Windows.Forms.Padding(0);
            this.dgvClass.MultiSelect = false;
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.ReadOnly = true;
            this.dgvClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClass.Size = new System.Drawing.Size(407, 303);
            this.dgvClass.TabIndex = 3;
            this.dgvClass.SelectionChanged += new System.EventHandler(this.dgvClass_SelectionChanged);
            // 
            // dgvColumnClassId
            // 
            this.dgvColumnClassId.DataPropertyName = "Id";
            this.dgvColumnClassId.HeaderText = "dgvColumnClassId";
            this.dgvColumnClassId.Name = "dgvColumnClassId";
            this.dgvColumnClassId.ReadOnly = true;
            this.dgvColumnClassId.Visible = false;
            // 
            // dgvColumnClassName
            // 
            this.dgvColumnClassName.DataPropertyName = "CurrentName";
            this.dgvColumnClassName.HeaderText = "dgvColumnClassName";
            this.dgvColumnClassName.Name = "dgvColumnClassName";
            this.dgvColumnClassName.ReadOnly = true;
            this.dgvColumnClassName.Width = 200;
            // 
            // dgvColumnClassDescription
            // 
            this.dgvColumnClassDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvColumnClassDescription.DataPropertyName = "CurrentDescription";
            this.dgvColumnClassDescription.HeaderText = "dgvColumnClassDescription";
            this.dgvColumnClassDescription.Name = "dgvColumnClassDescription";
            this.dgvColumnClassDescription.ReadOnly = true;
            // 
            // bsDocumentClass
            // 
            this.bsDocumentClass.DataMember = "Document_Class";
            this.bsDocumentClass.DataSource = this.iTDataSet;
            // 
            // lblDocumentDefinition
            // 
            this.lblDocumentDefinition.AutoSize = true;
            this.lblDocumentDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDocumentDefinition.Location = new System.Drawing.Point(3, 0);
            this.lblDocumentDefinition.Name = "lblDocumentDefinition";
            this.lblDocumentDefinition.Size = new System.Drawing.Size(401, 27);
            this.lblDocumentDefinition.TabIndex = 0;
            this.lblDocumentDefinition.Text = "lblDocumentDefinition";
            this.lblDocumentDefinition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpSecurity
            // 
            this.tlpSecurity.ColumnCount = 1;
            this.tlpSecurity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSecurity.Controls.Add(this.btnSelectAllGroups, 0, 2);
            this.tlpSecurity.Controls.Add(this.dgvSecurity, 0, 1);
            this.tlpSecurity.Controls.Add(this.lblGroups, 0, 0);
            this.tlpSecurity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSecurity.Location = new System.Drawing.Point(0, 330);
            this.tlpSecurity.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSecurity.Name = "tlpSecurity";
            this.tlpSecurity.RowCount = 3;
            this.tlpSecurity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpSecurity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSecurity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpSecurity.Size = new System.Drawing.Size(814, 331);
            this.tlpSecurity.TabIndex = 1;
            // 
            // btnSelectAllGroups
            // 
            this.btnSelectAllGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectAllGroups.Image = global::DocumentsManagerRU.Properties.Resources.check_2x;
            this.btnSelectAllGroups.Location = new System.Drawing.Point(0, 304);
            this.btnSelectAllGroups.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectAllGroups.Name = "btnSelectAllGroups";
            this.btnSelectAllGroups.Size = new System.Drawing.Size(814, 27);
            this.btnSelectAllGroups.TabIndex = 2;
            this.btnSelectAllGroups.UseVisualStyleBackColor = true;
            this.btnSelectAllGroups.Click += new System.EventHandler(this.btnSelectAllGroups_Click);
            // 
            // dgvSecurity
            // 
            this.dgvSecurity.AllowUserToAddRows = false;
            this.dgvSecurity.AllowUserToDeleteRows = false;
            this.dgvSecurity.AllowUserToResizeRows = false;
            this.dgvSecurity.AutoGenerateColumns = false;
            this.dgvSecurity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSecurity.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSecurity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSecurity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSecurity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumnSecurityType,
            this.dgvColumnSecurityId,
            this.dgvColumnSecurityName,
            this.dgvColumnSecurityDescription,
            this.dgvColumnSecurityIsGroup});
            this.dgvSecurity.DataSource = this.bsDocumentSecurity;
            this.dgvSecurity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSecurity.Location = new System.Drawing.Point(0, 27);
            this.dgvSecurity.Margin = new System.Windows.Forms.Padding(0);
            this.dgvSecurity.Name = "dgvSecurity";
            this.dgvSecurity.ReadOnly = true;
            this.dgvSecurity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSecurity.Size = new System.Drawing.Size(814, 277);
            this.dgvSecurity.TabIndex = 1;
            this.dgvSecurity.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSecurity_CellMouseDown);
            this.dgvSecurity.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSecurity_CellMouseUp);
            this.dgvSecurity.SelectionChanged += new System.EventHandler(this.dgvSecurity_SelectionChanged);
            this.dgvSecurity.MouseLeave += new System.EventHandler(this.dgvSecurity_MouseLeave);
            // 
            // dgvColumnSecurityType
            // 
            this.dgvColumnSecurityType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnSecurityType.DataPropertyName = "Type";
            this.dgvColumnSecurityType.HeaderText = "dgvColumnSecurityType";
            this.dgvColumnSecurityType.Name = "dgvColumnSecurityType";
            this.dgvColumnSecurityType.ReadOnly = true;
            // 
            // dgvColumnSecurityId
            // 
            this.dgvColumnSecurityId.DataPropertyName = "Id";
            this.dgvColumnSecurityId.HeaderText = "dgvColumnSecurityId";
            this.dgvColumnSecurityId.Name = "dgvColumnSecurityId";
            this.dgvColumnSecurityId.ReadOnly = true;
            this.dgvColumnSecurityId.Visible = false;
            // 
            // dgvColumnSecurityName
            // 
            this.dgvColumnSecurityName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnSecurityName.DataPropertyName = "Name";
            this.dgvColumnSecurityName.HeaderText = "dgvColumnSecurityName";
            this.dgvColumnSecurityName.Name = "dgvColumnSecurityName";
            this.dgvColumnSecurityName.ReadOnly = true;
            this.dgvColumnSecurityName.Width = 250;
            // 
            // dgvColumnSecurityDescription
            // 
            this.dgvColumnSecurityDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvColumnSecurityDescription.DataPropertyName = "Description";
            this.dgvColumnSecurityDescription.HeaderText = "dgvColumnSecurityDescription";
            this.dgvColumnSecurityDescription.Name = "dgvColumnSecurityDescription";
            this.dgvColumnSecurityDescription.ReadOnly = true;
            // 
            // dgvColumnSecurityIsGroup
            // 
            this.dgvColumnSecurityIsGroup.DataPropertyName = "IsGroup";
            this.dgvColumnSecurityIsGroup.HeaderText = "dgvColumnSecurityIsGroup";
            this.dgvColumnSecurityIsGroup.Name = "dgvColumnSecurityIsGroup";
            this.dgvColumnSecurityIsGroup.ReadOnly = true;
            this.dgvColumnSecurityIsGroup.Visible = false;
            // 
            // bsDocumentSecurity
            // 
            this.bsDocumentSecurity.DataMember = "GetDocumentSecurity";
            this.bsDocumentSecurity.DataSource = this.iTDataSet;
            // 
            // lblGroups
            // 
            this.lblGroups.AutoSize = true;
            this.lblGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGroups.Location = new System.Drawing.Point(3, 0);
            this.lblGroups.Name = "lblGroups";
            this.lblGroups.Size = new System.Drawing.Size(808, 27);
            this.lblGroups.TabIndex = 0;
            this.lblGroups.Text = "lblGroups";
            this.lblGroups.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpRight
            // 
            this.tlpRight.ColumnCount = 1;
            this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRight.Controls.Add(this.btnSelectAllRecords, 0, 1);
            this.tlpRight.Controls.Add(this.lblDocumentListItems, 0, 0);
            this.tlpRight.Controls.Add(this.tlpItemsButtons, 0, 3);
            this.tlpRight.Controls.Add(this.dgvPermissions, 0, 2);
            this.tlpRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRight.Location = new System.Drawing.Point(814, 0);
            this.tlpRight.Margin = new System.Windows.Forms.Padding(0);
            this.tlpRight.Name = "tlpRight";
            this.tlpRight.RowCount = 4;
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpRight.Size = new System.Drawing.Size(407, 661);
            this.tlpRight.TabIndex = 0;
            // 
            // btnSelectAllRecords
            // 
            this.btnSelectAllRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectAllRecords.Image = global::DocumentsManagerRU.Properties.Resources.check_2x;
            this.btnSelectAllRecords.Location = new System.Drawing.Point(0, 27);
            this.btnSelectAllRecords.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectAllRecords.Name = "btnSelectAllRecords";
            this.btnSelectAllRecords.Size = new System.Drawing.Size(407, 27);
            this.btnSelectAllRecords.TabIndex = 1;
            this.btnSelectAllRecords.UseVisualStyleBackColor = true;
            this.btnSelectAllRecords.Click += new System.EventHandler(this.btnSelectAllRecords_Click);
            // 
            // lblDocumentListItems
            // 
            this.lblDocumentListItems.AutoSize = true;
            this.lblDocumentListItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDocumentListItems.Location = new System.Drawing.Point(3, 0);
            this.lblDocumentListItems.Name = "lblDocumentListItems";
            this.lblDocumentListItems.Size = new System.Drawing.Size(401, 27);
            this.lblDocumentListItems.TabIndex = 0;
            this.lblDocumentListItems.Text = "lblDocumentListItems";
            this.lblDocumentListItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpItemsButtons
            // 
            this.tlpItemsButtons.ColumnCount = 2;
            this.tlpItemsButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpItemsButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpItemsButtons.Controls.Add(this.btnAddPermissions, 0, 0);
            this.tlpItemsButtons.Controls.Add(this.btnRemovePermissions, 1, 0);
            this.tlpItemsButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpItemsButtons.Location = new System.Drawing.Point(0, 634);
            this.tlpItemsButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpItemsButtons.Name = "tlpItemsButtons";
            this.tlpItemsButtons.RowCount = 1;
            this.tlpItemsButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpItemsButtons.Size = new System.Drawing.Size(407, 27);
            this.tlpItemsButtons.TabIndex = 0;
            // 
            // btnAddPermissions
            // 
            this.btnAddPermissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddPermissions.Image = global::DocumentsManagerRU.Properties.Resources.plus_2x;
            this.btnAddPermissions.Location = new System.Drawing.Point(0, 0);
            this.btnAddPermissions.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddPermissions.Name = "btnAddPermissions";
            this.btnAddPermissions.Size = new System.Drawing.Size(203, 27);
            this.btnAddPermissions.TabIndex = 0;
            this.btnAddPermissions.UseVisualStyleBackColor = true;
            this.btnAddPermissions.Click += new System.EventHandler(this.btnAddPermissions_Click);
            // 
            // btnRemovePermissions
            // 
            this.btnRemovePermissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemovePermissions.Image = global::DocumentsManagerRU.Properties.Resources.minus_2x;
            this.btnRemovePermissions.Location = new System.Drawing.Point(203, 0);
            this.btnRemovePermissions.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemovePermissions.Name = "btnRemovePermissions";
            this.btnRemovePermissions.Size = new System.Drawing.Size(204, 27);
            this.btnRemovePermissions.TabIndex = 1;
            this.btnRemovePermissions.UseVisualStyleBackColor = true;
            this.btnRemovePermissions.Click += new System.EventHandler(this.btnRemovePermissions_Click);
            // 
            // dgvPermissions
            // 
            this.dgvPermissions.AllowUserToAddRows = false;
            this.dgvPermissions.AllowUserToDeleteRows = false;
            this.dgvPermissions.AllowUserToResizeRows = false;
            this.dgvPermissions.AutoGenerateColumns = false;
            this.dgvPermissions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPermissions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPermissions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPermissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPermissions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumnPermissionPermissionId,
            this.dgvColumnPermissionClassId,
            this.dgvColumnPermissionSecurityId,
            this.dgvColumnPermissionDefinitionId,
            this.dgvColumnPermissionItemId,
            this.dgvColumnPermissionName,
            this.dgvColumnPermission,
            this.dgvColPermissionId,
            this.dgvColPermission});
            this.dgvPermissions.DataSource = this.bsDocumentListItemsPermissions;
            this.dgvPermissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPermissions.Location = new System.Drawing.Point(0, 54);
            this.dgvPermissions.Margin = new System.Windows.Forms.Padding(0);
            this.dgvPermissions.Name = "dgvPermissions";
            this.dgvPermissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPermissions.Size = new System.Drawing.Size(407, 580);
            this.dgvPermissions.TabIndex = 2;
            this.dgvPermissions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermissions_CellContentClick);
            // 
            // bsDocumentListItemsPermissions
            // 
            this.bsDocumentListItemsPermissions.DataMember = "GetDocumentListItemsPermissions";
            this.bsDocumentListItemsPermissions.DataSource = this.iTDataSet;
            // 
            // taDefinitions
            // 
            this.taDefinitions.ClearBeforeFill = true;
            // 
            // taDocumentClass
            // 
            this.taDocumentClass.ClearBeforeFill = true;
            // 
            // taDocumentSecurity
            // 
            this.taDocumentSecurity.ClearBeforeFill = true;
            // 
            // taDocumentListItemsPermissions
            // 
            this.taDocumentListItemsPermissions.ClearBeforeFill = true;
            // 
            // dgvColumnPermissionPermissionId
            // 
            this.dgvColumnPermissionPermissionId.DataPropertyName = "PermissionId";
            this.dgvColumnPermissionPermissionId.HeaderText = "dgvColumnPermissionPermissionId";
            this.dgvColumnPermissionPermissionId.Name = "dgvColumnPermissionPermissionId";
            this.dgvColumnPermissionPermissionId.ReadOnly = true;
            this.dgvColumnPermissionPermissionId.Visible = false;
            // 
            // dgvColumnPermissionClassId
            // 
            this.dgvColumnPermissionClassId.DataPropertyName = "ClassId";
            this.dgvColumnPermissionClassId.HeaderText = "dgvColumnPermissionClassId";
            this.dgvColumnPermissionClassId.Name = "dgvColumnPermissionClassId";
            this.dgvColumnPermissionClassId.ReadOnly = true;
            this.dgvColumnPermissionClassId.Visible = false;
            // 
            // dgvColumnPermissionSecurityId
            // 
            this.dgvColumnPermissionSecurityId.DataPropertyName = "SecurityId";
            this.dgvColumnPermissionSecurityId.HeaderText = "dgvColumnPermissionSecurityId";
            this.dgvColumnPermissionSecurityId.Name = "dgvColumnPermissionSecurityId";
            this.dgvColumnPermissionSecurityId.ReadOnly = true;
            this.dgvColumnPermissionSecurityId.Visible = false;
            // 
            // dgvColumnPermissionDefinitionId
            // 
            this.dgvColumnPermissionDefinitionId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnPermissionDefinitionId.DataPropertyName = "DefinitionId";
            this.dgvColumnPermissionDefinitionId.HeaderText = "dgvColumnPermissionDefinitionId";
            this.dgvColumnPermissionDefinitionId.Name = "dgvColumnPermissionDefinitionId";
            this.dgvColumnPermissionDefinitionId.ReadOnly = true;
            this.dgvColumnPermissionDefinitionId.Visible = false;
            // 
            // dgvColumnPermissionItemId
            // 
            this.dgvColumnPermissionItemId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnPermissionItemId.DataPropertyName = "ItemId";
            this.dgvColumnPermissionItemId.HeaderText = "dgvColumnPermissionItemId";
            this.dgvColumnPermissionItemId.Name = "dgvColumnPermissionItemId";
            this.dgvColumnPermissionItemId.ReadOnly = true;
            this.dgvColumnPermissionItemId.Visible = false;
            // 
            // dgvColumnPermissionName
            // 
            this.dgvColumnPermissionName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvColumnPermissionName.DataPropertyName = "Name";
            this.dgvColumnPermissionName.HeaderText = "dgvColumnPermissionName";
            this.dgvColumnPermissionName.Name = "dgvColumnPermissionName";
            this.dgvColumnPermissionName.ReadOnly = true;
            this.dgvColumnPermissionName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvColumnPermission
            // 
            this.dgvColumnPermission.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnPermission.DataPropertyName = "Permission";
            this.dgvColumnPermission.HeaderText = "dgvColumnPermission";
            this.dgvColumnPermission.Name = "dgvColumnPermission";
            this.dgvColumnPermission.ReadOnly = true;
            this.dgvColumnPermission.Visible = false;
            this.dgvColumnPermission.Width = 50;
            // 
            // dgvColPermissionId
            // 
            this.dgvColPermissionId.HeaderText = "dgvColPermissionId";
            this.dgvColPermissionId.Name = "dgvColPermissionId";
            this.dgvColPermissionId.Visible = false;
            // 
            // dgvColPermission
            // 
            this.dgvColPermission.HeaderText = "dgvColPermission";
            this.dgvColPermission.Name = "dgvColPermission";
            this.dgvColPermission.ReadOnly = true;
            this.dgvColPermission.Width = 50;
            // 
            // frmPermissionListItemsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 661);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPermissionListItemsManager";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPermissionListItemsManager";
            this.Load += new System.EventHandler(this.frmPermissionListItemsManager_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpLeft.ResumeLayout(false);
            this.tlpDefinitionClass.ResumeLayout(false);
            this.tlpDefinitionClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefinitions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDefinitions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentClass)).EndInit();
            this.tlpSecurity.ResumeLayout(false);
            this.tlpSecurity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecurity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentSecurity)).EndInit();
            this.tlpRight.ResumeLayout(false);
            this.tlpRight.PerformLayout();
            this.tlpItemsButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentListItemsPermissions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpLeft;
        private System.Windows.Forms.TableLayoutPanel tlpDefinitionClass;
        private System.Windows.Forms.TableLayoutPanel tlpSecurity;
        private System.Windows.Forms.TableLayoutPanel tlpRight;
        private System.Windows.Forms.TableLayoutPanel tlpItemsButtons;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.Label lblDocumentClass;
        private System.Windows.Forms.DataGridView dgvDefinitions;
        private System.Windows.Forms.Label lblDocumentDefinition;
        private System.Windows.Forms.DataGridView dgvSecurity;
        private System.Windows.Forms.Label lblGroups;
        private System.Windows.Forms.Label lblDocumentListItems;
        private System.Windows.Forms.DataGridView dgvPermissions;
        private System.Windows.Forms.Button btnSelectAllGroups;
        private System.Windows.Forms.Button btnSelectAllRecords;
        private System.Windows.Forms.Button btnRemovePermissions;
        private System.Windows.Forms.Button btnAddPermissions;
        private System.Windows.Forms.BindingSource bsDefinitions;
        private ITDataSet iTDataSet;
        private ITDataSetTableAdapters.GetDocumentDefinitionsByDirectiveTableAdapter taDefinitions;
        private System.Windows.Forms.BindingSource bsDocumentClass;
        private ITDataSetTableAdapters.Document_ClassTableAdapter taDocumentClass;
        private System.Windows.Forms.BindingSource bsDocumentSecurity;
        private ITDataSetTableAdapters.GetDocumentSecurityTableAdapter taDocumentSecurity;
        private System.Windows.Forms.BindingSource bsDocumentListItemsPermissions;
        private ITDataSetTableAdapters.GetDocumentListItemsPermissionsTableAdapter taDocumentListItemsPermissions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnSecurityType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnSecurityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnSecurityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnSecurityDescription;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvColumnSecurityIsGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnDefinitionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnDefinitionCurrentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnDefinitionCurrentDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnClassDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnPermissionPermissionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnPermissionClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnPermissionSecurityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnPermissionDefinitionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnPermissionItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnPermissionName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvColumnPermission;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColPermissionId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvColPermission;
    }
}