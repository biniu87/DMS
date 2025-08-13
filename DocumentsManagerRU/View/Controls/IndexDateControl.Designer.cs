namespace DocumentsManagerRU.Controls
{
    partial class IndexDateControl
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dtpIndexDate = new System.Windows.Forms.DateTimePicker();
            this.lblRequired = new System.Windows.Forms.Label();
            this.chkEnabled = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
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
            // dtpIndexDate
            // 
            this.dtpIndexDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpIndexDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIndexDate.Location = new System.Drawing.Point(175, 4);
            this.dtpIndexDate.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.dtpIndexDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpIndexDate.Name = "dtpIndexDate";
            this.dtpIndexDate.Size = new System.Drawing.Size(148, 21);
            this.dtpIndexDate.TabIndex = 1;
            this.dtpIndexDate.Value = new System.DateTime(2016, 9, 6, 0, 0, 0, 0);
            // 
            // lblRequired
            // 
            this.lblRequired.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRequired.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRequired.ForeColor = System.Drawing.Color.Red;
            this.lblRequired.Location = new System.Drawing.Point(403, 0);
            this.lblRequired.Margin = new System.Windows.Forms.Padding(0);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(85, 30);
            this.lblRequired.TabIndex = 3;
            this.lblRequired.Text = "* Required";
            this.lblRequired.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkEnabled
            // 
            this.chkEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkEnabled.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkEnabled.Checked = true;
            this.chkEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnabled.Image = global::DocumentsManagerRU.Properties.Resources.check_2x;
            this.chkEnabled.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkEnabled.Location = new System.Drawing.Point(327, 4);
            this.chkEnabled.Margin = new System.Windows.Forms.Padding(4, 4, 20, 5);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(56, 21);
            this.chkEnabled.TabIndex = 2;
            this.chkEnabled.UseVisualStyleBackColor = true;
            this.chkEnabled.CheckedChanged += new System.EventHandler(this.chkEnabled_CheckedChanged);
            // 
            // IndexDateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dtpIndexDate);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.chkEnabled);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "IndexDateControl";
            this.Size = new System.Drawing.Size(488, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dtpIndexDate;
        private System.Windows.Forms.CheckBox chkEnabled;
        private System.Windows.Forms.Label lblRequired;
    }
}
