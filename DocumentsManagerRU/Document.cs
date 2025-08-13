namespace DocumentsManagerRU
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Runtime.InteropServices;
    using NLog;
    
    public partial class Document
    {
        [StructLayout(LayoutKind.Sequential, Size = 1)]
        public struct Field
        {
            public const string Id = "Id";
            public const string Class_Id = "Class_Id";
            public const string Name = "Name";
            public const string Description = "Description";
            public const string URL = "URL";
            public const string OldFileName = "OldFileName";
            public const string Active = "Active";
            public const string Table_Name = "Table_Name";
            public const string Deactivate_Date = "Deactivate_Date";
            public const string Release_Date = "Release_Date";
            public const string Create_Date = "Create_Date";
            public const string Create_User = "Create_User";
            public const string Edit_Date = "Edit_Date";
            public const string Edit_User = "Edit_User";
            public const string AssignedClassId = "AssignedClassId";
            public const string AssignedDocumentId = "AssignedDocumentId";
        }

        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public Int64 Id { get; set; }
        public int Class_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public string OldFileName { get; set; }
        public bool? Active { get; set; }
        public string Table_Name { get; set; }
        public Nullable<System.DateTime> Deactivate_Date { get; set; }
        public Nullable<System.DateTime> Release_Date { get; set; }
        public Nullable<System.DateTime> Create_Date { get; set; }
        public string Create_User { get; set; }
        public Nullable<System.DateTime> Edit_Date { get; set; }
        public string Edit_User { get; set; }
        public Nullable<int> AssignedClassId { get; set; }
        public Nullable<Int64> AssignedDocumentId { get; set; }
    
        public virtual Document_Class Document_Class { get; set; }

        public virtual IEnumerable<Document_Index> DocumentIndexes { get; set; }

        public Document()
        {

        }

        public void FillFromDataRow(DataRow row, List<Document_DefinitionPerClass> definitionsPerClass)
        {
            try
            {
                if (row.Table.Columns.Contains("Id"))
                {
                    var value = row[row.Table.Columns["Id"].ColumnName];
                    if(value != null && value != DBNull.Value)
                        this.Id = Int64.Parse(value.ToString());
                }
                if (row.Table.Columns.Contains("Class_Id"))
                {
                    var value = row[row.Table.Columns["Class_Id"].ColumnName];
                    if (value != null && value != DBNull.Value)
                        this.Class_Id = Int32.Parse(value.ToString());
                }
                if (row.Table.Columns.Contains("Name"))
                {
                    var value = row[row.Table.Columns["Name"].ColumnName];
                    if (value != null && value != DBNull.Value)
                        this.Name = value.ToString();
                }
                if (row.Table.Columns.Contains("Description"))
                {
                    var value = row[row.Table.Columns["Description"].ColumnName];
                    if (value != null && value != DBNull.Value)
                        this.Description = value.ToString();
                }
                if (row.Table.Columns.Contains("URL"))
                {
                    var value = row[row.Table.Columns["URL"].ColumnName];
                    if (value != null && value != DBNull.Value)
                        this.URL = value.ToString();
                }
                if (row.Table.Columns.Contains("OldFileName"))
                {
                    var value = row[row.Table.Columns["OldFileName"].ColumnName];
                    if (value != null && value != DBNull.Value)
                        this.OldFileName = value.ToString();
                }
                if (row.Table.Columns.Contains("Active"))
                {
                    var value = row[row.Table.Columns["Active"].ColumnName];
                    if (value != null && value != DBNull.Value)
                        this.Active = Convert.ToBoolean(value.ToString());
                }
                if (row.Table.Columns.Contains("Table_Name"))
                {
                    var value = row[row.Table.Columns["Table_Name"].ColumnName];
                    if (value != null && value != DBNull.Value)
                        this.Table_Name = value.ToString();
                }
                if (row.Table.Columns.Contains("Deactivate_Date"))
                {
                    var value = row[row.Table.Columns["Deactivate_Date"].ColumnName];
                    if (value != null && value != DBNull.Value)
                        this.Deactivate_Date = DateTime.Parse(value.ToString());
                }
                if (row.Table.Columns.Contains("Release_Date"))
                {
                    var value = row[row.Table.Columns["Release_Date"].ColumnName];
                    if (value != null && value != DBNull.Value)
                        this.Release_Date = DateTime.Parse(value.ToString());
                }
                if (row.Table.Columns.Contains("Create_Date"))
                {
                    var value = row[row.Table.Columns["Create_Date"].ColumnName];
                    if (value != null && value != DBNull.Value)
                        this.Create_Date = DateTime.Parse(value.ToString());
                }
                if (row.Table.Columns.Contains("Edit_Date"))
                {
                    var value = row[row.Table.Columns["Edit_Date"].ColumnName];
                    if (value != null && value != DBNull.Value)
                        this.Edit_Date = DateTime.Parse(value.ToString());
                }
                if (row.Table.Columns.Contains("Create_User"))
                {
                    var value = row[row.Table.Columns["Create_User"].ColumnName];
                    if (value != null && value != DBNull.Value)
                        this.Create_User = value.ToString();
                }
                if (row.Table.Columns.Contains("Edit_User"))
                {
                    var value = row[row.Table.Columns["Edit_User"].ColumnName];
                    if (value != null && value != DBNull.Value)
                        this.Edit_User = value.ToString();
                }
                if (row.Table.Columns.Contains("AssignedClassId"))
                {
                    var value = row[row.Table.Columns["AssignedClassId"].ColumnName];
                    if (value != null && value != DBNull.Value)
                        this.AssignedClassId = Int32.Parse(value.ToString());
                }
                if (row.Table.Columns.Contains("AssignedDocumentId"))
                {
                    var value = row[row.Table.Columns["AssignedDocumentId"].ColumnName];
                    if (value != null && value != DBNull.Value)
                        this.AssignedDocumentId = Int64.Parse(value.ToString());
                }

                List<Document_Index> indexes = new List<Document_Index>();
                if (definitionsPerClass.Count > 0)
                {
                    foreach (Document_DefinitionPerClass def in definitionsPerClass)
                    {
                        if (def.Active == true)
                        {
                            Document_Index index = new Document_Index();
                            index.Class_Id = def.Document_Class.Id;
                            index.Column_Name = def.ColumnName;
                            Document_Definitions dd = Data.GetDocumentDefinitionById(def.DefinitionId);
                            index.AdvancedItems = Data.GetDefinitionListItemsForDefinitionId(dd.Id);// def.Document_Definitions.Document_DefinitionList_Items;
                            index.Data_Type = (int)dd.DataType;
                            index.Name_PL = dd.Name_PL;
                            index.Name_RU = dd.Name_RU;
                            index.Description_PL = dd.Description_PL;
                            index.Description_RU = dd.Description_RU;
                            index.Document = this;
                            index.Document_Id = index.Document.Id;
                            index.IsRequired = def.IsRequired.HasValue ? def.IsRequired.Value : false;
                            index.Active = def.Active.HasValue ? def.Active.Value : false;
                            index.DeactivateDate = def.Deactivate_Date.HasValue ? def.Deactivate_Date.Value : new DateTime();
                            index.Items = dd.Items;
                            if (row.Table.Columns.Contains(def.ColumnName))
                            {
                                var value = row[row.Table.Columns[def.ColumnName].ColumnName];
                                if (value != null && value != DBNull.Value)
                                    index.Value = value;
                                indexes.Add(index);
                            }
                            else
                            {
                                _logger.Warn(string.Format("Wykryto brak fizycznej kolumny, zdefiniowanej w indeksie. Id klasy: {0}, kolumna: {1}", def.ClassId.ToString(), def.ColumnName));
                            }

                            if (index.Data_Type == (int)Data.IndexTypes.List)
                            {
                                //wartoœæ id dla rekordu listy zaawansowanej przechowywanej w dokumencie
                                if (row.Table.Columns.Contains(index.ItemIdColumn_Name))
                                {
                                    var value = row[row.Table.Columns[index.ItemIdColumn_Name].ColumnName];
                                    if (value != null && value != DBNull.Value)
                                        index.ValueItemId = Int32.Parse(value.ToString());
                                }
                            }
                        }
                    }
                }
                DocumentIndexes = indexes;
            }
            catch (Exception e)
            {
                _logger.Error(string.Format("Wyst¹pi³ problem w trakcie przekazywania wartoœci z bazy danych do obiektu dokumentu! {0}", e));
            }
        }
    }

    //public partial class Document_DataRow : System.Data.DataRow
    //{
    //    private Document_DataTable document_DataTable;
    //    internal Document_DataRow(global::System.Data.DataRowBuilder rb) : 
    //                base(rb) {
    //                    this.document_DataTable = ((Document_DataTable)(this.Table));
    //        }
    //}

    //public partial class Document_DataTable : global::System.Data.TypedTableBase<Document_DataRow> {
    //    public Document_DataTable()
    //    {

    //    }
    //}
}
