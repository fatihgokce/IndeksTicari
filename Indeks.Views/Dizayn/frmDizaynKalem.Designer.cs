namespace Indeks.Views
{
  partial class frmDizaynKalem
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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.btnYeni = new System.Windows.Forms.Button();
        this.btnSil = new System.Windows.Forms.Button();
        this.btnKaydet = new System.Windows.Forms.Button();
        this.txtOndalik = new System.Windows.Forms.TextBox();
        this.label7 = new System.Windows.Forms.Label();
        this.txtUzunluk = new System.Windows.Forms.TextBox();
        this.label6 = new System.Windows.Forms.Label();
        this.txtSutun = new System.Windows.Forms.TextBox();
        this.label4 = new System.Windows.Forms.Label();
        this.txtSatir = new System.Windows.Forms.TextBox();
        this.label3 = new System.Windows.Forms.Label();
        this.txtAciklama = new System.Windows.Forms.TextBox();
        this.chkBaslik = new System.Windows.Forms.CheckBox();
        this.cmbAlanIsim = new System.Windows.Forms.ComboBox();
        this.label2 = new System.Windows.Forms.Label();
        this.cmbSahaYeri = new System.Windows.Forms.ComboBox();
        this.label1 = new System.Windows.Forms.Label();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.dataGridView1 = new System.Windows.Forms.DataGridView();
        this.clSahaYeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clAlanIsim = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clBaslikYaz = new System.Windows.Forms.DataGridViewCheckBoxColumn();
        this.clAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clSatir = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clSutun = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clUzunluk = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clOndalik = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.groupBox1.SuspendLayout();
        this.groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        this.SuspendLayout();
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.btnYeni);
        this.groupBox1.Controls.Add(this.btnSil);
        this.groupBox1.Controls.Add(this.btnKaydet);
        this.groupBox1.Controls.Add(this.txtOndalik);
        this.groupBox1.Controls.Add(this.label7);
        this.groupBox1.Controls.Add(this.txtUzunluk);
        this.groupBox1.Controls.Add(this.label6);
        this.groupBox1.Controls.Add(this.txtSutun);
        this.groupBox1.Controls.Add(this.label4);
        this.groupBox1.Controls.Add(this.txtSatir);
        this.groupBox1.Controls.Add(this.label3);
        this.groupBox1.Controls.Add(this.txtAciklama);
        this.groupBox1.Controls.Add(this.chkBaslik);
        this.groupBox1.Controls.Add(this.cmbAlanIsim);
        this.groupBox1.Controls.Add(this.label2);
        this.groupBox1.Controls.Add(this.cmbSahaYeri);
        this.groupBox1.Controls.Add(this.label1);
        this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
        this.groupBox1.Location = new System.Drawing.Point(0, 0);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(833, 167);
        this.groupBox1.TabIndex = 0;
        this.groupBox1.TabStop = false;
        // 
        // btnYeni
        // 
        this.btnYeni.BackColor = System.Drawing.SystemColors.MenuBar;
        this.btnYeni.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnYeni.ForeColor = System.Drawing.SystemColors.ControlText;
        this.btnYeni.Location = new System.Drawing.Point(171, 123);
        this.btnYeni.Name = "btnYeni";
        this.btnYeni.Size = new System.Drawing.Size(75, 28);
        this.btnYeni.TabIndex = 39;
        this.btnYeni.Text = "Yeni(F3)";
        this.btnYeni.UseVisualStyleBackColor = false;
        this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
        // 
        // btnSil
        // 
        this.btnSil.BackColor = System.Drawing.SystemColors.MenuBar;
        this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnSil.ForeColor = System.Drawing.SystemColors.ControlText;
        this.btnSil.Location = new System.Drawing.Point(90, 123);
        this.btnSil.Name = "btnSil";
        this.btnSil.Size = new System.Drawing.Size(75, 28);
        this.btnSil.TabIndex = 38;
        this.btnSil.Text = "Sil(F7)";
        this.btnSil.UseVisualStyleBackColor = false;
        this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
        // 
        // btnKaydet
        // 
        this.btnKaydet.BackColor = System.Drawing.SystemColors.MenuBar;
        this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnKaydet.ForeColor = System.Drawing.SystemColors.ControlText;
        this.btnKaydet.Location = new System.Drawing.Point(9, 123);
        this.btnKaydet.Name = "btnKaydet";
        this.btnKaydet.Size = new System.Drawing.Size(75, 28);
        this.btnKaydet.TabIndex = 37;
        this.btnKaydet.Text = "Kaydet(F5)";
        this.btnKaydet.UseVisualStyleBackColor = false;
        this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
        // 
        // txtOndalik
        // 
        this.txtOndalik.Location = new System.Drawing.Point(312, 83);
        this.txtOndalik.Name = "txtOndalik";
        this.txtOndalik.Size = new System.Drawing.Size(90, 20);
        this.txtOndalik.TabIndex = 36;
        this.txtOndalik.Text = "0";
        this.txtOndalik.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // label7
        // 
        this.label7.AutoSize = true;
        this.label7.Location = new System.Drawing.Point(309, 66);
        this.label7.Name = "label7";
        this.label7.Size = new System.Drawing.Size(43, 13);
        this.label7.TabIndex = 35;
        this.label7.Text = "Ondalık";
        // 
        // txtUzunluk
        // 
        this.txtUzunluk.Location = new System.Drawing.Point(213, 83);
        this.txtUzunluk.Name = "txtUzunluk";
        this.txtUzunluk.Size = new System.Drawing.Size(90, 20);
        this.txtUzunluk.TabIndex = 34;
        this.txtUzunluk.Text = "0";
        this.txtUzunluk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Location = new System.Drawing.Point(210, 66);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(46, 13);
        this.label6.TabIndex = 33;
        this.label6.Text = "Uzunluk";
        // 
        // txtSutun
        // 
        this.txtSutun.Location = new System.Drawing.Point(115, 83);
        this.txtSutun.Name = "txtSutun";
        this.txtSutun.Size = new System.Drawing.Size(90, 20);
        this.txtSutun.TabIndex = 30;
        this.txtSutun.Text = "0";
        this.txtSutun.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(112, 66);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(35, 13);
        this.label4.TabIndex = 29;
        this.label4.Text = "Sutun";
        // 
        // txtSatir
        // 
        this.txtSatir.Location = new System.Drawing.Point(12, 83);
        this.txtSatir.Name = "txtSatir";
        this.txtSatir.Size = new System.Drawing.Size(90, 20);
        this.txtSatir.TabIndex = 28;
        this.txtSatir.Text = "0";
        this.txtSatir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(9, 66);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(28, 13);
        this.label3.TabIndex = 27;
        this.label3.Text = "Satır";
        // 
        // txtAciklama
        // 
        this.txtAciklama.Enabled = false;
        this.txtAciklama.Location = new System.Drawing.Point(352, 32);
        this.txtAciklama.Name = "txtAciklama";
        this.txtAciklama.Size = new System.Drawing.Size(309, 20);
        this.txtAciklama.TabIndex = 26;
        // 
        // chkBaslik
        // 
        this.chkBaslik.AutoSize = true;
        this.chkBaslik.Location = new System.Drawing.Point(302, 32);
        this.chkBaslik.Name = "chkBaslik";
        this.chkBaslik.Size = new System.Drawing.Size(54, 17);
        this.chkBaslik.TabIndex = 25;
        this.chkBaslik.Text = "Başlık";
        this.chkBaslik.UseVisualStyleBackColor = true;
        this.chkBaslik.CheckedChanged += new System.EventHandler(this.chkBaslik_CheckedChanged);
        // 
        // cmbAlanIsim
        // 
        this.cmbAlanIsim.FormattingEnabled = true;
        this.cmbAlanIsim.Items.AddRange(new object[] {
            "Aciklama",
            "FaturaNo",
            "FaturaTarih",
            "FaturaSaat",
            "IrsaliyeNo",
            "SevkTarih",
            "SevkSaat",
            "CariAdSoyad",
            "CariAdres",
            "CariKod",
            "VergiDairesi",
            "VergiNumarasi",
            "CariTelefon",
            "CariBakiye"});
        this.cmbAlanIsim.Location = new System.Drawing.Point(115, 32);
        this.cmbAlanIsim.Name = "cmbAlanIsim";
        this.cmbAlanIsim.Size = new System.Drawing.Size(180, 21);
        this.cmbAlanIsim.TabIndex = 24;
        this.cmbAlanIsim.Text = "Aciklama";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(112, 16);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(49, 13);
        this.label2.TabIndex = 23;
        this.label2.Text = "Alan Isim";
        // 
        // cmbSahaYeri
        // 
        this.cmbSahaYeri.FormattingEnabled = true;
        this.cmbSahaYeri.Items.AddRange(new object[] {
            "1-Ust",
            "2-Alt",
            "3-Kalem"});
        this.cmbSahaYeri.Location = new System.Drawing.Point(9, 32);
        this.cmbSahaYeri.Name = "cmbSahaYeri";
        this.cmbSahaYeri.Size = new System.Drawing.Size(93, 21);
        this.cmbSahaYeri.TabIndex = 22;
        this.cmbSahaYeri.Text = "1-Ust";
        this.cmbSahaYeri.SelectedIndexChanged += new System.EventHandler(this.cmbSahaYeri_SelectedIndexChanged);
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(6, 16);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(53, 13);
        this.label1.TabIndex = 21;
        this.label1.Text = "Saha Yeri";
        // 
        // groupBox2
        // 
        this.groupBox2.Controls.Add(this.dataGridView1);
        this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.groupBox2.Location = new System.Drawing.Point(0, 167);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(833, 197);
        this.groupBox2.TabIndex = 1;
        this.groupBox2.TabStop = false;
        // 
        // dataGridView1
        // 
        this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
        this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
        this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSahaYeri,
            this.clAlanIsim,
            this.clBaslikYaz,
            this.clAciklama,
            this.clSatir,
            this.clSutun,
            this.clUzunluk,
            this.clOndalik,
            this.clId});
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
        this.dataGridView1.Size = new System.Drawing.Size(827, 178);
        this.dataGridView1.TabIndex = 1001;
        this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
        // 
        // clSahaYeri
        // 
        this.clSahaYeri.DataPropertyName = "SahaYeri";
        this.clSahaYeri.HeaderText = "SahaYeri";
        this.clSahaYeri.Name = "clSahaYeri";
        this.clSahaYeri.ReadOnly = true;
        this.clSahaYeri.Width = 75;
        // 
        // clAlanIsim
        // 
        this.clAlanIsim.DataPropertyName = "AlanIsim";
        this.clAlanIsim.HeaderText = "AlanIsim";
        this.clAlanIsim.Name = "clAlanIsim";
        this.clAlanIsim.ReadOnly = true;
        this.clAlanIsim.Width = 71;
        // 
        // clBaslikYaz
        // 
        this.clBaslikYaz.DataPropertyName = "BaslikYaz";
        this.clBaslikYaz.HeaderText = "BaslikYaz";
        this.clBaslikYaz.Name = "clBaslikYaz";
        this.clBaslikYaz.ReadOnly = true;
        this.clBaslikYaz.Resizable = System.Windows.Forms.DataGridViewTriState.True;
        this.clBaslikYaz.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
        this.clBaslikYaz.Width = 78;
        // 
        // clAciklama
        // 
        this.clAciklama.DataPropertyName = "Aciklama";
        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        this.clAciklama.DefaultCellStyle = dataGridViewCellStyle1;
        this.clAciklama.HeaderText = "Aciklama";
        this.clAciklama.Name = "clAciklama";
        this.clAciklama.ReadOnly = true;
        this.clAciklama.Width = 75;
        // 
        // clSatir
        // 
        this.clSatir.DataPropertyName = "Satir";
        this.clSatir.HeaderText = "Satır";
        this.clSatir.Name = "clSatir";
        this.clSatir.ReadOnly = true;
        this.clSatir.Width = 53;
        // 
        // clSutun
        // 
        this.clSutun.DataPropertyName = "Sutun";
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        this.clSutun.DefaultCellStyle = dataGridViewCellStyle2;
        this.clSutun.HeaderText = "Sutun";
        this.clSutun.Name = "clSutun";
        this.clSutun.ReadOnly = true;
        this.clSutun.Width = 60;
        // 
        // clUzunluk
        // 
        this.clUzunluk.DataPropertyName = "Uzunluk";
        this.clUzunluk.HeaderText = "Uzunluk";
        this.clUzunluk.Name = "clUzunluk";
        this.clUzunluk.ReadOnly = true;
        this.clUzunluk.Width = 71;
        // 
        // clOndalik
        // 
        this.clOndalik.DataPropertyName = "Ondalik";
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        this.clOndalik.DefaultCellStyle = dataGridViewCellStyle3;
        this.clOndalik.HeaderText = "Ondalik";
        this.clOndalik.Name = "clOndalik";
        this.clOndalik.ReadOnly = true;
        this.clOndalik.Width = 68;
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
        // frmDizaynKalem
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.ClientSize = new System.Drawing.Size(833, 364);
        this.Controls.Add(this.groupBox2);
        this.Controls.Add(this.groupBox1);
        this.KeyPreview = true;
        this.Name = "frmDizaynKalem";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "DizaynKalem";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDizaynKalem_KeyDown);
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.groupBox2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnYeni;
    private System.Windows.Forms.Button btnSil;
    private System.Windows.Forms.Button btnKaydet;
    private System.Windows.Forms.TextBox txtOndalik;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txtUzunluk;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtSutun;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtSatir;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtAciklama;
    private System.Windows.Forms.CheckBox chkBaslik;
    private System.Windows.Forms.ComboBox cmbAlanIsim;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cmbSahaYeri;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn clSahaYeri;
    private System.Windows.Forms.DataGridViewTextBoxColumn clAlanIsim;
    private System.Windows.Forms.DataGridViewCheckBoxColumn clBaslikYaz;
    private System.Windows.Forms.DataGridViewTextBoxColumn clAciklama;
    private System.Windows.Forms.DataGridViewTextBoxColumn clSatir;
    private System.Windows.Forms.DataGridViewTextBoxColumn clSutun;
    private System.Windows.Forms.DataGridViewTextBoxColumn clUzunluk;
    private System.Windows.Forms.DataGridViewTextBoxColumn clOndalik;
    private System.Windows.Forms.DataGridViewTextBoxColumn clId;

  }
}