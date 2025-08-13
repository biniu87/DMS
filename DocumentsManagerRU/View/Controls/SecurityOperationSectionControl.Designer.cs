namespace DocumentsManagerRU.View.Controls
{
    partial class SecurityOperationSectionControl
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
            this.btnSecurityOperationNone = new System.Windows.Forms.Button();
            this.btnSecurityOperationOnlyWith = new System.Windows.Forms.Button();
            this.btnSecurityOperationFull = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tlpButtonsControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpButtonsControl
            // 
            this.tlpButtonsControl.ColumnCount = 3;
            this.tlpButtonsControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButtonsControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButtonsControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButtonsControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpButtonsControl.Controls.Add(this.btnSecurityOperationNone, 0, 0);
            this.tlpButtonsControl.Controls.Add(this.btnSecurityOperationOnlyWith, 1, 0);
            this.tlpButtonsControl.Controls.Add(this.btnSecurityOperationFull, 2, 0);
            this.tlpButtonsControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpButtonsControl.Location = new System.Drawing.Point(0, 25);
            this.tlpButtonsControl.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButtonsControl.Name = "tlpButtonsControl";
            this.tlpButtonsControl.RowCount = 1;
            this.tlpButtonsControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtonsControl.Size = new System.Drawing.Size(150, 27);
            this.tlpButtonsControl.TabIndex = 3;
            // 
            // btnSecurityOperationNone
            // 
            this.btnSecurityOperationNone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSecurityOperationNone.FlatAppearance.BorderSize = 0;
            this.btnSecurityOperationNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecurityOperationNone.Image = global::DocumentsManagerRU.Properties.Resources.lock_locked_2x;
            this.btnSecurityOperationNone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSecurityOperationNone.Location = new System.Drawing.Point(0, 0);
            this.btnSecurityOperationNone.Margin = new System.Windows.Forms.Padding(0);
            this.btnSecurityOperationNone.Name = "btnSecurityOperationNone";
            this.btnSecurityOperationNone.Size = new System.Drawing.Size(50, 27);
            this.btnSecurityOperationNone.TabIndex = 0;
            this.btnSecurityOperationNone.UseVisualStyleBackColor = true;
            // 
            // btnSecurityOperationOnlyWith
            // 
            this.btnSecurityOperationOnlyWith.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSecurityOperationOnlyWith.FlatAppearance.BorderSize = 0;
            this.btnSecurityOperationOnlyWith.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecurityOperationOnlyWith.Image = global::DocumentsManagerRU.Properties.Resources.eye_2x;
            this.btnSecurityOperationOnlyWith.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSecurityOperationOnlyWith.Location = new System.Drawing.Point(50, 0);
            this.btnSecurityOperationOnlyWith.Margin = new System.Windows.Forms.Padding(0);
            this.btnSecurityOperationOnlyWith.Name = "btnSecurityOperationOnlyWith";
            this.btnSecurityOperationOnlyWith.Size = new System.Drawing.Size(50, 27);
            this.btnSecurityOperationOnlyWith.TabIndex = 1;
            this.btnSecurityOperationOnlyWith.UseVisualStyleBackColor = true;
            // 
            // btnSecurityOperationFull
            // 
            this.btnSecurityOperationFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSecurityOperationFull.FlatAppearance.BorderSize = 0;
            this.btnSecurityOperationFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecurityOperationFull.Image = global::DocumentsManagerRU.Properties.Resources.infinity_2x;
            this.btnSecurityOperationFull.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSecurityOperationFull.Location = new System.Drawing.Point(100, 0);
            this.btnSecurityOperationFull.Margin = new System.Windows.Forms.Padding(0);
            this.btnSecurityOperationFull.Name = "btnSecurityOperationFull";
            this.btnSecurityOperationFull.Size = new System.Drawing.Size(50, 27);
            this.btnSecurityOperationFull.TabIndex = 2;
            this.btnSecurityOperationFull.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "lblTitle";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecurityOperationSectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tlpButtonsControl);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SecurityOperationSectionControl";
            this.Size = new System.Drawing.Size(150, 52);
            this.tlpButtonsControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpButtonsControl;
        private System.Windows.Forms.Button btnSecurityOperationNone;
        private System.Windows.Forms.Button btnSecurityOperationFull;
        private System.Windows.Forms.Button btnSecurityOperationOnlyWith;
        private System.Windows.Forms.Label lblTitle;
    }
}
