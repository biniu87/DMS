namespace DocumentsManagerRU.View.Controls
{
    partial class ucSectionControlNotifications
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
            this.tlpButtonsControl = new System.Windows.Forms.TableLayoutPanel();
            this.btnEmailOnRelease = new System.Windows.Forms.Button();
            this.btnCanRelease = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tlpButtonsControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpButtonsControl
            // 
            this.tlpButtonsControl.ColumnCount = 2;
            this.tlpButtonsControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtonsControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtonsControl.Controls.Add(this.btnEmailOnRelease, 1, 0);
            this.tlpButtonsControl.Controls.Add(this.btnCanRelease, 0, 0);
            this.tlpButtonsControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpButtonsControl.Location = new System.Drawing.Point(0, 25);
            this.tlpButtonsControl.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButtonsControl.Name = "tlpButtonsControl";
            this.tlpButtonsControl.RowCount = 1;
            this.tlpButtonsControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtonsControl.Size = new System.Drawing.Size(200, 27);
            this.tlpButtonsControl.TabIndex = 3;
            // 
            // btnEmailOnRelease
            // 
            this.btnEmailOnRelease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmailOnRelease.FlatAppearance.BorderSize = 0;
            this.btnEmailOnRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmailOnRelease.Image = global::DocumentsManagerRU.Properties.Resources.envelope_closed_2x;
            this.btnEmailOnRelease.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEmailOnRelease.Location = new System.Drawing.Point(100, 0);
            this.btnEmailOnRelease.Margin = new System.Windows.Forms.Padding(0);
            this.btnEmailOnRelease.Name = "btnEmailOnRelease";
            this.btnEmailOnRelease.Size = new System.Drawing.Size(100, 27);
            this.btnEmailOnRelease.TabIndex = 3;
            this.btnEmailOnRelease.UseVisualStyleBackColor = true;
            // 
            // btnCanRelease
            // 
            this.btnCanRelease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCanRelease.FlatAppearance.BorderSize = 0;
            this.btnCanRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanRelease.Image = global::DocumentsManagerRU.Properties.Resources.paperclip_2x;
            this.btnCanRelease.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCanRelease.Location = new System.Drawing.Point(0, 0);
            this.btnCanRelease.Margin = new System.Windows.Forms.Padding(0);
            this.btnCanRelease.Name = "btnCanRelease";
            this.btnCanRelease.Size = new System.Drawing.Size(100, 27);
            this.btnCanRelease.TabIndex = 3;
            this.btnCanRelease.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "lblTitle";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucSectionControlNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tlpButtonsControl);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucSectionControlNotifications";
            this.Size = new System.Drawing.Size(200, 52);
            this.tlpButtonsControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpButtonsControl;
        private System.Windows.Forms.Button btnEmailOnRelease;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCanRelease;
    }
}
