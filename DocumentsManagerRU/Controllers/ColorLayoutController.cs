using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentsManagerRU
{
    public class ColorLayoutController
    {
        public enum ColorFields
        {
            COLOR_FORE_1,
            COLOR_FORE_2,
            COLOR_BACK,
            COLOR_OBJECTS,
            COLOR_PRESSED,
            COLOR_SELECTED
        }

        public List<ColorLayout> GetLayouts()
        {
            List<ColorLayout> layouts = new List<ColorLayout>();
            return layouts;
        }

        public static ColorLayout GetDefaultColorLayout()
        {
            ColorLayout layout = new ColorLayout(
                ColorLayout.GetColorFromRGB(0, 0, 0),
                ColorLayout.GetColorFromRGB(255, 255, 255),
                ColorLayout.GetColorFromRGB(255, 255, 255),
                ColorLayout.GetColorFromRGB(196, 226, 255),
                ColorLayout.GetColorFromRGB(0, 70, 138)
            );
            return layout;
        }

        public static void SetColors(Control ctrl, ColorLayout layout, Control[] exception)
        {
            if (!exception.Contains(ctrl))
                SetColors(ctrl, layout);
        }

        public static void SetColors(Control ctrl, ColorLayout layout)
        {
            //wymuszenie pomijania obiektów
            if (ctrl.Name.Contains("TestInfo"))
            {
                return;
            }

            if (ctrl is ToolStrip || ctrl is StatusStrip)
            {
                //nic nie rób
                return;
            }
            else if (ctrl.GetType() == typeof(Button))
            {
                ctrl.BackColor = layout.COLOR_OBJECTS;
                ctrl.ForeColor = layout.COLOR_FORE_1;// Color.Black;
                Button btn = (Button)ctrl;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
            }
            else if (ctrl.GetType() == typeof(Label))
            {
                ctrl.ForeColor = layout.COLOR_FORE_1;// Color.White;
                //dodano
                ctrl.BackColor = layout.COLOR_BACK;
            }
            else if (ctrl.GetType() == typeof(DataGridView))
            {
                DataGridView dgv = (DataGridView)ctrl;

                dgv.ColumnHeadersDefaultCellStyle.BackColor = layout.COLOR_BACK;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = layout.COLOR_FORE_1;// Color.White;
                dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

                dgv.RowHeadersDefaultCellStyle.BackColor = layout.COLOR_BACK;

                dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgv.EnableHeadersVisualStyles = false;

                dgv.DefaultCellStyle.BackColor = layout.COLOR_OBJECTS; // Color.White;
                dgv.DefaultCellStyle.SelectionBackColor = dgv.RowHeadersDefaultCellStyle.SelectionBackColor = layout.COLOR_SELECTED;
                dgv.DefaultCellStyle.SelectionForeColor = layout.COLOR_FORE_2;

                dgv.AlternatingRowsDefaultCellStyle.BackColor = layout.COLOR_BACK;
                //dodano
                dgv.AlternatingRowsDefaultCellStyle.ForeColor = layout.COLOR_FORE_1;

                dgv.BackgroundColor = layout.COLOR_BACK;
                dgv.ForeColor = layout.COLOR_FORE_1;// Color.Black;
            }
            else if (ctrl is TabPage || ctrl is Panel || ctrl is Form)
            {
                ctrl.BackColor = layout.COLOR_BACK;
                //ctrl.ForeColor = Data.COLOR_FORE_1;
            }
            else if (ctrl.GetType() == typeof(TabPage))
            {
                TabPage page = (TabPage)ctrl;

                ctrl.BackColor = layout.COLOR_OBJECTS;
                ctrl.ForeColor = layout.COLOR_FORE_1;// Data.COLOR_SELECTED;
            }
            else if (ctrl is MonthCalendar)
            {
                MonthCalendar calendar = (MonthCalendar)ctrl;
                calendar.BackColor = layout.COLOR_OBJECTS;
                calendar.TitleBackColor = layout.COLOR_OBJECTS;
            }
            else if (ctrl is CheckBox || ctrl is RadioButton)
            {
                var box = (ButtonBase)ctrl;
                if (ctrl is RadioButton)
                    ((RadioButton)ctrl).Appearance = Appearance.Button;
                else
                    ((CheckBox)ctrl).Appearance = Appearance.Button;
                box.BackColor = layout.COLOR_OBJECTS;
                box.ForeColor = layout.COLOR_FORE_2;// Color.Black;
                box.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke; //wciśnięty przycisk i pm
                box.FlatAppearance.MouseOverBackColor = layout.COLOR_PRESSED; //najeżdżona myszka
                box.FlatAppearance.CheckedBackColor = layout.COLOR_SELECTED; //wciśnięty przycisk
                box.FlatStyle = FlatStyle.Flat;
                box.FlatAppearance.BorderSize = 0;
            }
            else if (ctrl is ListBox)
            {
                ListBox box = (ListBox)ctrl;
                box.BackColor = layout.COLOR_BACK;
                box.ForeColor = layout.COLOR_FORE_1;
            }
            else if (ctrl is GroupBox)
            {
                GroupBox box = (GroupBox)ctrl;
                box.BackColor = layout.COLOR_BACK;
                box.ForeColor = layout.COLOR_FORE_1;
            }

            if (ctrl.Controls.Count > 0)
            {
                foreach (Control control in ctrl.Controls)
                {
                    SetColors(control, layout);
                }
            }
        }

        public static string SerializeColorLayout(ColorLayout layout)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("{0},{1},{2},", layout.COLOR_FORE_1.R, layout.COLOR_FORE_1.G, layout.COLOR_FORE_1.B));
            sb.Append(string.Format("{0},{1},{2},", layout.COLOR_FORE_2.R, layout.COLOR_FORE_2.G, layout.COLOR_FORE_2.B));
            sb.Append(string.Format("{0},{1},{2},", layout.COLOR_BACK.R, layout.COLOR_BACK.G, layout.COLOR_BACK.B));
            sb.Append(string.Format("{0},{1},{2},", layout.COLOR_OBJECTS.R, layout.COLOR_OBJECTS.G, layout.COLOR_OBJECTS.B));
            sb.Append(string.Format("{0},{1},{2},", layout.COLOR_PRESSED.R, layout.COLOR_PRESSED.G, layout.COLOR_PRESSED.B));
            sb.Append(string.Format("{0},{1},{2}", layout.COLOR_SELECTED.R, layout.COLOR_SELECTED.G, layout.COLOR_SELECTED.B));
            return sb.ToString();
        }

        public static ColorLayout DeserializeColorLayout(string body)
        {
            if (string.IsNullOrEmpty(body))
                return null;
            try 
	        {	        
                var parameters = Regex.Split(body, ",");
		        ColorLayout layout = new ColorLayout();
                layout.COLOR_FORE_1 = ColorLayout.GetColorFromRGB(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
                layout.COLOR_FORE_2 = ColorLayout.GetColorFromRGB(int.Parse(parameters[3]), int.Parse(parameters[4]), int.Parse(parameters[5]));
                layout.COLOR_BACK = ColorLayout.GetColorFromRGB(int.Parse(parameters[6]), int.Parse(parameters[7]), int.Parse(parameters[8]));
                layout.COLOR_OBJECTS = ColorLayout.GetColorFromRGB(int.Parse(parameters[9]), int.Parse(parameters[10]), int.Parse(parameters[11]));
                layout.COLOR_PRESSED = ColorLayout.GetColorFromRGB(int.Parse(parameters[12]), int.Parse(parameters[13]), int.Parse(parameters[14]));
                layout.COLOR_SELECTED = ColorLayout.GetColorFromRGB(int.Parse(parameters[15]), int.Parse(parameters[16]), int.Parse(parameters[17]));
                return layout;
	        }
	        catch (Exception)
	        {
                return GetDefaultColorLayout();
	        }
        }

    }
}
