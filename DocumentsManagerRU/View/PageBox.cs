using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentsManagerRU
{
    public partial class PageBox : Form
    {
        private Int64 _queryDocumentsCount = 1;
        private int _queryPageSize = 50;
        private Int64 _queryPageBegin = 1;
        private Int64 _queryPageEnd = 100;
        private int _queryPageCount = 1;
        private int _queryPageActual = 1;
        private string documents;
        private string page;
        private DGVDocumentControl _documentControl;

        public PageBox()
        {
            InitializeComponent();
        }

        public PageBox(DGVDocumentControl ctrl, int lastPage, int actualPage, int pageSize, Int64 documentsCount)
        {
            InitializeComponent();
            _documentControl = ctrl;
            documents = "Dokument:"; // po akceptacji będzie ze słownika
            page = "Strona:";

            tbPage.Minimum = 1;
            tbPage.Maximum = lastPage;
            tbPage.Value = actualPage;

            _queryDocumentsCount = documentsCount;
            _queryPageSize = pageSize;
            _queryPageCount = lastPage;

            CountPage();

            lblFirstPage.Text = "1";
            lblLastPage.Text = lastPage.ToString();
            lblActualPage.Text = actualPage.ToString();

            SetPageTitle();
        }

        private void tbPage_Scroll(object sender, EventArgs e)
        {
            CountPage();
            SetPageTitle();
        }

        private void CountPage()
        {
            _queryPageActual = tbPage.Value;
            _queryPageBegin = (_queryPageActual /*_queryPageCount*/ - 1) * _queryPageSize + 1;
            if (_queryPageBegin > _queryDocumentsCount)
            {
                _queryPageBegin = _queryDocumentsCount;
            }
            _queryPageEnd = _queryPageBegin + _queryPageSize - 1;
            if (_queryPageEnd > _queryDocumentsCount)
            {
                _queryPageEnd = _queryDocumentsCount;
            }
        }

        private void SetPageTitle()
        {
            lblActualPage.Text = string.Format("{0} {1}", page, _queryPageActual.ToString());
            lblActualDocuments.Text = string.Format("{0} {1} - {2}", documents, _queryPageBegin, _queryPageEnd);
        }

        private void PageBox_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SetActualePage();
        }

        public void SetActualePage()
        {
            _documentControl.SetActualPage(tbPage.Value);
            this.Close();
        }

        private void tbPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SetActualePage();
            }
            else if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
