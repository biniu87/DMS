using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentViewer.Controls.Viewer;
using System.Windows;
using System.Windows.Forms.Integration;
using System.Windows.Media;
using DocumentViewer.ViewModels;
using DocumentViewer.Security;
using DocumentsManagerRU.ImpersonationClass;
using System.IO;
using System.Text.RegularExpressions;
using NLog;

namespace DocumentsManagerRU.View
{
    public partial class frmDocumentViewer : Form
    {
        private ElementHost _ctrlHost;
        private Int64 _documentId;
        private int _classId;
        private Viewer viewer;
        private string _filePath;
        public static Logger _logger = LogManager.GetCurrentClassLogger();
        public frmDocumentViewer(Int64 documentId, int classId, string securityObjects, string filePath, string lang, string name, bool admin = false, UserCredentials user = null)
        {
            InitializeComponent();
            _documentId = documentId;
            _classId = classId;
            _filePath = filePath;
            if (!string.IsNullOrEmpty(name))
            {
                this.Text = name;
            }
            IEnumerable<BoxViewModel> boxes = DocumentViewerModel.GetDocumentViewerBoxes(documentId, classId);
            //DocumentViewer.Security.Security security = admin ? DocumentViewerModel.GetDocumentViewerSecurityForAdmin()
            //    : DocumentViewerModel.GetDocumentViewerSecurity(securityObjects, classId);
            DocumentViewer.Security.Security security = DocumentViewerModel.GetDocumentViewerSecurity(securityObjects, classId);
            Viewer viewer;

            if (user != null)
            {
                viewer = new Viewer(filePath, boxes, security, lang, new string[] { user.Domain, user.Login, user.Password });
            }
            else
            {
                viewer = new Viewer(filePath, boxes, security, lang);
            }
            
            _ctrlHost = new ElementHost();
            _ctrlHost.Dock = DockStyle.Fill;
            this.pnlView.Controls.Add(_ctrlHost);
            _ctrlHost.Child = viewer;
            //this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            viewer.SavingSettings += Save_ViewerSettings;

            if (documentId != null && documentId > 0 && classId != null && classId > 0)
            {
                //są parametry potrzebne do pobrania klasy
                Document doc = Data.GetDocumentById(_documentId, classId);
                string rtf = BuildRtfFromIndexes(doc);
                rtbIndexes.Rtf = rtf;
                //var log = string.Format("Użytkownik otworzył plik w przeglądarce DMS; id klasy:{0}, id dokumentu: {1}", classId.ToString(), documentId.ToString());
                //Data.AddLogToDatabaseAsync(Data.LogLevels.INFO, Security.GetUserLogin(), log);
                Data.AddLogDocumentOpenAsync(classId, _documentId);
            }
        }

        public static string BuildRtfFromIndexes(Document document)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var index in document.DocumentIndexes)
            {
                if(index.Value != null && !string.IsNullOrEmpty(index.Value.ToString()))
                    builder.Append(string.Format(@"{0}: \b\cf2 {1} \cf1\b0 ", index.Name_PL, index.Value.ToString()));
            }
            StringBuilder body = new StringBuilder();
            foreach (char character in builder.ToString())
            {
                if (character <= 0x7f)
                    body.Append(character);
                else
                    body.Append("\\u" + Convert.ToUInt32(character) + "?");
            }
            string rtf = @"{\rtf1\ansi\deff0 {\colortbl;\red0\green0\blue0;\red0\green0\blue255;} " + body + " }";
            return rtf;
        }

        public static string ForRtf(string str)
        {
            return str.Trim().Replace(@"\", @"\\").Replace(@"{", @"\{").Replace(@"}", @"\}");
        }

        public frmDocumentViewer(string filePath, string name, UserCredentials user = null)
        {
            InitializeComponent();
            _filePath = filePath;
            if (!string.IsNullOrEmpty(name))
            {
                this.Text = name;
            }
            IEnumerable<BoxViewModel> boxes = new List<BoxViewModel>();
            DocumentViewer.Security.Security security = DocumentViewerModel.GetMinimalSecurity();

            if (user != null)
            {
                viewer = new Viewer(filePath, boxes, security, "PL", new string[] { user.Domain, user.Login, user.Password });
            }
            else
            {
                viewer = new Viewer(filePath, boxes, security, "PL");
            }

            _ctrlHost = new ElementHost();
            _ctrlHost.Dock = DockStyle.Fill;
            this.pnlView.Controls.Add(_ctrlHost);
            _ctrlHost.Child = viewer;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        }

        public frmDocumentViewer()
        {
            InitializeComponent();
        }

        public void Save_ViewerSettings(object sender, SavingSettingsEventArgs e)
        {
            DocumentViewerModel.SaveDocumentSettings(_documentId, _classId, e.Boxes);
        }

        public void LoadPosition()
        {
            //Ustawienie pozycji okna po wczytaniu, poświadczenia użytkownika zalogowanego
            //var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //path = Path.Combine(path, "dms_temp.txt");

            try
            {
                var fileContent = TempController.LoadViewerPositionParams();
                if (string.IsNullOrEmpty(fileContent))
                {
                    this.StartPosition = FormStartPosition.CenterParent;
                    return;
                }
                var parameters = Regex.Split(fileContent, ",");
                if (parameters.Length != 7)
                {
                    this.StartPosition = FormStartPosition.CenterParent;
                    return;
                }
                // X,Y,width,height,screenWidth,screenHeight,windowState
                //będziemy używać tylko normalnego lub zmaksymalizowanego stanu
                if (parameters.Length == 7 && parameters[6].Equals(FormWindowState.Maximized.ToString()))
                {
                    this.WindowState = FormWindowState.Maximized;
                }
                else if (parameters.Length == 7)
                {
                    int screenWidthSaved;
                    int screenHeightSaved;
                    if (int.TryParse(parameters[4], out screenWidthSaved) && int.TryParse(parameters[5], out screenHeightSaved))
                    {
                        var screenSizeActual = Screen.FromControl(this).Bounds;
                        //sprawdzanie, czy zmieniła się rozdzielczość ekranu
                        if (screenSizeActual.Size != new System.Drawing.Size(screenWidthSaved, screenHeightSaved))
                        {
                            this.WindowState = FormWindowState.Maximized;
                        }
                        else
                        {
                            int X_;
                            int Y_;
                            int width_;
                            int height_;
                            if (
                                int.TryParse(parameters[0], out X_) &&
                                int.TryParse(parameters[1], out Y_) &&
                                int.TryParse(parameters[2], out width_) &&
                                int.TryParse(parameters[3], out height_)
                            )
                            {
                                //ewentualna korekta punktu początkowego ekranu
                                X_ = X_ < -8 ? 0 : ( X_ > Screen.FromControl(this).Bounds.Width ? 0 : X_);
                                Y_ = Y_ < -8 ? 0 : ( Y_ > Screen.FromControl(this).Bounds.Height ? 0 : Y_);
                                width_ = width_ > (Screen.FromControl(this).Bounds.Width + 16) ? Screen.FromControl(this).Bounds.Width :
                                    (width_ < 300 ? 1000 : width_);
                                height_ = height_ > (Screen.FromControl(this).Bounds.Height + 16) ? Screen.FromControl(this).Bounds.Height : 
                                    (height_ < 300 ? 600 : height_);

                                this.Location = new System.Drawing.Point(X_, Y_);
                                this.Size = new System.Drawing.Size(width_, height_);
                            }
                            else
                            {
                                //wartości domyślne
                                this.StartPosition = FormStartPosition.CenterParent;
                            }
                        }
                    }
                    else
                    {
                        this.StartPosition = FormStartPosition.CenterParent;
                    }
                }
                else
                {
                    this.StartPosition = FormStartPosition.CenterParent;
                }
            }
            catch (Exception)
            {
                this.StartPosition = FormStartPosition.CenterParent;
                _logger.Error("Wystąpił problem podczas wczytywania pozycji okna.");
                return;
            }
        }

        private void frmDocumentViewer_Load(object sender, EventArgs e)
        {
            LoadPosition();
        }

        public void SavePositionOnClose()
        {
            //zapis pozycji okna do pliku po jego zamknięciu, walidacja tylko przy otwieraniu okna
            //var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //path = Path.Combine(path, "dms_temp.txt");
            //Maximized, Normal
            var screenSize = Screen.FromControl(this).Bounds;
            // X,Y,width,height,screenWidth,screenHeight,windowState

            StringBuilder sb = new StringBuilder();
            var startX = this.Location.X; // < -8 ? 0 : this.Location.X;
            var startY = this.Location.Y; // < -8 ? 0 : this.Location.Y;
            var startWidth = this.Width; // > (screenSize.Width + 16) ? screenSize.Width : this.Width;
            var startHeight = this.Height; // > (screenSize.Height + 16) ? screenSize.Height : this.Height;
            sb.Append(string.Format("{0},{1},{2},{3},{4},{5},", startX, startY, startWidth, startHeight, screenSize.Width, screenSize.Height));
            sb.Append(this.WindowState == FormWindowState.Minimized ? FormWindowState.Normal.ToString() : this.WindowState.ToString());
            try
            {
                TempController.SaveViewerPositionParams(sb.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nie można zapisać informacji o kontrolce do tempa!");
                _logger.Error(string.Format("Nie można zapisać informacji o kontrolce do tempa: {0}", ex));
            }
            try
            {
                this.Dispose();
            }
            catch (Exception)
            {

            }
        }

        private void frmDocumentViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            SavePositionOnClose();
        }
    }
}
