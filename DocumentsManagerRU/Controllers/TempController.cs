using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NLog;

namespace DocumentsManagerRU
{
    public class TempController
    {
        public enum Fields
        {
            ViewerPosition = 0, //0
            LayoutColors = 1 //1
        }

        public static string TempFileName = "dms_temp.txt";
        public ColorLayout Layout;
        public string ViewerPosition;
        public static Logger _logger = LogManager.GetCurrentClassLogger();
        public static string @tempPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),"DMS","dms_temp.txt");

        public TempController()
        {
            var temp = LoadTemp();
            if (temp.Length != 2)
            {
                ViewerPosition = string.Empty;
                Layout = ColorLayoutController.GetDefaultColorLayout();
            }
            else
            {
                ViewerPosition = temp[(int)Fields.ViewerPosition];
                Layout = ColorLayoutController.DeserializeColorLayout(temp[(int)Fields.LayoutColors]);
            }
        }

        private static string[] LoadTemp()
        {
            if (File.Exists(@tempPath))
            {
                try
                {
                    var fileContent = File.ReadAllLines(@tempPath);
                    return fileContent;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Nie można uzyskać dostępu do pliku " + @tempPath);
                    _logger.Error(string.Format("Nie można uzyskać dostępu do pliku temp {0}, {1}", @tempPath, ex));
                    return new string[0];
                }
            }
            else 
                return new string[0];
        }

        public bool SaveTemp()
        {
            string[] temp = new string[]{
                ViewerPosition,
                ColorLayoutController.SerializeColorLayout(Layout)
            };
            return SaveTemp(temp);
        }

        /// <summary>
        /// Zapis tempa do pliku.
        /// </summary>
        /// <param name="fields"></param>
        /// <returns></returns>
        private bool SaveTemp(string[] fields)
        {
            //zapis pozycji okna do pliku po jego zamknięciu
            StringBuilder sb = new StringBuilder();
            try
            {
                FileInfo file = new FileInfo(@tempPath);
                StreamWriter sw;
                if (!file.Exists)
                {
                    //stworzenie pliku
                    sw = file.CreateText();
                    //file.Attributes = FileAttributes.Hidden;
                }
                else
                {
                    //uchwyt do istniejącego
                    FileStream fs = new FileStream(@tempPath, FileMode.Truncate); //nadpisze nam całą zawartość
                    foreach (string parameter in fields)
                    {
                        sb.AppendLine(parameter);
                    }
                    sw = new StreamWriter(fs);
                }
                sw.Write(sb.ToString());
                sw.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nie można zapisać informacji o kontrolce do tempa: " + @tempPath);
                _logger.Error(string.Format("Nie można zapisać informacji o kontrolce do tempa: {0}, {1}", @tempPath, ex));

                return false;
            }
        }

        /// <summary>
        /// Zapisanie layoutu do tempa.
        /// </summary>
        /// <param name="layout"></param>
        /// <returns></returns>
        public static bool SaveColorLayoutToTemp(ColorLayout layout)
        {
            var temp = new TempController();
            temp.Layout = layout;
            var result = temp.SaveTemp();
            return result;
        }

        /// <summary>
        /// zapis pozycji viewera do tempa
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static bool SaveViewerPositionParams(string parameters)
        {
            var temp = new TempController();
            temp.ViewerPosition = parameters;
            var result = temp.SaveTemp();
            return result;
        }

        /// <summary>
        /// Wczytanie layoutu z tempa
        /// </summary>
        /// <returns></returns>
        public static ColorLayout LoadLayoutFromTemp()
        {
            var temp = LoadTemp();
            if (temp.Length != 2) 
                return ColorLayoutController.GetDefaultColorLayout();
            var layout = ColorLayoutController.DeserializeColorLayout(temp[(int)Fields.LayoutColors]);
            return layout;
        }

        /// <summary>
        /// Wczytanie pozycji viewera z tempa
        /// </summary>
        /// <returns></returns>
        public static string LoadViewerPositionParams()
        {
            var temp = LoadTemp();
            if (temp.Length != 2) 
                return null;
            else
                return temp[(int)Fields.ViewerPosition];
        }

    }
}
