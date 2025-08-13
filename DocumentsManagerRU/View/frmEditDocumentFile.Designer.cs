namespace DocumentsManagerRU.View
{
    partial class frmEditDocumentFile
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
            this.gbPreview = new System.Windows.Forms.GroupBox();
            this.gbFile = new System.Windows.Forms.GroupBox();
            this.btnReleaseDocument = new System.Windows.Forms.Button();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReleaseDocument1 = new System.Windows.Forms.Button();
            this.selectDocumentFD = new System.Windows.Forms.OpenFileDialog();
            this.gbFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPreview
            // 
            this.gbPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPreview.Location = new System.Drawing.Point(519, 12);
            this.gbPreview.Name = "gbPreview";
            this.gbPreview.Size = new System.Drawing.Size(321, 383);
            this.gbPreview.TabIndex = 4;
            this.gbPreview.TabStop = false;
            this.gbPreview.Text = "gbPreview";
            // 
            // gbFile
            // 
            this.gbFile.Controls.Add(this.btnReleaseDocument);
            this.gbFile.Controls.Add(this.btnChooseFile);
            this.gbFile.Controls.Add(this.txtFilePath);
            this.gbFile.Controls.Add(this.lblFile);
            this.gbFile.Location = new System.Drawing.Point(12, 12);
            this.gbFile.Name = "gbFile";
            this.gbFile.Size = new System.Drawing.Size(501, 142);
            this.gbFile.TabIndex = 5;
            this.gbFile.TabStop = false;
            this.gbFile.Text = "gbFile";
            // 
            // btnReleaseDocument
            // 
            this.btnReleaseDocument.Image = global::DocumentsManagerRU.Properties.Resources.circle_check_2x;
            this.btnReleaseDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReleaseDocument.Location = new System.Drawing.Point(9, 101);
            this.btnReleaseDocument.Name = "btnReleaseDocument";
            this.btnReleaseDocument.Size = new System.Drawing.Size(461, 28);
            this.btnReleaseDocument.TabIndex = 10;
            this.btnReleaseDocument.Text = "btnReleaseDocument";
            this.btnReleaseDocument.UseVisualStyleBackColor = true;
            this.btnReleaseDocument.Click += new System.EventHandler(this.btnReleaseDocument_Click);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Image = global::DocumentsManagerRU.Properties.Resources.paperclip_2x;
            this.btnChooseFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChooseFile.Location = new System.Drawing.Point(9, 20);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(461, 28);
            this.btnChooseFile.TabIndex = 7;
            this.btnChooseFile.Text = "btnChooseFile";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(9, 74);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(461, 21);
            this.txtFilePath.TabIndex = 9;
            // 
            // lblFile
            // 
            this.lblFile.Location = new System.Drawing.Point(6, 51);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(169, 20);
            this.lblFile.TabIndex = 8;
            this.lblFile.Text = "lblFile";
            this.lblFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::DocumentsManagerRU.Properties.Resources.circle_x_2x;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(682, 401);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(158, 28);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReleaseDocument1
            // 
            this.btnReleaseDocument1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReleaseDocument1.Image = global::DocumentsManagerRU.Properties.Resources.circle_check_2x;
            this.btnReleaseDocument1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReleaseDocument1.Location = new System.Drawing.Point(518, 401);
            this.btnReleaseDocument1.Name = "btnReleaseDocument1";
            this.btnReleaseDocument1.Size = new System.Drawing.Size(158, 28);
            this.btnReleaseDocument1.TabIndex = 17;
            this.btnReleaseDocument1.Text = "btnReleaseDocument1";
            this.btnReleaseDocument1.UseVisualStyleBackColor = true;
            this.btnReleaseDocument1.Click += new System.EventHandler(this.btnReleaseDocument1_Click);
            // 
            // selectDocumentFD
            // 
            this.selectDocumentFD.Filter = "Pliki operacyjne (*.pdf, *.tiff, *.tif, *.jpg, *.jpeg)|*.pdf; *.tiff; *.tif; *.jp" +
    "g; *.jpeg";
            // 
            // frmEditDocumentFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(852, 441);
            this.Controls.Add(this.btnReleaseDocument1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbFile);
            this.Controls.Add(this.gbPreview);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(868, 480);
            this.Name = "frmEditDocumentFile";
            this.Text = "frmEditDocumentFile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbFile.ResumeLayout(false);
            this.gbFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPreview;
        private System.Windows.Forms.GroupBox gbFile;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReleaseDocument;
        private System.Windows.Forms.Button btnReleaseDocument1;
        private System.Windows.Forms.OpenFileDialog selectDocumentFD;
    }
}