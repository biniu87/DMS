namespace DocumentsManagerRU
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Linq;

    public partial class Document_Index
    {
        public Int64 Document_Id { get; set; }
        public int Definition_Id { get; set; }
        public int Class_Id { get; set; }
        public string Name_PL { get; set; }
        public string Description_PL { get; set; }
        public string Name_RU { get; set; }
        public string Description_RU { get; set; }
        public string Column_Name { get; set; }
        public DateTime DeactivateDate { get; set; }
        public bool Active { get; set; }
        public int Data_Type { get; set; }
        public bool IsRequired { get; set; }
        public string Items { get; set; } 
        public IEnumerable<Document_DefinitionList_Items> AdvancedItems { get; set; }
        private object _Value { get; set; }
        public object Value
        {
            get
            {
                switch (Data_Type)
                {
                    case (int)Data.IndexTypes.Date:
                        {
                            if (_Value != null)
                            {
                                return DateTime.Parse(_Value.ToString());
                            }
                            else
                            {
                                return null;
                            }
                            //return _Value.HasValue ? DateTime.Parse(_Value.Value.ToString()) : null;
                        }
                    case (int)Data.IndexTypes.Number:
                        {
                            decimal tmp;
                            decimal.TryParse(_Value != null ? _Value.ToString() : string.Empty, out tmp);
                            return tmp;
                        }
                    //case (int)Data.IndexTypes.String:
                    //    {
                    //        return _Value.ToString();
                    //    }
                    //case (int)Data.IndexTypes.List:
                    //    {
                    //        return _Value.ToString();
                    //    }
                    default:
                        {
                            //return _Value.ToString();
                            return _Value;
                            //return _Value != null && string.IsNullOrEmpty(_Value.ToString()) ? _Value : null;
                        }
                }
            }
            set { _Value = value; }
        }
        public string ItemIdColumn_Name
        {
            get
            {
                if (Data_Type == (int)Data.IndexTypes.List)
                {
                    return Column_Name + "id";
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Id rekordu z listy, zapisanego do indeksu
        /// </summary>
        public int? ValueItemId { get; set; }
        public virtual Document Document { get; set; }

        public Document_Index()
        {
             
        }

        public string GetName(string lang)
        {
            return lang == "PL" ? Name_PL : lang == "RU" ? Name_RU : "";
        }

        public string GetDescription(string lang)
        {
            return lang == "PL" ? Description_PL : lang == "RU" ? Description_RU : "";
        }

        public string[] GetParsedItems()
        {
            string[] items = Data.IndexItemsSplit(Items);
            return items;
        }

        public IDictionary<int, string> GetItemsDictionary()
        {
            return Data.IndexItemsDictionary(Items != null ? Items : "");
        }

        public IDictionary<int, string> GetAdvancedItemsDictionary()
        {
            List<Document_DefinitionList_Items> list = AdvancedItems != null ?
                ((IEnumerable<Document_DefinitionList_Items>)AdvancedItems).Where(rec => rec.Active == true).ToList() : new List<Document_DefinitionList_Items>();
            return Data.IndexAdvancedItemsDictionary(list);
            //return Data.IndexAdvancedItemsDictionary(AdvancedItems != null ? (List<Document_DefinitionList_Items>)AdvancedItems : new List<Document_DefinitionList_Items>());
        }
 
    }
}
