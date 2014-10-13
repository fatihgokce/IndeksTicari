namespace Indeks.Views {
    partial class frmSiparisRapor {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSiparisRapor));
            this.groupBoxIrsaliyeFatura = new System.Windows.Forms.GroupBox();
            this.btnCariRehber = new System.Windows.Forms.Button();
            this.dtTarBitTar = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtTarBasTar = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFiltre = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbVadeTarih = new System.Windows.Forms.GroupBox();
            this.dtTesBitTar = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTesBasTar = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.gbTarih = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grbCariKodu = new System.Windows.Forms.GroupBox();
            this.txtCariKodu = new IndeksControl.AutoCompleteTextBox();
            this.tslabToplamIskonto = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslabToplamKdvTutar = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslabToplamBrutTutar = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslabToplamTutar = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbMusteriSip = new System.Windows.Forms.CheckBox();
            this.cbSaticiSip = new System.Windows.Forms.CheckBox();
            this.groupBoxIrsaliyeFatura.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageFiltre.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbVadeTarih.SuspendLayout();
            this.gbTarih.SuspendLayout();
            this.grbCariKodu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxIrsaliyeFatura
            // 
            this.groupBoxIrsaliyeFatura.Controls.Add(this.cbSaticiSip);
            this.groupBoxIrsaliyeFatura.Controls.Add(this.cbMusteriSip);
            this.groupBoxIrsaliyeFatura.Location = new System.Drawing.Point(6, 19);
            this.groupBoxIrsaliyeFatura.Name = "groupBoxIrsaliyeFatura";
            this.groupBoxIrsaliyeFatura.Size = new System.Drawing.Size(245, 57);
            this.groupBoxIrsaliyeFatura.TabIndex = 12;
            this.groupBoxIrsaliyeFatura.TabStop = false;
            this.groupBoxIrsaliyeFatura.Text = "SiparişTipleri";
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
            // dtTarBitTar
            // 
            this.dtTarBitTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarBitTar.Location = new System.Drawing.Point(11, 71);
            this.dtTarBitTar.Name = "dtTarBitTar";
            this.dtTarBitTar.Size = new System.Drawing.Size(153, 20);
            this.dtTarBitTar.TabIndex = 1;
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
            // dtTarBasTar
            // 
            this.dtTarBasTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarBasTar.Location = new System.Drawing.Point(11, 32);
            this.dtTarBasTar.Name = "dtTarBasTar";
            this.dtTarBasTar.Size = new System.Drawing.Size(153, 20);
            this.dtTarBasTar.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tabControl1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1155, 491);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFiltre);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1149, 472);
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
            this.tabPageFiltre.Size = new System.Drawing.Size(1141, 446);
            this.tabPageFiltre.TabIndex = 0;
            this.tabPageFiltre.Text = "Sipariş Raporu";
            this.tabPageFiltre.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1135, 189);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.dataGridView1.Size = new System.Drawing.Size(1129, 170);
            this.dataGridView1.TabIndex = 1003;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnPrint);
            this.groupBox4.Controls.Add(this.btnRapor);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1135, 251);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(600, 19);
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
            this.btnRapor.Location = new System.Drawing.Point(519, 19);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(75, 66);
            this.btnRapor.TabIndex = 12;
            this.btnRapor.Text = "Rapor";
            this.btnRapor.UseVisualStyleBackColor = false;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbVadeTarih);
            this.groupBox1.Controls.Add(this.gbTarih);
            this.groupBox1.Controls.Add(this.grbCariKodu);
            this.groupBox1.Controls.Add(this.groupBoxIrsaliyeFatura);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 228);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama Seçenekleri";
            // 
            // gbVadeTarih
            // 
            this.gbVadeTarih.Controls.Add(this.dtTesBitTar);
            this.gbVadeTarih.Controls.Add(this.label2);
            this.gbVadeTarih.Controls.Add(this.dtTesBasTar);
            this.gbVadeTarih.Controls.Add(this.label6);
            this.gbVadeTarih.Location = new System.Drawing.Point(275, 121);
            this.gbVadeTarih.Name = "gbVadeTarih";
            this.gbVadeTarih.Size = new System.Drawing.Size(177, 96);
            this.gbVadeTarih.TabIndex = 28;
            this.gbVadeTarih.TabStop = false;
            this.gbVadeTarih.Text = "Teslim Tarihi";
            // 
            // dtTesBitTar
            // 
            this.dtTesBitTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTesBitTar.Location = new System.Drawing.Point(11, 71);
            this.dtTesBitTar.Name = "dtTesBitTar";
            this.dtTesBitTar.Size = new System.Drawing.Size(153, 20);
            this.dtTesBitTar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bitiş Tarih";
            // 
            // dtTesBasTar
            // 
            this.dtTesBasTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTesBasTar.Location = new System.Drawing.Point(11, 32);
            this.dtTesBasTar.Name = "dtTesBasTar";
            this.dtTesBasTar.Size = new System.Drawing.Size(153, 20);
            this.dtTesBasTar.TabIndex = 0;
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
            this.gbTarih.Location = new System.Drawing.Point(275, 19);
            this.gbTarih.Name = "gbTarih";
            this.gbTarih.Size = new System.Drawing.Size(177, 96);
            this.gbTarih.TabIndex = 27;
            this.gbTarih.TabStop = false;
            this.gbTarih.Text = "Tarih";
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
            // grbCariKodu
            // 
            this.grbCariKodu.Controls.Add(this.txtCariKodu);
            this.grbCariKodu.Controls.Add(this.btnCariRehber);
            this.grbCariKodu.Controls.Add(this.label5);
            this.grbCariKodu.Location = new System.Drawing.Point(9, 79);
            this.grbCariKodu.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.grbCariKodu.Name = "grbCariKodu";
            this.grbCariKodu.Size = new System.Drawing.Size(242, 47);
            this.grbCariKodu.TabIndex = 14;
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
            // tslabToplamIskonto
            // 
            this.tslabToplamIskonto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tslabToplamIskonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tslabToplamIskonto.Name = "tslabToplamIskonto";
            this.tslabToplamIskonto.Size = new System.Drawing.Size(0, 22);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tslabToplamKdvTutar,
            this.toolStripStatusLabel2,
            this.tslabToplamBrutTutar,
            this.toolStripStatusLabel4,
            this.tslabToplamIskonto,
            this.toolStripStatusLabel3,
            this.tslabToplamTutar});
            this.statusStrip1.Location = new System.Drawing.Point(3, 16);
            this.statusStrip1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1149, 27);
            this.statusStrip1.TabIndex = 1006;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(99, 22);
            this.toolStripStatusLabel1.Text = "ToplamKdvTutar:";
            // 
            // tslabToplamKdvTutar
            // 
            this.tslabToplamKdvTutar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tslabToplamKdvTutar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tslabToplamKdvTutar.Name = "tslabToplamKdvTutar";
            this.tslabToplamKdvTutar.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(101, 22);
            this.toolStripStatusLabel2.Text = "ToplamBrütTutar:";
            // 
            // tslabToplamBrutTutar
            // 
            this.tslabToplamBrutTutar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tslabToplamBrutTutar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tslabToplamBrutTutar.Name = "tslabToplamBrutTutar";
            this.tslabToplamBrutTutar.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(87, 22);
            this.toolStripStatusLabel4.Text = "ToplamIskonto";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(79, 22);
            this.toolStripStatusLabel3.Text = "ToplamTutar:";
            // 
            // tslabToplamTutar
            // 
            this.tslabToplamTutar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tslabToplamTutar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tslabToplamTutar.Name = "tslabToplamTutar";
            this.tslabToplamTutar.Size = new System.Drawing.Size(0, 22);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.statusStrip1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 491);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1155, 46);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // cbMusteriSip
            // 
            this.cbMusteriSip.AutoSize = true;
            this.cbMusteriSip.Location = new System.Drawing.Point(3, 16);
            this.cbMusteriSip.Name = "cbMusteriSip";
            this.cbMusteriSip.Size = new System.Drawing.Size(93, 17);
            this.cbMusteriSip.TabIndex = 0;
            this.cbMusteriSip.Text = "MüşteriSiparişi";
            this.cbMusteriSip.UseVisualStyleBackColor = true;
            // 
            // cbSaticiSip
            // 
            this.cbSaticiSip.AutoSize = true;
            this.cbSaticiSip.Location = new System.Drawing.Point(3, 34);
            this.cbSaticiSip.Name = "cbSaticiSip";
            this.cbSaticiSip.Size = new System.Drawing.Size(85, 17);
            this.cbSaticiSip.TabIndex = 1;
            this.cbSaticiSip.Text = "SatıcıSiparişi";
            this.cbSaticiSip.UseVisualStyleBackColor = true;
            // 
            // frmSiparisRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 537);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmSiparisRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiparisRapor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBoxIrsaliyeFatura.ResumeLayout(false);
            this.groupBoxIrsaliyeFatura.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageFiltre.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbVadeTarih.ResumeLayout(false);
            this.gbVadeTarih.PerformLayout();
            this.gbTarih.ResumeLayout(false);
            this.gbTarih.PerformLayout();
            this.grbCariKodu.ResumeLayout(false);
            this.grbCariKodu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIrsaliyeFatura;
        private System.Windows.Forms.Button btnCariRehber;
        private System.Windows.Forms.DateTimePicker dtTarBitTar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtTarBasTar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFiltre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbVadeTarih;
        private System.Windows.Forms.DateTimePicker dtTesBitTar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTesBasTar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbTarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbCariKodu;
        public IndeksControl.AutoCompleteTextBox txtCariKodu;
        private System.Windows.Forms.ToolStripStatusLabel tslabToplamIskonto;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tslabToplamKdvTutar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tslabToplamBrutTutar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tslabToplamTutar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbSaticiSip;
        private System.Windows.Forms.CheckBox cbMusteriSip;
    }
}