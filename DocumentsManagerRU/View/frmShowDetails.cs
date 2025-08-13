using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentsManagerRU.Controls;
using DocumentsManagerRU.ImpersonationClass;
using DocumentsManagerRU.View;

namespace DocumentsManagerRU
{
    public partial class frmDetails : Form
    {
        private IndexControl _indexControl;
        private DataShare _ds;
        private Document _currentDocument;
        private Document _primaryDocument;
        private Document_Class _currentClass;
        private Document_Class _primaryClass;

        public frmDetails(DataShare ds)
        {
            InitializeComponent();
            _ds = ds;
            this.Text = _ds.LocRM.GetString(this.Name);
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDetails_Load(object sender, EventArgs e)
        {
            btnCloseNoTitle.Select();
        }

        public void SetFields(Document doc, Document_Class docClass)
        {
            _currentDocument = doc;
            _currentClass = docClass;
            gbPrimaryObject.Enabled = false;
            //btnShowDetails.Enabled = btnShowDocument.Enabled = false;
            if (_currentDocument.AssignedClassId.HasValue)
            {
                _primaryClass = Data.GetClassById(_currentDocument.AssignedClassId.Value);
                txtClass.Text = _primaryClass.Name + " / " + _primaryClass.Name_RU;
                if (_currentDocument.AssignedDocumentId.HasValue)
                {
                    _primaryDocument = Data.GetDocumentById(_currentDocument.AssignedDocumentId.Value, _currentDocument.AssignedClassId.Value);
                    txtDocument.Text = _primaryDocument.Name;
                    //btnShowDetails.Enabled = btnShowDocument.Enabled = true;
                    gbPrimaryObject.Enabled = true;
                }
            }
            
            txtName.Text = docClass.Name;
            txtDescription.Text = docClass.Description;
            txtNameRU.Text = docClass.Name_RU;
            txtDescriptionRU.Text = docClass.Description_RU;
            txtName2.Text = doc.Name;
            txtDescription2.Text = doc.Description;
            txtURL.Text = doc.URL;
            txtFileSize.Text = GetFileSize(doc.URL);
            txtReleaseDate.Text = doc.Release_Date.Value.ToShortDateString();
            txtRelasedBy.Text = doc.Create_User;
            txtOriginalName.Text = doc.OldFileName;

            _indexControl = new IndexControl(doc.DocumentIndexes != null ? doc.DocumentIndexes.ToList() : null, _ds.LocRM, _ds.Language);
            _indexControl.Dock = DockStyle.Fill;
            pnlDocumentIndex.Controls.Clear();
            pnlDocumentIndex.Controls.Add(_indexControl);

            btnOpenURL.Enabled = !string.IsNullOrEmpty(txtURL.Text);

            taGetSecondaryDocuments.Fill(iTDataSet.GetSecondaryDocuments, _currentClass.Id, _currentDocument.Id, _ds.Language);
            if (bsGetSecondaryDocuments.Count < 1)
            {
                gbSecondaryObjects.Enabled = false;
            }
            //Data.SetColors(this);
        }

        public void OpenOtherDocumentDetails(Document_Class cl, Document doc)
        {
            frmDetails details = new frmDetails(_ds);
            _ds.SetColors(details);
            details.SetFields(doc, cl);
            LanguageController.SetLanguage(details, _ds.LocRM);
            details.Location = new Point(this.Location.X + (this.Width / 2) - (details.Width / 2), this.Location.Y + (this.Height / 2) - (details.Height / 2));
            details.Show();
            details.Activate();
        }

        public void OpenOtherDocumentDetails(int classId, Int64 documentId){
            Document_Class cl = Data.GetClassById(classId);
            Document doc = Data.GetDocumentById(documentId, classId);
            OpenOtherDocumentDetails(cl, doc);
        }

        public void RunFileFromCurrentDocument()
        {
            Data.ShowDocument(_currentDocument.Id, _currentClass.Id, Security.SecurityObjects, _currentDocument.URL,
                _ds.Language, _currentDocument.Name, Security.Admin, false, GlobalSettings.ScanOperator, _ds.UseExternalViewer);
        }

        public void RunFileFromDocument(Document doc, int classId, bool useExternal = false)
        {
            Data.ShowDocument(doc.Id, classId, Security.SecurityObjects, doc.URL, _ds.Language, doc.Name, Security.Admin, false, GlobalSettings.ScanOperator, useExternal);
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            if (_primaryClass != null && _primaryDocument != null)
            {
                OpenOtherDocumentDetails(_primaryClass, _primaryDocument);
            }
        }

        private void btnOpenURL_Click(object sender, EventArgs e)
        {
            RunFileFromCurrentDocument();
        }

        private void dgvSecondaryDocuments_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (sender is DataGridView)
            {
                if (e.ColumnIndex == dgvColumnOpen.Index)
                {
                    int classId = int.Parse(dgvSecondaryDocuments.Rows[e.RowIndex].Cells[dgvColumnClassId.Index].Value.ToString());
                    Int64 docId = Int64.Parse(dgvSecondaryDocuments.Rows[e.RowIndex].Cells[dgvColumnDocumentId.Index].Value.ToString());
                    Document doc = Data.GetDocumentById(docId, classId);
                    RunFileFromDocument(doc, classId, _ds.UseExternalViewer);
                }
                else if (e.ColumnIndex == dgvColumnDetails.Index)
                {
                    int classId = int.Parse(dgvSecondaryDocuments.Rows[e.RowIndex].Cells[dgvColumnClassId.Index].Value.ToString());
                    Int64 docId = Int64.Parse(dgvSecondaryDocuments.Rows[e.RowIndex].Cells[dgvColumnDocumentId.Index].Value.ToString());
                    OpenOtherDocumentDetails(classId, docId);
                }
            }
        }

        private void dgvSecondaryDocuments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int classId = int.Parse(dgvSecondaryDocuments.Rows[e.RowIndex].Cells[dgvColumnClassId.Index].Value.ToString());
                Int64 docId = Int64.Parse(dgvSecondaryDocuments.Rows[e.RowIndex].Cells[dgvColumnDocumentId.Index].Value.ToString());
                Document doc = Data.GetDocumentById(docId, classId);
                RunFileFromDocument(doc, classId, _ds.UseExternalViewer);
            }

        }

        private string GetFileSize(string filePath)
        {
            string fileSize = "0 B";
            if (GlobalSettings.ScanOperator != null)
            {
                using (Impersonation.LogonUser(GlobalSettings.ScanOperator.Domain, GlobalSettings.ScanOperator.Login, GlobalSettings.ScanOperator.Password, LogonType.NewCredentials))
                { 
                    System.IO.FileInfo info = new System.IO.FileInfo(filePath);
                    var size = (double) info.Length; //wielkość w bajtach
                    fileSize = size.ToString("N", CultureInfo.InvariantCulture) + " B";
                    if ((size / 1024) > 1)
                    {
                        size = size / 1024;
                        fileSize = size.ToString("N", CultureInfo.InvariantCulture) + " KB";
                        if ((size / 1000) > 1)
                        {
                            size = size / 1000;
                            fileSize = size.ToString("N", CultureInfo.InvariantCulture) + " MB";
                            if ((size / 1000) > 1)
                            {
                                size = size / 1000;
                                fileSize = size.ToString("N", CultureInfo.InvariantCulture) + " GB";
                            }
                        }
                    }
                }
            }
            return fileSize;
        }

        private void btnShowDocument_Click(object sender, EventArgs e)
        {
            if (_primaryClass != null && _primaryDocument != null)
            {
                RunFileFromDocument(_primaryDocument, _primaryClass.Id, false);
            }
        }
    }
}
