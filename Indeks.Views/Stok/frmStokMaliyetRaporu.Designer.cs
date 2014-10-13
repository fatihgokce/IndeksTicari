namespace Indeks.Views {
    partial class frmStokMaliyetRaporu {
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokMaliyetRaporu));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmsStokListesi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stokListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFiltre = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGrupRehber = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStokGrup = new IndeksControl.AutoCompleteTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.grbTarih = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpFinish = new System.Windows.Forms.DateTimePicker();
            this.rbTarihAralikli = new System.Windows.Forms.RadioButton();
            this.rbButunTarih = new System.Windows.Forms.RadioButton();
            this.grbStokKodu = new System.Windows.Forms.GroupBox();
            this.btnStokRehber = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStokKodu = new IndeksControl.AutoCompleteTextBox();
            this.rbStokKodu = new System.Windows.Forms.RadioButton();
            this.rbButunStoklar = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslabToplamAlisMiktar = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslabToplamSatisMiktar = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslabEldekiMalMiktar = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslabToplamAlisTutar = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslabToplamSatisTutar = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslabTopKalanMalinMaliyeti = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kalanMiktarSifirUstu = new System.Windows.Forms.ToolStripMenuItem();
            this.kalanMiktarEksiyeDusenlerListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kalanMiktarSifirinUstundeOlanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kalanMiktarSifirinAltindaOlanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.cmsStokListesi.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageFiltre.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.grbTarih.SuspendLayout();
            this.grbStokKodu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(975, 203);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
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
            this.dataGridView1.ContextMenuStrip = this.cmsStokListesi;
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
            this.dataGridView1.Size = new System.Drawing.Size(969, 184);
            this.dataGridView1.TabIndex = 1003;
            // 
            // cmsStokListesi
            // 
            this.cmsStokListesi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokListesiToolStripMenuItem,
            this.kalanMiktarSifirinUstundeOlanlarToolStripMenuItem,
            this.kalanMiktarSifirinAltindaOlanlarToolStripMenuItem});
            this.cmsStokListesi.Name = "cmsStokListesi";
            this.cmsStokListesi.Size = new System.Drawing.Size(258, 92);
            this.cmsStokListesi.Opening += new System.ComponentModel.CancelEventHandler(this.cmsStokListesi_Opening);
            // 
            // stokListesiToolStripMenuItem
            // 
            this.stokListesiToolStripMenuItem.Name = "stokListesiToolStripMenuItem";
            this.stokListesiToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.stokListesiToolStripMenuItem.Text = "StokHareketListesi";
            this.stokListesiToolStripMenuItem.Click += new System.EventHandler(this.stokListesiToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFiltre);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(989, 450);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPageFiltre
            // 
            this.tabPageFiltre.BackColor = System.Drawing.Color.Transparent;
            this.tabPageFiltre.Controls.Add(this.groupBox2);
            this.tabPageFiltre.Controls.Add(this.groupBox4);
            this.tabPageFiltre.Location = new System.Drawing.Point(4, 22);
            this.tabPageFiltre.Name = "tabPageFiltre";
            this.tabPageFiltre.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFiltre.Size = new System.Drawing.Size(981, 424);
            this.tabPageFiltre.TabIndex = 0;
            this.tabPageFiltre.Text = "StokMaliyetRaporu";
            this.tabPageFiltre.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnPrint);
            this.groupBox4.Controls.Add(this.btnRapor);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(975, 215);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(690, 19);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(49, 31);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnRapor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRapor.Location = new System.Drawing.Point(609, 19);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(75, 66);
            this.btnRapor.TabIndex = 12;
            this.btnRapor.Text = "Rapor";
            this.btnRapor.UseVisualStyleBackColor = false;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGrupRehber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtStokGrup);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.grbStokKodu);
            this.groupBox1.Controls.Add(this.rbStokKodu);
            this.groupBox1.Controls.Add(this.rbButunStoklar);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 184);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama Seçenekleri";
            // 
            // btnGrupRehber
            // 
            this.btnGrupRehber.Location = new System.Drawing.Point(211, 149);
            this.btnGrupRehber.Name = "btnGrupRehber";
            this.btnGrupRehber.Size = new System.Drawing.Size(34, 20);
            this.btnGrupRehber.TabIndex = 16;
            this.btnGrupRehber.Text = "...";
            this.btnGrupRehber.UseVisualStyleBackColor = true;
            this.btnGrupRehber.Click += new System.EventHandler(this.btnGrupRehber_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "StokGrubu";
            // 
            // txtStokGrup
            // 
            this.txtStokGrup.Ayirac = null;
            this.txtStokGrup.AyracBoslukKullan = false;
            this.txtStokGrup.DataSource = null;
            this.txtStokGrup.ListForeColor = System.Drawing.Color.Empty;
            this.txtStokGrup.ListItemColor = System.Drawing.Color.DarkOrange;
            this.txtStokGrup.Location = new System.Drawing.Point(72, 149);
            this.txtStokGrup.Name = "txtStokGrup";
            this.txtStokGrup.NextTabControlName = null;
            this.txtStokGrup.Size = new System.Drawing.Size(133, 20);
            this.txtStokGrup.TabIndex = 17;
            this.txtStokGrup.WidthAutoComplete = 133;
            this.txtStokGrup.WidthKod = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.grbTarih);
            this.groupBox6.Controls.Add(this.rbTarihAralikli);
            this.groupBox6.Controls.Add(this.rbButunTarih);
            this.groupBox6.Location = new System.Drawing.Point(297, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(267, 117);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tarih";
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
            // grbStokKodu
            // 
            this.grbStokKodu.Controls.Add(this.btnStokRehber);
            this.grbStokKodu.Controls.Add(this.label5);
            this.grbStokKodu.Controls.Add(this.txtStokKodu);
            this.grbStokKodu.Enabled = false;
            this.grbStokKodu.Location = new System.Drawing.Point(7, 64);
            this.grbStokKodu.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.grbStokKodu.Name = "grbStokKodu";
            this.grbStokKodu.Size = new System.Drawing.Size(267, 72);
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
            this.txtStokKodu.Location = new System.Drawing.Point(65, 15);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.NextTabControlName = null;
            this.txtStokKodu.Size = new System.Drawing.Size(133, 20);
            this.txtStokKodu.TabIndex = 5;
            this.txtStokKodu.WidthAutoComplete = 300;
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
            this.tslabToplamAlisMiktar,
            this.toolStripStatusLabel2,
            this.tslabToplamSatisMiktar,
            this.toolStripStatusLabel3,
            this.tslabEldekiMalMiktar,
            this.toolStripStatusLabel4,
            this.tslabToplamAlisTutar,
            this.toolStripStatusLabel5,
            this.tslabToplamSatisTutar,
            this.toolStripStatusLabel6,
            this.tslabTopKalanMalinMaliyeti});
            this.statusStrip1.Location = new System.Drawing.Point(3, 16);
            this.statusStrip1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(989, 27);
            this.statusStrip1.TabIndex = 1006;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(104, 22);
            this.toolStripStatusLabel1.Text = "ToplamAlışMiktar:";
            // 
            // tslabToplamAlisMiktar
            // 
            this.tslabToplamAlisMiktar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tslabToplamAlisMiktar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tslabToplamAlisMiktar.Name = "tslabToplamAlisMiktar";
            this.tslabToplamAlisMiktar.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(106, 22);
            this.toolStripStatusLabel2.Text = "ToplamSatışMiktar";
            // 
            // tslabToplamSatisMiktar
            // 
            this.tslabToplamSatisMiktar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tslabToplamSatisMiktar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tslabToplamSatisMiktar.Name = "tslabToplamSatisMiktar";
            this.tslabToplamSatisMiktar.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(98, 22);
            this.toolStripStatusLabel3.Text = "EldekiMalMiktarı:";
            // 
            // tslabEldekiMalMiktar
            // 
            this.tslabEldekiMalMiktar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tslabEldekiMalMiktar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tslabEldekiMalMiktar.Name = "tslabEldekiMalMiktar";
            this.tslabEldekiMalMiktar.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(101, 22);
            this.toolStripStatusLabel4.Text = "ToplamAlışTutarı:";
            // 
            // tslabToplamAlisTutar
            // 
            this.tslabToplamAlisTutar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tslabToplamAlisTutar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tslabToplamAlisTutar.Name = "tslabToplamAlisTutar";
            this.tslabToplamAlisTutar.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(103, 22);
            this.toolStripStatusLabel5.Text = "ToplamSatışTutar:";
            // 
            // tslabToplamSatisTutar
            // 
            this.tslabToplamSatisTutar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tslabToplamSatisTutar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tslabToplamSatisTutar.Name = "tslabToplamSatisTutar";
            this.tslabToplamSatisTutar.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(149, 22);
            this.toolStripStatusLabel6.Text = "ToplamKalanMalınMaliyeti";
            // 
            // tslabTopKalanMalinMaliyeti
            // 
            this.tslabTopKalanMalinMaliyeti.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tslabTopKalanMalinMaliyeti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tslabTopKalanMalinMaliyeti.Name = "tslabTopKalanMalinMaliyeti";
            this.tslabTopKalanMalinMaliyeti.Size = new System.Drawing.Size(0, 22);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.statusStrip1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 469);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(995, 46);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tabControl1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(995, 469);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kalanMiktarSifirUstu,
            this.kalanMiktarEksiyeDusenlerListesiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(263, 48);
            this.contextMenuStrip1.Tag = "Faturaya git";
            // 
            // kalanMiktarSifirUstu
            // 
            this.kalanMiktarSifirUstu.Name = "kalanMiktarSifirUstu";
            this.kalanMiktarSifirUstu.Size = new System.Drawing.Size(262, 22);
            this.kalanMiktarSifirUstu.Text = "Kalan miktar 0 ın üstündekiler listesi";
            this.kalanMiktarSifirUstu.Click += new System.EventHandler(this.kalanMiktarSifirUstu_Click);
            // 
            // kalanMiktarEksiyeDusenlerListesiToolStripMenuItem
            // 
            this.kalanMiktarEksiyeDusenlerListesiToolStripMenuItem.Name = "kalanMiktarEksiyeDusenlerListesiToolStripMenuItem";
            this.kalanMiktarEksiyeDusenlerListesiToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.kalanMiktarEksiyeDusenlerListesiToolStripMenuItem.Text = "Kalan miktar eksiye düşenler listesi";
            this.kalanMiktarEksiyeDusenlerListesiToolStripMenuItem.Click += new System.EventHandler(this.kalanMiktarEksiyeDusenlerListesiToolStripMenuItem_Click);
            // 
            // kalanMiktarSifirinUstundeOlanlarToolStripMenuItem
            // 
            this.kalanMiktarSifirinUstundeOlanlarToolStripMenuItem.Name = "kalanMiktarSifirinUstundeOlanlarToolStripMenuItem";
            this.kalanMiktarSifirinUstundeOlanlarToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.kalanMiktarSifirinUstundeOlanlarToolStripMenuItem.Text = "Kalan Miktar sıfırın üstünde olanlar";
            this.kalanMiktarSifirinUstundeOlanlarToolStripMenuItem.Click += new System.EventHandler(this.kalanMiktarSifirinUstundeOlanlarToolStripMenuItem_Click);
            // 
            // kalanMiktarSifirinAltindaOlanlarToolStripMenuItem
            // 
            this.kalanMiktarSifirinAltindaOlanlarToolStripMenuItem.Name = "kalanMiktarSifirinAltindaOlanlarToolStripMenuItem";
            this.kalanMiktarSifirinAltindaOlanlarToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.kalanMiktarSifirinAltindaOlanlarToolStripMenuItem.Text = "Kalan Miktar sıfırın altında olanlar";
            this.kalanMiktarSifirinAltindaOlanlarToolStripMenuItem.Click += new System.EventHandler(this.kalanMiktarSifirinAltindaOlanlarToolStripMenuItem_Click);
            // 
            // frmStokMaliyetRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 515);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmStokMaliyetRaporu";
            this.Text = "StokMaliyetRaporu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.cmsStokListesi.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageFiltre.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.grbTarih.ResumeLayout(false);
            this.grbTarih.PerformLayout();
            this.grbStokKodu.ResumeLayout(false);
            this.grbStokKodu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFiltre;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tslabToplamAlisMiktar;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbStokKodu;
        private System.Windows.Forms.Button btnStokRehber;
        private System.Windows.Forms.Label label5;
        public IndeksControl.AutoCompleteTextBox txtStokKodu;
        private System.Windows.Forms.RadioButton rbStokKodu;
        private System.Windows.Forms.RadioButton rbButunStoklar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox grbTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpFinish;
        private System.Windows.Forms.RadioButton rbTarihAralikli;
        private System.Windows.Forms.RadioButton rbButunTarih;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tslabToplamSatisMiktar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tslabEldekiMalMiktar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel tslabToplamAlisTutar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel tslabToplamSatisTutar;
        private System.Windows.Forms.Button btnGrupRehber;
        private System.Windows.Forms.Label label1;
        public IndeksControl.AutoCompleteTextBox txtStokGrup;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel tslabTopKalanMalinMaliyeti;
        private System.Windows.Forms.ContextMenuStrip cmsStokListesi;
        private System.Windows.Forms.ToolStripMenuItem stokListesiToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kalanMiktarSifirUstu;
        private System.Windows.Forms.ToolStripMenuItem kalanMiktarEksiyeDusenlerListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kalanMiktarSifirinUstundeOlanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kalanMiktarSifirinAltindaOlanlarToolStripMenuItem;
    }
}