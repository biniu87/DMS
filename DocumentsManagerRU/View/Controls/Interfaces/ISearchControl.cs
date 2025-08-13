using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsManagerRU.Controls.Interfaces
{
    interface ISearchControl
    {
        string[] GetParam();
        void SetDetails(int DataType, string title, string columnName);
        void Clear();
    }
}
