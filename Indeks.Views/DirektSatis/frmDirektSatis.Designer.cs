namespace Indeks.Views
{
  partial class frmDirektSatis
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDirektSatis));
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
        this.toolStrip1 = new System.Windows.Forms.ToolStrip();
        this.tsbtnYeniKayit = new System.Windows.Forms.ToolStripButton();
        this.tsbtnKalemKaydet = new System.Windows.Forms.ToolStripButton();
        this.tsbtnKalemSil = new System.Windows.Forms.ToolStripButton();
        this.tsbtnKasayaAktar = new System.Windows.Forms.ToolStripButton();
        this.tsbtnVeresiye = new System.Windows.Forms.ToolStripButton();
        this.tsbtnKrediKarti = new System.Windows.Forms.ToolStripButton();
        this.tsbtnSatisiptal = new System.Windows.Forms.ToolStripButton();
        this.tsbtnKapat = new System.Windows.Forms.ToolStripButton();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.cmbDizayn = new System.Windows.Forms.ComboBox();
        this.chbFaturaBas = new System.Windows.Forms.CheckBox();
        this.labSecilenUrun = new System.Windows.Forms.Label();
        this.btnListe = new System.Windows.Forms.Button();
        this.label6 = new System.Windows.Forms.Label();
        this.label1 = new System.Windows.Forms.Label();
        this.txtMiktar = new System.Windows.Forms.TextBox();
        this.txtGenelGenelTop = new System.Windows.Forms.TextBox();
        this.label22 = new System.Windows.Forms.Label();
        this.label7 = new System.Windows.Forms.Label();
        this.txtGenelTopKdv = new System.Windows.Forms.TextBox();
        this.cmboxKasaKodu = new System.Windows.Forms.ComboBox();
        this.label23 = new System.Windows.Forms.Label();
        this.label5 = new System.Windows.Forms.Label();
        this.txtGenelAraTop = new System.Windows.Forms.TextBox();
        this.txtTutar = new System.Windows.Forms.TextBox();
        this.label24 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.txtSatisFiyat = new System.Windows.Forms.TextBox();
        this.label3 = new System.Windows.Forms.Label();
        this.txtBarkod = new System.Windows.Forms.TextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.dataGridView1 = new System.Windows.Forms.DataGridView();
        this.clBarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clStokKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clStokAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.btnRehber = new System.Windows.Forms.Button();
        this.toolStrip1.SuspendLayout();
        this.groupBox2.SuspendLayout();
        this.groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        this.SuspendLayout();
        // 
        // toolStrip1
        // 
        this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnYeniKayit,
            this.tsbtnKalemKaydet,
            this.tsbtnKalemSil,
            this.tsbtnKasayaAktar,
            this.tsbtnVeresiye,
            this.tsbtnKrediKarti,
            this.tsbtnSatisiptal,
            this.tsbtnKapat});
        this.toolStrip1.Location = new System.Drawing.Point(0, 528);
        this.toolStrip1.Name = "toolStrip1";
        this.toolStrip1.Size = new System.Drawing.Size(990, 55);
        this.toolStrip1.TabIndex = 0;
        this.toolStrip1.Text = "toolStrip1";
        // 
        // tsbtnYeniKayit
        // 
        this.tsbtnYeniKayit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnYeniKayit.Image")));
        this.tsbtnYeniKayit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.tsbtnYeniKayit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.tsbtnYeniKayit.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.tsbtnYeniKayit.Name = "tsbtnYeniKayit";
        this.tsbtnYeniKayit.Size = new System.Drawing.Size(87, 52);
        this.tsbtnYeniKayit.Text = "YeniKalem(F3)";
        this.tsbtnYeniKayit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.tsbtnYeniKayit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
        this.tsbtnYeniKayit.Click += new System.EventHandler(this.tsbtnYeniKayit_Click);
        // 
        // tsbtnKalemKaydet
        // 
        this.tsbtnKalemKaydet.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnKalemKaydet.Image")));
        this.tsbtnKalemKaydet.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.tsbtnKalemKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.tsbtnKalemKaydet.Name = "tsbtnKalemKaydet";
        this.tsbtnKalemKaydet.Size = new System.Drawing.Size(100, 52);
        this.tsbtnKalemKaydet.Text = "KalemKaydet(F5)";
        this.tsbtnKalemKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
        this.tsbtnKalemKaydet.Click += new System.EventHandler(this.tsbtnKalemKaydet_Click);
        // 
        // tsbtnKalemSil
        // 
        this.tsbtnKalemSil.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnKalemSil.Image")));
        this.tsbtnKalemSil.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.tsbtnKalemSil.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.tsbtnKalemSil.Name = "tsbtnKalemSil";
        this.tsbtnKalemSil.Size = new System.Drawing.Size(76, 52);
        this.tsbtnKalemSil.Text = "KalemSil(F7)";
        this.tsbtnKalemSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
        this.tsbtnKalemSil.Click += new System.EventHandler(this.tsbtnKalemSil_Click);
        // 
        // tsbtnKasayaAktar
        // 
        this.tsbtnKasayaAktar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.tsbtnKasayaAktar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnKasayaAktar.Image")));
        this.tsbtnKasayaAktar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.tsbtnKasayaAktar.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.tsbtnKasayaAktar.Name = "tsbtnKasayaAktar";
        this.tsbtnKasayaAktar.Size = new System.Drawing.Size(72, 52);
        this.tsbtnKasayaAktar.Text = "Peşin(F9)";
        this.tsbtnKasayaAktar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
        this.tsbtnKasayaAktar.Click += new System.EventHandler(this.tsbtnKasayaAktar_Click);
        // 
        // tsbtnVeresiye
        // 
        this.tsbtnVeresiye.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.tsbtnVeresiye.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnVeresiye.Image")));
        this.tsbtnVeresiye.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.tsbtnVeresiye.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.tsbtnVeresiye.Name = "tsbtnVeresiye";
        this.tsbtnVeresiye.Size = new System.Drawing.Size(103, 52);
        this.tsbtnVeresiye.Text = "Veresiye(F10)";
        this.tsbtnVeresiye.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
        this.tsbtnVeresiye.Click += new System.EventHandler(this.tsbtnVeresiye_Click);
        // 
        // tsbtnKrediKarti
        // 
        this.tsbtnKrediKarti.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.tsbtnKrediKarti.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnKrediKarti.Image")));
        this.tsbtnKrediKarti.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.tsbtnKrediKarti.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.tsbtnKrediKarti.Name = "tsbtnKrediKarti";
        this.tsbtnKrediKarti.Size = new System.Drawing.Size(103, 52);
        this.tsbtnKrediKarti.Text = "KrediKartı(F11)";
        this.tsbtnKrediKarti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
        this.tsbtnKrediKarti.Click += new System.EventHandler(this.tsbtnKrediKarti_Click);
        // 
        // tsbtnSatisiptal
        // 
        this.tsbtnSatisiptal.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSatisiptal.Image")));
        this.tsbtnSatisiptal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.tsbtnSatisiptal.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.tsbtnSatisiptal.Name = "tsbtnSatisiptal";
        this.tsbtnSatisiptal.Size = new System.Drawing.Size(58, 52);
        this.tsbtnSatisiptal.Text = "SatışIptal";
        this.tsbtnSatisiptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
        this.tsbtnSatisiptal.Click += new System.EventHandler(this.tsbtnSatisiptal_Click);
        // 
        // tsbtnKapat
        // 
        this.tsbtnKapat.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnKapat.Image")));
        this.tsbtnKapat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.tsbtnKapat.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.tsbtnKapat.Name = "tsbtnKapat";
        this.tsbtnKapat.Size = new System.Drawing.Size(69, 52);
        this.tsbtnKapat.Text = "Kapat(ESC)";
        this.tsbtnKapat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        this.tsbtnKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
        this.tsbtnKapat.Click += new System.EventHandler(this.tsbtnKapat_Click);
        // 
        // groupBox2
        // 
        this.groupBox2.Controls.Add(this.btnRehber);
        this.groupBox2.Controls.Add(this.cmbDizayn);
        this.groupBox2.Controls.Add(this.chbFaturaBas);
        this.groupBox2.Controls.Add(this.labSecilenUrun);
        this.groupBox2.Controls.Add(this.btnListe);
        this.groupBox2.Controls.Add(this.label6);
        this.groupBox2.Controls.Add(this.label1);
        this.groupBox2.Controls.Add(this.txtMiktar);
        this.groupBox2.Controls.Add(this.txtGenelGenelTop);
        this.groupBox2.Controls.Add(this.label22);
        this.groupBox2.Controls.Add(this.label7);
        this.groupBox2.Controls.Add(this.txtGenelTopKdv);
        this.groupBox2.Controls.Add(this.cmboxKasaKodu);
        this.groupBox2.Controls.Add(this.label23);
        this.groupBox2.Controls.Add(this.label5);
        this.groupBox2.Controls.Add(this.txtGenelAraTop);
        this.groupBox2.Controls.Add(this.txtTutar);
        this.groupBox2.Controls.Add(this.label24);
        this.groupBox2.Controls.Add(this.label4);
        this.groupBox2.Controls.Add(this.txtSatisFiyat);
        this.groupBox2.Controls.Add(this.label3);
        this.groupBox2.Controls.Add(this.txtBarkod);
        this.groupBox2.Controls.Add(this.label2);
        this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
        this.groupBox2.Location = new System.Drawing.Point(0, 0);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(990, 205);
        this.groupBox2.TabIndex = 0;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "DirektSatış";
        // 
        // cmbDizayn
        // 
        this.cmbDizayn.FormattingEnabled = true;
        this.cmbDizayn.Location = new System.Drawing.Point(93, 20);
        this.cmbDizayn.Name = "cmbDizayn";
        this.cmbDizayn.Size = new System.Drawing.Size(121, 21);
        this.cmbDizayn.TabIndex = 98;
        // 
        // chbFaturaBas
        // 
        this.chbFaturaBas.AutoSize = true;
        this.chbFaturaBas.Location = new System.Drawing.Point(13, 20);
        this.chbFaturaBas.Name = "chbFaturaBas";
        this.chbFaturaBas.Size = new System.Drawing.Size(74, 17);
        this.chbFaturaBas.TabIndex = 97;
        this.chbFaturaBas.Text = "FaturaBas";
        this.chbFaturaBas.UseVisualStyleBackColor = true;
        // 
        // labSecilenUrun
        // 
        this.labSecilenUrun.AutoSize = true;
        this.labSecilenUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.labSecilenUrun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
        this.labSecilenUrun.Location = new System.Drawing.Point(5, 133);
        this.labSecilenUrun.Name = "labSecilenUrun";
        this.labSecilenUrun.Size = new System.Drawing.Size(0, 16);
        this.labSecilenUrun.TabIndex = 96;
        // 
        // btnListe
        // 
        this.btnListe.Location = new System.Drawing.Point(220, 45);
        this.btnListe.Name = "btnListe";
        this.btnListe.Size = new System.Drawing.Size(88, 23);
        this.btnListe.TabIndex = 95;
        this.btnListe.Text = "Listeyi Yenile";
        this.btnListe.UseVisualStyleBackColor = true;
        this.btnListe.Click += new System.EventHandler(this.btnListe_Click);
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        this.label6.Location = new System.Drawing.Point(5, 178);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(341, 16);
        this.label6.TabIndex = 94;
        this.label6.Text = ",MİKTAR azaltmak içinde aşağı ok tuşuna basabilirisiniz.";
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        this.label1.Location = new System.Drawing.Point(6, 162);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(256, 16);
        this.label1.TabIndex = 93;
        this.label1.Text = "Not:MİKTAR Artırmak için yukarı ok tuşuna";
        // 
        // txtMiktar
        // 
        this.txtMiktar.Location = new System.Drawing.Point(9, 108);
        this.txtMiktar.Name = "txtMiktar";
        this.txtMiktar.Size = new System.Drawing.Size(85, 20);
        this.txtMiktar.TabIndex = 0;
        this.txtMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // txtGenelGenelTop
        // 
        this.txtGenelGenelTop.BackColor = System.Drawing.Color.White;
        this.txtGenelGenelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.txtGenelGenelTop.ForeColor = System.Drawing.Color.Red;
        this.txtGenelGenelTop.Location = new System.Drawing.Point(606, 149);
        this.txtGenelGenelTop.Name = "txtGenelGenelTop";
        this.txtGenelGenelTop.ReadOnly = true;
        this.txtGenelGenelTop.Size = new System.Drawing.Size(199, 29);
        this.txtGenelGenelTop.TabIndex = 7;
        this.txtGenelGenelTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // label22
        // 
        this.label22.AutoSize = true;
        this.label22.Location = new System.Drawing.Point(603, 133);
        this.label22.Margin = new System.Windows.Forms.Padding(0);
        this.label22.Name = "label22";
        this.label22.Size = new System.Drawing.Size(73, 13);
        this.label22.TabIndex = 39;
        this.label22.Text = "Genel Toplam";
        // 
        // label7
        // 
        this.label7.AutoSize = true;
        this.label7.Location = new System.Drawing.Point(10, 50);
        this.label7.Name = "label7";
        this.label7.Size = new System.Drawing.Size(56, 13);
        this.label7.TabIndex = 86;
        this.label7.Text = "KasaKodu";
        // 
        // txtGenelTopKdv
        // 
        this.txtGenelTopKdv.BackColor = System.Drawing.Color.White;
        this.txtGenelTopKdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.txtGenelTopKdv.ForeColor = System.Drawing.Color.Red;
        this.txtGenelTopKdv.Location = new System.Drawing.Point(606, 94);
        this.txtGenelTopKdv.Name = "txtGenelTopKdv";
        this.txtGenelTopKdv.ReadOnly = true;
        this.txtGenelTopKdv.Size = new System.Drawing.Size(125, 29);
        this.txtGenelTopKdv.TabIndex = 6;
        this.txtGenelTopKdv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // cmboxKasaKodu
        // 
        this.cmboxKasaKodu.FormattingEnabled = true;
        this.cmboxKasaKodu.Location = new System.Drawing.Point(93, 47);
        this.cmboxKasaKodu.Name = "cmboxKasaKodu";
        this.cmboxKasaKodu.Size = new System.Drawing.Size(121, 21);
        this.cmboxKasaKodu.TabIndex = 4;
        // 
        // label23
        // 
        this.label23.AutoSize = true;
        this.label23.Location = new System.Drawing.Point(603, 78);
        this.label23.Margin = new System.Windows.Forms.Padding(0);
        this.label23.Name = "label23";
        this.label23.Size = new System.Drawing.Size(64, 13);
        this.label23.TabIndex = 37;
        this.label23.Text = "Toplam Kdv";
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(388, 92);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(32, 13);
        this.label5.TabIndex = 92;
        this.label5.Text = "Tutar";
        // 
        // txtGenelAraTop
        // 
        this.txtGenelAraTop.BackColor = System.Drawing.Color.White;
        this.txtGenelAraTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.txtGenelAraTop.ForeColor = System.Drawing.Color.Red;
        this.txtGenelAraTop.Location = new System.Drawing.Point(606, 42);
        this.txtGenelAraTop.Name = "txtGenelAraTop";
        this.txtGenelAraTop.ReadOnly = true;
        this.txtGenelAraTop.Size = new System.Drawing.Size(125, 29);
        this.txtGenelAraTop.TabIndex = 5;
        this.txtGenelAraTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // txtTutar
        // 
        this.txtTutar.BackColor = System.Drawing.Color.White;
        this.txtTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.txtTutar.ForeColor = System.Drawing.Color.Red;
        this.txtTutar.Location = new System.Drawing.Point(391, 108);
        this.txtTutar.Name = "txtTutar";
        this.txtTutar.ReadOnly = true;
        this.txtTutar.Size = new System.Drawing.Size(130, 22);
        this.txtTutar.TabIndex = 3;
        this.txtTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // label24
        // 
        this.label24.AutoSize = true;
        this.label24.Location = new System.Drawing.Point(603, 20);
        this.label24.Margin = new System.Windows.Forms.Padding(0);
        this.label24.Name = "label24";
        this.label24.Size = new System.Drawing.Size(61, 13);
        this.label24.TabIndex = 35;
        this.label24.Text = "Ara Toplam";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(12, 92);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(36, 13);
        this.label4.TabIndex = 90;
        this.label4.Text = "Miktar";
        // 
        // txtSatisFiyat
        // 
        this.txtSatisFiyat.Location = new System.Drawing.Point(254, 108);
        this.txtSatisFiyat.Name = "txtSatisFiyat";
        this.txtSatisFiyat.Size = new System.Drawing.Size(131, 20);
        this.txtSatisFiyat.TabIndex = 2;
        this.txtSatisFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        this.txtSatisFiyat.TextChanged += new System.EventHandler(this.txtSatisFiyat_TextChanged);
        this.txtSatisFiyat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSatisFiyat_KeyDown);
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(251, 92);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(55, 13);
        this.label3.TabIndex = 89;
        this.label3.Text = "Satış Fiyat";
        // 
        // txtBarkod
        // 
        this.txtBarkod.Location = new System.Drawing.Point(101, 108);
        this.txtBarkod.Name = "txtBarkod";
        this.txtBarkod.Size = new System.Drawing.Size(133, 20);
        this.txtBarkod.TabIndex = 1;
        this.txtBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarkod_KeyDown);
        this.txtBarkod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBarkod_KeyUp);
        this.txtBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarkod_KeyPress);
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(98, 92);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(41, 13);
        this.label2.TabIndex = 88;
        this.label2.Text = "Barkod";
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.dataGridView1);
        this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.groupBox1.Location = new System.Drawing.Point(0, 205);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(990, 323);
        this.groupBox1.TabIndex = 4;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "KalemListesi";
        // 
        // dataGridView1
        // 
        this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
        this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clBarkod,
            this.clStokKodu,
            this.clStokAdi,
            this.clFiyat,
            this.clMiktar,
            this.clId,
            this.clTutar});
        this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dataGridView1.GridColor = System.Drawing.SystemColors.Desktop;
        this.dataGridView1.Location = new System.Drawing.Point(3, 16);
        this.dataGridView1.MultiSelect = false;
        this.dataGridView1.Name = "dataGridView1";
        this.dataGridView1.ReadOnly = true;
        this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        this.dataGridView1.RowHeadersVisible = false;
        this.dataGridView1.RowHeadersWidth = 21;
        this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
        this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
        this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
        this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dataGridView1.Size = new System.Drawing.Size(984, 304);
        this.dataGridView1.TabIndex = 1001;
        this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
        // 
        // clBarkod
        // 
        this.clBarkod.DataPropertyName = "Barkod";
        this.clBarkod.HeaderText = "Barkod";
        this.clBarkod.Name = "clBarkod";
        this.clBarkod.ReadOnly = true;
        this.clBarkod.Width = 130;
        // 
        // clStokKodu
        // 
        this.clStokKodu.DataPropertyName = "StokKodu";
        this.clStokKodu.HeaderText = "StokKodu";
        this.clStokKodu.Name = "clStokKodu";
        this.clStokKodu.ReadOnly = true;
        this.clStokKodu.Width = 150;
        // 
        // clStokAdi
        // 
        this.clStokAdi.DataPropertyName = "StokAdi";
        this.clStokAdi.HeaderText = "StokAd";
        this.clStokAdi.Name = "clStokAdi";
        this.clStokAdi.ReadOnly = true;
        this.clStokAdi.Width = 320;
        // 
        // clFiyat
        // 
        this.clFiyat.DataPropertyName = "Fiyat";
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        this.clFiyat.DefaultCellStyle = dataGridViewCellStyle4;
        this.clFiyat.HeaderText = "Fiyat";
        this.clFiyat.Name = "clFiyat";
        this.clFiyat.ReadOnly = true;
        this.clFiyat.Width = 120;
        // 
        // clMiktar
        // 
        this.clMiktar.DataPropertyName = "Miktar";
        dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        this.clMiktar.DefaultCellStyle = dataGridViewCellStyle5;
        this.clMiktar.HeaderText = "Miktar";
        this.clMiktar.Name = "clMiktar";
        this.clMiktar.ReadOnly = true;
        this.clMiktar.Width = 120;
        // 
        // clId
        // 
        this.clId.DataPropertyName = "Id";
        this.clId.HeaderText = "Id";
        this.clId.Name = "clId";
        this.clId.ReadOnly = true;
        this.clId.Visible = false;
        this.clId.Width = 41;
        // 
        // clTutar
        // 
        this.clTutar.DataPropertyName = "Tutar";
        dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        dataGridViewCellStyle6.Format = "F2";
        dataGridViewCellStyle6.NullValue = null;
        this.clTutar.DefaultCellStyle = dataGridViewCellStyle6;
        this.clTutar.HeaderText = "Tutar";
        this.clTutar.Name = "clTutar";
        this.clTutar.ReadOnly = true;
        this.clTutar.Width = 140;
        // 
        // btnRehber
        // 
        this.btnRehber.Location = new System.Drawing.Point(231, 106);
        this.btnRehber.Name = "btnRehber";
        this.btnRehber.Size = new System.Drawing.Size(21, 23);
        this.btnRehber.TabIndex = 99;
        this.btnRehber.Text = "...";
        this.btnRehber.UseVisualStyleBackColor = true;
        this.btnRehber.Click += new System.EventHandler(this.btnRehber_Click);
        // 
        // frmDirektSatis
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.ClientSize = new System.Drawing.Size(990, 583);
        this.Controls.Add(this.groupBox1);
        this.Controls.Add(this.groupBox2);
        this.Controls.Add(this.toolStrip1);
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.KeyPreview = true;
        this.Name = "frmDirektSatis";
        this.Text = "DirektSatis";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDirektSatis_FormClosing);
        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDirektSatis_KeyDown);
        this.toolStrip1.ResumeLayout(false);
        this.toolStrip1.PerformLayout();
        this.groupBox2.ResumeLayout(false);
        this.groupBox2.PerformLayout();
        this.groupBox1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.ComboBox cmboxKasaKodu;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtTutar;
    private System.Windows.Forms.TextBox txtGenelGenelTop;
    private System.Windows.Forms.Label label22;
    private System.Windows.Forms.TextBox txtGenelTopKdv;
    private System.Windows.Forms.Label label23;
    private System.Windows.Forms.TextBox txtGenelAraTop;
    private System.Windows.Forms.Label label24;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.ToolStripButton tsbtnKalemKaydet;
    private System.Windows.Forms.ToolStripButton tsbtnKalemSil;
    private System.Windows.Forms.ToolStripButton tsbtnKasayaAktar;
    private System.Windows.Forms.ToolStripButton tsbtnVeresiye;
    private System.Windows.Forms.ToolStripButton tsbtnKrediKarti;
    private System.Windows.Forms.ToolStripButton tsbtnSatisiptal;
    private System.Windows.Forms.TextBox txtMiktar;
    private System.Windows.Forms.ToolStripButton tsbtnKapat;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button btnListe;
    private System.Windows.Forms.ComboBox cmbDizayn;
    private System.Windows.Forms.CheckBox chbFaturaBas;
    private System.Windows.Forms.ToolStripButton tsbtnYeniKayit;
    private System.Windows.Forms.DataGridViewTextBoxColumn clBarkod;
    private System.Windows.Forms.DataGridViewTextBoxColumn clStokKodu;
    private System.Windows.Forms.DataGridViewTextBoxColumn clStokAdi;
    private System.Windows.Forms.DataGridViewTextBoxColumn clFiyat;
    private System.Windows.Forms.DataGridViewTextBoxColumn clMiktar;
    private System.Windows.Forms.DataGridViewTextBoxColumn clId;
    private System.Windows.Forms.DataGridViewTextBoxColumn clTutar;
    private System.Windows.Forms.Button btnRehber;
    public System.Windows.Forms.TextBox txtSatisFiyat;
    public System.Windows.Forms.TextBox txtBarkod;
    public System.Windows.Forms.Label labSecilenUrun;
  }
}