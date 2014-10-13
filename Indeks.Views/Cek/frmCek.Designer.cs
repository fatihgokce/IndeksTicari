namespace Indeks.Views {
    partial class frmCek {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCek = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDuzelt = new System.Windows.Forms.Button();
            this.cmbCekDurum = new System.Windows.Forms.ComboBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAnahtarKelime = new System.Windows.Forms.TextBox();
            this.btnCekDurum = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnYeniCek = new System.Windows.Forms.Button();
            this.cmbCekTip = new System.Windows.Forms.ComboBox();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCariKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCekTip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIslemTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clVadeTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBanka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsubeAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHesapNumarasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAsilSahibi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKayitTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCek)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewCek);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dataGridViewCek
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridViewCek.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewCek.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCek.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clCariKodu,
            this.clCekTip,
            this.clDurum,
            this.clIslemTarih,
            this.clVadeTarih,
            this.clTutar,
            this.clBanka,
            this.clsubeAdi,
            this.clHesapNumarasi,
            this.clAsilSahibi,
            this.clKayitTarih,
            this.clAciklama});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCek.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCek.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewCek.MultiSelect = false;
            this.dataGridViewCek.Name = "dataGridViewCek";
            this.dataGridViewCek.ReadOnly = true;
            this.dataGridViewCek.RowHeadersVisible = false;
            this.dataGridViewCek.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCek.Size = new System.Drawing.Size(749, 280);
            this.dataGridViewCek.TabIndex = 4;
            this.dataGridViewCek.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCek_CellDoubleClick);
            this.dataGridViewCek.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCek_CellClick);
            this.dataGridViewCek.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCek_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDuzelt);
            this.groupBox2.Controls.Add(this.cmbCekDurum);
            this.groupBox2.Controls.Add(this.btnAra);
            this.groupBox2.Controls.Add(this.txtAnahtarKelime);
            this.groupBox2.Controls.Add(this.btnCekDurum);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnYeniCek);
            this.groupBox2.Controls.Add(this.cmbCekTip);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 105);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnDuzelt
            // 
            this.btnDuzelt.Location = new System.Drawing.Point(227, 73);
            this.btnDuzelt.Name = "btnDuzelt";
            this.btnDuzelt.Size = new System.Drawing.Size(75, 23);
            this.btnDuzelt.TabIndex = 7;
            this.btnDuzelt.Text = "Düzelt";
            this.btnDuzelt.UseVisualStyleBackColor = true;
            this.btnDuzelt.Click += new System.EventHandler(this.btnDuzelt_Click);
            // 
            // cmbCekDurum
            // 
            this.cmbCekDurum.FormattingEnabled = true;
            this.cmbCekDurum.Location = new System.Drawing.Point(133, 19);
            this.cmbCekDurum.Name = "cmbCekDurum";
            this.cmbCekDurum.Size = new System.Drawing.Size(121, 21);
            this.cmbCekDurum.TabIndex = 6;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(260, 19);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(47, 23);
            this.btnAra.TabIndex = 5;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAnahtarKelime
            // 
            this.txtAnahtarKelime.Location = new System.Drawing.Point(6, 19);
            this.txtAnahtarKelime.Name = "txtAnahtarKelime";
            this.txtAnahtarKelime.Size = new System.Drawing.Size(121, 20);
            this.txtAnahtarKelime.TabIndex = 4;
            this.txtAnahtarKelime.Text = "Aranacak kelime...";
            this.txtAnahtarKelime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAnahtarKelime_KeyDown);
            this.txtAnahtarKelime.Leave += new System.EventHandler(this.txtAnahtarKelime_Leave);
            // 
            // btnCekDurum
            // 
            this.btnCekDurum.Location = new System.Drawing.Point(389, 73);
            this.btnCekDurum.Name = "btnCekDurum";
            this.btnCekDurum.Size = new System.Drawing.Size(75, 23);
            this.btnCekDurum.TabIndex = 3;
            this.btnCekDurum.Text = "Durum";
            this.btnCekDurum.UseVisualStyleBackColor = true;
            this.btnCekDurum.Click += new System.EventHandler(this.btnCekDurum_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(308, 73);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnYeniCek
            // 
            this.btnYeniCek.Location = new System.Drawing.Point(146, 73);
            this.btnYeniCek.Name = "btnYeniCek";
            this.btnYeniCek.Size = new System.Drawing.Size(75, 23);
            this.btnYeniCek.TabIndex = 1;
            this.btnYeniCek.Text = "Yeni";
            this.btnYeniCek.UseVisualStyleBackColor = true;
            this.btnYeniCek.Click += new System.EventHandler(this.btnYeniCek_Click);
            // 
            // cmbCekTip
            // 
            this.cmbCekTip.FormattingEnabled = true;
            this.cmbCekTip.Location = new System.Drawing.Point(6, 73);
            this.cmbCekTip.Name = "cmbCekTip";
            this.cmbCekTip.Size = new System.Drawing.Size(121, 21);
            this.cmbCekTip.TabIndex = 0;
            // 
            // clId
            // 
            this.clId.DataPropertyName = "Id";
            this.clId.HeaderText = "Id";
            this.clId.Name = "clId";
            this.clId.ReadOnly = true;
            this.clId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clId.Width = 41;
            // 
            // clCariKodu
            // 
            this.clCariKodu.DataPropertyName = "CariKodu";
            this.clCariKodu.HeaderText = "CariKodu";
            this.clCariKodu.Name = "clCariKodu";
            this.clCariKodu.ReadOnly = true;
            this.clCariKodu.Width = 75;
            // 
            // clCekTip
            // 
            this.clCekTip.DataPropertyName = "CekTip";
            this.clCekTip.HeaderText = "ÇekTip";
            this.clCekTip.Name = "clCekTip";
            this.clCekTip.ReadOnly = true;
            this.clCekTip.Width = 66;
            // 
            // clDurum
            // 
            this.clDurum.DataPropertyName = "CekDurum";
            this.clDurum.HeaderText = "Durum";
            this.clDurum.Name = "clDurum";
            this.clDurum.ReadOnly = true;
            this.clDurum.Width = 63;
            // 
            // clIslemTarih
            // 
            this.clIslemTarih.DataPropertyName = "IslemTarih";
            this.clIslemTarih.HeaderText = "İşlemTarih";
            this.clIslemTarih.Name = "clIslemTarih";
            this.clIslemTarih.ReadOnly = true;
            this.clIslemTarih.Width = 80;
            // 
            // clVadeTarih
            // 
            this.clVadeTarih.DataPropertyName = "VadeTarih";
            this.clVadeTarih.HeaderText = "Vade";
            this.clVadeTarih.Name = "clVadeTarih";
            this.clVadeTarih.ReadOnly = true;
            this.clVadeTarih.Width = 57;
            // 
            // clTutar
            // 
            this.clTutar.DataPropertyName = "Tutar";
            this.clTutar.HeaderText = "Tutar";
            this.clTutar.Name = "clTutar";
            this.clTutar.ReadOnly = true;
            this.clTutar.Width = 57;
            // 
            // clBanka
            // 
            this.clBanka.DataPropertyName = "Banka";
            this.clBanka.HeaderText = "Banka";
            this.clBanka.Name = "clBanka";
            this.clBanka.ReadOnly = true;
            this.clBanka.Width = 63;
            // 
            // clsubeAdi
            // 
            this.clsubeAdi.DataPropertyName = "SubeAdi";
            this.clsubeAdi.HeaderText = "Şube";
            this.clsubeAdi.Name = "clsubeAdi";
            this.clsubeAdi.ReadOnly = true;
            this.clsubeAdi.Width = 57;
            // 
            // clHesapNumarasi
            // 
            this.clHesapNumarasi.DataPropertyName = "HesapNo";
            this.clHesapNumarasi.HeaderText = "HesapNumarası";
            this.clHesapNumarasi.Name = "clHesapNumarasi";
            this.clHesapNumarasi.ReadOnly = true;
            this.clHesapNumarasi.Width = 107;
            // 
            // clAsilSahibi
            // 
            this.clAsilSahibi.DataPropertyName = "AsilSahibi";
            this.clAsilSahibi.HeaderText = "AsılSahibi";
            this.clAsilSahibi.Name = "clAsilSahibi";
            this.clAsilSahibi.ReadOnly = true;
            this.clAsilSahibi.Width = 77;
            // 
            // clKayitTarih
            // 
            this.clKayitTarih.DataPropertyName = "KayitTarih";
            this.clKayitTarih.HeaderText = "KayıtTarih";
            this.clKayitTarih.Name = "clKayitTarih";
            this.clKayitTarih.ReadOnly = true;
            this.clKayitTarih.Width = 79;
            // 
            // clAciklama
            // 
            this.clAciklama.DataPropertyName = "Aciklama";
            this.clAciklama.HeaderText = "Açıklama";
            this.clAciklama.Name = "clAciklama";
            this.clAciklama.ReadOnly = true;
            this.clAciklama.Width = 75;
            // 
            // frmCek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(755, 404);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "frmCek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çek";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCek)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewCek;
        private System.Windows.Forms.Button btnCekDurum;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnYeniCek;
        private System.Windows.Forms.ComboBox cmbCekTip;
        private System.Windows.Forms.TextBox txtAnahtarKelime;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox cmbCekDurum;
        private System.Windows.Forms.Button btnDuzelt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCariKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCekTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDurum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIslemTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn clVadeTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBanka;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsubeAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHesapNumarasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAsilSahibi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKayitTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAciklama;
    }
}