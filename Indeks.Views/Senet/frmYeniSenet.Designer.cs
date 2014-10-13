namespace Indeks.Views {
    partial class frmYeniSenet {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYeniSenet));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnKaydet = new System.Windows.Forms.ToolStripButton();
            this.tsbtnKapat = new System.Windows.Forms.ToolStripButton();
            this.txtAsilSahip = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSenetNo = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtKefil1 = new System.Windows.Forms.TextBox();
            this.txtKefil2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateVade = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateIslem = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCariRehber = new System.Windows.Forms.Button();
            this.txtCariKodu = new IndeksControl.AutoCompleteTextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.toolStrip1.Size = new System.Drawing.Size(579, 39);
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
            // txtAsilSahip
            // 
            this.txtAsilSahip.Location = new System.Drawing.Point(92, 231);
            this.txtAsilSahip.Name = "txtAsilSahip";
            this.txtAsilSahip.Size = new System.Drawing.Size(145, 20);
            this.txtAsilSahip.TabIndex = 62;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(12, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 73;
            this.label10.Text = "AsılSahibi";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(92, 257);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(278, 53);
            this.txtAciklama.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(12, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 72;
            this.label9.Text = "Açıklama";
            // 
            // txtSenetNo
            // 
            this.txtSenetNo.Location = new System.Drawing.Point(92, 179);
            this.txtSenetNo.Name = "txtSenetNo";
            this.txtSenetNo.Size = new System.Drawing.Size(145, 20);
            this.txtSenetNo.TabIndex = 60;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(92, 205);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(145, 20);
            this.txtTutar.TabIndex = 61;
            // 
            // txtKefil1
            // 
            this.txtKefil1.Location = new System.Drawing.Point(92, 127);
            this.txtKefil1.Name = "txtKefil1";
            this.txtKefil1.Size = new System.Drawing.Size(145, 20);
            this.txtKefil1.TabIndex = 58;
            // 
            // txtKefil2
            // 
            this.txtKefil2.Location = new System.Drawing.Point(92, 153);
            this.txtKefil2.Name = "txtKefil2";
            this.txtKefil2.Size = new System.Drawing.Size(145, 20);
            this.txtKefil2.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(12, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 71;
            this.label8.Text = "Tutar(*)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(12, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 70;
            this.label7.Text = "SenetNo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(14, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Kefil2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "VadeTarih";
            // 
            // dateVade
            // 
            this.dateVade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVade.Location = new System.Drawing.Point(92, 101);
            this.dateVade.Name = "dateVade";
            this.dateVade.Size = new System.Drawing.Size(145, 20);
            this.dateVade.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "İşlemTarih";
            // 
            // dateIslem
            // 
            this.dateIslem.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateIslem.Location = new System.Drawing.Point(92, 77);
            this.dateIslem.Name = "dateIslem";
            this.dateIslem.Size = new System.Drawing.Size(145, 20);
            this.dateIslem.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(14, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Kefil1";
            // 
            // btnCariRehber
            // 
            this.btnCariRehber.Location = new System.Drawing.Point(243, 51);
            this.btnCariRehber.Name = "btnCariRehber";
            this.btnCariRehber.Size = new System.Drawing.Size(34, 20);
            this.btnCariRehber.TabIndex = 53;
            this.btnCariRehber.TabStop = false;
            this.btnCariRehber.Text = "...";
            this.btnCariRehber.UseVisualStyleBackColor = true;
            this.btnCariRehber.Click += new System.EventHandler(this.btnCariRehber_Click);
            // 
            // txtCariKodu
            // 
            this.txtCariKodu.Ayirac = "";
            this.txtCariKodu.AyracBoslukKullan = true;
            this.txtCariKodu.DataSource = null;
            this.txtCariKodu.ListForeColor = System.Drawing.Color.White;
            this.txtCariKodu.ListItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtCariKodu.Location = new System.Drawing.Point(92, 51);
            this.txtCariKodu.Name = "txtCariKodu";
            this.txtCariKodu.NextTabControlName = "dateIslem";
            this.txtCariKodu.Size = new System.Drawing.Size(145, 20);
            this.txtCariKodu.TabIndex = 52;
            this.txtCariKodu.WidthAutoComplete = 200;
            this.txtCariKodu.WidthKod = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(12, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Cari Kodu(*)";
            // 
            // frmYeniSenet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(579, 352);
            this.Controls.Add(this.txtAsilSahip);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSenetNo);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.txtKefil1);
            this.Controls.Add(this.txtKefil2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
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
            this.Name = "frmYeniSenet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Senet";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmYeniSenet_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnKaydet;
        private System.Windows.Forms.ToolStripButton tsbtnKapat;
        private System.Windows.Forms.TextBox txtAsilSahip;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSenetNo;
        private System.Windows.Forms.TextBox txtTutar;
        public System.Windows.Forms.TextBox txtKefil1;
        public System.Windows.Forms.TextBox txtKefil2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateVade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateIslem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCariRehber;
        public IndeksControl.AutoCompleteTextBox txtCariKodu;
        private System.Windows.Forms.Label label5;
    }
}