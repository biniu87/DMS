using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using DocumentsManagerRU.Controls.Interfaces;

namespace DocumentsManagerRU.Controls
{
    public partial class IndexComboControl : UserControl, IIndexControl
    {
        private Document_Index _index;
        private ResourceManager _rm;
        //private string error1 = "msg26"; // musisz podać wartość!
        private string error2 = "msg34"; // musisz podać wartość z listy!
        private ErrorProvider _errorProvider = new ErrorProvider();

        public IndexComboControl(Document_Index index, ResourceManager rm, string lang, bool readOnly)
        {
            InitializeComponent();
            _index = index;
            _rm = rm;
            SetReadOnly(readOnly);
            lblTitle.Text = _index.GetName(lang);
            lblRequired.Text = rm.GetString("lblRequired");
            lblRequired.Visible = _index.IsRequired;
            cbValue1.Items.Clear();
            //generowanie słownika
            IDictionary<int, string> dict = null;
            if (_index.Data_Type == (int)Data.IndexTypes.List)
                dict = _index.GetAdvancedItemsDictionary();
            else if(_index.Data_Type == (int)Data.IndexTypes.SimpleList)
                dict = _index.GetItemsDictionary();
            if ((_index.Value != null || _index.ValueItemId.HasValue) && _index.Value != DBNull.Value)
            {
                //dodanie do słownika wartości, która jest ustawiona, a której nie ma na liście- nieaktywna
                if (IsContainValue(dict, _index.Value.ToString()) == false)
                {
                    dict.Add(new KeyValuePair<int, string>(
                        _index.ValueItemId.HasValue ? _index.ValueItemId.Value : dict.Count, _index.Value.ToString()));
                }
            }
            //wstawienie słownika wartości do źródła
            cbValue1.DataSource = dict;
            //ustawienie wartości indeksu
            if (_index.Value != null && _index.Value != DBNull.Value)
                //cbValue1.Text = _index.Value.ToString();
                SelectByIndex(_index.Value.ToString());


        }

        public Document_Index GetIndex()
        {
            _index.Value = cbValue1.Text;
            if ((_index.Data_Type == (int)Data.IndexTypes.List) && _index.Value != null && (!string.IsNullOrEmpty(_index.Value.ToString())))
            {
                _index.ValueItemId = cbValue1.SelectedValue;
            }
            else
            {
                _index.ValueItemId = null;
            }
            return _index;
        }

        public void SetIndexValue(Document_Index index)
        {
            _index = index;
            //cbValue1.Text = index != null && _index.Value != null ? index.Value.ToString() : "";
            SelectByIndex(index != null && _index.Value != null ? index.Value.ToString() : "");
        }

        public void SetIndexValue(object index)
        {
            //cbValue1.Text = index.ToString();
            SelectByIndex(index.ToString());
        }

        public void SelectByIndex(string value)
        {
            Dictionary<int, string> dict = (Dictionary<int, string>)cbValue1.DataSource;
            var ind = dict.SingleOrDefault(i => i.Value == value).Key;
            if (ind != null && ind > 0)
            {
                cbValue1.SelectedValue = ind;
            }
            else
            {
                cbValue1.Text = value;
            }
            cbValue1.Select(0, 0);
        }

        public void SetReadOnly(bool readOnly)
        {
            cbValue1.Enabled = !readOnly;
        }

        new public bool Validate()
        {
            bool result;
            if (_index.IsRequired) //czy pole jest wymagane
            {
                if (string.IsNullOrEmpty(cbValue1.Text)) //czy pole jest puste
                {
                    result = false;
                }
                else if (!IsContainValue()) //czy pole zawiera wartość z listy
                {
                    result = false;
                }
                else //spełnia warunki gdy jest wymagane
                {
                    result = true;
                }
            }
            else if (!string.IsNullOrEmpty(cbValue1.Text)) //pole niewymagane, czy jest niepuste
            {
                if (IsContainValue()) //czy wpisana wartość jest elementem listy źródłowej
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            else //pole niewymagane i puste-jest ok
            {
                result = true;
            }
            if (!result)
            {
                _errorProvider.SetError(cbValue1, _rm.GetString(error2));
            }
            else
            {
                _errorProvider.Clear();
            }
            return result;
        }

        public void Clear()
        {
            cbValue1.Text = string.Empty;
        }

        public bool IsContainValue()
        {
            try
            {
                foreach (var val in (Dictionary<int, string>)cbValue1.DataSource)
                {
                    if (val.Value == cbValue1.Text)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool IsContainValue(IDictionary<int, string> dictionary, string value)
        {
            try
            {
                foreach (var val in dictionary)
                {
                    if (val.Value == value)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
