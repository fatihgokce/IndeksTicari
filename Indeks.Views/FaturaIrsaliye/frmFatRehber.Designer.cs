namespace Indeks.Views
{
  partial class frmFatRehber
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
        this.components = new System.ComponentModel.Container();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
        this.panel1 = new System.Windows.Forms.Panel();
        this.gbVadeTarih = new System.Windows.Forms.GroupBox();
        this.dtVadeBitTar = new System.Windows.Forms.DateTimePicker();
        this.label5 = new System.Windows.Forms.Label();
        this.dtVadeBasTar = new System.Windows.Forms.DateTimePicker();
        this.label6 = new System.Windows.Forms.Label();
        this.gbTarih = new System.Windows.Forms.GroupBox();
        this.dtTarBitTar = new System.Windows.Forms.DateTimePicker();
        this.label1 = new System.Windows.Forms.Label();
        this.dtTarBasTar = new System.Windows.Forms.DateTimePicker();
        this.label4 = new System.Windows.Forms.Label();
        this.gbFatTip = new System.Windows.Forms.GroupBox();
        this.rbKrediKarti = new System.Windows.Forms.RadioButton();
        this.rbIade = new System.Windows.Forms.RadioButton();
        this.rbVadeli = new System.Windows.Forms.RadioButton();
        this.rbPesin = new System.Windows.Forms.RadioButton();
        this.txtCariKodu = new System.Windows.Forms.TextBox();
        this.label3 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.txtFatirsNo = new System.Windows.Forms.TextBox();
        this.labFatNo = new System.Windows.Forms.Label();
        this.dataGridView1 = new System.Windows.Forms.DataGridView();
        this.cmsStokListesi = new System.Windows.Forms.ContextMenuStrip(this.components);
        this.stokListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.clFatirsNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clCariKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clBrutTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clKdvTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clSatirIsk = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clGenelToplam = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clVadeTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clTeslimTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clSevkTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.panel1.SuspendLayout();
        this.gbVadeTarih.SuspendLayout();
        this.gbTarih.SuspendLayout();
        this.gbFatTip.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        this.cmsStokListesi.SuspendLayout();
        this.SuspendLayout();
        // 
        // panel1
        // 
        this.panel1.AutoScroll = true;
        this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.panel1.Controls.Add(this.gbVadeTarih);
        this.panel1.Controls.Add(this.gbTarih);
        this.panel1.Controls.Add(this.gbFatTip);
        this.panel1.Controls.Add(this.txtCariKodu);
        this.panel1.Controls.Add(this.label3);
        this.panel1.Controls.Add(this.label2);
        this.panel1.Controls.Add(this.txtFatirsNo);
        this.panel1.Controls.Add(this.labFatNo);
        this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
        this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
        this.panel1.Location = new System.Drawing.Point(0, 0);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(218, 447);
        this.panel1.TabIndex = 2;
        // 
        // gbVadeTarih
        // 
        this.gbVadeTarih.Controls.Add(this.dtVadeBitTar);
        this.gbVadeTarih.Controls.Add(this.label5);
        this.gbVadeTarih.Controls.Add(this.dtVadeBasTar);
        this.gbVadeTarih.Controls.Add(this.label6);
        this.gbVadeTarih.Location = new System.Drawing.Point(3, 262);
        this.gbVadeTarih.Name = "gbVadeTarih";
        this.gbVadeTarih.Size = new System.Drawing.Size(188, 96);
        this.gbVadeTarih.TabIndex = 27;
        this.gbVadeTarih.TabStop = false;
        this.gbVadeTarih.Text = "Vade Tarih";
        // 
        // dtVadeBitTar
        // 
        this.dtVadeBitTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtVadeBitTar.Location = new System.Drawing.Point(11, 71);
        this.dtVadeBitTar.Name = "dtVadeBitTar";
        this.dtVadeBitTar.Size = new System.Drawing.Size(153, 20);
        this.dtVadeBitTar.TabIndex = 1;
        this.dtVadeBitTar.ValueChanged += new System.EventHandler(this.dtTarBasTar_ValueChanged);
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(8, 55);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(53, 13);
        this.label5.TabIndex = 6;
        this.label5.Text = "Bitiş Tarih";
        // 
        // dtVadeBasTar
        // 
        this.dtVadeBasTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtVadeBasTar.Location = new System.Drawing.Point(11, 32);
        this.dtVadeBasTar.Name = "dtVadeBasTar";
        this.dtVadeBasTar.Size = new System.Drawing.Size(153, 20);
        this.dtVadeBasTar.TabIndex = 0;
        this.dtVadeBasTar.ValueChanged += new System.EventHandler(this.dtTarBasTar_ValueChanged);
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Location = new System.Drawing.Point(8, 16);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(80, 13);
        this.label6.TabIndex = 4;
        this.label6.Text = "Başlangıç Tarih";
        // 
        // gbTarih
        // 
        this.gbTarih.Controls.Add(this.dtTarBitTar);
        this.gbTarih.Controls.Add(this.label1);
        this.gbTarih.Controls.Add(this.dtTarBasTar);
        this.gbTarih.Controls.Add(this.label4);
        this.gbTarih.Location = new System.Drawing.Point(3, 160);
        this.gbTarih.Name = "gbTarih";
        this.gbTarih.Size = new System.Drawing.Size(188, 96);
        this.gbTarih.TabIndex = 26;
        this.gbTarih.TabStop = false;
        this.gbTarih.Text = "Tarih";
        // 
        // dtTarBitTar
        // 
        this.dtTarBitTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtTarBitTar.Location = new System.Drawing.Point(11, 71);
        this.dtTarBitTar.Name = "dtTarBitTar";
        this.dtTarBitTar.Size = new System.Drawing.Size(153, 20);
        this.dtTarBitTar.TabIndex = 1;
        this.dtTarBitTar.ValueChanged += new System.EventHandler(this.dtTarBasTar_ValueChanged);
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(8, 55);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(53, 13);
        this.label1.TabIndex = 6;
        this.label1.Text = "Bitiş Tarih";
        // 
        // dtTarBasTar
        // 
        this.dtTarBasTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtTarBasTar.Location = new System.Drawing.Point(11, 32);
        this.dtTarBasTar.Name = "dtTarBasTar";
        this.dtTarBasTar.Size = new System.Drawing.Size(153, 20);
        this.dtTarBasTar.TabIndex = 0;
        this.dtTarBasTar.ValueChanged += new System.EventHandler(this.dtTarBasTar_ValueChanged);
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(8, 16);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(80, 13);
        this.label4.TabIndex = 4;
        this.label4.Text = "Başlangıç Tarih";
        // 
        // gbFatTip
        // 
        this.gbFatTip.Controls.Add(this.rbKrediKarti);
        this.gbFatTip.Controls.Add(this.rbIade);
        this.gbFatTip.Controls.Add(this.rbVadeli);
        this.gbFatTip.Controls.Add(this.rbPesin);
        this.gbFatTip.Location = new System.Drawing.Point(3, 86);
        this.gbFatTip.Name = "gbFatTip";
        this.gbFatTip.Size = new System.Drawing.Size(188, 68);
        this.gbFatTip.TabIndex = 25;
        this.gbFatTip.TabStop = false;
        this.gbFatTip.Text = "FaturaTipi";
        // 
        // rbKrediKarti
        // 
        this.rbKrediKarti.AutoSize = true;
        this.rbKrediKarti.Location = new System.Drawing.Point(61, 42);
        this.rbKrediKarti.Name = "rbKrediKarti";
        this.rbKrediKarti.Size = new System.Drawing.Size(70, 17);
        this.rbKrediKarti.TabIndex = 3;
        this.rbKrediKarti.Text = "KrediKartı";
        this.rbKrediKarti.UseVisualStyleBackColor = true;
        this.rbKrediKarti.CheckedChanged += new System.EventHandler(this.rbVadeli_CheckedChanged);
        // 
        // rbIade
        // 
        this.rbIade.AutoSize = true;
        this.rbIade.Location = new System.Drawing.Point(6, 42);
        this.rbIade.Name = "rbIade";
        this.rbIade.Size = new System.Drawing.Size(46, 17);
        this.rbIade.TabIndex = 2;
        this.rbIade.Text = "Iade";
        this.rbIade.UseVisualStyleBackColor = true;
        this.rbIade.CheckedChanged += new System.EventHandler(this.rbVadeli_CheckedChanged);
        // 
        // rbVadeli
        // 
        this.rbVadeli.AutoSize = true;
        this.rbVadeli.Checked = true;
        this.rbVadeli.Location = new System.Drawing.Point(6, 19);
        this.rbVadeli.Name = "rbVadeli";
        this.rbVadeli.Size = new System.Drawing.Size(54, 17);
        this.rbVadeli.TabIndex = 0;
        this.rbVadeli.TabStop = true;
        this.rbVadeli.Text = "Vadeli";
        this.rbVadeli.UseVisualStyleBackColor = true;
        this.rbVadeli.CheckedChanged += new System.EventHandler(this.rbVadeli_CheckedChanged);
        // 
        // rbPesin
        // 
        this.rbPesin.AutoSize = true;
        this.rbPesin.Location = new System.Drawing.Point(61, 19);
        this.rbPesin.Name = "rbPesin";
        this.rbPesin.Size = new System.Drawing.Size(51, 17);
        this.rbPesin.TabIndex = 1;
        this.rbPesin.Text = "Peşin";
        this.rbPesin.UseVisualStyleBackColor = true;
        this.rbPesin.CheckedChanged += new System.EventHandler(this.rbVadeli_CheckedChanged);
        // 
        // txtCariKodu
        // 
        this.txtCariKodu.Location = new System.Drawing.Point(3, 63);
        this.txtCariKodu.Name = "txtCariKodu";
        this.txtCariKodu.Size = new System.Drawing.Size(192, 20);
        this.txtCariKodu.TabIndex = 1;
        this.txtCariKodu.TextChanged += new System.EventHandler(this.txtStokKodu_TextChanged);
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(3, 47);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(25, 13);
        this.label3.TabIndex = 6;
        this.label3.Text = "Cari";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(0, 47);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(0, 13);
        this.label2.TabIndex = 2;
        // 
        // txtFatirsNo
        // 
        this.txtFatirsNo.Location = new System.Drawing.Point(3, 24);
        this.txtFatirsNo.Name = "txtFatirsNo";
        this.txtFatirsNo.Size = new System.Drawing.Size(192, 20);
        this.txtFatirsNo.TabIndex = 0;
        this.txtFatirsNo.TextChanged += new System.EventHandler(this.txtStokKodu_TextChanged);
        // 
        // labFatNo
        // 
        this.labFatNo.AutoSize = true;
        this.labFatNo.Location = new System.Drawing.Point(0, 8);
        this.labFatNo.Name = "labFatNo";
        this.labFatNo.Size = new System.Drawing.Size(54, 13);
        this.labFatNo.TabIndex = 0;
        this.labFatNo.Text = "Fatura No";
        // 
        // dataGridView1
        // 
        this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
        this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.clFatirsNo,
            this.clTarih,
            this.clCariKodu,
            this.clBrutTutar,
            this.clKdvTutar,
            this.clSatirIsk,
            this.clGenelToplam,
            this.clVadeTarihi,
            this.clTeslimTarih,
            this.clSevkTarih});
        this.dataGridView1.ContextMenuStrip = this.cmsStokListesi;
        dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
        dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
        dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
        this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dataGridView1.GridColor = System.Drawing.SystemColors.Desktop;
        this.dataGridView1.Location = new System.Drawing.Point(218, 0);
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
        this.dataGridView1.Size = new System.Drawing.Size(706, 447);
        this.dataGridView1.TabIndex = 1000;
        this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
        this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
        // 
        // cmsStokListesi
        // 
        this.cmsStokListesi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokListesiToolStripMenuItem});
        this.cmsStokListesi.Name = "cmsStokListesi";
        this.cmsStokListesi.Size = new System.Drawing.Size(130, 26);
        // 
        // stokListesiToolStripMenuItem
        // 
        this.stokListesiToolStripMenuItem.Name = "stokListesiToolStripMenuItem";
        this.stokListesiToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
        this.stokListesiToolStripMenuItem.Text = "StokListesi";
        this.stokListesiToolStripMenuItem.Click += new System.EventHandler(this.stokListesiToolStripMenuItem_Click);
        // 
        // clFatirsNo
        // 
        this.clFatirsNo.DataPropertyName = "FatirsNo";
        this.clFatirsNo.HeaderText = "FatIrsNo";
        this.clFatirsNo.Name = "clFatirsNo";
        this.clFatirsNo.ReadOnly = true;
        this.clFatirsNo.Width = 72;
        // 
        // clTarih
        // 
        this.clTarih.DataPropertyName = "Tarih";
        this.clTarih.HeaderText = "Tarih";
        this.clTarih.Name = "clTarih";
        this.clTarih.ReadOnly = true;
        this.clTarih.Width = 56;
        // 
        // clCariKodu
        // 
        this.clCariKodu.DataPropertyName = "CariKodu";
        this.clCariKodu.HeaderText = "CariKod";
        this.clCariKodu.Name = "clCariKodu";
        this.clCariKodu.ReadOnly = true;
        this.clCariKodu.Width = 69;
        // 
        // clBrutTutar
        // 
        this.clBrutTutar.DataPropertyName = "BrutTutar";
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        dataGridViewCellStyle2.Format = "F2";
        dataGridViewCellStyle2.NullValue = null;
        this.clBrutTutar.DefaultCellStyle = dataGridViewCellStyle2;
        this.clBrutTutar.HeaderText = "BrutTutar";
        this.clBrutTutar.Name = "clBrutTutar";
        this.clBrutTutar.ReadOnly = true;
        this.clBrutTutar.Width = 76;
        // 
        // clKdvTutar
        // 
        this.clKdvTutar.DataPropertyName = "KdvTutar";
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        dataGridViewCellStyle3.Format = "F2";
        dataGridViewCellStyle3.NullValue = null;
        this.clKdvTutar.DefaultCellStyle = dataGridViewCellStyle3;
        this.clKdvTutar.HeaderText = "KdvTutar";
        this.clKdvTutar.Name = "clKdvTutar";
        this.clKdvTutar.ReadOnly = true;
        this.clKdvTutar.Width = 76;
        // 
        // clSatirIsk
        // 
        this.clSatirIsk.DataPropertyName = "SatirIsk";
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        dataGridViewCellStyle4.Format = "F2";
        dataGridViewCellStyle4.NullValue = null;
        this.clSatirIsk.DefaultCellStyle = dataGridViewCellStyle4;
        this.clSatirIsk.HeaderText = "SatIskToplam";
        this.clSatirIsk.Name = "clSatirIsk";
        this.clSatirIsk.ReadOnly = true;
        this.clSatirIsk.Width = 97;
        // 
        // clGenelToplam
        // 
        this.clGenelToplam.DataPropertyName = "GenelToplam";
        dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        dataGridViewCellStyle5.Format = "F2";
        dataGridViewCellStyle5.NullValue = null;
        this.clGenelToplam.DefaultCellStyle = dataGridViewCellStyle5;
        this.clGenelToplam.HeaderText = "GenelToplam";
        this.clGenelToplam.Name = "clGenelToplam";
        this.clGenelToplam.ReadOnly = true;
        this.clGenelToplam.Width = 95;
        // 
        // clVadeTarihi
        // 
        this.clVadeTarihi.DataPropertyName = "VadeTarih";
        dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        this.clVadeTarihi.DefaultCellStyle = dataGridViewCellStyle6;
        this.clVadeTarihi.HeaderText = "VadeTarihi";
        this.clVadeTarihi.Name = "clVadeTarihi";
        this.clVadeTarihi.ReadOnly = true;
        this.clVadeTarihi.Width = 83;
        // 
        // clTeslimTarih
        // 
        this.clTeslimTarih.DataPropertyName = "TeslimTarih";
        this.clTeslimTarih.HeaderText = "TeslimTarih";
        this.clTeslimTarih.Name = "clTeslimTarih";
        this.clTeslimTarih.ReadOnly = true;
        this.clTeslimTarih.Width = 86;
        // 
        // clSevkTarih
        // 
        this.clSevkTarih.DataPropertyName = "SevkTarihi";
        this.clSevkTarih.HeaderText = "SevkTarihi";
        this.clSevkTarih.Name = "clSevkTarih";
        this.clSevkTarih.ReadOnly = true;
        this.clSevkTarih.Width = 83;
        // 
        // frmFatRehber
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.ClientSize = new System.Drawing.Size(924, 447);
        this.Controls.Add(this.dataGridView1);
        this.Controls.Add(this.panel1);
        this.Name = "frmFatRehber";
        this.Text = "Rehber";
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.gbVadeTarih.ResumeLayout(false);
        this.gbVadeTarih.PerformLayout();
        this.gbTarih.ResumeLayout(false);
        this.gbTarih.PerformLayout();
        this.gbFatTip.ResumeLayout(false);
        this.gbFatTip.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        this.cmsStokListesi.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox txtCariKodu;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtFatirsNo;
    private System.Windows.Forms.Label labFatNo;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.GroupBox gbFatTip;
    private System.Windows.Forms.RadioButton rbIade;
    private System.Windows.Forms.RadioButton rbVadeli;
    private System.Windows.Forms.RadioButton rbPesin;
    private System.Windows.Forms.GroupBox gbTarih;
    private System.Windows.Forms.DateTimePicker dtTarBitTar;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DateTimePicker dtTarBasTar;
    private System.Windows.Forms.GroupBox gbVadeTarih;
    private System.Windows.Forms.DateTimePicker dtVadeBitTar;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.DateTimePicker dtVadeBasTar;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ContextMenuStrip cmsStokListesi;
    private System.Windows.Forms.ToolStripMenuItem stokListesiToolStripMenuItem;
    private System.Windows.Forms.RadioButton rbKrediKarti;
    private System.Windows.Forms.DataGridViewTextBoxColumn clFatirsNo;
    private System.Windows.Forms.DataGridViewTextBoxColumn clTarih;
    private System.Windows.Forms.DataGridViewTextBoxColumn clCariKodu;
    private System.Windows.Forms.DataGridViewTextBoxColumn clBrutTutar;
    private System.Windows.Forms.DataGridViewTextBoxColumn clKdvTutar;
    private System.Windows.Forms.DataGridViewTextBoxColumn clSatirIsk;
    private System.Windows.Forms.DataGridViewTextBoxColumn clGenelToplam;
    private System.Windows.Forms.DataGridViewTextBoxColumn clVadeTarihi;
    private System.Windows.Forms.DataGridViewTextBoxColumn clTeslimTarih;
    private System.Windows.Forms.DataGridViewTextBoxColumn clSevkTarih;
  }
}