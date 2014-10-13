namespace Indeks.Views {
    partial class frmOzelGelirGiderRapor {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOzelGelirGiderRapor));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslabToplamKdvTutar = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslabToplamTutar = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFinish = new System.Windows.Forms.DateTimePicker();
            this.grbOzelGelirGider = new System.Windows.Forms.GroupBox();
            this.btnOzelRehber = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOzelGelirGiderKod = new IndeksControl.AutoCompleteTextBox();
            this.rbOzelGelirGiderLod = new System.Windows.Forms.RadioButton();
            this.rbButunGelirGider = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbOzelGelirGider.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Size = new System.Drawing.Size(872, 253);
            this.dataGridView1.TabIndex = 1004;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tslabToplamKdvTutar,
            this.toolStripStatusLabel2,
            this.tslabToplamTutar});
            this.statusStrip1.Location = new System.Drawing.Point(3, 16);
            this.statusStrip1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(892, 27);
            this.statusStrip1.TabIndex = 1006;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(102, 22);
            this.toolStripStatusLabel1.Text = "Toplam KdvTutar:";
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
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(79, 22);
            this.toolStripStatusLabel2.Text = "ToplamTutar:";
            // 
            // tslabToplamTutar
            // 
            this.tslabToplamTutar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tslabToplamTutar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tslabToplamTutar.Name = "tslabToplamTutar";
            this.tslabToplamTutar.Size = new System.Drawing.Size(0, 22);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(362, 25);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(49, 31);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnRapor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRapor.Location = new System.Drawing.Point(281, 25);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(75, 66);
            this.btnRapor.TabIndex = 15;
            this.btnRapor.Text = "Rapor";
            this.btnRapor.UseVisualStyleBackColor = false;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpStart);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpFinish);
            this.groupBox2.Controls.Add(this.grbOzelGelirGider);
            this.groupBox2.Controls.Add(this.rbOzelGelirGiderLod);
            this.groupBox2.Controls.Add(this.rbButunGelirGider);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 179);
            this.groupBox2.TabIndex = 14;
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
            // grbOzelGelirGider
            // 
            this.grbOzelGelirGider.Controls.Add(this.btnOzelRehber);
            this.grbOzelGelirGider.Controls.Add(this.label5);
            this.grbOzelGelirGider.Controls.Add(this.txtOzelGelirGiderKod);
            this.grbOzelGelirGider.Enabled = false;
            this.grbOzelGelirGider.Location = new System.Drawing.Point(7, 64);
            this.grbOzelGelirGider.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.grbOzelGelirGider.Name = "grbOzelGelirGider";
            this.grbOzelGelirGider.Size = new System.Drawing.Size(247, 55);
            this.grbOzelGelirGider.TabIndex = 2;
            this.grbOzelGelirGider.TabStop = false;
            // 
            // btnOzelRehber
            // 
            this.btnOzelRehber.Location = new System.Drawing.Point(174, 16);
            this.btnOzelRehber.Name = "btnOzelRehber";
            this.btnOzelRehber.Size = new System.Drawing.Size(34, 20);
            this.btnOzelRehber.TabIndex = 4;
            this.btnOzelRehber.Text = "...";
            this.btnOzelRehber.UseVisualStyleBackColor = true;
            this.btnOzelRehber.Click += new System.EventHandler(this.btnOzelRehber_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(5, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kod";
            // 
            // txtOzelGelirGiderKod
            // 
            this.txtOzelGelirGiderKod.Ayirac = null;
            this.txtOzelGelirGiderKod.AyracBoslukKullan = false;
            this.txtOzelGelirGiderKod.DataSource = null;
            this.txtOzelGelirGiderKod.ListForeColor = System.Drawing.Color.Empty;
            this.txtOzelGelirGiderKod.ListItemColor = System.Drawing.Color.DarkOrange;
            this.txtOzelGelirGiderKod.Location = new System.Drawing.Point(53, 16);
            this.txtOzelGelirGiderKod.Name = "txtOzelGelirGiderKod";
            this.txtOzelGelirGiderKod.NextTabControlName = null;
            this.txtOzelGelirGiderKod.Size = new System.Drawing.Size(100, 20);
            this.txtOzelGelirGiderKod.TabIndex = 5;
            this.txtOzelGelirGiderKod.WidthAutoComplete = 100;
            this.txtOzelGelirGiderKod.WidthKod = 0;
            // 
            // rbOzelGelirGiderLod
            // 
            this.rbOzelGelirGiderLod.AutoSize = true;
            this.rbOzelGelirGiderLod.Location = new System.Drawing.Point(7, 44);
            this.rbOzelGelirGiderLod.Name = "rbOzelGelirGiderLod";
            this.rbOzelGelirGiderLod.Size = new System.Drawing.Size(111, 17);
            this.rbOzelGelirGiderLod.TabIndex = 1;
            this.rbOzelGelirGiderLod.Text = "ÖzelGelirGiderKod";
            this.rbOzelGelirGiderLod.UseVisualStyleBackColor = true;
            this.rbOzelGelirGiderLod.Click += new System.EventHandler(this.rbButunGelirGider_CheckedChanged);
            // 
            // rbButunGelirGider
            // 
            this.rbButunGelirGider.AutoSize = true;
            this.rbButunGelirGider.Checked = true;
            this.rbButunGelirGider.Location = new System.Drawing.Point(7, 20);
            this.rbButunGelirGider.Name = "rbButunGelirGider";
            this.rbButunGelirGider.Size = new System.Drawing.Size(89, 17);
            this.rbButunGelirGider.TabIndex = 0;
            this.rbButunGelirGider.TabStop = true;
            this.rbButunGelirGider.Text = "Bütün Stoklar";
            this.rbButunGelirGider.UseVisualStyleBackColor = true;
            this.rbButunGelirGider.Click += new System.EventHandler(this.rbButunGelirGider_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(892, 509);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(884, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ÖzelGelirGiderRaporu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 208);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(878, 272);
            this.groupBox4.TabIndex = 1005;
            this.groupBox4.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.btnRapor);
            this.groupBox3.Controls.Add(this.btnPrint);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(878, 205);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.statusStrip1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Location = new System.Drawing.Point(0, 528);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(898, 46);
            this.groupBox5.TabIndex = 1007;
            this.groupBox5.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(898, 528);
            this.groupBox1.TabIndex = 1008;
            this.groupBox1.TabStop = false;
            // 
            // frmOzelGelirGiderRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 574);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Name = "frmOzelGelirGiderRapor";
            this.Text = "ÖzelGelirGiderRapor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbOzelGelirGider.ResumeLayout(false);
            this.grbOzelGelirGider.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tslabToplamKdvTutar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tslabToplamTutar;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFinish;
        private System.Windows.Forms.GroupBox grbOzelGelirGider;
        private System.Windows.Forms.Button btnOzelRehber;
        private System.Windows.Forms.Label label5;
        public IndeksControl.AutoCompleteTextBox txtOzelGelirGiderKod;
        private System.Windows.Forms.RadioButton rbOzelGelirGiderLod;
        private System.Windows.Forms.RadioButton rbButunGelirGider;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}