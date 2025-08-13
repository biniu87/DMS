namespace DocumentsManagerRU
{
    partial class PageBox
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
            this.tbPage = new System.Windows.Forms.TrackBar();
            this.lblFirstPage = new System.Windows.Forms.Label();
            this.lblLastPage = new System.Windows.Forms.Label();
            this.lblActualPage = new System.Windows.Forms.Label();
            this.tlpLabels = new System.Windows.Forms.TableLayoutPanel();
            this.lblActualDocuments = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbPage)).BeginInit();
            this.tlpLabels.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPage
            // 
            this.tbPage.AutoSize = false;
            this.tbPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPage.Location = new System.Drawing.Point(0, 0);
            this.tbPage.Margin = new System.Windows.Forms.Padding(0);
            this.tbPage.Maximum = 100;
            this.tbPage.Name = "tbPage";
            this.tbPage.Size = new System.Drawing.Size(769, 29);
            this.tbPage.TabIndex = 0;
            this.tbPage.Value = 10;
            this.tbPage.Scroll += new System.EventHandler(this.tbPage_Scroll);
            this.tbPage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPage_KeyDown);
            // 
            // lblFirstPage
            // 
            this.lblFirstPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFirstPage.Location = new System.Drawing.Point(3, 0);
            this.lblFirstPage.Name = "lblFirstPage";
            this.lblFirstPage.Size = new System.Drawing.Size(94, 22);
            this.lblFirstPage.TabIndex = 1;
            this.lblFirstPage.Text = "123456789";
            this.lblFirstPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLastPage
            // 
            this.lblLastPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastPage.Location = new System.Drawing.Point(671, 0);
            this.lblLastPage.Name = "lblLastPage";
            this.lblLastPage.Size = new System.Drawing.Size(95, 22);
            this.lblLastPage.TabIndex = 2;
            this.lblLastPage.Text = "123456789";
            this.lblLastPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblActualPage
            // 
            this.lblActualPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActualPage.Location = new System.Drawing.Point(103, 0);
            this.lblActualPage.Name = "lblActualPage";
            this.lblActualPage.Size = new System.Drawing.Size(267, 22);
            this.lblActualPage.TabIndex = 3;
            this.lblActualPage.Text = "123456789";
            this.lblActualPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tlpLabels
            // 
            this.tlpLabels.ColumnCount = 5;
            this.tlpLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tlpLabels.Controls.Add(this.lblActualDocuments, 3, 0);
            this.tlpLabels.Controls.Add(this.lblActualPage, 1, 0);
            this.tlpLabels.Controls.Add(this.lblLastPage, 4, 0);
            this.tlpLabels.Controls.Add(this.lblFirstPage, 0, 0);
            this.tlpLabels.Controls.Add(this.btnSelect, 2, 0);
            this.tlpLabels.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpLabels.Location = new System.Drawing.Point(0, 32);
            this.tlpLabels.Name = "tlpLabels";
            this.tlpLabels.RowCount = 1;
            this.tlpLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLabels.Size = new System.Drawing.Size(769, 22);
            this.tlpLabels.TabIndex = 4;
            // 
            // lblActualDocuments
            // 
            this.lblActualDocuments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActualDocuments.Location = new System.Drawing.Point(398, 0);
            this.lblActualDocuments.Name = "lblActualDocuments";
            this.lblActualDocuments.Size = new System.Drawing.Size(267, 22);
            this.lblActualDocuments.TabIndex = 4;
            this.lblActualDocuments.Text = "123456789";
            this.lblActualDocuments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSelect
            // 
            this.btnSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelect.Image = global::DocumentsManagerRU.Properties.Resources.check_2x;
            this.btnSelect.Location = new System.Drawing.Point(373, 0);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(22, 22);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // PageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 54);
            this.Controls.Add(this.tlpLabels);
            this.Controls.Add(this.tbPage);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PageBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PageBox";
            this.Deactivate += new System.EventHandler(this.PageBox_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.tbPage)).EndInit();
            this.tlpLabels.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar tbPage;
        private System.Windows.Forms.Label lblFirstPage;
        private System.Windows.Forms.Label lblLastPage;
        private System.Windows.Forms.Label lblActualPage;
        private System.Windows.Forms.TableLayoutPanel tlpLabels;
        private System.Windows.Forms.Label lblActualDocuments;
        private System.Windows.Forms.Button btnSelect;
    }
}