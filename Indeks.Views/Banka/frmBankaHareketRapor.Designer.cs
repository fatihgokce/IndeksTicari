namespace Indeks.Views
{
  partial class frmBankaHareketRapor
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankaHareketRapor));
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.btnPrint = new System.Windows.Forms.Button();
        this.btnRaporla = new System.Windows.Forms.Button();
        this.groupBox4 = new System.Windows.Forms.GroupBox();
        this.cmboxHareketTipi = new System.Windows.Forms.ComboBox();
        this.label8 = new System.Windows.Forms.Label();
        this.dateTimeFinish = new System.Windows.Forms.DateTimePicker();
        this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
        this.label7 = new System.Windows.Forms.Label();
        this.label5 = new System.Windows.Forms.Label();
        this.groupBox3 = new System.Windows.Forms.GroupBox();
        this.btnHesapRehber = new System.Windows.Forms.Button();
        this.txtParaBirimi = new System.Windows.Forms.TextBox();
        this.txtBankaAdi = new System.Windows.Forms.TextBox();
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
        this.groupBox5 = new System.Windows.Forms.GroupBox();
        this.statusStrip1 = new System.Windows.Forms.StatusStrip();
        this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
        this.tslabToplamTutar = new System.Windows.Forms.ToolStripStatusLabel();
        this.clTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clHareketTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clDekontNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clCariKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clFisNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.groupBox1.SuspendLayout();
        this.groupBox4.SuspendLayout();
        this.groupBox3.SuspendLayout();
        this.groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        this.groupBox5.SuspendLayout();
        this.statusStrip1.SuspendLayout();
        this.SuspendLayout();
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.btnPrint);
        this.groupBox1.Controls.Add(this.btnRaporla);
        this.groupBox1.Controls.Add(this.groupBox4);
        this.groupBox1.Controls.Add(this.groupBox3);
        this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
        this.groupBox1.Location = new System.Drawing.Point(0, 0);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(838, 211);
        this.groupBox1.TabIndex = 0;
        this.groupBox1.TabStop = false;
        // 
        // btnPrint
        // 
        this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
        this.btnPrint.Location = new System.Drawing.Point(414, 177);
        this.btnPrint.Name = "btnPrint";
        this.btnPrint.Size = new System.Drawing.Size(49, 31);
        this.btnPrint.TabIndex = 3;
        this.btnPrint.UseVisualStyleBackColor = true;
        this.btnPrint.Visible = false;
        this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
        // 
        // btnRaporla
        // 
        this.btnRaporla.Location = new System.Drawing.Point(320, 147);
        this.btnRaporla.Name = "btnRaporla";
        this.btnRaporla.Size = new System.Drawing.Size(88, 61);
        this.btnRaporla.TabIndex = 2;
        this.btnRaporla.Text = "Raporla";
        this.btnRaporla.UseVisualStyleBackColor = true;
        this.btnRaporla.Click += new System.EventHandler(this.btnRaporla_Click);
        // 
        // groupBox4
        // 
        this.groupBox4.Controls.Add(this.cmboxHareketTipi);
        this.groupBox4.Controls.Add(this.label8);
        this.groupBox4.Controls.Add(this.dateTimeFinish);
        this.groupBox4.Controls.Add(this.dateTimeStart);
        this.groupBox4.Controls.Add(this.label7);
        this.groupBox4.Controls.Add(this.label5);
        this.groupBox4.Location = new System.Drawing.Point(320, 32);
        this.groupBox4.Name = "groupBox4";
        this.groupBox4.Size = new System.Drawing.Size(323, 96);
        this.groupBox4.TabIndex = 1;
        this.groupBox4.TabStop = false;
        this.groupBox4.Text = "İşlemBilgileri";
        // 
        // cmboxHareketTipi
        // 
        this.cmboxHareketTipi.FormattingEnabled = true;
        this.cmboxHareketTipi.Items.AddRange(new object[] {
            "Hepsi",
            "ParaYatirma(+)",
            "ParaCekme(-)",
            "GelenHavale(+)",
            "GidenHavale(-)",
            "ÇekÖdeme",
            "ÇekTahsil",
            "SenetTahsil",
            "KrediKarti"});
        this.cmboxHareketTipi.Location = new System.Drawing.Point(81, 51);
        this.cmboxHareketTipi.Name = "cmboxHareketTipi";
        this.cmboxHareketTipi.Size = new System.Drawing.Size(236, 21);
        this.cmboxHareketTipi.TabIndex = 24;
        this.cmboxHareketTipi.Text = "Hepsi";
        // 
        // label8
        // 
        this.label8.AutoSize = true;
        this.label8.Location = new System.Drawing.Point(189, 23);
        this.label8.Name = "label8";
        this.label8.Size = new System.Drawing.Size(17, 13);
        this.label8.TabIndex = 23;
        this.label8.Text = "ile";
        // 
        // dateTimeFinish
        // 
        this.dateTimeFinish.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateTimeFinish.Location = new System.Drawing.Point(215, 23);
        this.dateTimeFinish.Name = "dateTimeFinish";
        this.dateTimeFinish.Size = new System.Drawing.Size(102, 20);
        this.dateTimeFinish.TabIndex = 22;
        // 
        // dateTimeStart
        // 
        this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateTimeStart.Location = new System.Drawing.Point(81, 21);
        this.dateTimeStart.Name = "dateTimeStart";
        this.dateTimeStart.Size = new System.Drawing.Size(102, 20);
        this.dateTimeStart.TabIndex = 21;
        // 
        // label7
        // 
        this.label7.AutoSize = true;
        this.label7.Location = new System.Drawing.Point(6, 51);
        this.label7.Name = "label7";
        this.label7.Size = new System.Drawing.Size(67, 13);
        this.label7.TabIndex = 20;
        this.label7.Text = "HareketTürü";
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(6, 23);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(59, 13);
        this.label5.TabIndex = 19;
        this.label5.Text = "TarihAralığı";
        // 
        // groupBox3
        // 
        this.groupBox3.Controls.Add(this.btnHesapRehber);
        this.groupBox3.Controls.Add(this.txtParaBirimi);
        this.groupBox3.Controls.Add(this.txtBankaAdi);
        this.groupBox3.Controls.Add(this.label6);
        this.groupBox3.Controls.Add(this.txtSubeAdi);
        this.groupBox3.Controls.Add(this.label4);
        this.groupBox3.Controls.Add(this.txtHesapSahip);
        this.groupBox3.Controls.Add(this.label3);
        this.groupBox3.Controls.Add(this.label2);
        this.groupBox3.Controls.Add(this.txtHesapNo);
        this.groupBox3.Controls.Add(this.label1);
        this.groupBox3.Location = new System.Drawing.Point(6, 32);
        this.groupBox3.Name = "groupBox3";
        this.groupBox3.Size = new System.Drawing.Size(308, 176);
        this.groupBox3.TabIndex = 0;
        this.groupBox3.TabStop = false;
        this.groupBox3.Text = "HesapBilgileri";
        // 
        // btnHesapRehber
        // 
        this.btnHesapRehber.Location = new System.Drawing.Point(229, 18);
        this.btnHesapRehber.Name = "btnHesapRehber";
        this.btnHesapRehber.Size = new System.Drawing.Size(35, 23);
        this.btnHesapRehber.TabIndex = 23;
        this.btnHesapRehber.Text = "...";
        this.btnHesapRehber.UseVisualStyleBackColor = true;
        this.btnHesapRehber.Click += new System.EventHandler(this.btnHesapRehber_Click);
        // 
        // txtParaBirimi
        // 
        this.txtParaBirimi.Location = new System.Drawing.Point(89, 131);
        this.txtParaBirimi.Name = "txtParaBirimi";
        this.txtParaBirimi.ReadOnly = true;
        this.txtParaBirimi.Size = new System.Drawing.Size(133, 20);
        this.txtParaBirimi.TabIndex = 16;
        // 
        // txtBankaAdi
        // 
        this.txtBankaAdi.Location = new System.Drawing.Point(89, 50);
        this.txtBankaAdi.Name = "txtBankaAdi";
        this.txtBankaAdi.ReadOnly = true;
        this.txtBankaAdi.Size = new System.Drawing.Size(133, 20);
        this.txtBankaAdi.TabIndex = 16;
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Location = new System.Drawing.Point(9, 131);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(56, 13);
        this.label6.TabIndex = 22;
        this.label6.Text = "Para Birimi";
        // 
        // txtSubeAdi
        // 
        this.txtSubeAdi.Location = new System.Drawing.Point(89, 103);
        this.txtSubeAdi.Name = "txtSubeAdi";
        this.txtSubeAdi.ReadOnly = true;
        this.txtSubeAdi.Size = new System.Drawing.Size(133, 20);
        this.txtSubeAdi.TabIndex = 16;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(9, 103);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(50, 13);
        this.label4.TabIndex = 21;
        this.label4.Text = "Şube Adı";
        // 
        // txtHesapSahip
        // 
        this.txtHesapSahip.Location = new System.Drawing.Point(89, 76);
        this.txtHesapSahip.Name = "txtHesapSahip";
        this.txtHesapSahip.ReadOnly = true;
        this.txtHesapSahip.Size = new System.Drawing.Size(133, 20);
        this.txtHesapSahip.TabIndex = 15;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(9, 76);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(70, 13);
        this.label3.TabIndex = 20;
        this.label3.Text = "Hesap Sahibi";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(9, 50);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(56, 13);
        this.label2.TabIndex = 19;
        this.label2.Text = "Banka Adı";
        // 
        // txtHesapNo
        // 
        this.txtHesapNo.Location = new System.Drawing.Point(89, 22);
        this.txtHesapNo.Name = "txtHesapNo";
        this.txtHesapNo.Size = new System.Drawing.Size(133, 20);
        this.txtHesapNo.TabIndex = 13;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(9, 22);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(55, 13);
        this.label1.TabIndex = 18;
        this.label1.Text = "Hesap No";
        // 
        // groupBox2
        // 
        this.groupBox2.Controls.Add(this.dataGridView1);
        this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.groupBox2.Location = new System.Drawing.Point(0, 211);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(838, 339);
        this.groupBox2.TabIndex = 1;
        this.groupBox2.TabStop = false;
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
            this.clTarih,
            this.clHareketTuru,
            this.clDekontNo,
            this.clCariKodu,
            this.clFisNo,
            this.clTutar,
            this.clAciklama});
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
        this.dataGridView1.Size = new System.Drawing.Size(832, 320);
        this.dataGridView1.TabIndex = 1001;
        // 
        // groupBox5
        // 
        this.groupBox5.Controls.Add(this.statusStrip1);
        this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.groupBox5.Location = new System.Drawing.Point(0, 503);
        this.groupBox5.Name = "groupBox5";
        this.groupBox5.Size = new System.Drawing.Size(838, 47);
        this.groupBox5.TabIndex = 1009;
        this.groupBox5.TabStop = false;
        // 
        // statusStrip1
        // 
        this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.tslabToplamTutar});
        this.statusStrip1.Location = new System.Drawing.Point(3, 16);
        this.statusStrip1.Name = "statusStrip1";
        this.statusStrip1.Size = new System.Drawing.Size(832, 28);
        this.statusStrip1.TabIndex = 1007;
        this.statusStrip1.Text = "statusStrip1";
        // 
        // toolStripStatusLabel2
        // 
        this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
        this.toolStripStatusLabel2.Size = new System.Drawing.Size(79, 23);
        this.toolStripStatusLabel2.Text = "Toplam Tutar";
        // 
        // tslabToplamTutar
        // 
        this.tslabToplamTutar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.tslabToplamTutar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
        this.tslabToplamTutar.Name = "tslabToplamTutar";
        this.tslabToplamTutar.Size = new System.Drawing.Size(0, 23);
        // 
        // clTarih
        // 
        this.clTarih.DataPropertyName = "Tarih";
        this.clTarih.HeaderText = "Tarih";
        this.clTarih.Name = "clTarih";
        this.clTarih.ReadOnly = true;
        this.clTarih.Width = 56;
        // 
        // clHareketTuru
        // 
        this.clHareketTuru.DataPropertyName = "HareketTuru";
        this.clHareketTuru.HeaderText = "HareketTürü";
        this.clHareketTuru.Name = "clHareketTuru";
        this.clHareketTuru.ReadOnly = true;
        this.clHareketTuru.Width = 92;
        // 
        // clDekontNo
        // 
        this.clDekontNo.DataPropertyName = "DekontNo";
        this.clDekontNo.HeaderText = "DekontNo";
        this.clDekontNo.Name = "clDekontNo";
        this.clDekontNo.ReadOnly = true;
        this.clDekontNo.Width = 81;
        // 
        // clCariKodu
        // 
        this.clCariKodu.DataPropertyName = "CariKod";
        this.clCariKodu.HeaderText = "CariKodu";
        this.clCariKodu.Name = "clCariKodu";
        this.clCariKodu.ReadOnly = true;
        this.clCariKodu.Width = 75;
        // 
        // clFisNo
        // 
        this.clFisNo.DataPropertyName = "FisNo";
        this.clFisNo.HeaderText = "FişNo";
        this.clFisNo.Name = "clFisNo";
        this.clFisNo.ReadOnly = true;
        this.clFisNo.Width = 59;
        // 
        // clTutar
        // 
        this.clTutar.DataPropertyName = "Tutar";
        dataGridViewCellStyle2.Format = "N2";
        dataGridViewCellStyle2.NullValue = null;
        this.clTutar.DefaultCellStyle = dataGridViewCellStyle2;
        this.clTutar.HeaderText = "Tutar";
        this.clTutar.Name = "clTutar";
        this.clTutar.ReadOnly = true;
        this.clTutar.Width = 57;
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
        // frmBankaHareketRapor
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.Control;
        this.ClientSize = new System.Drawing.Size(838, 550);
        this.Controls.Add(this.groupBox5);
        this.Controls.Add(this.groupBox2);
        this.Controls.Add(this.groupBox1);
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.Name = "frmBankaHareketRapor";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "BankaHareketRapor";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.groupBox1.ResumeLayout(false);
        this.groupBox4.ResumeLayout(false);
        this.groupBox4.PerformLayout();
        this.groupBox3.ResumeLayout(false);
        this.groupBox3.PerformLayout();
        this.groupBox2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        this.groupBox5.ResumeLayout(false);
        this.groupBox5.PerformLayout();
        this.statusStrip1.ResumeLayout(false);
        this.statusStrip1.PerformLayout();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    public System.Windows.Forms.TextBox txtParaBirimi;
    public System.Windows.Forms.TextBox txtBankaAdi;
    public System.Windows.Forms.TextBox txtSubeAdi;
    public System.Windows.Forms.TextBox txtHesapSahip;
    public System.Windows.Forms.TextBox txtHesapNo;
    private System.Windows.Forms.Button btnHesapRehber;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btnRaporla;
    private System.Windows.Forms.ComboBox cmboxHareketTipi;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.DateTimePicker dateTimeFinish;
    private System.Windows.Forms.DateTimePicker dateTimeStart;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button btnPrint;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    private System.Windows.Forms.ToolStripStatusLabel tslabToplamTutar;
    private System.Windows.Forms.DataGridViewTextBoxColumn clTarih;
    private System.Windows.Forms.DataGridViewTextBoxColumn clHareketTuru;
    private System.Windows.Forms.DataGridViewTextBoxColumn clDekontNo;
    private System.Windows.Forms.DataGridViewTextBoxColumn clCariKodu;
    private System.Windows.Forms.DataGridViewTextBoxColumn clFisNo;
    private System.Windows.Forms.DataGridViewTextBoxColumn clTutar;
    private System.Windows.Forms.DataGridViewTextBoxColumn clAciklama;
  }
}