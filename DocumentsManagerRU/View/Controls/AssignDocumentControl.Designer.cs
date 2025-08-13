namespace DocumentsManagerRU.View.Controls.Interfaces
{
    partial class AssignDocumentControl
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
            this.lblAssignDocument = new System.Windows.Forms.Label();
            this.lblAssignClass = new System.Windows.Forms.Label();
            this.btnClearAssign = new System.Windows.Forms.Button();
            this.lblClassCount = new System.Windows.Forms.Label();
            this.lblDocumentCount = new System.Windows.Forms.Label();
            this.cbDocument = new DocumentsManagerRU.Controls.ContainsComboBox64();
            this.cbClass = new DocumentsManagerRU.Controls.ContainsComboBox();
            this.SuspendLayout();
            // 
            // lblAssignDocument
            // 
            this.lblAssignDocument.Location = new System.Drawing.Point(0, 26);
            this.lblAssignDocument.Name = "lblAssignDocument";
            this.lblAssignDocument.Size = new System.Drawing.Size(120, 21);
            this.lblAssignDocument.TabIndex = 3;
            this.lblAssignDocument.Text = "lblAssignDocument";
            this.lblAssignDocument.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAssignClass
            // 
            this.lblAssignClass.Location = new System.Drawing.Point(0, 0);
            this.lblAssignClass.Name = "lblAssignClass";
            this.lblAssignClass.Size = new System.Drawing.Size(120, 21);
            this.lblAssignClass.TabIndex = 0;
            this.lblAssignClass.Text = "lblAssignClass";
            this.lblAssignClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClearAssign
            // 
            this.btnClearAssign.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClearAssign.Image = global::DocumentsManagerRU.Properties.Resources.circle_x_2x;
            this.btnClearAssign.Location = new System.Drawing.Point(572, 0);
            this.btnClearAssign.Name = "btnClearAssign";
            this.btnClearAssign.Size = new System.Drawing.Size(30, 49);
            this.btnClearAssign.TabIndex = 6;
            this.btnClearAssign.UseVisualStyleBackColor = true;
            this.btnClearAssign.Click += new System.EventHandler(this.btnClearAssign_Click);
            // 
            // lblClassCount
            // 
            this.lblClassCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClassCount.Location = new System.Drawing.Point(525, 0);
            this.lblClassCount.Name = "lblClassCount";
            this.lblClassCount.Size = new System.Drawing.Size(41, 21);
            this.lblClassCount.TabIndex = 2;
            this.lblClassCount.Text = "(0)";
            this.lblClassCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDocumentCount
            // 
            this.lblDocumentCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDocumentCount.Location = new System.Drawing.Point(525, 26);
            this.lblDocumentCount.Name = "lblDocumentCount";
            this.lblDocumentCount.Size = new System.Drawing.Size(41, 21);
            this.lblDocumentCount.TabIndex = 5;
            this.lblDocumentCount.Text = "(0)";
            this.lblDocumentCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbDocument
            // 
            this.cbDocument.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDocument.DataSource = null;
            this.cbDocument.DisplayMember = "Value";
            this.cbDocument.FormattingEnabled = true;
            this.cbDocument.Location = new System.Drawing.Point(126, 27);
            this.cbDocument.Name = "cbDocument";
            this.cbDocument.SelectedValue = ((long)(-2147483648));
            this.cbDocument.Size = new System.Drawing.Size(373, 21);
            this.cbDocument.TabIndex = 4;
            this.cbDocument.ValueMember = "Key";
            this.cbDocument.TextChanged += new System.EventHandler(this.cbDocument_TextChanged);
            // 
            // cbClass
            // 
            this.cbClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbClass.DataSource = null;
            this.cbClass.DisplayMember = "Value";
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(126, 0);
            this.cbClass.Name = "cbClass";
            this.cbClass.SelectedValue = -2147483648;
            this.cbClass.Size = new System.Drawing.Size(373, 21);
            this.cbClass.TabIndex = 1;
            this.cbClass.ValueMember = "Key";
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            this.cbClass.SelectedValueChanged += new System.EventHandler(this.cbClass_SelectedValueChanged);
            // 
            // AssignDocumentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblClassCount);
            this.Controls.Add(this.btnClearAssign);
            this.Controls.Add(this.cbDocument);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.lblDocumentCount);
            this.Controls.Add(this.lblAssignDocument);
            this.Controls.Add(this.lblAssignClass);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "AssignDocumentControl";
            this.Size = new System.Drawing.Size(602, 49);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAssignDocument;
        private System.Windows.Forms.Label lblAssignClass;
        private DocumentsManagerRU.Controls.ContainsComboBox cbClass;
        private DocumentsManagerRU.Controls.ContainsComboBox64 cbDocument;
        private System.Windows.Forms.Button btnClearAssign;
        private System.Windows.Forms.Label lblClassCount;
        private System.Windows.Forms.Label lblDocumentCount;
    }
}
