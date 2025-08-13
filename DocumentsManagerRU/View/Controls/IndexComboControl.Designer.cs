namespace DocumentsManagerRU.Controls
{
    partial class IndexComboControl
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
            this.lblRequired = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbValue1 = new DocumentsManagerRU.Controls.ContainsComboBox();
            this.SuspendLayout();
            // 
            // lblRequired
            // 
            this.lblRequired.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRequired.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRequired.ForeColor = System.Drawing.Color.Red;
            this.lblRequired.Location = new System.Drawing.Point(277, 0);
            this.lblRequired.Margin = new System.Windows.Forms.Padding(0);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(85, 30);
            this.lblRequired.TabIndex = 2;
            this.lblRequired.Text = "* Required";
            this.lblRequired.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(172, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "lblTitle";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbValue1
            // 
            this.cbValue1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbValue1.DataSource = null;
            this.cbValue1.DisplayMember = "Value";
            this.cbValue1.FormattingEnabled = true;
            this.cbValue1.Location = new System.Drawing.Point(175, 4);
            this.cbValue1.Margin = new System.Windows.Forms.Padding(0, 4, 20, 4);
            this.cbValue1.Name = "cbValue1";
            this.cbValue1.SelectedValue = -2147483648;
            this.cbValue1.Size = new System.Drawing.Size(82, 21);
            this.cbValue1.TabIndex = 1;
            this.cbValue1.ValueMember = "Key";
            // 
            // IndexComboControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cbValue1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "IndexComboControl";
            this.Size = new System.Drawing.Size(362, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Label lblTitle;
        private DocumentsManagerRU.Controls.ContainsComboBox cbValue1;
    }
}
