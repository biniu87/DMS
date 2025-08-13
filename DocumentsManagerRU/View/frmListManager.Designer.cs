namespace DocumentsManagerRU.View
{
    partial class frmListManager
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvListItems = new System.Windows.Forms.DataGridView();
            this.bsDocumentDefinitionListItems = new System.Windows.Forms.BindingSource(this.components);
            this.iTDataSet = new DocumentsManagerRU.ITDataSet();
            this.tlpControlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.bntAddNew = new System.Windows.Forms.Button();
            this.txtNewRecord = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbDefinition = new System.Windows.Forms.ComboBox();
            this.bsDocumentDefinitions = new System.Windows.Forms.BindingSource(this.components);
            this.lblDefinition = new System.Windows.Forms.Label();
            this.taDocumentDefinitions = new DocumentsManagerRU.ITDataSetTableAdapters.GetDocumentDefinitionsTableAdapter();
            this.taDocument_DefinitionList_Items = new DocumentsManagerRU.ITDataSetTableAdapters.GetDocumentDefinitionListItemsTableAdapter();
            this.dgvColumnItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnItemDefinitionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnItemDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvColumnItemActiveDB = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvColumnItemActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentDefinitionListItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTDataSet)).BeginInit();
            this.tlpControlButtons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentDefinitions)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.btnCancel, 0, 3);
            this.tlpMain.Controls.Add(this.dgvListItems, 0, 1);
            this.tlpMain.Controls.Add(this.tlpControlButtons, 0, 2);
            this.tlpMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpMain.Size = new System.Drawing.Size(534, 461);
            this.tlpMain.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Image = global::DocumentsManagerRU.Properties.Resources.circle_x_2x;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(0, 434);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnCancel.Size = new System.Drawing.Size(534, 27);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dgvListItems
            // 
            this.dgvListItems.AllowUserToAddRows = false;
            this.dgvListItems.AllowUserToResizeRows = false;
            this.dgvListItems.AutoGenerateColumns = false;
            this.dgvListItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumnItemId,
            this.dgvColumnItemDefinitionId,
            this.dgvColumnItemName,
            this.dgvColumnItemDelete,
            this.dgvColumnItemActiveDB,
            this.dgvColumnItemActive});
            this.dgvListItems.DataSource = this.bsDocumentDefinitionListItems;
            this.dgvListItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListItems.Location = new System.Drawing.Point(0, 22);
            this.dgvListItems.Margin = new System.Windows.Forms.Padding(0);
            this.dgvListItems.Name = "dgvListItems";
            this.dgvListItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListItems.Size = new System.Drawing.Size(534, 385);
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
            this.bsDocumentDefinitionListItems.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.bsDocumentDefinitionListItems_AddingNew);
            // 
            // iTDataSet
            // 
            this.iTDataSet.DataSetName = "ITDataSet";
            this.iTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tlpControlButtons
            // 
            this.tlpControlButtons.ColumnCount = 3;
            this.tlpControlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpControlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpControlButtons.Controls.Add(this.bntAddNew, 2, 0);
            this.tlpControlButtons.Controls.Add(this.txtNewRecord, 1, 0);
            this.tlpControlButtons.Controls.Add(this.lblName, 0, 0);
            this.tlpControlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControlButtons.Location = new System.Drawing.Point(0, 407);
            this.tlpControlButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpControlButtons.Name = "tlpControlButtons";
            this.tlpControlButtons.RowCount = 1;
            this.tlpControlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControlButtons.Size = new System.Drawing.Size(534, 27);
            this.tlpControlButtons.TabIndex = 6;
            // 
            // bntAddNew
            // 
            this.bntAddNew.Image = global::DocumentsManagerRU.Properties.Resources.plus_2x;
            this.bntAddNew.Location = new System.Drawing.Point(484, 0);
            this.bntAddNew.Margin = new System.Windows.Forms.Padding(0);
            this.bntAddNew.Name = "bntAddNew";
            this.bntAddNew.Size = new System.Drawing.Size(50, 27);
            this.bntAddNew.TabIndex = 0;
            this.bntAddNew.UseVisualStyleBackColor = true;
            this.bntAddNew.Click += new System.EventHandler(this.bntAddNew_Click);
            // 
            // txtNewRecord
            // 
            this.txtNewRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewRecord.Location = new System.Drawing.Point(103, 3);
            this.txtNewRecord.Name = "txtNewRecord";
            this.txtNewRecord.Size = new System.Drawing.Size(378, 21);
            this.txtNewRecord.TabIndex = 1;
            this.txtNewRecord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewRecord_KeyDown);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 23);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "lblName";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cbDefinition, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDefinition, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(534, 22);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cbDefinition
            // 
            this.cbDefinition.DataSource = this.bsDocumentDefinitions;
            this.cbDefinition.DisplayMember = "CurrentName";
            this.cbDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDefinition.Enabled = false;
            this.cbDefinition.FormattingEnabled = true;
            this.cbDefinition.Location = new System.Drawing.Point(267, 0);
            this.cbDefinition.Margin = new System.Windows.Forms.Padding(0);
            this.cbDefinition.Name = "cbDefinition";
            this.cbDefinition.Size = new System.Drawing.Size(267, 21);
            this.cbDefinition.TabIndex = 1;
            this.cbDefinition.ValueMember = "Id";
            // 
            // bsDocumentDefinitions
            // 
            this.bsDocumentDefinitions.DataMember = "GetDocumentDefinitions";
            this.bsDocumentDefinitions.DataSource = this.iTDataSet;
            // 
            // lblDefinition
            // 
            this.lblDefinition.AutoSize = true;
            this.lblDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDefinition.Location = new System.Drawing.Point(3, 0);
            this.lblDefinition.Name = "lblDefinition";
            this.lblDefinition.Size = new System.Drawing.Size(261, 22);
            this.lblDefinition.TabIndex = 0;
            this.lblDefinition.Text = "lblDefinition";
            this.lblDefinition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taDocumentDefinitions
            // 
            this.taDocumentDefinitions.ClearBeforeFill = true;
            // 
            // taDocument_DefinitionList_Items
            // 
            this.taDocument_DefinitionList_Items.ClearBeforeFill = true;
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
            // dgvColumnItemDefinitionId
            // 
            this.dgvColumnItemDefinitionId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnItemDefinitionId.DataPropertyName = "DefinitionId";
            this.dgvColumnItemDefinitionId.HeaderText = "dgvColumnItemDefinitionId";
            this.dgvColumnItemDefinitionId.Name = "dgvColumnItemDefinitionId";
            this.dgvColumnItemDefinitionId.Visible = false;
            // 
            // dgvColumnItemName
            // 
            this.dgvColumnItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvColumnItemName.DataPropertyName = "Name";
            this.dgvColumnItemName.HeaderText = "dgvColumnItemName";
            this.dgvColumnItemName.Name = "dgvColumnItemName";
            // 
            // dgvColumnItemDelete
            // 
            this.dgvColumnItemDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvColumnItemDelete.HeaderText = "";
            this.dgvColumnItemDelete.Image = global::DocumentsManagerRU.Properties.Resources.delete_2x;
            this.dgvColumnItemDelete.Name = "dgvColumnItemDelete";
            this.dgvColumnItemDelete.Width = 30;
            // 
            // dgvColumnItemActiveDB
            // 
            this.dgvColumnItemActiveDB.DataPropertyName = "Active";
            this.dgvColumnItemActiveDB.HeaderText = "Active";
            this.dgvColumnItemActiveDB.Name = "dgvColumnItemActiveDB";
            this.dgvColumnItemActiveDB.ReadOnly = true;
            this.dgvColumnItemActiveDB.Visible = false;
            // 
            // dgvColumnItemActive
            // 
            this.dgvColumnItemActive.HeaderText = "dgvColumnItemActive";
            this.dgvColumnItemActive.Name = "dgvColumnItemActive";
            this.dgvColumnItemActive.ReadOnly = true;
            // 
            // frmListManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(534, 461);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListManager";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmListManager";
            this.Load += new System.EventHandler(this.frmListManager_Load);
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentDefinitionListItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTDataSet)).EndInit();
            this.tlpControlButtons.ResumeLayout(false);
            this.tlpControlButtons.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentDefinitions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvListItems;
        private System.Windows.Forms.TableLayoutPanel tlpControlButtons;
        private System.Windows.Forms.BindingSource bsDocumentDefinitions;
        private ITDataSet iTDataSet;
        private ITDataSetTableAdapters.GetDocumentDefinitionsTableAdapter taDocumentDefinitions;
        private System.Windows.Forms.BindingSource bsDocumentDefinitionListItems;
        private ITDataSetTableAdapters.GetDocumentDefinitionListItemsTableAdapter taDocument_DefinitionList_Items;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbDefinition;
        private System.Windows.Forms.Label lblDefinition;
        private System.Windows.Forms.TextBox txtNewRecord;
        private System.Windows.Forms.Button bntAddNew;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnItemDefinitionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnItemName;
        private System.Windows.Forms.DataGridViewImageColumn dgvColumnItemDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvColumnItemActiveDB;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvColumnItemActive;
    }
}