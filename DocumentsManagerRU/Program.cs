using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentsManagerRU.ImpersonationClass;
using AutoUpdaterDotNET;
using NLog;

namespace DocumentsManagerRU
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //pobieranie obiektów security przy starcie dla zmniejszenia liczby zapytań do bazy
            //string securityObjects = Security.GetSecurityObjects();
            //System.Diagnostics.Debugger.Launch();
            if (!Data.IsServerAccesible())
            {
                Logger logger = LogManager.GetCurrentClassLogger();
                logger.Error("Brak dostępu do serwera.");
                DocumentsManagerRU.DialogBox.ShowDialog(LanguageController.GetLanguageResources(LanguageController.GetDefaultLanguage())
                    .GetString("msgAccessError"), string.Empty, null, MessageBoxButtons.OK, DialogBox.Icons.Error);
                return;
            }
            DataShare ds = new DataShare();
                ds.SetLanguageToDefault();
            ds.SetColorLayout(TempController.LoadLayoutFromTemp());
            if (Security.Active)
            {
                if (args.Length == 2 || args.Length == 1)
                {
                    Int64 docId = -1;
                    int classId = -1;
                    if (args.Length == 2)
                    {
                        int.TryParse(args[0], out classId);
                        Int64.TryParse(args[1], out docId);
                    }
                    else if (args.Length == 1)
                    {
                        string[] items = Regex.Split(args[0], ":");
                        //nazwa, id klasy, id dokumentu
                        if (items.Length != 3) return;
                        int.TryParse(items[1], out classId);
                        Int64.TryParse(items[2], out docId);
                    }
                    if(docId != -1 && classId != -1)
                    {
                        Document doc = Data.GetDocumentById(docId, classId);
                        if (doc == null || string.IsNullOrEmpty(doc.URL))
                            DialogBox.ShowDialog(ds.LocRM.GetString("msgNoFile"), "", ds, MessageBoxButtons.OK, DialogBox.Icons.Error);
                        else
                        {
                            var permissions = Permissions.GetPermissionsVector(classId, Security.SecurityObjects);
                            if (permissions.PrimaryPermission >= Permissions.ClassPrimaryPermissions.Read)
                            {
                                Data.ShowDocument(docId, classId, Security.SecurityObjects, doc.URL, ds.Language, doc.Name, false, true, GlobalSettings.ScanOperator, ds.UseExternalViewer);
                            }
                            else
                                DialogBox.ShowDialog(ds.LocRM.GetString("msgNoPermissionToDocument"), "", ds, MessageBoxButtons.OK, DialogBox.Icons.Error);
                        }
                    }
                }
                else if (args.Length == 1)
                {
                    //MessageBox.Show(args[0]);
                }
                else
                {
                    //uruchomienie normalnej instancji aplikacji
                    var appGuid = (GuidAttribute)Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(GuidAttribute), true)[0];
                    bool createdNew = true;

                    //spradzanie czy DMS jest uruchomiony na komputerze/serwerze i sprawdzanie aktualizacji.
                    if ((System.Windows.Forms.SystemInformation.TerminalServerSession == false))// && (Data.IsTestDatabase() == false))
                    {
                        try
                        {
                            AutoUpdater.Start(GlobalSettings.GetSingleSetting_Temp(GlobalSettings.SettingsDictionary.UpdaterSTRING).Value.ToString());
                        }
                        catch (Exception ex)
                        {
                            Data.AddLogToDatabase(Data.LogLevels.ERROR, Security.GetUserLogin(), "Wystąpił problem w trakcie wywołania aktualizatora: " + ex.Message);
                        }
                    }

                    using (var mutex = new Mutex(true, appGuid.Value, out createdNew))
                    {
                        if (createdNew || Security.Admin)
                        {
                            Application.EnableVisualStyles();
                            Application.SetCompatibleTextRenderingDefault(false);
                            Application.Run(new frmMain(ds));
                        }
                        else
                        {
                            DialogBox.ShowDialog(ds.LocRM.GetString("msg12"), string.Empty, ds, MessageBoxButtons.OK, DialogBox.Icons.Warning); //W systemie otwarta jest już aplikacja.
                        }
                    }
                }
            }
            else
            {
                Logger logger = LogManager.GetLogger("Program");
                logger.Warn("Nieautoryzowana próba uruchomienia aplikacji przez: {0}", Security.SecurityObjects);
                try
                {
                    DialogBox.ShowDialog(ds.LocRM.GetString("msg13") + //Użytkownik nie ma praw do uruchomienia aplikacji!
                        "\n" + ds.LocRM.GetString("msg14") //Skontaktuj się z administratorem.
                        , ds.LocRM.GetString("msg15") //Błąd uruchamiania aplikacji
                        , ds, MessageBoxButtons.OK, DialogBox.Icons.Error);
                }
                catch (Exception e)
                {
                    logger.Error("Wystąpił błąd podczas wyświetlenia komunikatu braku dostępu do aplikacji! " + e);
                }
                logger.ToString(); //wymuszenie akcji
            }
        }
    }
}
