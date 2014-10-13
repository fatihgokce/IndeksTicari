namespace Indeks.Views {
    partial class frmYeniCek {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYeniCek));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnKaydet = new System.Windows.Forms.ToolStripButton();
            this.tsbtnKapat = new System.Windows.Forms.ToolStripButton();
            this.txtCariKodu = new IndeksControl.AutoCompleteTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCariRehber = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateIslem = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateVade = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSube = new System.Windows.Forms.TextBox();
            this.txtBanka = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtCekNo = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAsilSahip = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHesapNo = new IndeksControl.AutoCompleteTextBox();
            this.btnBankaRehber = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnKaydet,
            this.tsbtnKapat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(600, 39);
            this.toolStrip1.TabIndex = 1;
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
            // txtCariKodu
            // 
            this.txtCariKodu.Ayirac = "";
            this.txtCariKodu.AyracBoslukKullan = true;
            this.txtCariKodu.DataSource = null;
            this.txtCariKodu.ListForeColor = System.Drawing.Color.White;
            this.txtCariKodu.ListItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtCariKodu.Location = new System.Drawing.Point(92, 53);
            this.txtCariKodu.Name = "txtCariKodu";
            this.txtCariKodu.NextTabControlName = "dateIslem";
            this.txtCariKodu.Size = new System.Drawing.Size(145, 20);
            this.txtCariKodu.TabIndex = 0;
            this.txtCariKodu.WidthAutoComplete = 200;
            this.txtCariKodu.WidthKod = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(12, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Cari Kodu(*)";
            // 
            // btnCariRehber
            // 
            this.btnCariRehber.Location = new System.Drawing.Point(243, 53);
            this.btnCariRehber.Name = "btnCariRehber";
            this.btnCariRehber.Size = new System.Drawing.Size(34, 20);
            this.btnCariRehber.TabIndex = 0;
            this.btnCariRehber.TabStop = false;
            this.btnCariRehber.Text = "...";
            this.btnCariRehber.UseVisualStyleBackColor = true;
            this.btnCariRehber.Click += new System.EventHandler(this.btnCariRehber_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Banka";
            // 
            // dateIslem
            // 
            this.dateIslem.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateIslem.Location = new System.Drawing.Point(92, 79);
            this.dateIslem.Name = "dateIslem";
            this.dateIslem.Size = new System.Drawing.Size(145, 20);
            this.dateIslem.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "İşlemTarih";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "VadeTarih";
            // 
            // dateVade
            // 
            this.dateVade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVade.Location = new System.Drawing.Point(92, 103);
            this.dateVade.Name = "dateVade";
            this.dateVade.Size = new System.Drawing.Size(145, 20);
            this.dateVade.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Şube";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(12, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "HesapNo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(12, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "ÇekNo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(12, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Tutar(*)";
            // 
            // txtSube
            // 
            this.txtSube.Location = new System.Drawing.Point(92, 179);
            this.txtSube.Name = "txtSube";
            this.txtSube.Size = new System.Drawing.Size(145, 20);
            this.txtSube.TabIndex = 5;
            // 
            // txtBanka
            // 
            this.txtBanka.Location = new System.Drawing.Point(92, 151);
            this.txtBanka.Name = "txtBanka";
            this.txtBanka.Size = new System.Drawing.Size(145, 20);
            this.txtBanka.TabIndex = 4;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(92, 232);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(145, 20);
            this.txtTutar.TabIndex = 7;
            // 
            // txtCekNo
            // 
            this.txtCekNo.Location = new System.Drawing.Point(92, 206);
            this.txtCekNo.Name = "txtCekNo";
            this.txtCekNo.Size = new System.Drawing.Size(145, 20);
            this.txtCekNo.TabIndex = 6;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(92, 284);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(278, 53);
            this.txtAciklama.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(12, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Açıklama";
            // 
            // txtAsilSahip
            // 
            this.txtAsilSahip.Location = new System.Drawing.Point(92, 258);
            this.txtAsilSahip.Name = "txtAsilSahip";
            this.txtAsilSahip.Size = new System.Drawing.Size(145, 20);
            this.txtAsilSahip.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(12, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "AsılSahibi";
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Ayirac = null;
            this.txtHesapNo.AyracBoslukKullan = false;
            this.txtHesapNo.DataSource = null;
            this.txtHesapNo.ListForeColor = System.Drawing.Color.Empty;
            this.txtHesapNo.ListItemColor = System.Drawing.Color.DarkOrange;
            this.txtHesapNo.Location = new System.Drawing.Point(92, 127);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.NextTabControlName = "txtBanka";
            this.txtHesapNo.Size = new System.Drawing.Size(145, 20);
            this.txtHesapNo.TabIndex = 3;
            this.txtHesapNo.WidthAutoComplete = 145;
            this.txtHesapNo.WidthKod = 0;
            this.txtHesapNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHesapNo_KeyUp);
            // 
            // btnBankaRehber
            // 
            this.btnBankaRehber.Location = new System.Drawing.Point(243, 127);
            this.btnBankaRehber.Name = "btnBankaRehber";
            this.btnBankaRehber.Size = new System.Drawing.Size(34, 20);
            this.btnBankaRehber.TabIndex = 0;
            this.btnBankaRehber.TabStop = false;
            this.btnBankaRehber.Text = "...";
            this.btnBankaRehber.UseVisualStyleBackColor = true;
            this.btnBankaRehber.Visible = false;
            this.btnBankaRehber.Click += new System.EventHandler(this.btnBankaRehber_Click);
            // 
            // frmYeniCek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 358);
            this.Controls.Add(this.btnBankaRehber);
            this.Controls.Add(this.txtHesapNo);
            this.Controls.Add(this.txtAsilSahip);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCekNo);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.txtBanka);
            this.Controls.Add(this.txtSube);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateVade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateIslem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCariRehber);
            this.Controls.Add(this.txtCariKodu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.Name = "frmYeniCek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çek";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmYeniCek_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnKaydet;
        public IndeksControl.AutoCompleteTextBox txtCariKodu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCariRehber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateIslem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateVade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtCekNo;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAsilSahip;
        private System.Windows.Forms.Label label10;
        public IndeksControl.AutoCompleteTextBox txtHesapNo;
        private System.Windows.Forms.Button btnBankaRehber;
        public System.Windows.Forms.TextBox txtSube;
        public System.Windows.Forms.TextBox txtBanka;
        private System.Windows.Forms.ToolStripButton tsbtnKapat;
    }
}