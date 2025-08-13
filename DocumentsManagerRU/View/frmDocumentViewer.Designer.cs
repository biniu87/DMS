namespace DocumentsManagerRU.View
{
    partial class frmDocumentViewer
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
            this.rtbIndexes = new System.Windows.Forms.RichTextBox();
            this.pnlView = new System.Windows.Forms.Panel();
            this.tlpViewer = new System.Windows.Forms.TableLayoutPanel();
            this.tlpViewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbIndexes
            // 
            this.rtbIndexes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbIndexes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbIndexes.Location = new System.Drawing.Point(0, 0);
            this.rtbIndexes.Margin = new System.Windows.Forms.Padding(0);
            this.rtbIndexes.Name = "rtbIndexes";
            this.rtbIndexes.ReadOnly = true;
            this.rtbIndexes.Size = new System.Drawing.Size(1002, 30);
            this.rtbIndexes.TabIndex = 0;
            this.rtbIndexes.Text = "";
            // 
            // pnlView
            // 
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(0, 30);
            this.pnlView.Margin = new System.Windows.Forms.Padding(0);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(1002, 488);
            this.pnlView.TabIndex = 1;
            // 
            // tlpViewer
            // 
            this.tlpViewer.ColumnCount = 1;
            this.tlpViewer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpViewer.Controls.Add(this.rtbIndexes, 0, 0);
            this.tlpViewer.Controls.Add(this.pnlView, 0, 1);
            this.tlpViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpViewer.Location = new System.Drawing.Point(0, 0);
            this.tlpViewer.Name = "tlpViewer";
            this.tlpViewer.RowCount = 2;
            this.tlpViewer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpViewer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpViewer.Size = new System.Drawing.Size(1002, 518);
            this.tlpViewer.TabIndex = 2;
            // 
            // frmDocumentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 518);
            this.Controls.Add(this.tlpViewer);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "frmDocumentViewer";
            this.ShowIcon = false;
            this.Text = "Document Viewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDocumentViewer_FormClosed);
            this.Load += new System.EventHandler(this.frmDocumentViewer_Load);
            this.tlpViewer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbIndexes;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.TableLayoutPanel tlpViewer;

    }
}