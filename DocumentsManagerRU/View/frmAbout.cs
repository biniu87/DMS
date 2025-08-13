using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentsManagerRU.View
{
    public partial class frmAbout : Form
    {
        public frmAbout(DataShare ds)
        {
            InitializeComponent();
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            lblApp.Text = string.Format("{0} v.{1}", fvi.ProductName, fvi.ProductVersion);
            lblCompany.Text = fvi.LegalCopyright;
            lblTestInfo.Visible = Data.IsTestDatabase();
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
