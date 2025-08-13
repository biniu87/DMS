namespace DocumentsManagerRU
{
    partial class frmDefinitionManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDefinitionManager));
            this.bsDocumentClass = new System.Windows.Forms.BindingSource(this.components);
            this.iTDataSet = new DocumentsManagerRU.ITDataSet();
            this.btnCancel = new System.Windows.Forms.Button();
            this.taDocumentClass = new DocumentsManagerRU.ITDataSetTableAdapters.Document_ClassTableAdapter();
            this.btnSaveDefinition = new System.Windows.Forms.Button();
            this.btnDeleteDefinition = new System.Windows.Forms.Button();
            this.chkEditDefinition = new System.Windows.Forms.CheckBox();
            this.gbDefinitionInfo = new System.Windows.Forms.GroupBox();
            this.pnlAdvancedList = new System.Windows.Forms.Panel();
            this.btnAddNewRecord = new System.Windows.Forms.Button();
            this.txtNewRecord = new System.Windows.Forms.TextBox();
            this.dgvListItems = new System.Windows.Forms.DataGridView();
            this.bsDocumentDefinitionListItems = new System.Windows.Forms.BindingSource(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.pnlSimpleList = new System.Windows.Forms.Panel();
            this.lblDefinitionList = new System.Windows.Forms.Label();
            this.txtDefinitionList = new System.Windows.Forms.TextBox();
            this.lblListRecordCount = new System.Windows.Forms.Label();
            this.txtListRecordCount = new System.Windows.Forms.TextBox();
            this.txtDefinitionDescriptionPL = new System.Windows.Forms.TextBox();
            this.txtDefinitionNamePL = new System.Windows.Forms.TextBox();
            this.lblNamePL1 = new System.Windows.Forms.Label();
            this.lblDescriptionPL1 = new System.Windows.Forms.Label();
            this.lblDefinitionCount = new System.Windows.Forms.Label();
            this.lblDataType = new System.Windows.Forms.Label();
            this.cbDocumentDataType = new System.Windows.Forms.ComboBox();
            this.bsDocumentDataTypes = new System.Windows.Forms.BindingSource(this.components);
            this.cbDocumentDefinitions = new System.Windows.Forms.ComboBox();
            this.bsDocumentDefinitions = new System.Windows.Forms.BindingSource(this.components);
            this.lblDefinition = new System.Windows.Forms.Label();
            this.btnEditRecords = new System.Windows.Forms.Button();
            this.txtDefinitionNameRU = new System.Windows.Forms.TextBox();
            this.lblNameRU1 = new System.Windows.Forms.Label();
            this.txtDefinitionDescriptionRU = new System.Windows.Forms.TextBox();
            this.lblDescriptionRU1 = new System.Windows.Forms.Label();
            this.taDocumentDefinitions = new DocumentsManagerRU.ITDataSetTableAdapters.GetDocumentDefinitionsTableAdapter();
            this.taDocumentDataTypes = new DocumentsManagerRU.ITDataSetTableAdapters.GetDocumentDataTypesTableAdapter();
            this.btnAddDefinition = new System.Windows.Forms.Button();
            this.taDocumentDefinitionListItems = new DocumentsManagerRU.ITDataSetTableAdapters.GetDocumentDefinitionListItemsTableAdapter();
            this.dgvColumnItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnItemDefinitionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnItemActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvColumnItemDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTDataSet)).BeginInit();
            this.gbDefinitionInfo.SuspendLayout();
            this.pnlAdvancedList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentDefinitionListItems)).BeginInit();
            this.pnlSimpleList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentDataTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentDefinitions)).BeginInit();
            this.SuspendLayout();
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
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(387, 508);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 24);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // taDocumentClass
            // 
            this.taDocumentClass.ClearBeforeFill = true;
            // 
            // btnSaveDefinition
            // 
            this.btnSaveDefinition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveDefinition.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveDefinition.Image")));
            this.btnSaveDefinition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveDefinition.Location = new System.Drawing.Point(9, 508);
            this.btnSaveDefinition.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaveDefinition.Name = "btnSaveDefinition";
            this.btnSaveDefinition.Size = new System.Drawing.Size(140, 24);
            this.btnSaveDefinition.TabIndex = 4;
            this.btnSaveDefinition.Text = "btnSaveDefinition";
            this.btnSaveDefinition.UseVisualStyleBackColor = true;
            this.btnSaveDefinition.Click += new System.EventHandler(this.btnSaveDefinitions_Click);
            // 
            // btnDeleteDefinition
            // 
            this.btnDeleteDefinition.Enabled = false;
            this.btnDeleteDefinition.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteDefinition.Image")));
            this.btnDeleteDefinition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteDefinition.Location = new System.Drawing.Point(149, 9);
            this.btnDeleteDefinition.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteDefinition.Name = "btnDeleteDefinition";
            this.btnDeleteDefinition.Size = new System.Drawing.Size(233, 24);
            this.btnDeleteDefinition.TabIndex = 2;
            this.btnDeleteDefinition.Text = "btnDeleteDefinition";
            this.btnDeleteDefinition.UseVisualStyleBackColor = true;
            this.btnDeleteDefinition.Visible = false;
            this.btnDeleteDefinition.Click += new System.EventHandler(this.btnDeleteDefinitions_Click);
            // 
            // chkEditDefinition
            // 
            this.chkEditDefinition.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkEditDefinition.Checked = true;
            this.chkEditDefinition.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEditDefinition.Image = ((System.Drawing.Image)(resources.GetObject("chkEditDefinition.Image")));
            this.chkEditDefinition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkEditDefinition.Location = new System.Drawing.Point(9, 9);
            this.chkEditDefinition.Margin = new System.Windows.Forms.Padding(0);
            this.chkEditDefinition.Name = "chkEditDefinition";
            this.chkEditDefinition.Size = new System.Drawing.Size(140, 24);
            this.chkEditDefinition.TabIndex = 0;
            this.chkEditDefinition.Text = "chkEditDefinition";
            this.chkEditDefinition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkEditDefinition.UseVisualStyleBackColor = true;
            this.chkEditDefinition.CheckedChanged += new System.EventHandler(this.chkEditDefinitions_CheckedChanged);
            // 
            // gbDefinitionInfo
            // 
            this.gbDefinitionInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDefinitionInfo.Controls.Add(this.pnlAdvancedList);
            this.gbDefinitionInfo.Controls.Add(this.pnlSimpleList);
            this.gbDefinitionInfo.Controls.Add(this.lblListRecordCount);
            this.gbDefinitionInfo.Controls.Add(this.txtListRecordCount);
            this.gbDefinitionInfo.Controls.Add(this.txtDefinitionDescriptionPL);
            this.gbDefinitionInfo.Controls.Add(this.txtDefinitionNamePL);
            this.gbDefinitionInfo.Controls.Add(this.lblNamePL1);
            this.gbDefinitionInfo.Controls.Add(this.lblDescriptionPL1);
            this.gbDefinitionInfo.Controls.Add(this.lblDefinitionCount);
            this.gbDefinitionInfo.Controls.Add(this.lblDataType);
            this.gbDefinitionInfo.Controls.Add(this.cbDocumentDataType);
            this.gbDefinitionInfo.Controls.Add(this.cbDocumentDefinitions);
            this.gbDefinitionInfo.Controls.Add(this.lblDefinition);
            this.gbDefinitionInfo.Location = new System.Drawing.Point(9, 36);
            this.gbDefinitionInfo.Name = "gbDefinitionInfo";
            this.gbDefinitionInfo.Size = new System.Drawing.Size(518, 469);
            this.gbDefinitionInfo.TabIndex = 3;
            this.gbDefinitionInfo.TabStop = false;
            this.gbDefinitionInfo.Text = "gbDefinitionInfo";
            // 
            // pnlAdvancedList
            // 
            this.pnlAdvancedList.Controls.Add(this.btnAddNewRecord);
            this.pnlAdvancedList.Controls.Add(this.txtNewRecord);
            this.pnlAdvancedList.Controls.Add(this.dgvListItems);
            this.pnlAdvancedList.Controls.Add(this.lblName);
            this.pnlAdvancedList.Location = new System.Drawing.Point(9, 124);
            this.pnlAdvancedList.Name = "pnlAdvancedList";
            this.pnlAdvancedList.Size = new System.Drawing.Size(495, 306);
            this.pnlAdvancedList.TabIndex = 19;
            // 
            // btnAddNewRecord
            // 
            this.btnAddNewRecord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewRecord.Image = global::DocumentsManagerRU.Properties.Resources.plus_2x;
            this.btnAddNewRecord.Location = new System.Drawing.Point(78, 274);
            this.btnAddNewRecord.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddNewRecord.Name = "btnAddNewRecord";
            this.btnAddNewRecord.Size = new System.Drawing.Size(370, 25);
            this.btnAddNewRecord.TabIndex = 0;
            this.btnAddNewRecord.UseVisualStyleBackColor = true;
            this.btnAddNewRecord.Click += new System.EventHandler(this.bntAddNew_Click);
            // 
            // txtNewRecord
            // 
            this.txtNewRecord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewRecord.Location = new System.Drawing.Point(78, 250);
            this.txtNewRecord.Name = "txtNewRecord";
            this.txtNewRecord.Size = new System.Drawing.Size(370, 21);
            this.txtNewRecord.TabIndex = 1;
            this.txtNewRecord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewRecord_KeyDown);
            // 
            // dgvListItems
            // 
            this.dgvListItems.AllowUserToAddRows = false;
            this.dgvListItems.AllowUserToDeleteRows = false;
            this.dgvListItems.AllowUserToResizeRows = false;
            this.dgvListItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListItems.AutoGenerateColumns = false;
            this.dgvListItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumnItemId,
            this.dgvColumnItemDefinitionId,
            this.dgvColumnItemName,
            this.dgvColumnItemActive,
            this.dgvColumnItemDelete});
            this.dgvListItems.DataSource = this.bsDocumentDefinitionListItems;
            this.dgvListItems.Location = new System.Drawing.Point(0, 0);
            this.dgvListItems.Margin = new System.Windows.Forms.Padding(0);
            this.dgvListItems.Name = "dgvListItems";
            this.dgvListItems.ReadOnly = true;
            this.dgvListItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListItems.Size = new System.Drawing.Size(495, 248);
            this.dgvListItems.TabIndex = 1;
            this.dgvListItems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListItems_CellEndEdit);
            this.dgvListItems.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListItems_CellMouseClick);
            this.dgvListItems.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvListItems_CellValidating);
            this.dgvListItems.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvListItems_UserDeletingRow);
            // 
            // bsDocumentDefinitionListItems
            // 
            this.bsDocumentDefinitionListItems.DataMember = "GetDocumentDefinitionListItems";
            this.bsDocumentDefinitionListItems.DataSource = this.iTDataSet;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblName.Location = new System.Drawing.Point(3, 248);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 23);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "lblName";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlSimpleList
            // 
            this.pnlSimpleList.Controls.Add(this.lblDefinitionList);
            this.pnlSimpleList.Controls.Add(this.txtDefinitionList);
            this.pnlSimpleList.Location = new System.Drawing.Point(9, 124);
            this.pnlSimpleList.Name = "pnlSimpleList";
            this.pnlSimpleList.Size = new System.Drawing.Size(495, 306);
            this.pnlSimpleList.TabIndex = 19;
            // 
            // lblDefinitionList
            // 
            this.lblDefinitionList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDefinitionList.Location = new System.Drawing.Point(3, 0);
            this.lblDefinitionList.Name = "lblDefinitionList";
            this.lblDefinitionList.Size = new System.Drawing.Size(128, 293);
            this.lblDefinitionList.TabIndex = 5;
            this.lblDefinitionList.Text = "lblDefinitionList";
            this.lblDefinitionList.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDefinitionList
            // 
            this.txtDefinitionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDefinitionList.Location = new System.Drawing.Point(137, 0);
            this.txtDefinitionList.Multiline = true;
            this.txtDefinitionList.Name = "txtDefinitionList";
            this.txtDefinitionList.ReadOnly = true;
            this.txtDefinitionList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDefinitionList.Size = new System.Drawing.Size(358, 306);
            this.txtDefinitionList.TabIndex = 6;
            // 
            // lblListRecordCount
            // 
            this.lblListRecordCount.Location = new System.Drawing.Point(289, 436);
            this.lblListRecordCount.Name = "lblListRecordCount";
            this.lblListRecordCount.Size = new System.Drawing.Size(134, 24);
            this.lblListRecordCount.TabIndex = 15;
            this.lblListRecordCount.Text = "lblListRecordCount";
            this.lblListRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtListRecordCount
            // 
            this.txtListRecordCount.Location = new System.Drawing.Point(429, 436);
            this.txtListRecordCount.Multiline = true;
            this.txtListRecordCount.Name = "txtListRecordCount";
            this.txtListRecordCount.ReadOnly = true;
            this.txtListRecordCount.Size = new System.Drawing.Size(75, 24);
            this.txtListRecordCount.TabIndex = 16;
            this.txtListRecordCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDefinitionDescriptionPL
            // 
            this.txtDefinitionDescriptionPL.Location = new System.Drawing.Point(146, 97);
            this.txtDefinitionDescriptionPL.MaxLength = 255;
            this.txtDefinitionDescriptionPL.Name = "txtDefinitionDescriptionPL";
            this.txtDefinitionDescriptionPL.ReadOnly = true;
            this.txtDefinitionDescriptionPL.Size = new System.Drawing.Size(358, 21);
            this.txtDefinitionDescriptionPL.TabIndex = 12;
            // 
            // txtDefinitionNamePL
            // 
            this.txtDefinitionNamePL.Location = new System.Drawing.Point(146, 70);
            this.txtDefinitionNamePL.MaxLength = 127;
            this.txtDefinitionNamePL.Name = "txtDefinitionNamePL";
            this.txtDefinitionNamePL.ReadOnly = true;
            this.txtDefinitionNamePL.Size = new System.Drawing.Size(311, 21);
            this.txtDefinitionNamePL.TabIndex = 8;
            // 
            // lblNamePL1
            // 
            this.lblNamePL1.Location = new System.Drawing.Point(6, 70);
            this.lblNamePL1.Name = "lblNamePL1";
            this.lblNamePL1.Size = new System.Drawing.Size(134, 20);
            this.lblNamePL1.TabIndex = 7;
            this.lblNamePL1.Text = "lblNamePL1";
            this.lblNamePL1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescriptionPL1
            // 
            this.lblDescriptionPL1.Location = new System.Drawing.Point(6, 96);
            this.lblDescriptionPL1.Name = "lblDescriptionPL1";
            this.lblDescriptionPL1.Size = new System.Drawing.Size(134, 20);
            this.lblDescriptionPL1.TabIndex = 11;
            this.lblDescriptionPL1.Text = "lblDescriptionPL1";
            this.lblDescriptionPL1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDefinitionCount
            // 
            this.lblDefinitionCount.Location = new System.Drawing.Point(463, 17);
            this.lblDefinitionCount.Name = "lblDefinitionCount";
            this.lblDefinitionCount.Size = new System.Drawing.Size(41, 21);
            this.lblDefinitionCount.TabIndex = 3;
            this.lblDefinitionCount.Text = "(9999)";
            this.lblDefinitionCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDataType
            // 
            this.lblDataType.Location = new System.Drawing.Point(6, 43);
            this.lblDataType.Name = "lblDataType";
            this.lblDataType.Size = new System.Drawing.Size(134, 21);
            this.lblDataType.TabIndex = 3;
            this.lblDataType.Text = "lblDataType";
            this.lblDataType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbDocumentDataType
            // 
            this.cbDocumentDataType.DataSource = this.bsDocumentDataTypes;
            this.cbDocumentDataType.DisplayMember = "Name";
            this.cbDocumentDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDocumentDataType.FormattingEnabled = true;
            this.cbDocumentDataType.Location = new System.Drawing.Point(146, 43);
            this.cbDocumentDataType.Name = "cbDocumentDataType";
            this.cbDocumentDataType.Size = new System.Drawing.Size(311, 21);
            this.cbDocumentDataType.TabIndex = 4;
            this.cbDocumentDataType.ValueMember = "TypeValue";
            this.cbDocumentDataType.SelectedIndexChanged += new System.EventHandler(this.cbDocumentDataType_SelectedIndexChanged);
            // 
            // bsDocumentDataTypes
            // 
            this.bsDocumentDataTypes.DataMember = "GetDocumentDataTypes";
            this.bsDocumentDataTypes.DataSource = this.iTDataSet;
            // 
            // cbDocumentDefinitions
            // 
            this.cbDocumentDefinitions.DataSource = this.bsDocumentDefinitions;
            this.cbDocumentDefinitions.DisplayMember = "CurrentName_Type";
            this.cbDocumentDefinitions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDocumentDefinitions.FormattingEnabled = true;
            this.cbDocumentDefinitions.Location = new System.Drawing.Point(146, 16);
            this.cbDocumentDefinitions.Name = "cbDocumentDefinitions";
            this.cbDocumentDefinitions.Size = new System.Drawing.Size(311, 21);
            this.cbDocumentDefinitions.TabIndex = 1;
            this.cbDocumentDefinitions.ValueMember = "Id";
            this.cbDocumentDefinitions.SelectedIndexChanged += new System.EventHandler(this.cbDocumentDefinitions_SelectedIndexChanged);
            // 
            // bsDocumentDefinitions
            // 
            this.bsDocumentDefinitions.DataMember = "GetDocumentDefinitions";
            this.bsDocumentDefinitions.DataSource = this.iTDataSet;
            // 
            // lblDefinition
            // 
            this.lblDefinition.Location = new System.Drawing.Point(6, 16);
            this.lblDefinition.Name = "lblDefinition";
            this.lblDefinition.Size = new System.Drawing.Size(134, 21);
            this.lblDefinition.TabIndex = 0;
            this.lblDefinition.Text = "lblDefinition";
            this.lblDefinition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEditRecords
            // 
            this.btnEditRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditRecords.Image = global::DocumentsManagerRU.Properties.Resources.list_2x;
            this.btnEditRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditRecords.Location = new System.Drawing.Point(304, 512);
            this.btnEditRecords.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditRecords.Name = "btnEditRecords";
            this.btnEditRecords.Size = new System.Drawing.Size(39, 24);
            this.btnEditRecords.TabIndex = 17;
            this.btnEditRecords.Text = "Edytuj Listę";
            this.btnEditRecords.UseVisualStyleBackColor = true;
            this.btnEditRecords.Visible = false;
            this.btnEditRecords.Click += new System.EventHandler(this.btnEditRecords_Click);
            // 
            // txtDefinitionNameRU
            // 
            this.txtDefinitionNameRU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDefinitionNameRU.Location = new System.Drawing.Point(199, 510);
            this.txtDefinitionNameRU.MaxLength = 127;
            this.txtDefinitionNameRU.Name = "txtDefinitionNameRU";
            this.txtDefinitionNameRU.ReadOnly = true;
            this.txtDefinitionNameRU.Size = new System.Drawing.Size(21, 21);
            this.txtDefinitionNameRU.TabIndex = 10;
            this.txtDefinitionNameRU.Visible = false;
            // 
            // lblNameRU1
            // 
            this.lblNameRU1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNameRU1.Location = new System.Drawing.Point(152, 510);
            this.lblNameRU1.Name = "lblNameRU1";
            this.lblNameRU1.Size = new System.Drawing.Size(41, 20);
            this.lblNameRU1.TabIndex = 9;
            this.lblNameRU1.Text = "lblNameRU1";
            this.lblNameRU1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNameRU1.Visible = false;
            // 
            // txtDefinitionDescriptionRU
            // 
            this.txtDefinitionDescriptionRU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDefinitionDescriptionRU.Location = new System.Drawing.Point(253, 511);
            this.txtDefinitionDescriptionRU.MaxLength = 255;
            this.txtDefinitionDescriptionRU.Name = "txtDefinitionDescriptionRU";
            this.txtDefinitionDescriptionRU.ReadOnly = true;
            this.txtDefinitionDescriptionRU.Size = new System.Drawing.Size(26, 21);
            this.txtDefinitionDescriptionRU.TabIndex = 14;
            this.txtDefinitionDescriptionRU.Visible = false;
            // 
            // lblDescriptionRU1
            // 
            this.lblDescriptionRU1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDescriptionRU1.Location = new System.Drawing.Point(226, 512);
            this.lblDescriptionRU1.Name = "lblDescriptionRU1";
            this.lblDescriptionRU1.Size = new System.Drawing.Size(21, 20);
            this.lblDescriptionRU1.TabIndex = 13;
            this.lblDescriptionRU1.Text = "lblDescriptionRU1";
            this.lblDescriptionRU1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDescriptionRU1.Visible = false;
            // 
            // taDocumentDefinitions
            // 
            this.taDocumentDefinitions.ClearBeforeFill = true;
            // 
            // taDocumentDataTypes
            // 
            this.taDocumentDataTypes.ClearBeforeFill = true;
            // 
            // btnAddDefinition
            // 
            this.btnAddDefinition.Enabled = false;
            this.btnAddDefinition.Image = global::DocumentsManagerRU.Properties.Resources.plus_2x;
            this.btnAddDefinition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDefinition.Location = new System.Drawing.Point(382, 9);
            this.btnAddDefinition.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddDefinition.Name = "btnAddDefinition";
            this.btnAddDefinition.Size = new System.Drawing.Size(140, 24);
            this.btnAddDefinition.TabIndex = 1;
            this.btnAddDefinition.Text = "btnAddDefinition";
            this.btnAddDefinition.UseVisualStyleBackColor = true;
            this.btnAddDefinition.Click += new System.EventHandler(this.btnAddDefinition_Click);
            // 
            // taDocumentDefinitionListItems
            // 
            this.taDocumentDefinitionListItems.ClearBeforeFill = true;
            // 
            // dgvColumnItemId
            // 
            this.dgvColumnItemId.DataPropertyName = "Id";
            this.dgvColumnItemId.HeaderText = "dgvColumnItemId";
            this.dgvColumnItemId.Name = "dgvColumnItemId";
            this.dgvColumnItemId.ReadOnly = true;
            this.dgvColumnItemId.Visible = false;
            this.dgvColumnItemId.Width = 30;
            // 
            // dgvColumnItemDefinitionId
            // 
            this.dgvColumnItemDefinitionId.DataPropertyName = "DefinitionId";
            this.dgvColumnItemDefinitionId.HeaderText = "dgvColumnItemDefinitionId";
            this.dgvColumnItemDefinitionId.Name = "dgvColumnItemDefinitionId";
            this.dgvColumnItemDefinitionId.ReadOnly = true;
            this.dgvColumnItemDefinitionId.Visible = false;
            // 
            // dgvColumnItemName
            // 
            this.dgvColumnItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvColumnItemName.DataPropertyName = "Name";
            this.dgvColumnItemName.HeaderText = "dgvColumnItemName";
            this.dgvColumnItemName.Name = "dgvColumnItemName";
            this.dgvColumnItemName.ReadOnly = true;
            // 
            // dgvColumnItemActive
            // 
            this.dgvColumnItemActive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnItemActive.DataPropertyName = "Active";
            this.dgvColumnItemActive.HeaderText = "A";
            this.dgvColumnItemActive.Name = "dgvColumnItemActive";
            this.dgvColumnItemActive.ReadOnly = true;
            this.dgvColumnItemActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvColumnItemActive.Width = 30;
            // 
            // dgvColumnItemDelete
            // 
            this.dgvColumnItemDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnItemDelete.HeaderText = "";
            this.dgvColumnItemDelete.Image = global::DocumentsManagerRU.Properties.Resources.delete_2x;
            this.dgvColumnItemDelete.Name = "dgvColumnItemDelete";
            this.dgvColumnItemDelete.ReadOnly = true;
            this.dgvColumnItemDelete.Width = 30;
            // 
            // frmDefinitionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(539, 541);
            this.Controls.Add(this.btnAddDefinition);
            this.Controls.Add(this.gbDefinitionInfo);
            this.Controls.Add(this.btnSaveDefinition);
            this.Controls.Add(this.btnDeleteDefinition);
            this.Controls.Add(this.btnEditRecords);
            this.Controls.Add(this.chkEditDefinition);
            this.Controls.Add(this.txtDefinitionNameRU);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblNameRU1);
            this.Controls.Add(this.txtDefinitionDescriptionRU);
            this.Controls.Add(this.lblDescriptionRU1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDefinitionManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmContentManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmContentManager_FormClosed);
            this.Load += new System.EventHandler(this.frmContentManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTDataSet)).EndInit();
            this.gbDefinitionInfo.ResumeLayout(false);
            this.gbDefinitionInfo.PerformLayout();
            this.pnlAdvancedList.ResumeLayout(false);
            this.pnlAdvancedList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentDefinitionListItems)).EndInit();
            this.pnlSimpleList.ResumeLayout(false);
            this.pnlSimpleList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentDataTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentDefinitions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource bsDocumentClass;
        private ITDataSet iTDataSet;
        private ITDataSetTableAdapters.Document_ClassTableAdapter taDocumentClass;
        private System.Windows.Forms.Button btnSaveDefinition;
        private System.Windows.Forms.Button btnDeleteDefinition;
        private System.Windows.Forms.CheckBox chkEditDefinition;
        private System.Windows.Forms.GroupBox gbDefinitionInfo;
        private System.Windows.Forms.ComboBox cbDocumentDefinitions;
        private System.Windows.Forms.Label lblDefinition;
        private System.Windows.Forms.BindingSource bsDocumentDefinitions;
        private ITDataSetTableAdapters.GetDocumentDefinitionsTableAdapter taDocumentDefinitions;
        private System.Windows.Forms.Label lblDataType;
        private System.Windows.Forms.ComboBox cbDocumentDataType;
        private System.Windows.Forms.BindingSource bsDocumentDataTypes;
        private ITDataSetTableAdapters.GetDocumentDataTypesTableAdapter taDocumentDataTypes;
        private System.Windows.Forms.TextBox txtDefinitionNameRU;
        private System.Windows.Forms.Label lblNameRU1;
        private System.Windows.Forms.TextBox txtDefinitionDescriptionRU;
        private System.Windows.Forms.Label lblDescriptionRU1;
        private System.Windows.Forms.TextBox txtDefinitionDescriptionPL;
        private System.Windows.Forms.TextBox txtDefinitionNamePL;
        private System.Windows.Forms.Label lblNamePL1;
        private System.Windows.Forms.Label lblDescriptionPL1;
        private System.Windows.Forms.Label lblDefinitionList;
        private System.Windows.Forms.TextBox txtDefinitionList;
        private System.Windows.Forms.Button btnAddDefinition;
        private System.Windows.Forms.Button btnEditRecords;
        private System.Windows.Forms.Label lblListRecordCount;
        private System.Windows.Forms.TextBox txtListRecordCount;
        private System.Windows.Forms.Label lblDefinitionCount;
        private System.Windows.Forms.Panel pnlAdvancedList;
        private System.Windows.Forms.Panel pnlSimpleList;
        private System.Windows.Forms.DataGridView dgvListItems;
        private System.Windows.Forms.Button btnAddNewRecord;
        private System.Windows.Forms.TextBox txtNewRecord;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.BindingSource bsDocumentDefinitionListItems;
        private ITDataSetTableAdapters.GetDocumentDefinitionListItemsTableAdapter taDocumentDefinitionListItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnItemDefinitionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnItemName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvColumnItemActive;
        private System.Windows.Forms.DataGridViewImageColumn dgvColumnItemDelete;
    }
}