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
    public partial class SearchValueControl : UserControl, ISearchControl
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

        public SearchValueControl()
        {
            InitializeComponent();
        }

        public string[] GetParam()
        {
            if (!string.IsNullOrEmpty(txtValue.Text))
            {
                return new string[]
                {
                    _type.ToString()
                    ,_columnName
                    ,txtValue.Text
                };
            }
            else
            {
                return new string[0];
            }
        }

        public void SetDetails(int DataType, string title, string columnName){
            _type = DataType;
            lblTitle.Text = title;
            _columnName = columnName;
        }

        public void Clear()
        {
            txtValue.Text = string.Empty;
        }
    }
}
