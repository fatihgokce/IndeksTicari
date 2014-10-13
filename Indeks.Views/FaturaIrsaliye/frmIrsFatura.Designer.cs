namespace Indeks.Views
{
  partial class frmIrsFatura
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
      this.label1 = new System.Windows.Forms.Label();
      this.txtFatNo = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.dateTarih = new System.Windows.Forms.DateTimePicker();
      this.cmboxKasalar = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.btnKaydet = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(78, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Yeni Fatura No";
      // 
      // txtFatNo
      // 
      this.txtFatNo.Location = new System.Drawing.Point(96, 12);
      this.txtFatNo.Name = "txtFatNo";
      this.txtFatNo.Size = new System.Drawing.Size(135, 20);
      this.txtFatNo.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 42);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(66, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Fatura Tarihi";
      // 
      // dateTarih
      // 
      this.dateTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dateTarih.Location = new System.Drawing.Point(96, 42);
      this.dateTarih.Name = "dateTarih";
      this.dateTarih.Size = new System.Drawing.Size(135, 20);
      this.dateTarih.TabIndex = 3;
      // 
      // cmboxKasalar
      // 
      this.cmboxKasalar.Enabled = false;
      this.cmboxKasalar.FormattingEnabled = true;
      this.cmboxKasalar.Location = new System.Drawing.Point(96, 72);
      this.cmboxKasalar.Name = "cmboxKasalar";
      this.cmboxKasalar.Size = new System.Drawing.Size(135, 21);
      this.cmboxKasalar.TabIndex = 4;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 72);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(59, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Kasa Kodu";
      // 
      // btnKaydet
      // 
      this.btnKaydet.BackColor = System.Drawing.SystemColors.MenuBar;
      this.btnKaydet.ForeColor = System.Drawing.SystemColors.ControlText;
      this.btnKaydet.Location = new System.Drawing.Point(15, 117);
      this.btnKaydet.Name = "btnKaydet";
      this.btnKaydet.Size = new System.Drawing.Size(138, 23);
      this.btnKaydet.TabIndex = 6;
      this.btnKaydet.Text = "İrs. Faturalaştır";
      this.btnKaydet.UseVisualStyleBackColor = false;
      this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
      // 
      // frmIrsFatura
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.ClientSize = new System.Drawing.Size(272, 156);
      this.Controls.Add(this.btnKaydet);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.cmboxKasalar);
      this.Controls.Add(this.dateTarih);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtFatNo);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.Name = "frmIrsFatura";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmIrsFatura_KeyDown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtFatNo;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DateTimePicker dateTarih;
    private System.Windows.Forms.ComboBox cmboxKasalar;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnKaydet;
  }
}