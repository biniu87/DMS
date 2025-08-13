namespace DocumentsManagerRU
{
    partial class frmDetails
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
            this.lblNamePL1 = new System.Windows.Forms.Label();
            this.lblDescriptionPL1 = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblDescription2 = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.Label();
            this.gbClassInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDescriptionRU = new System.Windows.Forms.TextBox();
            this.txtNameRU = new System.Windows.Forms.TextBox();
            this.lblDescriptionRU = new System.Windows.Forms.Label();
            this.lblNameRU = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gbDocumentInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.lblOriginalName = new System.Windows.Forms.Label();
            this.txtOriginalName = new System.Windows.Forms.TextBox();
            this.lblRelasedBy = new System.Windows.Forms.Label();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.txtRelasedBy = new System.Windows.Forms.TextBox();
            this.txtDescription2 = new System.Windows.Forms.TextBox();
            this.txtReleaseDate = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.txtFileSize = new System.Windows.Forms.TextBox();
            this.btnOpenURL = new System.Windows.Forms.Button();
            this.btnCloseNoTitle = new System.Windows.Forms.Button();
            this.pnlDocumentIndex = new System.Windows.Forms.Panel();
            this.tcDetails = new System.Windows.Forms.TabControl();
            this.tpSimpleDetails = new System.Windows.Forms.TabPage();
            this.tpAssignedDetails = new System.Windows.Forms.TabPage();
            this.gbSecondaryObjects = new System.Windows.Forms.GroupBox();
            this.dgvSecondaryDocuments = new System.Windows.Forms.DataGridView();
            this.dgvColumnClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnDocumentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnDetails = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvColumnOpen = new System.Windows.Forms.DataGridViewImageColumn();
            this.bsGetSecondaryDocuments = new System.Windows.Forms.BindingSource(this.components);
            this.iTDataSet = new DocumentsManagerRU.ITDataSet();
            this.gbPrimaryObject = new System.Windows.Forms.GroupBox();
            this.btnShowDocument = new System.Windows.Forms.Button();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.lblDocument = new System.Windows.Forms.Label();
            this.txtDocument = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.taGetSecondaryDocuments = new DocumentsManagerRU.ITDataSetTableAdapters.GetSecondaryDocumentsTableAdapter();
            this.gbClassInfo.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbDocumentInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tcDetails.SuspendLayout();
            this.tpSimpleDetails.SuspendLayout();
            this.tpAssignedDetails.SuspendLayout();
            this.gbSecondaryObjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecondaryDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGetSecondaryDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTDataSet)).BeginInit();
            this.gbPrimaryObject.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNamePL1
            // 
            this.lblNamePL1.AutoSize = true;
            this.lblNamePL1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNamePL1.Location = new System.Drawing.Point(3, 0);
            this.lblNamePL1.Name = "lblNamePL1";
            this.lblNamePL1.Size = new System.Drawing.Size(154, 25);
            this.lblNamePL1.TabIndex = 5;
            this.lblNamePL1.Text = "lblNamePL1";
            this.lblNamePL1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescriptionPL1
            // 
            this.lblDescriptionPL1.AutoSize = true;
            this.lblDescriptionPL1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescriptionPL1.Location = new System.Drawing.Point(3, 25);
            this.lblDescriptionPL1.Name = "lblDescriptionPL1";
            this.lblDescriptionPL1.Size = new System.Drawing.Size(154, 27);
            this.lblDescriptionPL1.TabIndex = 7;
            this.lblDescriptionPL1.Text = "lblDescriptionPL1";
            this.lblDescriptionPL1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName2.Location = new System.Drawing.Point(3, 0);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(154, 25);
            this.lblName2.TabIndex = 0;
            this.lblName2.Text = "lblDocName2";
            this.lblName2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescription2
            // 
            this.lblDescription2.AutoSize = true;
            this.lblDescription2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription2.Location = new System.Drawing.Point(3, 25);
            this.lblDescription2.Name = "lblDescription2";
            this.lblDescription2.Size = new System.Drawing.Size(154, 25);
            this.lblDescription2.TabIndex = 2;
            this.lblDescription2.Text = "lblDescription2";
            this.lblDescription2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblURL.Location = new System.Drawing.Point(3, 50);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(154, 25);
            this.lblURL.TabIndex = 4;
            this.lblURL.Text = "lblURL";
            this.lblURL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbClassInfo
            // 
            this.gbClassInfo.Controls.Add(this.tableLayoutPanel2);
            this.gbClassInfo.Location = new System.Drawing.Point(3, 3);
            this.gbClassInfo.Name = "gbClassInfo";
            this.gbClassInfo.Size = new System.Drawing.Size(651, 81);
            this.gbClassInfo.TabIndex = 0;
            this.gbClassInfo.TabStop = false;
            this.gbClassInfo.Text = "gbClassInfo";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.txtDescriptionRU, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtNameRU, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDescriptionRU, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblNameRU, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDescriptionPL1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtDescription, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtName, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblNamePL1, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(639, 52);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtDescriptionRU
            // 
            this.txtDescriptionRU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescriptionRU.Location = new System.Drawing.Point(163, 3);
            this.txtDescriptionRU.Name = "txtDescriptionRU";
            this.txtDescriptionRU.ReadOnly = true;
            this.txtDescriptionRU.Size = new System.Drawing.Size(473, 21);
            this.txtDescriptionRU.TabIndex = 4;
            this.txtDescriptionRU.Visible = false;
            // 
            // txtNameRU
            // 
            this.txtNameRU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNameRU.Location = new System.Drawing.Point(163, 3);
            this.txtNameRU.Name = "txtNameRU";
            this.txtNameRU.ReadOnly = true;
            this.txtNameRU.Size = new System.Drawing.Size(473, 21);
            this.txtNameRU.TabIndex = 2;
            this.txtNameRU.Visible = false;
            // 
            // lblDescriptionRU
            // 
            this.lblDescriptionRU.AutoSize = true;
            this.lblDescriptionRU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescriptionRU.Location = new System.Drawing.Point(3, 0);
            this.lblDescriptionRU.Name = "lblDescriptionRU";
            this.lblDescriptionRU.Size = new System.Drawing.Size(154, 1);
            this.lblDescriptionRU.TabIndex = 3;
            this.lblDescriptionRU.Text = "lblDescriptionRU";
            this.lblDescriptionRU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNameRU
            // 
            this.lblNameRU.AutoSize = true;
            this.lblNameRU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNameRU.Location = new System.Drawing.Point(3, 0);
            this.lblNameRU.Name = "lblNameRU";
            this.lblNameRU.Size = new System.Drawing.Size(154, 1);
            this.lblNameRU.TabIndex = 1;
            this.lblNameRU.Text = "lblNameRU";
            this.lblNameRU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(163, 28);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(473, 21);
            this.txtDescription.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(163, 3);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(473, 21);
            this.txtName.TabIndex = 6;
            // 
            // gbDocumentInfo
            // 
            this.gbDocumentInfo.Controls.Add(this.tableLayoutPanel1);
            this.gbDocumentInfo.Controls.Add(this.btnOpenURL);
            this.gbDocumentInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbDocumentInfo.Location = new System.Drawing.Point(4, 90);
            this.gbDocumentInfo.Name = "gbDocumentInfo";
            this.gbDocumentInfo.Size = new System.Drawing.Size(651, 177);
            this.gbDocumentInfo.TabIndex = 1;
            this.gbDocumentInfo.TabStop = false;
            this.gbDocumentInfo.Text = "gbDocumentInfo";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblReleaseDate, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblOriginalName, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtOriginalName, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblRelasedBy, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtName2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtRelasedBy, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblURL, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtReleaseDate, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDescription2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblName2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtURL, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFileSize, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtFileSize, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(604, 153);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReleaseDate.Location = new System.Drawing.Point(3, 100);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(154, 25);
            this.lblReleaseDate.TabIndex = 6;
            this.lblReleaseDate.Text = "lblReleaseDate";
            this.lblReleaseDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOriginalName
            // 
            this.lblOriginalName.AutoSize = true;
            this.lblOriginalName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOriginalName.Location = new System.Drawing.Point(3, 150);
            this.lblOriginalName.Name = "lblOriginalName";
            this.lblOriginalName.Size = new System.Drawing.Size(154, 25);
            this.lblOriginalName.TabIndex = 10;
            this.lblOriginalName.Text = "lblOriginalName";
            this.lblOriginalName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOriginalName
            // 
            this.txtOriginalName.Location = new System.Drawing.Point(163, 153);
            this.txtOriginalName.Name = "txtOriginalName";
            this.txtOriginalName.ReadOnly = true;
            this.txtOriginalName.Size = new System.Drawing.Size(438, 21);
            this.txtOriginalName.TabIndex = 11;
            // 
            // lblRelasedBy
            // 
            this.lblRelasedBy.AutoSize = true;
            this.lblRelasedBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRelasedBy.Location = new System.Drawing.Point(3, 125);
            this.lblRelasedBy.Name = "lblRelasedBy";
            this.lblRelasedBy.Size = new System.Drawing.Size(154, 25);
            this.lblRelasedBy.TabIndex = 8;
            this.lblRelasedBy.Text = "lblRelasedBy";
            this.lblRelasedBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName2
            // 
            this.txtName2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName2.Location = new System.Drawing.Point(163, 3);
            this.txtName2.Name = "txtName2";
            this.txtName2.ReadOnly = true;
            this.txtName2.Size = new System.Drawing.Size(438, 21);
            this.txtName2.TabIndex = 1;
            // 
            // txtRelasedBy
            // 
            this.txtRelasedBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRelasedBy.Location = new System.Drawing.Point(163, 128);
            this.txtRelasedBy.Name = "txtRelasedBy";
            this.txtRelasedBy.ReadOnly = true;
            this.txtRelasedBy.Size = new System.Drawing.Size(438, 21);
            this.txtRelasedBy.TabIndex = 9;
            // 
            // txtDescription2
            // 
            this.txtDescription2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription2.Location = new System.Drawing.Point(163, 28);
            this.txtDescription2.Name = "txtDescription2";
            this.txtDescription2.ReadOnly = true;
            this.txtDescription2.Size = new System.Drawing.Size(438, 21);
            this.txtDescription2.TabIndex = 3;
            // 
            // txtReleaseDate
            // 
            this.txtReleaseDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReleaseDate.Location = new System.Drawing.Point(163, 103);
            this.txtReleaseDate.Name = "txtReleaseDate";
            this.txtReleaseDate.ReadOnly = true;
            this.txtReleaseDate.Size = new System.Drawing.Size(438, 21);
            this.txtReleaseDate.TabIndex = 7;
            // 
            // txtURL
            // 
            this.txtURL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtURL.Location = new System.Drawing.Point(163, 53);
            this.txtURL.Name = "txtURL";
            this.txtURL.ReadOnly = true;
            this.txtURL.Size = new System.Drawing.Size(438, 21);
            this.txtURL.TabIndex = 5;
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFileSize.Location = new System.Drawing.Point(3, 75);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(154, 25);
            this.lblFileSize.TabIndex = 4;
            this.lblFileSize.Text = "lblFileSize";
            this.lblFileSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFileSize
            // 
            this.txtFileSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFileSize.Location = new System.Drawing.Point(163, 78);
            this.txtFileSize.Name = "txtFileSize";
            this.txtFileSize.ReadOnly = true;
            this.txtFileSize.Size = new System.Drawing.Size(438, 21);
            this.txtFileSize.TabIndex = 5;
            // 
            // btnOpenURL
            // 
            this.btnOpenURL.Image = global::DocumentsManagerRU.Properties.Resources.eye_2x;
            this.btnOpenURL.Location = new System.Drawing.Point(615, 19);
            this.btnOpenURL.Name = "btnOpenURL";
            this.btnOpenURL.Size = new System.Drawing.Size(30, 153);
            this.btnOpenURL.TabIndex = 1;
            this.btnOpenURL.UseVisualStyleBackColor = true;
            this.btnOpenURL.Click += new System.EventHandler(this.btnOpenURL_Click);
            // 
            // btnCloseNoTitle
            // 
            this.btnCloseNoTitle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseNoTitle.Image = global::DocumentsManagerRU.Properties.Resources.circle_x_2x;
            this.btnCloseNoTitle.Location = new System.Drawing.Point(528, 627);
            this.btnCloseNoTitle.Name = "btnCloseNoTitle";
            this.btnCloseNoTitle.Size = new System.Drawing.Size(133, 27);
            this.btnCloseNoTitle.TabIndex = 2;
            this.btnCloseNoTitle.UseVisualStyleBackColor = true;
            this.btnCloseNoTitle.Click += new System.EventHandler(this.CloseForm);
            // 
            // pnlDocumentIndex
            // 
            this.pnlDocumentIndex.Location = new System.Drawing.Point(12, 321);
            this.pnlDocumentIndex.Name = "pnlDocumentIndex";
            this.pnlDocumentIndex.Size = new System.Drawing.Size(665, 300);
            this.pnlDocumentIndex.TabIndex = 1;
            // 
            // tcDetails
            // 
            this.tcDetails.Controls.Add(this.tpSimpleDetails);
            this.tcDetails.Controls.Add(this.tpAssignedDetails);
            this.tcDetails.Location = new System.Drawing.Point(12, 12);
            this.tcDetails.Name = "tcDetails";
            this.tcDetails.SelectedIndex = 0;
            this.tcDetails.Size = new System.Drawing.Size(669, 303);
            this.tcDetails.TabIndex = 0;
            // 
            // tpSimpleDetails
            // 
            this.tpSimpleDetails.Controls.Add(this.gbClassInfo);
            this.tpSimpleDetails.Controls.Add(this.gbDocumentInfo);
            this.tpSimpleDetails.Location = new System.Drawing.Point(4, 22);
            this.tpSimpleDetails.Name = "tpSimpleDetails";
            this.tpSimpleDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpSimpleDetails.Size = new System.Drawing.Size(661, 277);
            this.tpSimpleDetails.TabIndex = 0;
            this.tpSimpleDetails.Text = "tpSimpleDetails";
            this.tpSimpleDetails.UseVisualStyleBackColor = true;
            // 
            // tpAssignedDetails
            // 
            this.tpAssignedDetails.Controls.Add(this.gbSecondaryObjects);
            this.tpAssignedDetails.Controls.Add(this.gbPrimaryObject);
            this.tpAssignedDetails.Location = new System.Drawing.Point(4, 22);
            this.tpAssignedDetails.Name = "tpAssignedDetails";
            this.tpAssignedDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpAssignedDetails.Size = new System.Drawing.Size(661, 277);
            this.tpAssignedDetails.TabIndex = 1;
            this.tpAssignedDetails.Text = "tpAssignedDetails";
            this.tpAssignedDetails.UseVisualStyleBackColor = true;
            // 
            // gbSecondaryObjects
            // 
            this.gbSecondaryObjects.Controls.Add(this.dgvSecondaryDocuments);
            this.gbSecondaryObjects.Location = new System.Drawing.Point(3, 86);
            this.gbSecondaryObjects.Name = "gbSecondaryObjects";
            this.gbSecondaryObjects.Size = new System.Drawing.Size(652, 232);
            this.gbSecondaryObjects.TabIndex = 1;
            this.gbSecondaryObjects.TabStop = false;
            this.gbSecondaryObjects.Text = "gbSecondaryObjects";
            // 
            // dgvSecondaryDocuments
            // 
            this.dgvSecondaryDocuments.AllowUserToAddRows = false;
            this.dgvSecondaryDocuments.AllowUserToDeleteRows = false;
            this.dgvSecondaryDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSecondaryDocuments.AutoGenerateColumns = false;
            this.dgvSecondaryDocuments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSecondaryDocuments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvSecondaryDocuments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSecondaryDocuments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSecondaryDocuments.ColumnHeadersHeight = 25;
            this.dgvSecondaryDocuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumnClassName,
            this.dgvColumnDocumentId,
            this.dgvColumnClassId,
            this.dgvColumnName,
            this.dgvColumnDetails,
            this.dgvColumnOpen});
            this.dgvSecondaryDocuments.DataSource = this.bsGetSecondaryDocuments;
            this.dgvSecondaryDocuments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvSecondaryDocuments.Location = new System.Drawing.Point(6, 20);
            this.dgvSecondaryDocuments.Name = "dgvSecondaryDocuments";
            this.dgvSecondaryDocuments.ReadOnly = true;
            this.dgvSecondaryDocuments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSecondaryDocuments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSecondaryDocuments.Size = new System.Drawing.Size(640, 165);
            this.dgvSecondaryDocuments.TabIndex = 0;
            this.dgvSecondaryDocuments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSecondaryDocuments_CellDoubleClick);
            this.dgvSecondaryDocuments.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSecondaryDocuments_CellMouseClick);
            // 
            // dgvColumnClassName
            // 
            this.dgvColumnClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnClassName.DataPropertyName = "ClassName";
            this.dgvColumnClassName.HeaderText = "dgvColumnClassName";
            this.dgvColumnClassName.Name = "dgvColumnClassName";
            this.dgvColumnClassName.ReadOnly = true;
            this.dgvColumnClassName.Width = 300;
            // 
            // dgvColumnDocumentId
            // 
            this.dgvColumnDocumentId.DataPropertyName = "Id";
            this.dgvColumnDocumentId.HeaderText = "dgvColumnDocumentId";
            this.dgvColumnDocumentId.Name = "dgvColumnDocumentId";
            this.dgvColumnDocumentId.ReadOnly = true;
            this.dgvColumnDocumentId.Visible = false;
            // 
            // dgvColumnClassId
            // 
            this.dgvColumnClassId.DataPropertyName = "ClassId";
            this.dgvColumnClassId.HeaderText = "dgvColumnClassId";
            this.dgvColumnClassId.Name = "dgvColumnClassId";
            this.dgvColumnClassId.ReadOnly = true;
            this.dgvColumnClassId.Visible = false;
            // 
            // dgvColumnName
            // 
            this.dgvColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvColumnName.DataPropertyName = "Name";
            this.dgvColumnName.HeaderText = "dgvColumnName";
            this.dgvColumnName.Name = "dgvColumnName";
            this.dgvColumnName.ReadOnly = true;
            // 
            // dgvColumnDetails
            // 
            this.dgvColumnDetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnDetails.HeaderText = "";
            this.dgvColumnDetails.Image = global::DocumentsManagerRU.Properties.Resources.magnifying_glass_2x;
            this.dgvColumnDetails.Name = "dgvColumnDetails";
            this.dgvColumnDetails.ReadOnly = true;
            this.dgvColumnDetails.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvColumnDetails.Width = 30;
            // 
            // dgvColumnOpen
            // 
            this.dgvColumnOpen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnOpen.HeaderText = "";
            this.dgvColumnOpen.Image = global::DocumentsManagerRU.Properties.Resources.eye_2x;
            this.dgvColumnOpen.Name = "dgvColumnOpen";
            this.dgvColumnOpen.ReadOnly = true;
            this.dgvColumnOpen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvColumnOpen.Width = 30;
            // 
            // bsGetSecondaryDocuments
            // 
            this.bsGetSecondaryDocuments.DataMember = "GetSecondaryDocuments";
            this.bsGetSecondaryDocuments.DataSource = this.iTDataSet;
            // 
            // iTDataSet
            // 
            this.iTDataSet.DataSetName = "ITDataSet";
            this.iTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbPrimaryObject
            // 
            this.gbPrimaryObject.Controls.Add(this.btnShowDocument);
            this.gbPrimaryObject.Controls.Add(this.btnShowDetails);
            this.gbPrimaryObject.Controls.Add(this.lblDocument);
            this.gbPrimaryObject.Controls.Add(this.txtDocument);
            this.gbPrimaryObject.Controls.Add(this.txtClass);
            this.gbPrimaryObject.Controls.Add(this.lblClass);
            this.gbPrimaryObject.Location = new System.Drawing.Point(3, 3);
            this.gbPrimaryObject.Name = "gbPrimaryObject";
            this.gbPrimaryObject.Size = new System.Drawing.Size(652, 77);
            this.gbPrimaryObject.TabIndex = 0;
            this.gbPrimaryObject.TabStop = false;
            this.gbPrimaryObject.Text = "gbPrimaryObject";
            // 
            // btnShowDocument
            // 
            this.btnShowDocument.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnShowDocument.Image = global::DocumentsManagerRU.Properties.Resources.eye_2x;
            this.btnShowDocument.Location = new System.Drawing.Point(619, 17);
            this.btnShowDocument.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnShowDocument.Name = "btnShowDocument";
            this.btnShowDocument.Size = new System.Drawing.Size(27, 48);
            this.btnShowDocument.TabIndex = 5;
            this.btnShowDocument.UseVisualStyleBackColor = true;
            this.btnShowDocument.Click += new System.EventHandler(this.btnShowDocument_Click);
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnShowDetails.Image = global::DocumentsManagerRU.Properties.Resources.magnifying_glass_2x;
            this.btnShowDetails.Location = new System.Drawing.Point(592, 17);
            this.btnShowDetails.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(27, 48);
            this.btnShowDetails.TabIndex = 4;
            this.btnShowDetails.UseVisualStyleBackColor = true;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // lblDocument
            // 
            this.lblDocument.Location = new System.Drawing.Point(3, 44);
            this.lblDocument.Name = "lblDocument";
            this.lblDocument.Size = new System.Drawing.Size(154, 21);
            this.lblDocument.TabIndex = 2;
            this.lblDocument.Text = "lblDocument";
            this.lblDocument.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDocument
            // 
            this.txtDocument.Location = new System.Drawing.Point(163, 44);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.ReadOnly = true;
            this.txtDocument.Size = new System.Drawing.Size(423, 21);
            this.txtDocument.TabIndex = 3;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(163, 17);
            this.txtClass.Name = "txtClass";
            this.txtClass.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(423, 21);
            this.txtClass.TabIndex = 1;
            // 
            // lblClass
            // 
            this.lblClass.Location = new System.Drawing.Point(3, 17);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(154, 21);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "lblClass";
            this.lblClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taGetSecondaryDocuments
            // 
            this.taGetSecondaryDocuments.ClearBeforeFill = true;
            // 
            // frmDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCloseNoTitle;
            this.ClientSize = new System.Drawing.Size(687, 659);
            this.Controls.Add(this.tcDetails);
            this.Controls.Add(this.pnlDocumentIndex);
            this.Controls.Add(this.btnCloseNoTitle);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmDetails_Load);
            this.gbClassInfo.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.gbDocumentInfo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tcDetails.ResumeLayout(false);
            this.tpSimpleDetails.ResumeLayout(false);
            this.tpAssignedDetails.ResumeLayout(false);
            this.gbSecondaryObjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecondaryDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGetSecondaryDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTDataSet)).EndInit();
            this.gbPrimaryObject.ResumeLayout(false);
            this.gbPrimaryObject.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNamePL1;
        private System.Windows.Forms.Label lblDescriptionPL1;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label lblDescription2;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.GroupBox gbClassInfo;
        private System.Windows.Forms.GroupBox gbDocumentInfo;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Label lblRelasedBy;
        private System.Windows.Forms.Label lblOriginalName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtOriginalName;
        private System.Windows.Forms.TextBox txtRelasedBy;
        private System.Windows.Forms.TextBox txtReleaseDate;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtDescription2;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCloseNoTitle;
        private System.Windows.Forms.TextBox txtDescriptionRU;
        private System.Windows.Forms.TextBox txtNameRU;
        private System.Windows.Forms.Label lblDescriptionRU;
        private System.Windows.Forms.Label lblNameRU;
        private System.Windows.Forms.Panel pnlDocumentIndex;
        private System.Windows.Forms.TabControl tcDetails;
        private System.Windows.Forms.TabPage tpSimpleDetails;
        private System.Windows.Forms.TabPage tpAssignedDetails;
        private System.Windows.Forms.GroupBox gbPrimaryObject;
        private System.Windows.Forms.GroupBox gbSecondaryObjects;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.Label lblDocument;
        private System.Windows.Forms.TextBox txtDocument;
        private System.Windows.Forms.Button btnOpenURL;
        private System.Windows.Forms.DataGridView dgvSecondaryDocuments;
        private System.Windows.Forms.BindingSource bsGetSecondaryDocuments;
        private ITDataSet iTDataSet;
        private ITDataSetTableAdapters.GetSecondaryDocumentsTableAdapter taGetSecondaryDocuments;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnDocumentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnName;
        private System.Windows.Forms.DataGridViewImageColumn dgvColumnDetails;
        private System.Windows.Forms.DataGridViewImageColumn dgvColumnOpen;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.TextBox txtFileSize;
        private System.Windows.Forms.Button btnShowDocument;
    }
}