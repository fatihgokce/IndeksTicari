namespace Indeks.Views
{
  partial class frmKullanici
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullanici));
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.chbSubelerdeOrtak = new System.Windows.Forms.CheckBox();
        this.txtUserName = new System.Windows.Forms.TextBox();
        this.label3 = new System.Windows.Forms.Label();
        this.btnYeni = new System.Windows.Forms.Button();
        this.btnSil = new System.Windows.Forms.Button();
        this.btnKaydet = new System.Windows.Forms.Button();
        this.chkAdmin = new System.Windows.Forms.CheckBox();
        this.txtPassword = new System.Windows.Forms.TextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.dataGridView1 = new System.Windows.Forms.DataGridView();
        this.gvClUserNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.gvClUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.gvClSifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.gvClAdmin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
        this.clSubelerdeOrtak = new System.Windows.Forms.DataGridViewCheckBoxColumn();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        this.groupBox2.SuspendLayout();
        this.SuspendLayout();
        // 
        // groupBox1
        // 
        this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.groupBox1.Controls.Add(this.chbSubelerdeOrtak);
        this.groupBox1.Controls.Add(this.txtUserName);
        this.groupBox1.Controls.Add(this.label3);
        this.groupBox1.Controls.Add(this.btnYeni);
        this.groupBox1.Controls.Add(this.btnSil);
        this.groupBox1.Controls.Add(this.btnKaydet);
        this.groupBox1.Controls.Add(this.chkAdmin);
        this.groupBox1.Controls.Add(this.txtPassword);
        this.groupBox1.Controls.Add(this.label1);
        this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
        this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
        this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
        this.groupBox1.Location = new System.Drawing.Point(0, 0);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(585, 167);
        this.groupBox1.TabIndex = 1;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Kullanıcılar";
        // 
        // chbSubelerdeOrtak
        // 
        this.chbSubelerdeOrtak.AutoSize = true;
        this.chbSubelerdeOrtak.Location = new System.Drawing.Point(91, 106);
        this.chbSubelerdeOrtak.Name = "chbSubelerdeOrtak";
        this.chbSubelerdeOrtak.Size = new System.Drawing.Size(100, 17);
        this.chbSubelerdeOrtak.TabIndex = 3;
        this.chbSubelerdeOrtak.Text = "ŞubelerdeOrtak";
        this.chbSubelerdeOrtak.UseVisualStyleBackColor = true;
        // 
        // txtUserName
        // 
        this.txtUserName.Location = new System.Drawing.Point(91, 32);
        this.txtUserName.Name = "txtUserName";
        this.txtUserName.Size = new System.Drawing.Size(181, 20);
        this.txtUserName.TabIndex = 0;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
        this.label3.Location = new System.Drawing.Point(22, 32);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(67, 13);
        this.label3.TabIndex = 11;
        this.label3.Text = "Kullanıcı Ismi";
        // 
        // btnYeni
        // 
        this.btnYeni.BackColor = System.Drawing.SystemColors.MenuBar;
        this.btnYeni.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnYeni.ForeColor = System.Drawing.SystemColors.ControlText;
        this.btnYeni.Location = new System.Drawing.Point(187, 129);
        this.btnYeni.Name = "btnYeni";
        this.btnYeni.Size = new System.Drawing.Size(75, 28);
        this.btnYeni.TabIndex = 6;
        this.btnYeni.Text = "Yeni(F3)";
        this.btnYeni.UseVisualStyleBackColor = false;
        this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
        // 
        // btnSil
        // 
        this.btnSil.BackColor = System.Drawing.SystemColors.MenuBar;
        this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnSil.ForeColor = System.Drawing.SystemColors.ControlText;
        this.btnSil.Location = new System.Drawing.Point(106, 129);
        this.btnSil.Name = "btnSil";
        this.btnSil.Size = new System.Drawing.Size(75, 28);
        this.btnSil.TabIndex = 5;
        this.btnSil.Text = "Sil(F7)";
        this.btnSil.UseVisualStyleBackColor = false;
        this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
        // 
        // btnKaydet
        // 
        this.btnKaydet.BackColor = System.Drawing.SystemColors.MenuBar;
        this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnKaydet.ForeColor = System.Drawing.SystemColors.ControlText;
        this.btnKaydet.Location = new System.Drawing.Point(25, 129);
        this.btnKaydet.Name = "btnKaydet";
        this.btnKaydet.Size = new System.Drawing.Size(75, 28);
        this.btnKaydet.TabIndex = 4;
        this.btnKaydet.Text = "Kaydet(F5)";
        this.btnKaydet.UseVisualStyleBackColor = false;
        this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
        // 
        // chkAdmin
        // 
        this.chkAdmin.AutoSize = true;
        this.chkAdmin.Location = new System.Drawing.Point(91, 83);
        this.chkAdmin.Name = "chkAdmin";
        this.chkAdmin.Size = new System.Drawing.Size(55, 17);
        this.chkAdmin.TabIndex = 2;
        this.chkAdmin.Text = "Admin";
        this.chkAdmin.UseVisualStyleBackColor = true;
        // 
        // txtPassword
        // 
        this.txtPassword.Location = new System.Drawing.Point(91, 57);
        this.txtPassword.Name = "txtPassword";
        this.txtPassword.Size = new System.Drawing.Size(181, 20);
        this.txtPassword.TabIndex = 1;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
        this.label1.Location = new System.Drawing.Point(22, 57);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(28, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "Şifre";
        // 
        // dataGridView1
        // 
        this.dataGridView1.AllowUserToAddRows = false;
        this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
        this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
        this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
        this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvClUserNo,
            this.gvClUserName,
            this.gvClSifre,
            this.gvClAdmin,
            this.clSubelerdeOrtak});
        this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
        dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
        this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dataGridView1.Location = new System.Drawing.Point(3, 16);
        this.dataGridView1.MultiSelect = false;
        this.dataGridView1.Name = "dataGridView1";
        this.dataGridView1.ReadOnly = true;
        this.dataGridView1.RowHeadersVisible = false;
        this.dataGridView1.RowHeadersWidth = 20;
        dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
        this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
        this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dataGridView1.Size = new System.Drawing.Size(579, 257);
        this.dataGridView1.TabIndex = 2;
        this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
        // 
        // gvClUserNo
        // 
        this.gvClUserNo.DataPropertyName = "Id";
        this.gvClUserNo.HeaderText = "KullaniciID";
        this.gvClUserNo.Name = "gvClUserNo";
        this.gvClUserNo.ReadOnly = true;
        this.gvClUserNo.Width = 82;
        // 
        // gvClUserName
        // 
        this.gvClUserName.DataPropertyName = "UserName";
        this.gvClUserName.HeaderText = "Kullanıcı İsmi";
        this.gvClUserName.Name = "gvClUserName";
        this.gvClUserName.ReadOnly = true;
        this.gvClUserName.Width = 92;
        // 
        // gvClSifre
        // 
        this.gvClSifre.DataPropertyName = "Password";
        this.gvClSifre.HeaderText = "Şifre";
        this.gvClSifre.Name = "gvClSifre";
        this.gvClSifre.ReadOnly = true;
        this.gvClSifre.Width = 53;
        // 
        // gvClAdmin
        // 
        this.gvClAdmin.DataPropertyName = "Adminmi";
        this.gvClAdmin.HeaderText = "Admin";
        this.gvClAdmin.Name = "gvClAdmin";
        this.gvClAdmin.ReadOnly = true;
        this.gvClAdmin.Width = 42;
        // 
        // clSubelerdeOrtak
        // 
        this.clSubelerdeOrtak.DataPropertyName = "SubelerdeOrtak";
        this.clSubelerdeOrtak.HeaderText = "ŞubelerdeOrtak";
        this.clSubelerdeOrtak.Name = "clSubelerdeOrtak";
        this.clSubelerdeOrtak.ReadOnly = true;
        this.clSubelerdeOrtak.Width = 87;
        // 
        // groupBox2
        // 
        this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.groupBox2.Controls.Add(this.dataGridView1);
        this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.groupBox2.Location = new System.Drawing.Point(0, 167);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(585, 276);
        this.groupBox2.TabIndex = 3;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "Kullanıcı Listesi";
        // 
        // frmKullanici
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.ClientSize = new System.Drawing.Size(585, 443);
        this.Controls.Add(this.groupBox2);
        this.Controls.Add(this.groupBox1);
        this.ForeColor = System.Drawing.SystemColors.ControlText;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.KeyPreview = true;
        this.Name = "frmKullanici";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Kullanici";
        this.Load += new System.EventHandler(this.frmKullanici_Load);
        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmKullanici_KeyDown);
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        this.groupBox2.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txtUserName;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnYeni;
    private System.Windows.Forms.Button btnSil;
    private System.Windows.Forms.Button btnKaydet;
    private System.Windows.Forms.CheckBox chkAdmin;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.CheckBox chbSubelerdeOrtak;
    private System.Windows.Forms.DataGridViewTextBoxColumn gvClUserNo;
    private System.Windows.Forms.DataGridViewTextBoxColumn gvClUserName;
    private System.Windows.Forms.DataGridViewTextBoxColumn gvClSifre;
    private System.Windows.Forms.DataGridViewCheckBoxColumn gvClAdmin;
    private System.Windows.Forms.DataGridViewCheckBoxColumn clSubelerdeOrtak;

  }
}