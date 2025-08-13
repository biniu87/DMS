namespace DocumentsManagerRU
{
    partial class frmPermissionManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsDocumentClass = new System.Windows.Forms.BindingSource(this.components);
            this.iTDataSet = new DocumentsManagerRU.ITDataSet();
            this.bsDocumentPermissionsForClass = new System.Windows.Forms.BindingSource(this.components);
            this.taDocumentClass = new DocumentsManagerRU.ITDataSetTableAdapters.Document_ClassTableAdapter();
            this.taGetDocumentPermissionsForClass = new DocumentsManagerRU.ITDataSetTableAdapters.GetDocumentPermissionsForClassTableAdapter();
            this.lblClassTitle = new System.Windows.Forms.Label();
            this.pnlSecurityControl = new System.Windows.Forms.Panel();
            this.rbSecurityClass = new System.Windows.Forms.RadioButton();
            this.rbSecurityAdds = new System.Windows.Forms.RadioButton();
            this.rbPermissionClass = new System.Windows.Forms.RadioButton();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.dgvColumnClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnTableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnActiveClass = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvColumnClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnClassDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentPermissionsForClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
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
            // bsDocumentPermissionsForClass
            // 
            this.bsDocumentPermissionsForClass.DataMember = "GetDocumentPermissionsForClass";
            this.bsDocumentPermissionsForClass.DataSource = this.iTDataSet;
            // 
            // taDocumentClass
            // 
            this.taDocumentClass.ClearBeforeFill = true;
            // 
            // taGetDocumentPermissionsForClass
            // 
            this.taGetDocumentPermissionsForClass.ClearBeforeFill = true;
            // 
            // lblClassTitle
            // 
            this.lblClassTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblClassTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblClassTitle.Location = new System.Drawing.Point(0, 0);
            this.lblClassTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblClassTitle.Name = "lblClassTitle";
            this.lblClassTitle.Size = new System.Drawing.Size(235, 30);
            this.lblClassTitle.TabIndex = 0;
            this.lblClassTitle.Text = "lblClassTitle";
            this.lblClassTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSecurityControl
            // 
            this.pnlSecurityControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSecurityControl.Location = new System.Drawing.Point(235, 30);
            this.pnlSecurityControl.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSecurityControl.Name = "pnlSecurityControl";
            this.pnlSecurityControl.Size = new System.Drawing.Size(826, 350);
            this.pnlSecurityControl.TabIndex = 5;
            // 
            // rbSecurityClass
            // 
            this.rbSecurityClass.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbSecurityClass.Location = new System.Drawing.Point(465, 0);
            this.rbSecurityClass.Margin = new System.Windows.Forms.Padding(0);
            this.rbSecurityClass.Name = "rbSecurityClass";
            this.rbSecurityClass.Size = new System.Drawing.Size(230, 30);
            this.rbSecurityClass.TabIndex = 3;
            this.rbSecurityClass.TabStop = true;
            this.rbSecurityClass.Text = "rbSecurityClass";
            this.rbSecurityClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbSecurityClass.UseVisualStyleBackColor = true;
            this.rbSecurityClass.CheckedChanged += new System.EventHandler(this.rbSecuritySettings_CheckedChanged);
            // 
            // rbSecurityAdds
            // 
            this.rbSecurityAdds.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbSecurityAdds.Location = new System.Drawing.Point(695, 0);
            this.rbSecurityAdds.Margin = new System.Windows.Forms.Padding(0);
            this.rbSecurityAdds.Name = "rbSecurityAdds";
            this.rbSecurityAdds.Size = new System.Drawing.Size(230, 30);
            this.rbSecurityAdds.TabIndex = 4;
            this.rbSecurityAdds.TabStop = true;
            this.rbSecurityAdds.Text = "rbSecurityAdds";
            this.rbSecurityAdds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbSecurityAdds.UseVisualStyleBackColor = true;
            this.rbSecurityAdds.CheckedChanged += new System.EventHandler(this.rbSecuritySettings_CheckedChanged);
            // 
            // rbPermissionClass
            // 
            this.rbPermissionClass.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPermissionClass.Location = new System.Drawing.Point(235, 0);
            this.rbPermissionClass.Margin = new System.Windows.Forms.Padding(0);
            this.rbPermissionClass.Name = "rbPermissionClass";
            this.rbPermissionClass.Size = new System.Drawing.Size(230, 30);
            this.rbPermissionClass.TabIndex = 2;
            this.rbPermissionClass.TabStop = true;
            this.rbPermissionClass.Text = "rbPermissionClass";
            this.rbPermissionClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbPermissionClass.UseVisualStyleBackColor = true;
            this.rbPermissionClass.CheckedChanged += new System.EventHandler(this.rbSecuritySettings_CheckedChanged);
            // 
            // dgvClass
            // 
            this.dgvClass.AllowUserToAddRows = false;
            this.dgvClass.AllowUserToDeleteRows = false;
            this.dgvClass.AllowUserToResizeColumns = false;
            this.dgvClass.AllowUserToResizeRows = false;
            this.dgvClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvClass.AutoGenerateColumns = false;
            this.dgvClass.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClass.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvClass.ColumnHeadersHeight = 30;
            this.dgvClass.ColumnHeadersVisible = false;
            this.dgvClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumnClassId,
            this.dgvColumnTableName,
            this.dgvColumnActiveClass,
            this.dgvColumnClassName,
            this.dgvColumnClassDescription});
            this.dgvClass.DataSource = this.bsDocumentClass;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClass.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClass.Location = new System.Drawing.Point(3, 30);
            this.dgvClass.MultiSelect = false;
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.ReadOnly = true;
            this.dgvClass.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClass.RowHeadersWidth = 20;
            this.dgvClass.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClass.Size = new System.Drawing.Size(229, 350);
            this.dgvClass.TabIndex = 6;
            this.dgvClass.SelectionChanged += new System.EventHandler(this.lstClass_SelectedIndexChanged);
            // 
            // dgvColumnClassId
            // 
            this.dgvColumnClassId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnClassId.DataPropertyName = "Id";
            this.dgvColumnClassId.HeaderText = "dgvColumnClassId";
            this.dgvColumnClassId.Name = "dgvColumnClassId";
            this.dgvColumnClassId.ReadOnly = true;
            this.dgvColumnClassId.Visible = false;
            // 
            // dgvColumnTableName
            // 
            this.dgvColumnTableName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnTableName.DataPropertyName = "Table_Name";
            this.dgvColumnTableName.HeaderText = "dgvColumnTableName";
            this.dgvColumnTableName.Name = "dgvColumnTableName";
            this.dgvColumnTableName.ReadOnly = true;
            this.dgvColumnTableName.Visible = false;
            // 
            // dgvColumnActiveClass
            // 
            this.dgvColumnActiveClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnActiveClass.DataPropertyName = "Active";
            this.dgvColumnActiveClass.HeaderText = "dgvColumnActiveClass";
            this.dgvColumnActiveClass.Name = "dgvColumnActiveClass";
            this.dgvColumnActiveClass.ReadOnly = true;
            this.dgvColumnActiveClass.Visible = false;
            // 
            // dgvColumnClassName
            // 
            this.dgvColumnClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvColumnClassName.DataPropertyName = "CurrentName";
            this.dgvColumnClassName.HeaderText = "dgvColumnClassName";
            this.dgvColumnClassName.Name = "dgvColumnClassName";
            this.dgvColumnClassName.ReadOnly = true;
            // 
            // dgvColumnClassDescription
            // 
            this.dgvColumnClassDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnClassDescription.DataPropertyName = "CurrentDescription";
            this.dgvColumnClassDescription.HeaderText = "dgvColumnClassName";
            this.dgvColumnClassDescription.Name = "dgvColumnClassDescription";
            this.dgvColumnClassDescription.ReadOnly = true;
            this.dgvColumnClassDescription.Visible = false;
            // 
            // frmPermissionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 382);
            this.Controls.Add(this.dgvClass);
            this.Controls.Add(this.rbPermissionClass);
            this.Controls.Add(this.rbSecurityAdds);
            this.Controls.Add(this.rbSecurityClass);
            this.Controls.Add(this.pnlSecurityControl);
            this.Controls.Add(this.lblClassTitle);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinimumSize = new System.Drawing.Size(1077, 421);
            this.Name = "frmPermissionManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPermissionManager";
            this.Load += new System.EventHandler(this.frmPermissionsManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentPermissionsForClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ITDataSet iTDataSet;
        private System.Windows.Forms.BindingSource bsDocumentClass;
        private ITDataSetTableAdapters.Document_ClassTableAdapter taDocumentClass;
        private System.Windows.Forms.BindingSource bsDocumentPermissionsForClass;
        private ITDataSetTableAdapters.GetDocumentPermissionsForClassTableAdapter taGetDocumentPermissionsForClass;
        private System.Windows.Forms.Label lblClassTitle;
        private System.Windows.Forms.Panel pnlSecurityControl;
        private System.Windows.Forms.RadioButton rbSecurityClass;
        private System.Windows.Forms.RadioButton rbSecurityAdds;
        private System.Windows.Forms.RadioButton rbPermissionClass;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnTableName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvColumnActiveClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnClassDescription;
    }
}