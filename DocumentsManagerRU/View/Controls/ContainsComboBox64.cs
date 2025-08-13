using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace DocumentsManagerRU.Controls
{
    public class ContainsComboBox64 : ComboBox
    {
        #region These properties can't be used because it can cause bugs

        [Bindable(false)]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Does nothing. This property can't be changed.", true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private new string ValueMember { get; set; }

        [Bindable(false)]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Does nothing. This property can't be changed.", true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private new string DisplayMember { get; set; }

        [Bindable(false)]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Does nothing. This property can't be changed.", true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private new ComboBoxStyle DropDownStyle { get; set; }

        [Bindable(false)]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Does nothing. This property can't be changed.", true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private new bool FormattingEnabled { get; set; }

        [Bindable(false)]
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Does nothing. This property can't be changed.", true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private new ObjectCollection Items { get; set; }

        #endregion

        private bool _canFilter = true;
        private bool _userCommitedSelection;

        // We need our own DataSource because at design time sometimes OriginalDataSource can throw exception(null) somewhere in code
        private IDictionary<Int64, string> _originalDataSource;
        private IDictionary<Int64, string> _dataSource = new Dictionary<Int64, string>();

        private readonly Keys[] _navigationKeys = { Keys.Down, Keys.Up, Keys.Left, Keys.Right };

        public ContainsComboBox64()
        {
            base.ValueMember = "Key";
            base.DisplayMember = "Value";
            base.FormattingEnabled = true;
            base.DropDownStyle = ComboBoxStyle.DropDown;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Int64 SelectedValue
        {
            get
            {
                if(DesignMode)
                {
                    return int.MinValue;
                }

                return ((KeyValuePair<Int64, string>)SelectedItem).Key;
            }
            set
            {
                if(DesignMode)
                {
                    return;
                }

                KeyValuePair<Int64, string> item = _dataSource.SingleOrDefault(pair => pair.Key == value);

                SelectedItem = item;
            }
        }

        public override int SelectedIndex
        {
            get
            {
                return base.Items.Count > 0 ? base.SelectedIndex : -1;
            }
            set
            {
                if (base.Items.Count > 0)
                {
                    base.SelectedIndex = value;
                }

                if (value < 0)
                {
                    Text = string.Empty;
                }
            }
        }

        public new IDictionary<Int64, string> DataSource
        {
            get
            {
                return _originalDataSource;
            }
            set
            {
                Text = string.Empty;

                IDictionary<Int64, string> items = value ?? new Dictionary<Int64, string>();

                _dataSource = items.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);

                _originalDataSource = value;

                UpdateItems();
            }
        }

        protected override void OnTextUpdate(EventArgs e)
        {
            base.OnTextChanged(e);

            if (_canFilter)
            {
                FilterRows();
            }

            _canFilter = true;
        }

        protected override void OnSelectionChangeCommitted(EventArgs e)
        {
            _canFilter = true;
            _userCommitedSelection = true;

            base.OnSelectionChangeCommitted(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            Cursor.Current = Cursors.Default;
        }

        protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
        {
            _canFilter = !_navigationKeys.Any(key => e.KeyData.HasFlag(key));

            _userCommitedSelection = false;

            base.OnPreviewKeyDown(e);

            if (e.KeyData.HasFlag(Keys.Delete))
            {
                OnTextUpdate(EventArgs.Empty);
            }
        }

        private void UpdateItems()
        {
            base.Items.Clear();

            if (_dataSource != null)
            {
                base.Items.AddRange(_dataSource.Where(ContainsIgnoreCase).Cast<object>().ToArray());
            }
        }

        private bool ContainsIgnoreCase(KeyValuePair<Int64, string> pair)
        {
            return pair.Value.IndexOf(Text, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        private void FilterRows()
        {
            if (DataSource == null)
            {
                return;
            }

            // Order of the following lines is important!

            string text = Text;
            int selectionStart = SelectionStart;

            UpdateItems();

            Text = text;

            SelectionLength = 0;
            SelectionStart = selectionStart;

            if (!_userCommitedSelection)
            {
                DroppedDown = true;
            }

            _userCommitedSelection = false;

            SelectionStart = selectionStart;

            Cursor.Current = Cursors.Default;
        }
    }
}