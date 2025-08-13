namespace DocumentsManagerRU.View.Controls
{
    partial class ExtendedRadioControl
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
            this.tlpRadios = new System.Windows.Forms.TableLayoutPanel();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.tlpRadios.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpRadios
            // 
            this.tlpRadios.ColumnCount = 2;
            this.tlpRadios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRadios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRadios.Controls.Add(this.rbNo, 0, 0);
            this.tlpRadios.Controls.Add(this.rbYes, 1, 0);
            this.tlpRadios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRadios.Location = new System.Drawing.Point(0, 0);
            this.tlpRadios.Margin = new System.Windows.Forms.Padding(0);
            this.tlpRadios.Name = "tlpRadios";
            this.tlpRadios.RowCount = 1;
            this.tlpRadios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRadios.Size = new System.Drawing.Size(85, 30);
            this.tlpRadios.TabIndex = 3;
            // 
            // rbNo
            // 
            this.rbNo.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbNo.AutoSize = true;
            this.rbNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbNo.Location = new System.Drawing.Point(0, 0);
            this.rbNo.Margin = new System.Windows.Forms.Padding(0);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(42, 30);
            this.rbNo.TabIndex = 0;
            this.rbNo.Text = "NO";
            this.rbNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbNo.UseVisualStyleBackColor = true;
            this.rbNo.CheckedChanged += new System.EventHandler(this.rbNoYes_CheckedChanged);
            // 
            // rbYes
            // 
            this.rbYes.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbYes.AutoSize = true;
            this.rbYes.Checked = true;
            this.rbYes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbYes.Location = new System.Drawing.Point(42, 0);
            this.rbYes.Margin = new System.Windows.Forms.Padding(0);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(43, 30);
            this.rbYes.TabIndex = 1;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "YES";
            this.rbYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // ExtendedRadioControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpRadios);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "ExtendedRadioControl";
            this.Size = new System.Drawing.Size(85, 30);
            this.tlpRadios.ResumeLayout(false);
            this.tlpRadios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRadios;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
    }
}
