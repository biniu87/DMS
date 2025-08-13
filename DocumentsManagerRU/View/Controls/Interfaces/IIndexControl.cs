using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsManagerRU.Controls.Interfaces
{
    interface IIndexControl
    {
        Document_Index GetIndex();
        void SetIndexValue(Document_Index index);
        void SetIndexValue(object Value);
        bool Validate();
        void SetReadOnly(bool readOnly);
        void Clear();
    }
}
