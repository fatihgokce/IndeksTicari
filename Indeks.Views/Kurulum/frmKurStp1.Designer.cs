namespace Indeks.Views
{
  partial class frmKurStp1
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
        this.btnKaydet = new System.Windows.Forms.Button();
        this.txtPassword = new System.Windows.Forms.TextBox();
        this.label4 = new System.Windows.Forms.Label();
        this.txtUserID = new System.Windows.Forms.TextBox();
        this.label3 = new System.Windows.Forms.Label();
        this.txtDatabase = new System.Windows.Forms.TextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.txtServer = new System.Windows.Forms.TextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.btnTest = new System.Windows.Forms.Button();
        this.cmbPaket = new System.Windows.Forms.ComboBox();
        this.label5 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // btnKaydet
        // 
        this.btnKaydet.BackColor = System.Drawing.SystemColors.MenuBar;
        this.btnKaydet.ForeColor = System.Drawing.SystemColors.ControlText;
        this.btnKaydet.Location = new System.Drawing.Point(42, 163);
        this.btnKaydet.Name = "btnKaydet";
        this.btnKaydet.Size = new System.Drawing.Size(75, 23);
        this.btnKaydet.TabIndex = 17;
        this.btnKaydet.Text = "Kaydet";
        this.btnKaydet.UseVisualStyleBackColor = false;
        this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
        // 
        // txtPassword
        // 
        this.txtPassword.Location = new System.Drawing.Point(109, 109);
        this.txtPassword.Name = "txtPassword";
        this.txtPassword.Size = new System.Drawing.Size(147, 20);
        this.txtPassword.TabIndex = 16;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(39, 109);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(28, 13);
        this.label4.TabIndex = 15;
        this.label4.Text = "Şifre";
        // 
        // txtUserID
        // 
        this.txtUserID.Location = new System.Drawing.Point(109, 82);
        this.txtUserID.Name = "txtUserID";
        this.txtUserID.Size = new System.Drawing.Size(147, 20);
        this.txtUserID.TabIndex = 14;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(39, 82);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(64, 13);
        this.label3.TabIndex = 13;
        this.label3.Text = "Kullanıcı Adı";
        // 
        // txtDatabase
        // 
        this.txtDatabase.Location = new System.Drawing.Point(109, 55);
        this.txtDatabase.Name = "txtDatabase";
        this.txtDatabase.Size = new System.Drawing.Size(147, 20);
        this.txtDatabase.TabIndex = 12;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(39, 55);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(53, 13);
        this.label2.TabIndex = 11;
        this.label2.Text = "Database";
        // 
        // txtServer
        // 
        this.txtServer.Location = new System.Drawing.Point(109, 27);
        this.txtServer.Name = "txtServer";
        this.txtServer.Size = new System.Drawing.Size(147, 20);
        this.txtServer.TabIndex = 10;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(39, 27);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(38, 13);
        this.label1.TabIndex = 9;
        this.label1.Text = "Server";
        // 
        // btnTest
        // 
        this.btnTest.BackColor = System.Drawing.SystemColors.MenuBar;
        this.btnTest.ForeColor = System.Drawing.SystemColors.ControlText;
        this.btnTest.Location = new System.Drawing.Point(141, 163);
        this.btnTest.Name = "btnTest";
        this.btnTest.Size = new System.Drawing.Size(75, 23);
        this.btnTest.TabIndex = 18;
        this.btnTest.Text = "Test Et";
        this.btnTest.UseVisualStyleBackColor = false;
        this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
        // 
        // cmbPaket
        // 
        this.cmbPaket.FormattingEnabled = true;
        this.cmbPaket.Location = new System.Drawing.Point(109, 136);
        this.cmbPaket.Name = "cmbPaket";
        this.cmbPaket.Size = new System.Drawing.Size(147, 21);
        this.cmbPaket.TabIndex = 19;
        this.cmbPaket.Visible = false;
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(39, 136);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(35, 13);
        this.label5.TabIndex = 20;
        this.label5.Text = "Paket";
        this.label5.Visible = false;
        // 
        // frmKurStp1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.ClientSize = new System.Drawing.Size(312, 190);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.cmbPaket);
        this.Controls.Add(this.btnTest);
        this.Controls.Add(this.btnKaydet);
        this.Controls.Add(this.txtPassword);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.txtUserID);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.txtDatabase);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.txtServer);
        this.Controls.Add(this.label1);
        this.KeyPreview = true;
        this.Name = "frmKurStp1";
        this.ShowIcon = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Kurulum";
        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmKurStp1_KeyDown);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnKaydet;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtUserID;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtDatabase;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtServer;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnTest;
    private System.Windows.Forms.ComboBox cmbPaket;
    private System.Windows.Forms.Label label5;
  }
}