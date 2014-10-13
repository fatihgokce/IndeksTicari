namespace Indeks.Views
{
  partial class frmLogin
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
        this.btnGiris = new System.Windows.Forms.Button();
        this.btnIptal = new System.Windows.Forms.Button();
        this.label1 = new System.Windows.Forms.Label();
        this.txtKulAdi = new System.Windows.Forms.TextBox();
        this.txtSifre = new System.Windows.Forms.TextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.cmbSube = new System.Windows.Forms.ComboBox();
        this.panel1 = new System.Windows.Forms.Panel();
        this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
        this.panel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // btnGiris
        // 
        this.btnGiris.BackColor = System.Drawing.Color.Maroon;
        this.btnGiris.Location = new System.Drawing.Point(23, 142);
        this.btnGiris.Name = "btnGiris";
        this.btnGiris.Size = new System.Drawing.Size(90, 34);
        this.btnGiris.TabIndex = 3;
        this.btnGiris.Text = "Giriş";
        this.btnGiris.UseVisualStyleBackColor = false;
        this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
        // 
        // btnIptal
        // 
        this.btnIptal.BackColor = System.Drawing.Color.Maroon;
        this.btnIptal.Location = new System.Drawing.Point(137, 142);
        this.btnIptal.Name = "btnIptal";
        this.btnIptal.Size = new System.Drawing.Size(90, 34);
        this.btnIptal.TabIndex = 4;
        this.btnIptal.Text = "İptal";
        this.btnIptal.UseVisualStyleBackColor = false;
        this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(20, 43);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(64, 13);
        this.label1.TabIndex = 2;
        this.label1.Text = "Kullanıcı Adı";
        // 
        // txtKulAdi
        // 
        this.txtKulAdi.Location = new System.Drawing.Point(90, 43);
        this.txtKulAdi.Name = "txtKulAdi";
        this.txtKulAdi.Size = new System.Drawing.Size(138, 20);
        this.txtKulAdi.TabIndex = 1;
        // 
        // txtSifre
        // 
        this.txtSifre.Location = new System.Drawing.Point(89, 69);
        this.txtSifre.Name = "txtSifre";
        this.txtSifre.PasswordChar = '*';
        this.txtSifre.Size = new System.Drawing.Size(138, 20);
        this.txtSifre.TabIndex = 2;
        this.txtSifre.UseSystemPasswordChar = true;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(20, 69);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(28, 13);
        this.label2.TabIndex = 4;
        this.label2.Text = "Şifre";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(20, 16);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(32, 13);
        this.label3.TabIndex = 6;
        this.label3.Text = "Şube";
        // 
        // cmbSube
        // 
        this.cmbSube.FormattingEnabled = true;
        this.cmbSube.Location = new System.Drawing.Point(90, 16);
        this.cmbSube.Name = "cmbSube";
        this.cmbSube.Size = new System.Drawing.Size(138, 21);
        this.cmbSube.TabIndex = 0;
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.btnGiris);
        this.panel1.Controls.Add(this.cmbSube);
        this.panel1.Controls.Add(this.btnIptal);
        this.panel1.Controls.Add(this.label3);
        this.panel1.Controls.Add(this.label1);
        this.panel1.Controls.Add(this.txtSifre);
        this.panel1.Controls.Add(this.txtKulAdi);
        this.panel1.Controls.Add(this.label2);
        this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.panel1.ForeColor = System.Drawing.SystemColors.Control;
        this.panel1.Location = new System.Drawing.Point(0, 0);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(278, 210);
        this.panel1.TabIndex = 8;
        // 
        // backgroundWorker1
        // 
        this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
        // 
        // frmLogin
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        this.ClientSize = new System.Drawing.Size(278, 210);
        this.Controls.Add(this.panel1);
        this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.KeyPreview = true;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "frmLogin";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "IndeksTicari";
        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnGiris;
    private System.Windows.Forms.Button btnIptal;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtKulAdi;
    private System.Windows.Forms.TextBox txtSifre;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox cmbSube;
    private System.Windows.Forms.Panel panel1;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
  }
}