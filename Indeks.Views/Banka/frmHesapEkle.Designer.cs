namespace Indeks.Views
{
  partial class frmHesapEkle
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHesapEkle));
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        this.toolStrip1 = new System.Windows.Forms.ToolStrip();
        this.tsbtnKaydet = new System.Windows.Forms.ToolStripButton();
        this.tsbtnSil = new System.Windows.Forms.ToolStripButton();
        this.tsbtnYeni = new System.Windows.Forms.ToolStripButton();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.cmbParaBirimi = new System.Windows.Forms.ComboBox();
        this.cmbBankaListe = new System.Windows.Forms.ComboBox();
        this.label6 = new System.Windows.Forms.Label();
        this.txtSubeAdi = new System.Windows.Forms.TextBox();
        this.label4 = new System.Windows.Forms.Label();
        this.txtHesapSahip = new System.Windows.Forms.TextBox();
        this.label3 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.txtHesapNo = new System.Windows.Forms.TextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.dataGridView1 = new System.Windows.Forms.DataGridView();
        this.clHesapNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clBankaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clHesapSahibi = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clSubeAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clParaBirimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
        this.toolStrip1.SuspendLayout();
        this.groupBox1.SuspendLayout();
        this.groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        this.SuspendLayout();
        // 
        // toolStrip1
        // 
        this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnKaydet,
            this.tsbtnSil,
            this.tsbtnYeni,
            this.toolStripButton1});
        this.toolStrip1.Location = new System.Drawing.Point(0, 0);
        this.toolStrip1.Name = "toolStrip1";
        this.toolStrip1.Size = new System.Drawing.Size(778, 39);
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
        this.tsbtnYeni.Size = new System.Drawing.Size(78, 36);
        this.tsbtnYeni.Text = "Yeni(F3)";
        this.tsbtnYeni.Click += new System.EventHandler(this.tsbtnYeni_Click);
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.cmbParaBirimi);
        this.groupBox1.Controls.Add(this.cmbBankaListe);
        this.groupBox1.Controls.Add(this.label6);
        this.groupBox1.Controls.Add(this.txtSubeAdi);
        this.groupBox1.Controls.Add(this.label4);
        this.groupBox1.Controls.Add(this.txtHesapSahip);
        this.groupBox1.Controls.Add(this.label3);
        this.groupBox1.Controls.Add(this.label2);
        this.groupBox1.Controls.Add(this.txtHesapNo);
        this.groupBox1.Controls.Add(this.label1);
        this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
        this.groupBox1.Location = new System.Drawing.Point(0, 39);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(778, 159);
        this.groupBox1.TabIndex = 1;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Hesap";
        // 
        // cmbParaBirimi
        // 
        this.cmbParaBirimi.FormattingEnabled = true;
        this.cmbParaBirimi.Items.AddRange(new object[] {
            "TL",
            "USD",
            "EUR"});
        this.cmbParaBirimi.Location = new System.Drawing.Point(91, 125);
        this.cmbParaBirimi.Name = "cmbParaBirimi";
        this.cmbParaBirimi.Size = new System.Drawing.Size(133, 21);
        this.cmbParaBirimi.TabIndex = 5;
        // 
        // cmbBankaListe
        // 
        this.cmbBankaListe.FormattingEnabled = true;
        this.cmbBankaListe.Location = new System.Drawing.Point(92, 44);
        this.cmbBankaListe.Name = "cmbBankaListe";
        this.cmbBankaListe.Size = new System.Drawing.Size(133, 21);
        this.cmbBankaListe.TabIndex = 2;
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Location = new System.Drawing.Point(12, 125);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(56, 13);
        this.label6.TabIndex = 12;
        this.label6.Text = "Para Birimi";
        // 
        // txtSubeAdi
        // 
        this.txtSubeAdi.Location = new System.Drawing.Point(92, 97);
        this.txtSubeAdi.Name = "txtSubeAdi";
        this.txtSubeAdi.Size = new System.Drawing.Size(133, 20);
        this.txtSubeAdi.TabIndex = 4;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(12, 97);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(50, 13);
        this.label4.TabIndex = 10;
        this.label4.Text = "Şube Adı";
        // 
        // txtHesapSahip
        // 
        this.txtHesapSahip.Location = new System.Drawing.Point(92, 70);
        this.txtHesapSahip.Name = "txtHesapSahip";
        this.txtHesapSahip.Size = new System.Drawing.Size(133, 20);
        this.txtHesapSahip.TabIndex = 3;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(12, 70);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(70, 13);
        this.label3.TabIndex = 9;
        this.label3.Text = "Hesap Sahibi";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(12, 44);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(56, 13);
        this.label2.TabIndex = 8;
        this.label2.Text = "Banka Adı";
        // 
        // txtHesapNo
        // 
        this.txtHesapNo.Location = new System.Drawing.Point(92, 16);
        this.txtHesapNo.Name = "txtHesapNo";
        this.txtHesapNo.Size = new System.Drawing.Size(133, 20);
        this.txtHesapNo.TabIndex = 1;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(12, 16);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(55, 13);
        this.label1.TabIndex = 7;
        this.label1.Text = "Hesap No";
        // 
        // groupBox2
        // 
        this.groupBox2.Controls.Add(this.dataGridView1);
        this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.groupBox2.Location = new System.Drawing.Point(0, 198);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(778, 262);
        this.groupBox2.TabIndex = 2;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "Hesap Listesi";
        // 
        // dataGridView1
        // 
        this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
        this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
        this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
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
            this.clBankaAdi,
            this.clHesapSahibi,
            this.clSubeAdi,
            this.clParaBirimi,
            this.clId});
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
        this.dataGridView1.Size = new System.Drawing.Size(772, 243);
        this.dataGridView1.TabIndex = 1000;
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
        // clBankaAdi
        // 
        this.clBankaAdi.DataPropertyName = "BankaAdi";
        this.clBankaAdi.HeaderText = "BankaAdı";
        this.clBankaAdi.Name = "clBankaAdi";
        this.clBankaAdi.ReadOnly = true;
        this.clBankaAdi.Width = 78;
        // 
        // clHesapSahibi
        // 
        this.clHesapSahibi.DataPropertyName = "HesapSahibi";
        this.clHesapSahibi.HeaderText = "HesapSahibi";
        this.clHesapSahibi.Name = "clHesapSahibi";
        this.clHesapSahibi.ReadOnly = true;
        this.clHesapSahibi.Width = 92;
        // 
        // clSubeAdi
        // 
        this.clSubeAdi.DataPropertyName = "SubeAdi";
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        this.clSubeAdi.DefaultCellStyle = dataGridViewCellStyle2;
        this.clSubeAdi.HeaderText = "ŞubeAdı";
        this.clSubeAdi.Name = "clSubeAdi";
        this.clSubeAdi.ReadOnly = true;
        this.clSubeAdi.Width = 72;
        // 
        // clParaBirimi
        // 
        this.clParaBirimi.DataPropertyName = "ParaBirimi";
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        this.clParaBirimi.DefaultCellStyle = dataGridViewCellStyle3;
        this.clParaBirimi.HeaderText = "ParaBirimi";
        this.clParaBirimi.Name = "clParaBirimi";
        this.clParaBirimi.ReadOnly = true;
        this.clParaBirimi.Width = 78;
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
        // frmHesapEkle
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.ClientSize = new System.Drawing.Size(778, 460);
        this.Controls.Add(this.groupBox2);
        this.Controls.Add(this.groupBox1);
        this.Controls.Add(this.toolStrip1);
        this.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.KeyPreview = true;
        this.Name = "frmHesapEkle";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "HesapEkle";
        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmHesapEkle_KeyDown);
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
    private System.Windows.Forms.TextBox txtSubeAdi;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtHesapSahip;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtHesapNo;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.ComboBox cmbBankaListe;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ComboBox cmbParaBirimi;
    private System.Windows.Forms.DataGridViewTextBoxColumn clHesapNo;
    private System.Windows.Forms.DataGridViewTextBoxColumn clBankaAdi;
    private System.Windows.Forms.DataGridViewTextBoxColumn clHesapSahibi;
    private System.Windows.Forms.DataGridViewTextBoxColumn clSubeAdi;
    private System.Windows.Forms.DataGridViewTextBoxColumn clParaBirimi;
    private System.Windows.Forms.DataGridViewTextBoxColumn clId;
    private System.Windows.Forms.ToolStripButton toolStripButton1;
  }
}