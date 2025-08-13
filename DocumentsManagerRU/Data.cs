using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentsManagerRU.ImpersonationClass;
using NLog;

namespace DocumentsManagerRU
{
    public static partial class Data
    {
        //public static Logger _logger = LogManager.GetLogger("DATA");
        public static Logger _logger = LogManager.GetCurrentClassLogger();

        public enum DefinitionDirectives
        {
            All = 0,
            Assigned = 1,
            Unassigned = 2,
            AdvancedListOnly = 3
        }

        public enum IndexTypes
        {
            Date = 0,
            Number = 1,
            String = 2,
            List = 3,
            SimpleList = 4
        }

        public enum LogLevels
        {
            INFO = 0,
            WARNING = 1,
            ERROR = 2,
            FATAL = 3
        }

        public const string INDEX_SEPARATOR = "$#";// "\r\n";

        #region TECHNICAL STUFF

        public static ToolTip SetToolTip(Control control, string text)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(control, text);
            return toolTip;
        }

        public static string[] IndexItemsSplit(string source, string separator = "")
        {
            if(string.IsNullOrEmpty(source))
                return new string[0];
            string[] items = Regex.Split(source, string.IsNullOrEmpty(separator) ? Data.INDEX_SEPARATOR : separator);
            items = source.Split(new string[] { string.IsNullOrEmpty(separator) ? Data.INDEX_SEPARATOR : separator }, StringSplitOptions.None);
            return items;
        }

        public static string IndexItemsMerge(string[] items, string separator = "")
        {
            string result = String.Join(string.IsNullOrEmpty(separator) ? Data.INDEX_SEPARATOR : separator, items);
            return result;
        }

        public static IDictionary<int, string> IndexItemsDictionary(string[] items)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            for (int i = 0; i < items.Length; i++)
            {
                dictionary.Add(i + 1, items[i]);
            }
            return dictionary;
        }

        public static IDictionary<int, string> IndexAdvancedItemsDictionary(List<Document_DefinitionList_Items> items)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            for (int i = 0; i < items.Count; i++)
            {
                var item = items.ElementAt(i);
                dictionary.Add(item.Id, item.Name);
            }
            return dictionary;
        }

        public static IDictionary<int, string> IndexAdvancedItemsDictionary(Document_Definitions definition)
        {
            Dictionary<int, string> dictionary = 
                (Dictionary<int, string>)IndexAdvancedItemsDictionary((List<Document_DefinitionList_Items>)definition.Document_DefinitionList_Items.ToList());
            return dictionary;
        }

        public static IDictionary<int, string> IndexItemsDictionary(string items)
        {
            string[] parsedItems = IndexItemsSplit(items);
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            for (int i = 0; i < parsedItems.Length; i++)
            {
                dictionary.Add(i + 1, parsedItems[i]);
            }
            return dictionary;
        }

        /// <summary>
        /// Pobranie słownika wszystkich klas; uwzględnia poświadczenia
        /// </summary>
        /// <param name="lang"></param>
        /// <param name="securityObjects"></param>
        /// <returns></returns>
        public static IDictionary<int, string> GetAllClassDictionary(string lang, string securityObjects)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            List<GetDocumentsClass_Result> list = GetClassToRelease(lang, securityObjects).ToList();
            foreach (var dc in list)
            {
                dictionary.Add(dc.Id, dc.Name);
            }
            return dictionary;
        }

        public static IDictionary<Int64, string> GetDocumentsDictionary(string tableName, string conditions)
        {
            DataTable docs = GetDocumentsInClassByDirectives(tableName, "ORDER BY Name ASC", conditions, 100000, 1, 100000);
            Dictionary<Int64, string> dict = new Dictionary<long, string>();
            foreach (DataRow row in docs.Rows)
            {
                dict.Add(Int64.Parse(row[Document.Field.Id].ToString()), row[Document.Field.Name].ToString()); //kolumny są uniwersalne
            }
            return dict;
        }

        public static void ShowDocumentByExternalApp(string filePath, UserCredentials user = null)
        {
            string destFile = MakeTempCopyOfFile(@filePath, user);
            if(!string.IsNullOrEmpty(destFile))
            {
                var process = System.Diagnostics.Process.Start(@destFile);
            }
        }

        public static void ShowDocument(long documentId, int classId, string securityObjects, string filePath, string lang, string name,
            bool admin = false, bool dialog = false, UserCredentials user = null, bool useExternal = false)
        {
            if (useExternal)
            {
                Data.AddLogDocumentOpenAsync(classId, documentId);
                ShowDocumentByExternalApp(@filePath, user);
            }
            else
            {
                DocumentsManagerRU.View.frmDocumentViewer viewer = new DocumentsManagerRU.View.frmDocumentViewer(documentId, classId, securityObjects, filePath, lang, name, admin, user);
                viewer.StartPosition = FormStartPosition.CenterParent;
                //Data.SetColors(_viewer);
                if (dialog)
                {
                    viewer.ShowDialog();
                }
                else
                {
                    viewer.Show();
                    viewer.Activate();
                }
            }
        }

        #endregion

        #region FILES

        public static void CopyFile(string sourcePath, string destinationPath, UserCredentials readUser = null, UserCredentials writeUser = null)
        {
            FileStream streamSource = null, streamDestination = null;
            try
            {
                if (readUser != null)
                    using (Impersonation.LogonUser(readUser.Domain, readUser.Login, readUser.Password, LogonType.NewCredentials))
                        streamSource = new FileStream(sourcePath, FileMode.Open, FileAccess.Read);
                else
                    streamSource = new FileStream(sourcePath, FileMode.Open, FileAccess.Read);
                if (writeUser != null)
                {
                    using (Impersonation.LogonUser(writeUser.Domain, writeUser.Login, writeUser.Password, LogonType.NewCredentials))
                    {
                        if (!Directory.Exists(Path.GetDirectoryName(destinationPath)))
                        {
                            Directory.CreateDirectory(Path.GetDirectoryName(destinationPath));
                        }
                        streamDestination = File.Create(destinationPath);
                        streamSource.CopyTo(streamDestination);
                    }
                }
                else
                {
                    if (!Directory.Exists(Path.GetDirectoryName(destinationPath)))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(destinationPath));
                    }
                    streamDestination = File.Create(destinationPath);
                    streamSource.CopyTo(streamDestination);
                }
            }
            catch (Exception e)
            {
                _logger.Error("Błąd zapisu pliku z: {0}, do: {1} e: {2}", @sourcePath, destinationPath, e);
            }
            finally
            {
                if (streamDestination != null)
                    streamDestination.Dispose();
                if (streamSource != null)
                    streamSource.Dispose();
            }
        }

        public static async Task CopyFileAsync(string @sourcePath, string destinationPath, UserCredentials readUser = null, UserCredentials writeUser = null)
        {
            FileStream streamSource = null, streamDestination = null;
            try
            {
                if (readUser != null)
                    using (Impersonation.LogonUser(readUser.Domain, readUser.Login, readUser.Password, LogonType.NewCredentials))
                        streamSource = new FileStream(@sourcePath, FileMode.Open, FileAccess.Read);
                else
                    streamSource = new FileStream(@sourcePath, FileMode.Open, FileAccess.Read);
                if (writeUser != null)
                {
                    using (Impersonation.LogonUser(writeUser.Domain, writeUser.Login, writeUser.Password, LogonType.NewCredentials))
                    {
                        if (!Directory.Exists(Path.GetDirectoryName(destinationPath)))
                        {
                            Directory.CreateDirectory(Path.GetDirectoryName(destinationPath));
                        }
                        streamDestination = File.Create(destinationPath);
                        await streamSource.CopyToAsync(streamDestination);
                    }
                }
                else
                {
                    if (!Directory.Exists(Path.GetDirectoryName(destinationPath)))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(destinationPath));
                    }
                    streamDestination = File.Create(destinationPath);
                    await streamSource.CopyToAsync(streamDestination);
                }
            }
            catch(Exception e)
            {
                _logger.Error("Błąd asynchronicznego zapisu pliku z: {0}, do: {1} e: {2}", @sourcePath, destinationPath, e);
            }
            finally
            {
                if (streamDestination != null)
                    streamDestination.Dispose();
                if (streamSource != null)
                    streamSource.Dispose();
            }
        }

        public static async Task<bool> CopyFileAsyncWithSplash(string @sourceFile, string @destinationFile, bool useSplash = true, UserCredentials userRead = null, UserCredentials userWrite = null)
        {
            if (string.IsNullOrEmpty(sourceFile) || string.IsNullOrEmpty(destinationFile)) 
                return false;
            if (IsFileOrDirectoryExist(@sourceFile, userRead) == false)
                return false;
            frmSplashInProgress splash = new frmSplashInProgress();
           
            //kopiowanie pliku z dysku lokalnego na serwer
            try
            {
                if(useSplash)
                    splash.StartSplash();
                await CopyFileAsync(@sourceFile, @destinationFile, userRead, userWrite);
                if(useSplash)
                    splash.StopSplash();
                //etap I - potwierdzenie istnienia pliku docelowego
                var result = IsFileOrDirectoryExist(@destinationFile, userWrite);
                //jeśli się nie udało- zakończ od razu operację
                if (!result) return result;
                //etap II - weryfikacja sukcesu kopiowania pliku na podstawie sumy kontrolnej
                var sourceFileCheckSum = GetCheckSum(@sourceFile, userRead);
                var destinationFileCheckSum = GetCheckSum(@destinationFile, userWrite);
                result = StructuralComparisons.StructuralEqualityComparer.Equals(sourceFileCheckSum, destinationFileCheckSum);
                if (!result)
                {
                    _logger.Error(string.Format("Błąd - skopiowany plik różni się od źródłowego! Plik źródłowy: {0}, plik docelowy: {1}", sourceFile, destinationFile));
                }
                return result;
            }
            catch (Exception e)
            {
                _logger.Error(string.Format("Błąd kopiowania pliku, {0}", e));
                return false;
            }
            finally
            {
                if(useSplash)
                    splash.StopSplash();
            }
        }

        public static async Task ReleaseDocumentProcess(string name, string filePath, string description, DateTime releaseDate,
            string classIdString, List<Document_Index> indexes, DataShare ds, int? assignedClassId = null, Int64? assignedDocumentId = null)
        {
            try
            {
                //bool success = false;
                //1. kopia pliku do miejsca docelowego
                string destinationFile = PrepareServerFilePathToCopy(filePath, classIdString, GlobalSettings.ScanOperator);
                var result = string.IsNullOrEmpty(destinationFile);
                if (result)
                {
                    _logger.Error("Błąd procesu zwalniania dokumentu: Nie udało się przygotować ścieżki dla nowego pliku!");
                    //porażka- odwrócenie wartości rezultatu
                    result = !result;
                }
                else
                {
                    result = await CopyFileAsyncWithSplash(filePath, destinationFile, false, null, GlobalSettings.ScanOperator);
                    if (result)
                    {
                        //2.Dodanie rekordu do bazy
                        var oldFileName = Path.GetFileName(@filePath);
                        var classId = Convert.ToInt32(classIdString);
                        result = AddNewDocument(classId, name, description, releaseDate, destinationFile, oldFileName, indexes, assignedClassId, assignedDocumentId);
                        if (result)
                        {
                            //3. Usunięcie pliku źródłowego, o ile funkcja jest ustawiona w bazie
                            var canDelete = GlobalSettings.GetFlagSetting_Temp(GlobalSettings.SettingsDictionary.DeleteAfterReleaseBOOL);
                            if (canDelete.HasValue && canDelete.Value)
                            {
                                //usuwanie z komputera użytkownika na jego poświadczeniach
                                //File.Delete(@filePath);
                                DeleteFileDirectory(@filePath);
                            }

                            //udało się zwolnić
                            //DialogBox.ShowDialog(ds.LocRM.GetString("msg03"), string.Empty, ds, MessageBoxButtons.OK, DialogBox.Icons.Success); //Zwalnianie dokumentu zakończone sukcesem.
                            //nowe znikające okienko informacyjne :)
                            DialogBox.ShowEvanescenceBox(ds.LocRM.GetString("msg03"), string.Empty, ds, DialogBox.Icons.Success, 2);
                        }
                        else
                        {
                            //logowanie błędu zostało obsłużone w metodzie zwalniania powyżej
                        }
                    }
                    else
                    {
                        //logowanie błędu zostało obsłużone w metodzie zwalniania powyżej
                    }
                }
                if (!result)
                {
                    DialogBox.ShowDialog(ds.LocRM.GetString("msg04"), string.Empty, ds, MessageBoxButtons.OK, DialogBox.Icons.Error); //Wystąpił problem w trakcie zwalniania dokumentu!
                }
                
            }
            catch (Exception e)
            {
                _logger.Error("Wystąpił błąd (Exception) procesu zwalniania dokumentu: {0}, ReleaseDocumentProcess(); e: {1}", name, e);
                DialogBox.ShowDialog(ds.LocRM.GetString("msg04"), string.Empty, ds, MessageBoxButtons.OK, DialogBox.Icons.Error); //Wystąpił problem w trakcie zwalniania dokumentu!
            }
        }

        public static async Task CopyFileOnServerAsync(string @sourcePath, string @destinationPath, UserCredentials serverUser = null)
        {
            if (string.IsNullOrEmpty(@sourcePath) || string.IsNullOrEmpty(@destinationPath)) return;
            FileInfo f1 = new FileInfo(@sourcePath); //plik źródłowy do kopiowania
            var result = await CopyFileAsyncWithSplash(@sourcePath, @destinationPath, true, serverUser, serverUser);
            if(!result)
            {
                _logger.Error(string.Format("Nie udało się przenieść dokumentu na serwerze z:{0}, do: {1}", @sourcePath, @destinationPath));
            }
        }

        public static async void UpdateDocumentProcess(Int64 documentId, int actualClassId, List<Document_Index> indexes, DataShare ds, int newClassId = -1, string name = "", string description = "",
            string URL = "", bool? active = null, DateTime? releaseDate = null, int? assignedClassId = null, Int64? assignedDocumentId = null)
        {
            Document document = GetDocumentById(documentId, actualClassId);
            string @destinationPath = URL;
            bool failed = string.IsNullOrEmpty(document.URL);
            if(failed)
            {
                //zaniechanie operacji przenoszenia
                _logger.Error("Błąd przenoszenia pliku wewnątrz serwera, nie udało się pobrać dokumentu z bazy!");
                DialogBox.ShowDialog(ds.LocRM.GetString(DialogBox.MESSAGE_FAILED), ds.LocRM.GetString(DialogBox.ACTION_SAVE),
                       ds, MessageBoxButtons.OK, DialogBox.Icons.Error);
            }
            string @sourcePath = document.URL;
            bool changeClass = newClassId != actualClassId ? true : false;
            if (changeClass)
            {
                //należy przenieść plik do innej klasy
                @destinationPath = PrepareServerFilePathToMove(document.URL, newClassId.ToString(), GlobalSettings.ScanOperator);
                bool result = false;
                try
                {
                    await CopyFileOnServerAsync(document.URL, @destinationPath, GlobalSettings.ScanOperator);

                    //sprawdzanie, czy przenoszenie zakończyło się sukcesem
                    if (Data.IsFileOrDirectoryExist(@destinationPath, GlobalSettings.ScanOperator))
                    {
                        //przeniesiono plik - usuwam wpis w tabeli klasy
                        result = DeleteDocumentFromDB(documentId, actualClassId, false);

                        //dodaję wpis w nowej tabeli klasy
                        Int64 newDocumentId = AddNewDocumentWithReference(newClassId,
                            string.IsNullOrEmpty(name) ? document.Name : name,
                            string.IsNullOrEmpty(description) ? document.Description : description,
                            releaseDate == null ? document.Release_Date : releaseDate,
                            @destinationPath,
                            document.OldFileName,
                            indexes,
                            assignedClassId,
                            assignedDocumentId);

                        //aktualizacja powiązań dokumentów
                        UpdateAssignedDocuments(documentId, actualClassId, newDocumentId, newClassId);

                        //aktualizacja obiektów w tabeli oznaczeń
                        UpdateOznaczeniaId(documentId, actualClassId, newDocumentId, newClassId);

                        //usunięcie pliku źródłowego, po zakończeniu przenoszenia
                        bool removedsource = DeleteFileDirectory(@sourcePath, GlobalSettings.ScanOperator);
                        if (removedsource == false)
                        {
                            StringBuilder builder = new StringBuilder();
                            builder.AppendLine("Plik na serwerze został skopiowany poprawnie, ale nie udało się usunąć jego oryginału i dalej ona istnieje.");
                            builder.AppendLine("Adres pliku: " + @sourcePath);
                            builder.AppendLine("Poprzednia klasa: " + document.Class_Id);
                            builder.AppendLine("Nowa klasa: " + newClassId);
                            Data.SendMail("DMS ALERT - Usuwanie pliku po kopiowaniu na serwerze", ds.AlertEmails, builder.ToString());
                            _logger.Error(string.Format("Błąd przenoszenia pliku! Udało się zrobić kopię, nie udało się usunąć oryginału! Plik:{0}, poprzednia klasa: {1}, obecna klasa: {2}",
                               @sourcePath, document.Class_Id, newClassId));
                        }

                        DialogBox.ShowDialog(ds.LocRM.GetString(DialogBox.MESSAGE_SUCCESS), ds.LocRM.GetString(DialogBox.ACTION_SAVE),
                            ds, MessageBoxButtons.OK, DialogBox.Icons.Success);
                    }
                    else
                    {
                        _logger.Error("Błąd przenoszenia pliku wewnątrz serwera na poświadczeniach użytkownika scanoperator - plik nie został przeniesiony!");
                        DialogBox.ShowDialog(ds.LocRM.GetString(DialogBox.MESSAGE_FAILED), ds.LocRM.GetString(DialogBox.ACTION_SAVE),
                       ds, MessageBoxButtons.OK, DialogBox.Icons.Error);
                    }
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd przenoszenia pliku wewnątrz serwera na poświadczeniach użytkownika scanoperator, " + e);
                }
            }
            else
            {
                bool result = UpdateDocument(documentId, actualClassId, indexes, name, description, releaseDate, active, assignedClassId, assignedDocumentId);
                if (result)
                {
                    DialogBox.ShowDialog(ds.LocRM.GetString(DialogBox.MESSAGE_SUCCESS), ds.LocRM.GetString(DialogBox.ACTION_SAVE),
                            ds, MessageBoxButtons.OK, DialogBox.Icons.Success);
                }
                else
                {
                    DialogBox.ShowDialog(ds.LocRM.GetString(DialogBox.MESSAGE_FAILED), ds.LocRM.GetString(DialogBox.ACTION_SAVE),
                       ds, MessageBoxButtons.OK, DialogBox.Icons.Error);
                }
            }
        }

        public static async Task UpdateDocumentFileProcess(Int64 documentId, int classId, DataShare ds, string filePath)
        {

            Document document = GetDocumentById(documentId, classId);
            bool failed = string.IsNullOrEmpty(document.URL);
            var result = true;
            if(failed)
            {
                //zaniechanie operacji przenoszenia
                _logger.Error("Błąd przenoszenia pliku wewnątrz serwera, nie udało się pobrać dokumentu z bazy!");
                DialogBox.ShowDialog(ds.LocRM.GetString(DialogBox.MESSAGE_FAILED), ds.LocRM.GetString(DialogBox.ACTION_SAVE),
                       ds, MessageBoxButtons.OK, DialogBox.Icons.Error);
                return;
            }
            string @oldSourceFileOnServerPath = document.URL;
            //nazwa pliku, która będzie zapisana jako stara nazwa pliku
            string oldFileName = Path.GetFileName(filePath);

            try
            {
                //1. kopia pliku do miejsca docelowego
                string @newSourceFileOnServerPath = PrepareServerFilePathToCopy(@filePath, classId.ToString(), GlobalSettings.ScanOperator);
                result = string.IsNullOrEmpty(@newSourceFileOnServerPath);
                if (result)
                {
                    _logger.Error("Błąd zwalniania nowego pliku dla dokumentu: Nie udało się przygotować ścieżki dla nowego pliku!");
                    //porażka- odwrócenie wartości rezultatu
                    result = !result;
                }
                else
                {
                    //kopiowanie właściwe
                    result = await CopyFileAsyncWithSplash(filePath, @newSourceFileOnServerPath, false, null, GlobalSettings.ScanOperator);
                    if (result)
                    {
                        //2.Zaktualizowanie rekordu w bazie, kopia gotowa
                        result = UpdateDocumentFile(documentId, classId, @newSourceFileOnServerPath, oldFileName);
                        if (result)
                        {
                            //3. Usunięcie pliku źródłowego, o ile funkcja jest ustawiona w bazie
                            var canDelete = GlobalSettings.GetFlagSetting_Temp(GlobalSettings.SettingsDictionary.DeleteAfterReleaseBOOL);
                            if (canDelete.HasValue && canDelete.Value)
                            {
                                //usuwanie z komputera użytkownika na jego poświadczeniach
                                //File.Delete(@filePath);
                                DeleteFileDirectory(@filePath);
                            }
                        }
                        else
                        {
                            //logowanie błędu zostało obsłużone w metodzie zwalniania powyżej
                        }
                    }
                    else
                    {
                        //logowanie błędu zostało obsłużone w metodzie zwalniania powyżej
                    }
                }
                if (result == false)
                {
                    DialogBox.ShowDialog(ds.LocRM.GetString(DialogBox.MESSAGE_FAILED), ds.LocRM.GetString(DialogBox.ACTION_SAVE),
                       ds, MessageBoxButtons.OK, DialogBox.Icons.Error);
                    //DialogBox.ShowDialog(ds.LocRM.GetString("msg04"), string.Empty, ds, MessageBoxButtons.OK, DialogBox.Icons.Error); //Wystąpił problem w trakcie zwalniania dokumentu!
                    return;
                }
                else
                {
                    try
                    {
                        //te akcje mogą się nie wykonanać, ale brak wykonania nie będzie oznaczać porażki przy przenoszeniu pliku
                        string @fileInMovedFolderPath = null;
                        //4. Kopiowanie pliku poprzedniego do specjalnej lokalizacji na serwerze- przeniesionych plików
                        @fileInMovedFolderPath = PrepareServerFilePathToMoveMovedFile(@oldSourceFileOnServerPath, GlobalSettings.ScanOperator);
                        await CopyFileOnServerAsync(@oldSourceFileOnServerPath, @fileInMovedFolderPath, GlobalSettings.ScanOperator);
                        //sprawdzanie, czy kopiowanie zakończyło się sukcesem
                        result = Data.IsFileOrDirectoryExist(@fileInMovedFolderPath, GlobalSettings.ScanOperator);
                        if (result)
                        {
                            //usunięcie pliku źródłowego, po zakończeniu przenoszenia
                            result = DeleteFileDirectory(@oldSourceFileOnServerPath, GlobalSettings.ScanOperator);
                            if (result)
                            {
                                DialogBox.ShowEvanescenceBox(ds.LocRM.GetString("msg03"), string.Empty, ds, DialogBox.Icons.Success, 2);
                            }
                            else
                            {
                                StringBuilder builder = new StringBuilder();
                                builder.AppendLine("Plik na serwerze został skopiowany poprawnie, ale nie udało się usunąć jego oryginału i dalej ona istnieje.");
                                builder.AppendLine("Adres pliku: " + @oldSourceFileOnServerPath);
                                builder.AppendLine("klasa: " + documentId);
                                Data.SendMail("DMS ALERT - Usuwanie pliku po kopiowaniu na serwerze", ds.AlertEmails, builder.ToString());
                                _logger.Error(string.Format("Błąd przenoszenia pliku! Udało się zrobić kopię, nie udało się usunąć oryginału! Plik:{0}, klasa: {1}",
                                    @oldSourceFileOnServerPath, classId));
                                _logger.Error("Błąd przenoszenia pliku wewnątrz serwera na poświadczeniach użytkownika scanoperator - plik poprzedni dokumentu nie został usunięty!");
                            }

                        }
                        else
                        {
                            _logger.Error("Błąd przenoszenia pliku wewnątrz serwera na poświadczeniach użytkownika scanoperator - ;plik poprzedni dokumentu nie został usunięty!");
                            //DialogBox.ShowDialog(ds.LocRM.GetString(DialogBox.MESSAGE_FAILED), ds.LocRM.GetString(DialogBox.ACTION_SAVE),
                            //ds, MessageBoxButtons.OK, DialogBox.Icons.Error);
                        }

                    }
                    catch (Exception e)
                    {
                        _logger.Error("Błąd przenoszenia pliku wewnątrz serwera na poświadczeniach użytkownika scanoperator, " + e);
                    }

                    DialogBox.ShowEvanescenceBox(ds.LocRM.GetString("msg03"), string.Empty, ds, DialogBox.Icons.Success, 2);
                }
                
            }
            catch (Exception e)
            {
                _logger.Error("Wystąpił błąd podczas zwalniania nowego pliku dla istniejącego dokumentu! Klasa:{0}, dokument:{1}, plik:{2}, e:{3}", classId, documentId, filePath, e);
                DialogBox.ShowDialog(ds.LocRM.GetString("msg04"), string.Empty, ds, MessageBoxButtons.OK, DialogBox.Icons.Error); //Wystąpił problem w trakcie zwalniania dokumentu!
            }
        }


        public static string PrepareServerFilePathToCopy(string @sourceLocalPath, string classId, UserCredentials user = null)
        {
            string @newPath = PrepareClassPath(classId);
            @newPath = Path.Combine(GetFirstAcceptedDirectory(@newPath, user), CreateNewHashName(@sourceLocalPath));
            return @newPath;
        }

        public static string PrepareClassPath(string classId)
        {
            string @newPath = Path.Combine(Data.GetServerRoot(), classId);
            return @newPath;
        }

        private static string PrepareTempFilePath(string sourcePath)
        {
            string @newPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName().Replace(".", "x"), Path.GetFileName(sourcePath));
            return @newPath;
        }

        public static string PrepareTempFilePath(string sourcePath, UserCredentials user = null)
        {
            if(user != null)
                using (Impersonation.LogonUser(user.Domain, user.Login, user.Password, LogonType.NewCredentials))
                {
                    return PrepareTempFilePath(sourcePath);
                }
            else
                return PrepareTempFilePath(sourcePath);
        }

        public static string CreateNewHashName(string filePath)
        {
            using (var md5 = MD5.Create())
            {
                try
                {
                    var test = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(Path.GetFileName(filePath) + DateTime.Now.Ticks.ToString()));
                    var test2 = BitConverter.ToString(test).Replace("-", "");
                    var test3 = test2.Substring(0, 20) + Path.GetExtension(filePath);
                    return test3;
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd tworzenia hasha nazwy pliku, CreateNewHashName({0}), e: {1}", filePath, e);
                    return "";
                };
            }
        }

        private static bool DeleteFileDirectory(string @path)
        {
            //usuwanie pliku z użyciem specjalnych poświadczeń
            try
            {
                if (IsFileOrDirectoryExist(@path))
                {
                    FileAttributes attr = File.GetAttributes(@path);
                    if (attr.HasFlag(FileAttributes.Directory))
                        Directory.Delete(@path, true);
                    else
                        File.Delete(@path);
                }
                else
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                _logger.Error("Błąd usuwania pliku lub folderu, DeleteFile({0}), e: {1}", path, e);
                return false;
            }
            return true;
        }

        public static bool DeleteFileDirectory(string @path, UserCredentials user = null)
        {
            if (user != null)
                using (Impersonation.LogonUser(user.Domain, user.Login, user.Password, LogonType.NewCredentials))
                    return DeleteFileDirectory(@path);
            else
                return DeleteFileDirectory(@path);
        }

        public static string MakeTempCopyOfFile(string sourcePath, UserCredentials user = null)
        {
            //zapis pliku docelowego zawsze na poświadczeniach zalogowanego użytkownika
            string dest = PrepareTempFilePath(@sourcePath, user);
            CopyFile(@sourcePath, @dest, user, null);
            return dest;
        }

        public static bool DeleteDocumentProcess(Int64 documentId, int classId, string file = null, UserCredentials user = null)
        {
            bool result = false;
            string @filePath = string.IsNullOrEmpty(file) ? GetDocumentById(documentId, classId).URL : file;
            if (IsFileOrDirectoryExist(@filePath))
            {
                //plik istnieje, można usuwać
                result = DeleteFileDirectory(@filePath, user);
                if (result)
                {
                    result = DeleteDocumentFromDB(documentId, classId, true);
                }
            }
            return result;
        }

        public static bool DeleteClassProcess(int classId, UserCredentials user = null)
        {
            bool result = false;
            result = DeleteClass(classId);
            if (result)
            {
                string @classPath = PrepareClassPath(classId.ToString());
                DeleteFileDirectory(@classPath, user);
                //result = !IsFileDirectoryExist(@classPath);
            }
            return result;
        }

        public static string PrepareServerFilePathToMove(string @sourcePath, string classId, UserCredentials user = null)
        {
            if (!string.IsNullOrEmpty(@sourcePath) && IsFileOrDirectoryExist(@sourcePath, user))
            {
                string newPath = Path.Combine(Data.GetServerRoot(), classId); 
                newPath = Path.Combine(GetFirstAcceptedDirectory(newPath, user), Path.GetFileName(sourcePath));
                return newPath;
            }
            else
            {
                return string.Empty;
            }
        }

        public static string PrepareServerFilePathToMoveMovedFile(string @sourcePath, UserCredentials user = null)
        {
            if (!string.IsNullOrEmpty(@sourcePath) && IsFileOrDirectoryExist(@sourcePath, user))
            {
                string newPath = Path.Combine(Data.GetServerRoot(), @"MOVED", DateTime.Now.Year.ToString(), Path.GetFileName(sourcePath));
                return newPath;
            }
            else
            {
                return string.Empty;
            }
        }

        public static string GetFirstAcceptedDirectory(string @baseDirectory, UserCredentials user = null)
        {
            if (user != null)
                using (Impersonation.LogonUser(user.Domain, user.Login, user.Password, LogonType.NewCredentials))
                    return GetFirstAcceptedDirectory(@baseDirectory);
            else
                return GetFirstAcceptedDirectory(@baseDirectory);
        }

        private static string GetFirstAcceptedDirectory(string @baseDirectory)
        {
            //base directory to root + permissionId
            string @finallyDirectory = string.Empty;
            string @base1 = Path.Combine(@baseDirectory, DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString());
            if (!Directory.Exists(@base1))
            {
                Directory.CreateDirectory(@base1);
            }
            //pobranie pierwszego spełniającego kryterium folderu, pierwszego pozimu
            string @newDir = Directory.EnumerateDirectories(@base1).SingleOrDefault(@str => Directory.GetDirectories(@str).Length < 1000);
            if (string.IsNullOrEmpty(@newDir))
            {
                @newDir = Path.Combine(@base1, (Directory.GetFiles(@base1).Length + 1).ToString());
                Directory.CreateDirectory(@newDir);
            }
            //pobranie pierwszego spełniającego kryterium folderu, drugiego pozimu, docelowego dla folderu dokumentu
            @finallyDirectory = Directory.EnumerateDirectories(@newDir).SingleOrDefault(@str => Directory.GetFiles(@str).Length < 1000);
            if (string.IsNullOrEmpty(@finallyDirectory))
            {
                @finallyDirectory = Path.Combine(@newDir, (Directory.GetDirectories(@newDir).Length + 1).ToString());
                Directory.CreateDirectory(@finallyDirectory);
            }
            return @finallyDirectory;
        }

        public static bool IsFileOrDirectoryExist(string @filePath, UserCredentials user = null)
        {
            if (user != null)
                using (Impersonation.LogonUser(user.Domain, user.Login, user.Password, LogonType.NewCredentials))
                    return IsFileOrDirectoryExist(@filePath);
            else
                return IsFileOrDirectoryExist(@filePath);
        }

        private static bool IsFileOrDirectoryExist(string @filePath)
        {
            try
            {
                FileAttributes attr = File.GetAttributes(@filePath);
                if (attr.HasFlag(FileAttributes.Directory))
                    return Directory.Exists(@filePath);
                else
                    return File.Exists(@filePath);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static byte[] GetCheckSum(string @file, UserCredentials user = null)
        {
            try
            {
                if (user == null)
                    using (var md5 = MD5.Create())
                    {
                        using (var stream = File.OpenRead(@file))
                        {
                            return md5.ComputeHash(stream);
                        }
                    }
                using (Impersonation.LogonUser(user.Domain, user.Login, user.Password, LogonType.NewCredentials))
                {
                    using (var md5 = MD5.Create())
                    {
                        using (var stream = File.OpenRead(@file))
                        {
                            return md5.ComputeHash(stream);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Wystąpił błąd e: " + ex);
                return new byte[0];
            }
        }

        #endregion

        #region DATABASE

        public static string GetConnectionString() 
        {
            return ConfigurationManager.ConnectionStrings
                ["DocumentsManagerRU.Properties.Settings.ConnectionString"].ConnectionString;
        }

        /**Pobieranie ścieżki serwera, przechowywanej w sesji.*/
        public static string GetServerRoot()
        {
            return GlobalSettings.GetSetting_Temp(GlobalSettings.SettingsDictionary.ServerDirectorySTRING);
        }

        public static string GetDataBaseName()
        {
            System.Data.SqlClient.SqlConnectionStringBuilder builder = new System.Data.SqlClient.SqlConnectionStringBuilder();
            builder.ConnectionString = GetConnectionString();
            var info = string.Format("{0}, {1}", builder.DataSource, builder.InitialCatalog);
            return info;
        }

        public static string GetFormattedDatabaseName()
        {
            var info = GetDataBaseName();
            if (Data.IsTestDatabase())
            {
                info = string.Format("{0} (BAZA TESTOWA)", info);
            }
            return info;
        }

        public static bool IsServerAccesible()
        {
            bool result;
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open();
                    conn.Close();
                    result = true;
                }
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public static string GetAppVersion()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;
            return version;
        }

        public static object GetSQLSingleValue(string sql)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            SqlCommand cm = new SqlCommand();

            cm.CommandType = CommandType.Text;
            cm.Connection = conn;
            cm.CommandText = string.Format(sql);
            var result = new object();
            try
            {
                conn.Open();
                result = cm.ExecuteScalar();
            }
            catch (Exception e)
            {
                result = "";
                _logger.Error("Błąd wykonania kwerendy: {0}, e: {1}", sql, e);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return result;
        }

        public static DataTable GetSQLTableValue(string sql)
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());
            SqlCommand cm = new SqlCommand();

            cm.CommandType = CommandType.Text;
            cm.Connection = conn;
            cm.CommandText = string.Format(sql);
            DataTable table = new DataTable();
            try
            {
                conn.Open();
                table.Load(cm.ExecuteReader());
                
            }
            catch (Exception e)
            {
                _logger.Error("Błąd wykonania kwerendy: {0}, e: {1}", sql, e);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return table;
        }

        public static bool IsClassNameExistInDatabase(string className)
        {
            var result = GetSQLSingleValue(string.Format("SELECT COUNT(Id) FROM Document_Class WHERE Name = N'{0}'", className));
            if (result == null || result == DBNull.Value) return false;
            int val = -1;
            int.TryParse(result.ToString(), out val);
            if (val <= 0)
                return false;
            else
                return true;
        }

        public static bool IsClassNameRUExistInDatabase(string className)
        {
            var result = GetSQLSingleValue(string.Format("SELECT COUNT(Id) FROM Document_Class WHERE Name_RU = N'{0}'", className));
            if (result == null || result == DBNull.Value) return false;
            int val = -1;
            int.TryParse(result.ToString(), out val);
            if (val <= 0)
                return false;
            else
                return true;
        }

        public static bool IsDefinitionNamePLExistInDataBase(string definitionName)
        {
            var result = GetSQLSingleValue(string.Format("SELECT COUNT(Id) FROM Document_Definitions WHERE Name_PL = N'{0}'", definitionName));
            if (result == null || result == DBNull.Value) return false;
            int val = -1;
            int.TryParse(result.ToString(), out val);
            if (val > 0)
                return true;
            else
                return false;
        }

        public static bool IsDefinitionNameRUExistInDataBase(string definitionName)
        {
            var result = GetSQLSingleValue(string.Format("SELECT COUNT(Id) FROM Document_Definitions WHERE Name_RU = N'{0}'", definitionName));
            if (result == null || result == DBNull.Value) return false;
            int val = -1;
            int.TryParse(result.ToString(), out val);
            if (val <= 0)
                return false;
            else
                return true;
        }

        public static bool IsUserHavePermissionToReleaseClass(int userId, int classId)
        {
            var result = GetSQLSingleValue(string.Format("SELECT COUNT(Id) FROM Document_Permissions (NOLOCK) WHERE "+
            "UserId = {0} AND ClassId = {1} AND (AccessLevel = 2 OR AccessLevel = 3)", userId, classId));
            if (result == null || result == DBNull.Value) return false;
            int res = -1;
            Int32.TryParse(result.ToString(), out res);
            if (res > 0)
                return true;
            else                 
                return false;
        }

        public static bool IsUniqueDocumentNameInClass(string documentName, string classId)
        {
            var tableName = GetTableNameById(null, classId);
            var result = GetSQLSingleValue(string.Format("SELECT COUNT(Id) FROM {0} WHERE REPLACE(Name, '_', 'c') LIKE REPLACE('{1}', '_', 'c')", tableName, documentName));
            //var result = GetSQLSingleValue(string.Format("SELECT COUNT(Id) FROM {0} WHERE Name LIKE N'{1}'", tableName, documentName));
            if (result == null || result == DBNull.Value) return false;
            int intResult = -1;
            Int32.TryParse(result.ToString(), out intResult);
            if (intResult > 0)
                return false;
            else
                return true;
        }

        public static bool IsUniqueDocumentDefinitionRecordName(string recordName, int recordId, int definitionId)
        {
            //z podanych wyników wyłączamy sprawdzanie określonego rekordu, który będzie zapisany
            string command = string.Format("select count(Id) From Document_DefinitionList_Items (nolock) where DefinitionId = " +
                "{0} and Name = N'{1}' and Id <> {2}", definitionId, recordName, recordId);
            try
            {
                var result = GetSQLSingleValue(command);
                if (result != null && result != DBNull.Value && result.ToString() == "0")
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string GetTableNameById(int? classId = null, string classIdStr = "")
        {
            var tableName = GetSQLSingleValue(string.Format("SELECT Table_Name FROM Document_Class WHERE Id = {0}", 
                classId.HasValue && classId.Value != -1 ? classId.Value.ToString() : classIdStr));
            return tableName != null ? tableName.ToString() : "";
        }

        public static bool IsTestDatabase()
        {
            var con = GetConnectionString();
            if (con.Contains("TEST"))
                return true;
            else
                return false;
        }

        public static void SendMail(string title, string recipients, string body)
        {
            string sql = string.Format("EXEC msdb.dbo.sp_send_dbmail @profile_name = 'DMS', @recipients = N'{0}', @subject = N'{1}', @body = N'{2}', @body_format = 'TEXT'", recipients, title, body);
            GetSQLSingleValue(sql);
        }

        public static void AddLogToDatabase(LogLevels logLevel, string login, string description)
        {
            using (var db = new DocContext())
            {
                db.LOG_DodajLog(logLevel.ToString(), login, description);
            }
        }

        public static async void AddLogToDatabaseAsync(LogLevels logLevel, string login, string description)
        {
            await Task.Run(() => AddLogToDatabase(logLevel, login, description)).ConfigureAwait(false);
        }


        public static void AddLogDocumentOpen(int classId, long documentId)
        {
            using (var db = new DocContext())
            {
                db.LOG_Dokument_DodajDostep(classId, documentId, Security.GetUserLogin());
            }
        }

        public static async void AddLogDocumentOpenAsync(int classId, long documentId)
        {
            await Task.Run(() => AddLogDocumentOpen(classId, documentId)).ConfigureAwait(false);
        }

        #endregion

    }
}
