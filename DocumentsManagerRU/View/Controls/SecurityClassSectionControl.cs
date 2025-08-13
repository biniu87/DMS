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
    public partial class SecurityClassSectionControl : UserControl
    {
        private ResourceManager _locRM { get; set; }

        public SecurityClassSectionControl()
        {
            InitializeComponent();
        }

        public SecurityClassSectionControl(ResourceManager rm, string title)
        {
            InitializeComponent();
            _locRM = rm;
            //ustawienia wag przycisków w tagach
            btnSecurityClassNothing.Tag = (int)Permissions.ClassPrimaryPermissions.None;
            btnSecurityClassRead.Tag = (int)Permissions.ClassPrimaryPermissions.Read;
            btnSecurityClassEdit.Tag = (int)Permissions.ClassPrimaryPermissions.Edit;
            btnSecurityClassDelete.Tag = (int)Permissions.ClassPrimaryPermissions.Delete;

            //ustawienia tytułów
            Data.SetToolTip(btnSecurityClassNothing, GetValueFromDictionary("btnlblSecurityClassNothing")); //Brak
            Data.SetToolTip(btnSecurityClassRead, GetValueFromDictionary("btnlblSecurityClassRead")); //Odczyt
            Data.SetToolTip(btnSecurityClassEdit, GetValueFromDictionary("btnlblSecurityClassRelease")); //Zwolnienie
            Data.SetToolTip(btnSecurityClassDelete, GetValueFromDictionary("btnlblSecurityClassDelete")); //Usuwanie
            lblTitle.Text = _locRM.GetString(title);

        }

        public event EventHandler SecurityClass_Click
        {
            add
            {
                btnSecurityClassNothing.Click += value;
                btnSecurityClassRead.Click += value;
                btnSecurityClassEdit.Click += value;
                btnSecurityClassDelete.Click += value;
            }
            remove 
            { 
                btnSecurityClassNothing.Click -= value;
                btnSecurityClassRead.Click -= value;
                btnSecurityClassEdit.Click -= value;
                btnSecurityClassDelete.Click -= value;
            }
        }

        public string GetValueFromDictionary(string text)
        {
            return !string.IsNullOrEmpty(_locRM.GetString(text)) ? _locRM.GetString(text) : "";
        }
    }
}
