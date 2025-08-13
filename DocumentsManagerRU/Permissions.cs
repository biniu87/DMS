using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace DocumentsManagerRU
{
    public static class Permissions
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public enum ClassPrimaryPermissions
        {
            None = 0,
            Read = 1,
            Edit = 2,
            Delete = 3
        }

        /// <summary>
        /// Poświadczenia do rozszerzonego wyświetlania klas
        /// </summary>
        public enum ClassSecondaryPermissions
        {
            None = 0,
            Release = 1,
            ActiveOnly = 2,
            AdminPermissions = 3
        }

        public enum OperationsPermissions
        {
            None = 0,
            WithModifications = 1,
            WithoutModifications = 2
        }

        public enum ModificationsPermissions
        {
            None = 0,
            New = 1,
            Modify = 2
        }

        /// <summary>
        /// Metoda dopisująca warunki poświadczeń dostepu do dokumentów uwzględniając poświadczenia dla rekordów list zaawansowanych 
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="permissions"></param>
        /// <returns></returns>
        public static string IncludePermissionsItemsConditions(string condition, List<GetDocumentListItemsPermissionsToSelect_Result> permissions, bool isAdmin)
        {

            //bool open = condition.Length > 2 && permissions.Count > 0;
            string newCondition = condition;
            int i = 0;
            if (permissions != null && permissions.Count > 0 && !isAdmin) //dodawanie gdy jakikolwiek warunek znajduje się na liście, a użytkownik nie jest adminem
            {
                //uwaga, nazwa kolumny przechowującej classId rekordów, to nazwa kolumny głównej + classId o.e.: "col_3id"
                foreach (string column in permissions.Select(p => p.ColumnName).Distinct().ToArray())
                {
                    newCondition = newCondition + " AND (" + (i == 0 ? "(" : ""); //otwarcie nawiasiczku dla całego security
                    i++;
                    //nadanie klauzuli dla wartości pustej
                    newCondition = string.Format("{0}{1}id IS NULL ", newCondition, column);
                    foreach (var record in permissions.Where(p => p.ColumnName == column))
                    {
                        newCondition = string.Format("{0} OR {1}id={2}", newCondition, record.ColumnName, record.ItemId);
                    }
                    newCondition = newCondition + ") "; // zamknięcie grupy warunków dla pojedynczej kolumny
                }
                newCondition = newCondition + ") "; //zamknięcie nawiasu głównego
            }
            return newCondition;
        }

        /// <summary>
        /// Pobranie poświadczeń dostępu do klasy dla zalogowanego użytkownika, oraz wszystkich grup AD do których należy
        /// </summary>
        /// <param name="classId">Id klasy</param>
        /// <param name="securityObjects">Obiekty Security do których należy zalogowany użytkownik</param>
        /// <returns></returns>
        public static ClassPermissions GetPermissionsVector(int classId, string securityObjects)
        {
            ClassPermissions classPermissions = new ClassPermissions();
            using (var db = new DocContext())
            {
                try
                {
                    var cp = db.GetClassPermissionsVector(securityObjects, classId).FirstOrDefault();
                    classPermissions.PrimaryPermission = (Permissions.ClassPrimaryPermissions)cp.Permission;
                    classPermissions.CanRelease = cp.Release.HasValue && cp.Release.Value;
                    classPermissions.MailOnRelease = cp.MailOnRelease.HasValue && cp.Release.Value;
                }
                catch (Exception e)
                {
                    _logger.Error(string.Format("Wystąpił błąd w trakcie pobierania wektora poświadczeń, klasa: {0}, {1}", classId, e));
                }
            }
            return classPermissions;
        }

        public static int GetPermissionForListItemId(int classId, int securityId, int itemId)
        {
            int count = -1;
            string sql = string.Format("SELECT Id FROM Document_ListItems_Permissions (NOLOCK) WHERE ClassId = {0} AND SecurityId = {1} AND ItemId = {2}",
                        classId, securityId, itemId);
            var val = Data.GetSQLSingleValue(sql);
            Int32.TryParse(val != null ? val.ToString() : string.Empty, out count);
            return count;
        }

        public static IEnumerable<GetDocumentListItemsPermissionsToSelect_Result> GetDocumentListItemsPermissionsToSelectClass(int classId, string security)
        {
            using (var db = new DocContext())
            {
                try
                {
                    return db.GetDocumentListItemsPermissionsToSelect(classId, security).ToList();
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd pobierania poświadczeń dla rekordów lisy klasy o id: {0}, e:{1}", classId, e);
                    return new List<GetDocumentListItemsPermissionsToSelect_Result>();
                }
            }
        }

        public static IEnumerable<Document_Permissions> GetPermissionsForSecurity(int securityId)
        {
            using (var db = new DocContext())
            {
                try
                {
                    return db.Document_Permissions.Where(dp => dp.SecurityId == securityId).ToList();
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd pobierania poświadczeń dla obiektu security o id: {0}, e:{1}", securityId, e);
                    return new List<Document_Permissions>();
                }
            }
        }

        public static IEnumerable<Document_Permissions> GetPermissionsForClass(int classId)
        {
            using (var db = new DocContext())
            {
                try
                {
                    return db.Document_Permissions.Where(dp => dp.ClassId == classId).ToList();
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd pobierania poświadczeń dla klasy o id: {0}, e:{1}", classId, e);
                    return new List<Document_Permissions>();
                }
            }
        }

        public static bool SetPermissionToItem(int itemId, int classId, int securityId, bool permission)
        {
            bool result = true;
            using (var db = new DocContext())
            {
                try
                {
                    int res = db.DocumentListItemsPermissionsInsert(itemId, classId, securityId, permission);
                    if (res > 0)
                        result = true;
                    else
                        result = false;
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd dodawania poświadczenia dla rekordu AddItemPermission(), e: " + e);
                    return false;
                }
            }
            return result;
        }

        public static bool AddClassPermission(int classId, int userId, int permission, int print, int save, int send, int mHighlight,
            int mBlackout, int mNote, bool chHighlight, bool chBlackout, bool chNote, bool csMail, bool dcRelease)
        {
            var val = -1;
            using (var db = new DocContext())
            {
                try
                {
                    val = db.DocumentPermissionInsert(userId, classId, permission, print, save, send, mHighlight, mBlackout, mNote, chHighlight, chBlackout, chNote, csMail, dcRelease);
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd nawadawania uprawnień AddPermission({0}, {1}, {2}), e: ", userId, classId, permission, e);
                }
            }
            if (val > 0)
                return true;
            else
                return false;

        }

        public static bool DeletePermission(int securityId, int classId)
        {
            using (var db = new DocContext())
            {
                try
                {
                    db.Document_Permissions.Remove(db.Document_Permissions.First(dp => (dp.ClassId == classId) && (dp.SecurityId == securityId)));
                    db.SaveChangesAsync();
                    return true;
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd usuwania uprawnień do klasy, obiekt security: {0}, classId: {1}, e: {2}", securityId, classId, e);
                    return false;
                }
            }
        }

        public static bool DeleteAllPermissionsForUser(int? userId)
        {
            using (var db = new DocContext())
            {
                var val = -1;
                try
                {
                    val = db.DocumentPermissionDelete(userId, 0);
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd usuwania wszystkich poświadczeń dostępu do klas dla użytkownika o Id: {0}, e: {1}", userId, e);
                    return false;
                }
                if (val > 0)
                    return true;
                else
                    return false;
            }
        }

        public static bool DeleteListItemPermission(int permissionId)
        {
            bool result = true;
            using (var db = new DocContext())
            {
                try
                {
                    int res = db.DocumentListItemsPermissionsDelete(permissionId);
                    if (res > 0)
                        result = true;
                    else
                        result = false;
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd usuwania poświadczenia dla rekordu DeleteListItemPermission(), e: " + e);
                    return false;
                }
            }
            return result;
        }
    }



}
