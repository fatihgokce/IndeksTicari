namespace Indeks.Views
{
  partial class frmDirekSatisVeresiye
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDirekSatisVeresiye));
        this.label5 = new System.Windows.Forms.Label();
        this.btnCariRehber = new System.Windows.Forms.Button();
        this.btnHizliCari = new System.Windows.Forms.Button();
        this.btnSec = new System.Windows.Forms.Button();
        this.dateTarih = new System.Windows.Forms.DateTimePicker();
        this.labTarih = new System.Windows.Forms.Label();
        this.txtCariKodu = new IndeksControl.AutoCompleteTextBox();
        this.SuspendLayout();
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
        this.label5.Location = new System.Drawing.Point(21, 26);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(53, 13);
        this.label5.TabIndex = 20;
        this.label5.Text = "Cari Kodu";
        // 
        // btnCariRehber
        // 
        this.btnCariRehber.Location = new System.Drawing.Point(260, 26);
        this.btnCariRehber.Name = "btnCariRehber";
        this.btnCariRehber.Size = new System.Drawing.Size(34, 23);
        this.btnCariRehber.TabIndex = 21;
        this.btnCariRehber.Text = "...";
        this.btnCariRehber.UseVisualStyleBackColor = true;
        this.btnCariRehber.Click += new System.EventHandler(this.btnCariRehber_Click);
        // 
        // btnHizliCari
        // 
        this.btnHizliCari.Location = new System.Drawing.Point(300, 26);
        this.btnHizliCari.Name = "btnHizliCari";
        this.btnHizliCari.Size = new System.Drawing.Size(34, 23);
        this.btnHizliCari.TabIndex = 22;
        this.btnHizliCari.Text = "+";
        this.btnHizliCari.UseVisualStyleBackColor = true;
        this.btnHizliCari.Visible = false;
        this.btnHizliCari.Click += new System.EventHandler(this.btnHizliCari_Click);
        // 
        // btnSec
        // 
        this.btnSec.Location = new System.Drawing.Point(24, 114);
        this.btnSec.Name = "btnSec";
        this.btnSec.Size = new System.Drawing.Size(75, 23);
        this.btnSec.TabIndex = 23;
        this.btnSec.Text = "Seç(F5)";
        this.btnSec.UseVisualStyleBackColor = true;
        this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
        // 
        // dateTarih
        // 
        this.dateTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dateTarih.Location = new System.Drawing.Point(80, 60);
        this.dateTarih.Name = "dateTarih";
        this.dateTarih.Size = new System.Drawing.Size(137, 20);
        this.dateTarih.TabIndex = 24;
        // 
        // labTarih
        // 
        this.labTarih.AutoSize = true;
        this.labTarih.Location = new System.Drawing.Point(21, 60);
        this.labTarih.Name = "labTarih";
        this.labTarih.Size = new System.Drawing.Size(59, 13);
        this.labTarih.TabIndex = 25;
        this.labTarih.Text = "Vade Tarih";
        // 
        // txtCariKodu
        // 
        this.txtCariKodu.Ayirac = "";
        this.txtCariKodu.AyracBoslukKullan = true;
        this.txtCariKodu.DataSource = null;
        this.txtCariKodu.ListForeColor = System.Drawing.Color.White;
        this.txtCariKodu.ListItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        this.txtCariKodu.Location = new System.Drawing.Point(80, 26);
        this.txtCariKodu.Name = "txtCariKodu";
        this.txtCariKodu.NextTabControlName = "";
        this.txtCariKodu.Size = new System.Drawing.Size(174, 20);
        this.txtCariKodu.TabIndex = 19;
        this.txtCariKodu.WidthAutoComplete = 200;
        this.txtCariKodu.WidthKod = 15;
        // 
        // frmDirekSatisVeresiye
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.ClientSize = new System.Drawing.Size(385, 162);
        this.Controls.Add(this.dateTarih);
        this.Controls.Add(this.labTarih);
        this.Controls.Add(this.btnSec);
        this.Controls.Add(this.btnHizliCari);
        this.Controls.Add(this.btnCariRehber);
        this.Controls.Add(this.txtCariKodu);
        this.Controls.Add(this.label5);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.KeyPreview = true;
        this.Name = "frmDirekSatisVeresiye";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "DirekSatisVeresiye";
        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDirekSatisVeresiye_KeyDown);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    public IndeksControl.AutoCompleteTextBox txtCariKodu;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btnCariRehber;
    private System.Windows.Forms.Button btnHizliCari;
    private System.Windows.Forms.Button btnSec;
    private System.Windows.Forms.Label labTarih;
    public System.Windows.Forms.DateTimePicker dateTarih;
  }
}