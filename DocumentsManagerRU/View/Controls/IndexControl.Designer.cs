namespace DocumentsManagerRU.Controls
{
    partial class IndexControl
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
            this.tlpIndexControl = new System.Windows.Forms.TableLayoutPanel();
            this.gbIndexes = new System.Windows.Forms.GroupBox();
            this.gbIndexes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpIndexControl
            // 
            this.tlpIndexControl.AutoScroll = true;
            this.tlpIndexControl.AutoSize = true;
            this.tlpIndexControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpIndexControl.ColumnCount = 1;
            this.tlpIndexControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpIndexControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpIndexControl.Location = new System.Drawing.Point(3, 17);
            this.tlpIndexControl.Name = "tlpIndexControl";
            this.tlpIndexControl.RowCount = 1;
            this.tlpIndexControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpIndexControl.Size = new System.Drawing.Size(1294, 633);
            this.tlpIndexControl.TabIndex = 0;
            // 
            // gbIndexes
            // 
            this.gbIndexes.Controls.Add(this.tlpIndexControl);
            this.gbIndexes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbIndexes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbIndexes.Location = new System.Drawing.Point(0, 0);
            this.gbIndexes.Name = "gbIndexes";
            this.gbIndexes.Size = new System.Drawing.Size(1300, 653);
            this.gbIndexes.TabIndex = 1;
            this.gbIndexes.TabStop = false;
            this.gbIndexes.Text = "gbIndexes";
            // 
            // IndexControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbIndexes);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "IndexControl";
            this.Size = new System.Drawing.Size(1300, 653);
            this.Load += new System.EventHandler(this.IndexControl_Load);
            this.gbIndexes.ResumeLayout(false);
            this.gbIndexes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpIndexControl;
        private System.Windows.Forms.GroupBox gbIndexes;
    }
}
