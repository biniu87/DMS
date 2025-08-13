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

namespace DocumentsManagerRU.Controls
{
    public partial class SearchComboControl : UserControl, ISearchControl
    {
        private int _type;
        public int Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
        private string _columnName;
        public string ColumnName
        {
            get
            {
                return _columnName;
            }
            set
            {
                _columnName = value;
            }
        }
        public string Title
        {
            get
            {
                return this.lblTitle.Text;
            }
            set
            {
                this.lblTitle.Text = value;
            }
        }
        public string Items
        {
            set
            {
                cboValue.Items.Clear();
                cboValue.DataSource = Data.IndexItemsDictionary(value);//       <------------- do weryfikacji
            }
        }
        public List<Document_DefinitionList_Items> AdvancedItems
        {
            set
            {
                cboValue.Items.Clear();
                cboValue.DataSource = Data.IndexAdvancedItemsDictionary(value);
            }
        }

        public SearchComboControl()
        {
            InitializeComponent();
        }

        public string[] GetParam()
        {
            if (!string.IsNullOrEmpty(cboValue.Text))
            {
                return new string[]{
                    _type.ToString()
                    ,_columnName
                    ,cboValue.Text
                };
            }
            else
            {
                return new string[0];
            }
        }

        public void SetDetails(int DataType, string title, string columnName)
        {
            _type = DataType;
            lblTitle.Text = title;
            _columnName = columnName;
        }

        public void SetDetails(int DataType, string title, string columnName, string values){
            _type = DataType;
            lblTitle.Text = title;
            _columnName = columnName;
            Items = values;
        }

        public void SetDetails(int DataType, string title, string columnName, List<Document_DefinitionList_Items> values)
        {
            _type = DataType;
            lblTitle.Text = title;
            _columnName = columnName;
            AdvancedItems = values;
        }

        public void Clear()
        {
            cboValue.Text = string.Empty;
        }

        //private object[] ParseItems(string source)
        //{
        //    List<string> list = new List<string>();
        //    int startIndex = 0;
        //    int length = 0;
        //    int index = 0;
        //    while (startIndex + length < (source.Length) )
        //    {
        //        if (source[startIndex + length] == '$' && source[startIndex + length + 1] == '#')
        //        {
        //            list.Add(source.Substring(startIndex == 0 ? 0 : startIndex, length));
        //            startIndex = startIndex + length + 2;
        //            length = 0;
        //            ++index;
        //        }
        //        else
        //        {
        //            ++length;
        //        }
        //    }
        //    if (length > 0)
        //    {
        //        list.Add(source.Substring(startIndex));
        //    }
        //    return list.ToArray();
        //}
    }
}
