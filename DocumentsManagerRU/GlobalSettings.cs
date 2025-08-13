using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DocumentsManagerRU.ImpersonationClass;
using NLog;

namespace DocumentsManagerRU
{
    public static class GlobalSettings
    {
        #region SETTINGS IN DATABASE

        public static Logger _logger = LogManager.GetCurrentClassLogger();
        public static IEnumerable<Document_Settings> AllSettings = GetAllSettings();
        public static UserCredentials ScanOperator = GetScansOperator();

        [StructLayout(LayoutKind.Sequential, Size = 1)]
        public struct SettingsDictionary
        {
            public const string ServerDirectorySTRING = "ServerPath";
            public const string DeleteAfterReleaseBOOL = "DeleteAfterRelease";
            public const string SendEmailAfterReleaseBOOL = "SendEmailOnRelease";
            public const string ScansOperator_STRING = "ScansOperator";
            public const string UseExternalViewer_BOOL = "UseExternalViewer";
            public const string UpdaterSTRING = "UpdaterPath";
            public const string AlertEmailsSTRING = "AlertEmails";
        }

        /// <summary>
        /// Pobranie pojedynczej właściwości ustawień globalnych - tekstu, bezpośrednio z bazy danych
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetSetting_DB(string name)
        {
            return GetSingleSetting_DB(name).Value;
        }

        /// <summary>
        /// Pobranie pojedynczej właściwości ustawień globalnych - tekstu, z pamięci
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetSetting_Temp(string name)
        {
            return GetSingleSetting_Temp(name).Value;
        }

        /// <summary>
        /// Pobranie pojedynczej właściwości ustawień globalnych, flagi bezpośrednio z bazy danych
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool? GetFlagSetting_DB(string name)
        {
            var val = GetSingleSetting_DB(name).Value;
            if (string.IsNullOrEmpty(val)) return null;
            if (val == "1")
                return true;
            else
                return false;
        }

        /// <summary>
        /// Pobranie pojedynczej właściwości ustawień globalnych - flagi, z pamięci
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool? GetFlagSetting_Temp(string name)
        {
            var val = GetSingleSetting_Temp(name).Value;
            if (string.IsNullOrEmpty(val)) return null;
            if (val == "1")
                return true;
            else
                return false;
        }

        /// <summary>
        /// Ustawienie wartości, oraz opisu danej właściwości ustawień globalnych- tekstu, w bazie danych
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="description"></param>
        public static void SetSetting(string name, string value, string description = "")
        {
            using (var db = new DocContext())
            {
                try
                {
                    db.DocumentSettingUpdate(name, value, description);
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd aktualizacji rekordu ustawień, SetFlagSetting({0},{1},{2}), e: {3}", name, value, description, e);
                }
            }
        }

        /// <summary>
        /// Ustawienie wartości, oraz opisu danej właściwości ustawień globalnych- flagi, w bazie danych
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="description"></param>
        public static void SetFlagSetting(string name, bool value, string description = "")
        {
            using (var db = new DocContext())
            {
                try
                {
                    db.DocumentSettingUpdate(name, value ? "1" : "0", description);
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd aktualizacji rekordu ustawień typu bool, SetFlagSetting({0},{1},{2}), e: {3}", name, value, description, e);
                }
            }
        }

        /// <summary>
        /// Ustawienie opisu dla pojecynczej właściwości ustawień w bazie danych
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        public static void SetSettingDescription(string name, string description)
        {
            using (var db = new DocContext())
            {
                try
                {
                    Document_Settings setting = db.Document_Settings.First(ds => ds.Name == name);
                    setting.Description = description;
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd aktualizacji opisu rekordu ustawień, SetSettingDescription({0}, {1}) e: {2}", name, description, e);
                }
            }
        }

        /// <summary>
        /// Pobranie wszystkich ustawień bezpośrednio z bazy danych
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Document_Settings> GetAllSettings()
        {
            using (var db = new DocContext())
            {
                try
                {
                    return db.Document_Settings.ToList();
                }
                catch (Exception e)
                {
                    _logger.Error(e, "Błąd pobierania wszystkich prametrów ustawień z bazy: GetAllSettings(), e: {0}", e);
                    return new Document_Settings[0];
                }
            }
        }

        /// <summary>
        /// Pobranie pojedynczej właściwości ustawień globalnych z pamięci
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Document_Settings GetSingleSetting_Temp(string name)
        {
            try
            {
                return AllSettings.FirstOrDefault(ds => ds.Name == name);
            }
            catch (Exception e)
            {
                _logger.Error("Błąd pobierania ustawienia z bazy: GetSingleSetting({0}), e:{1}", name, e);
                return new Document_Settings();
            }
        }

        /// <summary>
        /// Pobranie pojedynczej właściwości ustawień globalnych bezpośrednio z bazy danych
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Document_Settings GetSingleSetting_DB(string name)
        {
            using (var db = new DocContext())
            {
                try
                {
                    return db.Document_Settings.FirstOrDefault(ds => ds.Name == name);
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd pobierania ustawienia z bazy: GetSingleSetting({0}), e:{1}", name, e);
                    return new Document_Settings();
                }
            }
        }

        /// <summary>
        /// Pobranie poświadczeń użytkownika upoważnionego do operacji na dokumentach w bazie danych
        /// </summary>
        /// <returns></returns>
        public static UserCredentials GetScansOperator()
        {
            if (Data.IsTestDatabase()) return null;

            var key = GlobalSettings.GetSetting_Temp(SettingsDictionary.ScansOperator_STRING);
            if (string.IsNullOrEmpty(key))
                return null;
            string[] credentials = Regex.Split(key, ",");
            UserCredentials user = new UserCredentials(credentials[0], credentials[1], credentials[2]);
            return user;
        }

        #endregion
    }
}
