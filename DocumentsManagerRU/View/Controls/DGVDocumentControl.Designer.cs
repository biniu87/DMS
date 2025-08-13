namespace DocumentsManagerRU
{
    partial class DGVDocumentControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDocuments = new System.Windows.Forms.DataGridView();
            this.bsDocuments = new System.Windows.Forms.BindingSource(this.components);
            this.flpUpperNavigator = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblStatusNavigator = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.cbPager = new System.Windows.Forms.ComboBox();
            this.iTDataSet = new DocumentsManagerRU.ITDataSet();
            this.flpLowerNavigator = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFirst1 = new System.Windows.Forms.Button();
            this.btnPrev1 = new System.Windows.Forms.Button();
            this.lblStatusNavigator1 = new System.Windows.Forms.Label();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.btnLast1 = new System.Windows.Forms.Button();
            this.cbPager1 = new System.Windows.Forms.ComboBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnRowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnOldFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvChkColumnActivate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvColumnEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvColumnEditFile = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvColumnDetails = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvColumnOpen = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocuments)).BeginInit();
            this.flpUpperNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTDataSet)).BeginInit();
            this.flpLowerNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDocuments
            // 
            this.dgvDocuments.AllowUserToAddRows = false;
            this.dgvDocuments.AllowUserToDeleteRows = false;
            this.dgvDocuments.AllowUserToResizeRows = false;
            this.dgvDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDocuments.AutoGenerateColumns = false;
            this.dgvDocuments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDocuments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvDocuments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocuments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDocuments.ColumnHeadersHeight = 25;
            this.dgvDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDocuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumnId,
            this.dgvColumnRowNumber,
            this.dgvColumnName,
            this.dgvColumnDescription,
            this.dgvColumnURL,
            this.dgvColumnOldFileName,
            this.dgvColumnReleaseDate,
            this.dgvChkColumnActivate,
            this.dgvColumnEdit,
            this.dgvColumnEditFile,
            this.dgvColumnDetails,
            this.dgvColumnOpen});
            this.dgvDocuments.DataSource = this.bsDocuments;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocuments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDocuments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvDocuments.Location = new System.Drawing.Point(0, 23);
            this.dgvDocuments.Margin = new System.Windows.Forms.Padding(0);
            this.dgvDocuments.MultiSelect = false;
            this.dgvDocuments.Name = "dgvDocuments";
            this.dgvDocuments.ReadOnly = true;
            this.dgvDocuments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDocuments.RowHeadersWidth = 40;
            this.dgvDocuments.RowTemplate.Height = 25;
            this.dgvDocuments.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocuments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocuments.Size = new System.Drawing.Size(1070, 428);
            this.dgvDocuments.TabIndex = 0;
            this.dgvDocuments.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDocuments_CellMouseClick);
            this.dgvDocuments.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDocuments_CellMouseDoubleClick);
            this.dgvDocuments.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDocuments_DataError);
            // 
            // flpUpperNavigator
            // 
            this.flpUpperNavigator.Controls.Add(this.btnFirst);
            this.flpUpperNavigator.Controls.Add(this.btnPrev);
            this.flpUpperNavigator.Controls.Add(this.lblStatusNavigator);
            this.flpUpperNavigator.Controls.Add(this.btnNext);
            this.flpUpperNavigator.Controls.Add(this.btnLast);
            this.flpUpperNavigator.Controls.Add(this.cbPager);
            this.flpUpperNavigator.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpUpperNavigator.Location = new System.Drawing.Point(0, 0);
            this.flpUpperNavigator.Margin = new System.Windows.Forms.Padding(0);
            this.flpUpperNavigator.Name = "flpUpperNavigator";
            this.flpUpperNavigator.Size = new System.Drawing.Size(1070, 23);
            this.flpUpperNavigator.TabIndex = 3;
            // 
            // btnFirst
            // 
            this.btnFirst.Image = global::DocumentsManagerRU.Properties.Resources.media_step_backward_2x;
            this.btnFirst.Location = new System.Drawing.Point(0, 0);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(0);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(70, 23);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Image = global::DocumentsManagerRU.Properties.Resources.media_skip_backward_2x;
            this.btnPrev.Location = new System.Drawing.Point(70, 0);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(70, 23);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblStatusNavigator
            // 
            this.lblStatusNavigator.Image = global::DocumentsManagerRU.Properties.Resources.chevron_bottom;
            this.lblStatusNavigator.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStatusNavigator.Location = new System.Drawing.Point(140, 0);
            this.lblStatusNavigator.Margin = new System.Windows.Forms.Padding(0);
            this.lblStatusNavigator.Name = "lblStatusNavigator";
            this.lblStatusNavigator.Size = new System.Drawing.Size(265, 23);
            this.lblStatusNavigator.TabIndex = 2;
            this.lblStatusNavigator.Text = "lblStatusNavigator";
            this.lblStatusNavigator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatusNavigator.Click += new System.EventHandler(this.lblStatusNavigator_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = global::DocumentsManagerRU.Properties.Resources.media_skip_forward_2x;
            this.btnNext.Location = new System.Drawing.Point(405, 0);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(70, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Image = global::DocumentsManagerRU.Properties.Resources.media_step_forward_2x;
            this.btnLast.Location = new System.Drawing.Point(475, 0);
            this.btnLast.Margin = new System.Windows.Forms.Padding(0);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(70, 23);
            this.btnLast.TabIndex = 4;
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // cbPager
            // 
            this.cbPager.Enabled = false;
            this.cbPager.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPager.FormattingEnabled = true;
            this.cbPager.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "100",
            "1000"});
            this.cbPager.Location = new System.Drawing.Point(546, 1);
            this.cbPager.Margin = new System.Windows.Forms.Padding(1);
            this.cbPager.Name = "cbPager";
            this.cbPager.Size = new System.Drawing.Size(70, 21);
            this.cbPager.TabIndex = 5;
            this.cbPager.Text = "30";
            this.cbPager.SelectedIndexChanged += new System.EventHandler(this.cbPager_SelectedIndexChanged);
            // 
            // iTDataSet
            // 
            this.iTDataSet.DataSetName = "ITDataSet";
            this.iTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flpLowerNavigator
            // 
            this.flpLowerNavigator.Controls.Add(this.btnFirst1);
            this.flpLowerNavigator.Controls.Add(this.btnPrev1);
            this.flpLowerNavigator.Controls.Add(this.lblStatusNavigator1);
            this.flpLowerNavigator.Controls.Add(this.btnNext1);
            this.flpLowerNavigator.Controls.Add(this.btnLast1);
            this.flpLowerNavigator.Controls.Add(this.cbPager1);
            this.flpLowerNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpLowerNavigator.Location = new System.Drawing.Point(0, 451);
            this.flpLowerNavigator.Margin = new System.Windows.Forms.Padding(0);
            this.flpLowerNavigator.Name = "flpLowerNavigator";
            this.flpLowerNavigator.Size = new System.Drawing.Size(1070, 23);
            this.flpLowerNavigator.TabIndex = 4;
            // 
            // btnFirst1
            // 
            this.btnFirst1.Image = global::DocumentsManagerRU.Properties.Resources.media_step_backward_2x;
            this.btnFirst1.Location = new System.Drawing.Point(0, 0);
            this.btnFirst1.Margin = new System.Windows.Forms.Padding(0);
            this.btnFirst1.Name = "btnFirst1";
            this.btnFirst1.Size = new System.Drawing.Size(70, 23);
            this.btnFirst1.TabIndex = 0;
            this.btnFirst1.UseVisualStyleBackColor = true;
            this.btnFirst1.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev1
            // 
            this.btnPrev1.Image = global::DocumentsManagerRU.Properties.Resources.media_skip_backward_2x;
            this.btnPrev1.Location = new System.Drawing.Point(70, 0);
            this.btnPrev1.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrev1.Name = "btnPrev1";
            this.btnPrev1.Size = new System.Drawing.Size(70, 23);
            this.btnPrev1.TabIndex = 1;
            this.btnPrev1.UseVisualStyleBackColor = true;
            this.btnPrev1.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblStatusNavigator1
            // 
            this.lblStatusNavigator1.Location = new System.Drawing.Point(140, 0);
            this.lblStatusNavigator1.Margin = new System.Windows.Forms.Padding(0);
            this.lblStatusNavigator1.Name = "lblStatusNavigator1";
            this.lblStatusNavigator1.Size = new System.Drawing.Size(265, 23);
            this.lblStatusNavigator1.TabIndex = 2;
            this.lblStatusNavigator1.Text = "lblStatusNavigator1";
            this.lblStatusNavigator1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext1
            // 
            this.btnNext1.Image = global::DocumentsManagerRU.Properties.Resources.media_skip_forward_2x;
            this.btnNext1.Location = new System.Drawing.Point(405, 0);
            this.btnNext1.Margin = new System.Windows.Forms.Padding(0);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(70, 23);
            this.btnNext1.TabIndex = 3;
            this.btnNext1.UseVisualStyleBackColor = true;
            this.btnNext1.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast1
            // 
            this.btnLast1.Image = global::DocumentsManagerRU.Properties.Resources.media_step_forward_2x;
            this.btnLast1.Location = new System.Drawing.Point(475, 0);
            this.btnLast1.Margin = new System.Windows.Forms.Padding(0);
            this.btnLast1.Name = "btnLast1";
            this.btnLast1.Size = new System.Drawing.Size(70, 23);
            this.btnLast1.TabIndex = 4;
            this.btnLast1.UseVisualStyleBackColor = true;
            this.btnLast1.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // cbPager1
            // 
            this.cbPager1.Enabled = false;
            this.cbPager1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPager1.FormattingEnabled = true;
            this.cbPager1.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "100",
            "1000"});
            this.cbPager1.Location = new System.Drawing.Point(546, 1);
            this.cbPager1.Margin = new System.Windows.Forms.Padding(1);
            this.cbPager1.Name = "cbPager1";
            this.cbPager1.Size = new System.Drawing.Size(70, 21);
            this.cbPager1.TabIndex = 5;
            this.cbPager1.Text = "30";
            this.cbPager1.SelectedIndexChanged += new System.EventHandler(this.cbPager1_SelectedIndexChanged);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::DocumentsManagerRU.Properties.Resources.magnifying_glass_2x;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::DocumentsManagerRU.Properties.Resources.eye_2x;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.Width = 30;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::DocumentsManagerRU.Properties.Resources.eye_2x;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn3.Width = 30;
            // 
            // dgvColumnId
            // 
            this.dgvColumnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnId.DataPropertyName = "Id";
            this.dgvColumnId.HeaderText = "dgvColumnId";
            this.dgvColumnId.Name = "dgvColumnId";
            this.dgvColumnId.ReadOnly = true;
            this.dgvColumnId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvColumnId.Visible = false;
            // 
            // dgvColumnRowNumber
            // 
            this.dgvColumnRowNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvColumnRowNumber.DataPropertyName = "lp";
            this.dgvColumnRowNumber.HeaderText = "LP";
            this.dgvColumnRowNumber.Name = "dgvColumnRowNumber";
            this.dgvColumnRowNumber.ReadOnly = true;
            this.dgvColumnRowNumber.Width = 43;
            // 
            // dgvColumnName
            // 
            this.dgvColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvColumnName.DataPropertyName = "Name";
            this.dgvColumnName.HeaderText = "dgvColumnName";
            this.dgvColumnName.MinimumWidth = 100;
            this.dgvColumnName.Name = "dgvColumnName";
            this.dgvColumnName.ReadOnly = true;
            this.dgvColumnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvColumnName.Visible = false;
            // 
            // dgvColumnDescription
            // 
            this.dgvColumnDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvColumnDescription.DataPropertyName = "Description";
            this.dgvColumnDescription.HeaderText = "dgvColumnDescription";
            this.dgvColumnDescription.Name = "dgvColumnDescription";
            this.dgvColumnDescription.ReadOnly = true;
            this.dgvColumnDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvColumnDescription.Visible = false;
            // 
            // dgvColumnURL
            // 
            this.dgvColumnURL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnURL.DataPropertyName = "URL";
            this.dgvColumnURL.HeaderText = "URL";
            this.dgvColumnURL.Name = "dgvColumnURL";
            this.dgvColumnURL.ReadOnly = true;
            this.dgvColumnURL.Visible = false;
            this.dgvColumnURL.Width = 300;
            // 
            // dgvColumnOldFileName
            // 
            this.dgvColumnOldFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnOldFileName.DataPropertyName = "OldFileName";
            this.dgvColumnOldFileName.HeaderText = "dgvColumnOldFileName";
            this.dgvColumnOldFileName.Name = "dgvColumnOldFileName";
            this.dgvColumnOldFileName.ReadOnly = true;
            this.dgvColumnOldFileName.Visible = false;
            // 
            // dgvColumnReleaseDate
            // 
            this.dgvColumnReleaseDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnReleaseDate.DataPropertyName = "Release_Date";
            this.dgvColumnReleaseDate.HeaderText = "dgvColumnReleaseDate";
            this.dgvColumnReleaseDate.Name = "dgvColumnReleaseDate";
            this.dgvColumnReleaseDate.ReadOnly = true;
            // 
            // dgvChkColumnActivate
            // 
            this.dgvChkColumnActivate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvChkColumnActivate.DataPropertyName = "Active";
            this.dgvChkColumnActivate.HeaderText = "A";
            this.dgvChkColumnActivate.Name = "dgvChkColumnActivate";
            this.dgvChkColumnActivate.ReadOnly = true;
            this.dgvChkColumnActivate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChkColumnActivate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvChkColumnActivate.Width = 30;
            // 
            // dgvColumnEdit
            // 
            this.dgvColumnEdit.HeaderText = "";
            this.dgvColumnEdit.Image = global::DocumentsManagerRU.Properties.Resources.pencil_2x;
            this.dgvColumnEdit.Name = "dgvColumnEdit";
            this.dgvColumnEdit.ReadOnly = true;
            this.dgvColumnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvColumnEdit.Width = 30;
            // 
            // dgvColumnEditFile
            // 
            this.dgvColumnEditFile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnEditFile.HeaderText = "";
            this.dgvColumnEditFile.Image = global::DocumentsManagerRU.Properties.Resources.paperclip_2x;
            this.dgvColumnEditFile.Name = "dgvColumnEditFile";
            this.dgvColumnEditFile.ReadOnly = true;
            this.dgvColumnEditFile.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvColumnEditFile.Width = 30;
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
            this.dgvColumnOpen.Visible = false;
            this.dgvColumnOpen.Width = 30;
            // 
            // DGVDocumentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.flpLowerNavigator);
            this.Controls.Add(this.flpUpperNavigator);
            this.Controls.Add(this.dgvDocuments);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DGVDocumentControl";
            this.Size = new System.Drawing.Size(1070, 474);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocuments)).EndInit();
            this.flpUpperNavigator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iTDataSet)).EndInit();
            this.flpLowerNavigator.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDocuments;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.FlowLayoutPanel flpUpperNavigator;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private ITDataSet iTDataSet;
        private System.Windows.Forms.BindingSource bsDocuments;
        private System.Windows.Forms.ComboBox cbPager;
        private System.Windows.Forms.Label lblStatusNavigator;
        private System.Windows.Forms.FlowLayoutPanel flpLowerNavigator;
        private System.Windows.Forms.Button btnFirst1;
        private System.Windows.Forms.Button btnPrev1;
        private System.Windows.Forms.Label lblStatusNavigator1;
        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.Button btnLast1;
        private System.Windows.Forms.ComboBox cbPager1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnRowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnOldFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnReleaseDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChkColumnActivate;
        private System.Windows.Forms.DataGridViewImageColumn dgvColumnEdit;
        private System.Windows.Forms.DataGridViewImageColumn dgvColumnEditFile;
        private System.Windows.Forms.DataGridViewImageColumn dgvColumnDetails;
        private System.Windows.Forms.DataGridViewImageColumn dgvColumnOpen;
    }
}
