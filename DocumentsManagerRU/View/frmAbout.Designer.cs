namespace DocumentsManagerRU.View
{
    partial class frmAbout
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
            this.lblApp = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.lblPreIcon = new System.Windows.Forms.Label();
            this.lblTestInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblApp
            // 
            this.lblApp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblApp.Location = new System.Drawing.Point(-4, 48);
            this.lblApp.Margin = new System.Windows.Forms.Padding(0);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(270, 31);
            this.lblApp.TabIndex = 2;
            this.lblApp.Text = "lblApp";
            this.lblApp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompany
            // 
            this.lblCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompany.Location = new System.Drawing.Point(-3, 79);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(270, 31);
            this.lblCompany.TabIndex = 3;
            this.lblCompany.Text = "lblCompany";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel1
            // 
            this.btnCancel1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancel1.Image = global::DocumentsManagerRU.Properties.Resources.circle_x_2x;
            this.btnCancel1.Location = new System.Drawing.Point(0, 166);
            this.btnCancel1.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(358, 27);
            this.btnCancel1.TabIndex = 1;
            this.btnCancel1.UseVisualStyleBackColor = true;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click);
            // 
            // lblPreIcon
            // 
            this.lblPreIcon.Image = null;
            this.lblPreIcon.Location = new System.Drawing.Point(271, 48);
            this.lblPreIcon.Margin = new System.Windows.Forms.Padding(0);
            this.lblPreIcon.Name = "lblPreIcon";
            this.lblPreIcon.Size = new System.Drawing.Size(91, 75);
            this.lblPreIcon.TabIndex = 4;
            // 
            // lblTestInfo
            // 
            this.lblTestInfo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTestInfo.ForeColor = System.Drawing.Color.Red;
            this.lblTestInfo.Location = new System.Drawing.Point(12, 9);
            this.lblTestInfo.Name = "lblTestInfo";
            this.lblTestInfo.Size = new System.Drawing.Size(255, 39);
            this.lblTestInfo.TabIndex = 5;
            this.lblTestInfo.Text = "SYSTEM TESTOWY";
            this.lblTestInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel1;
            this.ClientSize = new System.Drawing.Size(358, 193);
            this.ControlBox = false;
            this.Controls.Add(this.lblTestInfo);
            this.Controls.Add(this.lblPreIcon);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblApp);
            this.Controls.Add(this.btnCancel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblPreIcon;
        private System.Windows.Forms.Label lblTestInfo;
    }
}