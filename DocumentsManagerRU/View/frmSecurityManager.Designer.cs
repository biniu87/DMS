namespace DocumentsManagerRU.View
{
    partial class frmSecurityManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSecurityManager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblSecurityTitle = new System.Windows.Forms.Label();
            this.lblGroupTitle = new System.Windows.Forms.Label();
            this.lblUserTitle = new System.Windows.Forms.Label();
            this.btnSelectAllUserRows = new System.Windows.Forms.Button();
            this.btnSelectAllGroupRows = new System.Windows.Forms.Button();
            this.btnSelectAllSecurityRows = new System.Windows.Forms.Button();
            this.btnSecurityRemove = new System.Windows.Forms.Button();
            this.tlpGroupButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSecurityAddGroup = new System.Windows.Forms.Button();
            this.btnSecurityRemoveGroup = new System.Windows.Forms.Button();
            this.tlpUserButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSecurityRemoveUser = new System.Windows.Forms.Button();
            this.btnSecurityAddUser = new System.Windows.Forms.Button();
            this.dgvSecurity = new System.Windows.Forms.DataGridView();
            this.bsDocumentSecurity = new System.Windows.Forms.BindingSource(this.components);
            this.iTDataSet = new DocumentsManagerRU.ITDataSet();
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.dgvColumnGroupNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnGroupGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnGroupDecription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnGroupAdded = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.dgvColumnUserNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnUserAdded = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.taDocumentSecurity = new DocumentsManagerRU.ITDataSetTableAdapters.GetDocumentSecurityTableAdapter();
            this.dgvColumnSecurityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnSecurityType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnSecurityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnSecurityDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnSecurityActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvColumnSecurityAdmin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvColumnSecurityIsGroup = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvColumnSecurityDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.tlpMain.SuspendLayout();
            this.tlpGroupButtons.SuspendLayout();
            this.tlpUserButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecurity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentSecurity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tlpMain.Controls.Add(this.lblSecurityTitle, 0, 0);
            this.tlpMain.Controls.Add(this.lblGroupTitle, 1, 0);
            this.tlpMain.Controls.Add(this.lblUserTitle, 2, 0);
            this.tlpMain.Controls.Add(this.btnSelectAllUserRows, 2, 1);
            this.tlpMain.Controls.Add(this.btnSelectAllGroupRows, 1, 1);
            this.tlpMain.Controls.Add(this.btnSelectAllSecurityRows, 0, 1);
            this.tlpMain.Controls.Add(this.btnSecurityRemove, 0, 3);
            this.tlpMain.Controls.Add(this.tlpGroupButtons, 1, 3);
            this.tlpMain.Controls.Add(this.tlpUserButtons, 2, 3);
            this.tlpMain.Controls.Add(this.dgvSecurity, 0, 2);
            this.tlpMain.Controls.Add(this.dgvGroups, 1, 2);
            this.tlpMain.Controls.Add(this.dgvUsers, 2, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(1266, 611);
            this.tlpMain.TabIndex = 0;
            // 
            // lblSecurityTitle
            // 
            this.lblSecurityTitle.AutoSize = true;
            this.lblSecurityTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSecurityTitle.Location = new System.Drawing.Point(3, 0);
            this.lblSecurityTitle.Name = "lblSecurityTitle";
            this.lblSecurityTitle.Size = new System.Drawing.Size(594, 20);
            this.lblSecurityTitle.TabIndex = 0;
            this.lblSecurityTitle.Text = "lblSecurityTitle";
            this.lblSecurityTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGroupTitle
            // 
            this.lblGroupTitle.AutoSize = true;
            this.lblGroupTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGroupTitle.Location = new System.Drawing.Point(603, 0);
            this.lblGroupTitle.Name = "lblGroupTitle";
            this.lblGroupTitle.Size = new System.Drawing.Size(430, 20);
            this.lblGroupTitle.TabIndex = 4;
            this.lblGroupTitle.Text = "lblGroupTitle";
            this.lblGroupTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserTitle
            // 
            this.lblUserTitle.AutoSize = true;
            this.lblUserTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserTitle.Location = new System.Drawing.Point(1039, 0);
            this.lblUserTitle.Name = "lblUserTitle";
            this.lblUserTitle.Size = new System.Drawing.Size(224, 20);
            this.lblUserTitle.TabIndex = 7;
            this.lblUserTitle.Text = "lblUserTitle";
            this.lblUserTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelectAllUserRows
            // 
            this.btnSelectAllUserRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectAllUserRows.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectAllUserRows.Image")));
            this.btnSelectAllUserRows.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectAllUserRows.Location = new System.Drawing.Point(1036, 20);
            this.btnSelectAllUserRows.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectAllUserRows.Name = "btnSelectAllUserRows";
            this.btnSelectAllUserRows.Size = new System.Drawing.Size(230, 27);
            this.btnSelectAllUserRows.TabIndex = 8;
            this.btnSelectAllUserRows.Text = "Zaznacz wszystko";
            this.btnSelectAllUserRows.UseVisualStyleBackColor = true;
            this.btnSelectAllUserRows.Click += new System.EventHandler(this.btnSelectAllUserRows_Click);
            // 
            // btnSelectAllGroupRows
            // 
            this.btnSelectAllGroupRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectAllGroupRows.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectAllGroupRows.Image")));
            this.btnSelectAllGroupRows.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectAllGroupRows.Location = new System.Drawing.Point(600, 20);
            this.btnSelectAllGroupRows.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectAllGroupRows.Name = "btnSelectAllGroupRows";
            this.btnSelectAllGroupRows.Size = new System.Drawing.Size(436, 27);
            this.btnSelectAllGroupRows.TabIndex = 5;
            this.btnSelectAllGroupRows.Text = "Zaznacz wszystko";
            this.btnSelectAllGroupRows.UseVisualStyleBackColor = true;
            this.btnSelectAllGroupRows.Click += new System.EventHandler(this.btnSelectAllGroupRows_Click);
            // 
            // btnSelectAllSecurityRows
            // 
            this.btnSelectAllSecurityRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectAllSecurityRows.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectAllSecurityRows.Image")));
            this.btnSelectAllSecurityRows.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectAllSecurityRows.Location = new System.Drawing.Point(0, 20);
            this.btnSelectAllSecurityRows.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectAllSecurityRows.Name = "btnSelectAllSecurityRows";
            this.btnSelectAllSecurityRows.Size = new System.Drawing.Size(600, 27);
            this.btnSelectAllSecurityRows.TabIndex = 1;
            this.btnSelectAllSecurityRows.Text = "Zaznacz wszystko";
            this.btnSelectAllSecurityRows.UseVisualStyleBackColor = true;
            this.btnSelectAllSecurityRows.Click += new System.EventHandler(this.btnSelectAllSecurityRows_Click);
            // 
            // btnSecurityRemove
            // 
            this.btnSecurityRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSecurityRemove.Image = global::DocumentsManagerRU.Properties.Resources.minus_2x;
            this.btnSecurityRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecurityRemove.Location = new System.Drawing.Point(0, 584);
            this.btnSecurityRemove.Margin = new System.Windows.Forms.Padding(0);
            this.btnSecurityRemove.Name = "btnSecurityRemove";
            this.btnSecurityRemove.Size = new System.Drawing.Size(600, 27);
            this.btnSecurityRemove.TabIndex = 3;
            this.btnSecurityRemove.Text = "Usuń";
            this.btnSecurityRemove.UseVisualStyleBackColor = true;
            this.btnSecurityRemove.Click += new System.EventHandler(this.btnSecurityRemove_Click);
            // 
            // tlpGroupButtons
            // 
            this.tlpGroupButtons.ColumnCount = 2;
            this.tlpGroupButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGroupButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGroupButtons.Controls.Add(this.btnSecurityAddGroup, 0, 0);
            this.tlpGroupButtons.Controls.Add(this.btnSecurityRemoveGroup, 1, 0);
            this.tlpGroupButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGroupButtons.Location = new System.Drawing.Point(600, 584);
            this.tlpGroupButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpGroupButtons.Name = "tlpGroupButtons";
            this.tlpGroupButtons.RowCount = 1;
            this.tlpGroupButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGroupButtons.Size = new System.Drawing.Size(436, 27);
            this.tlpGroupButtons.TabIndex = 7;
            // 
            // btnSecurityAddGroup
            // 
            this.btnSecurityAddGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSecurityAddGroup.Image = global::DocumentsManagerRU.Properties.Resources.plus_2x;
            this.btnSecurityAddGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecurityAddGroup.Location = new System.Drawing.Point(0, 0);
            this.btnSecurityAddGroup.Margin = new System.Windows.Forms.Padding(0);
            this.btnSecurityAddGroup.Name = "btnSecurityAddGroup";
            this.btnSecurityAddGroup.Size = new System.Drawing.Size(218, 27);
            this.btnSecurityAddGroup.TabIndex = 0;
            this.btnSecurityAddGroup.Text = "Dodaj";
            this.btnSecurityAddGroup.UseVisualStyleBackColor = true;
            this.btnSecurityAddGroup.Click += new System.EventHandler(this.btnSecurityAddGroup_Click);
            // 
            // btnSecurityRemoveGroup
            // 
            this.btnSecurityRemoveGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSecurityRemoveGroup.Image = global::DocumentsManagerRU.Properties.Resources.minus_2x;
            this.btnSecurityRemoveGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecurityRemoveGroup.Location = new System.Drawing.Point(218, 0);
            this.btnSecurityRemoveGroup.Margin = new System.Windows.Forms.Padding(0);
            this.btnSecurityRemoveGroup.Name = "btnSecurityRemoveGroup";
            this.btnSecurityRemoveGroup.Size = new System.Drawing.Size(218, 27);
            this.btnSecurityRemoveGroup.TabIndex = 1;
            this.btnSecurityRemoveGroup.Text = "Usuń";
            this.btnSecurityRemoveGroup.UseVisualStyleBackColor = true;
            this.btnSecurityRemoveGroup.Click += new System.EventHandler(this.btnSecurityRemoveGroup_Click);
            // 
            // tlpUserButtons
            // 
            this.tlpUserButtons.ColumnCount = 2;
            this.tlpUserButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUserButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUserButtons.Controls.Add(this.btnSecurityRemoveUser, 1, 0);
            this.tlpUserButtons.Controls.Add(this.btnSecurityAddUser, 0, 0);
            this.tlpUserButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUserButtons.Location = new System.Drawing.Point(1036, 584);
            this.tlpUserButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpUserButtons.Name = "tlpUserButtons";
            this.tlpUserButtons.RowCount = 1;
            this.tlpUserButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUserButtons.Size = new System.Drawing.Size(230, 27);
            this.tlpUserButtons.TabIndex = 8;
            // 
            // btnSecurityRemoveUser
            // 
            this.btnSecurityRemoveUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSecurityRemoveUser.Image = global::DocumentsManagerRU.Properties.Resources.minus_2x;
            this.btnSecurityRemoveUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecurityRemoveUser.Location = new System.Drawing.Point(115, 0);
            this.btnSecurityRemoveUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnSecurityRemoveUser.Name = "btnSecurityRemoveUser";
            this.btnSecurityRemoveUser.Size = new System.Drawing.Size(115, 27);
            this.btnSecurityRemoveUser.TabIndex = 1;
            this.btnSecurityRemoveUser.Text = "Usuń";
            this.btnSecurityRemoveUser.UseVisualStyleBackColor = true;
            this.btnSecurityRemoveUser.Click += new System.EventHandler(this.btnSecurityRemoveUser_Click);
            // 
            // btnSecurityAddUser
            // 
            this.btnSecurityAddUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSecurityAddUser.Image = global::DocumentsManagerRU.Properties.Resources.plus_2x;
            this.btnSecurityAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecurityAddUser.Location = new System.Drawing.Point(0, 0);
            this.btnSecurityAddUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnSecurityAddUser.Name = "btnSecurityAddUser";
            this.btnSecurityAddUser.Size = new System.Drawing.Size(115, 27);
            this.btnSecurityAddUser.TabIndex = 0;
            this.btnSecurityAddUser.Text = "Dodaj";
            this.btnSecurityAddUser.UseVisualStyleBackColor = true;
            this.btnSecurityAddUser.Click += new System.EventHandler(this.btnSecurityAddUser_Click);
            // 
            // dgvSecurity
            // 
            this.dgvSecurity.AllowUserToAddRows = false;
            this.dgvSecurity.AllowUserToResizeRows = false;
            this.dgvSecurity.AutoGenerateColumns = false;
            this.dgvSecurity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSecurity.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSecurity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSecurity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSecurity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumnSecurityId,
            this.dgvColumnSecurityType,
            this.dgvColumnSecurityName,
            this.dgvColumnSecurityDescription,
            this.dgvColumnSecurityActive,
            this.dgvColumnSecurityAdmin,
            this.dgvColumnSecurityIsGroup,
            this.dgvColumnSecurityDelete});
            this.dgvSecurity.DataSource = this.bsDocumentSecurity;
            this.dgvSecurity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSecurity.Location = new System.Drawing.Point(0, 47);
            this.dgvSecurity.Margin = new System.Windows.Forms.Padding(0);
            this.dgvSecurity.Name = "dgvSecurity";
            this.dgvSecurity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSecurity.Size = new System.Drawing.Size(600, 537);
            this.dgvSecurity.TabIndex = 2;
            this.dgvSecurity.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSecurity_CellContentClick);
            this.dgvSecurity.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSecurity_CellEndEdit);
            // 
            // bsDocumentSecurity
            // 
            this.bsDocumentSecurity.DataMember = "GetDocumentSecurity";
            this.bsDocumentSecurity.DataSource = this.iTDataSet;
            // 
            // iTDataSet
            // 
            this.iTDataSet.DataSetName = "ITDataSet";
            this.iTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvGroups
            // 
            this.dgvGroups.AllowUserToAddRows = false;
            this.dgvGroups.AllowUserToResizeRows = false;
            this.dgvGroups.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGroups.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGroups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumnGroupNumber,
            this.dgvColumnGroupGuid,
            this.dgvColumnGroupName,
            this.dgvColumnGroupDecription,
            this.dgvColumnGroupAdded});
            this.dgvGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGroups.Location = new System.Drawing.Point(600, 47);
            this.dgvGroups.Margin = new System.Windows.Forms.Padding(0);
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.RowHeadersWidth = 20;
            this.dgvGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroups.Size = new System.Drawing.Size(436, 537);
            this.dgvGroups.TabIndex = 6;
            this.dgvGroups.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroups_CellContentClick);
            this.dgvGroups.SelectionChanged += new System.EventHandler(this.dgvGroups_SelectionChanged);
            // 
            // dgvColumnGroupNumber
            // 
            this.dgvColumnGroupNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnGroupNumber.HeaderText = "dgvColumnGroupNumber";
            this.dgvColumnGroupNumber.Name = "dgvColumnGroupNumber";
            this.dgvColumnGroupNumber.ReadOnly = true;
            this.dgvColumnGroupNumber.Width = 30;
            // 
            // dgvColumnGroupGuid
            // 
            this.dgvColumnGroupGuid.HeaderText = "dgvColumnGroupGuid";
            this.dgvColumnGroupGuid.Name = "dgvColumnGroupGuid";
            this.dgvColumnGroupGuid.ReadOnly = true;
            this.dgvColumnGroupGuid.Visible = false;
            // 
            // dgvColumnGroupName
            // 
            this.dgvColumnGroupName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnGroupName.HeaderText = "dgvColumnGroupName";
            this.dgvColumnGroupName.Name = "dgvColumnGroupName";
            this.dgvColumnGroupName.ReadOnly = true;
            this.dgvColumnGroupName.Width = 150;
            // 
            // dgvColumnGroupDecription
            // 
            this.dgvColumnGroupDecription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvColumnGroupDecription.HeaderText = "dgvColumnGroupDecription";
            this.dgvColumnGroupDecription.Name = "dgvColumnGroupDecription";
            this.dgvColumnGroupDecription.ReadOnly = true;
            // 
            // dgvColumnGroupAdded
            // 
            this.dgvColumnGroupAdded.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnGroupAdded.HeaderText = "dgvColumnGroupAdded";
            this.dgvColumnGroupAdded.Name = "dgvColumnGroupAdded";
            this.dgvColumnGroupAdded.ReadOnly = true;
            this.dgvColumnGroupAdded.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvColumnGroupAdded.Width = 30;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumnUserNumber,
            this.dgvColumnUserName,
            this.dgvColumnUserAdded});
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(1036, 47);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(0);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 20;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(230, 537);
            this.dgvUsers.TabIndex = 9;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // dgvColumnUserNumber
            // 
            this.dgvColumnUserNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnUserNumber.HeaderText = "dgvColumnUserNumber";
            this.dgvColumnUserNumber.Name = "dgvColumnUserNumber";
            this.dgvColumnUserNumber.ReadOnly = true;
            this.dgvColumnUserNumber.Width = 30;
            // 
            // dgvColumnUserName
            // 
            this.dgvColumnUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvColumnUserName.HeaderText = "dgvColumnUserName";
            this.dgvColumnUserName.Name = "dgvColumnUserName";
            this.dgvColumnUserName.ReadOnly = true;
            // 
            // dgvColumnUserAdded
            // 
            this.dgvColumnUserAdded.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnUserAdded.HeaderText = "dgvColumnUserAdded";
            this.dgvColumnUserAdded.Name = "dgvColumnUserAdded";
            this.dgvColumnUserAdded.ReadOnly = true;
            this.dgvColumnUserAdded.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvColumnUserAdded.Width = 30;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::DocumentsManagerRU.Properties.Resources.delete_2x;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::DocumentsManagerRU.Properties.Resources.delete_2x;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.Width = 30;
            // 
            // taDocumentSecurity
            // 
            this.taDocumentSecurity.ClearBeforeFill = true;
            // 
            // dgvColumnSecurityId
            // 
            this.dgvColumnSecurityId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnSecurityId.DataPropertyName = "Id";
            this.dgvColumnSecurityId.HeaderText = "Id";
            this.dgvColumnSecurityId.Name = "dgvColumnSecurityId";
            this.dgvColumnSecurityId.ReadOnly = true;
            this.dgvColumnSecurityId.Visible = false;
            // 
            // dgvColumnSecurityType
            // 
            this.dgvColumnSecurityType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvColumnSecurityType.DataPropertyName = "Type";
            this.dgvColumnSecurityType.HeaderText = "dgvColumnSecurityType";
            this.dgvColumnSecurityType.Name = "dgvColumnSecurityType";
            this.dgvColumnSecurityType.ReadOnly = true;
            this.dgvColumnSecurityType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvColumnSecurityType.Width = 148;
            // 
            // dgvColumnSecurityName
            // 
            this.dgvColumnSecurityName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvColumnSecurityName.DataPropertyName = "Name";
            this.dgvColumnSecurityName.HeaderText = "dgvColumnSecurityName";
            this.dgvColumnSecurityName.Name = "dgvColumnSecurityName";
            this.dgvColumnSecurityName.ReadOnly = true;
            this.dgvColumnSecurityName.Width = 151;
            // 
            // dgvColumnSecurityDescription
            // 
            this.dgvColumnSecurityDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvColumnSecurityDescription.DataPropertyName = "Description";
            this.dgvColumnSecurityDescription.HeaderText = "dgvColumnSecurityDescription";
            this.dgvColumnSecurityDescription.Name = "dgvColumnSecurityDescription";
            this.dgvColumnSecurityDescription.ReadOnly = true;
            // 
            // dgvColumnSecurityActive
            // 
            this.dgvColumnSecurityActive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvColumnSecurityActive.DataPropertyName = "Active";
            this.dgvColumnSecurityActive.HeaderText = "dgvColumnSecurityActive";
            this.dgvColumnSecurityActive.Name = "dgvColumnSecurityActive";
            this.dgvColumnSecurityActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvColumnSecurityActive.Width = 154;
            // 
            // dgvColumnSecurityAdmin
            // 
            this.dgvColumnSecurityAdmin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvColumnSecurityAdmin.DataPropertyName = "Admin";
            this.dgvColumnSecurityAdmin.HeaderText = "dgvColumnSecurityAdmin";
            this.dgvColumnSecurityAdmin.Name = "dgvColumnSecurityAdmin";
            this.dgvColumnSecurityAdmin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvColumnSecurityAdmin.Width = 153;
            // 
            // dgvColumnSecurityIsGroup
            // 
            this.dgvColumnSecurityIsGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnSecurityIsGroup.DataPropertyName = "IsGroup";
            this.dgvColumnSecurityIsGroup.HeaderText = "dgvColumIsSecurityGroup";
            this.dgvColumnSecurityIsGroup.Name = "dgvColumnSecurityIsGroup";
            this.dgvColumnSecurityIsGroup.ReadOnly = true;
            this.dgvColumnSecurityIsGroup.Visible = false;
            this.dgvColumnSecurityIsGroup.Width = 30;
            // 
            // dgvColumnSecurityDelete
            // 
            this.dgvColumnSecurityDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnSecurityDelete.HeaderText = "";
            this.dgvColumnSecurityDelete.Image = global::DocumentsManagerRU.Properties.Resources.minus_2x;
            this.dgvColumnSecurityDelete.Name = "dgvColumnSecurityDelete";
            this.dgvColumnSecurityDelete.ReadOnly = true;
            this.dgvColumnSecurityDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvColumnSecurityDelete.Width = 30;
            // 
            // frmSecurityManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 611);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSecurityManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSecurityManager";
            this.Load += new System.EventHandler(this.frmSecurityManager_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpGroupButtons.ResumeLayout(false);
            this.tlpUserButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecurity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentSecurity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.DataGridView dgvSecurity;
        private ITDataSet iTDataSet;
        private System.Windows.Forms.BindingSource bsDocumentSecurity;
        private ITDataSetTableAdapters.GetDocumentSecurityTableAdapter taDocumentSecurity;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnUserNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnUserName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvColumnUserAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnGroupNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnGroupGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnGroupDecription;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvColumnGroupAdded;
        private System.Windows.Forms.Button btnSecurityRemove;
        private System.Windows.Forms.Button btnSecurityAddGroup;
        private System.Windows.Forms.Button btnSecurityAddUser;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.TableLayoutPanel tlpUserButtons;
        private System.Windows.Forms.Button btnSecurityRemoveUser;
        private System.Windows.Forms.TableLayoutPanel tlpGroupButtons;
        private System.Windows.Forms.Button btnSecurityRemoveGroup;
        private System.Windows.Forms.Button btnSelectAllUserRows;
        private System.Windows.Forms.Button btnSelectAllGroupRows;
        private System.Windows.Forms.Button btnSelectAllSecurityRows;
        private System.Windows.Forms.Label lblSecurityTitle;
        private System.Windows.Forms.Label lblGroupTitle;
        private System.Windows.Forms.Label lblUserTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnSecurityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnSecurityType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnSecurityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnSecurityDescription;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvColumnSecurityActive;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvColumnSecurityAdmin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvColumnSecurityIsGroup;
        private System.Windows.Forms.DataGridViewImageColumn dgvColumnSecurityDelete;
    }
}