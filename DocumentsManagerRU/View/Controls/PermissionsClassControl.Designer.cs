namespace DocumentsManagerRU.View.Controls
{
    partial class PermissionsClassControl
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
            this.dgvColumClassAccess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnDC_Release = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvColumnCS_Mail = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvChkColumnClassNone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvChkColumnClassRead = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvChkColumnClassRelease = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvChkColumnClassDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvChkColumnCanRelease = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvChkColumnMailOnRelease = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.dgvColumClassAccess,
            this.dgvColumnDC_Release,
            this.dgvColumnCS_Mail,
            this.dgvChkColumnClassNone,
            this.dgvChkColumnClassRead,
            this.dgvChkColumnClassRelease,
            this.dgvChkColumnClassDelete,
            this.dgvChkColumnCanRelease,
            this.dgvChkColumnMailOnRelease});
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
            // dgvColumClassAccess
            // 
            this.dgvColumClassAccess.DataPropertyName = "AccessLevel";
            this.dgvColumClassAccess.HeaderText = "dgvColumClassAccess";
            this.dgvColumClassAccess.Name = "dgvColumClassAccess";
            this.dgvColumClassAccess.Visible = false;
            // 
            // dgvColumnDC_Release
            // 
            this.dgvColumnDC_Release.DataPropertyName = "DC_Release";
            this.dgvColumnDC_Release.HeaderText = "dgvColumnDC_Release";
            this.dgvColumnDC_Release.Name = "dgvColumnDC_Release";
            this.dgvColumnDC_Release.Visible = false;
            // 
            // dgvColumnCS_Mail
            // 
            this.dgvColumnCS_Mail.DataPropertyName = "CS_Mail";
            this.dgvColumnCS_Mail.HeaderText = "dgvColumnCS_Mail";
            this.dgvColumnCS_Mail.Name = "dgvColumnCS_Mail";
            this.dgvColumnCS_Mail.Visible = false;
            // 
            // dgvChkColumnClassNone
            // 
            this.dgvChkColumnClassNone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvChkColumnClassNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvChkColumnClassNone.HeaderText = "dgvChkColumnClassNone";
            this.dgvChkColumnClassNone.Name = "dgvChkColumnClassNone";
            this.dgvChkColumnClassNone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChkColumnClassNone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvChkColumnClassNone.Width = 50;
            // 
            // dgvChkColumnClassRead
            // 
            this.dgvChkColumnClassRead.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvChkColumnClassRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvChkColumnClassRead.HeaderText = "dgvChkColumnClassRead";
            this.dgvChkColumnClassRead.Name = "dgvChkColumnClassRead";
            this.dgvChkColumnClassRead.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChkColumnClassRead.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvChkColumnClassRead.Width = 50;
            // 
            // dgvChkColumnClassRelease
            // 
            this.dgvChkColumnClassRelease.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvChkColumnClassRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvChkColumnClassRelease.HeaderText = "dgvChkColumnClassRelease";
            this.dgvChkColumnClassRelease.Name = "dgvChkColumnClassRelease";
            this.dgvChkColumnClassRelease.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChkColumnClassRelease.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvChkColumnClassRelease.Width = 50;
            // 
            // dgvChkColumnClassDelete
            // 
            this.dgvChkColumnClassDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvChkColumnClassDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvChkColumnClassDelete.HeaderText = "dgvChkColumnClassDelete";
            this.dgvChkColumnClassDelete.Name = "dgvChkColumnClassDelete";
            this.dgvChkColumnClassDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChkColumnClassDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvChkColumnClassDelete.Width = 50;
            // 
            // dgvChkColumnCanRelease
            // 
            this.dgvChkColumnCanRelease.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvChkColumnCanRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvChkColumnCanRelease.HeaderText = "dgvChkColumnCanRelease";
            this.dgvChkColumnCanRelease.Name = "dgvChkColumnCanRelease";
            this.dgvChkColumnCanRelease.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChkColumnCanRelease.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvChkColumnMailOnRelease
            // 
            this.dgvChkColumnMailOnRelease.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvChkColumnMailOnRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvChkColumnMailOnRelease.HeaderText = "dgvChkColumnMailOnRelease";
            this.dgvChkColumnMailOnRelease.Name = "dgvChkColumnMailOnRelease";
            this.dgvChkColumnMailOnRelease.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChkColumnMailOnRelease.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PermissionsClassControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpManageColumns);
            this.Controls.Add(this.dgvPermissions);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PermissionsClassControl";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumClassAccess;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvColumnDC_Release;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvColumnCS_Mail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChkColumnClassNone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChkColumnClassRead;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChkColumnClassRelease;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChkColumnClassDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChkColumnCanRelease;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChkColumnMailOnRelease;
    }
}
