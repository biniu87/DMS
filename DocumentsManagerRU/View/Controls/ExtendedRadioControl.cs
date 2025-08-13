using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentsManagerRU.View.Controls
{
    public partial class ExtendedRadioControl : UserControl
    {
        //private ToolTip _ttYes;
        //private ToolTip _ttNo;
        private string _strYesActive = string.Empty;
        private string _strYesInactive = string.Empty;
        private string _strNoActive = string.Empty;
        private string _strNoInactive = string.Empty;
        
        public bool Checked
        {
            get { return rbYes.Checked; }
            set {
                rbYes.Checked = value; 
                rbNo.Checked = !value;
                //_ttYes = Data.SetToolTip(rbYes, value ? _strYesActive : _strYesInactive);
                //_ttNo = Data.SetToolTip(rbNo, value ? _strNoInactive : _strNoActive);
                rbYes.Font = new System.Drawing.Font(Font.FontFamily, Font.SizeInPoints, value ? FontStyle.Bold : FontStyle.Regular, Font.Unit, ((byte)(238)));
                rbNo.Font = new System.Drawing.Font(Font.FontFamily, Font.SizeInPoints, !value ? FontStyle.Bold : FontStyle.Regular, Font.Unit, ((byte)(238)));
            }
        }
        


        public event EventHandler CheckedChanged
        {
            add { rbYes.CheckedChanged += value; }
            remove { rbYes.CheckedChanged -= value; }
        }

        public ExtendedRadioControl()
        {
            InitializeComponent();
        }

        public void SetLangugage(string yesActive, string yesInactive, string noActive, string noInactive)
        {
            _strYesActive = yesActive;
            _strYesInactive = yesInactive;
            _strNoActive = noActive;
            _strNoInactive = noInactive;

            rbYes.Text = _strYesActive;
            rbNo.Text = _strNoActive;
        }

        private void rbNoYes_CheckedChanged(object sender, EventArgs e)
        {
            bool IsCheckedComponent = ((RadioButton)sender) == rbYes ? ((RadioButton)sender).Checked : !((RadioButton)sender).Checked;
            rbYes.Font = new System.Drawing.Font(Font.FontFamily, Font.SizeInPoints, IsCheckedComponent ? FontStyle.Bold : FontStyle.Regular, Font.Unit, ((byte)(238)));
            rbNo.Font = new System.Drawing.Font(Font.FontFamily, Font.SizeInPoints, !IsCheckedComponent ? FontStyle.Bold : FontStyle.Regular, Font.Unit, ((byte)(238)));
        }
    }
}
