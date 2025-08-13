using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using Extensions;
using DocumentsManagerRU.Controls.Interfaces;

namespace DocumentsManagerRU.Controls
{
    public partial class SearchControl : UserControl
    {
        //private ResourceManager _locRM { get; set; }
        private DataShare _ds;
        private List<UserControl> _controls = new List<UserControl>();
        private frmMain _main;

        public SearchControl(frmMain main, DataShare ds, List<GetDocumentDefinitionsForClass_Result> indexDefinitions = null)
        {
            _main = main;
            _ds = ds;
            InitializeComponent();
            _ds.SetColors(this);
            LanguageController.SetLanguage(this, _ds.LocRM);
            this.tlpControls.HorizontalScroll.Visible = false;
            this.tlpControls.HorizontalScroll.Enabled = false;
            if (Security.Admin)
            {
                //predefiniowane
                SearchDateControl ctrl = (SearchDateControl)CreateParamControl((int)Data.IndexTypes.Date, _ds.LocRM.GetString("lblDeactivateDate"), "Deactivate_Date");
                AddControl(ctrl);
            }
            searchValueControlClassName.SetDetails((int)Data.IndexTypes.String, _ds.LocRM.GetString("lblSearchDocName"), "Name");
            searchDateControlReleaseDate.SetDetails((int)Data.IndexTypes.Date, _ds.LocRM.GetString("lblSearchReleaseDate"), "Release_Date");
            //Kontrolki predefiniowane
            _controls.Add(searchValueControlClassName);
            _controls.Add(searchDateControlReleaseDate);
            AddControls(indexDefinitions);
        }

        public SearchControl()
        {
            if (DesignMode)
                _ds.SetLanguage("pl");
            if (_ds != null)
            {
                _ds.SetColors(this);
                searchValueControlClassName.SetDetails((int)Data.IndexTypes.String, _ds.LocRM.GetString("lblSearchDocName"), "Name");
                searchDateControlReleaseDate.SetDetails((int)Data.IndexTypes.Date, _ds.LocRM.GetString("lblSearchReleaseDate"), "Release_Date");
            }
        }

        //public SearchControl(DataShare ds)
        //{
        //    Data.SetColors(this);
        //    searchValueControlClassName.SetDetails((int)Data.IndexTypes.String, _ds.LocRM.GetString("lblSearchDocName"), "Name");
        //    searchDateControlReleaseDate.SetDetails((int)Data.IndexTypes.Date, _ds.LocRM.GetString("lblSearchReleaseDate"), "Release_Date");
        //}

        public void AddControl(UserControl ctrl)
        {
            if (ctrl is SearchDateControl)
            {
                this.tlpControls.RowStyles.Insert(this.tlpControls.RowStyles.Count, new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            }
            else if (ctrl is SearchComboControl || ctrl is SearchValueControl)
            {
                this.tlpControls.RowStyles.Insert(this.tlpControls.RowStyles.Count, new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            }
            _controls.Add(ctrl);
            tlpControls.Controls.Add(ctrl, 0, tlpControls.Controls.Count);

        }

        public void AddControls(List<GetDocumentDefinitionsForClass_Result> definitions)
        {
            if (definitions != null)
            {
                foreach (GetDocumentDefinitionsForClass_Result def in definitions)
                {
                    List<Document_DefinitionList_Items> items;
                    if(def.DataType == (int)Data.IndexTypes.List)
                    {
                        items = Data.GetDefinitionListItemsForDefinitionId(def.DefinitionId).ToList();
                        UserControl ctrl = CreateParamControl(def.DataType.Value, def.CurrentName, def.ColumnName, items);
                        AddControl(ctrl);
                    }
                    else
                    {
                        UserControl ctrl = CreateParamControl(def.DataType.Value, def.CurrentName, def.ColumnName, def.Items);
                        AddControl(ctrl);
                    }
                }
            }
        }

        public UserControl CreateParamControl(int type, string label, string column, List<Document_DefinitionList_Items> advItems)
        {
            SearchComboControl ctrl = new SearchComboControl();
            ctrl.SetDetails(type, label, column, advItems);
            return ctrl;
        }

        public UserControl CreateParamControl(int type, string label, string column, string items = "")
        {
            switch (type)
            {
                case (int)Data.IndexTypes.Date:
                    {
                        SearchDateControl ctrl = new SearchDateControl();
                        ctrl.SetDetails(type, label, column);
                        return ctrl;
                    }
                //case (int)Data.IndexTypes.List:
                //    {
                //        SearchComboControl ctrl = new SearchComboControl();
                //        ctrl.SetDetails(type, label, column, advItems);
                //        return ctrl;
                //    }
                case (int)Data.IndexTypes.SimpleList:
                    {
                        SearchComboControl ctrl = new SearchComboControl();
                        ctrl.SetDetails(type, label, column, items);
                        return ctrl;
                    }
                default:
                    {
                        // dla liczb i wartości tekstowych
                        SearchValueControl ctrl = new SearchValueControl();
                        ctrl.SetDetails(type, label, column);
                        return ctrl;
                    }
                //case (int)Data.IndexTypes.Number:
                //    {
                //        SearchValueControl ctrl = new SearchValueControl();
                //        ctrl.SetDetails(type, label, column);
                //        return ctrl;
                //    }
                //case (int)Data.IndexTypes.String:
                //    {
                //        SearchValueControl ctrl = new SearchValueControl();
                //        ctrl.SetDetails(type, label, column);
                //        return ctrl;
                //    }
            }
        }

        public string CreateQueryConditions(bool isAdmin)
        {
            StringBuilder builder = new StringBuilder();
            if (isAdmin)
                builder.Append("WHERE 1 = 1");
            else
                builder.Append("WHERE Active = 1");
            foreach (ISearchControl ctrl in _controls)
            {
                string[] param = ctrl.GetParam();
                if (param.Length > 0)
                {
                    int type = Convert.ToInt32(param[0]);
                    if (type == (int)Data.IndexTypes.Date)
                    {
                        builder.Append(string.Format(" AND {0} BETWEEN '{1}' AND DATEADD(SECOND,-1,DATEADD(DAY,1,'{2}'))", param[1], param[2], param[3]));
                    }
                    else if (type == (int)Data.IndexTypes.Number)
                    {
                        builder.Append(string.Format(" AND {0} = {1}", param[1], param[2]));
                    }
                    else if ((type == (int)Data.IndexTypes.String) || (type == (int)Data.IndexTypes.List) || (type == (int)Data.IndexTypes.SimpleList))
                    {
                        builder.Append(string.Format(" AND {0} LIKE '%{1}%'", param[1], param[2].ToInsert()));
                    }
                    //else if (type == (int)Data.IndexTypes.List)
                    //{
                    //    builder.Append(string.Format(" AND {0} LIKE '%{1}%'", param[1], param[2]));
                    //}
                }
            }
            return builder.ToString();
        }

        public void ClearControl()
        {
            foreach (ISearchControl ctrl in _controls)
            {
                ctrl.Clear();
            }
        }

        public int GetComponentHeight()
        {
            int size;
            if (lblSearch != null)
            {
                size = lblSearch.DisplayRectangle.Size.Height;
            }
            else
            {
                size = 0;
            }
            if(tlpControls != null)
            {
                foreach (Control ctrl in tlpControls.Controls)
                {
                    //ręczny pomiar długości - długość komponentu może być zakłamana przez element z dynamicznie modyfikowaną wielkością dodawany przez Visuala
                    size += ctrl.Height;
                }
            }
            return size;
        }

        private void tlpControls_SizeChanged(object sender, EventArgs e)
        {
            if (this.tlpControls.HorizontalScroll.Visible)
            {
                this.tlpControls.HorizontalScroll.Visible = false;
                this.tlpControls.HorizontalScroll.Enabled = false;
                this.tlpControls.Dock = DockStyle.None;
                this.tlpControls.Dock = DockStyle.Fill;
            }
        }

        private void btnHideSearch_Click(object sender, EventArgs e)
        {
            _main.HideSearchPanel();
        }
    }
}
