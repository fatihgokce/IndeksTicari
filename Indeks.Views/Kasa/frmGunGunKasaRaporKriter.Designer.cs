namespace Indeks.Views {
    partial class frmGunGunKasaRaporKriter {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGunGunKasaRaporKriter));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFiltre = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGelirToplam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiderToplam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBakiye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbHepsi = new System.Windows.Forms.CheckBox();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBoxHareketTipleri = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFinish = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.cmboxKasalar = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslabToplamGelir = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslabToplamGider = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslabToplamBakiye = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPageFiltre.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFiltre);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(940, 444);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageFiltre
            // 
            this.tabPageFiltre.BackColor = System.Drawing.Color.Transparent;
            this.tabPageFiltre.Controls.Add(this.groupBox3);
            this.tabPageFiltre.Controls.Add(this.groupBox2);
            this.tabPageFiltre.Location = new System.Drawing.Point(4, 22);
            this.tabPageFiltre.Name = "tabPageFiltre";
            this.tabPageFiltre.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFiltre.Size = new System.Drawing.Size(932, 418);
            this.tabPageFiltre.TabIndex = 0;
            this.tabPageFiltre.Text = "Gün gün Kasa Raporu";
            this.tabPageFiltre.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 321);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(926, 94);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
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
            this.clGelirToplam,
            this.clGiderToplam,
            this.clBakiye});
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
            this.dataGridView1.Size = new System.Drawing.Size(920, 75);
            this.dataGridView1.TabIndex = 1002;
            // 
            // clTarih
            // 
            this.clTarih.DataPropertyName = "Tarih";
            this.clTarih.HeaderText = "Tarih";
            this.clTarih.Name = "clTarih";
            this.clTarih.ReadOnly = true;
            this.clTarih.Width = 56;
            // 
            // clGelirToplam
            // 
            this.clGelirToplam.DataPropertyName = "Gelir";
            this.clGelirToplam.HeaderText = "Gelir";
            this.clGelirToplam.Name = "clGelirToplam";
            this.clGelirToplam.ReadOnly = true;
            this.clGelirToplam.Width = 53;
            // 
            // clGiderToplam
            // 
            this.clGiderToplam.DataPropertyName = "Gider";
            this.clGiderToplam.HeaderText = "Gider";
            this.clGiderToplam.Name = "clGiderToplam";
            this.clGiderToplam.ReadOnly = true;
            this.clGiderToplam.Width = 57;
            // 
            // clBakiye
            // 
            this.clBakiye.DataPropertyName = "Bakiye";
            this.clBakiye.HeaderText = "Bakiye";
            this.clBakiye.Name = "clBakiye";
            this.clBakiye.ReadOnly = true;
            this.clBakiye.Width = 64;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbHepsi);
            this.groupBox2.Controls.Add(this.btnRapor);
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpFinish);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpStart);
            this.groupBox2.Controls.Add(this.cmboxKasalar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(926, 318);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // chbHepsi
            // 
            this.chbHepsi.AutoSize = true;
            this.chbHepsi.Location = new System.Drawing.Point(9, 84);
            this.chbHepsi.Name = "chbHepsi";
            this.chbHepsi.Size = new System.Drawing.Size(80, 17);
            this.chbHepsi.TabIndex = 12;
            this.chbHepsi.Text = "HepsiniSeç";
            this.chbHepsi.UseVisualStyleBackColor = true;
            this.chbHepsi.CheckedChanged += new System.EventHandler(this.chbHepsi_CheckedChanged);
            // 
            // btnRapor
            // 
            this.btnRapor.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnRapor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRapor.Location = new System.Drawing.Point(257, 16);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(75, 66);
            this.btnRapor.TabIndex = 11;
            this.btnRapor.Text = "Rapor";
            this.btnRapor.UseVisualStyleBackColor = false;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(338, 16);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(49, 31);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBoxHareketTipleri);
            this.groupBox1.Location = new System.Drawing.Point(9, 106);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tarih Aralığı";
            // 
            // dtpFinish
            // 
            this.dtpFinish.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinish.Location = new System.Drawing.Point(123, 57);
            this.dtpFinish.Name = "dtpFinish";
            this.dtpFinish.Size = new System.Drawing.Size(102, 20);
            this.dtpFinish.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "KasaKodu";
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(9, 57);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(102, 20);
            this.dtpStart.TabIndex = 8;
            // 
            // cmboxKasalar
            // 
            this.cmboxKasalar.FormattingEnabled = true;
            this.cmboxKasalar.Location = new System.Drawing.Point(85, 16);
            this.cmboxKasalar.Name = "cmboxKasalar";
            this.cmboxKasalar.Size = new System.Drawing.Size(140, 21);
            this.cmboxKasalar.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.statusStrip1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 463);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(946, 45);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tslabToplamGelir,
            this.toolStripStatusLabel2,
            this.tslabToplamGider,
            this.toolStripStatusLabel3,
            this.tslabToplamBakiye});
            this.statusStrip1.Location = new System.Drawing.Point(3, 16);
            this.statusStrip1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(940, 26);
            this.statusStrip1.TabIndex = 1006;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(78, 21);
            this.toolStripStatusLabel1.Text = "Toplam Gelir:";
            // 
            // tslabToplamGelir
            // 
            this.tslabToplamGelir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tslabToplamGelir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tslabToplamGelir.Name = "tslabToplamGelir";
            this.tslabToplamGelir.Size = new System.Drawing.Size(0, 21);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(79, 21);
            this.toolStripStatusLabel2.Text = "ToplamGider:";
            // 
            // tslabToplamGider
            // 
            this.tslabToplamGider.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tslabToplamGider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tslabToplamGider.Name = "tslabToplamGider";
            this.tslabToplamGider.Size = new System.Drawing.Size(0, 21);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(85, 21);
            this.toolStripStatusLabel3.Text = "ToplamBakiye:";
            // 
            // tslabToplamBakiye
            // 
            this.tslabToplamBakiye.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tslabToplamBakiye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tslabToplamBakiye.Name = "tslabToplamBakiye";
            this.tslabToplamBakiye.Size = new System.Drawing.Size(0, 21);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tabControl1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(946, 463);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            // 
            // frmGunGunKasaRaporKriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(946, 508);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.KeyPreview = true;
            this.Name = "frmGunGunKasaRaporKriter";
            this.Text = "GünVeGünKasaRaporu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPageFiltre.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFiltre;
        private System.Windows.Forms.ComboBox cmboxKasalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFinish;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckedListBox checkedListBoxHareketTipleri;
        private System.Windows.Forms.CheckBox chbHepsi;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGelirToplam;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiderToplam;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBakiye;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tslabToplamGelir;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tslabToplamGider;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tslabToplamBakiye;

    }
}