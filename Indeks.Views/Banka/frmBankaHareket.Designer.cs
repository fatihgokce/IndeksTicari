namespace Indeks.Views
{
  partial class frmBankaHareket
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankaHareket));
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        this.toolStrip1 = new System.Windows.Forms.ToolStrip();
        this.tsbtnKaydet = new System.Windows.Forms.ToolStripButton();
        this.tsbtnSil = new System.Windows.Forms.ToolStripButton();
        this.tsbtnYeni = new System.Windows.Forms.ToolStripButton();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.btnCariRehber = new System.Windows.Forms.Button();
        this.txtCariKodu = new IndeksControl.AutoCompleteTextBox();
        this.cmbKasaKodu = new System.Windows.Forms.ComboBox();
        this.labCariKasaKodu = new System.Windows.Forms.Label();
        this.txtAciklama = new System.Windows.Forms.TextBox();
        this.label5 = new System.Windows.Forms.Label();
        this.txtTutar = new System.Windows.Forms.TextBox();
        this.txtDekontNo = new System.Windows.Forms.TextBox();
        this.dateTarih = new System.Windows.Forms.DateTimePicker();
        this.label4 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.txtHesapNo = new IndeksControl.AutoCompleteTextBox();
        this.btnRehber = new System.Windows.Forms.Button();
        this.label1 = new System.Windows.Forms.Label();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.dataGridView1 = new System.Windows.Forms.DataGridView();
        this.clHesapNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clDekontNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clKasaKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clCariKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clCariHarId = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clKasaHarId = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.tsbtnKapat = new System.Windows.Forms.ToolStripButton();
        this.toolStrip1.SuspendLayout();
        this.groupBox1.SuspendLayout();
        this.groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        this.SuspendLayout();
        // 
        // toolStrip1
        // 
        this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnKaydet,
            this.tsbtnSil,
            this.tsbtnYeni,
            this.tsbtnKapat});
        this.toolStrip1.Location = new System.Drawing.Point(0, 0);
        this.toolStrip1.Name = "toolStrip1";
        this.toolStrip1.Size = new System.Drawing.Size(695, 39);
        this.toolStrip1.TabIndex = 0;
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
        // tsbtnYeni
        // 
        this.tsbtnYeni.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnYeni.Image")));
        this.tsbtnYeni.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.tsbtnYeni.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.tsbtnYeni.Name = "tsbtnYeni";
        this.tsbtnYeni.Size = new System.Drawing.Size(104, 36);
        this.tsbtnYeni.Text = "YeniKayıt(F3)";
        this.tsbtnYeni.Click += new System.EventHandler(this.tsbtnYeni_Click);
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.btnCariRehber);
        this.groupBox1.Controls.Add(this.txtCariKodu);
        this.groupBox1.Controls.Add(this.cmbKasaKodu);
        this.groupBox1.Controls.Add(this.labCariKasaKodu);
        this.groupBox1.Controls.Add(this.txtAciklama);
        this.groupBox1.Controls.Add(this.label5);
        this.groupBox1.Controls.Add(this.txtTutar);
        this.groupBox1.Controls.Add(this.txtDekontNo);
        this.groupBox1.Controls.Add(this.dateTarih);
        this.groupBox1.Controls.Add(this.label4);
        this.groupBox1.Controls.Add(this.label3);
        this.groupBox1.Controls.Add(this.label2);
        this.groupBox1.Controls.Add(this.txtHesapNo);
        this.groupBox1.Controls.Add(this.btnRehber);
        this.groupBox1.Controls.Add(this.label1);
        this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
        this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
        this.groupBox1.Location = new System.Drawing.Point(0, 39);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(695, 233);
        this.groupBox1.TabIndex = 1;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Hesap Hareket";
        // 
        // btnCariRehber
        // 
        this.btnCariRehber.Location = new System.Drawing.Point(448, 140);
        this.btnCariRehber.Name = "btnCariRehber";
        this.btnCariRehber.Size = new System.Drawing.Size(35, 23);
        this.btnCariRehber.TabIndex = 8;
        this.btnCariRehber.Text = "...";
        this.btnCariRehber.UseVisualStyleBackColor = true;
        this.btnCariRehber.Click += new System.EventHandler(this.btnCariRehber_Click);
        // 
        // txtCariKodu
        // 
        this.txtCariKodu.Ayirac = "";
        this.txtCariKodu.AyracBoslukKullan = true;
        this.txtCariKodu.DataSource = null;
        this.txtCariKodu.ListForeColor = System.Drawing.Color.Empty;
        this.txtCariKodu.ListItemColor = System.Drawing.Color.OrangeRed;
        this.txtCariKodu.Location = new System.Drawing.Point(276, 140);
        this.txtCariKodu.Name = "txtCariKodu";
        this.txtCariKodu.NextTabControlName = "txtAciklama";
        this.txtCariKodu.Size = new System.Drawing.Size(166, 20);
        this.txtCariKodu.TabIndex = 5;
        this.txtCariKodu.WidthAutoComplete = 200;
        this.txtCariKodu.WidthKod = 15;
        // 
        // cmbKasaKodu
        // 
        this.cmbKasaKodu.FormattingEnabled = true;
        this.cmbKasaKodu.Location = new System.Drawing.Point(88, 139);
        this.cmbKasaKodu.Name = "cmbKasaKodu";
        this.cmbKasaKodu.Size = new System.Drawing.Size(166, 21);
        this.cmbKasaKodu.TabIndex = 4;
        // 
        // labCariKasaKodu
        // 
        this.labCariKasaKodu.AutoSize = true;
        this.labCariKasaKodu.Location = new System.Drawing.Point(12, 139);
        this.labCariKasaKodu.Name = "labCariKasaKodu";
        this.labCariKasaKodu.Size = new System.Drawing.Size(56, 13);
        this.labCariKasaKodu.TabIndex = 22;
        this.labCariKasaKodu.Text = "KasaKodu";
        // 
        // txtAciklama
        // 
        this.txtAciklama.Location = new System.Drawing.Point(88, 175);
        this.txtAciklama.Multiline = true;
        this.txtAciklama.Name = "txtAciklama";
        this.txtAciklama.Size = new System.Drawing.Size(233, 36);
        this.txtAciklama.TabIndex = 6;
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(12, 175);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(50, 13);
        this.label5.TabIndex = 21;
        this.label5.Text = "Açıklama";
        // 
        // txtTutar
        // 
        this.txtTutar.Location = new System.Drawing.Point(88, 109);
        this.txtTutar.Name = "txtTutar";
        this.txtTutar.Size = new System.Drawing.Size(166, 20);
        this.txtTutar.TabIndex = 3;
        // 
        // txtDekontNo
        // 
        this.txtDekontNo.Location = new System.Drawing.Point(88, 83);
        this.txtDekontNo.Name = "txtDekontNo";
        this.txtDekontNo.Size = new System.Drawing.Size(166, 20);
        this.txtDekontNo.TabIndex = 2;
        // 
        // dateTarih
        // 
        this.dateTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateTarih.Location = new System.Drawing.Point(88, 53);
        this.dateTarih.Name = "dateTarih";
        this.dateTarih.Size = new System.Drawing.Size(166, 20);
        this.dateTarih.TabIndex = 1;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(12, 109);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(32, 13);
        this.label4.TabIndex = 17;
        this.label4.Text = "Tutar";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(12, 83);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(59, 13);
        this.label3.TabIndex = 16;
        this.label3.Text = "Dekont No";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(12, 53);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(31, 13);
        this.label2.TabIndex = 15;
        this.label2.Text = "Tarih";
        // 
        // txtHesapNo
        // 
        this.txtHesapNo.Ayirac = null;
        this.txtHesapNo.AyracBoslukKullan = false;
        this.txtHesapNo.DataSource = null;
        this.txtHesapNo.ListForeColor = System.Drawing.Color.Empty;
        this.txtHesapNo.ListItemColor = System.Drawing.Color.OrangeRed;
        this.txtHesapNo.Location = new System.Drawing.Point(88, 26);
        this.txtHesapNo.Name = "txtHesapNo";
        this.txtHesapNo.NextTabControlName = "dateTarih";
        this.txtHesapNo.Size = new System.Drawing.Size(166, 20);
        this.txtHesapNo.TabIndex = 0;
        this.txtHesapNo.WidthAutoComplete = 166;
        this.txtHesapNo.WidthKod = 0;
        // 
        // btnRehber
        // 
        this.btnRehber.Location = new System.Drawing.Point(260, 23);
        this.btnRehber.Name = "btnRehber";
        this.btnRehber.Size = new System.Drawing.Size(35, 23);
        this.btnRehber.TabIndex = 0;
        this.btnRehber.Text = "...";
        this.btnRehber.UseVisualStyleBackColor = true;
        this.btnRehber.Click += new System.EventHandler(this.btnRehber_Click);
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(12, 26);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(55, 13);
        this.label1.TabIndex = 7;
        this.label1.Text = "Hesap No";
        // 
        // groupBox2
        // 
        this.groupBox2.Controls.Add(this.dataGridView1);
        this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
        this.groupBox2.Location = new System.Drawing.Point(0, 272);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(695, 249);
        this.groupBox2.TabIndex = 2;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "Hareket Liste";
        // 
        // dataGridView1
        // 
        this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
        this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
        this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clHesapNo,
            this.clTarih,
            this.clDekontNo,
            this.clTutar,
            this.clKasaKod,
            this.clCariKodu,
            this.clAciklama,
            this.clId,
            this.clCariHarId,
            this.clKasaHarId});
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
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
        this.dataGridView1.Size = new System.Drawing.Size(689, 230);
        this.dataGridView1.TabIndex = 1001;
        this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
        // 
        // clHesapNo
        // 
        this.clHesapNo.DataPropertyName = "HesapNo";
        this.clHesapNo.HeaderText = "HesapNo";
        this.clHesapNo.Name = "clHesapNo";
        this.clHesapNo.ReadOnly = true;
        this.clHesapNo.Width = 77;
        // 
        // clTarih
        // 
        this.clTarih.DataPropertyName = "Tarih";
        this.clTarih.HeaderText = "Tarih";
        this.clTarih.Name = "clTarih";
        this.clTarih.ReadOnly = true;
        this.clTarih.Width = 56;
        // 
        // clDekontNo
        // 
        this.clDekontNo.DataPropertyName = "DekontNo";
        this.clDekontNo.HeaderText = "DekontNo";
        this.clDekontNo.Name = "clDekontNo";
        this.clDekontNo.ReadOnly = true;
        this.clDekontNo.Width = 81;
        // 
        // clTutar
        // 
        this.clTutar.DataPropertyName = "Tutar";
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        this.clTutar.DefaultCellStyle = dataGridViewCellStyle2;
        this.clTutar.HeaderText = "Tutar";
        this.clTutar.Name = "clTutar";
        this.clTutar.ReadOnly = true;
        this.clTutar.Width = 57;
        // 
        // clKasaKod
        // 
        this.clKasaKod.DataPropertyName = "KasaKod";
        this.clKasaKod.HeaderText = "KasaKodu";
        this.clKasaKod.Name = "clKasaKod";
        this.clKasaKod.ReadOnly = true;
        this.clKasaKod.Width = 81;
        // 
        // clCariKodu
        // 
        this.clCariKodu.DataPropertyName = "CariKod";
        this.clCariKodu.HeaderText = "CariKodu";
        this.clCariKodu.Name = "clCariKodu";
        this.clCariKodu.ReadOnly = true;
        this.clCariKodu.Width = 75;
        // 
        // clAciklama
        // 
        this.clAciklama.DataPropertyName = "Aciklama";
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        this.clAciklama.DefaultCellStyle = dataGridViewCellStyle3;
        this.clAciklama.HeaderText = "Açıklama";
        this.clAciklama.Name = "clAciklama";
        this.clAciklama.ReadOnly = true;
        this.clAciklama.Width = 75;
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
        // clCariHarId
        // 
        this.clCariHarId.DataPropertyName = "CariHarId";
        this.clCariHarId.HeaderText = "CariHarId";
        this.clCariHarId.Name = "clCariHarId";
        this.clCariHarId.ReadOnly = true;
        this.clCariHarId.Visible = false;
        this.clCariHarId.Width = 76;
        // 
        // clKasaHarId
        // 
        this.clKasaHarId.DataPropertyName = "KasaHarId";
        this.clKasaHarId.HeaderText = "KasaHarId";
        this.clKasaHarId.Name = "clKasaHarId";
        this.clKasaHarId.ReadOnly = true;
        this.clKasaHarId.Visible = false;
        this.clKasaHarId.Width = 82;
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
        // frmBankaHareket
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.ClientSize = new System.Drawing.Size(695, 521);
        this.Controls.Add(this.groupBox2);
        this.Controls.Add(this.groupBox1);
        this.Controls.Add(this.toolStrip1);
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.KeyPreview = true;
        this.Name = "frmBankaHareket";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "frmBankaHareket";
        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBankaHareket_KeyDown);
        this.toolStrip1.ResumeLayout(false);
        this.toolStrip1.PerformLayout();
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.groupBox2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton tsbtnKaydet;
    private System.Windows.Forms.ToolStripButton tsbtnSil;
    private System.Windows.Forms.ToolStripButton tsbtnYeni;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnRehber;
    public IndeksControl.AutoCompleteTextBox txtHesapNo;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.TextBox txtTutar;
    private System.Windows.Forms.TextBox txtDekontNo;
    private System.Windows.Forms.DateTimePicker dateTarih;
    private System.Windows.Forms.TextBox txtAciklama;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox cmbKasaKodu;
    private System.Windows.Forms.Label labCariKasaKodu;
    private System.Windows.Forms.Button btnCariRehber;
    private System.Windows.Forms.DataGridViewTextBoxColumn clHesapNo;
    private System.Windows.Forms.DataGridViewTextBoxColumn clTarih;
    private System.Windows.Forms.DataGridViewTextBoxColumn clDekontNo;
    private System.Windows.Forms.DataGridViewTextBoxColumn clTutar;
    private System.Windows.Forms.DataGridViewTextBoxColumn clKasaKod;
    private System.Windows.Forms.DataGridViewTextBoxColumn clCariKodu;
    private System.Windows.Forms.DataGridViewTextBoxColumn clAciklama;
    private System.Windows.Forms.DataGridViewTextBoxColumn clId;
    private System.Windows.Forms.DataGridViewTextBoxColumn clCariHarId;
    private System.Windows.Forms.DataGridViewTextBoxColumn clKasaHarId;
    public IndeksControl.AutoCompleteTextBox txtCariKodu;
    private System.Windows.Forms.ToolStripButton tsbtnKapat;
  }
}