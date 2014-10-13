namespace Indeks.Views {
    partial class frmSenetDurum {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSenetDurum));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnKaydet = new System.Windows.Forms.ToolStripButton();
            this.btnBankaRehber = new System.Windows.Forms.Button();
            this.txtBankaHesap = new IndeksControl.AutoCompleteTextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.grbCari = new System.Windows.Forms.GroupBox();
            this.btnCariRehber = new System.Windows.Forms.Button();
            this.txtCari = new IndeksControl.AutoCompleteTextBox();
            this.grbBanka = new System.Windows.Forms.GroupBox();
            this.grbVerilenSenet = new System.Windows.Forms.GroupBox();
            this.rbGeriAlindi = new System.Windows.Forms.RadioButton();
            this.rbOdendi = new System.Windows.Forms.RadioButton();
            this.rbBeklemedeVerilen = new System.Windows.Forms.RadioButton();
            this.labCariKod = new System.Windows.Forms.Label();
            this.dateIslem = new System.Windows.Forms.DateTimePicker();
            this.cmbKasa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbKasa = new System.Windows.Forms.GroupBox();
            this.labCariIsim = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbKarsiliksiz = new System.Windows.Forms.RadioButton();
            this.grbAlinanSenet = new System.Windows.Forms.GroupBox();
            this.rbBankaTeminatVerildi = new System.Windows.Forms.RadioButton();
            this.rbIadeEdildi = new System.Windows.Forms.RadioButton();
            this.rbTahsilBankaHesaba = new System.Windows.Forms.RadioButton();
            this.rbBankayaTahsileVerildi = new System.Windows.Forms.RadioButton();
            this.rbCiroEdildi = new System.Windows.Forms.RadioButton();
            this.rbTahsilEdildi = new System.Windows.Forms.RadioButton();
            this.rbBeklemede = new System.Windows.Forms.RadioButton();
            this.labSuanDurum = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.grbCari.SuspendLayout();
            this.grbBanka.SuspendLayout();
            this.grbVerilenSenet.SuspendLayout();
            this.grbKasa.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grbAlinanSenet.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnKaydet,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(551, 39);
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
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(75, 294);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(218, 46);
            this.txtAciklama.TabIndex = 25;
            // 
            // grbCari
            // 
            this.grbCari.Controls.Add(this.btnCariRehber);
            this.grbCari.Controls.Add(this.txtCari);
            this.grbCari.Location = new System.Drawing.Point(554, 92);
            this.grbCari.Name = "grbCari";
            this.grbCari.Size = new System.Drawing.Size(221, 56);
            this.grbCari.TabIndex = 20;
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
            // grbBanka
            // 
            this.grbBanka.Controls.Add(this.btnBankaRehber);
            this.grbBanka.Controls.Add(this.txtBankaHesap);
            this.grbBanka.Location = new System.Drawing.Point(12, 200);
            this.grbBanka.Name = "grbBanka";
            this.grbBanka.Size = new System.Drawing.Size(281, 56);
            this.grbBanka.TabIndex = 19;
            this.grbBanka.TabStop = false;
            this.grbBanka.Text = "Banka Hesap";
            // 
            // grbVerilenSenet
            // 
            this.grbVerilenSenet.Controls.Add(this.rbGeriAlindi);
            this.grbVerilenSenet.Controls.Add(this.rbOdendi);
            this.grbVerilenSenet.Controls.Add(this.rbBeklemedeVerilen);
            this.grbVerilenSenet.Location = new System.Drawing.Point(348, 248);
            this.grbVerilenSenet.Name = "grbVerilenSenet";
            this.grbVerilenSenet.Size = new System.Drawing.Size(200, 151);
            this.grbVerilenSenet.TabIndex = 18;
            this.grbVerilenSenet.TabStop = false;
            this.grbVerilenSenet.Text = "YeniDurum";
            this.grbVerilenSenet.Visible = false;
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
            // dateIslem
            // 
            this.dateIslem.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateIslem.Location = new System.Drawing.Point(75, 263);
            this.dateIslem.Name = "dateIslem";
            this.dateIslem.Size = new System.Drawing.Size(146, 20);
            this.dateIslem.TabIndex = 24;
            // 
            // cmbKasa
            // 
            this.cmbKasa.FormattingEnabled = true;
            this.cmbKasa.Location = new System.Drawing.Point(10, 19);
            this.cmbKasa.Name = "cmbKasa";
            this.cmbKasa.Size = new System.Drawing.Size(160, 21);
            this.cmbKasa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Açıklama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "İşlemTarih";
            // 
            // grbKasa
            // 
            this.grbKasa.Controls.Add(this.cmbKasa);
            this.grbKasa.Location = new System.Drawing.Point(554, 154);
            this.grbKasa.Name = "grbKasa";
            this.grbKasa.Size = new System.Drawing.Size(221, 56);
            this.grbKasa.TabIndex = 21;
            this.grbKasa.TabStop = false;
            this.grbKasa.Text = "Kasa";
            this.grbKasa.Visible = false;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labCariIsim);
            this.groupBox3.Controls.Add(this.labCariKod);
            this.groupBox3.Location = new System.Drawing.Point(12, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 77);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CariHesapBilgileri";
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
            // grbAlinanSenet
            // 
            this.grbAlinanSenet.Controls.Add(this.rbKarsiliksiz);
            this.grbAlinanSenet.Controls.Add(this.rbBankaTeminatVerildi);
            this.grbAlinanSenet.Controls.Add(this.rbIadeEdildi);
            this.grbAlinanSenet.Controls.Add(this.rbTahsilBankaHesaba);
            this.grbAlinanSenet.Controls.Add(this.rbBankayaTahsileVerildi);
            this.grbAlinanSenet.Controls.Add(this.rbCiroEdildi);
            this.grbAlinanSenet.Controls.Add(this.rbTahsilEdildi);
            this.grbAlinanSenet.Controls.Add(this.rbBeklemede);
            this.grbAlinanSenet.Location = new System.Drawing.Point(348, 43);
            this.grbAlinanSenet.Name = "grbAlinanSenet";
            this.grbAlinanSenet.Size = new System.Drawing.Size(200, 199);
            this.grbAlinanSenet.TabIndex = 16;
            this.grbAlinanSenet.TabStop = false;
            this.grbAlinanSenet.Text = "YeniDurum";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labSuanDurum);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 68);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şuanki Durum";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(101, 36);
            this.toolStripButton1.Text = "Kapat(ESC)";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // frmSenetDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(551, 399);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.grbCari);
            this.Controls.Add(this.grbBanka);
            this.Controls.Add(this.grbVerilenSenet);
            this.Controls.Add(this.dateIslem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbKasa);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grbAlinanSenet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.Name = "frmSenetDurum";
            this.Text = "SenetDurum";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSenetDurum_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grbCari.ResumeLayout(false);
            this.grbCari.PerformLayout();
            this.grbBanka.ResumeLayout(false);
            this.grbBanka.PerformLayout();
            this.grbVerilenSenet.ResumeLayout(false);
            this.grbVerilenSenet.PerformLayout();
            this.grbKasa.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grbAlinanSenet.ResumeLayout(false);
            this.grbAlinanSenet.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnKaydet;
        private System.Windows.Forms.Button btnBankaRehber;
        public IndeksControl.AutoCompleteTextBox txtBankaHesap;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.GroupBox grbCari;
        private System.Windows.Forms.Button btnCariRehber;
        public IndeksControl.AutoCompleteTextBox txtCari;
        private System.Windows.Forms.GroupBox grbBanka;
        private System.Windows.Forms.GroupBox grbVerilenSenet;
        private System.Windows.Forms.RadioButton rbGeriAlindi;
        private System.Windows.Forms.RadioButton rbOdendi;
        private System.Windows.Forms.RadioButton rbBeklemedeVerilen;
        private System.Windows.Forms.Label labCariKod;
        private System.Windows.Forms.DateTimePicker dateIslem;
        private System.Windows.Forms.ComboBox cmbKasa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbKasa;
        private System.Windows.Forms.Label labCariIsim;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbKarsiliksiz;
        private System.Windows.Forms.GroupBox grbAlinanSenet;
        private System.Windows.Forms.RadioButton rbBankaTeminatVerildi;
        private System.Windows.Forms.RadioButton rbIadeEdildi;
        private System.Windows.Forms.RadioButton rbTahsilBankaHesaba;
        private System.Windows.Forms.RadioButton rbBankayaTahsileVerildi;
        private System.Windows.Forms.RadioButton rbCiroEdildi;
        private System.Windows.Forms.RadioButton rbTahsilEdildi;
        private System.Windows.Forms.RadioButton rbBeklemede;
        private System.Windows.Forms.Label labSuanDurum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}