namespace Indeks.Views {
    partial class frmCekDurum {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCekDurum));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnKaydet = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labSuanDurum = new System.Windows.Forms.Label();
            this.grbAlinanCek = new System.Windows.Forms.GroupBox();
            this.rbKarsiliksiz = new System.Windows.Forms.RadioButton();
            this.rbBankaTeminatVerildi = new System.Windows.Forms.RadioButton();
            this.rbIadeEdildi = new System.Windows.Forms.RadioButton();
            this.rbTahsilBankaHesaba = new System.Windows.Forms.RadioButton();
            this.rbBankayaTahsileVerildi = new System.Windows.Forms.RadioButton();
            this.rbCiroEdildi = new System.Windows.Forms.RadioButton();
            this.rbTahsilEdildi = new System.Windows.Forms.RadioButton();
            this.rbBeklemede = new System.Windows.Forms.RadioButton();
            this.grbVerilenCek = new System.Windows.Forms.GroupBox();
            this.rbGeriAlindi = new System.Windows.Forms.RadioButton();
            this.rbOdendi = new System.Windows.Forms.RadioButton();
            this.rbBeklemedeVerilen = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labCariIsim = new System.Windows.Forms.Label();
            this.labCariKod = new System.Windows.Forms.Label();
            this.grbBanka = new System.Windows.Forms.GroupBox();
            this.btnBankaRehber = new System.Windows.Forms.Button();
            this.txtBankaHesap = new IndeksControl.AutoCompleteTextBox();
            this.grbCari = new System.Windows.Forms.GroupBox();
            this.btnCariRehber = new System.Windows.Forms.Button();
            this.txtCari = new IndeksControl.AutoCompleteTextBox();
            this.grbKasa = new System.Windows.Forms.GroupBox();
            this.cmbKasa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateIslem = new System.Windows.Forms.DateTimePicker();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbAlinanCek.SuspendLayout();
            this.grbVerilenCek.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grbBanka.SuspendLayout();
            this.grbCari.SuspendLayout();
            this.grbKasa.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnKaydet});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(552, 39);
            this.toolStrip1.TabIndex = 2;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labSuanDurum);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 68);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şuanki Durum";
            // 
            // labSuanDurum
            // 
            this.labSuanDurum.AutoSize = true;
            this.labSuanDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labSuanDurum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labSuanDurum.Location = new System.Drawing.Point(6, 29);
            this.labSuanDurum.Name = "labSuanDurum";
            this.labSuanDurum.Size = new System.Drawing.Size(0, 20);
            this.labSuanDurum.TabIndex = 0;
            // 
            // grbAlinanCek
            // 
            this.grbAlinanCek.Controls.Add(this.rbKarsiliksiz);
            this.grbAlinanCek.Controls.Add(this.rbBankaTeminatVerildi);
            this.grbAlinanCek.Controls.Add(this.rbIadeEdildi);
            this.grbAlinanCek.Controls.Add(this.rbTahsilBankaHesaba);
            this.grbAlinanCek.Controls.Add(this.rbBankayaTahsileVerildi);
            this.grbAlinanCek.Controls.Add(this.rbCiroEdildi);
            this.grbAlinanCek.Controls.Add(this.rbTahsilEdildi);
            this.grbAlinanCek.Controls.Add(this.rbBeklemede);
            this.grbAlinanCek.Location = new System.Drawing.Point(348, 44);
            this.grbAlinanCek.Name = "grbAlinanCek";
            this.grbAlinanCek.Size = new System.Drawing.Size(200, 199);
            this.grbAlinanCek.TabIndex = 4;
            this.grbAlinanCek.TabStop = false;
            this.grbAlinanCek.Text = "YeniDurum";
            // 
            // rbKarsiliksiz
            // 
            this.rbKarsiliksiz.AutoSize = true;
            this.rbKarsiliksiz.Location = new System.Drawing.Point(6, 176);
            this.rbKarsiliksiz.Name = "rbKarsiliksiz";
            this.rbKarsiliksiz.Size = new System.Drawing.Size(70, 17);
            this.rbKarsiliksiz.TabIndex = 7;
            this.rbKarsiliksiz.TabStop = true;
            this.rbKarsiliksiz.Text = "Karşılıksız";
            this.rbKarsiliksiz.UseVisualStyleBackColor = true;
            this.rbKarsiliksiz.Click += new System.EventHandler(this.rbBeklemede_Click);
            // 
            // rbBankaTeminatVerildi
            // 
            this.rbBankaTeminatVerildi.AutoSize = true;
            this.rbBankaTeminatVerildi.Location = new System.Drawing.Point(6, 157);
            this.rbBankaTeminatVerildi.Name = "rbBankaTeminatVerildi";
            this.rbBankaTeminatVerildi.Size = new System.Drawing.Size(133, 17);
            this.rbBankaTeminatVerildi.TabIndex = 6;
            this.rbBankaTeminatVerildi.TabStop = true;
            this.rbBankaTeminatVerildi.Text = "BankayaTeminatVerildi";
            this.rbBankaTeminatVerildi.UseVisualStyleBackColor = true;
            this.rbBankaTeminatVerildi.Click += new System.EventHandler(this.rbBeklemede_Click);
            // 
            // rbIadeEdildi
            // 
            this.rbIadeEdildi.AutoSize = true;
            this.rbIadeEdildi.Location = new System.Drawing.Point(6, 134);
            this.rbIadeEdildi.Name = "rbIadeEdildi";
            this.rbIadeEdildi.Size = new System.Drawing.Size(71, 17);
            this.rbIadeEdildi.TabIndex = 5;
            this.rbIadeEdildi.TabStop = true;
            this.rbIadeEdildi.Text = "IadeEdildi";
            this.rbIadeEdildi.UseVisualStyleBackColor = true;
            this.rbIadeEdildi.Click += new System.EventHandler(this.rbBeklemede_Click);
            // 
            // rbTahsilBankaHesaba
            // 
            this.rbTahsilBankaHesaba.AutoSize = true;
            this.rbTahsilBankaHesaba.Location = new System.Drawing.Point(6, 111);
            this.rbTahsilBankaHesaba.Name = "rbTahsilBankaHesaba";
            this.rbTahsilBankaHesaba.Size = new System.Drawing.Size(121, 17);
            this.rbTahsilBankaHesaba.TabIndex = 4;
            this.rbTahsilBankaHesaba.TabStop = true;
            this.rbTahsilBankaHesaba.Text = "TahsilBankaHesaba";
            this.rbTahsilBankaHesaba.UseVisualStyleBackColor = true;
            this.rbTahsilBankaHesaba.Click += new System.EventHandler(this.rbBeklemede_Click);
            // 
            // rbBankayaTahsileVerildi
            // 
            this.rbBankayaTahsileVerildi.AutoSize = true;
            this.rbBankayaTahsileVerildi.Location = new System.Drawing.Point(6, 88);
            this.rbBankayaTahsileVerildi.Name = "rbBankayaTahsileVerildi";
            this.rbBankayaTahsileVerildi.Size = new System.Drawing.Size(129, 17);
            this.rbBankayaTahsileVerildi.TabIndex = 3;
            this.rbBankayaTahsileVerildi.TabStop = true;
            this.rbBankayaTahsileVerildi.Text = "BankayaTahsileVerildi";
            this.rbBankayaTahsileVerildi.UseVisualStyleBackColor = true;
            this.rbBankayaTahsileVerildi.Click += new System.EventHandler(this.rbBeklemede_Click);
            // 
            // rbCiroEdildi
            // 
            this.rbCiroEdildi.AutoSize = true;
            this.rbCiroEdildi.Location = new System.Drawing.Point(6, 65);
            this.rbCiroEdildi.Name = "rbCiroEdildi";
            this.rbCiroEdildi.Size = new System.Drawing.Size(68, 17);
            this.rbCiroEdildi.TabIndex = 2;
            this.rbCiroEdildi.TabStop = true;
            this.rbCiroEdildi.Text = "CiroEdildi";
            this.rbCiroEdildi.UseVisualStyleBackColor = true;
            this.rbCiroEdildi.Click += new System.EventHandler(this.rbBeklemede_Click);
            // 
            // rbTahsilEdildi
            // 
            this.rbTahsilEdildi.AutoSize = true;
            this.rbTahsilEdildi.Location = new System.Drawing.Point(6, 42);
            this.rbTahsilEdildi.Name = "rbTahsilEdildi";
            this.rbTahsilEdildi.Size = new System.Drawing.Size(78, 17);
            this.rbTahsilEdildi.TabIndex = 1;
            this.rbTahsilEdildi.TabStop = true;
            this.rbTahsilEdildi.Text = "TahsilEdildi";
            this.rbTahsilEdildi.UseVisualStyleBackColor = true;
            this.rbTahsilEdildi.Click += new System.EventHandler(this.rbBeklemede_Click);
            // 
            // rbBeklemede
            // 
            this.rbBeklemede.AutoSize = true;
            this.rbBeklemede.Location = new System.Drawing.Point(6, 19);
            this.rbBeklemede.Name = "rbBeklemede";
            this.rbBeklemede.Size = new System.Drawing.Size(78, 17);
            this.rbBeklemede.TabIndex = 0;
            this.rbBeklemede.TabStop = true;
            this.rbBeklemede.Text = "Beklemede";
            this.rbBeklemede.UseVisualStyleBackColor = true;
            this.rbBeklemede.Click += new System.EventHandler(this.rbBeklemede_Click);
            // 
            // grbVerilenCek
            // 
            this.grbVerilenCek.Controls.Add(this.rbGeriAlindi);
            this.grbVerilenCek.Controls.Add(this.rbOdendi);
            this.grbVerilenCek.Controls.Add(this.rbBeklemedeVerilen);
            this.grbVerilenCek.Location = new System.Drawing.Point(348, 249);
            this.grbVerilenCek.Name = "grbVerilenCek";
            this.grbVerilenCek.Size = new System.Drawing.Size(200, 151);
            this.grbVerilenCek.TabIndex = 6;
            this.grbVerilenCek.TabStop = false;
            this.grbVerilenCek.Text = "YeniDurum";
            this.grbVerilenCek.Visible = false;
            // 
            // rbGeriAlindi
            // 
            this.rbGeriAlindi.AutoSize = true;
            this.rbGeriAlindi.Location = new System.Drawing.Point(6, 65);
            this.rbGeriAlindi.Name = "rbGeriAlindi";
            this.rbGeriAlindi.Size = new System.Drawing.Size(69, 17);
            this.rbGeriAlindi.TabIndex = 3;
            this.rbGeriAlindi.TabStop = true;
            this.rbGeriAlindi.Text = "GeriAlındı";
            this.rbGeriAlindi.UseVisualStyleBackColor = true;
            // 
            // rbOdendi
            // 
            this.rbOdendi.AutoSize = true;
            this.rbOdendi.Location = new System.Drawing.Point(6, 42);
            this.rbOdendi.Name = "rbOdendi";
            this.rbOdendi.Size = new System.Drawing.Size(59, 17);
            this.rbOdendi.TabIndex = 2;
            this.rbOdendi.TabStop = true;
            this.rbOdendi.Text = "Ödendi";
            this.rbOdendi.UseVisualStyleBackColor = true;
            // 
            // rbBeklemedeVerilen
            // 
            this.rbBeklemedeVerilen.AutoSize = true;
            this.rbBeklemedeVerilen.Location = new System.Drawing.Point(6, 19);
            this.rbBeklemedeVerilen.Name = "rbBeklemedeVerilen";
            this.rbBeklemedeVerilen.Size = new System.Drawing.Size(78, 17);
            this.rbBeklemedeVerilen.TabIndex = 1;
            this.rbBeklemedeVerilen.TabStop = true;
            this.rbBeklemedeVerilen.Text = "Beklemede";
            this.rbBeklemedeVerilen.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labCariIsim);
            this.groupBox3.Controls.Add(this.labCariKod);
            this.groupBox3.Location = new System.Drawing.Point(12, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 77);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CariHesapBilgileri";
            // 
            // labCariIsim
            // 
            this.labCariIsim.AutoSize = true;
            this.labCariIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labCariIsim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labCariIsim.Location = new System.Drawing.Point(6, 47);
            this.labCariIsim.Name = "labCariIsim";
            this.labCariIsim.Size = new System.Drawing.Size(0, 20);
            this.labCariIsim.TabIndex = 2;
            // 
            // labCariKod
            // 
            this.labCariKod.AutoSize = true;
            this.labCariKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labCariKod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labCariKod.Location = new System.Drawing.Point(6, 16);
            this.labCariKod.Name = "labCariKod";
            this.labCariKod.Size = new System.Drawing.Size(0, 20);
            this.labCariKod.TabIndex = 1;
            // 
            // grbBanka
            // 
            this.grbBanka.Controls.Add(this.btnBankaRehber);
            this.grbBanka.Controls.Add(this.txtBankaHesap);
            this.grbBanka.Location = new System.Drawing.Point(12, 201);
            this.grbBanka.Name = "grbBanka";
            this.grbBanka.Size = new System.Drawing.Size(281, 56);
            this.grbBanka.TabIndex = 7;
            this.grbBanka.TabStop = false;
            this.grbBanka.Text = "Banka Hesap";
            // 
            // btnBankaRehber
            // 
            this.btnBankaRehber.Location = new System.Drawing.Point(177, 19);
            this.btnBankaRehber.Name = "btnBankaRehber";
            this.btnBankaRehber.Size = new System.Drawing.Size(32, 23);
            this.btnBankaRehber.TabIndex = 1;
            this.btnBankaRehber.Text = "...";
            this.btnBankaRehber.UseVisualStyleBackColor = true;
            this.btnBankaRehber.Click += new System.EventHandler(this.btnBankaRehber_Click);
            // 
            // txtBankaHesap
            // 
            this.txtBankaHesap.Ayirac = null;
            this.txtBankaHesap.AyracBoslukKullan = false;
            this.txtBankaHesap.DataSource = null;
            this.txtBankaHesap.ListForeColor = System.Drawing.Color.Empty;
            this.txtBankaHesap.ListItemColor = System.Drawing.Color.DarkOrange;
            this.txtBankaHesap.Location = new System.Drawing.Point(10, 19);
            this.txtBankaHesap.Name = "txtBankaHesap";
            this.txtBankaHesap.NextTabControlName = null;
            this.txtBankaHesap.Size = new System.Drawing.Size(160, 20);
            this.txtBankaHesap.TabIndex = 0;
            this.txtBankaHesap.WidthAutoComplete = 160;
            this.txtBankaHesap.WidthKod = 0;
            // 
            // grbCari
            // 
            this.grbCari.Controls.Add(this.btnCariRehber);
            this.grbCari.Controls.Add(this.txtCari);
            this.grbCari.Location = new System.Drawing.Point(554, 93);
            this.grbCari.Name = "grbCari";
            this.grbCari.Size = new System.Drawing.Size(63, 56);
            this.grbCari.TabIndex = 8;
            this.grbCari.TabStop = false;
            this.grbCari.Text = "Cari";
            this.grbCari.Visible = false;
            // 
            // btnCariRehber
            // 
            this.btnCariRehber.Location = new System.Drawing.Point(177, 19);
            this.btnCariRehber.Name = "btnCariRehber";
            this.btnCariRehber.Size = new System.Drawing.Size(32, 23);
            this.btnCariRehber.TabIndex = 1;
            this.btnCariRehber.Text = "...";
            this.btnCariRehber.UseVisualStyleBackColor = true;
            this.btnCariRehber.Click += new System.EventHandler(this.btnCariRehber_Click);
            // 
            // txtCari
            // 
            this.txtCari.Ayirac = "";
            this.txtCari.AyracBoslukKullan = true;
            this.txtCari.DataSource = null;
            this.txtCari.ListForeColor = System.Drawing.Color.White;
            this.txtCari.ListItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtCari.Location = new System.Drawing.Point(10, 19);
            this.txtCari.Name = "txtCari";
            this.txtCari.NextTabControlName = null;
            this.txtCari.Size = new System.Drawing.Size(160, 20);
            this.txtCari.TabIndex = 0;
            this.txtCari.WidthAutoComplete = 200;
            this.txtCari.WidthKod = 15;
            // 
            // grbKasa
            // 
            this.grbKasa.Controls.Add(this.cmbKasa);
            this.grbKasa.Location = new System.Drawing.Point(554, 155);
            this.grbKasa.Name = "grbKasa";
            this.grbKasa.Size = new System.Drawing.Size(63, 56);
            this.grbKasa.TabIndex = 9;
            this.grbKasa.TabStop = false;
            this.grbKasa.Text = "Kasa";
            this.grbKasa.Visible = false;
            // 
            // cmbKasa
            // 
            this.cmbKasa.FormattingEnabled = true;
            this.cmbKasa.Location = new System.Drawing.Point(10, 19);
            this.cmbKasa.Name = "cmbKasa";
            this.cmbKasa.Size = new System.Drawing.Size(160, 21);
            this.cmbKasa.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "İşlemTarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Açıklama";
            // 
            // dateIslem
            // 
            this.dateIslem.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateIslem.Location = new System.Drawing.Point(75, 264);
            this.dateIslem.Name = "dateIslem";
            this.dateIslem.Size = new System.Drawing.Size(146, 20);
            this.dateIslem.TabIndex = 12;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(75, 295);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(218, 46);
            this.txtAciklama.TabIndex = 13;
            // 
            // frmCekDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(552, 416);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.dateIslem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbKasa);
            this.Controls.Add(this.grbCari);
            this.Controls.Add(this.grbBanka);
            this.Controls.Add(this.grbVerilenCek);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grbAlinanCek);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.Name = "frmCekDurum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÇekDurum";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCekDurum_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbAlinanCek.ResumeLayout(false);
            this.grbAlinanCek.PerformLayout();
            this.grbVerilenCek.ResumeLayout(false);
            this.grbVerilenCek.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grbBanka.ResumeLayout(false);
            this.grbBanka.PerformLayout();
            this.grbCari.ResumeLayout(false);
            this.grbCari.PerformLayout();
            this.grbKasa.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnKaydet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labSuanDurum;
        private System.Windows.Forms.GroupBox grbAlinanCek;
        private System.Windows.Forms.RadioButton rbTahsilBankaHesaba;
        private System.Windows.Forms.RadioButton rbBankayaTahsileVerildi;
        private System.Windows.Forms.RadioButton rbCiroEdildi;
        private System.Windows.Forms.RadioButton rbTahsilEdildi;
        private System.Windows.Forms.RadioButton rbBeklemede;
        private System.Windows.Forms.RadioButton rbKarsiliksiz;
        private System.Windows.Forms.RadioButton rbBankaTeminatVerildi;
        private System.Windows.Forms.RadioButton rbIadeEdildi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labCariKod;
        private System.Windows.Forms.Label labCariIsim;
        private System.Windows.Forms.GroupBox grbVerilenCek;
        private System.Windows.Forms.RadioButton rbGeriAlindi;
        private System.Windows.Forms.RadioButton rbOdendi;
        private System.Windows.Forms.RadioButton rbBeklemedeVerilen;
        private System.Windows.Forms.GroupBox grbBanka;
        private System.Windows.Forms.Button btnBankaRehber;
        public IndeksControl.AutoCompleteTextBox txtBankaHesap;
        private System.Windows.Forms.GroupBox grbCari;
        private System.Windows.Forms.Button btnCariRehber;
        public IndeksControl.AutoCompleteTextBox txtCari;
        private System.Windows.Forms.GroupBox grbKasa;
        private System.Windows.Forms.ComboBox cmbKasa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateIslem;
        private System.Windows.Forms.TextBox txtAciklama;
    }
}