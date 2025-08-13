using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentsManagerRU.View.Controls.Interfaces
{
    public partial class AssignDocumentControl : UserControl
    {
        private frmMain _main;
        private DataShare _ds;
        private Int64 _documentId;
        private Document_Class _loadedClass;
        private string _conditions;
        private string _dbKey = string.Empty;
        private bool _loaded = false;
        private int _maxDisplay = 100000;
        private ErrorProvider _errorProvider = new ErrorProvider();

        public AssignDocumentControl()
        {
            InitializeComponent();
        }

        public AssignDocumentControl(frmMain main, DataShare ds)
        {
            InitializeComponent();
            InitializeComponent(main, ds);
        }

        public void InitializeComponent(frmMain main, DataShare ds)
        {
            _ds = ds;
            _main = main;
            _conditions = Permissions.IncludePermissionsItemsConditions(string.Empty, _main.PermisionToListItems, Security.Admin);
            InitializeClassList();
        }

        public void InitializeClassList()
        {
            var dict = Data.GetAllClassDictionary(_ds.Language, Security.SecurityObjects);
            cbClass.DataSource = dict;
            lblClassCount.Text = "(" + dict.Count.ToString() + ")";
        }

        public void TryInitializeDocumentList()
        {
            //już wczytano wcześniej
            //najpierw trzeba sprawdzić, czy klucz z którego wygenerowano źródło zawiera się w aktualnym
            var key = cbDocument.Text;
            if (!key.Contains(_dbKey) || !_loaded)
            {
                //wpisany klucz nie zawiera w sobie poprzedniego klucza- tworzymy nowe źródło
                if (_loadedClass != null)
                {
                    _conditions = Permissions.IncludePermissionsItemsConditions(string.IsNullOrEmpty(key) ? string.Empty : string.Format("WHERE {0} LIKE N'%{1}%'", Document.Field.Name, key),
                        _main.PermisionToListItems, Security.Admin);
                    var count = Data.GetDocumentInClassCount(_loadedClass.Table_Name, _conditions);
                    if (count > 0)
                    {
                        if (count < _maxDisplay)
                        {
                            //wczytujemy
                            var source = Data.GetDocumentsDictionary(_loadedClass.Table_Name, _conditions);
                            cbDocument.DataSource = source;
                            lblDocumentCount.Text = "(" + count.ToString() + ")";
                            _dbKey = key;
                            _loaded = true;
                        }
                    }
                }
            }
        }

        public void ClearAssign()
        {
            cbClass.SelectedIndex = -1;
            cbClass.Text = string.Empty;
            cbDocument.Text = string.Empty;
            cbDocument.DataSource = null;
            lblDocumentCount.Text = "0";
            _loaded = false;
            _dbKey = string.Empty;
            //cbClass.SelectedValue = -1;
        }

        public int? GetSelectedClassId()
        {
            int? classId = null;
            try
            {
                classId = cbClass.SelectedValue;
            }
            catch
            {
                classId = null;
            }
            return classId;
        }

        public Int64? GetSelectedDocumentId()
        {
            Int64? docId = -1;
            try
            {
                docId = cbDocument.SelectedValue;
            }
            catch
            {
                docId = null;
            }
            return docId;
        }

        public void SetSelectedClass(int classId)
        {
            cbClass.SelectedValue = classId;
        }

        public void SetSelectedDocument(Int64 documentId)
        {
            cbDocument.SelectedValue = _documentId = documentId;
        }

        public bool ValidateForm()
        {
            _errorProvider.Clear();
            var docId = GetSelectedDocumentId();
            var classId = GetSelectedClassId();
            if (classId > 0 && docId > 0)
            {
                //oba są wypełnione - jest ok
                return true;
            }
            else if ((classId == null && docId == null) || (classId < 1 && docId < 1))
            {
                //oba są puste - jest ok
                return true;
            }
            else
            {
                //wypełnione jest tylko jedno - nie do przyjęcia
                _errorProvider.SetError(cbDocument, _ds.LocRM.GetString("msg32")); //Wybierz dokument i klasę do powiązania, lub wyczyść powiązania
                _errorProvider.SetError(cbClass, _ds.LocRM.GetString("msg32")); //Wybierz dokument i klasę do powiązania, lub wyczyść powiązania
                return false;
            }
        }

        #region Events

        private void btnClearAssign_Click(object sender, EventArgs e)
        {
            ClearAssign();
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbDocument_TextChanged(object sender, EventArgs e)
        {
            TryInitializeDocumentList();
        }

        #endregion

        private void cbClass_SelectedValueChanged(object sender, EventArgs e)
        {
            var classId = GetSelectedClassId();
            if (classId == null || classId < 0)
                _loadedClass = null;
            else
                _loadedClass = Data.GetClassById(classId);
            cbDocument.DataSource = null;
            cbDocument.Text = string.Empty;
            lblDocumentCount.Text = "(0)";
            _loaded = false;
            TryInitializeDocumentList();
        }
    }
}
