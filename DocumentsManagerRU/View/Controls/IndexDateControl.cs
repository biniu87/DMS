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
    public partial class IndexDateControl : UserControl, IIndexControl
    {
        private Document_Index _index;

        public IndexDateControl(Document_Index index, ResourceManager rm, string lang, bool readOnly)
        {
            InitializeComponent();
            _index = index;
            lblTitle.Text = _index.GetName(lang);
            lblRequired.Text = rm.GetString("lblRequired");
            lblRequired.Visible = _index.IsRequired;
            SetReadOnly(readOnly);
            chkEnabled.Checked = _index.Value != null;
            if(_index.Value != null && _index.Value != DBNull.Value)
            {
                dtpIndexDate.Value = (DateTime)_index.Value;
            }
            else
            {
                dtpIndexDate.Value = DateTime.Today;// dtpIndexDate.MinDate;
            }
        }

        public Document_Index GetIndex()
        {
            if (chkEnabled.Checked)
            {
                _index.Value = dtpIndexDate.Value.Date;
            }
            else
            {
                _index.Value = null;
            }
            
            return _index;
        }

        public void SetIndexValue(Document_Index index)
        {
            if (index == null) return;
            _index = index;
            if (index.Value == null)
            {
                dtpIndexDate.Value = DateTime.Today;// dtpIndexDate.MinDate;
                chkEnabled.Checked = false;
            }
            else
            {
                DateTime tmp;
                DateTime.TryParse(index.Value.ToString(), out tmp);
                if (tmp != null)
                    dtpIndexDate.Value = tmp;
                chkEnabled.Checked = _index.IsRequired;
            }
        }

        public void SetIndexValue(object index)
        {
            if (index is DateTime)
                dtpIndexDate.Value = (DateTime)index;
            else
            {
                DateTime tmp;
                DateTime.TryParse(index.ToString(), out tmp);
                if (tmp != null)
                    dtpIndexDate.Value = tmp;
            }
        }

        public void SetReadOnly(bool readOnly)
        {
            chkEnabled.Enabled = !readOnly && !_index.IsRequired;// nie można aktywować, jeżeli pole wymagane
            chkEnabled.Checked = _index.IsRequired ? true : chkEnabled.Checked; // gdy wymagane, aktywowanie musi byćzaznaczone
            dtpIndexDate.Enabled = !readOnly && chkEnabled.Checked;
        }

        new public bool Validate()
        {
            //zawsze ustawiona wartość dla daty
            return true;
        }

        public void Clear()
        {
            dtpIndexDate.Value = DateTime.Now;
        }

        private void chkEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnabled.Checked)
                chkEnabled.Image = DocumentsManagerRU.Properties.Resources.check_2x;
            else
                chkEnabled.Image = DocumentsManagerRU.Properties.Resources.plus_2x;
            dtpIndexDate.Enabled = chkEnabled.Checked;
        }
    }
}
