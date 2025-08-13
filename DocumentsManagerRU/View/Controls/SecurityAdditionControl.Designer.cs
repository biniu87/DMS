namespace DocumentsManagerRU.View.Controls
{
    partial class SecurityAdditionControl
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
            this.dgvColumnM_Highlight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnM_Blackout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnM_Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnCH_Highlight = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvColumnCH_Blackout = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvColumnCH_Note = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvChkColumnHighlightNone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvChkColumnHighlightNew = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvChkColumnHighlightFull = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvChkColumnHighlightCanHide = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvChkColumnBlackoutNone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvChkColumnBlackoutNew = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvChkColumnBlackoutFull = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvChkColumnBlackoutCanHide = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvChkColumnNoteNone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvChkColumnNoteNew = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvChkColumnNoteFull = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvChkColumnNoteCanHide = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.dgvColumnM_Highlight,
            this.dgvColumnM_Blackout,
            this.dgvColumnM_Note,
            this.dgvColumnCH_Highlight,
            this.dgvColumnCH_Blackout,
            this.dgvColumnCH_Note,
            this.dgvChkColumnHighlightNone,
            this.dgvChkColumnHighlightNew,
            this.dgvChkColumnHighlightFull,
            this.dgvChkColumnHighlightCanHide,
            this.dgvChkColumnBlackoutNone,
            this.dgvChkColumnBlackoutNew,
            this.dgvChkColumnBlackoutFull,
            this.dgvChkColumnBlackoutCanHide,
            this.dgvChkColumnNoteNone,
            this.dgvChkColumnNoteNew,
            this.dgvChkColumnNoteFull,
            this.dgvChkColumnNoteCanHide});
            this.dgvPermissions.DataSource = this.bsDocumentPermissionsForClass;
            this.dgvPermissions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPermissions.Location = new System.Drawing.Point(0, 54);
            this.dgvPermissions.Margin = new System.Windows.Forms.Padding(0);
            this.dgvPermissions.Name = "dgvPermissions";
            this.dgvPermissions.RowHeadersWidth = 20;
            this.dgvPermissions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
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
            // dgvColumnM_Highlight
            // 
            this.dgvColumnM_Highlight.DataPropertyName = "M_Highlight";
            this.dgvColumnM_Highlight.HeaderText = "dgvColumnM_Highlight";
            this.dgvColumnM_Highlight.Name = "dgvColumnM_Highlight";
            this.dgvColumnM_Highlight.Visible = false;
            // 
            // dgvColumnM_Blackout
            // 
            this.dgvColumnM_Blackout.DataPropertyName = "M_Blackout";
            this.dgvColumnM_Blackout.HeaderText = "dgvColumnM_Blackout";
            this.dgvColumnM_Blackout.Name = "dgvColumnM_Blackout";
            this.dgvColumnM_Blackout.Visible = false;
            // 
            // dgvColumnM_Note
            // 
            this.dgvColumnM_Note.DataPropertyName = "M_Note";
            this.dgvColumnM_Note.HeaderText = "dgvColumnM_Note";
            this.dgvColumnM_Note.Name = "dgvColumnM_Note";
            this.dgvColumnM_Note.Visible = false;
            // 
            // dgvColumnCH_Highlight
            // 
            this.dgvColumnCH_Highlight.DataPropertyName = "CH_Highlight";
            this.dgvColumnCH_Highlight.HeaderText = "dgvColumnCH_Highlight";
            this.dgvColumnCH_Highlight.Name = "dgvColumnCH_Highlight";
            this.dgvColumnCH_Highlight.Visible = false;
            // 
            // dgvColumnCH_Blackout
            // 
            this.dgvColumnCH_Blackout.DataPropertyName = "CH_Blackout";
            this.dgvColumnCH_Blackout.HeaderText = "dgvColumnCH_Blackout";
            this.dgvColumnCH_Blackout.Name = "dgvColumnCH_Blackout";
            this.dgvColumnCH_Blackout.Visible = false;
            // 
            // dgvColumnCH_Note
            // 
            this.dgvColumnCH_Note.DataPropertyName = "CH_Note";
            this.dgvColumnCH_Note.HeaderText = "dgvColumnCH_Note";
            this.dgvColumnCH_Note.Name = "dgvColumnCH_Note";
            this.dgvColumnCH_Note.Visible = false;
            // 
            // dgvChkColumnHighlightNone
            // 
            this.dgvChkColumnHighlightNone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvChkColumnHighlightNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvChkColumnHighlightNone.HeaderText = "dgvChkColumnHighlightNone";
            this.dgvChkColumnHighlightNone.Name = "dgvChkColumnHighlightNone";
            this.dgvChkColumnHighlightNone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChkColumnHighlightNone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvChkColumnHighlightNone.Width = 50;
            // 
            // dgvChkColumnHighlightNew
            // 
            this.dgvChkColumnHighlightNew.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvChkColumnHighlightNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvChkColumnHighlightNew.HeaderText = "dgvChkColumnHighlightNew";
            this.dgvChkColumnHighlightNew.Name = "dgvChkColumnHighlightNew";
            this.dgvChkColumnHighlightNew.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChkColumnHighlightNew.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvChkColumnHighlightNew.Width = 50;
            // 
            // dgvChkColumnHighlightFull
            // 
            this.dgvChkColumnHighlightFull.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvChkColumnHighlightFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvChkColumnHighlightFull.HeaderText = "dgvChkColumnHighlightFull";
            this.dgvChkColumnHighlightFull.Name = "dgvChkColumnHighlightFull";
            this.dgvChkColumnHighlightFull.ReadOnly = true;
            this.dgvChkColumnHighlightFull.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChkColumnHighlightFull.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvChkColumnHighlightFull.Width = 50;
            // 
            // dgvChkColumnHighlightCanHide
            // 
            this.dgvChkColumnHighlightCanHide.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvChkColumnHighlightCanHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvChkColumnHighlightCanHide.HeaderText = "dgvChkColumnHighlightCanHide";
            this.dgvChkColumnHighlightCanHide.Name = "dgvChkColumnHighlightCanHide";
            this.dgvChkColumnHighlightCanHide.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChkColumnHighlightCanHide.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvChkColumnHighlightCanHide.Width = 50;
            // 
            // dgvChkColumnBlackoutNone
            // 
            this.dgvChkColumnBlackoutNone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvChkColumnBlackoutNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvChkColumnBlackoutNone.HeaderText = "dgvChkColumnBlackoutNone";
            this.dgvChkColumnBlackoutNone.Name = "dgvChkColumnBlackoutNone";
            this.dgvChkColumnBlackoutNone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChkColumnBlackoutNone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvChkColumnBlackoutNone.Width = 50;
            // 
            // dgvChkColumnBlackoutNew
            // 
            this.dgvChkColumnBlackoutNew.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvChkColumnBlackoutNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvChkColumnBlackoutNew.HeaderText = "dgvChkColumnBlackoutNew";
            this.dgvChkColumnBlackoutNew.Name = "dgvChkColumnBlackoutNew";
            this.dgvChkColumnBlackoutNew.ReadOnly = true;
            this.dgvChkColumnBlackoutNew.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChkColumnBlackoutNew.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvChkColumnBlackoutNew.Width = 50;
            // 
            // dgvChkColumnBlackoutFull
            // 
            this.dgvChkColumnBlackoutFull.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvChkColumnBlackoutFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvChkColumnBlackoutFull.HeaderText = "dgvChkColumnBlackoutFull";
            this.dgvChkColumnBlackoutFull.Name = "dgvChkColumnBlackoutFull";
            this.dgvChkColumnBlackoutFull.ReadOnly = true;
            this.dgvChkColumnBlackoutFull.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChkColumnBlackoutFull.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvChkColumnBlackoutFull.Width = 50;
            // 
            // dgvChkColumnBlackoutCanHide
            // 
            this.dgvChkColumnBlackoutCanHide.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvChkColumnBlackoutCanHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvChkColumnBlackoutCanHide.HeaderText = "dgvChkColumnBlackoutCanHide";
            this.dgvChkColumnBlackoutCanHide.Name = "dgvChkColumnBlackoutCanHide";
            this.dgvChkColumnBlackoutCanHide.ReadOnly = true;
            this.dgvChkColumnBlackoutCanHide.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChkColumnBlackoutCanHide.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvChkColumnBlackoutCanHide.Width = 50;
            // 
            // dgvChkColumnNoteNone
            // 
            this.dgvChkColumnNoteNone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvChkColumnNoteNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvChkColumnNoteNone.HeaderText = "dgvChkColumnNoteNone";
            this.dgvChkColumnNoteNone.Name = "dgvChkColumnNoteNone";
            this.dgvChkColumnNoteNone.ReadOnly = true;
            this.dgvChkColumnNoteNone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChkColumnNoteNone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvChkColumnNoteNone.Width = 50;
            // 
            // dgvChkColumnNoteNew
            // 
            this.dgvChkColumnNoteNew.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvChkColumnNoteNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvChkColumnNoteNew.HeaderText = "dgvChkColumnNoteNew";
            this.dgvChkColumnNoteNew.Name = "dgvChkColumnNoteNew";
            this.dgvChkColumnNoteNew.ReadOnly = true;
            this.dgvChkColumnNoteNew.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChkColumnNoteNew.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvChkColumnNoteNew.Width = 50;
            // 
            // dgvChkColumnNoteFull
            // 
            this.dgvChkColumnNoteFull.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvChkColumnNoteFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvChkColumnNoteFull.HeaderText = "dgvChkColumnNoteFull";
            this.dgvChkColumnNoteFull.Name = "dgvChkColumnNoteFull";
            this.dgvChkColumnNoteFull.ReadOnly = true;
            this.dgvChkColumnNoteFull.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChkColumnNoteFull.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvChkColumnNoteFull.Width = 50;
            // 
            // dgvChkColumnNoteCanHide
            // 
            this.dgvChkColumnNoteCanHide.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvChkColumnNoteCanHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvChkColumnNoteCanHide.HeaderText = "dgvChkColumnNoteCanHide";
            this.dgvChkColumnNoteCanHide.Name = "dgvChkColumnNoteCanHide";
            this.dgvChkColumnNoteCanHide.ReadOnly = true;
            this.dgvChkColumnNoteCanHide.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChkColumnNoteCanHide.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvChkColumnNoteCanHide.Width = 50;
            // 
            // SecurityAdditionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpManageColumns);
            this.Controls.Add(this.dgvPermissions);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SecurityAdditionControl";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnM_Highlight;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnM_Blackout;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnM_Note;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvColumnCH_Highlight;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvColumnCH_Blackout;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvColumnCH_Note;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChkColumnHighlightNone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChkColumnHighlightNew;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChkColumnHighlightFull;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChkColumnHighlightCanHide;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChkColumnBlackoutNone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChkColumnBlackoutNew;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChkColumnBlackoutFull;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChkColumnBlackoutCanHide;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChkColumnNoteNone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChkColumnNoteNew;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChkColumnNoteFull;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvChkColumnNoteCanHide;
    }
}
