namespace DocumentsManagerRU
{
    partial class frmAddClass
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
            this.gbClass = new System.Windows.Forms.GroupBox();
            this.txtNameRU = new System.Windows.Forms.TextBox();
            this.lblNameRU = new System.Windows.Forms.Label();
            this.txtDescriptionRU = new System.Windows.Forms.TextBox();
            this.lblDescriptionRU = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescriptionPL1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNamePL1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.gbClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbClass
            // 
            this.gbClass.Controls.Add(this.txtDescription);
            this.gbClass.Controls.Add(this.lblDescriptionPL1);
            this.gbClass.Controls.Add(this.txtName);
            this.gbClass.Controls.Add(this.lblNamePL1);
            this.gbClass.Location = new System.Drawing.Point(12, 12);
            this.gbClass.Name = "gbClass";
            this.gbClass.Size = new System.Drawing.Size(492, 86);
            this.gbClass.TabIndex = 0;
            this.gbClass.TabStop = false;
            this.gbClass.Text = "gbClass";
            // 
            // txtNameRU
            // 
            this.txtNameRU.Location = new System.Drawing.Point(87, 104);
            this.txtNameRU.MaxLength = 50;
            this.txtNameRU.Name = "txtNameRU";
            this.txtNameRU.Size = new System.Drawing.Size(30, 21);
            this.txtNameRU.TabIndex = 3;
            this.txtNameRU.Visible = false;
            // 
            // lblNameRU
            // 
            this.lblNameRU.Location = new System.Drawing.Point(46, 107);
            this.lblNameRU.Name = "lblNameRU";
            this.lblNameRU.Size = new System.Drawing.Size(35, 20);
            this.lblNameRU.TabIndex = 2;
            this.lblNameRU.Text = "lblNameRU";
            this.lblNameRU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNameRU.Visible = false;
            // 
            // txtDescriptionRU
            // 
            this.txtDescriptionRU.Location = new System.Drawing.Point(172, 104);
            this.txtDescriptionRU.MaxLength = 100;
            this.txtDescriptionRU.Name = "txtDescriptionRU";
            this.txtDescriptionRU.Size = new System.Drawing.Size(23, 21);
            this.txtDescriptionRU.TabIndex = 7;
            this.txtDescriptionRU.Visible = false;
            // 
            // lblDescriptionRU
            // 
            this.lblDescriptionRU.Location = new System.Drawing.Point(123, 105);
            this.lblDescriptionRU.Name = "lblDescriptionRU";
            this.lblDescriptionRU.Size = new System.Drawing.Size(43, 20);
            this.lblDescriptionRU.TabIndex = 6;
            this.lblDescriptionRU.Text = "lblDescriptionRU";
            this.lblDescriptionRU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDescriptionRU.Visible = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(132, 46);
            this.txtDescription.MaxLength = 100;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(333, 21);
            this.txtDescription.TabIndex = 5;
            // 
            // lblDescriptionPL1
            // 
            this.lblDescriptionPL1.Location = new System.Drawing.Point(6, 46);
            this.lblDescriptionPL1.Name = "lblDescriptionPL1";
            this.lblDescriptionPL1.Size = new System.Drawing.Size(120, 20);
            this.lblDescriptionPL1.TabIndex = 4;
            this.lblDescriptionPL1.Text = "lblDescriptionPL1";
            this.lblDescriptionPL1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 19);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(333, 21);
            this.txtName.TabIndex = 1;
            // 
            // lblNamePL1
            // 
            this.lblNamePL1.Location = new System.Drawing.Point(6, 19);
            this.lblNamePL1.Name = "lblNamePL1";
            this.lblNamePL1.Size = new System.Drawing.Size(120, 20);
            this.lblNamePL1.TabIndex = 0;
            this.lblNamePL1.Text = "lblNamePL1";
            this.lblNamePL1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::DocumentsManagerRU.Properties.Resources.circle_x_2x;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(343, 104);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 28);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddClass
            // 
            this.btnAddClass.Image = global::DocumentsManagerRU.Properties.Resources.circle_check_2x;
            this.btnAddClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddClass.Location = new System.Drawing.Point(201, 104);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(134, 28);
            this.btnAddClass.TabIndex = 1;
            this.btnAddClass.Text = "btnAddClass";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // frmAddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(516, 142);
            this.Controls.Add(this.txtNameRU);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.lblNameRU);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtDescriptionRU);
            this.Controls.Add(this.lblDescriptionRU);
            this.Controls.Add(this.gbClass);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddClass";
            this.gbClass.ResumeLayout(false);
            this.gbClass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbClass;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescriptionPL1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNamePL1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.TextBox txtNameRU;
        private System.Windows.Forms.Label lblNameRU;
        private System.Windows.Forms.TextBox txtDescriptionRU;
        private System.Windows.Forms.Label lblDescriptionRU;
    }
}