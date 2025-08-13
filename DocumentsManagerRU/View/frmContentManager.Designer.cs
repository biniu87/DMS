namespace DocumentsManagerRU
{
    partial class frmContentManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContentManager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.bsDocumentClass = new System.Windows.Forms.BindingSource(this.components);
            this.iTDataSet = new DocumentsManagerRU.ITDataSet();
            this.txtClassDescription = new System.Windows.Forms.TextBox();
            this.btnDeleteClass = new System.Windows.Forms.Button();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkEditClass = new System.Windows.Forms.CheckBox();
            this.taDocumentClass = new DocumentsManagerRU.ITDataSetTableAdapters.Document_ClassTableAdapter();
            this.gbClassInfo = new System.Windows.Forms.GroupBox();
            this.lblClassCount = new System.Windows.Forms.Label();
            this.ercClassActive = new DocumentsManagerRU.View.Controls.ExtendedRadioControl();
            this.lblActive = new System.Windows.Forms.Label();
            this.txtClassNameRU = new System.Windows.Forms.TextBox();
            this.lblNameRU = new System.Windows.Forms.Label();
            this.txtClassDescriptionRU = new System.Windows.Forms.TextBox();
            this.lblDescriptionRU = new System.Windows.Forms.Label();
            this.lblDescriptionRU1 = new System.Windows.Forms.Label();
            this.txtDefinitionDescriptionRU = new System.Windows.Forms.TextBox();
            this.lblNameRU1 = new System.Windows.Forms.Label();
            this.txtDefinitionNameRU = new System.Windows.Forms.TextBox();
            this.btnSaveClass = new System.Windows.Forms.Button();
            this.btnSaveDefinition = new System.Windows.Forms.Button();
            this.btnDeleteDefinition = new System.Windows.Forms.Button();
            this.chkEditDefinition = new System.Windows.Forms.CheckBox();
            this.gbDefinitionInfo = new System.Windows.Forms.GroupBox();
            this.chkUseDateDefault = new System.Windows.Forms.CheckBox();
            this.tcDefinition = new System.Windows.Forms.TabControl();
            this.pcDefinition = new System.Windows.Forms.TabPage();
            this.lblDefinitionCount = new System.Windows.Forms.Label();
            this.cbExistingDefinitions = new System.Windows.Forms.ComboBox();
            this.bsDocumentDefinitionsByDirective = new System.Windows.Forms.BindingSource(this.components);
            this.lblExistingDefinitions = new System.Windows.Forms.Label();
            this.lblNamePL1 = new System.Windows.Forms.Label();
            this.lblDescriptionPL1 = new System.Windows.Forms.Label();
            this.txtDefinitionNamePL = new System.Windows.Forms.TextBox();
            this.txtDefinitionDescriptionPL = new System.Windows.Forms.TextBox();
            this.cbDocumentDataType = new System.Windows.Forms.ComboBox();
            this.bsDocumentDataTypes = new System.Windows.Forms.BindingSource(this.components);
            this.lblDataType = new System.Windows.Forms.Label();
            this.pcSimpleList = new System.Windows.Forms.TabPage();
            this.lblDefinitionList = new System.Windows.Forms.Label();
            this.txtDefinitionList = new System.Windows.Forms.TextBox();
            this.pcAdvancedList = new System.Windows.Forms.TabPage();
            this.dgvListItems = new System.Windows.Forms.DataGridView();
            this.dgvColumnItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.definitionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDocumentDefinitionListItems = new System.Windows.Forms.BindingSource(this.components);
            this.lblDefinitionListAdv = new System.Windows.Forms.Label();
            this.lblDefaultListCount = new System.Windows.Forms.Label();
            this.lblDefinitionPerClassCount = new System.Windows.Forms.Label();
            this.cbDefinitionDefault = new DocumentsManagerRU.Controls.ContainsComboBox();
            this.ercRequired = new DocumentsManagerRU.View.Controls.ExtendedRadioControl();
            this.ercDefinitionActive = new DocumentsManagerRU.View.Controls.ExtendedRadioControl();
            this.txtDefinitionDefault = new System.Windows.Forms.TextBox();
            this.dtpDefinitionDefault = new System.Windows.Forms.DateTimePicker();
            this.lblDefinitionDefault = new System.Windows.Forms.Label();
            this.lblActive3 = new System.Windows.Forms.Label();
            this.lblIsRequired = new System.Windows.Forms.Label();
            this.cbDocumentDefinitionsPerClass = new System.Windows.Forms.ComboBox();
            this.bsDocumentDefinitionsPerClass = new System.Windows.Forms.BindingSource(this.components);
            this.lblDefinition = new System.Windows.Forms.Label();
            this.taDocumentDefinitionsPerClass = new DocumentsManagerRU.ITDataSetTableAdapters.GetDocumentDefinitionsForClassTableAdapter();
            this.taDocumentDataTypes = new DocumentsManagerRU.ITDataSetTableAdapters.GetDocumentDataTypesTableAdapter();
            this.btnAddDefinition = new System.Windows.Forms.Button();
            this.taDocumentDefinitionsByDirective = new DocumentsManagerRU.ITDataSetTableAdapters.GetDocumentDefinitionsByDirectiveTableAdapter();
            this.taDocumentDefinitionListItems = new DocumentsManagerRU.ITDataSetTableAdapters.GetDocumentDefinitionListItemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTDataSet)).BeginInit();
            this.gbClassInfo.SuspendLayout();
            this.gbDefinitionInfo.SuspendLayout();
            this.tcDefinition.SuspendLayout();
            this.pcDefinition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentDefinitionsByDirective)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentDataTypes)).BeginInit();
            this.pcSimpleList.SuspendLayout();
            this.pcAdvancedList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentDefinitionListItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentDefinitionsPerClass)).BeginInit();
            this.SuspendLayout();
            // 
            // cbClass
            // 
            this.cbClass.DataSource = this.bsDocumentClass;
            this.cbClass.DisplayMember = "CurrentName";
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(146, 16);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(307, 21);
            this.cbClass.TabIndex = 1;
            this.cbClass.ValueMember = "Id";
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
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
            // txtClassDescription
            // 
            this.txtClassDescription.Location = new System.Drawing.Point(146, 72);
            this.txtClassDescription.MaxLength = 255;
            this.txtClassDescription.Name = "txtClassDescription";
            this.txtClassDescription.ReadOnly = true;
            this.txtClassDescription.Size = new System.Drawing.Size(307, 21);
            this.txtClassDescription.TabIndex = 8;
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteClass.Image")));
            this.btnDeleteClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteClass.Location = new System.Drawing.Point(382, 9);
            this.btnDeleteClass.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(140, 24);
            this.btnDeleteClass.TabIndex = 1;
            this.btnDeleteClass.Text = "btnDeleteClass";
            this.btnDeleteClass.UseVisualStyleBackColor = true;
            this.btnDeleteClass.Visible = false;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click);
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(146, 43);
            this.txtClassName.MaxLength = 127;
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.ReadOnly = true;
            this.txtClassName.Size = new System.Drawing.Size(307, 21);
            this.txtClassName.TabIndex = 4;
            // 
            // lblClass
            // 
            this.lblClass.Location = new System.Drawing.Point(6, 16);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(134, 21);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "lblClass";
            this.lblClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(6, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(134, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "lblName";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(6, 71);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(134, 20);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "lblDescription";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(904, 331);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 24);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // chkEditClass
            // 
            this.chkEditClass.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkEditClass.Checked = true;
            this.chkEditClass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEditClass.Image = ((System.Drawing.Image)(resources.GetObject("chkEditClass.Image")));
            this.chkEditClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkEditClass.Location = new System.Drawing.Point(9, 9);
            this.chkEditClass.Margin = new System.Windows.Forms.Padding(0);
            this.chkEditClass.Name = "chkEditClass";
            this.chkEditClass.Size = new System.Drawing.Size(140, 24);
            this.chkEditClass.TabIndex = 0;
            this.chkEditClass.Text = "chkEditClass";
            this.chkEditClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkEditClass.UseVisualStyleBackColor = true;
            this.chkEditClass.CheckedChanged += new System.EventHandler(this.chkEditClass_CheckedChanged);
            // 
            // taDocumentClass
            // 
            this.taDocumentClass.ClearBeforeFill = true;
            // 
            // gbClassInfo
            // 
            this.gbClassInfo.Controls.Add(this.chkUseDateDefault);
            this.gbClassInfo.Controls.Add(this.lblClassCount);
            this.gbClassInfo.Controls.Add(this.ercClassActive);
            this.gbClassInfo.Controls.Add(this.lblDefaultListCount);
            this.gbClassInfo.Controls.Add(this.lblActive);
            this.gbClassInfo.Controls.Add(this.txtClassNameRU);
            this.gbClassInfo.Controls.Add(this.cbDefinitionDefault);
            this.gbClassInfo.Controls.Add(this.lblNameRU);
            this.gbClassInfo.Controls.Add(this.txtClassDescriptionRU);
            this.gbClassInfo.Controls.Add(this.txtDefinitionDefault);
            this.gbClassInfo.Controls.Add(this.lblDescriptionRU);
            this.gbClassInfo.Controls.Add(this.dtpDefinitionDefault);
            this.gbClassInfo.Controls.Add(this.lblDescriptionRU1);
            this.gbClassInfo.Controls.Add(this.lblDefinitionDefault);
            this.gbClassInfo.Controls.Add(this.cbClass);
            this.gbClassInfo.Controls.Add(this.txtDefinitionDescriptionRU);
            this.gbClassInfo.Controls.Add(this.txtClassDescription);
            this.gbClassInfo.Controls.Add(this.txtClassName);
            this.gbClassInfo.Controls.Add(this.lblNameRU1);
            this.gbClassInfo.Controls.Add(this.lblClass);
            this.gbClassInfo.Controls.Add(this.lblName);
            this.gbClassInfo.Controls.Add(this.txtDefinitionNameRU);
            this.gbClassInfo.Controls.Add(this.lblDescription);
            this.gbClassInfo.Location = new System.Drawing.Point(9, 36);
            this.gbClassInfo.Name = "gbClassInfo";
            this.gbClassInfo.Size = new System.Drawing.Size(513, 292);
            this.gbClassInfo.TabIndex = 2;
            this.gbClassInfo.TabStop = false;
            this.gbClassInfo.Text = "gbClassInfo";
            // 
            // lblClassCount
            // 
            this.lblClassCount.Location = new System.Drawing.Point(453, 15);
            this.lblClassCount.Name = "lblClassCount";
            this.lblClassCount.Size = new System.Drawing.Size(51, 21);
            this.lblClassCount.TabIndex = 13;
            this.lblClassCount.Text = "(999999)";
            this.lblClassCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ercClassActive
            // 
            this.ercClassActive.Checked = true;
            this.ercClassActive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ercClassActive.Location = new System.Drawing.Point(146, 99);
            this.ercClassActive.Name = "ercClassActive";
            this.ercClassActive.Size = new System.Drawing.Size(192, 24);
            this.ercClassActive.TabIndex = 12;
            // 
            // lblActive
            // 
            this.lblActive.Location = new System.Drawing.Point(6, 99);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(134, 24);
            this.lblActive.TabIndex = 11;
            this.lblActive.Text = "lblActive";
            this.lblActive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtClassNameRU
            // 
            this.txtClassNameRU.Location = new System.Drawing.Point(80, 146);
            this.txtClassNameRU.MaxLength = 127;
            this.txtClassNameRU.Name = "txtClassNameRU";
            this.txtClassNameRU.ReadOnly = true;
            this.txtClassNameRU.Size = new System.Drawing.Size(42, 21);
            this.txtClassNameRU.TabIndex = 6;
            this.txtClassNameRU.Visible = false;
            // 
            // lblNameRU
            // 
            this.lblNameRU.Location = new System.Drawing.Point(25, 151);
            this.lblNameRU.Name = "lblNameRU";
            this.lblNameRU.Size = new System.Drawing.Size(49, 20);
            this.lblNameRU.TabIndex = 5;
            this.lblNameRU.Text = "lblNameRU";
            this.lblNameRU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNameRU.Visible = false;
            // 
            // txtClassDescriptionRU
            // 
            this.txtClassDescriptionRU.Location = new System.Drawing.Point(173, 146);
            this.txtClassDescriptionRU.MaxLength = 255;
            this.txtClassDescriptionRU.Name = "txtClassDescriptionRU";
            this.txtClassDescriptionRU.ReadOnly = true;
            this.txtClassDescriptionRU.Size = new System.Drawing.Size(51, 21);
            this.txtClassDescriptionRU.TabIndex = 10;
            this.txtClassDescriptionRU.Visible = false;
            // 
            // lblDescriptionRU
            // 
            this.lblDescriptionRU.Location = new System.Drawing.Point(128, 149);
            this.lblDescriptionRU.Name = "lblDescriptionRU";
            this.lblDescriptionRU.Size = new System.Drawing.Size(39, 20);
            this.lblDescriptionRU.TabIndex = 9;
            this.lblDescriptionRU.Text = "lblDescriptionRU";
            this.lblDescriptionRU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDescriptionRU.Visible = false;
            // 
            // lblDescriptionRU1
            // 
            this.lblDescriptionRU1.Location = new System.Drawing.Point(307, 153);
            this.lblDescriptionRU1.Name = "lblDescriptionRU1";
            this.lblDescriptionRU1.Size = new System.Drawing.Size(53, 20);
            this.lblDescriptionRU1.TabIndex = 10;
            this.lblDescriptionRU1.Text = "lblDescriptionRU1";
            this.lblDescriptionRU1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDescriptionRU1.Visible = false;
            // 
            // txtDefinitionDescriptionRU
            // 
            this.txtDefinitionDescriptionRU.Location = new System.Drawing.Point(366, 154);
            this.txtDefinitionDescriptionRU.MaxLength = 255;
            this.txtDefinitionDescriptionRU.Name = "txtDefinitionDescriptionRU";
            this.txtDefinitionDescriptionRU.ReadOnly = true;
            this.txtDefinitionDescriptionRU.Size = new System.Drawing.Size(30, 21);
            this.txtDefinitionDescriptionRU.TabIndex = 11;
            this.txtDefinitionDescriptionRU.Visible = false;
            // 
            // lblNameRU1
            // 
            this.lblNameRU1.Location = new System.Drawing.Point(402, 154);
            this.lblNameRU1.Name = "lblNameRU1";
            this.lblNameRU1.Size = new System.Drawing.Size(47, 20);
            this.lblNameRU1.TabIndex = 6;
            this.lblNameRU1.Text = "lblNameRU1";
            this.lblNameRU1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNameRU1.Visible = false;
            // 
            // txtDefinitionNameRU
            // 
            this.txtDefinitionNameRU.Location = new System.Drawing.Point(455, 152);
            this.txtDefinitionNameRU.MaxLength = 127;
            this.txtDefinitionNameRU.Name = "txtDefinitionNameRU";
            this.txtDefinitionNameRU.ReadOnly = true;
            this.txtDefinitionNameRU.Size = new System.Drawing.Size(53, 21);
            this.txtDefinitionNameRU.TabIndex = 7;
            this.txtDefinitionNameRU.Visible = false;
            // 
            // btnSaveClass
            // 
            this.btnSaveClass.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveClass.Image")));
            this.btnSaveClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveClass.Location = new System.Drawing.Point(9, 331);
            this.btnSaveClass.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaveClass.Name = "btnSaveClass";
            this.btnSaveClass.Size = new System.Drawing.Size(140, 24);
            this.btnSaveClass.TabIndex = 3;
            this.btnSaveClass.Text = "btnSaveClass";
            this.btnSaveClass.UseVisualStyleBackColor = true;
            this.btnSaveClass.Click += new System.EventHandler(this.btnSaveClass_Click);
            // 
            // btnSaveDefinition
            // 
            this.btnSaveDefinition.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveDefinition.Image")));
            this.btnSaveDefinition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveDefinition.Location = new System.Drawing.Point(531, 330);
            this.btnSaveDefinition.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaveDefinition.Name = "btnSaveDefinition";
            this.btnSaveDefinition.Size = new System.Drawing.Size(140, 24);
            this.btnSaveDefinition.TabIndex = 8;
            this.btnSaveDefinition.Text = "btnSaveDefinition";
            this.btnSaveDefinition.UseVisualStyleBackColor = true;
            this.btnSaveDefinition.Click += new System.EventHandler(this.btnSaveDefinitions_Click);
            // 
            // btnDeleteDefinition
            // 
            this.btnDeleteDefinition.Enabled = false;
            this.btnDeleteDefinition.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteDefinition.Image")));
            this.btnDeleteDefinition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteDefinition.Location = new System.Drawing.Point(764, 9);
            this.btnDeleteDefinition.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteDefinition.Name = "btnDeleteDefinition";
            this.btnDeleteDefinition.Size = new System.Drawing.Size(140, 24);
            this.btnDeleteDefinition.TabIndex = 6;
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
            this.chkEditDefinition.Location = new System.Drawing.Point(531, 9);
            this.chkEditDefinition.Margin = new System.Windows.Forms.Padding(0);
            this.chkEditDefinition.Name = "chkEditDefinition";
            this.chkEditDefinition.Size = new System.Drawing.Size(140, 24);
            this.chkEditDefinition.TabIndex = 4;
            this.chkEditDefinition.Text = "chkEditDefinition";
            this.chkEditDefinition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkEditDefinition.UseVisualStyleBackColor = true;
            this.chkEditDefinition.CheckedChanged += new System.EventHandler(this.chkEditDefinitions_CheckedChanged);
            // 
            // gbDefinitionInfo
            // 
            this.gbDefinitionInfo.Controls.Add(this.tcDefinition);
            this.gbDefinitionInfo.Controls.Add(this.lblDefinitionPerClassCount);
            this.gbDefinitionInfo.Controls.Add(this.ercRequired);
            this.gbDefinitionInfo.Controls.Add(this.ercDefinitionActive);
            this.gbDefinitionInfo.Controls.Add(this.lblActive3);
            this.gbDefinitionInfo.Controls.Add(this.lblIsRequired);
            this.gbDefinitionInfo.Controls.Add(this.cbDocumentDefinitionsPerClass);
            this.gbDefinitionInfo.Controls.Add(this.lblDefinition);
            this.gbDefinitionInfo.Location = new System.Drawing.Point(531, 36);
            this.gbDefinitionInfo.Name = "gbDefinitionInfo";
            this.gbDefinitionInfo.Size = new System.Drawing.Size(513, 292);
            this.gbDefinitionInfo.TabIndex = 7;
            this.gbDefinitionInfo.TabStop = false;
            this.gbDefinitionInfo.Text = "gbDefinitionInfo";
            // 
            // chkUseDateDefault
            // 
            this.chkUseDateDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkUseDateDefault.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkUseDateDefault.Checked = true;
            this.chkUseDateDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseDateDefault.Image = global::DocumentsManagerRU.Properties.Resources.check_2x;
            this.chkUseDateDefault.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkUseDateDefault.Location = new System.Drawing.Point(330, 191);
            this.chkUseDateDefault.Margin = new System.Windows.Forms.Padding(4, 4, 20, 5);
            this.chkUseDateDefault.Name = "chkUseDateDefault";
            this.chkUseDateDefault.Size = new System.Drawing.Size(56, 21);
            this.chkUseDateDefault.TabIndex = 55;
            this.chkUseDateDefault.UseVisualStyleBackColor = true;
            this.chkUseDateDefault.Visible = false;
            this.chkUseDateDefault.CheckedChanged += new System.EventHandler(this.chkUseDateDefault_CheckedChanged);
            // 
            // tcDefinition
            // 
            this.tcDefinition.Controls.Add(this.pcDefinition);
            this.tcDefinition.Controls.Add(this.pcSimpleList);
            this.tcDefinition.Controls.Add(this.pcAdvancedList);
            this.tcDefinition.Location = new System.Drawing.Point(3, 43);
            this.tcDefinition.Name = "tcDefinition";
            this.tcDefinition.SelectedIndex = 0;
            this.tcDefinition.Size = new System.Drawing.Size(504, 145);
            this.tcDefinition.TabIndex = 3;
            // 
            // pcDefinition
            // 
            this.pcDefinition.Controls.Add(this.lblDefinitionCount);
            this.pcDefinition.Controls.Add(this.cbExistingDefinitions);
            this.pcDefinition.Controls.Add(this.lblExistingDefinitions);
            this.pcDefinition.Controls.Add(this.lblNamePL1);
            this.pcDefinition.Controls.Add(this.lblDescriptionPL1);
            this.pcDefinition.Controls.Add(this.txtDefinitionNamePL);
            this.pcDefinition.Controls.Add(this.txtDefinitionDescriptionPL);
            this.pcDefinition.Controls.Add(this.cbDocumentDataType);
            this.pcDefinition.Controls.Add(this.lblDataType);
            this.pcDefinition.Location = new System.Drawing.Point(4, 22);
            this.pcDefinition.Name = "pcDefinition";
            this.pcDefinition.Padding = new System.Windows.Forms.Padding(3);
            this.pcDefinition.Size = new System.Drawing.Size(496, 119);
            this.pcDefinition.TabIndex = 0;
            this.pcDefinition.Text = "pcDefinition";
            // 
            // lblDefinitionCount
            // 
            this.lblDefinitionCount.Location = new System.Drawing.Point(449, 6);
            this.lblDefinitionCount.Name = "lblDefinitionCount";
            this.lblDefinitionCount.Size = new System.Drawing.Size(44, 21);
            this.lblDefinitionCount.TabIndex = 55;
            this.lblDefinitionCount.Text = "(9999)";
            this.lblDefinitionCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbExistingDefinitions
            // 
            this.cbExistingDefinitions.DataSource = this.bsDocumentDefinitionsByDirective;
            this.cbExistingDefinitions.DisplayMember = "CurrentName_Type";
            this.cbExistingDefinitions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExistingDefinitions.FormattingEnabled = true;
            this.cbExistingDefinitions.Location = new System.Drawing.Point(139, 6);
            this.cbExistingDefinitions.Name = "cbExistingDefinitions";
            this.cbExistingDefinitions.Size = new System.Drawing.Size(304, 21);
            this.cbExistingDefinitions.TabIndex = 1;
            this.cbExistingDefinitions.ValueMember = "Id";
            this.cbExistingDefinitions.SelectedIndexChanged += new System.EventHandler(this.cbExistingDefinitions_SelectedIndexChanged);
            // 
            // bsDocumentDefinitionsByDirective
            // 
            this.bsDocumentDefinitionsByDirective.DataMember = "GetDocumentDefinitionsByDirective";
            this.bsDocumentDefinitionsByDirective.DataSource = this.iTDataSet;
            // 
            // lblExistingDefinitions
            // 
            this.lblExistingDefinitions.Location = new System.Drawing.Point(9, 6);
            this.lblExistingDefinitions.Name = "lblExistingDefinitions";
            this.lblExistingDefinitions.Size = new System.Drawing.Size(124, 21);
            this.lblExistingDefinitions.TabIndex = 0;
            this.lblExistingDefinitions.Text = "lblExistingDefinitions";
            this.lblExistingDefinitions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNamePL1
            // 
            this.lblNamePL1.Location = new System.Drawing.Point(6, 60);
            this.lblNamePL1.Name = "lblNamePL1";
            this.lblNamePL1.Size = new System.Drawing.Size(127, 20);
            this.lblNamePL1.TabIndex = 4;
            this.lblNamePL1.Text = "lblNamePL1";
            this.lblNamePL1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescriptionPL1
            // 
            this.lblDescriptionPL1.Location = new System.Drawing.Point(6, 86);
            this.lblDescriptionPL1.Name = "lblDescriptionPL1";
            this.lblDescriptionPL1.Size = new System.Drawing.Size(127, 20);
            this.lblDescriptionPL1.TabIndex = 8;
            this.lblDescriptionPL1.Text = "lblDescriptionPL1";
            this.lblDescriptionPL1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDefinitionNamePL
            // 
            this.txtDefinitionNamePL.Location = new System.Drawing.Point(139, 60);
            this.txtDefinitionNamePL.MaxLength = 127;
            this.txtDefinitionNamePL.Name = "txtDefinitionNamePL";
            this.txtDefinitionNamePL.ReadOnly = true;
            this.txtDefinitionNamePL.Size = new System.Drawing.Size(304, 21);
            this.txtDefinitionNamePL.TabIndex = 5;
            // 
            // txtDefinitionDescriptionPL
            // 
            this.txtDefinitionDescriptionPL.Location = new System.Drawing.Point(139, 87);
            this.txtDefinitionDescriptionPL.MaxLength = 255;
            this.txtDefinitionDescriptionPL.Name = "txtDefinitionDescriptionPL";
            this.txtDefinitionDescriptionPL.ReadOnly = true;
            this.txtDefinitionDescriptionPL.Size = new System.Drawing.Size(304, 21);
            this.txtDefinitionDescriptionPL.TabIndex = 9;
            // 
            // cbDocumentDataType
            // 
            this.cbDocumentDataType.DataSource = this.bsDocumentDataTypes;
            this.cbDocumentDataType.DisplayMember = "Name";
            this.cbDocumentDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDocumentDataType.FormattingEnabled = true;
            this.cbDocumentDataType.Location = new System.Drawing.Point(139, 33);
            this.cbDocumentDataType.Name = "cbDocumentDataType";
            this.cbDocumentDataType.Size = new System.Drawing.Size(304, 21);
            this.cbDocumentDataType.TabIndex = 3;
            this.cbDocumentDataType.ValueMember = "TypeValue";
            this.cbDocumentDataType.SelectedIndexChanged += new System.EventHandler(this.cbDocumentDataType_SelectedIndexChanged);
            // 
            // bsDocumentDataTypes
            // 
            this.bsDocumentDataTypes.DataMember = "GetDocumentDataTypes";
            this.bsDocumentDataTypes.DataSource = this.iTDataSet;
            // 
            // lblDataType
            // 
            this.lblDataType.Location = new System.Drawing.Point(6, 33);
            this.lblDataType.Name = "lblDataType";
            this.lblDataType.Size = new System.Drawing.Size(127, 21);
            this.lblDataType.TabIndex = 2;
            this.lblDataType.Text = "lblDataType";
            this.lblDataType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pcSimpleList
            // 
            this.pcSimpleList.Controls.Add(this.lblDefinitionList);
            this.pcSimpleList.Controls.Add(this.txtDefinitionList);
            this.pcSimpleList.Location = new System.Drawing.Point(4, 22);
            this.pcSimpleList.Name = "pcSimpleList";
            this.pcSimpleList.Padding = new System.Windows.Forms.Padding(3);
            this.pcSimpleList.Size = new System.Drawing.Size(496, 119);
            this.pcSimpleList.TabIndex = 1;
            this.pcSimpleList.Text = "pcSimpleList";
            // 
            // lblDefinitionList
            // 
            this.lblDefinitionList.Location = new System.Drawing.Point(6, 9);
            this.lblDefinitionList.Name = "lblDefinitionList";
            this.lblDefinitionList.Size = new System.Drawing.Size(127, 92);
            this.lblDefinitionList.TabIndex = 56;
            this.lblDefinitionList.Text = "lblDefinitionList";
            this.lblDefinitionList.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDefinitionList
            // 
            this.txtDefinitionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDefinitionList.Location = new System.Drawing.Point(139, 9);
            this.txtDefinitionList.Multiline = true;
            this.txtDefinitionList.Name = "txtDefinitionList";
            this.txtDefinitionList.ReadOnly = true;
            this.txtDefinitionList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDefinitionList.Size = new System.Drawing.Size(354, 107);
            this.txtDefinitionList.TabIndex = 55;
            this.txtDefinitionList.Leave += new System.EventHandler(this.txtDefinitionList_Leave);
            // 
            // pcAdvancedList
            // 
            this.pcAdvancedList.Controls.Add(this.dgvListItems);
            this.pcAdvancedList.Controls.Add(this.lblDefinitionListAdv);
            this.pcAdvancedList.Location = new System.Drawing.Point(4, 22);
            this.pcAdvancedList.Name = "pcAdvancedList";
            this.pcAdvancedList.Size = new System.Drawing.Size(496, 119);
            this.pcAdvancedList.TabIndex = 2;
            this.pcAdvancedList.Text = "pcAdvancedList";
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListItems.ColumnHeadersVisible = false;
            this.dgvListItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumnItemId,
            this.definitionIdDataGridViewTextBoxColumn,
            this.dgvColumnName});
            this.dgvListItems.DataSource = this.bsDocumentDefinitionListItems;
            this.dgvListItems.Location = new System.Drawing.Point(168, 4);
            this.dgvListItems.Name = "dgvListItems";
            this.dgvListItems.ReadOnly = true;
            this.dgvListItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListItems.Size = new System.Drawing.Size(325, 112);
            this.dgvListItems.TabIndex = 58;
            // 
            // dgvColumnItemId
            // 
            this.dgvColumnItemId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnItemId.DataPropertyName = "Id";
            this.dgvColumnItemId.HeaderText = "dgvColumnItemId";
            this.dgvColumnItemId.Name = "dgvColumnItemId";
            this.dgvColumnItemId.ReadOnly = true;
            this.dgvColumnItemId.Visible = false;
            // 
            // definitionIdDataGridViewTextBoxColumn
            // 
            this.definitionIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.definitionIdDataGridViewTextBoxColumn.DataPropertyName = "DefinitionId";
            this.definitionIdDataGridViewTextBoxColumn.HeaderText = "dgvColumnDefinitionId";
            this.definitionIdDataGridViewTextBoxColumn.Name = "definitionIdDataGridViewTextBoxColumn";
            this.definitionIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.definitionIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // dgvColumnName
            // 
            this.dgvColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvColumnName.DataPropertyName = "Name";
            this.dgvColumnName.HeaderText = "dgvColumnName";
            this.dgvColumnName.Name = "dgvColumnName";
            this.dgvColumnName.ReadOnly = true;
            // 
            // bsDocumentDefinitionListItems
            // 
            this.bsDocumentDefinitionListItems.DataMember = "GetDocumentDefinitionListItems";
            this.bsDocumentDefinitionListItems.DataSource = this.iTDataSet;
            // 
            // lblDefinitionListAdv
            // 
            this.lblDefinitionListAdv.Location = new System.Drawing.Point(3, 8);
            this.lblDefinitionListAdv.Name = "lblDefinitionListAdv";
            this.lblDefinitionListAdv.Size = new System.Drawing.Size(156, 92);
            this.lblDefinitionListAdv.TabIndex = 57;
            this.lblDefinitionListAdv.Text = "lblDefinitionListAdv";
            this.lblDefinitionListAdv.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDefaultListCount
            // 
            this.lblDefaultListCount.Location = new System.Drawing.Point(441, 190);
            this.lblDefaultListCount.Name = "lblDefaultListCount";
            this.lblDefaultListCount.Size = new System.Drawing.Size(51, 21);
            this.lblDefaultListCount.TabIndex = 0;
            this.lblDefaultListCount.Text = "(999999)";
            this.lblDefaultListCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDefaultListCount.Visible = false;
            // 
            // lblDefinitionPerClassCount
            // 
            this.lblDefinitionPerClassCount.Location = new System.Drawing.Point(456, 15);
            this.lblDefinitionPerClassCount.Name = "lblDefinitionPerClassCount";
            this.lblDefinitionPerClassCount.Size = new System.Drawing.Size(51, 21);
            this.lblDefinitionPerClassCount.TabIndex = 0;
            this.lblDefinitionPerClassCount.Text = "(999999)";
            this.lblDefinitionPerClassCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbDefinitionDefault
            // 
            this.cbDefinitionDefault.DataSource = null;
            this.cbDefinitionDefault.DisplayMember = "Value";
            this.cbDefinitionDefault.FormattingEnabled = true;
            this.cbDefinitionDefault.Location = new System.Drawing.Point(131, 191);
            this.cbDefinitionDefault.Name = "cbDefinitionDefault";
            this.cbDefinitionDefault.SelectedValue = -2147483648;
            this.cbDefinitionDefault.Size = new System.Drawing.Size(255, 21);
            this.cbDefinitionDefault.TabIndex = 7;
            this.cbDefinitionDefault.ValueMember = "Key";
            this.cbDefinitionDefault.Visible = false;
            // 
            // ercRequired
            // 
            this.ercRequired.Checked = true;
            this.ercRequired.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ercRequired.Location = new System.Drawing.Point(150, 191);
            this.ercRequired.Name = "ercRequired";
            this.ercRequired.Size = new System.Drawing.Size(192, 24);
            this.ercRequired.TabIndex = 5;
            this.ercRequired.CheckedChanged += new System.EventHandler(this.chkRequired_CheckedChanged);
            // 
            // ercDefinitionActive
            // 
            this.ercDefinitionActive.Checked = true;
            this.ercDefinitionActive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ercDefinitionActive.Location = new System.Drawing.Point(150, 221);
            this.ercDefinitionActive.Name = "ercDefinitionActive";
            this.ercDefinitionActive.Size = new System.Drawing.Size(192, 24);
            this.ercDefinitionActive.TabIndex = 9;
            // 
            // txtDefinitionDefault
            // 
            this.txtDefinitionDefault.Location = new System.Drawing.Point(131, 191);
            this.txtDefinitionDefault.MaxLength = 255;
            this.txtDefinitionDefault.Name = "txtDefinitionDefault";
            this.txtDefinitionDefault.ReadOnly = true;
            this.txtDefinitionDefault.Size = new System.Drawing.Size(255, 21);
            this.txtDefinitionDefault.TabIndex = 53;
            this.txtDefinitionDefault.Visible = false;
            // 
            // dtpDefinitionDefault
            // 
            this.dtpDefinitionDefault.Location = new System.Drawing.Point(131, 192);
            this.dtpDefinitionDefault.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDefinitionDefault.Name = "dtpDefinitionDefault";
            this.dtpDefinitionDefault.Size = new System.Drawing.Size(192, 21);
            this.dtpDefinitionDefault.TabIndex = 54;
            this.dtpDefinitionDefault.Visible = false;
            // 
            // lblDefinitionDefault
            // 
            this.lblDefinitionDefault.Location = new System.Drawing.Point(51, 192);
            this.lblDefinitionDefault.Name = "lblDefinitionDefault";
            this.lblDefinitionDefault.Size = new System.Drawing.Size(74, 20);
            this.lblDefinitionDefault.TabIndex = 6;
            this.lblDefinitionDefault.Text = "lblDefinitionDefault";
            this.lblDefinitionDefault.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDefinitionDefault.Visible = false;
            // 
            // lblActive3
            // 
            this.lblActive3.Location = new System.Drawing.Point(13, 221);
            this.lblActive3.Name = "lblActive3";
            this.lblActive3.Size = new System.Drawing.Size(131, 24);
            this.lblActive3.TabIndex = 8;
            this.lblActive3.Text = "lblActive3";
            this.lblActive3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIsRequired
            // 
            this.lblIsRequired.Location = new System.Drawing.Point(13, 191);
            this.lblIsRequired.Name = "lblIsRequired";
            this.lblIsRequired.Size = new System.Drawing.Size(131, 24);
            this.lblIsRequired.TabIndex = 4;
            this.lblIsRequired.Text = "lblIsRequired";
            this.lblIsRequired.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbDocumentDefinitionsPerClass
            // 
            this.cbDocumentDefinitionsPerClass.DataSource = this.bsDocumentDefinitionsPerClass;
            this.cbDocumentDefinitionsPerClass.DisplayMember = "CurrentName_Type";
            this.cbDocumentDefinitionsPerClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDocumentDefinitionsPerClass.FormattingEnabled = true;
            this.cbDocumentDefinitionsPerClass.Location = new System.Drawing.Point(146, 16);
            this.cbDocumentDefinitionsPerClass.Name = "cbDocumentDefinitionsPerClass";
            this.cbDocumentDefinitionsPerClass.Size = new System.Drawing.Size(304, 21);
            this.cbDocumentDefinitionsPerClass.TabIndex = 1;
            this.cbDocumentDefinitionsPerClass.ValueMember = "Id";
            this.cbDocumentDefinitionsPerClass.SelectedIndexChanged += new System.EventHandler(this.cbDocumentDefinitions_SelectedIndexChanged);
            // 
            // bsDocumentDefinitionsPerClass
            // 
            this.bsDocumentDefinitionsPerClass.DataMember = "GetDocumentDefinitionsForClass";
            this.bsDocumentDefinitionsPerClass.DataSource = this.iTDataSet;
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
            // taDocumentDefinitionsPerClass
            // 
            this.taDocumentDefinitionsPerClass.ClearBeforeFill = true;
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
            this.btnAddDefinition.Location = new System.Drawing.Point(904, 9);
            this.btnAddDefinition.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddDefinition.Name = "btnAddDefinition";
            this.btnAddDefinition.Size = new System.Drawing.Size(140, 24);
            this.btnAddDefinition.TabIndex = 5;
            this.btnAddDefinition.Text = "btnAddDefinition";
            this.btnAddDefinition.UseVisualStyleBackColor = true;
            this.btnAddDefinition.Click += new System.EventHandler(this.btnAddDefinition_Click);
            // 
            // taDocumentDefinitionsByDirective
            // 
            this.taDocumentDefinitionsByDirective.ClearBeforeFill = true;
            // 
            // taDocumentDefinitionListItems
            // 
            this.taDocumentDefinitionListItems.ClearBeforeFill = true;
            // 
            // frmContentManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1054, 363);
            this.Controls.Add(this.btnAddDefinition);
            this.Controls.Add(this.gbDefinitionInfo);
            this.Controls.Add(this.btnSaveDefinition);
            this.Controls.Add(this.btnDeleteDefinition);
            this.Controls.Add(this.chkEditDefinition);
            this.Controls.Add(this.btnSaveClass);
            this.Controls.Add(this.btnDeleteClass);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbClassInfo);
            this.Controls.Add(this.chkEditClass);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmContentManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmContentManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmContentManager_FormClosed);
            this.Load += new System.EventHandler(this.frmContentManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTDataSet)).EndInit();
            this.gbClassInfo.ResumeLayout(false);
            this.gbClassInfo.PerformLayout();
            this.gbDefinitionInfo.ResumeLayout(false);
            this.tcDefinition.ResumeLayout(false);
            this.pcDefinition.ResumeLayout(false);
            this.pcDefinition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentDefinitionsByDirective)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentDataTypes)).EndInit();
            this.pcSimpleList.ResumeLayout(false);
            this.pcSimpleList.PerformLayout();
            this.pcAdvancedList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentDefinitionListItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentDefinitionsPerClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.TextBox txtClassDescription;
        private System.Windows.Forms.Button btnDeleteClass;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkEditClass;
        private System.Windows.Forms.BindingSource bsDocumentClass;
        private ITDataSet iTDataSet;
        private ITDataSetTableAdapters.Document_ClassTableAdapter taDocumentClass;
        private System.Windows.Forms.GroupBox gbClassInfo;
        private System.Windows.Forms.TextBox txtClassNameRU;
        private System.Windows.Forms.Label lblNameRU;
        private System.Windows.Forms.TextBox txtClassDescriptionRU;
        private System.Windows.Forms.Label lblDescriptionRU;
        private System.Windows.Forms.Button btnSaveClass;
        private System.Windows.Forms.Button btnSaveDefinition;
        private System.Windows.Forms.Button btnDeleteDefinition;
        private System.Windows.Forms.CheckBox chkEditDefinition;
        private System.Windows.Forms.GroupBox gbDefinitionInfo;
        private System.Windows.Forms.ComboBox cbDocumentDefinitionsPerClass;
        private System.Windows.Forms.Label lblDefinition;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.BindingSource bsDocumentDefinitionsPerClass;
        private ITDataSetTableAdapters.GetDocumentDefinitionsForClassTableAdapter taDocumentDefinitionsPerClass;
        private System.Windows.Forms.Label lblDataType;
        private System.Windows.Forms.ComboBox cbDocumentDataType;
        private System.Windows.Forms.BindingSource bsDocumentDataTypes;
        private ITDataSetTableAdapters.GetDocumentDataTypesTableAdapter taDocumentDataTypes;
        private System.Windows.Forms.Label lblIsRequired;
        private System.Windows.Forms.Label lblActive3;
        private System.Windows.Forms.TextBox txtDefinitionNameRU;
        private System.Windows.Forms.Label lblNameRU1;
        private System.Windows.Forms.TextBox txtDefinitionDescriptionRU;
        private System.Windows.Forms.Label lblDescriptionRU1;
        private System.Windows.Forms.TextBox txtDefinitionDescriptionPL;
        private System.Windows.Forms.TextBox txtDefinitionNamePL;
        private System.Windows.Forms.Label lblNamePL1;
        private System.Windows.Forms.Label lblDescriptionPL1;
        private System.Windows.Forms.TextBox txtDefinitionDefault;
        private System.Windows.Forms.Label lblDefinitionDefault;
        private System.Windows.Forms.Label lblDefinitionList;
        private System.Windows.Forms.TextBox txtDefinitionList;
        private System.Windows.Forms.Button btnAddDefinition;
        private System.Windows.Forms.DateTimePicker dtpDefinitionDefault;
        private DocumentsManagerRU.View.Controls.ExtendedRadioControl ercClassActive;
        private DocumentsManagerRU.View.Controls.ExtendedRadioControl ercRequired;
        private DocumentsManagerRU.View.Controls.ExtendedRadioControl ercDefinitionActive;
        private DocumentsManagerRU.Controls.ContainsComboBox cbDefinitionDefault;
        private System.Windows.Forms.ComboBox cbExistingDefinitions;
        private System.Windows.Forms.Label lblExistingDefinitions;
        private System.Windows.Forms.TabControl tcDefinition;
        private System.Windows.Forms.TabPage pcDefinition;
        private System.Windows.Forms.TabPage pcSimpleList;
        private System.Windows.Forms.TabPage pcAdvancedList;
        private System.Windows.Forms.BindingSource bsDocumentDefinitionsByDirective;
        private ITDataSetTableAdapters.GetDocumentDefinitionsByDirectiveTableAdapter taDocumentDefinitionsByDirective;
        private System.Windows.Forms.Label lblDefinitionListAdv;
        private System.Windows.Forms.DataGridView dgvListItems;
        private System.Windows.Forms.BindingSource bsDocumentDefinitionListItems;
        private ITDataSetTableAdapters.GetDocumentDefinitionListItemsTableAdapter taDocumentDefinitionListItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn definitionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnName;
        private System.Windows.Forms.Label lblClassCount;
        private System.Windows.Forms.Label lblDefinitionPerClassCount;
        private System.Windows.Forms.Label lblDefinitionCount;
        private System.Windows.Forms.Label lblDefaultListCount;
        private System.Windows.Forms.CheckBox chkUseDateDefault;
    }
}