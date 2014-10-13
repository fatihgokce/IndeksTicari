namespace Indeks.Views
{
  partial class frmKasaTanimlama
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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKasaTanimlama));
        this.label1 = new System.Windows.Forms.Label();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.btnYeni = new System.Windows.Forms.Button();
        this.btnSil = new System.Windows.Forms.Button();
        this.btnKaydet = new System.Windows.Forms.Button();
        this.txtKasaKodu = new IndeksControl.AutoCompleteTextBox();
        this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
        this.txtSonDevirTutar = new System.Windows.Forms.TextBox();
        this.label4 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.txtKasaIsmi = new System.Windows.Forms.TextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.dataGridView1 = new System.Windows.Forms.DataGridView();
        this.clKasaKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clKasaIsmi = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clSonDevirTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clSonDevirTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        this.groupBox2.SuspendLayout();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(6, 25);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(59, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "Kasa Kodu";
        // 
        // groupBox1
        // 
        this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.groupBox1.Controls.Add(this.btnYeni);
        this.groupBox1.Controls.Add(this.btnSil);
        this.groupBox1.Controls.Add(this.btnKaydet);
        this.groupBox1.Controls.Add(this.txtKasaKodu);
        this.groupBox1.Controls.Add(this.dateTimePicker1);
        this.groupBox1.Controls.Add(this.txtSonDevirTutar);
        this.groupBox1.Controls.Add(this.label4);
        this.groupBox1.Controls.Add(this.label3);
        this.groupBox1.Controls.Add(this.txtKasaIsmi);
        this.groupBox1.Controls.Add(this.label2);
        this.groupBox1.Controls.Add(this.label1);
        this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
        this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
        this.groupBox1.Location = new System.Drawing.Point(0, 0);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(482, 173);
        this.groupBox1.TabIndex = 1;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Kasa Tanımlama";
        // 
        // btnYeni
        // 
        this.btnYeni.BackColor = System.Drawing.SystemColors.MenuBar;
        this.btnYeni.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnYeni.ForeColor = System.Drawing.SystemColors.ControlText;
        this.btnYeni.Location = new System.Drawing.Point(171, 129);
        this.btnYeni.Name = "btnYeni";
        this.btnYeni.Size = new System.Drawing.Size(75, 28);
        this.btnYeni.TabIndex = 16;
        this.btnYeni.Text = "Yeni(F3)";
        this.btnYeni.UseVisualStyleBackColor = false;
        this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
        // 
        // btnSil
        // 
        this.btnSil.BackColor = System.Drawing.SystemColors.MenuBar;
        this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnSil.ForeColor = System.Drawing.SystemColors.ControlText;
        this.btnSil.Location = new System.Drawing.Point(90, 129);
        this.btnSil.Name = "btnSil";
        this.btnSil.Size = new System.Drawing.Size(75, 28);
        this.btnSil.TabIndex = 15;
        this.btnSil.Text = "Sil(F7)";
        this.btnSil.UseVisualStyleBackColor = false;
        this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
        // 
        // btnKaydet
        // 
        this.btnKaydet.BackColor = System.Drawing.SystemColors.MenuBar;
        this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnKaydet.ForeColor = System.Drawing.SystemColors.ControlText;
        this.btnKaydet.Location = new System.Drawing.Point(9, 129);
        this.btnKaydet.Name = "btnKaydet";
        this.btnKaydet.Size = new System.Drawing.Size(75, 28);
        this.btnKaydet.TabIndex = 14;
        this.btnKaydet.Text = "Kaydet(F5)";
        this.btnKaydet.UseVisualStyleBackColor = false;
        this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
        // 
        // txtKasaKodu
        // 
        this.txtKasaKodu.Ayirac = null;
        this.txtKasaKodu.AyracBoslukKullan = false;
        this.txtKasaKodu.DataSource = null;
        this.txtKasaKodu.ListForeColor = System.Drawing.Color.Empty;
        this.txtKasaKodu.ListItemColor = System.Drawing.Color.DarkOrange;
        this.txtKasaKodu.Location = new System.Drawing.Point(104, 25);
        this.txtKasaKodu.Name = "txtKasaKodu";
        this.txtKasaKodu.NextTabControlName = null;
        this.txtKasaKodu.Size = new System.Drawing.Size(135, 20);
        this.txtKasaKodu.TabIndex = 0;
        this.txtKasaKodu.WidthAutoComplete = 135;
        this.txtKasaKodu.WidthKod = 0;
        this.txtKasaKodu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKasaKodu_KeyUp);
        // 
        // dateTimePicker1
        // 
        this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateTimePicker1.Location = new System.Drawing.Point(104, 77);
        this.dateTimePicker1.Name = "dateTimePicker1";
        this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
        this.dateTimePicker1.TabIndex = 2;
        // 
        // txtSonDevirTutar
        // 
        this.txtSonDevirTutar.Location = new System.Drawing.Point(104, 103);
        this.txtSonDevirTutar.MaxLength = 8;
        this.txtSonDevirTutar.Name = "txtSonDevirTutar";
        this.txtSonDevirTutar.Size = new System.Drawing.Size(135, 20);
        this.txtSonDevirTutar.TabIndex = 3;
        this.txtSonDevirTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(7, 103);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(82, 13);
        this.label4.TabIndex = 6;
        this.label4.Text = "Son Devir Tutar";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(6, 77);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(83, 13);
        this.label3.TabIndex = 4;
        this.label3.Text = "Son Devir Tarihi";
        // 
        // txtKasaIsmi
        // 
        this.txtKasaIsmi.Location = new System.Drawing.Point(104, 51);
        this.txtKasaIsmi.MaxLength = 50;
        this.txtKasaIsmi.Name = "txtKasaIsmi";
        this.txtKasaIsmi.Size = new System.Drawing.Size(204, 20);
        this.txtKasaIsmi.TabIndex = 1;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(6, 51);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(52, 13);
        this.label2.TabIndex = 1;
        this.label2.Text = "Kasa Ismi";
        // 
        // dataGridView1
        // 
        this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
        this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clKasaKod,
            this.clKasaIsmi,
            this.clSonDevirTarih,
            this.clSonDevirTutar});
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
        this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dataGridView1.Location = new System.Drawing.Point(3, 16);
        this.dataGridView1.MultiSelect = false;
        this.dataGridView1.Name = "dataGridView1";
        this.dataGridView1.ReadOnly = true;
        this.dataGridView1.RowHeadersVisible = false;
        this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dataGridView1.Size = new System.Drawing.Size(476, 291);
        this.dataGridView1.TabIndex = 9;
        this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
        // 
        // clKasaKod
        // 
        this.clKasaKod.DataPropertyName = "Id";
        this.clKasaKod.HeaderText = "KasaKod";
        this.clKasaKod.Name = "clKasaKod";
        this.clKasaKod.ReadOnly = true;
        // 
        // clKasaIsmi
        // 
        this.clKasaIsmi.DataPropertyName = "KasaIsmi";
        this.clKasaIsmi.HeaderText = "KasaIsmi";
        this.clKasaIsmi.Name = "clKasaIsmi";
        this.clKasaIsmi.ReadOnly = true;
        // 
        // clSonDevirTarih
        // 
        this.clSonDevirTarih.DataPropertyName = "SonDevirTarih";
        this.clSonDevirTarih.HeaderText = "SonDevirTarih";
        this.clSonDevirTarih.Name = "clSonDevirTarih";
        this.clSonDevirTarih.ReadOnly = true;
        // 
        // clSonDevirTutar
        // 
        this.clSonDevirTutar.DataPropertyName = "SonDevirTutar";
        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        this.clSonDevirTutar.DefaultCellStyle = dataGridViewCellStyle1;
        this.clSonDevirTutar.HeaderText = "SonDevirTutar";
        this.clSonDevirTutar.Name = "clSonDevirTutar";
        this.clSonDevirTutar.ReadOnly = true;
        // 
        // groupBox2
        // 
        this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.groupBox2.Controls.Add(this.dataGridView1);
        this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
        this.groupBox2.Location = new System.Drawing.Point(0, 173);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(482, 310);
        this.groupBox2.TabIndex = 2;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "Kasa Listesi";
        // 
        // frmKasaTanimlama
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.ClientSize = new System.Drawing.Size(482, 483);
        this.Controls.Add(this.groupBox2);
        this.Controls.Add(this.groupBox1);
        this.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.KeyPreview = true;
        this.Name = "frmKasaTanimlama";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "KasaTanimlama";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKasaTanimlama_FormClosing);
        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmKasaTanimlama_KeyDown);
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        this.groupBox2.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txtKasaIsmi;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtSonDevirTutar;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.GroupBox groupBox2;
    private IndeksControl.AutoCompleteTextBox txtKasaKodu;
    private System.Windows.Forms.Button btnYeni;
    private System.Windows.Forms.Button btnSil;
    private System.Windows.Forms.Button btnKaydet;
    private System.Windows.Forms.DataGridViewTextBoxColumn clKasaKod;
    private System.Windows.Forms.DataGridViewTextBoxColumn clKasaIsmi;
    private System.Windows.Forms.DataGridViewTextBoxColumn clSonDevirTarih;
    private System.Windows.Forms.DataGridViewTextBoxColumn clSonDevirTutar;
  }
}