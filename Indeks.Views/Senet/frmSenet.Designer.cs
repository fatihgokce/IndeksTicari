namespace Indeks.Views {
    partial class frmSenet {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDuzelt = new System.Windows.Forms.Button();
            this.cmbSenetDurum = new System.Windows.Forms.ComboBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAnahtarKelime = new System.Windows.Forms.TextBox();
            this.btnSenetDurum = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnYeniCek = new System.Windows.Forms.Button();
            this.cmbSenetTip = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewSenet = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCariKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSenetTip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIslemTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clVadeTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKefil1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKefil2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKayitTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAsilSahibi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSenet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDuzelt);
            this.groupBox2.Controls.Add(this.cmbSenetDurum);
            this.groupBox2.Controls.Add(this.btnAra);
            this.groupBox2.Controls.Add(this.txtAnahtarKelime);
            this.groupBox2.Controls.Add(this.btnSenetDurum);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnYeniCek);
            this.groupBox2.Controls.Add(this.cmbSenetTip);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(642, 135);
            this.groupBox2.TabIndex = 3;
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
            // cmbSenetDurum
            // 
            this.cmbSenetDurum.FormattingEnabled = true;
            this.cmbSenetDurum.Location = new System.Drawing.Point(133, 19);
            this.cmbSenetDurum.Name = "cmbSenetDurum";
            this.cmbSenetDurum.Size = new System.Drawing.Size(121, 21);
            this.cmbSenetDurum.TabIndex = 6;
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
            // btnSenetDurum
            // 
            this.btnSenetDurum.Location = new System.Drawing.Point(389, 73);
            this.btnSenetDurum.Name = "btnSenetDurum";
            this.btnSenetDurum.Size = new System.Drawing.Size(75, 23);
            this.btnSenetDurum.TabIndex = 3;
            this.btnSenetDurum.Text = "Durum";
            this.btnSenetDurum.UseVisualStyleBackColor = true;
            this.btnSenetDurum.Click += new System.EventHandler(this.btnSenetDurum_Click);
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
            // cmbSenetTip
            // 
            this.cmbSenetTip.FormattingEnabled = true;
            this.cmbSenetTip.Location = new System.Drawing.Point(6, 73);
            this.cmbSenetTip.Name = "cmbSenetTip";
            this.cmbSenetTip.Size = new System.Drawing.Size(121, 21);
            this.cmbSenetTip.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewSenet);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 299);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // dataGridViewSenet
            // 
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridViewSenet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSenet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewSenet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSenet.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSenet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSenet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clCariKodu,
            this.clSenetTip,
            this.clDurum,
            this.clIslemTarih,
            this.clVadeTarih,
            this.clTutar,
            this.clKefil1,
            this.clKefil2,
            this.clKayitTarih,
            this.clAsilSahibi,
            this.clAciklama});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSenet.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewSenet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSenet.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewSenet.MultiSelect = false;
            this.dataGridViewSenet.Name = "dataGridViewSenet";
            this.dataGridViewSenet.ReadOnly = true;
            this.dataGridViewSenet.RowHeadersVisible = false;
            this.dataGridViewSenet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSenet.Size = new System.Drawing.Size(636, 280);
            this.dataGridViewSenet.TabIndex = 4;
            this.dataGridViewSenet.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSenet_CellDoubleClick);
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
            // clSenetTip
            // 
            this.clSenetTip.DataPropertyName = "SenetTip";
            this.clSenetTip.HeaderText = "SenetTip";
            this.clSenetTip.Name = "clSenetTip";
            this.clSenetTip.ReadOnly = true;
            this.clSenetTip.Width = 75;
            // 
            // clDurum
            // 
            this.clDurum.DataPropertyName = "SenetDurum";
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
            // clKefil1
            // 
            this.clKefil1.DataPropertyName = "Kefil1";
            this.clKefil1.HeaderText = "Kefil1";
            this.clKefil1.Name = "clKefil1";
            this.clKefil1.ReadOnly = true;
            this.clKefil1.Width = 58;
            // 
            // clKefil2
            // 
            this.clKefil2.DataPropertyName = "Kefil2";
            this.clKefil2.HeaderText = "Kefil2";
            this.clKefil2.Name = "clKefil2";
            this.clKefil2.ReadOnly = true;
            this.clKefil2.Width = 58;
            // 
            // clKayitTarih
            // 
            this.clKayitTarih.DataPropertyName = "KayitTarih";
            this.clKayitTarih.HeaderText = "KayıtTarih";
            this.clKayitTarih.Name = "clKayitTarih";
            this.clKayitTarih.ReadOnly = true;
            this.clKayitTarih.Width = 79;
            // 
            // clAsilSahibi
            // 
            this.clAsilSahibi.DataPropertyName = "AsilSahibi";
            this.clAsilSahibi.HeaderText = "AsılSahibi";
            this.clAsilSahibi.Name = "clAsilSahibi";
            this.clAsilSahibi.ReadOnly = true;
            this.clAsilSahibi.Width = 77;
            // 
            // clAciklama
            // 
            this.clAciklama.DataPropertyName = "Aciklama";
            this.clAciklama.HeaderText = "Açıklama";
            this.clAciklama.Name = "clAciklama";
            this.clAciklama.ReadOnly = true;
            this.clAciklama.Width = 75;
            // 
            // frmSenet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(642, 434);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "frmSenet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Senet";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSenet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDuzelt;
        private System.Windows.Forms.ComboBox cmbSenetDurum;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAnahtarKelime;
        private System.Windows.Forms.Button btnSenetDurum;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnYeniCek;
        private System.Windows.Forms.ComboBox cmbSenetTip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewSenet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCariKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSenetTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDurum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIslemTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn clVadeTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKefil1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKefil2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKayitTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAsilSahibi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAciklama;

    }
}