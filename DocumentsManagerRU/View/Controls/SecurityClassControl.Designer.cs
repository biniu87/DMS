namespace DocumentsManagerRU.View.Controls
{
    partial class SecurityClassControl
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
            this.dgvPermissions = new System.Windows.Forms.DataGridView();
            this.bsDocumentPermissionsForClass = new System.Windows.Forms.BindingSource(this.components);
            this.iTDataSet = new DocumentsManagerRU.ITDataSet();
            this.flpManageColumns = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.taDocumentPermissionsForClass = new DocumentsManagerRU.ITDataSetTableAdapters.GetDocumentPermissionsForClassTableAdapter();
            this.dgvColumnLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnSecurityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnPrint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnSave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnSend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvChkColumnPrintNone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvChkColumnPrintOnlyWith = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvChkColumnPrintFull = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvChkColumnSaveNone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvChkColumnSaveOnlyWith = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvChkColumnSaveFull = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvChkColumnSendNone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvChkColumnSendOnlyWith = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvChkColumnSendFull = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentPermissionsForClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTDataSet)).BeginInit();
            this.flpManageColumns.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPermissions
            // 
            this.dgvPermissions.AllowUserToAddRows = false;
            this.dgvPermissions.AllowUserToDeleteRows = false;
            this.dgvPermissions.AllowUserToResizeColumns = false;
            this.dgvPermissions.AllowUserToResizeRows = false;
            this.dgvPermissions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPermissions.AutoGenerateColumns = false;
            this.dgvPermissions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPermissions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPermissions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPermissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPermissions.ColumnHeadersVisible = false;
            this.dgvPermissions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumnLogin,
            this.dgvColumnSecurityId,
            this.dgvColumnPrint,
            this.dgvColumnSave,
            this.dgvColumnSend,
            this.dgvChkColumnPrintNone,
            this.dgvChkColumnPrintOnlyWith,
            this.dgvChkColumnPrintFull,
            this.dgvChkColumnSaveNone,
            this.dgvChkColumnSaveOnlyWith,
            this.dgvChkColumnSaveFull,
            this.dgvChkColumnSendNone,
            this.dgvChkColumnSendOnlyWith,
            this.dgvChkColumnSendFull});
            this.dgvPermissions.DataSource = this.bsDocumentPermissionsForClass;
            this.dgvPermissions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPermissions.Location = new System.Drawing.Point(0, 54);
            this.dgvPermissions.Margin = new System.Windows.Forms.Padding(0);
            this.dgvPermissions.Name = "dgvPermissions";
            this.dgvPermissions.RowHeadersWidth = 20;
            this.dgvPermissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPermissions.Size = new System.Drawing.Size(963, 377);
            this.dgvPermissions.TabIndex = 1;
            this.dgvPermissions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermissions_CellContentClick);
            this.dgvPermissions.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvPermissions_RowsAdded);
            // 
            // bsDocumentPermissionsForClass
            // 
            this.bsDocumentPermissionsForClass.DataMember = "GetDocumentPermissionsForClass";
            this.bsDocumentPermissionsForClass.DataSource = this.iTDataSet;
            // 
            // iTDataSet
            // 
            this.iTDataSet.DataSetName = "ITDataSet";
            this.iTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flpManageColumns
            // 
            this.flpManageColumns.Controls.Add(this.lblLogin);
            this.flpManageColumns.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpManageColumns.Location = new System.Drawing.Point(0, 0);
            this.flpManageColumns.Margin = new System.Windows.Forms.Padding(0);
            this.flpManageColumns.Name = "flpManageColumns";
            this.flpManageColumns.Size = new System.Drawing.Size(963, 54);
            this.flpManageColumns.TabIndex = 0;
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogin.Location = new System.Drawing.Point(0, 0);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblLogin.Size = new System.Drawing.Size(170, 54);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "lblLogin";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // taDocumentPermissionsForClass
            // 
            this.taDocumentPermissionsForClass.ClearBeforeFill = true;
            // 
            // dgvColumnLogin
            // 
            this.dgvColumnLogin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnLogin.DataPropertyName = "Name";
            this.dgvColumnLogin.HeaderText = "dgvColumnLogin";
            this.dgvColumnLogin.MaxInputLength = 50;
            this.dgvColumnLogin.Name = "dgvColumnLogin";
            this.dgvColumnLogin.ReadOnly = true;
            this.dgvColumnLogin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvColumnLogin.Width = 150;
            // 
            // dgvColumnSecurityId
            // 
            this.dgvColumnSecurityId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnSecurityId.DataPropertyName = "SecurityId";
            this.dgvColumnSecurityId.HeaderText = "dgvColumnSecurityId";
            this.dgvColumnSecurityId.Name = "dgvColumnSecurityId";
            this.dgvColumnSecurityId.ReadOnly = true;
            this.dgvColumnSecurityId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvColumnSecurityId.Visible = false;
            // 
            // dgvColumnPrint
            // 
            this.dgvColumnPrint.DataPropertyName = "O_Print";
            this.dgvColumnPrint.HeaderText = "dgvColumnPrint";
            this.dgvColumnPrint.Name = "dgvColumnPrint";
            this.dgvColumnPrint.Visible = false;
            // 
            // dgvColumnSave
            // 
            this.dgvColumnSave.DataPropertyName = "O_Save";
            this.dgvColumnSave.HeaderText = "dgvColumnSave";
            this.dgvColumnSave.Name = "dgvColumnSave";
            this.dgvColumnSave.Visible = false;
            // 
            // dgvColumnSend
            // 
            this.dgvColumnSend.DataPropertyName = "O_Send";
            this.dgvColumnSend.HeaderText = "dgvColumnSend";
            this.dgvColumnSend.Name = "dgvColumnSend";
            this.dgvColumnSend.Visible = false;
            // 
            // dgvChkColumnPrintNone
            // 
            this.dgvChkColumnPrintNone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvChkColumnPrintNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvChkColumnPrintNone.HeaderText = "dgvChkColumnPrintNone";
            this.dgvChkColumnPrintNone.Name = "dgvChkColumnPrintNone";
            this.dgvChkColumnPrintNone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChkColumnPrintNone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvChkColumnPrintNone.Width = 50;
            // 
            // dgvChkColumnPrintOnlyWith
            // 
            this.dgvChkColumnPrintOnlyWith.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvChkColumnPrintOnlyWith.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvChkColumnPrintOnlyWith.HeaderText = "dgvChkColumnPrintOnlyWith";
            this.dgvChkColumnPrintOnlyWith.Name = "dgvChkColumnPrintOnlyWith";
            this.dgvChkColumnPrintOnlyWith.ReadOnly = true;
            this.dgvChkColumnPrintOnlyWith.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChkColumnPrintOnlyWith.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvChkColumnPrintOnlyWith.Width = 50;
            // 
            // dgvChkColumnPrintFull
            // 
            this.dgvChkColumnPrintFull.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvChkColumnPrintFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvChkColumnPrintFull.HeaderText = "dgvChkColumnPrintFull";
            this.dgvChkColumnPrintFull.Name = "dgvChkColumnPrintFull";
            this.dgvChkColumnPrintFull.ReadOnly = true;
            this.dgvChkColumnPrintFull.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChkColumnPrintFull.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvChkColumnPrintFull.Width = 50;
            // 
            // dgvChkColumnSaveNone
            // 
            this.dgvChkColumnSaveNone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvChkColumnSaveNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvChkColumnSaveNone.HeaderText = "dgvChkColumnSaveNone";
            this.dgvChkColumnSaveNone.Name = "dgvChkColumnSaveNone";
            this.dgvChkColumnSaveNone.ReadOnly = true;
            this.dgvChkColumnSaveNone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChkColumnSaveNone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvChkColumnSaveNone.Width = 50;
            // 
            // dgvChkColumnSaveOnlyWith
            // 
            this.dgvChkColumnSaveOnlyWith.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvChkColumnSaveOnlyWith.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvChkColumnSaveOnlyWith.HeaderText = "dgvChkColumnSaveOnlyWith";
            this.dgvChkColumnSaveOnlyWith.Name = "dgvChkColumnSaveOnlyWith";
            this.dgvChkColumnSaveOnlyWith.ReadOnly = true;
            this.dgvChkColumnSaveOnlyWith.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChkColumnSaveOnlyWith.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvChkColumnSaveOnlyWith.Width = 50;
            // 
            // dgvChkColumnSaveFull
            // 
            this.dgvChkColumnSaveFull.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvChkColumnSaveFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvChkColumnSaveFull.HeaderText = "dgvChkColumnSaveFull";
            this.dgvChkColumnSaveFull.Name = "dgvChkColumnSaveFull";
            this.dgvChkColumnSaveFull.ReadOnly = true;
            this.dgvChkColumnSaveFull.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChkColumnSaveFull.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvChkColumnSaveFull.Width = 50;
            // 
            // dgvChkColumnSendNone
            // 
            this.dgvChkColumnSendNone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvChkColumnSendNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvChkColumnSendNone.HeaderText = "dgvChkColumnSendNone";
            this.dgvChkColumnSendNone.Name = "dgvChkColumnSendNone";
            this.dgvChkColumnSendNone.ReadOnly = true;
            this.dgvChkColumnSendNone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChkColumnSendNone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvChkColumnSendNone.Width = 50;
            // 
            // dgvChkColumnSendOnlyWith
            // 
            this.dgvChkColumnSendOnlyWith.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvChkColumnSendOnlyWith.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvChkColumnSendOnlyWith.HeaderText = "dgvChkColumnSendOnlyWith";
            this.dgvChkColumnSendOnlyWith.Name = "dgvChkColumnSendOnlyWith";
            this.dgvChkColumnSendOnlyWith.ReadOnly = true;
            this.dgvChkColumnSendOnlyWith.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChkColumnSendOnlyWith.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvChkColumnSendOnlyWith.Width = 50;
            // 
            // dgvChkColumnSendFull
            // 
            this.dgvChkColumnSendFull.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvChkColumnSendFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvChkColumnSendFull.HeaderText = "dgvChkColumnSendFull";
            this.dgvChkColumnSendFull.Name = "dgvChkColumnSendFull";
            this.dgvChkColumnSendFull.ReadOnly = true;
            this.dgvChkColumnSendFull.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChkColumnSendFull.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvChkColumnSendFull.Width = 50;
            // 
            // SecurityClassControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpManageColumns);
            this.Controls.Add(this.dgvPermissions);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SecurityClassControl";
            this.Size = new System.Drawing.Size(963, 431);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentPermissionsForClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTDataSet)).EndInit();
            this.flpManageColumns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPermissions;
        private System.Windows.Forms.FlowLayoutPanel flpManageColumns;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.BindingSource bsDocumentPermissionsForClass;
        private ITDataSet iTDataSet;
        private ITDataSetTableAdapters.GetDocumentPermissionsForClassTableAdapter taDocumentPermissionsForClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnSecurityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnSend;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChkColumnPrintNone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChkColumnPrintOnlyWith;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChkColumnPrintFull;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChkColumnSaveNone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChkColumnSaveOnlyWith;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChkColumnSaveFull;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChkColumnSendNone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChkColumnSendOnlyWith;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChkColumnSendFull;
    }
}
