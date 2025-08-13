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
    public partial class LanguageBox : Form
    {
        //frmMain _main;
        DataShare _ds;
        public LanguageBox()
        {
            InitializeComponent();
        }

        public LanguageBox(DataShare ds)
        {
            InitializeComponent();
            _ds = ds;
            SetLanguageButtons(_ds.Language);
        }

        public void SetLanguageButtonsTitles()
        {
            DataTable langs = LanguageController.GetLanguageTable(_ds.LocRM);
            //text - tytuł, tag - prefix języka
            btnLang1.Text = langs.Rows[0]["title"].ToString();
            btnLang1.Tag = langs.Rows[0]["prefix"].ToString();
            btnLang2.Text = langs.Rows[1]["title"].ToString();
            btnLang2.Tag = langs.Rows[1]["prefix"].ToString();
            btnLang3.Text = langs.Rows[2]["title"].ToString();
            btnLang3.Tag = langs.Rows[2]["prefix"].ToString();
        }

        public void SetLanguageButtons(string lang)
        {
            Button[] buttons = new Button[] { btnLang1, btnLang2, btnLang3 };
            //tytuły zostają ustawione już dla nowego języka
            SetLanguageButtonsTitles();
            foreach (Button btn in buttons)
            {
                //ustawienie checka tylko na wybranym języku
                if (btn.Tag.ToString() == lang)
                {
                    btn.Image = DocumentsManagerRU.Properties.Resources.check_2x;
                }
                else
                {
                    btn.Image = null;
                }
            }
        }

        private void chooseLanguage_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (_ds.Language != btn.Tag.ToString().ToLower())
            {
                _ds.SetLanguage(btn.Tag.ToString());
            }
            this.Close();
        }

        private void LanguageBox_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
