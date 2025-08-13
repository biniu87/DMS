using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace DocumentsManagerRU
{
    public partial class DialogBox : Form
    {

        #region Global types

        public static string MESSAGE_SUCCESS = "msgSuccess"; //Operacja zakończona sukcesem!
        public static string MESSAGE_FAILED = "msgFailed"; //Wystąpił problem w trakcie trwania operacji!
        public static string MESSAGE_DELETE = "msgDelete"; //Potwierdź usunięcie
        public static string MESSAGE_CANCEL = "msgCancel"; //Anuluj
        public static string MESSAGE_YES = "msgYes"; // Tak
        public static string MESSAGE_NO = "msgNo"; // Nie

        public static string OBJECT_CLASS = "objectClass"; 
        public static string OBJECT_DOCUMENT = "objectDocument";
        public static string OBJECT_DEFINITION = "objectDefinition";
        public static string OBJECT_DEFINITIONPERCLASS = "objectAssociatedDefinition";

        public static string ACTION = "action"; // obiekt akcji- akcja
        public static string ACTION_CREATE = "actionCreate"; //tworzenie
        public static string ACTION_DELETE = "actionDelete"; //usuwanie
        public static string ACTION_RELEASE = "actionRelease"; //zwalnianie
        public static string ACTION_SAVE = "actionSave"; // zapisywanie

        public enum Icons
        {
            None = 0,
            Success = 1,// = DocumentsManagerRU.Properties.Resources.check_6x,
            Info = 2,// = DocumentsManagerRU.Properties.Resources.info_6x,
            Error = 3,// = DocumentsManagerRU.Properties.Resources.x_6x,
            Warning = 4,// = DocumentsManagerRU.Properties.Resources.warning_6x,
            Question = 5// = DocumentsManagerRU.Properties.Resources.question_mark_6x
        }

        #endregion

        private MessageBoxButtons _buttons;
        //private readonly DispatcherTimer dispatcherTimer;

        public DialogBox()
        {
            InitializeComponent();
        }

        public DialogBox(string body, string title, Icons icon)
        {
            InitializeComponent();
            lblBody.Text = body;
            this.Text = title;

            if (this.Parent == null)
            {
                StartPosition = FormStartPosition.CenterScreen;
            }

            //ikona
            switch (icon)
            {
                case Icons.None:
                    lblImage.Image = null;
                    break;
                case Icons.Info:
                    lblImage.Image = DocumentsManagerRU.Properties.Resources.info_6x;
                    break;
                case Icons.Success:
                    lblImage.Image = DocumentsManagerRU.Properties.Resources.check_6x;
                    break;
                case Icons.Error:
                    lblImage.Image = DocumentsManagerRU.Properties.Resources.x_6x;
                    break;
                case Icons.Warning:
                    lblImage.Image = DocumentsManagerRU.Properties.Resources.warning_6x;
                    break;
                case Icons.Question:
                    lblImage.Image = DocumentsManagerRU.Properties.Resources.question_mark_6x;
                    break;
            }

            btn1.Visible = false;
            btn2.Visible = false;
            btn3.Visible = false;
        }

        public DialogBox(string body, string title, DataShare ds, MessageBoxButtons buttons, Icons icon)
        {
            InitializeComponent();
            _buttons = buttons;
            lblBody.Text = body;
            this.Text = title;

            if (this.Parent == null)
            {
                StartPosition = FormStartPosition.CenterScreen;
            }

            //ikona
            switch (icon)
            {
                case Icons.None:
                    lblImage.Image = null;
                    break;
                case Icons.Info:
                    lblImage.Image = DocumentsManagerRU.Properties.Resources.info_6x;
                    break;
                case Icons.Success:
                    lblImage.Image = DocumentsManagerRU.Properties.Resources.check_6x;
                    break;
                case Icons.Error:
                    lblImage.Image = DocumentsManagerRU.Properties.Resources.x_6x;
                    break;
                case Icons.Warning:
                    lblImage.Image = DocumentsManagerRU.Properties.Resources.warning_6x;
                    break;
                case Icons.Question:
                    lblImage.Image = DocumentsManagerRU.Properties.Resources.question_mark_6x;
                    break;
            }
            //widoczność przycisków, nagłówki, tytuł okna
            switch (buttons)
            {
                default: //case MessageBoxButtons.OK:
                    btn1.Visible = false;
                    btn2.Visible = false;
                    btn3.Visible = true;
                    btn3.Text = "OK";
                    this.AcceptButton = btn3;
                    this.CancelButton = btn3;
                    break;
                case MessageBoxButtons.OKCancel:
                    btn1.Visible = false;
                    btn2.Visible = true;
                    btn3.Visible = true;
                    btn2.Text = "OK";
                    btn3.Text = ds.LocRM.GetString(MESSAGE_CANCEL);
                    this.AcceptButton = btn2;
                    this.CancelButton = btn3;
                    break;
                case MessageBoxButtons.YesNo:
                    btn1.Visible = false;
                    btn2.Visible = true;
                    btn3.Visible = true;
                    btn2.Text = ds.LocRM.GetString(MESSAGE_YES);
                    btn3.Text = ds.LocRM.GetString(MESSAGE_NO);
                    this.AcceptButton = btn2;
                    this.CancelButton = btn3;
                    break;
                case MessageBoxButtons.YesNoCancel:
                    btn1.Visible = true;
                    btn2.Visible = true;
                    btn3.Visible = true;
                    btn1.Text = ds.LocRM.GetString(MESSAGE_YES);
                    btn2.Text = ds.LocRM.GetString(MESSAGE_NO);
                    btn3.Text = ds.LocRM.GetString(MESSAGE_CANCEL);
                    this.AcceptButton = btn1;
                    this.CancelButton = btn3;
                    break;
            }
        }

        public static DialogResult ShowDialog(string body, string title = "", DataShare ds = null,  MessageBoxButtons buttons = MessageBoxButtons.OK, Icons icon = 0)
        {
            DialogBox dialog = new DialogBox(body, title, ds, buttons, icon);
            if(ds != null)
                ds.SetColors(dialog);
            return dialog.ShowDialog();
        }

        public static void ShowEvanescenceBox(string body, string title = "", DataShare ds = null, Icons icon = 0, int displaySeconds = 2)
        {
            //await Task.Factory.StartNew(() =>
            //{
            //});

            DialogBox dialog = new DialogBox(body, title, icon);
            if (ds != null)
                ds.SetColors(dialog);
            dialog.TopLevel = true;
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler((object sender, EventArgs e) =>
            {
                dialog.Close();
                dispatcherTimer.IsEnabled = false;
            });
            dispatcherTimer.Interval = new TimeSpan(0, 0, displaySeconds);
            dispatcherTimer.Start();
            dialog.Show();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            switch (_buttons)
            {
                case MessageBoxButtons.YesNoCancel:
                    this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    break;
                default:
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    break;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            switch (_buttons)
            {
                case MessageBoxButtons.OKCancel:
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    break;
                case MessageBoxButtons.YesNo:
                    this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    break;
                case MessageBoxButtons.YesNoCancel:
                    this.DialogResult = System.Windows.Forms.DialogResult.No;
                    break;
                default:
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    break;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            switch (_buttons)
            {
                case MessageBoxButtons.OK:
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    break;
                case MessageBoxButtons.OKCancel:
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    break;
                case MessageBoxButtons.YesNo:
                    this.DialogResult = System.Windows.Forms.DialogResult.No;
                    break;
                case MessageBoxButtons.YesNoCancel:
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    break;
                default:
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    break;
            }
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            //akcja na zakończenie timera
            //dispatcherTimer.IsEnabled = false;
            this.Close();
        }

        //inicjalizacja timera, potem Start();
        //dispatcherTimer = new DispatcherTimer();
        //dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
        //dispatcherTimer.Interval = new TimeSpan(0, 0, 2);
    }

}
