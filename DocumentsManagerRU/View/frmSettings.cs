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

namespace DocumentsManagerRU
{
    public partial class frmSettings : Form
    {
        private DataShare _ds;
        private bool _changePermission = false;
        //private ToolTip _ttEditServerPath;
        //private string _tempServerPath = "";

        public frmSettings(DataShare ds)
        {
            _ds = ds;
            InitializeComponent();
        }

        public void LoadData()
        {
            PrepareSettingsForm();
            //_ttEditServerPath = Data.SetToolTip(cbEditServerPath, GetValueFromDictionary("lblEdit"));
            Data.SetToolTip(btnCancel, GetValueFromDictionary("msgCancel"));
            Data.SetToolTip(btnSavePath, GetValueFromDictionary("ttSavePath"));
            Data.SetToolTip(btnChooseFolder, GetValueFromDictionary("ttOpenDirectory"));
            //btnSavePath.Enabled = false;
            //SetServerPathEdit(false);
            _changePermission = true;

        }

        public void PrepareSettingsForm()
        {
            var settings = GlobalSettings.GetAllSettings();
            //ustawienie ścieżki serwera
            txtCurrentServerPath.Text /*= _tempServerPath*/ = Data.GetServerRoot();
            //ustawienie usuwania po zwolnieniu
            var deleteOnRelease = settings.SingleOrDefault(sett => sett.Name == GlobalSettings.SettingsDictionary.DeleteAfterReleaseBOOL).Value;
            ercDelete.Checked = deleteOnRelease == "1" ? true : false;
            //wysyłka emaila po zwolnieniu dokumentu
            var sendEmailOnRelease = settings.SingleOrDefault(sett => sett.Name == GlobalSettings.SettingsDictionary.SendEmailAfterReleaseBOOL).Value;
            ercMailOnRelease.Checked = sendEmailOnRelease == "1" ? true : false;
            //otwieranie dokumentów za pomocą zewnętrznej aplikacji, a nie wbudowanego viewera
            var useExternalViewer = settings.SingleOrDefault(sett => sett.Name == GlobalSettings.SettingsDictionary.UseExternalViewer_BOOL).Value;
            ercUseExternalViewer.Checked = useExternalViewer == "1" ? true : false;
        }

        public void SetDeleting()
        {
            var check = GlobalSettings.GetFlagSetting_DB(GlobalSettings.SettingsDictionary.DeleteAfterReleaseBOOL);
            if (check.HasValue)
            {
                ercDelete.Checked = check.Value;
                ercDelete.Enabled = true;
            }
            else
            {
                ercDelete.Enabled = false;
            }
            
        }

        public void SetServerPath()
        {
            var root = GlobalSettings.GetSetting_DB(GlobalSettings.SettingsDictionary.ServerDirectorySTRING);
            txtCurrentServerPath.Text /*= _tempServerPath*/ = root;
        }

        public bool IsDirtyServerPath()
        {
            bool dirty = false;
            if (!string.IsNullOrEmpty(txtNewServerPath.Text) && (txtCurrentServerPath.Text != txtNewServerPath.Text))
            {
                return true;
            }
            return dirty;
        }

        public void UpdateDeletingOption()
        {
            bool delete = ercDelete.Checked;
            GlobalSettings.SetFlagSetting(GlobalSettings.SettingsDictionary.DeleteAfterReleaseBOOL, delete);
        }

        public void UpdateUseExternalViewer()
        {
            bool use = ercUseExternalViewer.Checked;
            GlobalSettings.SetFlagSetting(GlobalSettings.SettingsDictionary.UseExternalViewer_BOOL, use);

        }

        public void UpdateEmailOnReleaseOption()
        {
            bool send = ercMailOnRelease.Checked;
            GlobalSettings.SetFlagSetting(GlobalSettings.SettingsDictionary.SendEmailAfterReleaseBOOL, send);
        }

        public void DoSaveServerPath()
        {
            if (IsDirtyServerPath())
            {
                //zapis do bazy nowego adresu
                GlobalSettings.SetSetting(GlobalSettings.SettingsDictionary.ServerDirectorySTRING, txtNewServerPath.Text);
                txtCurrentServerPath.Text = txtNewServerPath.Text;
                txtNewServerPath.Text = string.Empty;
                //btnSavePath.Enabled = false;
            }
        }

        private void rbDeletingFilesYes_MouseClick(object sender, MouseEventArgs e)
        {
            if(_changePermission)
                UpdateDeletingOption();
        }

        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = TryCloseWindow();
        }

        public bool TryCloseWindow()
        {
            if (IsDirtyServerPath())
            {
                //alert na zamykanie okna bez zapisania zmian
                DialogResult res = DialogBox.ShowDialog(_ds.LocRM.GetString("msg18"), _ds.LocRM.GetString("msg19"), _ds, MessageBoxButtons.YesNo, DialogBox.Icons.Warning);
                if (res != System.Windows.Forms.DialogResult.Yes)
                {
                    // jeżeli użytkownik się nie zgadza
                   return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        private void ercDelete_CheckedChanged(object sender, EventArgs e)
        {
            if(_changePermission)
                UpdateDeletingOption();
        }

        public void ChooseFolder()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            //czy wybrano już nową ścieżkę
            if (!string.IsNullOrEmpty(txtNewServerPath.Text))
            {
                fbd.SelectedPath = txtNewServerPath.Text;
            }
            //
            else if (!string.IsNullOrEmpty(txtCurrentServerPath.Text))
            {
                fbd.SelectedPath = txtCurrentServerPath.Text;
            }
            DialogResult result = fbd.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //txtCurrentServerPath.Text = fbd.SelectedPath;
                txtNewServerPath.Text = fbd.SelectedPath;
                //odblokowanie możliwości zapisu
                //btnSavePath.Enabled = true;
            }
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }

        private void btnSavePath_Click(object sender, EventArgs e)
        {
            DoSaveServerPath();
        }

        public string GetValueFromDictionary(string text)
        {
            return !string.IsNullOrEmpty(_ds.LocRM.GetString(text)) ? _ds.LocRM.GetString(text) : "";
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ercMailOnRelease_CheckedChanged(object sender, EventArgs e)
        {
            if (_changePermission)
                UpdateEmailOnReleaseOption();
        }

        private void ercUseExternalViewer_CheckedChanged(object sender, EventArgs e)
        {
            if (_changePermission)
                UpdateUseExternalViewer();
        }
    }
}
