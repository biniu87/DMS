namespace DocumentsManagerRU
{
    partial class frmAddDocument
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
            this.gbDocument = new System.Windows.Forms.GroupBox();
            this.assignDocumentControl = new DocumentsManagerRU.View.Controls.Interfaces.AssignDocumentControl();
            this.pnlDocumentIndex = new System.Windows.Forms.Panel();
            this.btnReleaseDocument1 = new System.Windows.Forms.Button();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.cbsDocumentClass = new System.Windows.Forms.BindingSource(this.components);
            this.iTDataSet = new DocumentsManagerRU.ITDataSet();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtDocumentName = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnReleaseDocument = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.selectDocumentFD = new System.Windows.Forms.OpenFileDialog();
            this.taDocument_Class = new DocumentsManagerRU.ITDataSetTableAdapters.Document_ClassTableAdapter();
            this.gbPreview = new System.Windows.Forms.GroupBox();
            this.gbDocument.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbsDocumentClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDocument
            // 
            this.gbDocument.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbDocument.Controls.Add(this.assignDocumentControl);
            this.gbDocument.Controls.Add(this.pnlDocumentIndex);
            this.gbDocument.Controls.Add(this.btnReleaseDocument1);
            this.gbDocument.Controls.Add(this.btnChooseFile);
            this.gbDocument.Controls.Add(this.cbClass);
            this.gbDocument.Controls.Add(this.txtDescription);
            this.gbDocument.Controls.Add(this.lblDescription);
            this.gbDocument.Controls.Add(this.txtFilePath);
            this.gbDocument.Controls.Add(this.txtDocumentName);
            this.gbDocument.Controls.Add(this.lblClass);
            this.gbDocument.Controls.Add(this.lblFile);
            this.gbDocument.Controls.Add(this.lblName);
            this.gbDocument.Location = new System.Drawing.Point(12, 12);
            this.gbDocument.Name = "gbDocument";
            this.gbDocument.Size = new System.Drawing.Size(622, 558);
            this.gbDocument.TabIndex = 0;
            this.gbDocument.TabStop = false;
            this.gbDocument.Text = "gbDocument";
            // 
            // assignDocumentControl
            // 
            this.assignDocumentControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assignDocumentControl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.assignDocumentControl.Location = new System.Drawing.Point(9, 125);
            this.assignDocumentControl.Margin = new System.Windows.Forms.Padding(0);
            this.assignDocumentControl.Name = "assignDocumentControl";
            this.assignDocumentControl.Size = new System.Drawing.Size(588, 51);
            this.assignDocumentControl.TabIndex = 9;
            // 
            // pnlDocumentIndex
            // 
            this.pnlDocumentIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDocumentIndex.Location = new System.Drawing.Point(6, 213);
            this.pnlDocumentIndex.Name = "pnlDocumentIndex";
            this.pnlDocumentIndex.Size = new System.Drawing.Size(608, 335);
            this.pnlDocumentIndex.TabIndex = 10;
            // 
            // btnReleaseDocument1
            // 
            this.btnReleaseDocument1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReleaseDocument1.Image = global::DocumentsManagerRU.Properties.Resources.circle_check_2x;
            this.btnReleaseDocument1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReleaseDocument1.Location = new System.Drawing.Point(136, 179);
            this.btnReleaseDocument1.Name = "btnReleaseDocument1";
            this.btnReleaseDocument1.Size = new System.Drawing.Size(461, 28);
            this.btnReleaseDocument1.TabIndex = 1;
            this.btnReleaseDocument1.Text = "Zwolnij dokument";
            this.btnReleaseDocument1.UseVisualStyleBackColor = true;
            this.btnReleaseDocument1.Click += new System.EventHandler(this.btnAddDocument_Click);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseFile.Image = global::DocumentsManagerRU.Properties.Resources.paperclip_4x;
            this.btnChooseFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChooseFile.Location = new System.Drawing.Point(439, 16);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(158, 49);
            this.btnChooseFile.TabIndex = 4;
            this.btnChooseFile.Text = "btnChooseFile";
            this.btnChooseFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // cbClass
            // 
            this.cbClass.DataSource = this.cbsDocumentClass;
            this.cbClass.DisplayMember = "CurrentName";
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(136, 16);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(297, 21);
            this.cbClass.TabIndex = 1;
            this.cbClass.ValueMember = "Id";
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbsDocumentClass
            // 
            this.cbsDocumentClass.DataMember = "Document_Class";
            this.cbsDocumentClass.DataSource = this.iTDataSet;
            // 
            // iTDataSet
            // 
            this.iTDataSet.DataSetName = "ITDataSet";
            this.iTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(136, 98);
            this.txtDescription.MaxLength = 255;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(461, 21);
            this.txtDescription.TabIndex = 8;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(6, 97);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(120, 20);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "lblDescription";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePath.Location = new System.Drawing.Point(136, 71);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(461, 21);
            this.txtFilePath.TabIndex = 6;
            // 
            // txtDocumentName
            // 
            this.txtDocumentName.Location = new System.Drawing.Point(136, 44);
            this.txtDocumentName.MaxLength = 127;
            this.txtDocumentName.Name = "txtDocumentName";
            this.txtDocumentName.Size = new System.Drawing.Size(297, 21);
            this.txtDocumentName.TabIndex = 3;
            this.txtDocumentName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDocumentName_KeyDown);
            // 
            // lblClass
            // 
            this.lblClass.Location = new System.Drawing.Point(6, 16);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(120, 21);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "lblClass";
            this.lblClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFile
            // 
            this.lblFile.Location = new System.Drawing.Point(6, 71);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(120, 20);
            this.lblFile.TabIndex = 5;
            this.lblFile.Text = "lblFile";
            this.lblFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(6, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(120, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "lblName";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnReleaseDocument
            // 
            this.btnReleaseDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReleaseDocument.Image = global::DocumentsManagerRU.Properties.Resources.circle_check_2x;
            this.btnReleaseDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReleaseDocument.Location = new System.Drawing.Point(951, 576);
            this.btnReleaseDocument.Name = "btnReleaseDocument";
            this.btnReleaseDocument.Size = new System.Drawing.Size(158, 28);
            this.btnReleaseDocument.TabIndex = 1;
            this.btnReleaseDocument.Text = "btnReleaseDocument";
            this.btnReleaseDocument.UseVisualStyleBackColor = true;
            this.btnReleaseDocument.Click += new System.EventHandler(this.btnAddDocument_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::DocumentsManagerRU.Properties.Resources.circle_x_2x;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(1115, 576);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(158, 28);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // selectDocumentFD
            // 
            this.selectDocumentFD.Filter = "Pliki operacyjne (*.pdf, *.tiff, *.tif, *.jpg, *.jpeg)|*.pdf; *.tiff; *.tif; *.jp" +
    "g; *.jpeg";
            // 
            // taDocument_Class
            // 
            this.taDocument_Class.ClearBeforeFill = true;
            // 
            // gbPreview
            // 
            this.gbPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPreview.Location = new System.Drawing.Point(640, 12);
            this.gbPreview.Name = "gbPreview";
            this.gbPreview.Size = new System.Drawing.Size(649, 558);
            this.gbPreview.TabIndex = 3;
            this.gbPreview.TabStop = false;
            this.gbPreview.Text = "gbPreview";
            // 
            // frmAddDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1301, 610);
            this.Controls.Add(this.gbPreview);
            this.Controls.Add(this.btnReleaseDocument);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbDocument);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "frmAddDocument";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddDocument";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddDocument_FormClosed);
            this.Load += new System.EventHandler(this.AddDocumentForm_Load);
            this.gbDocument.ResumeLayout(false);
            this.gbDocument.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbsDocumentClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDocument;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtDocumentName;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReleaseDocument;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.BindingSource cbsDocumentClass;
        private System.Windows.Forms.OpenFileDialog selectDocumentFD;
        private ITDataSet iTDataSet;
        private ITDataSetTableAdapters.Document_ClassTableAdapter taDocument_Class;
        private System.Windows.Forms.Panel pnlDocumentIndex;
        private View.Controls.Interfaces.AssignDocumentControl assignDocumentControl;
        private System.Windows.Forms.GroupBox gbPreview;
        private System.Windows.Forms.Button btnReleaseDocument1;
        //private ITDataSetTableAdapters.Document_ContractorTableAdapter document_ContractorTableAdapter;
    }
}