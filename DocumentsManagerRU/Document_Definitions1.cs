using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsManagerRU
{
    public partial class Document_Definitions
    {
        public string[] GetParsedItems()
        {
            string[] items = Data.IndexItemsSplit(Items);
            return items;
        }

        public IDictionary<int, string> GetItemsDictionary()
        {
            return Data.IndexItemsDictionary(Items);
        }

        public IDictionary<int, string> GetAdvancedListDictionary()
        {
            List<Document_DefinitionList_Items> list;
            try
            {
                list = Document_DefinitionList_Items.ToList();
            }
            catch (Exception)
            {
                list = new List<Document_DefinitionList_Items>();
            }
            return Data.IndexAdvancedItemsDictionary(list);
        }

    }
}
