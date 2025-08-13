using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Extensions;
using DocumentsManagerRU.ImpersonationClass;
using NLog;

namespace DocumentsManagerRU
{
    public static partial class Data
    {

        #region SELECT

        public static Int64 GetDocumentInClassCount(string tableName, string conditions)
        {
            string query = string.Format("SELECT COUNT (Id) FROM {0} (NOLOCK) {1}", tableName, conditions);
            var value = Data.GetSQLSingleValue(query);
            Int64 count = -1;
            Console.WriteLine(query);
            if (value != null)
            {
                Int64.TryParse(value.ToString(), out count);
            }
            return count;
        }

        public static DataTable GetDocumentsInClassByDirectives(string tableName, string queryOrder, string queryConditions, int queryPageSize, Int64 queryPageBegin, Int64 queryPageEnd)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(string.Format("SELECT TOP({0}) * FROM ", queryPageSize));
            builder.Append(string.Format("(SELECT TOP({0}) ROW_NUMBER() OVER ({1}) AS lp, Id FROM {2} (NOLOCK) {3}) ", queryPageEnd, queryOrder, tableName, queryConditions));
            builder.Append(string.Format("AS tab JOIN {0} d (NOLOCK) on tab.Id = d.Id WHERE tab.lp >= {1} and tab.lp <= {2} ", tableName, queryPageBegin, queryPageEnd));
            var dt = GetSQLTableValue(builder.ToString());
            Console.WriteLine(builder.ToString());
            return dt;
        }

        public static DataTable GetDocumentsInClassAsTable(string tableName, string queryConditions)
        {
            string sql = string.Format("SELECT * From {0} (NOLOCK) {1} ORDER BY Name ASC", tableName, queryConditions);
            var dt = GetSQLTableValue(sql);
            return dt;
        }

        public static IEnumerable GetAllClass()
        {
            using (var db = new DocContext())
            {
                try
                {
                    return db.Document_Class.ToList();
                }
                catch (Exception e)
                {
                    _logger.Error(e, "Błąd pobrania wszystkich klas dokumentów, GetAllClass(), e: {0}", e);
                    return new Document_Class[0];
                }
            }
        }

        public static IEnumerable<GetDocumentsClass_Result> GetClassToRelease(string lang, string securityObjects)
        {
            using (var db = new DocContext())
            {
                try
                {
                    return db.GetDocumentsClass(lang, securityObjects, (int)Permissions.ClassPrimaryPermissions.None, (int)Permissions.ClassSecondaryPermissions.Release).ToList();
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd pobrania klas dokumentów, GetClassToRelease({0}), e: {1}", lang, e);
                    return new GetDocumentsClass_Result[0];
                }
            }
        }

        public static IEnumerable GetClassByPermissions(int permissionValue, int securityId)
        {
            using (var db = new DocContext())
            {
                try
                {
                    return db.Document_Permissions.Where(dp => dp.AccessLevel <= permissionValue && dp.SecurityId == securityId).Select(dp => dp.Document_Class).ToList();
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd pobrania klas dokumentów, GetClassByPermissions({0}, {1}), e: {2}", permissionValue, securityId, e);
                    return new Document_Class[0];
                }
            }
        }

        public static IEnumerable GetClassWhichUserCanRead(int securityId)
        {
            using (var db = new DocContext())
            {
                try
                {
                    return db.Document_Permissions.Where(dp => (dp.AccessLevel >= (int)Permissions.ClassPrimaryPermissions.Read)
                                && dp.SecurityId == securityId).Select(dp => dp.Document_Class).ToList();
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd pobrania klas dokumentów, GetClassWhichUserCanRead({0}), e: {1}", securityId, e);
                    return new Document_Class[0];
                }
            }
        }

        public static IEnumerable GetClassWhichUserCanRelease(int securityId)
        {
            using (var db = new DocContext())
            {
                try
                {
                    return db.Document_Permissions.Where(dp => (dp.DC_Release.HasValue && dp.DC_Release.Value) && dp.SecurityId == securityId).Select(dp => dp.Document_Class).ToList();
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd pobrania klas dokumentów, GetClassWhichUserCanRelease({0}), e: {1}", securityId, e);
                    return new Document_Class[0];
                }
            }
        }

        public static Document_Class GetClassById(int? Id)
        {
            if (Id.HasValue && Id > 0)
            {
                using (var db = new DocContext())
                {
                    try
                    {
                        Document_Class docClass = db.Document_Class.FirstOrDefault(dc => dc.Id == Id);
                        docClass.Document_DefinitionPerClass.ToString(); // wymuszenie wczytania?
                        return docClass;
                    }
                    catch (Exception e)
                    {
                        _logger.Error("Błąd pobrania klasy dokumentu po Id, GetSingleClassById({0}), e: {1}", Id, e);
                        return new Document_Class();
                    }
                }
            }
            else
            {
                return new Document_Class();
            }
        }

        public static IEnumerable GetIndexesForClassId(int classId)
        {
            Document_Class docClass = GetClassById(classId);
            return docClass.CreateEmptyIndexes();
        }

        public static IEnumerable GetDocumentsForClass(Document_Class cl)
        {
            List<Document> documents = new List<Document>();
            try
            {
                DataTable tmp = GetSQLTableValue(string.Format("SELECT * FROM {0}", cl.Table_Name));
                List<Document_DefinitionPerClass> definitions = cl.Document_DefinitionPerClass.ToList();
                foreach (DataRow row in tmp.Rows)
                {
                    Document doc = new Document();
                    doc.FillFromDataRow(row, definitions);
                    documents.Add(doc);
                }
            }
            catch (Exception e)
            {
                _logger.Error(string.Format("Wystąpił problem w listowaniu dokumentów klasy: {0}, {1}", cl.Name, e));
                return new List<Document>();
            }
            return documents;
        }

        public static IEnumerable<Document_DefinitionPerClass> GetDocumentDefinitionsPerClass(int classId)
        {
            using (var db = new DocContext())
            {
                try
                {
                    Document_Class cl = GetClassById(classId);
                    var definitionsPerClass = cl.Document_DefinitionPerClass.AsEnumerable();
                    return definitionsPerClass;
                }
                catch (Exception e)
                {
                    _logger.Error(e, "Błąd pobierania definicji dla klas, GetDocumentDefinitionsPerClass(), e: {0}", e);
                    return new List<Document_DefinitionPerClass>();
                }
            }
        }

        public static List<GetDocumentDefinitionsForClass_Result> GetDocumentsDefinitionsForClassByLanguage(int classId, string language)
        {
            List<GetDocumentDefinitionsForClass_Result> result;
            using (var db = new DocContext())
            {
                try
                {
                    result = db.GetDocumentDefinitionsForClass(language, classId).ToList();
                    if (result.Count() > 0)
                        return result;
                    else
                        return new List<GetDocumentDefinitionsForClass_Result>();
                }
                catch (Exception e)
                {
                    _logger.Error(e, "Błąd pobierania definicji, GetDocumentsDefinitionsForClassByLanguage(), e: {0}", e);
                    return new List<GetDocumentDefinitionsForClass_Result>();
                }
            }
        }

        public static List<Document_Index> GetDocumentIndexesForClass(int classId)
        {
            List<Document_DefinitionPerClass> definitions = GetDocumentDefinitionsPerClass(classId).ToList();
            List<Document_Index> indexes = GetDocumentIndexesForDefinitions(definitions);
            return indexes;
        }

        public static List<Document_Index> GetDocumentIndexesForDefinitions(List<Document_DefinitionPerClass> definitions, bool activeOnly = true)
        {
            if (definitions != null || definitions.Count > 0)
            {
                List<Document_Index> indexes = new List<Document_Index>();
                foreach (Document_DefinitionPerClass defPerClass in definitions)
                {
                    if (activeOnly ? defPerClass.Active.HasValue ? defPerClass.Active.Value : false : true)
                    {
                        Document_Definitions dd;
                        try
                        {
                            dd = defPerClass.Document_Definitions;
                        }
                        catch (Exception)
                        {
                            dd = GetDocumentDefinitionById(defPerClass.DefinitionId);
                        }
                        Document_Index index = new Document_Index();
                        index.Class_Id = defPerClass.ClassId;
                        index.Column_Name = defPerClass.ColumnName;
                        //Document_Definitions dd = defPerClass.Document_Definitions != null ? defPerClass.Document_Definitions : 
                        index.Data_Type = (int)dd.DataType;
                        index.Name_PL = dd.Name_PL;
                        index.Name_RU = dd.Name_RU;
                        index.Description_PL = dd.Description_PL;
                        index.Description_RU = dd.Description_RU;
                        index.Items = dd.Items;
                        index.IsRequired = defPerClass.IsRequired.HasValue ? defPerClass.IsRequired.Value : false;
                        index.AdvancedItems = Data.GetDefinitionListItemsForDefinitionId(dd.Id); // dd.Document_DefinitionList_Items;
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

        public static Document_Definitions GetDocumentDefinitionById(int defId)
        {
            if (defId < 1) return new Document_Definitions();
            using (var db = new DocContext())
            {
                try
                {
                    Document_Definitions definition = db.Document_Definitions.SingleOrDefault(dd => dd.Id == defId);
                    if (definition != null)
                    {
                        definition.Document_DefinitionList_Items.ToString(); //powoduje pobranie z bazy obiektów.
                        definition.Document_DefinitionPerClass.ToString();
                        return definition;
                    }
                    else
                    {
                        return new Document_Definitions();
                    }
                }
                catch (Exception e)
                {
                    _logger.Error(e, "Błąd pobierania pojedynczej definicji indeksu, GetDocumentDefinitionById(), e: {0}", e);
                    return new Document_Definitions();
                }
            }

        }

        public static IEnumerable<Document_DefinitionPerClass> GetDocumentDefinitionsForClassPerClass(int classId)
        {
            if (classId < 1) return new List<Document_DefinitionPerClass>();
            using (var db = new DocContext())
            {
                try
                {
                    IEnumerable<Document_DefinitionPerClass> definition = db.Document_DefinitionPerClass.Where(dd => dd.ClassId == classId);
                    return definition;
                }
                catch (Exception e)
                {
                    _logger.Error(e, "Błąd pobierania wszystkich powiązanych defininicji indeksu na klasę, GetDocumentDefinitionsForClassPerClass(), e: {0}", e);
                    return new List<Document_DefinitionPerClass>();
                }
            }
        }

        public static Document_DefinitionPerClass GetDocumentDefinitionPerClassById(int id)
        {
            if (id < 1) return new Document_DefinitionPerClass();
            using (var db = new DocContext())
            {
                try
                {
                    Document_DefinitionPerClass definition = db.Document_DefinitionPerClass.SingleOrDefault(dd => dd.Id == id);
                    definition.Document_Class.ToString();
                    definition.Document_Definitions.ToString();
                    return definition;
                }
                catch (Exception e)
                {
                    _logger.Error(e, "Błąd pobierania pojedynczej powiązanej defininicji indeksu na klasę, GetDocumentDefinitionForClassById(), e: {0}", e);
                    return new Document_DefinitionPerClass();
                }
            }
        }

        public static Document GetDocumentById(Int64 docId, int classId, List<Document_DefinitionPerClass> definitions = null)
        {
            Document doc = new Document();
            if (docId > 0 && classId > 0)
            {
                string tableName = GetTableNameById(classId);
                string sql = string.Format("SELECT * FROM {0} WHERE Id = {1}", tableName, docId);
                DataTable docTable = GetSQLTableValue(sql);
                if (docTable == null || docTable.Rows.Count < 1)
                {
                    return doc;
                }
                DataRow docRow = docTable.Rows[0];
                List<Document_DefinitionPerClass> listDefinitions = definitions;
                if (listDefinitions == null)
                {
                    listDefinitions = GetDocumentDefinitionsPerClass(classId).ToList();
                }
                doc.Class_Id = classId;
                doc.Table_Name = tableName.ToString();
                doc.FillFromDataRow(docRow, listDefinitions);
            }
            return doc;
        }

        public static IEnumerable GetPermissionsByClass(int classId)
        {
            using (var db = new DocContext())
            {
                try
                {
                    return db.GetDocumentPermissionsForClass(classId);
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd pobierania poświadczeń dla klasy, GetPermissionsByClass({0}), e: {1}", classId, e);
                    return new GetDocumentPermissionsForClass_Result[0];
                }
            }
        }

        public static IEnumerable<Document_DefinitionList_Items> GetDefinitionListItemsForDefinitionId(int definitionId)
        {
            using (var db = new DocContext())
            {
                try
                {
                    return db.Document_DefinitionList_Items.Where(ddli => ddli.DefinitionId == definitionId).ToList();
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd pobierania rekordów definicji listy zaawansowanej z bazy: GetDefinitionListItemsForDefinitionId({0}), e:{1}", definitionId, e);
                    return new List<Document_DefinitionList_Items>();
                }
            }
        }

        public static IEnumerable<Document_DefinitionList_Items> GetDefinitionListItemsForDefinitionIdByPermissions(int definitionId, int classId, string securityObject)
        {
            using (var db = new DocContext())
            {
                try
                {
                    var listItems = db.Document_DefinitionList_Items.Where(ddli => ddli.DefinitionId == definitionId).ToList();
                    //var permissions = db.Document_ListItems_Permissions.Where(dlip => dlip.ClassId == classId && dlip.)
                    var list = db.GetDocumentListItemsPermissions(definitionId, classId, securityObject).Where(l => l.Permission.HasValue).ToList();
                    if (list.Count > 0)
                    {
                        return listItems;
                        //nie wszystkie elementy mogą być wyświetlone
                    }
                    else
                    {
                        var lst = list.Select(l => l.ItemId);
                        return listItems.Where(li => lst.Contains(li.Id));
                    }

                    ///return listItems;
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd pobierania rekordów definicji listy zaawansowanej z bazy: GetDefinitionListItemsForDefinitionId({0}), e:{1}", definitionId, e);
                    return new List<Document_DefinitionList_Items>();
                }
            }
        }

        public static int GetCountUsedAdvancedListRecords(int recordId)
        {
            int count = 0;
            var body = string.Format("DECLARE @return_value int EXEC @return_value = [dbo].[ACT_GetCountUsedAdvancedListRecords] {0} SELECT 'Return Value' = @return_value", recordId);
            var result = GetSQLSingleValue(body);
            if (result != null && result != DBNull.Value)
            {
                int.TryParse(result.ToString(), out count);
            }
            return count;
        }

        #endregion

        #region INSERT

        public static bool AddNewClass(Document_Class docClass)
        {
            return AddNewClass(docClass.Name, docClass.Name_RU, docClass.Description, docClass.Description_RU);
        }

        public static bool AddNewClass(string name, string nameRU, string description, string descriptionRU)
        {
            using (var db = new DocContext())
            {
                var val = -3;
                try
                {
                    val = db.DocumentClassInsert(name, nameRU, description, descriptionRU);
                }
                catch (Exception e)
                {
                    _logger.Error(e, "Błąd dodawania nowej klasy, AddNewClass(), e: {0}", e);
                }
                int valInt = -1;
                Int32.TryParse(val.ToString(), out valInt);
                if (valInt > 0)
                    return true;
                else
                    return false;
            }
        }

        public static bool AddNewDocument(int classId, string name, string description, DateTime? releaseDate, string url, string oldFileName,
            List<Document_Index> indexes, int? assignedClassId = null, Int64? assignedDocumentId = null)
        {
            //budowanie query do update Dokumentu
            string tableName = GetTableNameById(classId);
            string assignedClassIdString = assignedClassId.HasValue && assignedClassId.Value > 0 ? assignedClassId.Value.ToString() : "NULL";
            string assignedDocumentIdString = assignedDocumentId.HasValue && assignedDocumentId.Value > 0 ? assignedDocumentId.Value.ToString() : "NULL";

            StringBuilder indexNames = new StringBuilder(), indexValues = new StringBuilder();

            foreach (Document_Index index in indexes)
            {
                if (index != null)
                {
                    indexNames.Append(string.Format(", {0}", index.Column_Name));
                    if (index.Data_Type == (int)Data.IndexTypes.Number)
                    {
                        indexValues.Append(string.Format(", {0}", index.Value != null && !string.IsNullOrEmpty(index.Value.ToString()) ? index.Value.ToString() : "NULL" ));
                    }
                    else if (index.Data_Type == (int)Data.IndexTypes.Date)
                    {
                        if (index.Value != null && !string.IsNullOrEmpty(index.Value.ToString()))
                            indexValues.Append(string.Format(", N'{0}'", index.Value.ToString().ToInsert()));
                        else
                            indexValues.Append(", NULL");
                    }
                    else
                    {
                        if(index.Value != null && !string.IsNullOrEmpty(index.Value.ToString()))
                            indexValues.Append(string.Format(", N'{0}'", index.Value.ToString().ToInsert()));
                        else
                            indexValues.Append(", NULL");
                    }

                    //kolumna z listą zaawansowaną wymusza dodatkową kolumnę z id rekordu listy zaawansowanej
                    if (index.Data_Type == (int)Data.IndexTypes.List)
                    {
                        if (!string.IsNullOrEmpty(index.ItemIdColumn_Name))
                        {
                            indexNames.Append(string.Format(", {0}", index.ItemIdColumn_Name));
                            indexValues.Append(string.Format(", {0}", index.ValueItemId.HasValue ? index.ValueItemId.Value.ToString() : "NULL"));
                        }
                    }
                }
            }

            StringBuilder builderQuery = new StringBuilder();
            builderQuery.Append(string.Format("INSERT INTO {0} ", tableName));
            builderQuery.Append(string.Format("({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}{9}) VALUES ",
                Document.Field.Name, Document.Field.Description, Document.Field.URL, Document.Field.OldFileName, Document.Field.Release_Date, Document.Field.Active,
                 Document.Field.Deactivate_Date, Document.Field.AssignedClassId, Document.Field.AssignedDocumentId, indexNames.ToString()));
            builderQuery.Append(string.Format("(N'{0}', N'{1}', N'{2}', N'{3}', ", name.ToInsert(), description.ToInsert(), url.ToInsert(), oldFileName.ToInsert()));
            builderQuery.Append(string.Format("N'{0}', {1}, {2}, {3}, {4}{5}) SELECT SCOPE_IDENTITY()", releaseDate.Value.ToString().ToInsert(), 1, "NULL", assignedClassIdString, assignedDocumentIdString, indexValues.ToString()));
            try
            {
                var sql = builderQuery.ToString();
                var val = GetSQLSingleValue(sql);

                bool success = false;
                if (val != null)
                    success = true;
                if (!success)
                {
                    _logger.Error("Funkcja SQL nie zwróciła poprawnej wartości id nowego dokumentu- dokument nie został zwolniony.");
                }

                return success;
            }
            catch (Exception e)
            {
                _logger.Error("Błąd tworzenia nowego dokumentu, AddNewDocument(), e: " + e);
                return false;
            }
        }

        public static Int64 AddNewDocumentWithReference(int classId, string name, string description, DateTime? releaseDate, string url, string oldFileName,
            List<Document_Index> indexes, int? assignedClassId = null, Int64? assignedDocumentId = null)
        {
            Int64 val = -1;
            string tableName = GetTableNameById(classId);
            bool success = AddNewDocument(classId, name, description, releaseDate, url, oldFileName, indexes, assignedClassId = null, assignedDocumentId = null);
            if (success)
            {
                var result = GetSQLSingleValue(string.Format("SELECT Id FROM {0} (NOLOCK) WHERE {1}=N'{2}' AND {3}=N'{4}'",
                    tableName, Document.Field.Name, name.ToInsert(), Document.Field.Description, description.ToInsert()));
                if (result != null && result != DBNull.Value)
                {
                    Int64.TryParse(result.ToString(), out val);
                }
            }
            return val;
        }

        public static bool AddNewDocumentDefinition(string namePL, string descriptionPL, string nameRU, string descriptionRU, int datatype, string items = null)
        {
            using (var db = new DocContext())
            {
                try
                {
                    int result = db.DocumentDefinitionInsert(namePL, descriptionPL, nameRU, descriptionRU, (byte)datatype, items);
                    if (result > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd tworzenia nowej definicji indeksu dokumentu, DocumentDefinitionInsert(), e: " + e);
                    return false;
                }
            }
        }

        public static bool AddNewDocumentDefinitionPerClass(int classId, int definitionId, bool required, bool active, string defaultValue)
        {
            using (var db = new DocContext())
            {
                var val = -3;
                try
                {
                    val = db.DocumentDefinitionPerClassInsert(classId, definitionId, required, active, defaultValue);
                }
                catch (Exception e)
                {
                    _logger.Error(e, "Błąd dodawania nowej definicji indeksu dla klasy, AddNewDocumentDefinitionPerClass(), e: {0}", e);
                }
                int valInt = -1;
                Int32.TryParse(val.ToString(), out valInt);
                if (valInt > 0)
                    return true;
                else
                    return false;
            }
        }

        public static bool AddSetting(string name, string value, string description = "")
        {
            using (var db = new DocContext())
            {
                var val = -1;
                try
                {
                    val = db.DocumentSettingInsert(name, value, description);
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd dodawania nowego rekordu ustawienia do bazy, nazwa: {0}, wartość: {1}, opis: {2}, e: {3}", name, value, description, e);
                }
                if (val > 0)
                    return true;
                else
                    return false;
            }
        }

        public static bool AddListItem(int definitionId, string name, bool active)
        {
            bool result = true;
            using (var db = new DocContext())
            {
                try
                {
                    int res = db.DocumentDefinitionListItemsInsert(definitionId, name, active);
                    if (res > 0)
                        result = true;
                    else
                        result = false;
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd dodawania rekordu listy AddListItem(), e: " + e);
                    return false;
                }
            }
            return result;
        }

        #endregion

        #region UPDATE

        public static bool UpdateDocumentClass(int id, string className, string classNameRU, string description, string descriptionRU, bool active)
        {
            using (var db = new DocContext())
            {
                try
                {
                    int result = db.DocumentClassUpdate(id, className, classNameRU, description, descriptionRU, active);
                    if (result > 0)
                        return true;
                    else
                        return false;
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd aktualizacji klasy, UpdateDocumentClass(), e: " + e);
                    return false;
                }
            }
        }

        public static bool UpdateDefinitionIndexOnly(int definitionId, string namePL = null, string descriptionPL = null, string nameRU = null,
            string descriptionRU = null, string items = null)
        {
            using (var db = new DocContext())
            {
                try
                {
                    int result = 0;
                    var res = db.DocumentDefinitionUpdate(definitionId, namePL, descriptionPL, nameRU, descriptionRU, items);
                    Int32.TryParse(res.ToString(), out result);
                    if (result > 0)
                        return true;
                    else
                        return false;
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd aktualizacji definicji indeksu, UpdateDefinitionIndexOnly(), e: " + e);
                    return false;
                }
            }
        }

        public static bool UpdateDefinitionIndexPerClass(int definitionPerClassId, bool? required = null, bool? active = null, string defaultValue = null)
        {
            using (var db = new DocContext())
            {
                try
                {
                    int result = 0;
                    var res = db.DocumentDefinitionPerClassUpdate(definitionPerClassId, required, active, defaultValue);
                    Int32.TryParse(res.ToString(), out result);
                    if (result != 0)
                        return true;
                    else
                        return false;
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd aktualizacji definicji indeksu dla klasy, DocumentDefinitionsPerClassUpdate(), e: " + e);
                    return false;
                }
            }
        }

        public static bool UpdateDocument(Int64 id, int classId, List<Document_Index> indexes, string name = null, string description = null,
            DateTime? releaseDate = null, bool? active = null, int? assignedClassId = null, Int64? assignedDocumentId = null)
        {
            //budowanie query do update Dokumentu
            StringBuilder builder = new StringBuilder();
            Document document = GetDocumentById(id, classId);
            if (string.IsNullOrEmpty(document.Table_Name))
            {
                _logger.Error("Błąd aktualizacji dokumentu, nie udało się pobrać dokumentu z bazy, klasa: {0}, dokument:{1}", classId, id);
                return false;
            }
            builder.Append(string.Format("UPDATE TOP (1) {0} SET ", document.Table_Name));
            if (document.Name != name)
            {
                builder.Append(string.Format("{0}=N'{1}', ", Document.Field.Name, name.ToInsert()));
            }
            if (document.Description != description)
            {
                builder.Append(string.Format("{0}=N'{1}', ", Document.Field.Description, description.ToInsert()));
            }
            if (document.Release_Date != releaseDate.Value)
            {
                builder.Append(string.Format("{0}=N'{1}', ", Document.Field.Release_Date, releaseDate.Value.Date.ToShortDateString()));
            }
            if ((document.AssignedClassId != assignedClassId) || (document.AssignedDocumentId != assignedDocumentId))
            {
                builder.Append(string.Format("{0}={1}, ", Document.Field.AssignedDocumentId, assignedDocumentId.Value));
                builder.Append(string.Format("{0}={1}, ", Document.Field.AssignedClassId, assignedClassId.Value));
            }
            
            if (indexes != null && indexes.Count > 0)
            {
                foreach (Document_Index index in indexes)
                {
                    if (index.Value == null || string.IsNullOrEmpty(index.Value.ToString()))
                    {
                        builder.Append(string.Format("{0}=NULL, ", index.Column_Name));
                    }
                    else if (index.Data_Type == (int)Data.IndexTypes.Number)
                    {
                        builder.Append(string.Format("{0}={1}, ", index.Column_Name, index.Value.ToString()));
                    }
                    else
                    {
                        builder.Append(string.Format("{0}=N'{1}', ", index.Column_Name, index.Value.ToString().ToInsert()));
                    }
                    //to jeszcze kolumna zawierająca id rekordu listy zaawansowanej
                    if (index.Data_Type == (int)Data.IndexTypes.List)
                    {
                        if (!string.IsNullOrEmpty(index.ItemIdColumn_Name))
                        {
                            builder.Append(string.Format("{0}={1}, ", index.ItemIdColumn_Name, index.ValueItemId.HasValue ? index.ValueItemId.Value.ToString() : "NULL"));
                        }
                    }
                }
            }
            if (active.HasValue && (active != document.Active))
            {
                builder.Append(string.Format("{0}={1}, ", Document.Field.Active, active.Value == true ? "1" : "0"));
                builder.Append(string.Format("{0}={1}, ", Document.Field.Deactivate_Date, active.Value == true ? "NULL" : "CURRENT_TIMESTAMP"));
            }
            //te pola są dołączane zawsze, dlatego wszystkie poprzednie wpisy muszą zawierać przecinki bez sprawdzania, czy jest coś po nich
            builder.Append(string.Format("{0}=N'{1}', {2}=CURRENT_TIMESTAMP ", Document.Field.Edit_User, Security.GetUserLogin(), Document.Field.Edit_Date));
            builder.Append(string.Format("WHERE Id={0}", id));
            try
            {
                var sql = builder.ToString();
                GetSQLSingleValue(sql);
                return true;
            }
            catch (Exception e)
            {
                _logger.Error("Błąd aktualizacji dokumentu, UpdateDocument(), e: " + e);
                return false;
            }
        }

        public static bool UpdateDocumentFile(Int64 id, int classId, string URL, string oldFileName = null)
        {
            //budowanie query do update Dokumentu
            StringBuilder builder = new StringBuilder();
            Document document = GetDocumentById(id, classId);
            if (string.IsNullOrEmpty(document.Table_Name))
            {
                _logger.Error("Błąd aktualizacji pliku dokumentu, nie udało się pobrać dokumentu z bazy, klasa: {0}, dokument:{1}", classId, id);
                return false;
            }
            builder.Append(string.Format("UPDATE TOP (1) {0} SET ", document.Table_Name));
            builder.Append(string.Format("{0}=N'{1}', ", Document.Field.URL, URL));
            if (string.IsNullOrEmpty(oldFileName) == false)
            {
                builder.Append(string.Format("{0}=N'{1}', ", Document.Field.OldFileName, oldFileName));
            }

            //te pola są dołączane zawsze, dlatego wszystkie poprzednie wpisy muszą zawierać przecinki bez sprawdzania, czy jest coś po nich
            builder.Append(string.Format("{0}=N'{1}', {2}=CURRENT_TIMESTAMP ", Document.Field.Edit_User, Security.GetUserLogin(), Document.Field.Edit_Date));
            builder.Append(string.Format("WHERE Id={0}", id));
            try
            {
                var sql = builder.ToString();
                GetSQLSingleValue(sql);
                return true;
            }
            catch (Exception e)
            {
                _logger.Error("Błąd aktualizacji pliku dokumentu, UpdateDocument(), e: " + e);
                return false;
            }
        }

        public static bool UpadateListItem(int itemId, int definitionId, string name, bool active)
        {
            bool result = true;
            using (var db = new DocContext())
            {
                try
                {
                    int res = db.DocumentDefinitionListItemsUpdate(itemId, definitionId, name, active);
                    if (res > 0)
                        result = true;
                    else
                        result = false;
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd aktualizowania rekordu listy UpadateListItem(), e: " + e);
                    return false;
                }
            }
            return result;
        }

        #endregion

        #region DELETE

        public static bool DeleteClass(int classId)
        {
            using (var db = new DocContext())
            {
                try
                {
                    var result = db.DocumentClassDelete(classId);
                    return true;
                }
                catch (Exception e)
                {
                    _logger.Error(e, "Błąd usuwania klasy, e: {0}" + e);
                    return false;
                }
            }
        }

        public static bool DeleteDocumentFromDB(Int64 documentId, int classId, bool deleteAssignAndOznaczenia, string tableName = "")
        {
            try
            {
                string table;

                if (classId > 0)
                {
                    table = GetTableNameById(classId);
                }
                else
                {
                    table = tableName;
                }
                
                //usuwanie wraz 
                string deleteQuery = string.Format("DELETE TOP(1) FROM {0} WHERE {1}={2}", table, Document.Field.Id, documentId);
                if (deleteAssignAndOznaczenia)
                {
                    ClearAssignedDocuments(documentId, classId);
                    //dopisanie na początku usuwania oznaczeń dla dokumentu
                    deleteQuery = string.Format("DELETE Oznaczenia WHERE Class_Id={0} AND Document_Id={1} {2}", classId, documentId, deleteQuery);
                }
                //trzeba jeszcze wyczyścić powiązania, jeżeli mamy zamiar wykorzystywać funkcję do usuwania dokumentów z bazy
                var returnValue = GetSQLSingleValue(deleteQuery);
                return true;
            }
            catch (Exception e)
            {
                _logger.Error(e, "Błąd usuwania dokumentu, e: {0}", e);
                return false;
            }
        }

        public static void UpdateAssignedDocuments(Int64 documentId, int classId, Int64 newDocumentId, int newClassId)
        {
            using (var db = new DocContext())
            {
                try
                {
                    db.ACT_UpdateAssign(documentId, classId, newDocumentId, newClassId);
                }
                catch (Exception e)
                {
                    _logger.Error(e, "Błąd aktualizowania powiązań dla dokumentu {0} w klasie {1}, e: {2}", documentId, classId, e);
                }
            }
        }

        public static void ClearAssignedDocuments(Int64 documentId, int classId)
        {
            using (var db = new DocContext())
            {
                try
                {
                    db.ACT_DeleteAssign(documentId, classId);
                }
                catch (Exception e)
                {
                    _logger.Error(e, "Błąd usuwania powiązań dla dokumentu {0} w klasie {1}, e: {2}", documentId, classId, e);
                }
            }
            //czy przetestowano
            //var classTables = GetSQLTableValue(string.Format("SELECT {0} FROM Document_Class", Document_Class.Field.Table_Name));
            //try
            //{
            //    foreach (DataRow altairRow in classTables.Rows)
            //    {
            //        //czyszczenie powiązań w pętli po wszystkich klasach dla jednego dokumentu
            //        var tableName = altairRow[0].ToString();
            //        var sql = string.Format("UPDATE {0} SET {1}=NULL, {2}=NULL WHERE {1}={4} AND {2}={3}",
            //            tableName, Document.Field.AssignedClassId, Document.Field.AssignedDocumentId, documentId, classId);
            //        GetSQLSingleValue(sql);
            //    }
            //}
            //catch (Exception)
            //{
            //}
        }

        public static void UpdateOznaczeniaId(Int64 documentId, int classId, Int64 newDocumentId, int newClassId)
        {
            using (var db = new DocContext())
            {
                try
                {
                    db.ACT_UpdateOznaczeniaId(documentId, classId, newDocumentId, newClassId);
                }
                catch (Exception e)
                {
                    _logger.Error(e, "Błąd aktuazliowania znaczeń dla dokumentu {0} w klasie {1}, e: {2}", documentId, classId, e);
                }
            }
        }

        public static bool DeleteDocumentDefinition(int defId)
        {
            using (var db = new DocContext())
            {
                try
                {
                    int result = db.DocumentDefinitionDelete(defId);
                    if (result > 0)
                        return true;
                    else
                        return false;
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd usuwania definicji indeksu, id: {0}, e: {1}", defId, e);
                    return false;
                }
            }
        }

        public static bool DeleteDocumentIndexDefinitionPerClass(int defId)
        {
            using (var db = new DocContext())
            {
                try
                {
                    var result =  db.DocumentDefinitionPerClassDelete(defId);
                    if (result > 0)
                        return true;
                    else return false;
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd usuwania powiązania definicji indeksu z klasą, Id: {0}, e: {1}", defId, e);
                    return false;
                }
            }
        }

        public static bool DeleteSetting(string name)
        {
            using (var db = new DocContext())
            {
                try
                {
                    Document_Settings setting = db.Document_Settings.First(ds => ds.Name == name);
                    db.Document_Settings.Remove(setting);
                    if (db.SaveChanges() > 0)
                        return true;
                    else
                        return false;
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd usuwania urekordu ustawienia, nazwa: {0}, e: {1}", name, e);
                    return false;
                }
            }
        }

        public static bool DeleteListItem(int itemId)
        {
            bool result = true;
            using (var db = new DocContext())
            {
                try
                {
                    int res = db.DocumentDefinitionListItemsDelete(itemId);
                    if (res > 0)
                        result = true;
                    else
                        result = false;
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd usuwania rekordu listy DeleteListItem(), e: " + e);
                    return false;
                }
            }
            return result;
        }

        #endregion

    }
}
