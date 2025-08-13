namespace DocumentsManagerRU
{
    partial class frmEditDocument
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
            this.components = new System.ComponentModel.Container();
            this.pnlDocumentIndex = new System.Windows.Forms.Panel();
            this.lblActive2 = new System.Windows.Forms.Label();
            this.bsDocuments = new System.Windows.Forms.BindingSource(this.components);
            this.iTDataSet = new DocumentsManagerRU.ITDataSet();
            this.txtDocumentName = new System.Windows.Forms.TextBox();
            this.lblClass2 = new System.Windows.Forms.Label();
            this.txtDocumentDescription = new System.Windows.Forms.TextBox();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.Label();
            this.lblDescription2 = new System.Windows.Forms.Label();
            this.gbDocumentInfo = new System.Windows.Forms.GroupBox();
            this.assignDocumentControl = new DocumentsManagerRU.View.Controls.Interfaces.AssignDocumentControl();
            this.ercActive = new DocumentsManagerRU.View.Controls.ExtendedRadioControl();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.taDocumentClass = new DocumentsManagerRU.ITDataSetTableAdapters.Document_ClassTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTDataSet)).BeginInit();
            this.gbDocumentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDocumentIndex
            // 
            this.pnlDocumentIndex.Location = new System.Drawing.Point(6, 205);
            this.pnlDocumentIndex.Name = "pnlDocumentIndex";
            this.pnlDocumentIndex.Size = new System.Drawing.Size(638, 236);
            this.pnlDocumentIndex.TabIndex = 13;
            // 
            // lblActive2
            // 
            this.lblActive2.Location = new System.Drawing.Point(6, 123);
            this.lblActive2.Name = "lblActive2";
            this.lblActive2.Size = new System.Drawing.Size(160, 24);
            this.lblActive2.TabIndex = 10;
            this.lblActive2.Text = "lblActive2";
            this.lblActive2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bsDocuments
            // 
            this.bsDocuments.DataMember = "Document_Class";
            this.bsDocuments.DataSource = this.iTDataSet;
            // 
            // iTDataSet
            // 
            this.iTDataSet.DataSetName = "ITDataSet";
            this.iTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDocumentName
            // 
            this.txtDocumentName.Location = new System.Drawing.Point(172, 44);
            this.txtDocumentName.MaxLength = 127;
            this.txtDocumentName.Name = "txtDocumentName";
            this.txtDocumentName.Size = new System.Drawing.Size(418, 21);
            this.txtDocumentName.TabIndex = 3;
            // 
            // lblClass2
            // 
            this.lblClass2.Location = new System.Drawing.Point(6, 16);
            this.lblClass2.Name = "lblClass2";
            this.lblClass2.Size = new System.Drawing.Size(160, 21);
            this.lblClass2.TabIndex = 0;
            this.lblClass2.Text = "lblClass2";
            this.lblClass2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDocumentDescription
            // 
            this.txtDocumentDescription.Location = new System.Drawing.Point(172, 71);
            this.txtDocumentDescription.MaxLength = 255;
            this.txtDocumentDescription.Name = "txtDocumentDescription";
            this.txtDocumentDescription.Size = new System.Drawing.Size(472, 21);
            this.txtDocumentDescription.TabIndex = 7;
            // 
            // cbClass
            // 
            this.cbClass.DataSource = this.bsDocuments;
            this.cbClass.DisplayMember = "CurrentName";
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(172, 17);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(418, 21);
            this.cbClass.TabIndex = 1;
            this.cbClass.ValueMember = "Id";
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbChangeClass_SelectedIndexChanged);
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.Location = new System.Drawing.Point(6, 98);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(160, 20);
            this.lblReleaseDate.TabIndex = 4;
            this.lblReleaseDate.Text = "lblReleaseDate";
            this.lblReleaseDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.Location = new System.Drawing.Point(172, 98);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(166, 21);
            this.dtpReleaseDate.TabIndex = 5;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(509, 101);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(35, 21);
            this.txtURL.TabIndex = 9;
            this.txtURL.Visible = false;
            // 
            // lblName2
            // 
            this.lblName2.Location = new System.Drawing.Point(6, 43);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(160, 20);
            this.lblName2.TabIndex = 2;
            this.lblName2.Text = "lblName2";
            this.lblName2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblURL
            // 
            this.lblURL.Location = new System.Drawing.Point(469, 102);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(40, 20);
            this.lblURL.TabIndex = 8;
            this.lblURL.Text = "lblURL";
            this.lblURL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblURL.Visible = false;
            // 
            // lblDescription2
            // 
            this.lblDescription2.Location = new System.Drawing.Point(6, 70);
            this.lblDescription2.Name = "lblDescription2";
            this.lblDescription2.Size = new System.Drawing.Size(160, 20);
            this.lblDescription2.TabIndex = 6;
            this.lblDescription2.Text = "lblDescription2";
            this.lblDescription2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbDocumentInfo
            // 
            this.gbDocumentInfo.Controls.Add(this.assignDocumentControl);
            this.gbDocumentInfo.Controls.Add(this.ercActive);
            this.gbDocumentInfo.Controls.Add(this.btnSave);
            this.gbDocumentInfo.Controls.Add(this.btnCancel);
            this.gbDocumentInfo.Controls.Add(this.pnlDocumentIndex);
            this.gbDocumentInfo.Controls.Add(this.lblActive2);
            this.gbDocumentInfo.Controls.Add(this.txtDocumentName);
            this.gbDocumentInfo.Controls.Add(this.lblClass2);
            this.gbDocumentInfo.Controls.Add(this.txtDocumentDescription);
            this.gbDocumentInfo.Controls.Add(this.cbClass);
            this.gbDocumentInfo.Controls.Add(this.lblReleaseDate);
            this.gbDocumentInfo.Controls.Add(this.dtpReleaseDate);
            this.gbDocumentInfo.Controls.Add(this.txtURL);
            this.gbDocumentInfo.Controls.Add(this.lblName2);
            this.gbDocumentInfo.Controls.Add(this.lblURL);
            this.gbDocumentInfo.Controls.Add(this.lblDescription2);
            this.gbDocumentInfo.Location = new System.Drawing.Point(12, 12);
            this.gbDocumentInfo.Name = "gbDocumentInfo";
            this.gbDocumentInfo.Size = new System.Drawing.Size(650, 482);
            this.gbDocumentInfo.TabIndex = 0;
            this.gbDocumentInfo.TabStop = false;
            this.gbDocumentInfo.Text = "gbDocumentInfo";
            // 
            // assignDocumentControl
            // 
            this.assignDocumentControl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.assignDocumentControl.Location = new System.Drawing.Point(46, 150);
            this.assignDocumentControl.Name = "assignDocumentControl";
            this.assignDocumentControl.Size = new System.Drawing.Size(598, 49);
            this.assignDocumentControl.TabIndex = 12;
            // 
            // ercActive
            // 
            this.ercActive.Checked = true;
            this.ercActive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ercActive.Location = new System.Drawing.Point(172, 123);
            this.ercActive.Name = "ercActive";
            this.ercActive.Size = new System.Drawing.Size(166, 24);
            this.ercActive.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::DocumentsManagerRU.Properties.Resources.circle_check_2x;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(322, 447);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(158, 28);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSaveDocument_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::DocumentsManagerRU.Properties.Resources.circle_x_2x;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(486, 447);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(158, 28);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // taDocumentClass
            // 
            this.taDocumentClass.ClearBeforeFill = true;
            // 
            // frmEditDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(670, 501);
            this.Controls.Add(this.gbDocumentInfo);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditDocument";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEditDocument";
            ((System.ComponentModel.ISupportInitialize)(this.bsDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTDataSet)).EndInit();
            this.gbDocumentInfo.ResumeLayout(false);
            this.gbDocumentInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDocumentIndex;
        private System.Windows.Forms.Label lblActive2;
        private System.Windows.Forms.BindingSource bsDocuments;
        private System.Windows.Forms.TextBox txtDocumentName;
        private System.Windows.Forms.Label lblClass2;
        private System.Windows.Forms.TextBox txtDocumentDescription;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label lblDescription2;
        private System.Windows.Forms.GroupBox gbDocumentInfo;
        private ITDataSet iTDataSet;
        private ITDataSetTableAdapters.Document_ClassTableAdapter taDocumentClass;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private DocumentsManagerRU.View.Controls.ExtendedRadioControl ercActive;
        private View.Controls.Interfaces.AssignDocumentControl assignDocumentControl;
    }
}