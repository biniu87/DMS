using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentsManagerRU
{
    public class LanguageController
    {
        public LanguageController()
        {

        }

        public static ResourceManager GetLanguageResources(string lang)
        {
            switch (lang.ToUpper())
            {
                case ("PL"):
                    return new ResourceManager("DocumentsManagerRu.InterfaceLang_PL", typeof(LanguageController).Assembly);
                case ("RU"):
                    return new ResourceManager("DocumentsManagerRu.InterfaceLang_RU", typeof(LanguageController).Assembly);
                default:
                    return new ResourceManager("DocumentsManagerRu.InterfaceLang_PL", typeof(LanguageController).Assembly);
            }
        }

        public static string GetDefaultLanguage()
        {
            CultureInfo culture = Thread.CurrentThread.CurrentCulture;
            string lang = culture.TwoLetterISOLanguageName.ToUpper();
            return lang;
        }

        public static DataTable GetLanguageTable(ResourceManager rm)
        {
            DataTable langs = new DataTable("Language");
            langs.Columns.Add("prefix");
            langs.Columns.Add("title");
            langs.Rows.Add("PL", "PL - " + rm.GetString("langPL"));
            langs.Rows.Add("RU", "RU - " + rm.GetString("langRU"));
            langs.Rows.Add("EN", "EN - " + rm.GetString("langEN"));
            return langs;
        }

        public static string GetLanguageTitle(ResourceManager rm, string lang)
        {
            DataTable langTable = GetLanguageTable(rm);
            for (int i = 0; i < langTable.Rows.Count; i++)
            {
                if (langTable.Rows[i]["prefix"].ToString() == lang.ToUpper())
                {
                    return langTable.Rows[i]["title"].ToString();
                }
            }
            return "";
        }

        public static void SetLanguage(ToolStripMenuItem item, ResourceManager rm)
        {
            item.Text = rm.GetString(item.Name) != null ? rm.GetString(item.Name) : item.Text;
        }

        public static void SetLanguage(ToolStripItem item, ResourceManager rm)
        {
            item.Text = rm.GetString(item.Name) != null ? rm.GetString(item.Name) : item.Text;
        }

        public static void SetLanguage(ToolStripDropDownButton button, ResourceManager rm)
        {
            button.Text = rm.GetString(button.Name) != null ? rm.GetString(button.Name) : button.Text;
            foreach (var item in button.DropDownItems)
            {
                if (item.GetType() == typeof(ToolStripDropDownButton))
                    SetLanguage((ToolStripDropDownButton)item, rm);
                else if (item.GetType() == typeof(ToolStripMenuItem))
                    SetLanguage((ToolStripMenuItem)item, rm);
                else if (item.GetType() == typeof(ToolStripItem))
                    SetLanguage((ToolStripItem)item, rm);
                else if (item.GetType() == typeof(ToolStrip))
                    SetLanguage((ToolStrip)item, rm);
            }
        }

        public static void SetLanguage(ToolStrip ts, ResourceManager rm)
        {
            ts.Text = rm.GetString(ts.Name) != null ? rm.GetString(ts.Name) : ts.Text;
            foreach (var item in ts.Items)
            {
                if (item.GetType() == typeof(ToolStripDropDownButton))
                    SetLanguage((ToolStripDropDownButton)item, rm);
                else if (item.GetType() == typeof(ToolStripMenuItem))
                    SetLanguage((ToolStripMenuItem)item, rm);
                else if (item.GetType() == typeof(ToolStripItem))
                    SetLanguage((ToolStripItem)item, rm);
                else if (item.GetType() == typeof(ToolStrip))
                    SetLanguage((ToolStrip)item, rm);
            }
        }

        public static void SetLanguage(Control ctrl, ResourceManager rm)
        {
            if (ctrl == null) return;
            if (ctrl.GetType() == typeof(Button) ||
                ctrl.GetType() == typeof(RadioButton) ||
                ctrl.GetType() == typeof(Label) ||
                ctrl.GetType() == typeof(Form) ||
                ctrl.GetType() == typeof(GroupBox) ||
                ctrl.GetType() == typeof(TabPage) ||
                ctrl.GetType().ToString().Contains("frm"))
            {
                ctrl.Text = rm.GetString(ctrl.Name) != null ? rm.GetString(ctrl.Name) : ctrl.Text;
            }
            else if (ctrl.GetType() == typeof(DataGridView))
            {
                foreach (DataGridViewColumn col in ((DataGridView)ctrl).Columns)
                {
                    col.HeaderText = rm.GetString(col.Name) != null ? rm.GetString(col.Name) : col.HeaderText;
                }
            }
            else if (ctrl.GetType() == typeof(ToolStrip))
            {
                SetLanguage(((ToolStrip)ctrl), rm);
            }
            else if (ctrl.GetType() == typeof(DocumentsManagerRU.View.Controls.ExtendedRadioControl))
            {
                ((DocumentsManagerRU.View.Controls.ExtendedRadioControl)ctrl).SetLangugage(rm.GetString("strYesActive"), rm.GetString("strYesInactive"), rm.GetString("strNoActive"), rm.GetString("strNoInactive"));
            }

            if (ctrl.Controls.Count > 0)
            {
                foreach (Control control in ctrl.Controls)
                {
                    SetLanguage(control, rm);
                }
            }
        }

    }
}
