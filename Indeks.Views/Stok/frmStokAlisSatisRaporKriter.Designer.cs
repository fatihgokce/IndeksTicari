namespace Indeks.Views
{
  partial class frmStokAlisSatisRaporKriter
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokAlisSatisRaporKriter));
        this.tabControl1 = new System.Windows.Forms.TabControl();
        this.tabPage2 = new System.Windows.Forms.TabPage();
        this.groupBox4 = new System.Windows.Forms.GroupBox();
        this.dataGridView1 = new System.Windows.Forms.DataGridView();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.btnPrint = new System.Windows.Forms.Button();
        this.btnRapor = new System.Windows.Forms.Button();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.dtpStart = new System.Windows.Forms.DateTimePicker();
        this.label2 = new System.Windows.Forms.Label();
        this.dtpFinish = new System.Windows.Forms.DateTimePicker();
        this.grbStokKodu = new System.Windows.Forms.GroupBox();
        this.btnStokRehber = new System.Windows.Forms.Button();
        this.label5 = new System.Windows.Forms.Label();
        this.txtStokKodu = new IndeksControl.AutoCompleteTextBox();
        this.rbStokKodu = new System.Windows.Forms.RadioButton();
        this.rbButunStoklar = new System.Windows.Forms.RadioButton();
        this.statusStrip1 = new System.Windows.Forms.StatusStrip();
        this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
        this.tslabToplamMiktar = new System.Windows.Forms.ToolStripStatusLabel();
        this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
        this.tslabToplamTutar = new System.Windows.Forms.ToolStripStatusLabel();
        this.groupBox3 = new System.Windows.Forms.GroupBox();
        this.groupBox5 = new System.Windows.Forms.GroupBox();
        this.tabControl1.SuspendLayout();
        this.tabPage2.SuspendLayout();
        this.groupBox4.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        this.groupBox1.SuspendLayout();
        this.groupBox2.SuspendLayout();
        this.grbStokKodu.SuspendLayout();
        this.statusStrip1.SuspendLayout();
        this.groupBox3.SuspendLayout();
        this.groupBox5.SuspendLayout();
        this.SuspendLayout();
        // 
        // tabControl1
        // 
        this.tabControl1.Controls.Add(this.tabPage2);
        this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tabControl1.Location = new System.Drawing.Point(3, 16);
        this.tabControl1.Name = "tabControl1";
        this.tabControl1.SelectedIndex = 0;
        this.tabControl1.Size = new System.Drawing.Size(945, 387);
        this.tabControl1.TabIndex = 1;
        // 
        // tabPage2
        // 
        this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
        this.tabPage2.Controls.Add(this.groupBox4);
        this.tabPage2.Controls.Add(this.groupBox1);
        this.tabPage2.Location = new System.Drawing.Point(4, 22);
        this.tabPage2.Name = "tabPage2";
        this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
        this.tabPage2.Size = new System.Drawing.Size(937, 361);
        this.tabPage2.TabIndex = 1;
        this.tabPage2.Text = "StokHareket Raporu";
        // 
        // groupBox4
        // 
        this.groupBox4.Controls.Add(this.dataGridView1);
        this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
        this.groupBox4.Location = new System.Drawing.Point(3, 203);
        this.groupBox4.Name = "groupBox4";
        this.groupBox4.Size = new System.Drawing.Size(931, 155);
        this.groupBox4.TabIndex = 1;
        this.groupBox4.TabStop = false;
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
        this.dataGridView1.Size = new System.Drawing.Size(925, 136);
        this.dataGridView1.TabIndex = 1004;
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.btnPrint);
        this.groupBox1.Controls.Add(this.btnRapor);
        this.groupBox1.Controls.Add(this.groupBox2);
        this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
        this.groupBox1.Location = new System.Drawing.Point(3, 3);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(931, 200);
        this.groupBox1.TabIndex = 0;
        this.groupBox1.TabStop = false;
        // 
        // btnPrint
        // 
        this.btnPrint.BackColor = System.Drawing.SystemColors.Control;
        this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
        this.btnPrint.Location = new System.Drawing.Point(383, 19);
        this.btnPrint.Name = "btnPrint";
        this.btnPrint.Size = new System.Drawing.Size(49, 31);
        this.btnPrint.TabIndex = 10;
        this.btnPrint.UseVisualStyleBackColor = false;
        this.btnPrint.Visible = false;
        this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
        // 
        // btnRapor
        // 
        this.btnRapor.BackColor = System.Drawing.SystemColors.MenuBar;
        this.btnRapor.ForeColor = System.Drawing.SystemColors.ControlText;
        this.btnRapor.Location = new System.Drawing.Point(302, 19);
        this.btnRapor.Name = "btnRapor";
        this.btnRapor.Size = new System.Drawing.Size(75, 66);
        this.btnRapor.TabIndex = 9;
        this.btnRapor.Text = "Rapor";
        this.btnRapor.UseVisualStyleBackColor = false;
        this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
        // 
        // groupBox2
        // 
        this.groupBox2.Controls.Add(this.dtpStart);
        this.groupBox2.Controls.Add(this.label2);
        this.groupBox2.Controls.Add(this.dtpFinish);
        this.groupBox2.Controls.Add(this.grbStokKodu);
        this.groupBox2.Controls.Add(this.rbStokKodu);
        this.groupBox2.Controls.Add(this.rbButunStoklar);
        this.groupBox2.Location = new System.Drawing.Point(6, 19);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(280, 174);
        this.groupBox2.TabIndex = 0;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "Arama Seçenekleri";
        // 
        // dtpStart
        // 
        this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpStart.Location = new System.Drawing.Point(5, 138);
        this.dtpStart.Name = "dtpStart";
        this.dtpStart.Size = new System.Drawing.Size(102, 20);
        this.dtpStart.TabIndex = 9;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(4, 122);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(62, 13);
        this.label2.TabIndex = 11;
        this.label2.Text = "Tarih Aralığı";
        // 
        // dtpFinish
        // 
        this.dtpFinish.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpFinish.Location = new System.Drawing.Point(113, 138);
        this.dtpFinish.Name = "dtpFinish";
        this.dtpFinish.Size = new System.Drawing.Size(102, 20);
        this.dtpFinish.TabIndex = 10;
        // 
        // grbStokKodu
        // 
        this.grbStokKodu.Controls.Add(this.btnStokRehber);
        this.grbStokKodu.Controls.Add(this.label5);
        this.grbStokKodu.Controls.Add(this.txtStokKodu);
        this.grbStokKodu.Enabled = false;
        this.grbStokKodu.Location = new System.Drawing.Point(7, 64);
        this.grbStokKodu.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
        this.grbStokKodu.Name = "grbStokKodu";
        this.grbStokKodu.Size = new System.Drawing.Size(247, 55);
        this.grbStokKodu.TabIndex = 2;
        this.grbStokKodu.TabStop = false;
        // 
        // btnStokRehber
        // 
        this.btnStokRehber.Location = new System.Drawing.Point(204, 15);
        this.btnStokRehber.Name = "btnStokRehber";
        this.btnStokRehber.Size = new System.Drawing.Size(34, 20);
        this.btnStokRehber.TabIndex = 4;
        this.btnStokRehber.Text = "...";
        this.btnStokRehber.UseVisualStyleBackColor = true;
        this.btnStokRehber.Click += new System.EventHandler(this.btnStokRehber_Click);
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
        this.label5.Location = new System.Drawing.Point(5, 16);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(54, 13);
        this.label5.TabIndex = 2;
        this.label5.Text = "StokKodu";
        // 
        // txtStokKodu
        // 
        this.txtStokKodu.Ayirac = null;
        this.txtStokKodu.AyracBoslukKullan = true;
        this.txtStokKodu.DataSource = null;
        this.txtStokKodu.ListForeColor = System.Drawing.Color.White;
        this.txtStokKodu.ListItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        this.txtStokKodu.Location = new System.Drawing.Point(69, 16);
        this.txtStokKodu.Name = "txtStokKodu";
        this.txtStokKodu.NextTabControlName = "dtpStart";
        this.txtStokKodu.Size = new System.Drawing.Size(129, 20);
        this.txtStokKodu.TabIndex = 3;
        this.txtStokKodu.WidthAutoComplete = 250;
        this.txtStokKodu.WidthKod = 35;
        // 
        // rbStokKodu
        // 
        this.rbStokKodu.AutoSize = true;
        this.rbStokKodu.Location = new System.Drawing.Point(7, 44);
        this.rbStokKodu.Name = "rbStokKodu";
        this.rbStokKodu.Size = new System.Drawing.Size(113, 17);
        this.rbStokKodu.TabIndex = 1;
        this.rbStokKodu.Text = "Stok Koduna Göre";
        this.rbStokKodu.UseVisualStyleBackColor = true;
        this.rbStokKodu.CheckedChanged += new System.EventHandler(this.rbButunStoklar_CheckedChanged);
        // 
        // rbButunStoklar
        // 
        this.rbButunStoklar.AutoSize = true;
        this.rbButunStoklar.Checked = true;
        this.rbButunStoklar.Location = new System.Drawing.Point(7, 20);
        this.rbButunStoklar.Name = "rbButunStoklar";
        this.rbButunStoklar.Size = new System.Drawing.Size(89, 17);
        this.rbButunStoklar.TabIndex = 0;
        this.rbButunStoklar.TabStop = true;
        this.rbButunStoklar.Text = "Bütün Stoklar";
        this.rbButunStoklar.UseVisualStyleBackColor = true;
        this.rbButunStoklar.CheckedChanged += new System.EventHandler(this.rbButunStoklar_CheckedChanged);
        // 
        // statusStrip1
        // 
        this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tslabToplamMiktar,
            this.toolStripStatusLabel2,
            this.tslabToplamTutar});
        this.statusStrip1.Location = new System.Drawing.Point(3, 16);
        this.statusStrip1.Name = "statusStrip1";
        this.statusStrip1.Size = new System.Drawing.Size(945, 42);
        this.statusStrip1.TabIndex = 1007;
        this.statusStrip1.Text = "statusStrip1";
        // 
        // toolStripStatusLabel1
        // 
        this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
        this.toolStripStatusLabel1.Size = new System.Drawing.Size(88, 37);
        this.toolStripStatusLabel1.Text = "Toplam Miktar:";
        // 
        // tslabToplamMiktar
        // 
        this.tslabToplamMiktar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.tslabToplamMiktar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
        this.tslabToplamMiktar.Name = "tslabToplamMiktar";
        this.tslabToplamMiktar.Size = new System.Drawing.Size(0, 37);
        // 
        // toolStripStatusLabel2
        // 
        this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
        this.toolStripStatusLabel2.Size = new System.Drawing.Size(79, 37);
        this.toolStripStatusLabel2.Text = "Toplam Tutar";
        // 
        // tslabToplamTutar
        // 
        this.tslabToplamTutar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.tslabToplamTutar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
        this.tslabToplamTutar.Name = "tslabToplamTutar";
        this.tslabToplamTutar.Size = new System.Drawing.Size(0, 37);
        // 
        // groupBox3
        // 
        this.groupBox3.Controls.Add(this.statusStrip1);
        this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.groupBox3.Location = new System.Drawing.Point(0, 406);
        this.groupBox3.Name = "groupBox3";
        this.groupBox3.Size = new System.Drawing.Size(951, 61);
        this.groupBox3.TabIndex = 1008;
        this.groupBox3.TabStop = false;
        // 
        // groupBox5
        // 
        this.groupBox5.Controls.Add(this.tabControl1);
        this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
        this.groupBox5.Location = new System.Drawing.Point(0, 0);
        this.groupBox5.Name = "groupBox5";
        this.groupBox5.Size = new System.Drawing.Size(951, 406);
        this.groupBox5.TabIndex = 1009;
        this.groupBox5.TabStop = false;
        // 
        // frmStokAlisSatisRaporKriter
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.Control;
        this.ClientSize = new System.Drawing.Size(951, 467);
        this.Controls.Add(this.groupBox5);
        this.Controls.Add(this.groupBox3);
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.KeyPreview = true;
        this.Name = "frmStokAlisSatisRaporKriter";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "StokAlisSatisRaporKriter";
        this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStokAlisSatisRaporKriter_KeyDown);
        this.tabControl1.ResumeLayout(false);
        this.tabPage2.ResumeLayout(false);
        this.groupBox4.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        this.groupBox1.ResumeLayout(false);
        this.groupBox2.ResumeLayout(false);
        this.groupBox2.PerformLayout();
        this.grbStokKodu.ResumeLayout(false);
        this.grbStokKodu.PerformLayout();
        this.statusStrip1.ResumeLayout(false);
        this.statusStrip1.PerformLayout();
        this.groupBox3.ResumeLayout(false);
        this.groupBox3.PerformLayout();
        this.groupBox5.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnPrint;
    private System.Windows.Forms.Button btnRapor;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.DateTimePicker dtpStart;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DateTimePicker dtpFinish;
    private System.Windows.Forms.GroupBox grbStokKodu;
    private System.Windows.Forms.Button btnStokRehber;
    private System.Windows.Forms.Label label5;
    public IndeksControl.AutoCompleteTextBox txtStokKodu;
    private System.Windows.Forms.RadioButton rbStokKodu;
    private System.Windows.Forms.RadioButton rbButunStoklar;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.ToolStripStatusLabel tslabToplamMiktar;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    private System.Windows.Forms.ToolStripStatusLabel tslabToplamTutar;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.GroupBox groupBox5;

  }
}