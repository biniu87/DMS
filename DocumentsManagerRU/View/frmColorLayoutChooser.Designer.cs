namespace DocumentsManagerRU.View
{
    partial class frmColorLayoutChooser
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
            this.dgvColors = new System.Windows.Forms.DataGridView();
            this.dgvColumnParams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnThumbURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnThumb = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSetLayoutColors = new System.Windows.Forms.Button();
            this.btnCancel1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvColors
            // 
            this.dgvColors.AllowUserToAddRows = false;
            this.dgvColors.AllowUserToDeleteRows = false;
            this.dgvColors.AllowUserToResizeColumns = false;
            this.dgvColors.AllowUserToResizeRows = false;
            this.dgvColors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvColors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvColors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumnParams,
            this.dgvColumnThumbURL,
            this.dgvColumnThumb});
            this.dgvColors.Location = new System.Drawing.Point(0, 0);
            this.dgvColors.Margin = new System.Windows.Forms.Padding(0);
            this.dgvColors.MultiSelect = false;
            this.dgvColors.Name = "dgvColors";
            this.dgvColors.ReadOnly = true;
            this.dgvColors.RowTemplate.Height = 100;
            this.dgvColors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColors.Size = new System.Drawing.Size(241, 369);
            this.dgvColors.TabIndex = 0;
            this.dgvColors.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvColors_CellContentDoubleClick);
            this.dgvColors.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvColors_CellFormatting);
            // 
            // dgvColumnParams
            // 
            this.dgvColumnParams.HeaderText = "params";
            this.dgvColumnParams.Name = "dgvColumnParams";
            this.dgvColumnParams.ReadOnly = true;
            this.dgvColumnParams.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvColumnParams.Visible = false;
            // 
            // dgvColumnThumbURL
            // 
            this.dgvColumnThumbURL.HeaderText = "url";
            this.dgvColumnThumbURL.Name = "dgvColumnThumbURL";
            this.dgvColumnThumbURL.ReadOnly = true;
            this.dgvColumnThumbURL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvColumnThumbURL.Visible = false;
            // 
            // dgvColumnThumb
            // 
            this.dgvColumnThumb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvColumnThumb.HeaderText = "Podgląd";
            this.dgvColumnThumb.Name = "dgvColumnThumb";
            this.dgvColumnThumb.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnSetLayoutColors, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 369);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(241, 28);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnSetLayoutColors
            // 
            this.btnSetLayoutColors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetLayoutColors.Image = global::DocumentsManagerRU.Properties.Resources.check_2x;
            this.btnSetLayoutColors.Location = new System.Drawing.Point(0, 0);
            this.btnSetLayoutColors.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetLayoutColors.Name = "btnSetLayoutColors";
            this.btnSetLayoutColors.Size = new System.Drawing.Size(120, 28);
            this.btnSetLayoutColors.TabIndex = 1;
            this.btnSetLayoutColors.UseVisualStyleBackColor = true;
            this.btnSetLayoutColors.Click += new System.EventHandler(this.btnSetLayoutColors_Click);
            // 
            // btnCancel1
            // 
            this.btnCancel1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel1.Image = global::DocumentsManagerRU.Properties.Resources.circle_x_2x;
            this.btnCancel1.Location = new System.Drawing.Point(120, 0);
            this.btnCancel1.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(121, 28);
            this.btnCancel1.TabIndex = 1;
            this.btnCancel1.UseVisualStyleBackColor = true;
            this.btnCancel1.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmColorLayoutChooser
            // 
            this.AcceptButton = this.btnSetLayoutColors;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel1;
            this.ClientSize = new System.Drawing.Size(241, 397);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvColors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmColorLayoutChooser";
            this.Text = "frmColorLayoutChooser";
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvColors;
        private System.Windows.Forms.Button btnSetLayoutColors;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnParams;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnThumbURL;
        private System.Windows.Forms.DataGridViewImageColumn dgvColumnThumb;
    }
}