namespace Indeks.Views
{
  partial class frmStokSearch
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokSearch));
        this.panel1 = new System.Windows.Forms.Panel();
        this.label13 = new System.Windows.Forms.Label();
        this.txtKod1 = new System.Windows.Forms.TextBox();
        this.label3 = new System.Windows.Forms.Label();
        this.txtKod4 = new System.Windows.Forms.TextBox();
        this.txtGrupKodu = new System.Windows.Forms.TextBox();
        this.label6 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.txtKod3 = new System.Windows.Forms.TextBox();
        this.txtStokAdi = new System.Windows.Forms.TextBox();
        this.label7 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.txtKod2 = new System.Windows.Forms.TextBox();
        this.txtStokKodu = new System.Windows.Forms.TextBox();
        this.label8 = new System.Windows.Forms.Label();
        this.label1 = new System.Windows.Forms.Label();
        this.listView1 = new System.Windows.Forms.ListView();
        this.clStokMiktar = new System.Windows.Forms.ColumnHeader();
        this.clStokKodu = new System.Windows.Forms.ColumnHeader();
        this.clStokIsmi = new System.Windows.Forms.ColumnHeader();
        this.clAlisKdvOrani = new System.Windows.Forms.ColumnHeader();
        this.clSatisKdvOrani = new System.Windows.Forms.ColumnHeader();
        this.clBirim = new System.Windows.Forms.ColumnHeader();
        this.clAsgariMiktar = new System.Windows.Forms.ColumnHeader();
        this.clAzamiMiktar = new System.Windows.Forms.ColumnHeader();
        this.clAlsFyt = new System.Windows.Forms.ColumnHeader();
        this.clStFyt = new System.Windows.Forms.ColumnHeader();
        this.clStGrp1 = new System.Windows.Forms.ColumnHeader();
        this.clStGrp2 = new System.Windows.Forms.ColumnHeader();
        this.clStGrp3 = new System.Windows.Forms.ColumnHeader();
        this.clStGrp4 = new System.Windows.Forms.ColumnHeader();
        this.clStGrp5 = new System.Windows.Forms.ColumnHeader();
        this.clBrk1 = new System.Windows.Forms.ColumnHeader();
        this.clBrk2 = new System.Windows.Forms.ColumnHeader();
        this.clBrk3 = new System.Windows.Forms.ColumnHeader();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.toolStrip1 = new System.Windows.Forms.ToolStrip();
        this.tsbtnYeniKayit = new System.Windows.Forms.ToolStripButton();
        this.tsbtnSil = new System.Windows.Forms.ToolStripButton();
        this.tsbtnKapat = new System.Windows.Forms.ToolStripButton();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.groupBox3 = new System.Windows.Forms.GroupBox();
        this.panel1.SuspendLayout();
        this.groupBox1.SuspendLayout();
        this.toolStrip1.SuspendLayout();
        this.groupBox2.SuspendLayout();
        this.groupBox3.SuspendLayout();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.AutoScroll = true;
        this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.panel1.Controls.Add(this.label13);
        this.panel1.Controls.Add(this.txtKod1);
        this.panel1.Controls.Add(this.label3);
        this.panel1.Controls.Add(this.txtKod4);
        this.panel1.Controls.Add(this.txtGrupKodu);
        this.panel1.Controls.Add(this.label6);
        this.panel1.Controls.Add(this.label4);
        this.panel1.Controls.Add(this.txtKod3);
        this.panel1.Controls.Add(this.txtStokAdi);
        this.panel1.Controls.Add(this.label7);
        this.panel1.Controls.Add(this.label2);
        this.panel1.Controls.Add(this.txtKod2);
        this.panel1.Controls.Add(this.txtStokKodu);
        this.panel1.Controls.Add(this.label8);
        this.panel1.Controls.Add(this.label1);
        this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
        this.panel1.Location = new System.Drawing.Point(3, 16);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(205, 429);
        this.panel1.TabIndex = 1;
        // 
        // label13
        // 
        this.label13.AutoSize = true;
        this.label13.Location = new System.Drawing.Point(0, 47);
        this.label13.Name = "label13";
        this.label13.Size = new System.Drawing.Size(47, 13);
        this.label13.TabIndex = 16;
        this.label13.Text = "Stok Adı";
        // 
        // txtKod1
        // 
        this.txtKod1.Location = new System.Drawing.Point(3, 141);
        this.txtKod1.Name = "txtKod1";
        this.txtKod1.Size = new System.Drawing.Size(192, 20);
        this.txtKod1.TabIndex = 4;
        this.txtKod1.TextChanged += new System.EventHandler(this.txtStokKodu_TextChanged);
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(0, 125);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(39, 13);
        this.label3.TabIndex = 6;
        this.label3.Text = "Grup-2";
        // 
        // txtKod4
        // 
        this.txtKod4.Location = new System.Drawing.Point(3, 258);
        this.txtKod4.Name = "txtKod4";
        this.txtKod4.Size = new System.Drawing.Size(192, 20);
        this.txtKod4.TabIndex = 7;
        this.txtKod4.TextChanged += new System.EventHandler(this.txtStokKodu_TextChanged);
        // 
        // txtGrupKodu
        // 
        this.txtGrupKodu.Location = new System.Drawing.Point(3, 102);
        this.txtGrupKodu.Name = "txtGrupKodu";
        this.txtGrupKodu.Size = new System.Drawing.Size(192, 20);
        this.txtGrupKodu.TabIndex = 3;
        this.txtGrupKodu.TextChanged += new System.EventHandler(this.txtStokKodu_TextChanged);
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Location = new System.Drawing.Point(0, 242);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(39, 13);
        this.label6.TabIndex = 12;
        this.label6.Text = "Grup-5";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(0, 86);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(39, 13);
        this.label4.TabIndex = 4;
        this.label4.Text = "Grup-1";
        // 
        // txtKod3
        // 
        this.txtKod3.Location = new System.Drawing.Point(3, 219);
        this.txtKod3.Name = "txtKod3";
        this.txtKod3.Size = new System.Drawing.Size(192, 20);
        this.txtKod3.TabIndex = 6;
        this.txtKod3.TextChanged += new System.EventHandler(this.txtStokKodu_TextChanged);
        // 
        // txtStokAdi
        // 
        this.txtStokAdi.Location = new System.Drawing.Point(3, 63);
        this.txtStokAdi.Name = "txtStokAdi";
        this.txtStokAdi.Size = new System.Drawing.Size(192, 20);
        this.txtStokAdi.TabIndex = 2;
        this.txtStokAdi.TextChanged += new System.EventHandler(this.txtStokKodu_TextChanged);
        // 
        // label7
        // 
        this.label7.AutoSize = true;
        this.label7.Location = new System.Drawing.Point(0, 203);
        this.label7.Name = "label7";
        this.label7.Size = new System.Drawing.Size(39, 13);
        this.label7.TabIndex = 10;
        this.label7.Text = "Grup-4";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(0, 47);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(0, 13);
        this.label2.TabIndex = 2;
        // 
        // txtKod2
        // 
        this.txtKod2.Location = new System.Drawing.Point(3, 180);
        this.txtKod2.Name = "txtKod2";
        this.txtKod2.Size = new System.Drawing.Size(192, 20);
        this.txtKod2.TabIndex = 5;
        this.txtKod2.TextChanged += new System.EventHandler(this.txtStokKodu_TextChanged);
        // 
        // txtStokKodu
        // 
        this.txtStokKodu.Location = new System.Drawing.Point(3, 24);
        this.txtStokKodu.Name = "txtStokKodu";
        this.txtStokKodu.Size = new System.Drawing.Size(192, 20);
        this.txtStokKodu.TabIndex = 1;
        this.txtStokKodu.TextChanged += new System.EventHandler(this.txtStokKodu_TextChanged);
        // 
        // label8
        // 
        this.label8.AutoSize = true;
        this.label8.Location = new System.Drawing.Point(0, 164);
        this.label8.Name = "label8";
        this.label8.Size = new System.Drawing.Size(39, 13);
        this.label8.TabIndex = 8;
        this.label8.Text = "Grup-3";
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(0, 8);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(57, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "Stok Kodu";
        // 
        // listView1
        // 
        this.listView1.BackColor = System.Drawing.Color.White;
        this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clStokMiktar,
            this.clStokKodu,
            this.clStokIsmi,
            this.clAlisKdvOrani,
            this.clSatisKdvOrani,
            this.clBirim,
            this.clAsgariMiktar,
            this.clAzamiMiktar,
            this.clAlsFyt,
            this.clStFyt,
            this.clStGrp1,
            this.clStGrp2,
            this.clStGrp3,
            this.clStGrp4,
            this.clStGrp5,
            this.clBrk1,
            this.clBrk2,
            this.clBrk3});
        this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.listView1.ForeColor = System.Drawing.Color.Black;
        this.listView1.FullRowSelect = true;
        this.listView1.GridLines = true;
        this.listView1.Location = new System.Drawing.Point(3, 16);
        this.listView1.MultiSelect = false;
        this.listView1.Name = "listView1";
        this.listView1.Size = new System.Drawing.Size(676, 429);
        this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
        this.listView1.TabIndex = 2;
        this.listView1.UseCompatibleStateImageBehavior = false;
        this.listView1.View = System.Windows.Forms.View.Details;
        this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
        this.listView1.Enter += new System.EventHandler(this.listView1_Enter);
        this.listView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyUp);
        // 
        // clStokMiktar
        // 
        this.clStokMiktar.Text = "StokMiktar";
        this.clStokMiktar.Width = 65;
        // 
        // clStokKodu
        // 
        this.clStokKodu.Text = "StokKodu";
        this.clStokKodu.Width = 100;
        // 
        // clStokIsmi
        // 
        this.clStokIsmi.Text = "StokIsmi";
        this.clStokIsmi.Width = 200;
        // 
        // clAlisKdvOrani
        // 
        this.clAlisKdvOrani.Text = "AlişKdvOranı";
        this.clAlisKdvOrani.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.clAlisKdvOrani.Width = 80;
        // 
        // clSatisKdvOrani
        // 
        this.clSatisKdvOrani.Text = "SatişKdvOranı";
        this.clSatisKdvOrani.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.clSatisKdvOrani.Width = 81;
        // 
        // clBirim
        // 
        this.clBirim.Text = "Birim";
        // 
        // clAsgariMiktar
        // 
        this.clAsgariMiktar.Text = "AsgariMiktar";
        this.clAsgariMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.clAsgariMiktar.Width = 80;
        // 
        // clAzamiMiktar
        // 
        this.clAzamiMiktar.Text = "AzamiMiktar";
        this.clAzamiMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.clAzamiMiktar.Width = 76;
        // 
        // clAlsFyt
        // 
        this.clAlsFyt.Text = "AlışFiyat";
        this.clAlsFyt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // clStFyt
        // 
        this.clStFyt.Text = "SatışFiyat";
        this.clStFyt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.clStFyt.Width = 67;
        // 
        // clStGrp1
        // 
        this.clStGrp1.Text = "Grup1";
        this.clStGrp1.Width = 90;
        // 
        // clStGrp2
        // 
        this.clStGrp2.Text = "Grup2";
        this.clStGrp2.Width = 90;
        // 
        // clStGrp3
        // 
        this.clStGrp3.Text = "Grup3";
        this.clStGrp3.Width = 90;
        // 
        // clStGrp4
        // 
        this.clStGrp4.Text = "Grup4";
        this.clStGrp4.Width = 90;
        // 
        // clStGrp5
        // 
        this.clStGrp5.Text = "Grup5";
        this.clStGrp5.Width = 90;
        // 
        // clBrk1
        // 
        this.clBrk1.Text = "Barkod1";
        this.clBrk1.Width = 100;
        // 
        // clBrk2
        // 
        this.clBrk2.Text = "Barkod2";
        this.clBrk2.Width = 100;
        // 
        // clBrk3
        // 
        this.clBrk3.Text = "Barkod3";
        this.clBrk3.Width = 100;
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.toolStrip1);
        this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
        this.groupBox1.Location = new System.Drawing.Point(0, 0);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(893, 58);
        this.groupBox1.TabIndex = 3;
        this.groupBox1.TabStop = false;
        // 
        // toolStrip1
        // 
        this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnYeniKayit,
            this.tsbtnSil,
            this.tsbtnKapat});
        this.toolStrip1.Location = new System.Drawing.Point(3, 16);
        this.toolStrip1.Name = "toolStrip1";
        this.toolStrip1.Size = new System.Drawing.Size(887, 39);
        this.toolStrip1.TabIndex = 2;
        this.toolStrip1.Text = "toolStrip1";
        // 
        // tsbtnYeniKayit
        // 
        this.tsbtnYeniKayit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnYeniKayit.Image")));
        this.tsbtnYeniKayit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.tsbtnYeniKayit.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.tsbtnYeniKayit.Name = "tsbtnYeniKayit";
        this.tsbtnYeniKayit.Size = new System.Drawing.Size(104, 36);
        this.tsbtnYeniKayit.Text = "YeniKayıt(F3)";
        this.tsbtnYeniKayit.Click += new System.EventHandler(this.tsbtnYeniKayit_Click);
        // 
        // tsbtnSil
        // 
        this.tsbtnSil.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSil.Image")));
        this.tsbtnSil.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.tsbtnSil.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.tsbtnSil.Name = "tsbtnSil";
        this.tsbtnSil.Size = new System.Drawing.Size(75, 36);
        this.tsbtnSil.Text = "Sil(F7)";
        this.tsbtnSil.Click += new System.EventHandler(this.tsbtnSil_Click);
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
        // groupBox2
        // 
        this.groupBox2.Controls.Add(this.panel1);
        this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
        this.groupBox2.Location = new System.Drawing.Point(0, 58);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(211, 448);
        this.groupBox2.TabIndex = 4;
        this.groupBox2.TabStop = false;
        // 
        // groupBox3
        // 
        this.groupBox3.Controls.Add(this.listView1);
        this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
        this.groupBox3.Location = new System.Drawing.Point(211, 58);
        this.groupBox3.Name = "groupBox3";
        this.groupBox3.Size = new System.Drawing.Size(682, 448);
        this.groupBox3.TabIndex = 5;
        this.groupBox3.TabStop = false;
        // 
        // frmStokSearch
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.ClientSize = new System.Drawing.Size(893, 506);
        this.Controls.Add(this.groupBox3);
        this.Controls.Add(this.groupBox2);
        this.Controls.Add(this.groupBox1);
        this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.KeyPreview = true;
        this.Name = "frmStokSearch";
        this.Text = "StokArama";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.Load += new System.EventHandler(this.frmStokSearch_Load);
        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStokSearch_KeyDown);
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.toolStrip1.ResumeLayout(false);
        this.toolStrip1.PerformLayout();
        this.groupBox2.ResumeLayout(false);
        this.groupBox3.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.TextBox txtKod1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtKod4;
    private System.Windows.Forms.TextBox txtGrupKodu;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtKod3;
    private System.Windows.Forms.TextBox txtStokAdi;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtKod2;
    private System.Windows.Forms.TextBox txtStokKodu;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.ColumnHeader clStokKodu;
    private System.Windows.Forms.ColumnHeader clStokIsmi;
    private System.Windows.Forms.ColumnHeader clAlisKdvOrani;
    private System.Windows.Forms.ColumnHeader clBirim;
    private System.Windows.Forms.ColumnHeader clAsgariMiktar;
    private System.Windows.Forms.ColumnHeader clAzamiMiktar;
    private System.Windows.Forms.ColumnHeader clAlsFyt;
    private System.Windows.Forms.ColumnHeader clStFyt;
    private System.Windows.Forms.ColumnHeader clStGrp1;
    private System.Windows.Forms.ColumnHeader clStGrp2;
    private System.Windows.Forms.ColumnHeader clStGrp3;
    private System.Windows.Forms.ColumnHeader clStGrp4;
    private System.Windows.Forms.ColumnHeader clStGrp5;
    private System.Windows.Forms.ColumnHeader clBrk1;
    private System.Windows.Forms.ColumnHeader clBrk2;
    private System.Windows.Forms.ColumnHeader clBrk3;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton tsbtnYeniKayit;
    private System.Windows.Forms.ToolStripButton tsbtnSil;
    private System.Windows.Forms.ToolStripButton tsbtnKapat;
    private System.Windows.Forms.ColumnHeader clSatisKdvOrani;
    private System.Windows.Forms.ColumnHeader clStokMiktar;
  }
}