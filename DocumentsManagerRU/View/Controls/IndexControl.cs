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
using DocumentsManagerRU.Controls.Interfaces;

namespace DocumentsManagerRU.Controls
{
    public partial class IndexControl : UserControl
    {
        private ResourceManager _rm;
        private List<Document_Index> _indexes;
        private string _language;
        private List<object[]> _tempValues;
        private List<UserControl> _controls = new List<UserControl>();
        public IndexControl(List<Document_Index> indexes, ResourceManager rm, string language)
        {
            InitializeComponent();
            //tlpIndexControl.VerticalScroll.Visible = true;
            _rm = rm;
            _language = language;
            _indexes = indexes != null ? indexes : new List<Document_Index>();
            InitializeIndexes();
            //_tempValues = GetValuesFromIndexes(_indexes);
            //gbIndexes.Text = _rm.GetString(gbIndexes.Name);
        }

        public IndexControl()
        {
            InitializeComponent();
        }

        public void InitializeIndexes()
        {
            if (_indexes.Count > 0)
            {
                tlpIndexControl.RowStyles.Clear();
                foreach (Document_Index index in _indexes)
                {
                    switch (index.Data_Type)
                    {
                        case (int)Data.IndexTypes.Date:
                            {
                                UserControl ctrl = new IndexDateControl(index, _rm, _language, true);
                                AddControl(ctrl);
                                break;
                            }
                        case (int)Data.IndexTypes.List:
                            {
                                UserControl ctrl = new IndexComboControl(index, _rm, _language, true);
                                AddControl(ctrl);
                                break;
                            }
                        case (int)Data.IndexTypes.SimpleList:
                            {
                                UserControl ctrl = new IndexComboControl(index, _rm, _language, true);
                                AddControl(ctrl);
                                break;
                            }
                        case (int)Data.IndexTypes.Number:
                            {
                                UserControl ctrl = new IndexValueControl(index, _rm, _language, true);
                                AddControl(ctrl);
                                break;
                            }
                        case (int)Data.IndexTypes.String:
                            {
                                UserControl ctrl = new IndexValueControl(index, _rm, _language, true);
                                AddControl(ctrl);
                                break;
                            }
                    }
                }
            }
            //if(tlpIndexControl.Height >= tlpIndexControl.DisplayRectangle.Height)
            //    AddEmptyControl();
        }

        public void AddEmptyRowStyle()
        {
            this.tlpIndexControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
        }

        public void AddControlRowStyle()
        {
            this.tlpIndexControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        }

        public void AddControl(Control ctrl)
        {
            AddControlRowStyle();
            ctrl.Dock = DockStyle.Fill;
            tlpIndexControl.Controls.Add(ctrl);
            _controls.Add((UserControl)ctrl);
        }

        public void AddEmptyControl()
        {
            AddEmptyRowStyle();
            Panel pnl = new Panel();
            tlpIndexControl.Controls.Add(pnl);
            pnl.Dock = DockStyle.None;
        }

        public void SetReadOnly(bool readOnly)
        {
            if (_controls.Count > 0)
            {
                foreach ( IIndexControl ctrl in _controls)
                {
                    ctrl.SetReadOnly(readOnly);
                }
            }
        }

        new public bool Validate()
        {
            if (_controls.Count > 0)
            {
                foreach (IIndexControl ctrl in _controls)
                {
                    if (!ctrl.Validate())
                    {
                        return false;
                    }
                }
            }
            else
            {
                return true;
            }
            return true;
        }

        public void Clear()
        {
            if (_controls.Count > 0)
            {
                foreach (IIndexControl ctrl in _controls)
                {
                    ctrl.Clear();
                }
            }
        }

        public bool IsModified()
        {
            bool result = false;
            List<Document_Index> actualValues = GetIndexes();
            foreach (Document_Index ind in actualValues)
            {
                var val = _tempValues.FirstOrDefault(obj => obj[0].ToString() == ind.Column_Name);
                if((val == null || val[1] == null ) || ind.Value == null)
                {
                    if ((val == null || val[1] == null) != (ind.Value == null))
                    {
                        //sprawdzanie, czy tylko jedno z powyższych ma wartość null
                        return true;
                    }
                }
                else if((val != null) && (val[1] != null) && (ind != null) && !ind.Value.ToString().Equals(val[1].ToString()))
                {
                    //sprawdzanie gdy oba posiadają jakąś wartość i czy tę samą
                    return true;
                }
            }
            return result;
        }

        public List<Document_Index> GetIndexes()
        {
            List<Document_Index> indexes = new List<Document_Index>();
            foreach (IIndexControl ctrl in _controls)
            {
                indexes.Add(ctrl.GetIndex());
            }
            return indexes;
        }

        public void ApplyValuesToControls(List<Document_Index> indexes)
        {
            _tempValues = new List<object[]>();
            foreach (IIndexControl ctrl in _controls)
            {
                //pobranie indeksu, ustawienie na nim wartości odpowiadającej temu samemu indeksowi
                Document_Index ind = ctrl.GetIndex();
                if (ind != null)
                {
                    Document_Index selected = indexes.FirstOrDefault(sourceIndex => sourceIndex.Class_Id == ind.Class_Id && sourceIndex.Column_Name == ind.Column_Name);
                    if (selected != null)
                    {
                        ctrl.SetIndexValue(selected);
                        _tempValues.Add(new object[] { selected.Column_Name, selected.Value }); // aktualizowanie zbioru wartości tymczasowych
                    }
                }
                    
            }
        }

        public void ApplyValuesToControls(List<object[]> indexValues)
        {
            _tempValues = indexValues;
            foreach (IIndexControl ctrl in _controls)
            {
                //pobranie indeksu, ustawienie na nim wartości odpowiadającej temu samemu indeksowi
                Document_Index ind = ctrl.GetIndex();
                ctrl.SetIndexValue(indexValues.FirstOrDefault(iv => iv[0].ToString() == ind.Column_Name)[1]);
            }
        }

        public List<object[]> GetValuesFromIndexes(List<Document_Index> indexes)
        {
            List<object[]> objects = new List<object[]>();
            foreach (Document_Index index in indexes)
            {
                objects.Add(new object[] { index.Column_Name, index.Value });
            }
            return objects;
        }

        private void IndexControl_Load(object sender, EventArgs e)
        {
            tlpIndexControl.Dock = DockStyle.None;
            tlpIndexControl.Width = 1000;
            //tlpIndexControl.HorizontalScroll.Visible = true;
            
            _tempValues = GetValuesFromIndexes(_indexes);
            //tlpIndexControl.AutoSize = true;
            gbIndexes.Text = _rm.GetString(gbIndexes.Name);
            tlpIndexControl.Width = 100;
            //tlpIndexControl.BackColor = Color.Yellow;

            tlpIndexControl.Dock = DockStyle.Fill;
            //tlpIndexControl.Height = tlpIndexControl.Size.Height;


            //tlpIndexControl.VerticalScroll.Visible = false;
            //tlpIndexControl.Size
        }
    }
}
