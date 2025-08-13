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
    public partial class SecurityOperationSectionControl : UserControl
    {
        private ResourceManager _locRM { get; set; }

        public SecurityOperationSectionControl()
        {
            InitializeComponent();
        }

        public SecurityOperationSectionControl(ResourceManager rm, string title)
        {
            InitializeComponent();
            _locRM = rm;
            //ustawienia wag przycisków w tagach
            btnSecurityOperationNone.Tag = (int)Permissions.OperationsPermissions.None;
            btnSecurityOperationOnlyWith.Tag = (int)Permissions.OperationsPermissions.WithModifications;
            btnSecurityOperationFull.Tag = (int)Permissions.OperationsPermissions.WithoutModifications;

            //ustawienia tytułów
            Data.SetToolTip(btnSecurityOperationNone, GetValueFromDictionary("btnlblSecurityOperationNone")); //Brak dostępu do wykonania operacji
            Data.SetToolTip(btnSecurityOperationOnlyWith, GetValueFromDictionary("btnlblSecurityOperationOnlyWith")); //Operacja dostępna, bez możliwości ukrycia pól specjalnych
            Data.SetToolTip(btnSecurityOperationFull, GetValueFromDictionary("btnlblSecurityOperationFull")); //Operacja dostępna, z możliwością ukrycia pól specjalnych
            lblTitle.Text = _locRM.GetString(title);

        }

        public event EventHandler SecurityOperation_Click
        {
            add 
            { 
                btnSecurityOperationNone.Click += value;
                btnSecurityOperationOnlyWith.Click += value;
                btnSecurityOperationFull.Click += value;
            }
            remove 
            { 
                btnSecurityOperationNone.Click -= value;
                btnSecurityOperationOnlyWith.Click -= value;
                btnSecurityOperationFull.Click -= value;
            }
        }

        public string GetValueFromDictionary(string text)
        {
            return !string.IsNullOrEmpty(_locRM.GetString(text)) ? _locRM.GetString(text) : "";
        }
    }
}
