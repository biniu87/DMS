namespace DocumentsManagerRU.Controls
{
    partial class SearchControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSearch = new System.Windows.Forms.Label();
            this.tlpControls = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSearchLabel = new System.Windows.Forms.TableLayoutPanel();
            this.btnHideSearch = new System.Windows.Forms.Button();
            this.searchDateControlReleaseDate = new DocumentsManagerRU.Controls.SearchDateControl();
            this.searchValueControlClassName = new DocumentsManagerRU.Controls.SearchValueControl();
            this.tlpControls.SuspendLayout();
            this.tlpSearchLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSearch.Location = new System.Drawing.Point(35, 0);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(252, 35);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "lblSearch";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpControls
            // 
            this.tlpControls.AutoScroll = true;
            this.tlpControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpControls.ColumnCount = 1;
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControls.Controls.Add(this.tlpSearchLabel, 0, 0);
            this.tlpControls.Controls.Add(this.searchDateControlReleaseDate, 0, 2);
            this.tlpControls.Controls.Add(this.searchValueControlClassName, 0, 1);
            this.tlpControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControls.Location = new System.Drawing.Point(0, 0);
            this.tlpControls.Margin = new System.Windows.Forms.Padding(0);
            this.tlpControls.Name = "tlpControls";
            this.tlpControls.RowCount = 3;
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpControls.Size = new System.Drawing.Size(287, 172);
            this.tlpControls.TabIndex = 2;
            this.tlpControls.SizeChanged += new System.EventHandler(this.tlpControls_SizeChanged);
            // 
            // tlpSearchLabel
            // 
            this.tlpSearchLabel.ColumnCount = 2;
            this.tlpSearchLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpSearchLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchLabel.Controls.Add(this.btnHideSearch, 0, 0);
            this.tlpSearchLabel.Controls.Add(this.lblSearch, 1, 0);
            this.tlpSearchLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearchLabel.Location = new System.Drawing.Point(0, 0);
            this.tlpSearchLabel.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSearchLabel.Name = "tlpSearchLabel";
            this.tlpSearchLabel.RowCount = 1;
            this.tlpSearchLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearchLabel.Size = new System.Drawing.Size(287, 35);
            this.tlpSearchLabel.TabIndex = 4;
            // 
            // btnHideSearch
            // 
            this.btnHideSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHideSearch.Image = global::DocumentsManagerRU.Properties.Resources.chevron_bottom_2x;
            this.btnHideSearch.Location = new System.Drawing.Point(0, 0);
            this.btnHideSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnHideSearch.Name = "btnHideSearch";
            this.btnHideSearch.Size = new System.Drawing.Size(35, 35);
            this.btnHideSearch.TabIndex = 0;
            this.btnHideSearch.UseVisualStyleBackColor = true;
            this.btnHideSearch.Click += new System.EventHandler(this.btnHideSearch_Click);
            // 
            // searchDateControlReleaseDate
            // 
            this.searchDateControlReleaseDate.AutoScroll = true;
            this.searchDateControlReleaseDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchDateControlReleaseDate.ColumnName = null;
            this.searchDateControlReleaseDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchDateControlReleaseDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchDateControlReleaseDate.Location = new System.Drawing.Point(0, 85);
            this.searchDateControlReleaseDate.Margin = new System.Windows.Forms.Padding(0);
            this.searchDateControlReleaseDate.Name = "searchDateControlReleaseDate";
            this.searchDateControlReleaseDate.Size = new System.Drawing.Size(287, 87);
            this.searchDateControlReleaseDate.TabIndex = 1;
            this.searchDateControlReleaseDate.Title = "lblTitle";
            this.searchDateControlReleaseDate.Type = 0;
            // 
            // searchValueControlClassName
            // 
            this.searchValueControlClassName.AutoScroll = true;
            this.searchValueControlClassName.ColumnName = null;
            this.searchValueControlClassName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchValueControlClassName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchValueControlClassName.Location = new System.Drawing.Point(0, 35);
            this.searchValueControlClassName.Margin = new System.Windows.Forms.Padding(0);
            this.searchValueControlClassName.Name = "searchValueControlClassName";
            this.searchValueControlClassName.Size = new System.Drawing.Size(287, 50);
            this.searchValueControlClassName.TabIndex = 0;
            this.searchValueControlClassName.Title = "lblTitle";
            this.searchValueControlClassName.Type = 0;
            // 
            // SearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tlpControls);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SearchControl";
            this.Size = new System.Drawing.Size(287, 172);
            this.tlpControls.ResumeLayout(false);
            this.tlpSearchLabel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TableLayoutPanel tlpControls;
        private SearchDateControl searchDateControlReleaseDate;
        private SearchValueControl searchValueControlClassName;
        private System.Windows.Forms.Button btnHideSearch;
        private System.Windows.Forms.TableLayoutPanel tlpSearchLabel;

    }
}
