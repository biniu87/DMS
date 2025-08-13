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
using DocumentsManagerRU.View.Controls;
using NLog;

namespace DocumentsManagerRU
{
    public partial class frmPermissionManager : Form
    {
        private DataShare _ds;
        private SecurityClassControl _classControl;
        private SecurityAdditionControl _additionControl;
        private PermissionsClassControl _permissionsControl;
        public static Logger _logger = LogManager.GetCurrentClassLogger();
        public bool _canChangeClass = false;

        public frmPermissionManager(DataShare ds)
        {
            _ds = ds;
            InitializeComponent();
            InitalizeSecurityControls();
        }

        #region Methods

        public void RefreshClassList()
        {
            this.taDocumentClass.FillToReadRelease(this.iTDataSet.Document_Class, _ds.Language, Security.SecurityObjects,
                (int)Permissions.ClassPrimaryPermissions.Read, (int)Permissions.ClassSecondaryPermissions.AdminPermissions);
        }

        public void RefreshPermissionControls()
        {
            SetClassIdOnControls();
        }

        public void RefreshData()
        {
            RefreshClassList();
            RefreshPermissionControls();
        }

        public int GetSelectedClassId()
        {
            try
            {
                if (dgvClass.SelectedRows.Count == 1)
                {
                    int index = 0;
                    int.TryParse(dgvClass.SelectedRows[0].Cells[dgvColumnClassId.Index].Value.ToString(), out index);
                    return index;
                }
                else
                    return -1;
            }
            catch (Exception e)
            {
                _logger.Error(e, "Błąd pobrania Id zaznaczonej klasy, e: {0}", e);
                return -1;
            }
        }

        //public void SetPermissionsCBInGridOnStart()
        //{
        //    for (int i = 0; i < dgvPermissions.Rows.Count; i++)
        //    {
        //        var access = dgvPermissions.Rows[i].Cells[dgvColumnAccess.Index].Value;
        //        var user = dgvPermissions.Rows[i].Cells[dgvColumnUserId.Index].Value;
        //        if (access == null || user == null) return;
        //        int accessInt = -1;
        //        int userIdInt = -1;
        //        Int32.TryParse(access.ToString(), out accessInt);
        //        Int32.TryParse(user.ToString(), out userIdInt);
        //        if (accessInt == -1 || userIdInt == -1) return;
        //        int classId = GetSelectedClassId();

        //        switch (accessInt)
        //        {
        //            case (int)Data.ClassPrimaryPermissions.None:
        //                SetCheckboxesOnGrid(false, false, false, i);
        //                break;
        //            case (int)Data.ClassPrimaryPermissions.Read:
        //                SetCheckboxesOnGrid(true, false, false, i);
        //                break;
        //            case (int)Data.ClassPrimaryPermissions.Edit:
        //                SetCheckboxesOnGrid(false, true, false, i);
        //                break;
        //            case (int)Data.ClassPrimaryPermissions.Full:
        //                SetCheckboxesOnGrid(false, false, true, i);
        //                break;
        //        }
        //    }
        //}

        //public void SetCheckboxesOnGrid(bool read, bool release, bool full, int rowIndex)
        //{
        //    dgvPermissions.Rows[rowIndex].Cells[dgvChkColumnRead.Index].Value = read;
        //    dgvPermissions.Rows[rowIndex].Cells[dgvChkColumnRelease.Index].Value = release;
        //    dgvPermissions.Rows[rowIndex].Cells[dgvChkColumnFull.Index].Value = full;
        //    dgvPermissions.Rows[rowIndex].Cells[dgvChkColumnNone.Index].Value = !read && !release && !full;
        //}

        //public void UpdateAllPermissionsInGrid(int permission)
        //{
        //    var classId = GetSelectedClassId();
        //    //Data.AddClassPermission(classId, 0, permission, true); tu trzeba wprowadzić modyfikację
        //    dgvPermissions.EndEdit();
        //    for (int i = 0; i < dgvPermissions.RowCount; i++)
        //    {
        //        switch (permission)
        //        {
        //            case (int)Data.ClassPrimaryPermissions.None:
        //                SetCheckboxesOnGrid(false, false, false, i);
        //                break;
        //            case (int)Data.ClassPrimaryPermissions.Read:
        //                SetCheckboxesOnGrid(true, false, false, i);
        //                break;
        //            case (int)Data.ClassPrimaryPermissions.Edit:
        //                SetCheckboxesOnGrid(false, true, false, i);
        //                break;
        //            case (int)Data.ClassPrimaryPermissions.Full:
        //                SetCheckboxesOnGrid(false, false, true, i);
        //                break;
        //        }
        //    }



        //    //    if(permission == (int)Data.ClassPrimaryPermissions.Read &&
        //    //        !Convert.ToBoolean(dgvPermissions[dgvChkColumnRead.Index, i].Value))
        //    //    {
        //    //      UpdatePermissionsOnClick(i, dgvChkColumnRead.Index);
        //    //    }
        //    //    else if (permission == (int)Data.ClassPrimaryPermissions.Edit &&
        //    //        !Convert.ToBoolean(dgvPermissions[dgvChkColumnRelease.Index, i].Value))
        //    //    {
        //    //        UpdatePermissionsOnClick(i, dgvChkColumnRelease.Index);
        //    //    }
        //    //    else if (permission == (int)Data.ClassPrimaryPermissions.Full &&
        //    //        !Convert.ToBoolean(dgvPermissions[dgvChkColumnFull.Index, i].Value))
        //    //    {
        //    //        UpdatePermissionsOnClick(i, dgvChkColumnFull.Index);
        //    //    }
        //    //    else if (permission == (int)Data.ClassPrimaryPermissions.None &&
        //    //        !Convert.ToBoolean(dgvPermissions[dgvChkColumnNone.Index, i].Value))
        //    //    {
        //    //        UpdatePermissionsOnClick(i, dgvChkColumnNone.Index);
        //    //    }
        //    //}
        //}

        //public void UpdatePermissionsOnClick(int rowIndex, int columnIndex)
        //{
        //    if (rowIndex < 0) return;
        //    if (columnIndex == dgvChkColumnRead.Index || columnIndex == dgvChkColumnRelease.Index || columnIndex == dgvChkColumnFull.Index || columnIndex == dgvChkColumnNone.Index)
        //    {
        //        //akcja zmiany dostępu przez użytkownika
        //        var newPermissionValue = 0;
        //        if (columnIndex == dgvChkColumnNone.Index)
        //        {
        //            SetCheckboxesOnGrid(false, false, false, rowIndex);
        //            newPermissionValue = (int)Data.ClassPrimaryPermissions.None;
        //        }
        //        else if (columnIndex == dgvChkColumnRead.Index)
        //        {
        //            SetCheckboxesOnGrid(true, false, false, rowIndex);
        //            newPermissionValue = (int)Data.ClassPrimaryPermissions.Read;
        //        }
        //        else if (columnIndex == dgvChkColumnRelease.Index)
        //        {
        //            SetCheckboxesOnGrid(false, true, false, rowIndex);
        //            newPermissionValue = (int)Data.ClassPrimaryPermissions.Edit;
        //        }
        //        else if (columnIndex == dgvChkColumnFull.Index)
        //        {
        //            SetCheckboxesOnGrid(false, false, true, rowIndex);
        //            newPermissionValue = (int)Data.ClassPrimaryPermissions.Full;
        //        }
        //        var securityId = -1;
        //        Int32.TryParse(dgvPermissions.Rows[rowIndex].Cells[dgvColumnUserId.Index].Value.ToString(), out securityId);
        //        var classId = GetSelectedClassId();
        //        //Data.AddClassPermission(classId, securityId, newPermissionValue); // tu trzeba wprowadzić modyfikacje
        //        dgvPermissions.EndEdit();
        //    }
        //}

        public string GetValueFromDictionary(string text)
        {
            return !string.IsNullOrEmpty(_ds.LocRM.GetString(text)) ? _ds.LocRM.GetString(text) : "";
        }

        #endregion

        #region Events

        private void frmPermissionsManager_Load(object sender, EventArgs e)
        {
            _canChangeClass = true;
            RefreshData();
            SelectFirstClass();
            rbPermissionClass.Checked = true;
            //rbSecurityClass.Checked = true;
        }

        private void SelectFirstClass()
        {
            if (dgvClass.Rows.Count > 0)
            {
                dgvClass.ClearSelection();

                dgvClass.Rows[0].Selected = true;
            }
            SetClassIdOnControls();
        }

        //private void lstBox_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    if (e.Index < 0 || sender == null) return;
        //    bool selected = false;
        //    //przesunięcie
        //    int ShiftTextBound = 10;

        //    if (this.iTDataSet.Document_Class.Rows.Count <= e.Index) return;
        //    //if the item state is selected them change the back color 
        //    //►●
        //    DataRowView view = (DataRowView)lstClass.Items[e.Index];
        //    ITDataSet.Document_ClassRow row = (ITDataSet.Document_ClassRow)view.Row;
        //    var displayValue = ((ITDataSet.Document_ClassRow)view.Row).CurrentName;
        //    var activeClass = ((ITDataSet.Document_ClassRow)view.Row).Active;
        //    //var displayValue = ((DocumentsManagerRU.ITDataSet.Document_ClassRow)this.iTDataSet.Document_Class.Rows[e.Index]).Name; 
        //    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
        //    {
        //        e = new DrawItemEventArgs(e.Graphics,
        //            activeClass ? e.Font : new System.Drawing.Font(e.Font.FontFamily, e.Font.SizeInPoints, System.Drawing.FontStyle.Strikeout, e.Font.Unit, e.Font.GdiCharSet),
        //            //e.Font,
        //                                  e.Bounds,
        //                                  e.Index,
        //                                  e.State ^ DrawItemState.Selected,
        //                                  Data.COLOR_FORE_1,//e.ForeColor,
        //                                  Data.COLOR_SELECTED); //zaznaczony
        //        selected = true;
        //    }
        //    else
        //    {
        //        e = new DrawItemEventArgs(e.Graphics,
        //            activeClass ? e.Font : new System.Drawing.Font(e.Font.FontFamily, e.Font.SizeInPoints, System.Drawing.FontStyle.Strikeout, e.Font.Unit, e.Font.GdiCharSet),
        //            //e.Font,
        //                                  e.Bounds,
        //                                  e.Index,
        //                                  e.State,
        //                                  Data.COLOR_FORE_1,// e.ForeColor,
        //                                  Data.COLOR_OBJECTS); //niezaznaczony
        //    }
        //    // Draw the background of the ListBox control for each item.
        //    e.DrawBackground();

        //    // If the ListBox has focus, draw a focus rectangle around the selected item.
        //    //e.DrawFocusRectangle();
        //    if (selected)
        //    {
        //        // Draw the current item text
        //        Rectangle textBound = new Rectangle(e.Bounds.X + (ShiftTextBound * 2), e.Bounds.Y, e.Bounds.Width - (ShiftTextBound * 2), e.Bounds.Height);
        //        e.Graphics.DrawString(displayValue, e.Font, new SolidBrush(Data.COLOR_FORE_1), /* Brushes.Black,*/ textBound, StringFormat.GenericTypographic);
        //        //specjalna beleczka dla zaznaczonego
        //        Rectangle rectangleBeam = new Rectangle(e.Bounds.X, e.Bounds.Y, ShiftTextBound, e.Bounds.Height);
        //        //rectangleBeam = new Rectangle(e.Bounds.X, e.Bounds.Y, 10, lstClass.ItemHeight);
        //        // Draw rectangle to screen.
        //        e.Graphics.FillRectangle(new SolidBrush(Data.COLOR_FORE_1), /* Brushes.Black,*/ rectangleBeam);
        //    }
        //    else
        //    {
        //        // Draw the current item text
        //        Rectangle textBound = new Rectangle(e.Bounds.X + ShiftTextBound, e.Bounds.Y, e.Bounds.Width - ShiftTextBound, e.Bounds.Height);
        //        e.Graphics.DrawString(displayValue, e.Font, new SolidBrush(Data.COLOR_FORE_1), /* Brushes.Black,*/ textBound /*e.Bounds*/, StringFormat.GenericTypographic);
        //    }
        //}

        private void lstClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetClassIdOnControls();
        }

        #endregion

        public void InitalizeSecurityControls()
        {
            if (_classControl == null)
            {
                _classControl = new SecurityClassControl(_ds);
            }
            if (_additionControl == null)
            {
                _additionControl = new SecurityAdditionControl(_ds);
            }
            if (_permissionsControl == null)
            {
                _permissionsControl = new PermissionsClassControl(_ds);
            }
            LanguageController.SetLanguage(_classControl, _ds.LocRM);
            LanguageController.SetLanguage(_additionControl, _ds.LocRM);
            LanguageController.SetLanguage(_permissionsControl, _ds.LocRM);
            _ds.SetColors(_classControl);
            _ds.SetColors(_additionControl);
            _ds.SetColors(_permissionsControl);
            _classControl.Dock = DockStyle.Fill;
            _additionControl.Dock = DockStyle.Fill;
            _permissionsControl.Dock = DockStyle.Fill;
        }

        public void SetClassIdOnControls()
        {
            if (_canChangeClass)
            {
                var newClassId = GetSelectedClassId();
                _classControl.SetNewClass(newClassId);
                _additionControl.SetNewClass(newClassId);
                _permissionsControl.SetNewClass(newClassId);
            }
        }

        public void SetActiveControl()
        {
            if (_classControl != null && _additionControl != null && _permissionsControl != null)
            {
                //zarządzanie aktywnością komponentów
                if (rbSecurityClass.Checked)
                {
                    if(this.pnlSecurityControl.Controls.Contains(_additionControl))
                    {
                        this.pnlSecurityControl.Controls.Remove(_additionControl);
                    }
                    if(this.pnlSecurityControl.Controls.Contains(_permissionsControl))
                    {
                        this.pnlSecurityControl.Controls.Remove(_permissionsControl);
                    }
                    if (!this.pnlSecurityControl.Controls.Contains(_classControl)) //jeżeli nie zawiera- dodaj
                    {
                        this.pnlSecurityControl.Controls.Add(_classControl);
                    }
                }
                if (rbSecurityAdds.Checked)
                {
                    if (this.pnlSecurityControl.Controls.Contains(_classControl))
                    {
                        this.pnlSecurityControl.Controls.Remove(_classControl);
                    } 
                    if (this.pnlSecurityControl.Controls.Contains(_permissionsControl))
                    {
                        this.pnlSecurityControl.Controls.Remove(_permissionsControl);
                    }
                    if (!this.pnlSecurityControl.Controls.Contains(_additionControl))//jeżeli nie zawiera- dodaj
                    {
                        this.pnlSecurityControl.Controls.Add(_additionControl);
                    }
                }
                if (rbPermissionClass.Checked)
                {
                    if (this.pnlSecurityControl.Controls.Contains(_classControl))
                    {
                        this.pnlSecurityControl.Controls.Remove(_classControl);
                    }
                    if (this.pnlSecurityControl.Controls.Contains(_additionControl))
                    {
                        this.pnlSecurityControl.Controls.Remove(_additionControl);
                    }
                    if (!this.pnlSecurityControl.Controls.Contains(_permissionsControl))//jeżeli nie zawiera- dodaj
                    {
                        this.pnlSecurityControl.Controls.Add(_permissionsControl);
                    }
                }
            }
        }

        private void rbSecuritySettings_CheckedChanged(object sender, EventArgs e)
        {
            if (_canChangeClass)
            {
                SetActiveControl();
            }
        }

    }
}
