namespace Indeks.Views
{
  partial class frmKasaHareketDokumu
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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKasaHareketDokumu));
        this.label1 = new System.Windows.Forms.Label();
        this.btnRapor = new System.Windows.Forms.Button();
        this.dtpStart = new System.Windows.Forms.DateTimePicker();
        this.dtpFinish = new System.Windows.Forms.DateTimePicker();
        this.label2 = new System.Windows.Forms.Label();
        this.cmboxKasalar = new System.Windows.Forms.ComboBox();
        this.label3 = new System.Windows.Forms.Label();
        this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
        this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.checkedListBoxHareketTipleri = new System.Windows.Forms.CheckedListBox();
        this.comboBox1 = new System.Windows.Forms.ComboBox();
        this.label4 = new System.Windows.Forms.Label();
        this.tabControl1 = new System.Windows.Forms.TabControl();
        this.tabPageFiltre = new System.Windows.Forms.TabPage();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.dataGridView1 = new System.Windows.Forms.DataGridView();
        this.cmsCariListesi = new System.Windows.Forms.ContextMenuStrip(this.components);
        this.cariListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.groupBox4 = new System.Windows.Forms.GroupBox();
        this.btnPrint = new System.Windows.Forms.Button();
        this.groupBox3 = new System.Windows.Forms.GroupBox();
        this.statusStrip1 = new System.Windows.Forms.StatusStrip();
        this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
        this.tslabToplamTutar = new System.Windows.Forms.ToolStripStatusLabel();
        this.groupBox5 = new System.Windows.Forms.GroupBox();
        this.groupBox1.SuspendLayout();
        this.tabControl1.SuspendLayout();
        this.tabPageFiltre.SuspendLayout();
        this.groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        this.cmsCariListesi.SuspendLayout();
        this.groupBox4.SuspendLayout();
        this.groupBox3.SuspendLayout();
        this.statusStrip1.SuspendLayout();
        this.groupBox5.SuspendLayout();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(6, 16);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(56, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "KasaKodu";
        // 
        // btnRapor
        // 
        this.btnRapor.BackColor = System.Drawing.SystemColors.MenuBar;
        this.btnRapor.ForeColor = System.Drawing.SystemColors.ControlText;
        this.btnRapor.Location = new System.Drawing.Point(240, 16);
        this.btnRapor.Name = "btnRapor";
        this.btnRapor.Size = new System.Drawing.Size(75, 66);
        this.btnRapor.TabIndex = 2;
        this.btnRapor.Text = "Rapor";
        this.btnRapor.UseVisualStyleBackColor = false;
        this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
        // 
        // dtpStart
        // 
        this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpStart.Location = new System.Drawing.Point(9, 62);
        this.dtpStart.Name = "dtpStart";
        this.dtpStart.Size = new System.Drawing.Size(102, 20);
        this.dtpStart.TabIndex = 3;
        // 
        // dtpFinish
        // 
        this.dtpFinish.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpFinish.Location = new System.Drawing.Point(117, 62);
        this.dtpFinish.Name = "dtpFinish";
        this.dtpFinish.Size = new System.Drawing.Size(102, 20);
        this.dtpFinish.TabIndex = 4;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(6, 46);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(62, 13);
        this.label2.TabIndex = 5;
        this.label2.Text = "Tarih Aralığı";
        // 
        // cmboxKasalar
        // 
        this.cmboxKasalar.FormattingEnabled = true;
        this.cmboxKasalar.Location = new System.Drawing.Point(90, 16);
        this.cmboxKasalar.Name = "cmboxKasalar";
        this.cmboxKasalar.Size = new System.Drawing.Size(129, 21);
        this.cmboxKasalar.TabIndex = 6;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(21, 46);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(62, 13);
        this.label3.TabIndex = 10;
        this.label3.Text = "Tarih Aralığı";
        // 
        // dateTimePicker1
        // 
        this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateTimePicker1.Location = new System.Drawing.Point(138, 62);
        this.dateTimePicker1.Name = "dateTimePicker1";
        this.dateTimePicker1.Size = new System.Drawing.Size(102, 20);
        this.dateTimePicker1.TabIndex = 9;
        // 
        // dateTimePicker2
        // 
        this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateTimePicker2.Location = new System.Drawing.Point(24, 62);
        this.dateTimePicker2.Name = "dateTimePicker2";
        this.dateTimePicker2.Size = new System.Drawing.Size(102, 20);
        this.dateTimePicker2.TabIndex = 8;
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.checkedListBoxHareketTipleri);
        this.groupBox1.Location = new System.Drawing.Point(24, 97);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(216, 206);
        this.groupBox1.TabIndex = 6;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "HareketTipleri";
        // 
        // checkedListBoxHareketTipleri
        // 
        this.checkedListBoxHareketTipleri.Dock = System.Windows.Forms.DockStyle.Fill;
        this.checkedListBoxHareketTipleri.FormattingEnabled = true;
        this.checkedListBoxHareketTipleri.Items.AddRange(new object[] {
            "MalAlış",
            "MalSatış",
            "CaridenTahsilat",
            "CariyeÖdeme",
            "BankayaYatan",
            "BankadanÇekilen",
            "ÇekGelir",
            "ÇekGider",
            "SenetGelir",
            "SenetGider",
            "ÖzelGelir",
            "ÖzelGider"});
        this.checkedListBoxHareketTipleri.Location = new System.Drawing.Point(3, 16);
        this.checkedListBoxHareketTipleri.Name = "checkedListBoxHareketTipleri";
        this.checkedListBoxHareketTipleri.Size = new System.Drawing.Size(210, 184);
        this.checkedListBoxHareketTipleri.TabIndex = 5;
        // 
        // comboBox1
        // 
        this.comboBox1.FormattingEnabled = true;
        this.comboBox1.Location = new System.Drawing.Point(100, 15);
        this.comboBox1.Name = "comboBox1";
        this.comboBox1.Size = new System.Drawing.Size(140, 21);
        this.comboBox1.TabIndex = 4;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(21, 15);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(56, 13);
        this.label4.TabIndex = 3;
        this.label4.Text = "KasaKodu";
        // 
        // tabControl1
        // 
        this.tabControl1.Controls.Add(this.tabPageFiltre);
        this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tabControl1.Location = new System.Drawing.Point(3, 16);
        this.tabControl1.Name = "tabControl1";
        this.tabControl1.SelectedIndex = 0;
        this.tabControl1.Size = new System.Drawing.Size(809, 327);
        this.tabControl1.TabIndex = 7;
        this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
        // 
        // tabPageFiltre
        // 
        this.tabPageFiltre.BackColor = System.Drawing.Color.Transparent;
        this.tabPageFiltre.Controls.Add(this.groupBox2);
        this.tabPageFiltre.Controls.Add(this.groupBox4);
        this.tabPageFiltre.Location = new System.Drawing.Point(4, 22);
        this.tabPageFiltre.Name = "tabPageFiltre";
        this.tabPageFiltre.Padding = new System.Windows.Forms.Padding(3);
        this.tabPageFiltre.Size = new System.Drawing.Size(801, 301);
        this.tabPageFiltre.TabIndex = 0;
        this.tabPageFiltre.Text = "Kasa Hareket Dökümü";
        this.tabPageFiltre.UseVisualStyleBackColor = true;
        // 
        // groupBox2
        // 
        this.groupBox2.Controls.Add(this.dataGridView1);
        this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.groupBox2.Location = new System.Drawing.Point(3, 102);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(795, 196);
        this.groupBox2.TabIndex = 8;
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
        this.dataGridView1.ContextMenuStrip = this.cmsCariListesi;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
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
        this.dataGridView1.Size = new System.Drawing.Size(789, 177);
        this.dataGridView1.TabIndex = 1003;
        // 
        // cmsCariListesi
        // 
        this.cmsCariListesi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cariListesiToolStripMenuItem});
        this.cmsCariListesi.Name = "cmsStokListesi";
        this.cmsCariListesi.Size = new System.Drawing.Size(174, 26);
        // 
        // cariListesiToolStripMenuItem
        // 
        this.cariListesiToolStripMenuItem.Name = "cariListesiToolStripMenuItem";
        this.cariListesiToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
        this.cariListesiToolStripMenuItem.Text = "StokiHareketListesi";
        this.cariListesiToolStripMenuItem.Click += new System.EventHandler(this.cariListesiToolStripMenuItem_Click);
        // 
        // groupBox4
        // 
        this.groupBox4.Controls.Add(this.btnPrint);
        this.groupBox4.Controls.Add(this.label1);
        this.groupBox4.Controls.Add(this.btnRapor);
        this.groupBox4.Controls.Add(this.dtpStart);
        this.groupBox4.Controls.Add(this.label2);
        this.groupBox4.Controls.Add(this.dtpFinish);
        this.groupBox4.Controls.Add(this.cmboxKasalar);
        this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
        this.groupBox4.Location = new System.Drawing.Point(3, 3);
        this.groupBox4.Name = "groupBox4";
        this.groupBox4.Size = new System.Drawing.Size(795, 99);
        this.groupBox4.TabIndex = 7;
        this.groupBox4.TabStop = false;
        // 
        // btnPrint
        // 
        this.btnPrint.BackColor = System.Drawing.SystemColors.Control;
        this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
        this.btnPrint.Location = new System.Drawing.Point(332, 51);
        this.btnPrint.Name = "btnPrint";
        this.btnPrint.Size = new System.Drawing.Size(49, 31);
        this.btnPrint.TabIndex = 4;
        this.btnPrint.UseVisualStyleBackColor = false;
        this.btnPrint.Visible = false;
        this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
        // 
        // groupBox3
        // 
        this.groupBox3.Controls.Add(this.statusStrip1);
        this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.groupBox3.Location = new System.Drawing.Point(0, 346);
        this.groupBox3.Name = "groupBox3";
        this.groupBox3.Size = new System.Drawing.Size(815, 45);
        this.groupBox3.TabIndex = 8;
        this.groupBox3.TabStop = false;
        // 
        // statusStrip1
        // 
        this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tslabToplamTutar});
        this.statusStrip1.Location = new System.Drawing.Point(3, 16);
        this.statusStrip1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
        this.statusStrip1.Name = "statusStrip1";
        this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
        this.statusStrip1.Size = new System.Drawing.Size(809, 26);
        this.statusStrip1.TabIndex = 1006;
        this.statusStrip1.Text = "statusStrip1";
        this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
        // 
        // toolStripStatusLabel1
        // 
        this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
        this.toolStripStatusLabel1.Size = new System.Drawing.Size(82, 21);
        this.toolStripStatusLabel1.Text = "Toplam Tutar:";
        // 
        // tslabToplamTutar
        // 
        this.tslabToplamTutar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.tslabToplamTutar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
        this.tslabToplamTutar.Name = "tslabToplamTutar";
        this.tslabToplamTutar.Size = new System.Drawing.Size(0, 21);
        // 
        // groupBox5
        // 
        this.groupBox5.Controls.Add(this.tabControl1);
        this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
        this.groupBox5.Location = new System.Drawing.Point(0, 0);
        this.groupBox5.Name = "groupBox5";
        this.groupBox5.Size = new System.Drawing.Size(815, 346);
        this.groupBox5.TabIndex = 9;
        this.groupBox5.TabStop = false;
        // 
        // frmKasaHareketDokumu
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.Control;
        this.ClientSize = new System.Drawing.Size(815, 391);
        this.Controls.Add(this.groupBox5);
        this.Controls.Add(this.groupBox3);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.KeyPreview = true;
        this.Name = "frmKasaHareketDokumu";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "KasaHareketDökümü";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmKasaKriter_KeyDown);
        this.groupBox1.ResumeLayout(false);
        this.tabControl1.ResumeLayout(false);
        this.tabPageFiltre.ResumeLayout(false);
        this.groupBox2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        this.cmsCariListesi.ResumeLayout(false);
        this.groupBox4.ResumeLayout(false);
        this.groupBox4.PerformLayout();
        this.groupBox3.ResumeLayout(false);
        this.groupBox3.PerformLayout();
        this.statusStrip1.ResumeLayout(false);
        this.statusStrip1.PerformLayout();
        this.groupBox5.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnRapor;
    private System.Windows.Forms.DateTimePicker dtpStart;
    private System.Windows.Forms.DateTimePicker dtpFinish;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cmboxKasalar;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.DateTimePicker dateTimePicker2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.CheckedListBox checkedListBoxHareketTipleri;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPageFiltre;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Button btnPrint;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.ToolStripStatusLabel tslabToplamTutar;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.ContextMenuStrip cmsCariListesi;
    private System.Windows.Forms.ToolStripMenuItem cariListesiToolStripMenuItem;
  }
}