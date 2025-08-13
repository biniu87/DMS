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
    public partial class SecurityAdditionSectionControl : UserControl
    {
        private ResourceManager _locRM { get; set; }

        public SecurityAdditionSectionControl()
        {
            InitializeComponent();
        }

        public SecurityAdditionSectionControl(ResourceManager rm, string title, string selectcanHideColumnName)
        {
            InitializeComponent();
            _locRM = rm;
            //ustawienia wag przycisków w tagach
            btnSecurityAddsNothing.Tag = (int)Permissions.ModificationsPermissions.None;
            btnSecurityAddsNew.Tag = (int)Permissions.ModificationsPermissions.New;
            btnSecurityAddsFull.Tag = (int)Permissions.ModificationsPermissions.Modify;
            btnSecurityAddsCanHide.Tag = selectcanHideColumnName;

            //ustawienia tytułów
            Data.SetToolTip(btnSecurityAddsNothing, GetValueFromDictionary("btnlblSecurityAdditionNothing")); //Brak
            Data.SetToolTip(btnSecurityAddsNew, GetValueFromDictionary("btnlblSecurityAdditionNew")); //dostęp do tworzenia
            Data.SetToolTip(btnSecurityAddsFull, GetValueFromDictionary("btnlblSecurityAdditionFull")); //Zwolnienie
            Data.SetToolTip(btnSecurityAddsCanHide, GetValueFromDictionary("btnlblSecurityAdditionCanHide")); //Pełny dostęp
            lblTitle.Text = _locRM.GetString(title);

        }

        public event EventHandler SecurityAdds_Click
        {
            add
            {
                btnSecurityAddsNothing.Click += value;
                btnSecurityAddsNew.Click += value;
                btnSecurityAddsFull.Click += value;
            }
            remove 
            { 
                btnSecurityAddsNothing.Click -= value;
                btnSecurityAddsNew.Click -= value;
                btnSecurityAddsFull.Click -= value;
            }
        }
        public event EventHandler SecurityAddsCanHide_Click
        {
            add
            {
                btnSecurityAddsCanHide.Click += value;
            }
            remove
            {
                btnSecurityAddsCanHide.Click -= value;
            }
        }

        public string GetValueFromDictionary(string text)
        {
            return !string.IsNullOrEmpty(_locRM.GetString(text)) ? _locRM.GetString(text) : "";
        }
    }
}
