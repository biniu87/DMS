using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsManagerRU
{
    public class ClassPermissions
    {
        public Permissions.ClassPrimaryPermissions PrimaryPermission { get; set; }
        public bool CanRelease { get; set; }
        public bool MailOnRelease { get; set; }
    }
}
