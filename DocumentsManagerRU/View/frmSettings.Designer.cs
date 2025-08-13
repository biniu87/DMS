namespace DocumentsManagerRU
{
    partial class frmSettings
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
            this.lblDeleting = new System.Windows.Forms.Label();
            this.lblServerPath = new System.Windows.Forms.Label();
            this.txtCurrentServerPath = new System.Windows.Forms.TextBox();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.btnSavePath = new System.Windows.Forms.Button();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.lblNewServerPath = new System.Windows.Forms.Label();
            this.txtNewServerPath = new System.Windows.Forms.TextBox();
            this.lblUseExternalViewer = new System.Windows.Forms.Label();
            this.lblEmailOnRelease = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ercUseExternalViewer = new DocumentsManagerRU.View.Controls.ExtendedRadioControl();
            this.ercMailOnRelease = new DocumentsManagerRU.View.Controls.ExtendedRadioControl();
            this.ercDelete = new DocumentsManagerRU.View.Controls.ExtendedRadioControl();
            this.gbSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeleting
            // 
            this.lblDeleting.Location = new System.Drawing.Point(6, 80);
            this.lblDeleting.Name = "lblDeleting";
            this.lblDeleting.Size = new System.Drawing.Size(164, 27);
            this.lblDeleting.TabIndex = 3;
            this.lblDeleting.Text = "lblDeleting";
            this.lblDeleting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblServerPath
            // 
            this.lblServerPath.Location = new System.Drawing.Point(6, 17);
            this.lblServerPath.Name = "lblServerPath";
            this.lblServerPath.Size = new System.Drawing.Size(164, 27);
            this.lblServerPath.TabIndex = 0;
            this.lblServerPath.Text = "lblServerPath";
            this.lblServerPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCurrentServerPath
            // 
            this.txtCurrentServerPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentServerPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentServerPath.Location = new System.Drawing.Point(176, 17);
            this.txtCurrentServerPath.Multiline = true;
            this.txtCurrentServerPath.Name = "txtCurrentServerPath";
            this.txtCurrentServerPath.ReadOnly = true;
            this.txtCurrentServerPath.Size = new System.Drawing.Size(461, 27);
            this.txtCurrentServerPath.TabIndex = 1;
            // 
            // gbSettings
            // 
            this.gbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSettings.Controls.Add(this.btnSavePath);
            this.gbSettings.Controls.Add(this.btnChooseFolder);
            this.gbSettings.Controls.Add(this.ercUseExternalViewer);
            this.gbSettings.Controls.Add(this.ercMailOnRelease);
            this.gbSettings.Controls.Add(this.ercDelete);
            this.gbSettings.Controls.Add(this.lblNewServerPath);
            this.gbSettings.Controls.Add(this.lblServerPath);
            this.gbSettings.Controls.Add(this.txtNewServerPath);
            this.gbSettings.Controls.Add(this.txtCurrentServerPath);
            this.gbSettings.Controls.Add(this.lblUseExternalViewer);
            this.gbSettings.Controls.Add(this.lblEmailOnRelease);
            this.gbSettings.Controls.Add(this.lblDeleting);
            this.gbSettings.Location = new System.Drawing.Point(12, 12);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(714, 181);
            this.gbSettings.TabIndex = 0;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "gbSettings";
            // 
            // btnSavePath
            // 
            this.btnSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSavePath.FlatAppearance.BorderSize = 0;
            this.btnSavePath.Image = global::DocumentsManagerRU.Properties.Resources.check_2x;
            this.btnSavePath.Location = new System.Drawing.Point(640, 17);
            this.btnSavePath.Margin = new System.Windows.Forms.Padding(0);
            this.btnSavePath.Name = "btnSavePath";
            this.btnSavePath.Size = new System.Drawing.Size(71, 27);
            this.btnSavePath.TabIndex = 6;
            this.btnSavePath.UseVisualStyleBackColor = true;
            this.btnSavePath.Click += new System.EventHandler(this.btnSavePath_Click);
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseFolder.FlatAppearance.BorderSize = 0;
            this.btnChooseFolder.Image = global::DocumentsManagerRU.Properties.Resources.folder_2x;
            this.btnChooseFolder.Location = new System.Drawing.Point(640, 47);
            this.btnChooseFolder.Margin = new System.Windows.Forms.Padding(0);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(71, 27);
            this.btnChooseFolder.TabIndex = 5;
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // lblNewServerPath
            // 
            this.lblNewServerPath.Location = new System.Drawing.Point(6, 47);
            this.lblNewServerPath.Name = "lblNewServerPath";
            this.lblNewServerPath.Size = new System.Drawing.Size(164, 27);
            this.lblNewServerPath.TabIndex = 0;
            this.lblNewServerPath.Text = "lblNewServerPath";
            this.lblNewServerPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNewServerPath
            // 
            this.txtNewServerPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewServerPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewServerPath.Location = new System.Drawing.Point(176, 47);
            this.txtNewServerPath.Multiline = true;
            this.txtNewServerPath.Name = "txtNewServerPath";
            this.txtNewServerPath.Size = new System.Drawing.Size(461, 27);
            this.txtNewServerPath.TabIndex = 1;
            // 
            // lblUseExternalViewer
            // 
            this.lblUseExternalViewer.Location = new System.Drawing.Point(6, 146);
            this.lblUseExternalViewer.Name = "lblUseExternalViewer";
            this.lblUseExternalViewer.Size = new System.Drawing.Size(164, 27);
            this.lblUseExternalViewer.TabIndex = 3;
            this.lblUseExternalViewer.Text = "lblUseExternalViewer";
            this.lblUseExternalViewer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmailOnRelease
            // 
            this.lblEmailOnRelease.Location = new System.Drawing.Point(6, 113);
            this.lblEmailOnRelease.Name = "lblEmailOnRelease";
            this.lblEmailOnRelease.Size = new System.Drawing.Size(164, 27);
            this.lblEmailOnRelease.TabIndex = 3;
            this.lblEmailOnRelease.Text = "lblEmailOnRelease";
            this.lblEmailOnRelease.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::DocumentsManagerRU.Properties.Resources.circle_x_2x;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(586, 196);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 27);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ercUseExternalViewer
            // 
            this.ercUseExternalViewer.Checked = false;
            this.ercUseExternalViewer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ercUseExternalViewer.Location = new System.Drawing.Point(176, 146);
            this.ercUseExternalViewer.Name = "ercUseExternalViewer";
            this.ercUseExternalViewer.Size = new System.Drawing.Size(100, 27);
            this.ercUseExternalViewer.TabIndex = 4;
            this.ercUseExternalViewer.CheckedChanged += new System.EventHandler(this.ercUseExternalViewer_CheckedChanged);
            // 
            // ercMailOnRelease
            // 
            this.ercMailOnRelease.Checked = false;
            this.ercMailOnRelease.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ercMailOnRelease.Location = new System.Drawing.Point(176, 113);
            this.ercMailOnRelease.Name = "ercMailOnRelease";
            this.ercMailOnRelease.Size = new System.Drawing.Size(100, 27);
            this.ercMailOnRelease.TabIndex = 4;
            this.ercMailOnRelease.CheckedChanged += new System.EventHandler(this.ercMailOnRelease_CheckedChanged);
            // 
            // ercDelete
            // 
            this.ercDelete.Checked = false;
            this.ercDelete.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ercDelete.Location = new System.Drawing.Point(176, 80);
            this.ercDelete.Name = "ercDelete";
            this.ercDelete.Size = new System.Drawing.Size(100, 27);
            this.ercDelete.TabIndex = 4;
            this.ercDelete.CheckedChanged += new System.EventHandler(this.ercDelete_CheckedChanged);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(744, 227);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbSettings);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSettings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSettings_FormClosing);
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDeleting;
        private System.Windows.Forms.Label lblServerPath;
        private System.Windows.Forms.TextBox txtCurrentServerPath;
        private System.Windows.Forms.GroupBox gbSettings;
        private DocumentsManagerRU.View.Controls.ExtendedRadioControl ercDelete;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSavePath;
        private System.Windows.Forms.TextBox txtNewServerPath;
        private System.Windows.Forms.Label lblNewServerPath;
        private View.Controls.ExtendedRadioControl ercMailOnRelease;
        private System.Windows.Forms.Label lblEmailOnRelease;
        private View.Controls.ExtendedRadioControl ercUseExternalViewer;
        private System.Windows.Forms.Label lblUseExternalViewer;
    }
}