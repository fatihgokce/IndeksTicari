namespace Indeks.Views
{
  partial class frmSubeDegistir
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubeDegistir));
      this.btnDegistir = new System.Windows.Forms.Button();
      this.btnIptal = new System.Windows.Forms.Button();
      this.cmbSubeKodu = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtSubeIsmi = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnDegistir
      // 
      this.btnDegistir.BackColor = System.Drawing.SystemColors.MenuBar;
      this.btnDegistir.Location = new System.Drawing.Point(40, 151);
      this.btnDegistir.Name = "btnDegistir";
      this.btnDegistir.Size = new System.Drawing.Size(94, 41);
      this.btnDegistir.TabIndex = 0;
      this.btnDegistir.Text = "Değiştir";
      this.btnDegistir.UseVisualStyleBackColor = false;
      this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
      // 
      // btnIptal
      // 
      this.btnIptal.BackColor = System.Drawing.SystemColors.MenuBar;
      this.btnIptal.Location = new System.Drawing.Point(168, 151);
      this.btnIptal.Name = "btnIptal";
      this.btnIptal.Size = new System.Drawing.Size(94, 41);
      this.btnIptal.TabIndex = 1;
      this.btnIptal.Text = "İptal";
      this.btnIptal.UseVisualStyleBackColor = false;
      this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
      // 
      // cmbSubeKodu
      // 
      this.cmbSubeKodu.FormattingEnabled = true;
      this.cmbSubeKodu.Location = new System.Drawing.Point(40, 63);
      this.cmbSubeKodu.Name = "cmbSubeKodu";
      this.cmbSubeKodu.Size = new System.Drawing.Size(127, 21);
      this.cmbSubeKodu.TabIndex = 2;
      this.cmbSubeKodu.SelectedIndexChanged += new System.EventHandler(this.cmbSubeKodu_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(37, 47);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(60, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Şube Kodu";
      // 
      // txtSubeIsmi
      // 
      this.txtSubeIsmi.Enabled = false;
      this.txtSubeIsmi.Location = new System.Drawing.Point(40, 112);
      this.txtSubeIsmi.Name = "txtSubeIsmi";
      this.txtSubeIsmi.Size = new System.Drawing.Size(222, 20);
      this.txtSubeIsmi.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(37, 96);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(60, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Şube Kodu";
      // 
      // frmSubeDegistir
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.ClientSize = new System.Drawing.Size(345, 236);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtSubeIsmi);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cmbSubeKodu);
      this.Controls.Add(this.btnIptal);
      this.Controls.Add(this.btnDegistir);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "frmSubeDegistir";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "SubeDegistir";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnDegistir;
    private System.Windows.Forms.Button btnIptal;
    private System.Windows.Forms.ComboBox cmbSubeKodu;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtSubeIsmi;
    private System.Windows.Forms.Label label2;
  }
}