namespace Indeks.Views
{
  partial class frmDizaynKayit
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
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.btnYeni = new System.Windows.Forms.Button();
        this.btnSil = new System.Windows.Forms.Button();
        this.btnKaydet = new System.Windows.Forms.Button();
        this.btnNext = new System.Windows.Forms.Button();
        this.cmboxDizaynTipi = new System.Windows.Forms.ComboBox();
        this.label2 = new System.Windows.Forms.Label();
        this.txtDizaynAdi = new System.Windows.Forms.TextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.dataGridView1 = new System.Windows.Forms.DataGridView();
        this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clDizaynAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clDizaynTipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.groupBox1.SuspendLayout();
        this.groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        this.SuspendLayout();
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.btnYeni);
        this.groupBox1.Controls.Add(this.btnSil);
        this.groupBox1.Controls.Add(this.btnKaydet);
        this.groupBox1.Controls.Add(this.btnNext);
        this.groupBox1.Controls.Add(this.cmboxDizaynTipi);
        this.groupBox1.Controls.Add(this.label2);
        this.groupBox1.Controls.Add(this.txtDizaynAdi);
        this.groupBox1.Controls.Add(this.label1);
        this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
        this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
        this.groupBox1.Location = new System.Drawing.Point(0, 0);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(659, 118);
        this.groupBox1.TabIndex = 0;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Dizayn";
        // 
        // btnYeni
        // 
        this.btnYeni.BackColor = System.Drawing.SystemColors.MenuBar;
        this.btnYeni.Location = new System.Drawing.Point(189, 90);
        this.btnYeni.Name = "btnYeni";
        this.btnYeni.Size = new System.Drawing.Size(75, 22);
        this.btnYeni.TabIndex = 7;
        this.btnYeni.Text = "Yeni(F3)";
        this.btnYeni.UseVisualStyleBackColor = false;
        this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
        // 
        // btnSil
        // 
        this.btnSil.BackColor = System.Drawing.SystemColors.MenuBar;
        this.btnSil.Location = new System.Drawing.Point(108, 90);
        this.btnSil.Name = "btnSil";
        this.btnSil.Size = new System.Drawing.Size(75, 22);
        this.btnSil.TabIndex = 6;
        this.btnSil.Text = "Sil(F7)";
        this.btnSil.UseVisualStyleBackColor = false;
        this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
        // 
        // btnKaydet
        // 
        this.btnKaydet.BackColor = System.Drawing.SystemColors.MenuBar;
        this.btnKaydet.Location = new System.Drawing.Point(27, 90);
        this.btnKaydet.Name = "btnKaydet";
        this.btnKaydet.Size = new System.Drawing.Size(75, 22);
        this.btnKaydet.TabIndex = 5;
        this.btnKaydet.Text = "Kaydet(F5)";
        this.btnKaydet.UseVisualStyleBackColor = false;
        this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
        // 
        // btnNext
        // 
        this.btnNext.BackColor = System.Drawing.SystemColors.MenuBar;
        this.btnNext.Enabled = false;
        this.btnNext.Location = new System.Drawing.Point(256, 16);
        this.btnNext.Name = "btnNext";
        this.btnNext.Size = new System.Drawing.Size(75, 53);
        this.btnNext.TabIndex = 4;
        this.btnNext.Text = ">>";
        this.btnNext.UseVisualStyleBackColor = false;
        this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
        // 
        // cmboxDizaynTipi
        // 
        this.cmboxDizaynTipi.FormattingEnabled = true;
        this.cmboxDizaynTipi.Items.AddRange(new object[] {
            "1-SatışFaturası",
            "2-SatışIrsaliyesi"});
        this.cmboxDizaynTipi.Location = new System.Drawing.Point(100, 48);
        this.cmboxDizaynTipi.Name = "cmboxDizaynTipi";
        this.cmboxDizaynTipi.Size = new System.Drawing.Size(140, 21);
        this.cmboxDizaynTipi.TabIndex = 3;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(24, 48);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(59, 13);
        this.label2.TabIndex = 2;
        this.label2.Text = "Dizayn Tipi";
        // 
        // txtDizaynAdi
        // 
        this.txtDizaynAdi.Location = new System.Drawing.Point(100, 16);
        this.txtDizaynAdi.Name = "txtDizaynAdi";
        this.txtDizaynAdi.Size = new System.Drawing.Size(140, 20);
        this.txtDizaynAdi.TabIndex = 1;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(24, 16);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(57, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "Dizayn Adı";
        // 
        // groupBox2
        // 
        this.groupBox2.Controls.Add(this.dataGridView1);
        this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
        this.groupBox2.Location = new System.Drawing.Point(0, 118);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(659, 225);
        this.groupBox2.TabIndex = 1;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "Dizayn Liste";
        // 
        // dataGridView1
        // 
        this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
        this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clDizaynAdi,
            this.clDizaynTipi});
        this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dataGridView1.Location = new System.Drawing.Point(3, 16);
        this.dataGridView1.MultiSelect = false;
        this.dataGridView1.Name = "dataGridView1";
        this.dataGridView1.ReadOnly = true;
        this.dataGridView1.RowHeadersVisible = false;
        this.dataGridView1.Size = new System.Drawing.Size(653, 206);
        this.dataGridView1.TabIndex = 0;
        this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
        // 
        // clId
        // 
        this.clId.DataPropertyName = "Id";
        this.clId.HeaderText = "Id";
        this.clId.Name = "clId";
        this.clId.ReadOnly = true;
        this.clId.Visible = false;
        // 
        // clDizaynAdi
        // 
        this.clDizaynAdi.DataPropertyName = "DizaynAdi";
        this.clDizaynAdi.HeaderText = "DizaynAdi";
        this.clDizaynAdi.Name = "clDizaynAdi";
        this.clDizaynAdi.ReadOnly = true;
        // 
        // clDizaynTipi
        // 
        this.clDizaynTipi.DataPropertyName = "DizaynTipi";
        this.clDizaynTipi.HeaderText = "DizaynTipi";
        this.clDizaynTipi.Name = "clDizaynTipi";
        this.clDizaynTipi.ReadOnly = true;
        // 
        // frmDizaynKayit
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.ClientSize = new System.Drawing.Size(659, 343);
        this.Controls.Add(this.groupBox2);
        this.Controls.Add(this.groupBox1);
        this.KeyPreview = true;
        this.Name = "frmDizaynKayit";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "DizaynKayit";
        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDizaynKayit_KeyDown);
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.groupBox2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.ComboBox cmboxDizaynTipi;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtDizaynAdi;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnNext;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn clId;
    private System.Windows.Forms.DataGridViewTextBoxColumn clDizaynAdi;
    private System.Windows.Forms.DataGridViewTextBoxColumn clDizaynTipi;
    private System.Windows.Forms.Button btnYeni;
    private System.Windows.Forms.Button btnSil;
    private System.Windows.Forms.Button btnKaydet;
  }
}