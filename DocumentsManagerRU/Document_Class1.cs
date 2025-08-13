using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsManagerRU
{
    public partial class Document_Class
    {
        /*public virtual IEnumerable<Document_Definitions> GetDefinitions()
        {
            if (this.Document_Definitions != null)
            {
                return Document_Definitions;
            }
            else
            {
                this.Document_Definitions = Data.GetDocumentDefinitionsForClass(this.Id);
                return Document_Definitions;
            }
            
        }*/

        /*public virtual void FillDefinitions()
        {
            using (var db = new DocContext())
            {
                try
                {
                    this.Document_Definitions = db.Document_Definitions.Where(dd => dd.ClassId == this.Id).ToList();
                }
                catch (Exception)
                {
                }
            }
        }*/

        [StructLayout(LayoutKind.Sequential, Size = 1)]
        public struct Field
        {
            public const string Id = "Id";
            public const string Table_Name = "Table_Name";
            public const string Name = "Name";
            public const string Name_RU = "Name_RU";
            public const string Description = "Description";
            public const string Description_RU = "Description_RU";
            public const string Active = "Active";
            public const string Deactivate_Date = "Deactivate_Date";
            public const string Create_Date = "Create_Date";
            public const string Create_User = "Create_User";
            public const string Edit_Date = "Edit_Date";
            public const string Edit_User = "Edit_User";
        }

        public virtual IEnumerable<Document_Index> CreateEmptyIndexes()
        {
            /*try
            {
                if (this.Document_Definitions == null || this.Document_Definitions.Count < 1)
                {
                    FillDefinitions();
                }
            }
            catch (Exception)
            {
                FillDefinitions();
            }*/

            try
            {
                if (this.Document_DefinitionPerClass != null || this.Document_DefinitionPerClass.Count > 0)
                {
                    List<Document_Index> indexes = new List<Document_Index>();
                    foreach (Document_DefinitionPerClass def in this.Document_DefinitionPerClass)
                    {
                        if (def.Active == true)
                        {
                            Document_Index index = new Document_Index();
                            index.Class_Id = def.ClassId;
                            index.Column_Name = def.ColumnName;
                            index.IsRequired = def.IsRequired.HasValue ? def.IsRequired.Value : false;
                            if (def.Document_Definitions != null)
                            {
                                index.Data_Type = (int)def.Document_Definitions.DataType;
                                index.Name_PL = def.Document_Definitions.Name_PL;
                                index.Name_RU = def.Document_Definitions.Name_RU;
                                index.Description_PL = def.Document_Definitions.Description_PL;
                                index.Description_RU = def.Document_Definitions.Description_RU;
                                if (def.Document_Definitions.Document_DefinitionList_Items != null)
                                {
                                    index.AdvancedItems = def.Document_Definitions.Document_DefinitionList_Items;
                                }
                            }
                            indexes.Add(index);
                        }
                    }
                    return indexes;
                }
                else
                {
                    return new List<Document_Index>();
                }
            }
            catch(Exception)
            {
                return new List<Document_Index>();
            }
        }
    }
}
