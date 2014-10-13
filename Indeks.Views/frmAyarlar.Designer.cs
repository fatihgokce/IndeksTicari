namespace Indeks.Views {
    partial class frmAyarlar {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAyarlar));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnKaydet = new System.Windows.Forms.ToolStripButton();
            this.tsbtnKapat = new System.Windows.Forms.ToolStripButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGenel = new System.Windows.Forms.TabPage();
            this.tabPageFatura = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenDialog = new System.Windows.Forms.Button();
            this.txtYedek = new System.Windows.Forms.TextBox();
            this.cmbFatTipi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkOtomatikCariKaydet = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageGenel.SuspendLayout();
            this.tabPageFatura.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnKaydet,
            this.tsbtnKapat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 326);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(652, 39);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnKaydet
            // 
            this.tsbtnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnKaydet.Image")));
            this.tsbtnKaydet.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnKaydet.Name = "tsbtnKaydet";
            this.tsbtnKaydet.Size = new System.Drawing.Size(99, 36);
            this.tsbtnKaydet.Text = "Kaydet(F5)";
            this.tsbtnKaydet.Click += new System.EventHandler(this.tsbtnKaydet_Click);
            // 
            // tsbtnKapat
            // 
            this.tsbtnKapat.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnKapat.Image")));
            this.tsbtnKapat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnKapat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnKapat.Name = "tsbtnKapat";
            this.tsbtnKapat.Size = new System.Drawing.Size(101, 36);
            this.tsbtnKapat.Text = "Kapat(ESC)";
            this.tsbtnKapat.Click += new System.EventHandler(this.tsbtnKapat_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageGenel);
            this.tabControl1.Controls.Add(this.tabPageFatura);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(652, 326);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageGenel
            // 
            this.tabPageGenel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPageGenel.Controls.Add(this.label1);
            this.tabPageGenel.Controls.Add(this.btnOpenDialog);
            this.tabPageGenel.Controls.Add(this.txtYedek);
            this.tabPageGenel.Location = new System.Drawing.Point(4, 22);
            this.tabPageGenel.Name = "tabPageGenel";
            this.tabPageGenel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGenel.Size = new System.Drawing.Size(644, 300);
            this.tabPageGenel.TabIndex = 0;
            this.tabPageGenel.Text = "Genel";
            // 
            // tabPageFatura
            // 
            this.tabPageFatura.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPageFatura.Controls.Add(this.cmbFatTipi);
            this.tabPageFatura.Controls.Add(this.label4);
            this.tabPageFatura.Controls.Add(this.chkOtomatikCariKaydet);
            this.tabPageFatura.Location = new System.Drawing.Point(4, 22);
            this.tabPageFatura.Name = "tabPageFatura";
            this.tabPageFatura.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFatura.Size = new System.Drawing.Size(644, 300);
            this.tabPageFatura.TabIndex = 1;
            this.tabPageFatura.Text = "Fatura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Veri Tabanı Yedekleme Yeri";
            // 
            // btnOpenDialog
            // 
            this.btnOpenDialog.Location = new System.Drawing.Point(196, 28);
            this.btnOpenDialog.Name = "btnOpenDialog";
            this.btnOpenDialog.Size = new System.Drawing.Size(27, 20);
            this.btnOpenDialog.TabIndex = 23;
            this.btnOpenDialog.Text = "...";
            this.btnOpenDialog.UseVisualStyleBackColor = true;
            this.btnOpenDialog.Click += new System.EventHandler(this.btnOpenDialog_Click);
            // 
            // txtYedek
            // 
            this.txtYedek.Location = new System.Drawing.Point(9, 28);
            this.txtYedek.Name = "txtYedek";
            this.txtYedek.Size = new System.Drawing.Size(181, 20);
            this.txtYedek.TabIndex = 22;
            // 
            // cmbFatTipi
            // 
            this.cmbFatTipi.FormattingEnabled = true;
            this.cmbFatTipi.Items.AddRange(new object[] {
            "Vadeli",
            "Peşin",
            "Iade"});
            this.cmbFatTipi.Location = new System.Drawing.Point(20, 51);
            this.cmbFatTipi.Name = "cmbFatTipi";
            this.cmbFatTipi.Size = new System.Drawing.Size(152, 21);
            this.cmbFatTipi.TabIndex = 28;
            this.cmbFatTipi.Text = "Vadeli";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Varsayılan FaturaTipi";
            // 
            // chkOtomatikCariKaydet
            // 
            this.chkOtomatikCariKaydet.AutoSize = true;
            this.chkOtomatikCariKaydet.Location = new System.Drawing.Point(20, 15);
            this.chkOtomatikCariKaydet.Name = "chkOtomatikCariKaydet";
            this.chkOtomatikCariKaydet.Size = new System.Drawing.Size(229, 17);
            this.chkOtomatikCariKaydet.TabIndex = 27;
            this.chkOtomatikCariKaydet.Text = "Fatura ve Sipariş de Cari yi otomatik kaydet";
            this.chkOtomatikCariKaydet.UseVisualStyleBackColor = true;
            // 
            // frmAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(652, 365);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.Name = "frmAyarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAyarlar_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageGenel.ResumeLayout(false);
            this.tabPageGenel.PerformLayout();
            this.tabPageFatura.ResumeLayout(false);
            this.tabPageFatura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnKaydet;
        private System.Windows.Forms.ToolStripButton tsbtnKapat;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageGenel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenDialog;
        private System.Windows.Forms.TextBox txtYedek;
        private System.Windows.Forms.TabPage tabPageFatura;
        private System.Windows.Forms.ComboBox cmbFatTipi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkOtomatikCariKaydet;
    }
}