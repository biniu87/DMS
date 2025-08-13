using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentViewer.Controls.Boxes;
using DocumentViewer.Security;
using DocumentViewer.ViewModels;
using NLog;

namespace DocumentsManagerRU
{
    public class DocumentViewerModel
    {
        public static Logger _logger = LogManager.GetLogger("DATA");

        //IEnumerable<BoxViewModel> _boxes = new List<BoxViewModel>(); // DataAccess.GetBoxes(documentId, classId);

        private static Type MapToType(int type)
        {
            switch (type)
            {
                case 0:
                    return typeof(Blackout);
                case 1:
                    return typeof(Highlight);
                case 2:
                    return typeof(Note);
                default:
                    throw new ArgumentException("boxType");
            }
        }

        private static int MapToInt(Type type)
        {
            if (type == typeof(Blackout))
            {
                return 0;
            }
            else if (type == typeof(Highlight))
            {
                return 1;
            }
            else if (type == typeof(Note))
            {
                return 2;
            }
            else
            {
                throw new ArgumentException("boxType");
            }
        }

        public static IEnumerable<BoxViewModel> GetDocumentViewerAdds(int classId, int userId)
        {
            List<BoxViewModel> boxes = new List<BoxViewModel>();
            using (var db = new DocContext())
            {
                try
                {
                    IEnumerable<PobierzOznaczenia_Result> Adds = db.PobierzOznaczenia(userId, classId);
                    BoxViewModel bvm;
                    foreach (var box in Adds)
                    {
                        bvm = new BoxViewModel();
                        bvm.Type = MapToType(box.Typ);
                        bvm.Page = box.Strona;
                        bvm.Position = box.Pozycja;
                        bvm.Left = box.Left;
                        bvm.Top = box.Top;
                        bvm.Width = box.Width;
                        bvm.Height = box.Height;
                        bvm.Text = box.Column1;
                        boxes.Add(bvm);
                    }
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd pobrania ustawień kontrolki DocumentViewer dla usera: {0}, klasy: {1}, e: {2}", userId, classId, e);
                    return boxes;
                }
            }
            return boxes;
        }

        public static bool SaveDocumentSettings(Int64 documentId, int classId, IEnumerable<BoxViewModel> boxes)
        {
            using (var db = new DocContext())
            {
                try
                {
                    db.WyczyscOznaczeniaZeSkanu(documentId, classId);
                    foreach(var box in boxes)
                    {
                        db.ZapiszOznaczenie(documentId, classId, MapToInt(box.Type), box.Page, box.Position, box.Left, box.Top, box.Width, box.Height, box.Text);
                    }
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd zapisania ustawień kontrolki DocumentViewer dla dokumentu: {0}, klasy: {1}, e: {2}", documentId, classId, e);
                    return false;
                }
            }
            return true;
        }

        public static ModificationsPermissions GetModificationPermissionFromInt(int? permission)
        {
            switch (permission.HasValue ? permission.Value : 0)
            {
                default:
                    return ModificationsPermissions.None;
                case (0): 
                    return ModificationsPermissions.None;
                case (1):
                    return ModificationsPermissions.New;
                case (2): 
                    return ModificationsPermissions.Modify;
            }
        }

        public static OperationsPermissions GetOperationsPermissionFromInt(int? permission)
        {
            switch (permission.HasValue ? permission.Value : 0)
            {
                default:
                    return OperationsPermissions.None;
                case (0):
                    return OperationsPermissions.None;
                case (1):
                    return OperationsPermissions.WithModifications;
                case (2):
                    return OperationsPermissions.WithoutModifications;
            }
        }

        public static DocumentViewer.Security.Security GetDocumentViewerSecurity(string securityObjects, int classId)
        {
            using (var db = new DocContext())
            {
                try
                {
                    GetDocumentClassPermission_Result result = db.GetDocumentClassPermission(securityObjects, classId).FirstOrDefault();
                    DocumentViewer.Security.Security security = new DocumentViewer.Security.Security();
                    security.Blackouts = GetModificationPermissionFromInt(result.M_Blackout);
                    security.Highlights = GetModificationPermissionFromInt(result.M_Highlight);
                    security.Notes = GetModificationPermissionFromInt(result.M_Note);
                    security.Saving = GetOperationsPermissionFromInt(result.O_Save);
                    security.Printing = GetOperationsPermissionFromInt(result.O_Print);
                    security.Sending = GetOperationsPermissionFromInt(result.O_Send);
                    security.CanHideBlackouts = result.CH_Blackout.HasValue ? result.CH_Blackout.Value : false;
                    security.CanHideHighlights = result.CH_Highlight.HasValue ? result.CH_Highlight.Value : false;
                    security.CanHideNotes = result.CH_Note.HasValue ? result.CH_Note.Value : false;
                    return security;
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd pobrania poświadczeń dla klasy: {0}, obiektów: {1}, e: {2}", classId, securityObjects, e);
                    return new DocumentViewer.Security.Security();
                }
            }
        }

        public static DocumentViewer.Security.Security GetDocumentViewerSecurityForAdmin()
        {
            DocumentViewer.Security.Security security = new DocumentViewer.Security.Security();
            security.Blackouts = ModificationsPermissions.Modify;
            security.Highlights = ModificationsPermissions.Modify;
            security.Notes = ModificationsPermissions.Modify;
            security.Saving = OperationsPermissions.WithoutModifications;
            security.Printing = OperationsPermissions.WithoutModifications;
            security.Sending = OperationsPermissions.WithoutModifications;
            security.CanHideBlackouts = true;
            security.CanHideHighlights = true;
            security.CanHideNotes = true;
            return security;
        }

        public static DocumentViewer.Security.Security GetMinimalSecurity()
        {
            DocumentViewer.Security.Security security = new DocumentViewer.Security.Security();
            security.Blackouts = ModificationsPermissions.None;
            security.Highlights = ModificationsPermissions.None;
            security.Notes = ModificationsPermissions.None;
            security.Saving = OperationsPermissions.None;
            security.Printing = OperationsPermissions.None;
            security.Sending = OperationsPermissions.None;
            security.CanHideBlackouts = false;
            security.CanHideHighlights = false;
            security.CanHideNotes = false;
            return security;
        }

        public static string GetDocumentPath(Int64 documentId, int classId)
        {
            using (var db = new DocContext())
            {
                try
                {
                    return db.GetDocumentPath(documentId, classId).ToString();
                }
                catch (Exception e)
                {
                    _logger.Error("Błąd pobrania ściżki do dokumentu, dokument: {0}, klasa: {1}, e: {2}", documentId, classId, e);
                    return string.Empty;
                }
            }
        }

        public static DocumentViewer.Controls.Viewer.Viewer GetNewViewer(string filePath)
        {
            DocumentViewer.Controls.Viewer.Viewer viewer = null;
            IEnumerable<BoxViewModel> boxes = new List<BoxViewModel>();
            DocumentViewer.Security.Security security = DocumentViewerModel.GetMinimalSecurity();
            viewer = new DocumentViewer.Controls.Viewer.Viewer(filePath, boxes, security, "PL");
            return viewer;
        }

        /// <summary>
        /// Metoda oryginalna, obecnie używana jest osadzona w entity model
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="classId"></param>
        /// <param name="boxes"></param>
        public static void SaveScanSettings(Int64 documentId, int classId, IEnumerable<BoxViewModel> boxes)
        {
            string deleteOldBoxes = "WyczyscOznaczeniaZeSkanu";
            string saveBoxes = "ZapiszOznaczenie";

            using (var connection = new SqlConnection(Data.GetConnectionString()))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                using (var command = new SqlCommand(deleteOldBoxes, connection, transaction))
                {
                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@DocumentId", documentId);
                        command.Parameters.AddWithValue("@ClassId", classId);
                        command.ExecuteNonQuery();

                        command.CommandText = saveBoxes;

                        foreach (var box in boxes)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@DocumentId", documentId);
                            command.Parameters.AddWithValue("@ClassId", classId);
                            command.Parameters.AddWithValue("@Typ", MapToInt(box.Type));
                            command.Parameters.AddWithValue("@Strona", box.Page);
                            command.Parameters.AddWithValue("@Pozycja", box.Position);
                            command.Parameters.AddWithValue("@Left", box.Left);
                            command.Parameters.AddWithValue("@Top", box.Top);
                            command.Parameters.AddWithValue("@Width", box.Width);
                            command.Parameters.AddWithValue("@Height", box.Height);
                            command.Parameters.AddWithValue("@Text", box.Text);

                            command.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();

                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// Metoda oryginalna, obecnie używana osadzona jest w entity model 
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="classId"></param>
        /// <returns></returns>
        public static IEnumerable<BoxViewModel> GetDocumentViewerBoxes(long documentId, int classId)
        {
            using (var connection = new SqlConnection(Data.GetConnectionString()))
            using (var command = new SqlCommand("PobierzOznaczenia", connection))
            {
                connection.Open();

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@documentId", documentId);
                command.Parameters.AddWithValue("@classId", classId);

                var result = new List<BoxViewModel>();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int page = reader.GetInt32(0);

                    result.Add(new BoxViewModel
                    {
                        Page = page,
                        Position = reader.GetInt32(1),
                        Type = MapToType(reader.GetInt32(2)),
                        Left = reader.GetDouble(3),
                        Top = reader.GetDouble(4),
                        Width = reader.GetDouble(5),
                        Height = reader.GetDouble(6),
                        Text = reader.GetString(7)
                    });
                }

                return result;
            }
        }

        /// <summary>
        /// Metoda oryginalna, obecnie używana osadzona jest w entity model 
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="classId"></param>
        /// <returns></returns>
        public static string GetFilePath(Int64 documentId, int classId)
        {
            using (var connection = new SqlConnection(Data.GetConnectionString()))
            using (var command = new SqlCommand("GetDocumentPath", connection))
            {
                connection.Open();

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@documentId", documentId);
                command.Parameters.AddWithValue("@classId", classId);

                return command.ExecuteScalar().ToString();
            }
        }
    }
}
