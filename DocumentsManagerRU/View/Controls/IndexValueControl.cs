using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentsManagerRU.Controls.Interfaces;
using System.Resources;

namespace DocumentsManagerRU.Controls
{
    public partial class IndexValueControl : UserControl, IIndexControl
    {
        private Document_Index _index;
        private ResourceManager _rm;
        private ErrorProvider _errorProvider = new ErrorProvider();

        public IndexValueControl(Document_Index index, ResourceManager rm, string lang, bool readOnly)
        {
            InitializeComponent();
            _index = index;
            _rm = rm;
            SetReadOnly(readOnly);
            lblTitle.Text = _index.GetName(lang) + (_index.Data_Type == (int)Data.IndexTypes.Number ? _rm.GetString("lblTypeNumber") : "");
            lblRequired.Text = rm.GetString("lblRequired");
            lblRequired.Visible = _index.IsRequired;
            if (_index.Value != null && _index.Value != DBNull.Value)
                txtValue.Text = _index.Value.ToString();
        }

        public Document_Index GetIndex()
        {
            if (_index.Data_Type == (int)Data.IndexTypes.Number)
            {
                decimal tmp;
                Decimal.TryParse(txtValue.Text.Replace(",", "."), out tmp);
                 _index.Value = tmp;
            }
            else 
            {
                _index.Value = txtValue.Text; 
            }
            return _index;
        }

        public void SetIndexValue(Document_Index index)
        {
            _index = index;
            txtValue.Text = index != null && index.Value != null ? index.Value.ToString() : "";
        }

        public void SetIndexValue(object index)
        {
            txtValue.Text = index.ToString();
        }

        public void SetReadOnly(bool readOnly)
        {
            txtValue.ReadOnly = readOnly;
        }

        new public bool Validate()
        {
            bool result;
            if (_index.IsRequired)
            {
                if (string.IsNullOrEmpty(txtValue.Text))
                {
                    _errorProvider.SetError(txtValue, _rm.GetString("msg26")); //musisz podać wartość
                    return false;
                }
                else
                {
                    result = true;
                }
            }
            else
            {
                result = true;
            }
            if (_index.Data_Type == (int)Data.IndexTypes.Number) //niezależnie czy wymagane
            {
                if(!string.IsNullOrEmpty(txtValue.Text))
                {
                    decimal number;
                    result = decimal.TryParse(txtValue.Text.Replace(",", "."), out number);
                }
            }
            if (!result)
            {
                _errorProvider.SetError(txtValue, _rm.GetString("msg17")); //nie spełnia regół walidacji!
            }
            else
            {
                _errorProvider.Clear();
            }
            return result;
        }

        public void Clear()
        {
            txtValue.Text = string.Empty;
        }
    }
}
