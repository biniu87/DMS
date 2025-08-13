using System;
using System.Collections;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace DocumentsManagerRU
{
    /// <summary>
    /// Klasa obsługująca dostęp do Active Directory
    /// </summary>
    public static class Security
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public static string SecurityObjects = GetSecurityObjects();
        public static bool Admin = IsAdminInSecurity();
        public static bool Active = IsActiveInSecurity();

        /// <summary>
        /// Pobranie wszystkich domen z AD
        /// </summary>
        /// <returns></returns>
        public static ArrayList EnumerateDomains()
        {
            ArrayList alDomains = new ArrayList();
            Forest currentForest = Forest.GetCurrentForest();
            DomainCollection myDomains = currentForest.Domains;

            foreach (Domain objDomain in myDomains)
            {
                alDomains.Add(objDomain.Name);
            }
            return alDomains;
        }

        /// <summary>
        /// pobieranie wszystkich grup z AD
        /// </summary>
        /// <returns></returns>
        public static List<GroupPrincipal> GetGroups()
        {
            List<GroupPrincipal> allDomains = new List<GroupPrincipal>();
            List<GroupPrincipal> gpFiltered = new List<GroupPrincipal>();
            Forest currentForest = Forest.GetCurrentForest();
            DomainCollection myDomains = currentForest.Domains;
            foreach (Domain objDomain in myDomains)
            {
                // create your domain context
                try
                {
                    if (!objDomain.Name.ToLower().Contains("ru"))
                    {
                        PrincipalContext ctx = new PrincipalContext(ContextType.Domain, objDomain.Name);
                        GroupPrincipal qbeGroup = new GroupPrincipal(ctx);
                        PrincipalSearcher srch = new PrincipalSearcher(qbeGroup);
                        List<Principal> gpl = new List<Principal>();
                        gpl = srch.FindAll().ToList();
                        foreach (GroupPrincipal found in gpl)
                        {
                            allDomains.Add(found);        
                        }
                    }
                }
                catch (Exception)
                {
                }
            }

                gpFiltered.AddRange(allDomains.Distinct().Where(gp => FilterGroupName(gp.SamAccountName, new string[0/*tutaj można wstawić nazwy działów*/],  new string[] {"_10", "_20", "_30", "_SH", "_RSH"})
                ).OrderBy(gp => gp.SamAccountName).ToList());
            return gpFiltered;
        }

        public static bool FilterGroupName(string name, string[] prefikses, string[] suffikses)
        {
            foreach (string pre in prefikses)
                if (name.StartsWith(pre))
                    return false;

            foreach (string suff in suffikses)
                if (name.EndsWith(suff))
                    return false;
            return true;
        }

        /// <summary>
        /// Pobiera wszystkie grupy AD, do których przynależy zalogowany użytkownik
        /// </summary>
        /// <returns></returns>
        public static List<Principal> GetLoggedUserGroups()
        {
            try
            {
                PrincipalSearchResult<Principal> groups = UserPrincipal.Current.GetGroups();
                return groups.Select(x => x).ToList();

                Forest currentForest = Forest.GetCurrentForest();
                string domainName = string.Empty;
                DomainCollection myDomains = currentForest.Domains;

                foreach (Domain objDomain in myDomains)
                {
                    if (objDomain.Name.ToLower().Contains("pila"))
                    {
                        domainName = objDomain.Name;
                        break;
                    }
                }

                UserPrincipal user = UserPrincipal.FindByIdentity(new PrincipalContext(ContextType.Domain, domainName), IdentityType.SamAccountName, GetUserLogin());
                List<Principal> plist = user.GetGroups().Select(x => x).ToList();
                List<Principal> plist2 = user.GetGroups(new PrincipalContext(ContextType.Domain, domainName)).Select(x => x).ToList();

                return groups.Select(x => x).ToList();
            }
            catch (Exception)
            {
                return new List<Principal>();
            }
        }

        public static List<GroupPrincipal> GetGroups2(string userName)
        {
            List<GroupPrincipal> result = new List<GroupPrincipal>();

            // establish domain context
            PrincipalContext yourDomain = new PrincipalContext(ContextType.Domain);

            // find your user
            UserPrincipal user = UserPrincipal.FindByIdentity(yourDomain, userName);

            // if found - grab its groups
            if (user != null)
            {
                PrincipalSearchResult<Principal> groups = user.GetAuthorizationGroups();

                // iterate over all groups
                foreach (Principal p in groups)
                {
                    // make sure to add only group principals
                    if (p is GroupPrincipal)
                    {
                        result.Add((GroupPrincipal)p);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Pobieranie wszystkich użytkowników, jakich zawiera dana grupa AD
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public static List<UserPrincipal> GetUsersFromGroup(GroupPrincipal group)
        {
            
            List<UserPrincipal> users = new List<UserPrincipal>();
            foreach (Principal user in group.Members.OrderBy(m => m.SamAccountName))
            {
                if (user is UserPrincipal)
                {
                    users.Add((UserPrincipal)user);
                }
            }
            return users;
        }

        /// <summary>
        /// Pobierz wszystkie grupy i login zalogowanego użytkownika, jako sformatowany string
        /// </summary>
        /// <returns></returns>
        public static string GetSecurityObjects()
        {
            //List<Principal> userGroups = GetLoggedUserGroups();
            string result = string.Empty;
            try
            {
                List<Principal> userGroups = GetLoggedUserGroups();
                var user = Security.GetUserLogin();
                string[] users = {};
                if (userGroups.Count == 0)
                {
                    return string.Join(",", GetPrincipalString(user)) + "," + user;
                }
                if (users.Contains(user.ToLower()))
                {
                    /*rozwiązane dla specjalnych użytkowników przez uwarunkowania techniczne*/
                    return "ZA_Z," + user;
                }
                else if (userGroups.Count == 0)
                {
                    int i = 1;
                    //lista powinna na 100% zawierać dane
                    while (i <= 10 && userGroups.Count == 0)
                    {
                        //ponowne pobranie grup
                        System.Threading.Thread.Sleep(100);
                        userGroups = GetLoggedUserGroups();
                        i++;
                    }
                    //raport do binia
                    StringBuilder mail = new StringBuilder();
                    mail.AppendLine("Wystąpił problem w trakcie dostępu do list AD, związany ze zwracaniem pustej listy grup!" + Environment.NewLine);
                    mail.AppendLine(Data.IsTestDatabase() ? "TEST" : "PRODUKCJA");
                    mail.AppendLine("Czas wystąpienia: " + DateTime.Now.ToString());
                    mail.AppendLine("Użytkownik: " + Security.GetUserLogin());
                    mail.AppendLine("Lista grup: " + string.Join(",", userGroups.Select(u => u.SamAccountName).ToList()));
                    mail.AppendLine("Numer przebiegu zakończonego sukcesem: " + i.ToString());
                    Data.SendMail("DMS ALERT - DOSTĘP DO AD", "", mail.ToString());
                }
                result = string.Join(",", userGroups.Select(u => u.SamAccountName).ToList()) + "," + GetUserLogin();
            }
            catch (Exception e)
            {
                _logger.Error("Błąd podczas pobierania listy grup użytkownika z AD, " + e.Message);
            }
            return result;
        }

        private static List<string> GetPrincipalString(string userName)
        {
            List<string> result = new List<string>();
            WindowsIdentity wi = new WindowsIdentity(userName);

            foreach (IdentityReference group in wi.Groups)
            {
                try
                {
                    result.Add(group.Translate(typeof(NTAccount)).ToString());
                }
                catch (Exception ex) { }
            }
            result.Sort();
            return result;
        }

        public static string GetUserLogin()
        {
            // login bez domeny
            var login = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToLower();
            login = login.Substring(login.IndexOf('\\') + 1);
            return login;
        }

        public static bool IsSuperUser()
        {
            var user = GetUserLogin();
            if (user.ToLower().Equals("marcin"))
                return true;
            else
                return false;
        }

        #region Database

        public static bool InsertSecurity(string name, string description, bool active, bool admin, bool isGroup)
        {
            using (var db = new DocContext())
            {
                try
                {
                    db.DocumentSecurityInsert(name, description, active, admin, isGroup);
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd wstawiania do bazy, danych obiektu security o nazwie: {0}, e:{1}", name, e);
                    return false;
                }
            }
            return true;
        }

        public static bool UpdateSecurity(string name, string description, bool active, bool admin)
        {
            using (var db = new DocContext())
            {
                try
                {
                    db.DocumentSecurityUpdate(name, description, active, admin);
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd aktualizacji danych obiektu security o nazwie: {0}, e:{1}", name, e);
                    return false;
                }
            }
            return true;
        }

        public static bool UpdateSecurity(int classId, int securityId, string columnName, string value)
        {
            using (var db = new DocContext())
            {
                try
                {
                    db.DocumentPermissionSimpleUpdate(securityId, classId, columnName, value);
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd akrualizacji poświadczeń dla obiektu security {0}, klasy {1} i pola {2}, e: {3}", securityId, classId, columnName, e);
                    return false;
                }
            }
            return true;
        }

        public static bool DeleteSecurity(string name)
        {
            using (var db = new DocContext())
            {
                try
                {
                    db.DocumentSecurityDelete(name);
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd usuwania danych obiektów security o nazwach: {0}, e:{1}", name, e);
                    return false;
                }
            }
            return true;
        }

        public static bool IsAdminInSecurity()
        {
            var script = string.Format("SELECT MAX(CAST([Admin] AS TINYINT)) FROM Document_Security (NOLOCK) WHERE Name IN (SELECT CONVERT(NVARCHAR, Value) FROM dbo.Split('{0}', ','))", SecurityObjects);
            var result = Data.GetSQLSingleValue(script);
            if (result == null || result == DBNull.Value) return false;
            int resultInt = 0;
            Int32.TryParse(result.ToString(), out resultInt);
            if (resultInt <= 0)
                return false;
            else
                return true;
        }

        public static bool IsActiveInSecurity()
        {
            var result = Data.GetSQLSingleValue(string.Format("SELECT MAX(CAST([Active] AS TINYINT)) FROM Document_Security (NOLOCK) WHERE Name IN (SELECT CONVERT(NVARCHAR, Value) FROM dbo.Split('{0}', ','))", SecurityObjects));
            if (result == null || result == DBNull.Value)
                return false;
            int resultInt = -1;
            if (Int32.TryParse(result.ToString(), out resultInt))
                if (resultInt <= 0)
                    return false;
                else
                    return true;
            else
                return false;
        }

        #endregion
    }
}
