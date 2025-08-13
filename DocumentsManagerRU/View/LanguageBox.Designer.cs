namespace DocumentsManagerRU.View
{
    partial class LanguageBox
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanguageBox));
            this.tlpLanguage = new System.Windows.Forms.TableLayoutPanel();
            this.btnLang1 = new System.Windows.Forms.Button();
            this.btnLang2 = new System.Windows.Forms.Button();
            this.btnLang3 = new System.Windows.Forms.Button();
            this.tlpLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpLanguage
            // 
            this.tlpLanguage.ColumnCount = 1;
            this.tlpLanguage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLanguage.Controls.Add(this.btnLang1, 0, 0);
            this.tlpLanguage.Controls.Add(this.btnLang2, 0, 1);
            this.tlpLanguage.Controls.Add(this.btnLang3, 0, 2);
            this.tlpLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLanguage.Location = new System.Drawing.Point(0, 0);
            this.tlpLanguage.Margin = new System.Windows.Forms.Padding(0);
            this.tlpLanguage.Name = "tlpLanguage";
            this.tlpLanguage.RowCount = 3;
            this.tlpLanguage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tlpLanguage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpLanguage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpLanguage.Size = new System.Drawing.Size(145, 86);
            this.tlpLanguage.TabIndex = 13;
            // 
            // btnLang1
            // 
            this.btnLang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLang1.FlatAppearance.BorderSize = 0;
            this.btnLang1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLang1.Image = ((System.Drawing.Image)(resources.GetObject("btnLang1.Image")));
            this.btnLang1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLang1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLang1.Location = new System.Drawing.Point(0, 0);
            this.btnLang1.Margin = new System.Windows.Forms.Padding(0);
            this.btnLang1.Name = "btnLang1";
            this.btnLang1.Size = new System.Drawing.Size(145, 28);
            this.btnLang1.TabIndex = 9;
            this.btnLang1.Text = "btnLang1";
            this.btnLang1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLang1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLang1.UseVisualStyleBackColor = true;
            this.btnLang1.Click += new System.EventHandler(this.chooseLanguage_Click);
            // 
            // btnLang2
            // 
            this.btnLang2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLang2.FlatAppearance.BorderSize = 0;
            this.btnLang2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLang2.Image = ((System.Drawing.Image)(resources.GetObject("btnLang2.Image")));
            this.btnLang2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLang2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLang2.Location = new System.Drawing.Point(0, 28);
            this.btnLang2.Margin = new System.Windows.Forms.Padding(0);
            this.btnLang2.Name = "btnLang2";
            this.btnLang2.Size = new System.Drawing.Size(145, 28);
            this.btnLang2.TabIndex = 11;
            this.btnLang2.Text = "btnLang2";
            this.btnLang2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLang2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLang2.UseVisualStyleBackColor = true;
            this.btnLang2.Click += new System.EventHandler(this.chooseLanguage_Click);
            // 
            // btnLang3
            // 
            this.btnLang3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLang3.FlatAppearance.BorderSize = 0;
            this.btnLang3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLang3.Image = ((System.Drawing.Image)(resources.GetObject("btnLang3.Image")));
            this.btnLang3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLang3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLang3.Location = new System.Drawing.Point(0, 56);
            this.btnLang3.Margin = new System.Windows.Forms.Padding(0);
            this.btnLang3.Name = "btnLang3";
            this.btnLang3.Size = new System.Drawing.Size(145, 30);
            this.btnLang3.TabIndex = 10;
            this.btnLang3.Text = "btnLang3";
            this.btnLang3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLang3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLang3.UseVisualStyleBackColor = true;
            this.btnLang3.Click += new System.EventHandler(this.chooseLanguage_Click);
            // 
            // LanguageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(145, 86);
            this.Controls.Add(this.tlpLanguage);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LanguageBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LanguageBox";
            this.Deactivate += new System.EventHandler(this.LanguageBox_Deactivate);
            this.tlpLanguage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpLanguage;
        private System.Windows.Forms.Button btnLang1;
        private System.Windows.Forms.Button btnLang2;
        private System.Windows.Forms.Button btnLang3;
    }
}