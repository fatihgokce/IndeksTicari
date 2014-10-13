namespace Indeks.Views
{
  partial class frmHizliCari
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHizliCari));
        this.toolStrip1 = new System.Windows.Forms.ToolStrip();
        this.tsbtnKaydet = new System.Windows.Forms.ToolStripButton();
        this.tsbtnKapat = new System.Windows.Forms.ToolStripButton();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.btnCariRehber = new System.Windows.Forms.Button();
        this.txtVergiNumarasi = new System.Windows.Forms.TextBox();
        this.label8 = new System.Windows.Forms.Label();
        this.txtVergiDairesi = new System.Windows.Forms.TextBox();
        this.label7 = new System.Windows.Forms.Label();
        this.groupBox4 = new System.Windows.Forms.GroupBox();
        this.rbAliciSatici = new System.Windows.Forms.RadioButton();
        this.rbAlici = new System.Windows.Forms.RadioButton();
        this.rbSatici = new System.Windows.Forms.RadioButton();
        this.txtCepTel = new System.Windows.Forms.MaskedTextBox();
        this.txtTel = new System.Windows.Forms.MaskedTextBox();
        this.label15 = new System.Windows.Forms.Label();
        this.txtCariKodu = new IndeksControl.AutoCompleteTextBox();
        this.label5 = new System.Windows.Forms.Label();
        this.txtCariAdres = new System.Windows.Forms.TextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.txtCariIsim = new System.Windows.Forms.TextBox();
        this.label3 = new System.Windows.Forms.Label();
        this.label1 = new System.Windows.Forms.Label();
        this.toolStrip1.SuspendLayout();
        this.groupBox1.SuspendLayout();
        this.groupBox4.SuspendLayout();
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
        this.toolStrip1.Size = new System.Drawing.Size(382, 39);
        this.toolStrip1.TabIndex = 1;
        this.toolStrip1.Text = "toolStrip1";
        // 
        // tsbtnKaydet
        // 
        this.tsbtnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnKaydet.Image")));
        this.tsbtnKaydet.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.tsbtnKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.tsbtnKaydet.Name = "tsbtnKaydet";
        this.tsbtnKaydet.Size = new System.Drawing.Size(148, 36);
        this.tsbtnKaydet.Text = "Seç Veya Kaydet(F5)";
        this.tsbtnKaydet.Click += new System.EventHandler(this.tsbtnKaydet_Click);
        // 
        // tsbtnKapat
        // 
        this.tsbtnKapat.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnKapat.Image")));
        this.tsbtnKapat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.tsbtnKapat.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.tsbtnKapat.Name = "tsbtnKapat";
        this.tsbtnKapat.Size = new System.Drawing.Size(90, 36);
        this.tsbtnKapat.Text = "Kapat(Esc)";
        this.tsbtnKapat.Click += new System.EventHandler(this.tsbtnKapat_Click);
        // 
        // groupBox1
        // 
        this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.groupBox1.Controls.Add(this.btnCariRehber);
        this.groupBox1.Controls.Add(this.txtVergiNumarasi);
        this.groupBox1.Controls.Add(this.label8);
        this.groupBox1.Controls.Add(this.txtVergiDairesi);
        this.groupBox1.Controls.Add(this.label7);
        this.groupBox1.Controls.Add(this.groupBox4);
        this.groupBox1.Controls.Add(this.txtCepTel);
        this.groupBox1.Controls.Add(this.txtTel);
        this.groupBox1.Controls.Add(this.label15);
        this.groupBox1.Controls.Add(this.txtCariKodu);
        this.groupBox1.Controls.Add(this.label5);
        this.groupBox1.Controls.Add(this.txtCariAdres);
        this.groupBox1.Controls.Add(this.label2);
        this.groupBox1.Controls.Add(this.txtCariIsim);
        this.groupBox1.Controls.Add(this.label3);
        this.groupBox1.Controls.Add(this.label1);
        this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
        this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
        this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
        this.groupBox1.Location = new System.Drawing.Point(0, 39);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(382, 232);
        this.groupBox1.TabIndex = 2;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Müşteri";
        // 
        // btnCariRehber
        // 
        this.btnCariRehber.Location = new System.Drawing.Point(293, 15);
        this.btnCariRehber.Name = "btnCariRehber";
        this.btnCariRehber.Size = new System.Drawing.Size(34, 20);
        this.btnCariRehber.TabIndex = 40;
        this.btnCariRehber.TabStop = false;
        this.btnCariRehber.Text = "...";
        this.btnCariRehber.UseVisualStyleBackColor = true;
        this.btnCariRehber.Click += new System.EventHandler(this.btnCariRehber_Click);
        // 
        // txtVergiNumarasi
        // 
        this.txtVergiNumarasi.Location = new System.Drawing.Point(103, 147);
        this.txtVergiNumarasi.MaxLength = 50;
        this.txtVergiNumarasi.Name = "txtVergiNumarasi";
        this.txtVergiNumarasi.Size = new System.Drawing.Size(184, 20);
        this.txtVergiNumarasi.TabIndex = 5;
        // 
        // label8
        // 
        this.label8.AutoSize = true;
        this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
        this.label8.Location = new System.Drawing.Point(19, 147);
        this.label8.Name = "label8";
        this.label8.Size = new System.Drawing.Size(78, 13);
        this.label8.TabIndex = 39;
        this.label8.Text = "Vergi Numarası";
        // 
        // txtVergiDairesi
        // 
        this.txtVergiDairesi.Location = new System.Drawing.Point(103, 118);
        this.txtVergiDairesi.MaxLength = 50;
        this.txtVergiDairesi.Name = "txtVergiDairesi";
        this.txtVergiDairesi.Size = new System.Drawing.Size(184, 20);
        this.txtVergiDairesi.TabIndex = 4;
        // 
        // label7
        // 
        this.label7.AutoSize = true;
        this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
        this.label7.Location = new System.Drawing.Point(19, 118);
        this.label7.Name = "label7";
        this.label7.Size = new System.Drawing.Size(66, 13);
        this.label7.TabIndex = 38;
        this.label7.Text = "Vergi Dairesi";
        // 
        // groupBox4
        // 
        this.groupBox4.Controls.Add(this.rbAliciSatici);
        this.groupBox4.Controls.Add(this.rbAlici);
        this.groupBox4.Controls.Add(this.rbSatici);
        this.groupBox4.Location = new System.Drawing.Point(21, 216);
        this.groupBox4.Name = "groupBox4";
        this.groupBox4.Size = new System.Drawing.Size(54, 10);
        this.groupBox4.TabIndex = 35;
        this.groupBox4.TabStop = false;
        this.groupBox4.Text = "Cari Tipi";
        this.groupBox4.Visible = false;
        // 
        // rbAliciSatici
        // 
        this.rbAliciSatici.AutoSize = true;
        this.rbAliciSatici.Location = new System.Drawing.Point(117, 28);
        this.rbAliciSatici.Name = "rbAliciSatici";
        this.rbAliciSatici.Size = new System.Drawing.Size(70, 17);
        this.rbAliciSatici.TabIndex = 2;
        this.rbAliciSatici.Text = "AliciSatici";
        this.rbAliciSatici.UseVisualStyleBackColor = true;
        // 
        // rbAlici
        // 
        this.rbAlici.AutoSize = true;
        this.rbAlici.Checked = true;
        this.rbAlici.Location = new System.Drawing.Point(6, 28);
        this.rbAlici.Name = "rbAlici";
        this.rbAlici.Size = new System.Drawing.Size(44, 17);
        this.rbAlici.TabIndex = 0;
        this.rbAlici.TabStop = true;
        this.rbAlici.Text = "Alıcı";
        this.rbAlici.UseVisualStyleBackColor = true;
        // 
        // rbSatici
        // 
        this.rbSatici.AutoSize = true;
        this.rbSatici.Location = new System.Drawing.Point(60, 28);
        this.rbSatici.Name = "rbSatici";
        this.rbSatici.Size = new System.Drawing.Size(51, 17);
        this.rbSatici.TabIndex = 1;
        this.rbSatici.Text = "Satıcı";
        this.rbSatici.UseVisualStyleBackColor = true;
        // 
        // txtCepTel
        // 
        this.txtCepTel.Location = new System.Drawing.Point(106, 92);
        this.txtCepTel.Mask = "(999) 000-0000";
        this.txtCepTel.Name = "txtCepTel";
        this.txtCepTel.Size = new System.Drawing.Size(181, 20);
        this.txtCepTel.TabIndex = 3;
        // 
        // txtTel
        // 
        this.txtTel.Location = new System.Drawing.Point(106, 66);
        this.txtTel.Mask = "(999) 000-0000";
        this.txtTel.Name = "txtTel";
        this.txtTel.Size = new System.Drawing.Size(181, 20);
        this.txtTel.TabIndex = 2;
        // 
        // label15
        // 
        this.label15.AutoSize = true;
        this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
        this.label15.Location = new System.Drawing.Point(22, 92);
        this.label15.Name = "label15";
        this.label15.Size = new System.Drawing.Size(47, 13);
        this.label15.TabIndex = 34;
        this.label15.Text = "Cep Tel.";
        // 
        // txtCariKodu
        // 
        this.txtCariKodu.Ayirac = "";
        this.txtCariKodu.AyracBoslukKullan = true;
        this.txtCariKodu.DataSource = null;
        this.txtCariKodu.ListForeColor = System.Drawing.Color.White;
        this.txtCariKodu.ListItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        this.txtCariKodu.Location = new System.Drawing.Point(106, 16);
        this.txtCariKodu.Name = "txtCariKodu";
        this.txtCariKodu.NextTabControlName = "";
        this.txtCariKodu.Size = new System.Drawing.Size(181, 20);
        this.txtCariKodu.TabIndex = 0;
        this.txtCariKodu.WidthAutoComplete = 200;
        this.txtCariKodu.WidthKod = 15;
        this.txtCariKodu.TextChanged += new System.EventHandler(this.txtCariKodu_TextChanged);
        this.txtCariKodu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCariKodu_KeyUp);
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
        this.label5.Location = new System.Drawing.Point(22, 16);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(53, 13);
        this.label5.TabIndex = 18;
        this.label5.Text = "Cari Kodu";
        // 
        // txtCariAdres
        // 
        this.txtCariAdres.Location = new System.Drawing.Point(103, 178);
        this.txtCariAdres.MaxLength = 100;
        this.txtCariAdres.Multiline = true;
        this.txtCariAdres.Name = "txtCariAdres";
        this.txtCariAdres.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        this.txtCariAdres.Size = new System.Drawing.Size(252, 36);
        this.txtCariAdres.TabIndex = 6;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
        this.label2.Location = new System.Drawing.Point(22, 178);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(34, 13);
        this.label2.TabIndex = 13;
        this.label2.Text = "Adres";
        // 
        // txtCariIsim
        // 
        this.txtCariIsim.Location = new System.Drawing.Point(106, 42);
        this.txtCariIsim.MaxLength = 50;
        this.txtCariIsim.Name = "txtCariIsim";
        this.txtCariIsim.Size = new System.Drawing.Size(181, 20);
        this.txtCariIsim.TabIndex = 1;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
        this.label3.Location = new System.Drawing.Point(22, 42);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(63, 13);
        this.label3.TabIndex = 11;
        this.label3.Text = "Isim Soyisim";
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
        this.label1.Location = new System.Drawing.Point(22, 66);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(43, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "Telefon";
        // 
        // frmHizliCari
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.ClientSize = new System.Drawing.Size(382, 273);
        this.Controls.Add(this.groupBox1);
        this.Controls.Add(this.toolStrip1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.KeyPreview = true;
        this.Name = "frmHizliCari";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Müşteri";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHizliCari_FormClosing);
        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmHizliCari_KeyDown);
        this.toolStrip1.ResumeLayout(false);
        this.toolStrip1.PerformLayout();
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.groupBox4.ResumeLayout(false);
        this.groupBox4.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton tsbtnKaydet;
    private System.Windows.Forms.ToolStripButton tsbtnKapat;
    private System.Windows.Forms.GroupBox groupBox1;
    public System.Windows.Forms.MaskedTextBox txtCepTel;
    public System.Windows.Forms.MaskedTextBox txtTel;
    private System.Windows.Forms.Label label15;
    public IndeksControl.AutoCompleteTextBox txtCariKodu;
    private System.Windows.Forms.Label label5;
    public System.Windows.Forms.TextBox txtCariAdres;
    private System.Windows.Forms.Label label2;
    public System.Windows.Forms.TextBox txtCariIsim;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox4;
    public System.Windows.Forms.RadioButton rbAliciSatici;
    public System.Windows.Forms.RadioButton rbAlici;
    public System.Windows.Forms.RadioButton rbSatici;
    public System.Windows.Forms.TextBox txtVergiNumarasi;
    private System.Windows.Forms.Label label8;
    public System.Windows.Forms.TextBox txtVergiDairesi;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button btnCariRehber;
  }
}