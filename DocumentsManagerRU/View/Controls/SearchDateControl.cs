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
    public partial class SearchDateControl : UserControl, ISearchControl
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
        public SearchDateControl()
        {
            InitializeComponent();
            dtpBeginDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
        }

        public string[] GetParam()
        {
            if (chkActive.Checked)
            {
                return new string[]{
                _type.ToString()
                ,_columnName
                ,dtpBeginDate.Value.ToShortDateString()
                ,dtpEndDate.Value.ToShortDateString()
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
            chkActive.Checked = false;
            dtpBeginDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
        }

        private void chActive_CheckedChanged(object sender, EventArgs e)
        {
            dtpBeginDate.Enabled = chkActive.Checked;
            dtpEndDate.Enabled = chkActive.Checked;
            if (chkActive.Checked)
                chkActive.Image = DocumentsManagerRU.Properties.Resources.check_2x;
            else
                chkActive.Image = DocumentsManagerRU.Properties.Resources.plus_2x;
        }
    }
}
