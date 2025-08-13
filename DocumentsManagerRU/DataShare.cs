using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DocumentsManagerRU.ImpersonationClass;
using NLog;

namespace DocumentsManagerRU
{
    public class DataShare
    {
        public DataShare()
        {
        }

        private frmMain _main;
        private ResourceManager _locRM;
        public ResourceManager LocRM { get { return _locRM; } }
        private ColorLayout _colorLayout;
        public ColorLayout ColorLayout { get { return _colorLayout != null ? _colorLayout : ColorLayoutController.GetDefaultColorLayout(); }}
        private string _language;
        public string Language { get { return _language; } }
        public Bitmap Logo { get { return _main != null ? _main.Icon.ToBitmap() : null; } }
        public readonly bool UseExternalViewer = GlobalSettings.GetFlagSetting_Temp(GlobalSettings.SettingsDictionary.UseExternalViewer_BOOL).GetValueOrDefault(false);
        public readonly string AlertEmails = GlobalSettings.GetSingleSetting_Temp(GlobalSettings.SettingsDictionary.AlertEmailsSTRING).Value;
        public void SetFrmMain(frmMain main)
        {
            _main = main;
        }

        public void SetLanguage(string language)
        {
            _language = language.ToUpper();
            SetResourceManager(LanguageController.GetLanguageResources(_language));
            ReloadLanguage();
        }

        public void ReloadLanguage()
        {
            if (_main != null)
                _main.SetLanguage();
        }

        private void SetResourceManager(ResourceManager locRm)
        {
            _locRM = locRm;
        }

        public void RefreshDocumentGridSimple()
        {
            if (_main != null)
                _main.RefreshDocumentGridSimple();
        }

        public void RefreshDocumentGridFull()
        {
            _main.RefreshDocumentGridFull();
        }

        public void RefreshData()
        {
            if (_main != null)
                _main.RefreshData();
        }

        public void SetLanguageToDefault()
        {
            var lang = LanguageController.GetDefaultLanguage();
            SetLanguage(lang);
        }

        public void SetColorLayout(ColorLayout layout)
        {
            _colorLayout = layout;
            if(_main != null)
                SetColors(_main);
        }

        public void SetColors(System.Windows.Forms.Control ctrl)
        {
            ColorLayoutController.SetColors(ctrl, ColorLayout);
        }

        //public void SetResourceManagerToDefault(string lang = "")
        //{
        //    var defaultLang = lang;
        //    if (string.IsNullOrEmpty(lang))
        //    {
        //        SetLanguageToDefault();
        //    }

        //    switch (_language)
        //    {
        //        case ("PL"):
        //            SetResourceManager(new ResourceManager("DocumentsManagerRu.InterfaceLang_PL", typeof(DataShare).Assembly));
        //        case ("RU"):
        //            SetResourceManager(new ResourceManager("DocumentsManagerRu.InterfaceLang_RU", typeof(DataShare).Assembly));
        //        default:
        //            SetResourceManager(new ResourceManager("DocumentsManagerRu.InterfaceLang_PL", typeof(DataShare).Assembly));
        //    }
        //}

    }
}