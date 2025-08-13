using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace DocumentsManagerRU.View.Controls
{
    public partial class ucSectionControlNotifications : UserControl
    {
        private ResourceManager _locRM { get; set; }

        public ucSectionControlNotifications()
        {
            InitializeComponent();
        }

        public ucSectionControlNotifications(ResourceManager rm, string title, string releaseProperty, string emailOnReleaseProperty)
        {
            InitializeComponent();
            _locRM = rm;
            //ustawienia wag przycisków w tagach
            btnCanRelease.Tag = releaseProperty;
            btnEmailOnRelease.Tag = emailOnReleaseProperty;
            //ustawienia tytułów
            Data.SetToolTip(btnEmailOnRelease, GetValueFromDictionary("btnPermissionEmailOnRelease"));
            Data.SetToolTip(btnCanRelease, GetValueFromDictionary("btnPermissionCanRelease"));

            lblTitle.Text = _locRM.GetString(title);
        }

        //public event EventHandler SecurityAdds_Click
        //{
        //    add
        //    {
        //        btnSecurityAddsNothing.Click += value;
        //        btnSecurityAddsNew.Click += value;
        //        btnSecurityAddsFull.Click += value;
        //    }
        //    remove 
        //    { 
        //        btnSecurityAddsNothing.Click -= value;
        //        btnSecurityAddsNew.Click -= value;
        //        btnSecurityAddsFull.Click -= value;
        //    }
        //}
        public event EventHandler PermissionEnableMailAndRelease
        {
            add
            {
                btnEmailOnRelease.Click += value;
                btnCanRelease.Click += value;
            }
            remove
            {
                btnEmailOnRelease.Click -= value;
                btnCanRelease.Click -= value;
            }
        }

        public string GetValueFromDictionary(string text)
        {
            return !string.IsNullOrEmpty(_locRM.GetString(text)) ? _locRM.GetString(text) : "";
        }
    }
}
