using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using DocumentViewer.Controls.Viewer;
using NLog;

namespace DocumentsManagerRU.View
{
    public partial class frmEditDocumentFile : Form
    {
        private int _classId;
        private long _documentId;
        private Document _loadedDocument;
        //private Document_Class _loadedClass;
        public static Logger _logger = LogManager.GetCurrentClassLogger();
        private ErrorProvider _errorProvider = new ErrorProvider();
        private frmMain _main;
        private DataShare _ds;
        private ElementHost _ctrlHost;
        private Viewer _viewer;

        public frmEditDocumentFile()
        {
            InitializeComponent();
        }

        public frmEditDocumentFile(Int64 documentId, int classId, frmMain main, DataShare ds)
        {
            InitializeComponent();
            _main = main;
            _ds = ds;
            _documentId = documentId;
            _classId = classId;
            _loadedDocument = Data.GetDocumentById(documentId, classId);
            //_loadedClass = Data.GetClassById(classId);

        }

        private bool ValidateForm()
        {
            _errorProvider.Clear();
            if (string.IsNullOrEmpty(txtFilePath.Text))
            {
                _errorProvider.SetError(txtFilePath, _ds.LocRM.GetString("msg02")); //Musisz wybrać plik, który ma zostać zwolniony!
                return false;
            }
            else if (txtFilePath.Text.Length > 260)
            {
                _errorProvider.SetError(txtFilePath, _ds.LocRM.GetString("msg20")); //Zbyt długi adres pliku! Wybierz plik ponownie.
                return false;
            }
            else if (!Data.IsFileOrDirectoryExist(txtFilePath.Text))
            {
                _errorProvider.SetError(txtFilePath, _ds.LocRM.GetString("msg02")); //Musisz wybrać plik, który ma zostać zwolniony!
                return false;
            }
            return true;
        }

        public async void StartReleaseProces()
        {
            if (!ValidateForm()) return;
            _main.Enabled = false;
            this.Enabled = false;

            if (_viewer != null)
            {
                _viewer.Dispose();
                _viewer = null;
                if (_viewer != null)
                {
                    gbPreview.Controls.Clear();
                    _viewer.Dispose();
                    _viewer = null;
                }
            }

            //główny przedmiot metody- proces zwalniania dokumentu
            await Data.UpdateDocumentFileProcess(_documentId, _classId, _ds, txtFilePath.Text);
            _main.Enabled = true;
            _main.RefreshDocumentGridSimple();
            this.Close();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            DialogResult result = selectDocumentFD.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var link = selectDocumentFD.FileName;
                selectDocumentFD.Dispose();

                //stworzymy kopię pliku w tempie dla uzyskania dla niego podglądu
                var temporaryFile = Data.MakeTempCopyOfFile(link);

                txtFilePath.Text = link;
                //tutaj generujemy podgląd
                if (_ctrlHost != null)
                {
                    _ctrlHost.Dispose();
                    _ctrlHost = null;
                }
                if (_viewer != null)
                {
                    _viewer.Dispose();
                    _viewer = null;
                }
                _viewer = DocumentViewerModel.GetNewViewer(temporaryFile);
                _ctrlHost = new ElementHost();
                _ctrlHost.Dock = DockStyle.Fill;
                gbPreview.Controls.Clear();
                gbPreview.Controls.Add(_ctrlHost);
                _ctrlHost.Child = _viewer;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void btnReleaseDocument_Click(object sender, EventArgs e)
        {
            StartReleaseProces();
        }

        private void btnReleaseDocument1_Click(object sender, EventArgs e)
        {
            StartReleaseProces();
        }
    }
}
