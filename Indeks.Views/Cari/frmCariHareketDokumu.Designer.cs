namespace Indeks.Views {
    partial class frmCariHareketDokumu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCariHareketDokumu));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkedListBoxHareketTipleri = new System.Windows.Forms.CheckedListBox();
            this.chbHepsi = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grbTarih = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpFinish = new System.Windows.Forms.DateTimePicker();
            this.rbTarihAralikli = new System.Windows.Forms.RadioButton();
            this.rbButunTarih = new System.Windows.Forms.RadioButton();
            this.grbCariKodu = new System.Windows.Forms.GroupBox();
            this.txtCariKodu = new IndeksControl.AutoCompleteTextBox();
            this.btnCariRehber = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rbCariKodu = new System.Windows.Forms.RadioButton();
            this.rbButunCariler = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslabToplamBorc = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslabToplamAlacak = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslabTopBakiye = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grbTarih.SuspendLayout();
            this.grbCariKodu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(912, 514);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(904, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cari Hareket Dokümü";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
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
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
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
            this.dataGridView1.Size = new System.Drawing.Size(892, 152);
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
            this.groupBox1.Size = new System.Drawing.Size(898, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(732, 19);
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
            this.btnRapor.Location = new System.Drawing.Point(637, 19);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(75, 66);
            this.btnRapor.TabIndex = 9;
            this.btnRapor.Text = "Rapor";
            this.btnRapor.UseVisualStyleBackColor = false;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.chbHepsi);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.grbCariKodu);
            this.groupBox2.Controls.Add(this.rbCariKodu);
            this.groupBox2.Controls.Add(this.rbButunCariler);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(608, 245);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arama Seçenekleri";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkedListBoxHareketTipleri);
            this.groupBox5.Location = new System.Drawing.Point(306, 37);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(226, 199);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hareket Tipleri";
            // 
            // checkedListBoxHareketTipleri
            // 
            this.checkedListBoxHareketTipleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxHareketTipleri.FormattingEnabled = true;
            this.checkedListBoxHareketTipleri.Items.AddRange(new object[] {
            "NakitTahsilat",
            "NakitOdeme",
            "AlinanMal",
            "SatilanMal",
            "AlinanMalIadesi",
            "SatilanMalIadesi",
            "AlinanCek",
            "VerilenCek",
            "CekCirosu",
            "AlinanCekIade",
            "VerilenCekGeriAlinmasi",
            "KarsiliksizCek",
            "AlinanSenet",
            "VerilenSenet",
            "SenetCirosu",
            "AlinanSenetIade",
            "VerilenSenetGeriAlinmasi",
            "KarsiliksizSenet",
            "Veresiye",
            "GelenHavale",
            "GonderilenHavale"});
            this.checkedListBoxHareketTipleri.Location = new System.Drawing.Point(3, 16);
            this.checkedListBoxHareketTipleri.Name = "checkedListBoxHareketTipleri";
            this.checkedListBoxHareketTipleri.Size = new System.Drawing.Size(220, 169);
            this.checkedListBoxHareketTipleri.TabIndex = 14;
            // 
            // chbHepsi
            // 
            this.chbHepsi.AutoSize = true;
            this.chbHepsi.Checked = true;
            this.chbHepsi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbHepsi.Location = new System.Drawing.Point(306, 14);
            this.chbHepsi.Name = "chbHepsi";
            this.chbHepsi.Size = new System.Drawing.Size(80, 17);
            this.chbHepsi.TabIndex = 15;
            this.chbHepsi.Text = "HepsiniSeç";
            this.chbHepsi.UseVisualStyleBackColor = true;
            this.chbHepsi.CheckedChanged += new System.EventHandler(this.chbHepsi_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grbTarih);
            this.groupBox3.Controls.Add(this.rbTarihAralikli);
            this.groupBox3.Controls.Add(this.rbButunTarih);
            this.groupBox3.Location = new System.Drawing.Point(7, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 117);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tarih";
            // 
            // grbTarih
            // 
            this.grbTarih.Controls.Add(this.label2);
            this.grbTarih.Controls.Add(this.dtpStart);
            this.grbTarih.Controls.Add(this.dtpFinish);
            this.grbTarih.Enabled = false;
            this.grbTarih.Location = new System.Drawing.Point(8, 50);
            this.grbTarih.Margin = new System.Windows.Forms.Padding(0);
            this.grbTarih.Name = "grbTarih";
            this.grbTarih.Size = new System.Drawing.Size(230, 64);
            this.grbTarih.TabIndex = 2;
            this.grbTarih.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tarih Aralığı";
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(7, 32);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(102, 20);
            this.dtpStart.TabIndex = 9;
            // 
            // dtpFinish
            // 
            this.dtpFinish.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinish.Location = new System.Drawing.Point(115, 32);
            this.dtpFinish.Name = "dtpFinish";
            this.dtpFinish.Size = new System.Drawing.Size(102, 20);
            this.dtpFinish.TabIndex = 10;
            // 
            // rbTarihAralikli
            // 
            this.rbTarihAralikli.AutoSize = true;
            this.rbTarihAralikli.Location = new System.Drawing.Point(8, 33);
            this.rbTarihAralikli.Margin = new System.Windows.Forms.Padding(0);
            this.rbTarihAralikli.Name = "rbTarihAralikli";
            this.rbTarihAralikli.Size = new System.Drawing.Size(82, 17);
            this.rbTarihAralikli.TabIndex = 1;
            this.rbTarihAralikli.Text = "Tarih Aralıklı";
            this.rbTarihAralikli.UseVisualStyleBackColor = true;
            this.rbTarihAralikli.CheckedChanged += new System.EventHandler(this.rbButunTarih_CheckedChanged);
            // 
            // rbButunTarih
            // 
            this.rbButunTarih.AutoSize = true;
            this.rbButunTarih.Checked = true;
            this.rbButunTarih.Location = new System.Drawing.Point(8, 16);
            this.rbButunTarih.Margin = new System.Windows.Forms.Padding(0);
            this.rbButunTarih.Name = "rbButunTarih";
            this.rbButunTarih.Size = new System.Drawing.Size(91, 17);
            this.rbButunTarih.TabIndex = 0;
            this.rbButunTarih.TabStop = true;
            this.rbButunTarih.Text = "Bütün Tarihler";
            this.rbButunTarih.UseVisualStyleBackColor = true;
            this.rbButunTarih.CheckedChanged += new System.EventHandler(this.rbButunTarih_CheckedChanged);
            // 
            // grbCariKodu
            // 
            this.grbCariKodu.Controls.Add(this.txtCariKodu);
            this.grbCariKodu.Controls.Add(this.btnCariRehber);
            this.grbCariKodu.Controls.Add(this.label5);
            this.grbCariKodu.Enabled = false;
            this.grbCariKodu.Location = new System.Drawing.Point(7, 64);
            this.grbCariKodu.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.grbCariKodu.Name = "grbCariKodu";
            this.grbCariKodu.Size = new System.Drawing.Size(267, 55);
            this.grbCariKodu.TabIndex = 2;
            this.grbCariKodu.TabStop = false;
            // 
            // txtCariKodu
            // 
            this.txtCariKodu.Ayirac = "";
            this.txtCariKodu.AyracBoslukKullan = true;
            this.txtCariKodu.DataSource = null;
            this.txtCariKodu.ListForeColor = System.Drawing.Color.White;
            this.txtCariKodu.ListItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtCariKodu.Location = new System.Drawing.Point(61, 16);
            this.txtCariKodu.Name = "txtCariKodu";
            this.txtCariKodu.NextTabControlName = "";
            this.txtCariKodu.Size = new System.Drawing.Size(137, 20);
            this.txtCariKodu.TabIndex = 11;
            this.txtCariKodu.WidthAutoComplete = 200;
            this.txtCariKodu.WidthKod = 15;
            // 
            // btnCariRehber
            // 
            this.btnCariRehber.Location = new System.Drawing.Point(204, 15);
            this.btnCariRehber.Name = "btnCariRehber";
            this.btnCariRehber.Size = new System.Drawing.Size(34, 20);
            this.btnCariRehber.TabIndex = 4;
            this.btnCariRehber.TabStop = false;
            this.btnCariRehber.Text = "...";
            this.btnCariRehber.UseVisualStyleBackColor = true;
            this.btnCariRehber.Click += new System.EventHandler(this.btnCariRehber_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(5, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "CariKodu";
            // 
            // rbCariKodu
            // 
            this.rbCariKodu.AutoSize = true;
            this.rbCariKodu.Location = new System.Drawing.Point(7, 44);
            this.rbCariKodu.Name = "rbCariKodu";
            this.rbCariKodu.Size = new System.Drawing.Size(109, 17);
            this.rbCariKodu.TabIndex = 1;
            this.rbCariKodu.Text = "Cari Koduna Göre";
            this.rbCariKodu.UseVisualStyleBackColor = true;
            this.rbCariKodu.CheckedChanged += new System.EventHandler(this.rbButunCariler_CheckedChanged);
            // 
            // rbButunCariler
            // 
            this.rbButunCariler.AutoSize = true;
            this.rbButunCariler.Checked = true;
            this.rbButunCariler.Location = new System.Drawing.Point(7, 20);
            this.rbButunCariler.Name = "rbButunCariler";
            this.rbButunCariler.Size = new System.Drawing.Size(85, 17);
            this.rbButunCariler.TabIndex = 0;
            this.rbButunCariler.TabStop = true;
            this.rbButunCariler.Text = "Bütün Cariler";
            this.rbButunCariler.UseVisualStyleBackColor = true;
            this.rbButunCariler.CheckedChanged += new System.EventHandler(this.rbButunCariler_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tslabToplamBorc,
            this.toolStripStatusLabel2,
            this.tslabToplamAlacak,
            this.toolStripStatusLabel3,
            this.tslabTopBakiye});
            this.statusStrip1.Location = new System.Drawing.Point(3, 16);
            this.statusStrip1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(892, 22);
            this.statusStrip1.TabIndex = 1005;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(126, 17);
            this.toolStripStatusLabel1.Text = "Carinin Toplam Borçu:";
            // 
            // tslabToplamBorc
            // 
            this.tslabToplamBorc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tslabToplamBorc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tslabToplamBorc.Name = "tslabToplamBorc";
            this.tslabToplamBorc.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel2.Text = "Carinin Toplam Alacağı";
            // 
            // tslabToplamAlacak
            // 
            this.tslabToplamAlacak.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tslabToplamAlacak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tslabToplamAlacak.Name = "tslabToplamAlacak";
            this.tslabToplamAlacak.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(41, 17);
            this.toolStripStatusLabel3.Text = "Bakiye";
            // 
            // tslabTopBakiye
            // 
            this.tslabTopBakiye.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tslabTopBakiye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tslabTopBakiye.Name = "tslabTopBakiye";
            this.tslabTopBakiye.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.statusStrip1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox6.Location = new System.Drawing.Point(3, 444);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(898, 41);
            this.groupBox6.TabIndex = 1006;
            this.groupBox6.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 273);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(898, 171);
            this.groupBox4.TabIndex = 1007;
            this.groupBox4.TabStop = false;
            // 
            // frmCariHareketDokumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 514);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmCariHareketDokumu";
            this.Text = "CariHareketDokumu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grbTarih.ResumeLayout(false);
            this.grbTarih.PerformLayout();
            this.grbCariKodu.ResumeLayout(false);
            this.grbCariKodu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grbTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpFinish;
        private System.Windows.Forms.RadioButton rbTarihAralikli;
        private System.Windows.Forms.RadioButton rbButunTarih;
        private System.Windows.Forms.GroupBox grbCariKodu;
        public IndeksControl.AutoCompleteTextBox txtCariKodu;
        private System.Windows.Forms.Button btnCariRehber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbCariKodu;
        private System.Windows.Forms.RadioButton rbButunCariler;
        private System.Windows.Forms.CheckBox chbHepsi;
        private System.Windows.Forms.CheckedListBox checkedListBoxHareketTipleri;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tslabToplamBorc;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tslabToplamAlacak;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tslabTopBakiye;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}