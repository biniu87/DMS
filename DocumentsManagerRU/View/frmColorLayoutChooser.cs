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
    public partial class frmColorLayoutChooser : Form
    {
        private List<Image> _thumbs = new List<Image>();
        private DataShare _ds; 

        public frmColorLayoutChooser(DataShare ds)
        {
            InitializeComponent();
            _ds = ds;

            dgvColors.Rows.Add();
            _thumbs.Add(DocumentsManagerRU.Properties.Resources.szablon1);
            dgvColors.Rows[dgvColors.Rows.Count - 1].Cells[dgvColumnThumb.Index].Value = DocumentsManagerRU.Properties.Resources.szablon1;
            dgvColors.Rows[dgvColors.Rows.Count - 1].Cells[dgvColumnParams.Index].Value = "0,0,0,255,255,255,255,255,255,196,226,255,197,197,197,0,70,138";

            dgvColors.Rows.Add();
            _thumbs.Add(DocumentsManagerRU.Properties.Resources.szablon2);
            dgvColors.Rows[dgvColors.Rows.Count - 1].Cells[dgvColumnThumb.Index].Value = DocumentsManagerRU.Properties.Resources.szablon2;
            dgvColors.Rows[dgvColors.Rows.Count - 1].Cells[dgvColumnParams.Index].Value = "0,0,0,255,255,255,255,255,255,251,228,152,197,197,197,70,72,60";


            //dgvColors.Rows.Add();
            //_thumbs.Add(DocumentsManagerRU.Properties.Resources.szablon3);
            //dgvColors.Rows[dgvColors.Rows.Count - 1].Cells[dgvColumnThumb.Index].Value = DocumentsManagerRU.Properties.Resources.szablon3;
            //dgvColors.Rows[dgvColors.Rows.Count - 1].Cells[dgvColumnParams.Index].Value = "255,255,255,255,255,255,6,64,244,7,16,241,197,197,197,0,70,138";

            //dgvColors.Rows.Add();
            //_thumbs.Add(DocumentsManagerRU.Properties.Resources.szablon4);
            //dgvColors.Rows[dgvColors.Rows.Count - 1].Cells[dgvColumnThumb.Index].Value = DocumentsManagerRU.Properties.Resources.szablon4;
            //dgvColors.Rows[dgvColors.Rows.Count - 1].Cells[dgvColumnParams.Index].Value = "0,0,0,255,255,255,243,210,224,153,160,119,197,197,197,82,70,66";

            //dgvColors.Rows.Add();
            //_thumbs.Add(DocumentsManagerRU.Properties.Resources.szablon5);
            //dgvColors.Rows[dgvColors.Rows.Count - 1].Cells[dgvColumnThumb.Index].Value = DocumentsManagerRU.Properties.Resources.szablon5;
            //dgvColors.Rows[dgvColors.Rows.Count - 1].Cells[dgvColumnParams.Index].Value = "255,255,255,255,255,255,45,116,73,4,65,50,197,197,197,2,32,35";

            //_thumbs.Add(DocumentsManagerRU.Properties.Resources.szablon6);
            //dgvColors.Rows[dgvColors.Rows.Count - 1].Cells[dgvColumnThumb.Index].Value = DocumentsManagerRU.Properties.Resources.szablon6;
            //dgvColors.Rows[dgvColors.Rows.Count - 1].Cells[dgvColumnParams.Index].Value = "0,0,0,0,0,0,237,237,237,220,220,220,197,197,197,161,205,58";

            //_thumbs.Add(DocumentsManagerRU.Properties.Resources.szablon7);
            //dgvColors.Rows[dgvColors.Rows.Count - 1].Cells[dgvColumnThumb.Index].Value = DocumentsManagerRU.Properties.Resources.szablon7;
            //dgvColors.Rows[dgvColors.Rows.Count - 1].Cells[dgvColumnParams.Index].Value = "255,255,255,50,50,50,82,82,82,50,50,50,197,197,197,255,255,255";

            try
            {
                string actualColorLayout = ColorLayoutController.SerializeColorLayout(_ds.ColorLayout);
                DataGridViewRow current = null;
                foreach (DataGridViewRow row in dgvColors.Rows)
                {
                    if (row.Cells[dgvColumnParams.Index].Value.ToString().Equals(actualColorLayout))
                    {
                        current = row;
                        row.Selected = true;
                        break;
                    }
                }
                if (current != null)
                {
                    dgvColors.Rows.Remove(current);
                    dgvColors.Rows.Insert(0, current);
                }
            }
            catch (Exception)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvColors_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvColumnThumb.Index && e.RowIndex != -1)
            {
                //e.Value = _thumbs[e.RowIndex];
                e.Value = dgvColors.Rows[e.RowIndex].Cells[dgvColumnThumb.Index].Value;
            }
        }

        public ColorLayout GetSelectedColorLayout()
        {
            if (dgvColors.SelectedRows.Count > 0)
            {
                var str = dgvColors.SelectedRows[0].Cells[dgvColumnParams.Index].Value;
                if(str != null && !string.IsNullOrEmpty(str.ToString()))
                {
                    ColorLayout layout = ColorLayoutController.DeserializeColorLayout(str.ToString());
                    return layout;
                    
                }
            }
            return ColorLayoutController.GetDefaultColorLayout();
        }
        public void ApplyColorLayout()
        {
            ColorLayout layout = GetSelectedColorLayout();
            //aktualizacja
            _ds.SetColorLayout(layout);
            TempController.SaveColorLayoutToTemp(layout);
            this.Close();
        }

        private void btnSetLayoutColors_Click(object sender, EventArgs e)
        {
            ApplyColorLayout();
        }

        private void dgvColors_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
                ApplyColorLayout();
        }
    }
}
