using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentsManagerRU
{
    public partial class frmAddClass : Form
    {
        private DataShare _ds;
        private ErrorProvider _errorProvider = new ErrorProvider();

        public frmAddClass(DataShare ds)
        {
            _ds = ds;
            InitializeComponent();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            AddClass();
        }

        public bool ValidateForm()
        {
            _errorProvider.Clear();
            if (txtName.Visible && string.IsNullOrEmpty(txtName.Text))
            {
                _errorProvider.SetError(txtName, _ds.LocRM.GetString("msg05")); //"Musisz podać nazwę dla nowej klasy!"
                return false;
            }
            else if (txtNameRU.Visible && string.IsNullOrEmpty(txtNameRU.Text))
            {
                _errorProvider.SetError(txtNameRU, _ds.LocRM.GetString("msg10")); //Musisz podać nazwę dla nowej klasy w języku rosyjskim!
                return false;
            }
            else if (txtName.Visible && Data.IsClassNameExistInDatabase(txtName.Text))
            {
                _errorProvider.SetError(txtName, _ds.LocRM.GetString("msg06")); //Podana nazwa dla klasy dokumentów już jest w użyciu!
                return false;
            }
            else if (txtNameRU.Visible && Data.IsClassNameRUExistInDatabase(txtNameRU.Text))
            {
                _errorProvider.SetError(txtNameRU, _ds.LocRM.GetString("msg11")); //Podana nazwa dla klasy dokumentów w języku rosyjskim już jest w użyciu!
                return false;
            }
            else 
            {
                return true; 
            }
        }

        public void ClearForm()
        {
            txtName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtNameRU.Text = string.Empty;
            txtDescriptionRU.Text = string.Empty;
        }

        public bool AddClass()
        {
            if (ValidateForm())
            {
                var result = Data.AddNewClass(txtName.Text, txtNameRU.Text, txtDescription.Text, txtDescriptionRU.Text);
                if (result)
                {
                    DialogBox.ShowDialog(_ds.LocRM.GetString("msg07"), string.Empty, _ds, MessageBoxButtons.OK, DialogBox.Icons.Success); //Klasa została poprawnie utworzona.
                    this.Close();
                    _ds.RefreshData();
                    return true;
                }
                else
                {
                    DialogBox.ShowDialog(_ds.LocRM.GetString("msg08"), string.Empty, _ds, MessageBoxButtons.OK, DialogBox.Icons.Error); //Wystąpił problem w trakcie tworzenia nowej klasy!
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
    }
}
