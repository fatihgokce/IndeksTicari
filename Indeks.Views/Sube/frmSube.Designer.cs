namespace Indeks.Views
{
  partial class frmSube
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSube));
        this.label1 = new System.Windows.Forms.Label();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.txtVergiNo = new System.Windows.Forms.TextBox();
        this.label5 = new System.Windows.Forms.Label();
        this.txtVergiDairesi = new System.Windows.Forms.TextBox();
        this.label4 = new System.Windows.Forms.Label();
        this.txtSubeKodu = new System.Windows.Forms.TextBox();
        this.label3 = new System.Windows.Forms.Label();
        this.btnYeni = new System.Windows.Forms.Button();
        this.btnSil = new System.Windows.Forms.Button();
        this.btnKaydet = new System.Windows.Forms.Button();
        this.chkAktif = new System.Windows.Forms.CheckBox();
        this.chkMerkez = new System.Windows.Forms.CheckBox();
        this.txtAdres = new System.Windows.Forms.TextBox();
        this.txtSubeIsmi = new System.Windows.Forms.TextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.dataGridView1 = new System.Windows.Forms.DataGridView();
        this.gvClSubeKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.gvClSubeIsmi = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.gvClAdres = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.gvClVergiDairesi = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.gvClVergiNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.gvClMerkez = new System.Windows.Forms.DataGridViewCheckBoxColumn();
        this.gvClAktif = new System.Windows.Forms.DataGridViewCheckBoxColumn();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        this.groupBox2.SuspendLayout();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
        this.label1.Location = new System.Drawing.Point(22, 57);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(53, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "Şube İsmi";
        // 
        // groupBox1
        // 
        this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.groupBox1.Controls.Add(this.txtVergiNo);
        this.groupBox1.Controls.Add(this.label5);
        this.groupBox1.Controls.Add(this.txtVergiDairesi);
        this.groupBox1.Controls.Add(this.label4);
        this.groupBox1.Controls.Add(this.txtSubeKodu);
        this.groupBox1.Controls.Add(this.label3);
        this.groupBox1.Controls.Add(this.btnYeni);
        this.groupBox1.Controls.Add(this.btnSil);
        this.groupBox1.Controls.Add(this.btnKaydet);
        this.groupBox1.Controls.Add(this.chkAktif);
        this.groupBox1.Controls.Add(this.chkMerkez);
        this.groupBox1.Controls.Add(this.txtAdres);
        this.groupBox1.Controls.Add(this.txtSubeIsmi);
        this.groupBox1.Controls.Add(this.label2);
        this.groupBox1.Controls.Add(this.label1);
        this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
        this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
        this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
        this.groupBox1.Location = new System.Drawing.Point(0, 0);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(618, 252);
        this.groupBox1.TabIndex = 1;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Şubeler";
        // 
        // txtVergiNo
        // 
        this.txtVergiNo.Location = new System.Drawing.Point(91, 150);
        this.txtVergiNo.MaxLength = 30;
        this.txtVergiNo.Name = "txtVergiNo";
        this.txtVergiNo.Size = new System.Drawing.Size(181, 20);
        this.txtVergiNo.TabIndex = 4;
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
        this.label5.Location = new System.Drawing.Point(22, 150);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(48, 13);
        this.label5.TabIndex = 16;
        this.label5.Text = "Vergi No";
        // 
        // txtVergiDairesi
        // 
        this.txtVergiDairesi.Location = new System.Drawing.Point(91, 125);
        this.txtVergiDairesi.MaxLength = 50;
        this.txtVergiDairesi.Name = "txtVergiDairesi";
        this.txtVergiDairesi.Size = new System.Drawing.Size(181, 20);
        this.txtVergiDairesi.TabIndex = 3;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
        this.label4.Location = new System.Drawing.Point(22, 125);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(66, 13);
        this.label4.TabIndex = 14;
        this.label4.Text = "Vergi Dairesi";
        // 
        // txtSubeKodu
        // 
        this.txtSubeKodu.Location = new System.Drawing.Point(91, 32);
        this.txtSubeKodu.Name = "txtSubeKodu";
        this.txtSubeKodu.Size = new System.Drawing.Size(181, 20);
        this.txtSubeKodu.TabIndex = 0;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
        this.label3.Location = new System.Drawing.Point(22, 32);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(60, 13);
        this.label3.TabIndex = 11;
        this.label3.Text = "Şube Kodu";
        // 
        // btnYeni
        // 
        this.btnYeni.BackColor = System.Drawing.SystemColors.MenuBar;
        this.btnYeni.ForeColor = System.Drawing.SystemColors.ControlText;
        this.btnYeni.Location = new System.Drawing.Point(172, 211);
        this.btnYeni.Name = "btnYeni";
        this.btnYeni.Size = new System.Drawing.Size(75, 28);
        this.btnYeni.TabIndex = 9;
        this.btnYeni.Text = "Yeni(F3)";
        this.btnYeni.UseVisualStyleBackColor = false;
        this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
        // 
        // btnSil
        // 
        this.btnSil.BackColor = System.Drawing.SystemColors.MenuBar;
        this.btnSil.ForeColor = System.Drawing.SystemColors.ControlText;
        this.btnSil.Location = new System.Drawing.Point(91, 211);
        this.btnSil.Name = "btnSil";
        this.btnSil.Size = new System.Drawing.Size(75, 28);
        this.btnSil.TabIndex = 8;
        this.btnSil.Text = "Sil(F7)";
        this.btnSil.UseVisualStyleBackColor = false;
        this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
        // 
        // btnKaydet
        // 
        this.btnKaydet.BackColor = System.Drawing.SystemColors.MenuBar;
        this.btnKaydet.ForeColor = System.Drawing.SystemColors.ControlText;
        this.btnKaydet.Location = new System.Drawing.Point(9, 211);
        this.btnKaydet.Name = "btnKaydet";
        this.btnKaydet.Size = new System.Drawing.Size(75, 28);
        this.btnKaydet.TabIndex = 7;
        this.btnKaydet.Text = "Kaydet(F5)";
        this.btnKaydet.UseVisualStyleBackColor = false;
        this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
        // 
        // chkAktif
        // 
        this.chkAktif.AutoSize = true;
        this.chkAktif.Location = new System.Drawing.Point(90, 192);
        this.chkAktif.Name = "chkAktif";
        this.chkAktif.Size = new System.Drawing.Size(47, 17);
        this.chkAktif.TabIndex = 6;
        this.chkAktif.Text = "Aktif";
        this.chkAktif.UseVisualStyleBackColor = true;
        // 
        // chkMerkez
        // 
        this.chkMerkez.AutoSize = true;
        this.chkMerkez.Location = new System.Drawing.Point(90, 176);
        this.chkMerkez.Name = "chkMerkez";
        this.chkMerkez.Size = new System.Drawing.Size(61, 17);
        this.chkMerkez.TabIndex = 5;
        this.chkMerkez.Text = "Merkez";
        this.chkMerkez.UseVisualStyleBackColor = true;
        // 
        // txtAdres
        // 
        this.txtAdres.Location = new System.Drawing.Point(91, 83);
        this.txtAdres.Multiline = true;
        this.txtAdres.Name = "txtAdres";
        this.txtAdres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtAdres.Size = new System.Drawing.Size(281, 38);
        this.txtAdres.TabIndex = 2;
        // 
        // txtSubeIsmi
        // 
        this.txtSubeIsmi.Location = new System.Drawing.Point(91, 57);
        this.txtSubeIsmi.Name = "txtSubeIsmi";
        this.txtSubeIsmi.Size = new System.Drawing.Size(181, 20);
        this.txtSubeIsmi.TabIndex = 1;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
        this.label2.Location = new System.Drawing.Point(22, 83);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(34, 13);
        this.label2.TabIndex = 1;
        this.label2.Text = "Adres";
        // 
        // dataGridView1
        // 
        this.dataGridView1.AllowUserToAddRows = false;
        this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
        this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
        this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
        this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvClSubeKodu,
            this.gvClSubeIsmi,
            this.gvClAdres,
            this.gvClVergiDairesi,
            this.gvClVergiNo,
            this.gvClMerkez,
            this.gvClAktif});
        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
        dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
        this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
        this.dataGridView1.Location = new System.Drawing.Point(3, 16);
        this.dataGridView1.MultiSelect = false;
        this.dataGridView1.Name = "dataGridView1";
        this.dataGridView1.ReadOnly = true;
        this.dataGridView1.RowHeadersVisible = false;
        this.dataGridView1.RowHeadersWidth = 20;
        dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
        this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
        this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dataGridView1.Size = new System.Drawing.Size(612, 312);
        this.dataGridView1.TabIndex = 2;
        this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
        // 
        // gvClSubeKodu
        // 
        this.gvClSubeKodu.DataPropertyName = "Id";
        this.gvClSubeKodu.HeaderText = "SubeKodu";
        this.gvClSubeKodu.Name = "gvClSubeKodu";
        this.gvClSubeKodu.ReadOnly = true;
        this.gvClSubeKodu.Width = 82;
        // 
        // gvClSubeIsmi
        // 
        this.gvClSubeIsmi.DataPropertyName = "SubeIsmi";
        this.gvClSubeIsmi.HeaderText = "SubeIsmi";
        this.gvClSubeIsmi.Name = "gvClSubeIsmi";
        this.gvClSubeIsmi.ReadOnly = true;
        this.gvClSubeIsmi.Width = 75;
        // 
        // gvClAdres
        // 
        this.gvClAdres.DataPropertyName = "Adres";
        this.gvClAdres.HeaderText = "Adres";
        this.gvClAdres.MinimumWidth = 100;
        this.gvClAdres.Name = "gvClAdres";
        this.gvClAdres.ReadOnly = true;
        // 
        // gvClVergiDairesi
        // 
        this.gvClVergiDairesi.DataPropertyName = "VergiDairesi";
        this.gvClVergiDairesi.HeaderText = "VergiDairesi";
        this.gvClVergiDairesi.MaxInputLength = 50;
        this.gvClVergiDairesi.MinimumWidth = 50;
        this.gvClVergiDairesi.Name = "gvClVergiDairesi";
        this.gvClVergiDairesi.ReadOnly = true;
        this.gvClVergiDairesi.Width = 88;
        // 
        // gvClVergiNo
        // 
        this.gvClVergiNo.DataPropertyName = "VergiNo";
        this.gvClVergiNo.HeaderText = "VergiNo";
        this.gvClVergiNo.MinimumWidth = 30;
        this.gvClVergiNo.Name = "gvClVergiNo";
        this.gvClVergiNo.ReadOnly = true;
        this.gvClVergiNo.Width = 70;
        // 
        // gvClMerkez
        // 
        this.gvClMerkez.DataPropertyName = "Merkezmi";
        this.gvClMerkez.HeaderText = "Merkez";
        this.gvClMerkez.Name = "gvClMerkez";
        this.gvClMerkez.ReadOnly = true;
        this.gvClMerkez.Width = 48;
        // 
        // gvClAktif
        // 
        this.gvClAktif.DataPropertyName = "Aktif";
        this.gvClAktif.HeaderText = "Aktif";
        this.gvClAktif.Name = "gvClAktif";
        this.gvClAktif.ReadOnly = true;
        this.gvClAktif.Width = 34;
        // 
        // groupBox2
        // 
        this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.groupBox2.Controls.Add(this.dataGridView1);
        this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
        this.groupBox2.Location = new System.Drawing.Point(0, 252);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(618, 331);
        this.groupBox2.TabIndex = 3;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "Şube Listesi";
        // 
        // frmSube
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.ClientSize = new System.Drawing.Size(618, 583);
        this.Controls.Add(this.groupBox2);
        this.Controls.Add(this.groupBox1);
        this.ForeColor = System.Drawing.SystemColors.ControlText;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.KeyPreview = true;
        this.Name = "frmSube";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Şube";
        this.Load += new System.EventHandler(this.frmSube_Load);
        this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSube_FormClosed);
        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSube_KeyDown);
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        this.groupBox2.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txtAdres;
    private System.Windows.Forms.TextBox txtSubeIsmi;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnKaydet;
    private System.Windows.Forms.CheckBox chkAktif;
    private System.Windows.Forms.CheckBox chkMerkez;
    private System.Windows.Forms.Button btnYeni;
    private System.Windows.Forms.Button btnSil;
    private System.Windows.Forms.TextBox txtSubeKodu;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.TextBox txtVergiNo;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtVergiDairesi;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.DataGridViewTextBoxColumn gvClSubeKodu;
    private System.Windows.Forms.DataGridViewTextBoxColumn gvClSubeIsmi;
    private System.Windows.Forms.DataGridViewTextBoxColumn gvClAdres;
    private System.Windows.Forms.DataGridViewTextBoxColumn gvClVergiDairesi;
    private System.Windows.Forms.DataGridViewTextBoxColumn gvClVergiNo;
    private System.Windows.Forms.DataGridViewCheckBoxColumn gvClMerkez;
    private System.Windows.Forms.DataGridViewCheckBoxColumn gvClAktif;
    private System.Windows.Forms.GroupBox groupBox2;
  }
}