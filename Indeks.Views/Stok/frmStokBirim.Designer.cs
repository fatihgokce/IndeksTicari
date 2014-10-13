namespace Indeks.Views
{
  partial class frmStokBirim
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokBirim));
        this.toolStrip1 = new System.Windows.Forms.ToolStrip();
        this.tsbtnKaydet = new System.Windows.Forms.ToolStripButton();
        this.tsbtnYeniKayit = new System.Windows.Forms.ToolStripButton();
        this.txtAnaBirim = new System.Windows.Forms.TextBox();
        this.label17 = new System.Windows.Forms.Label();
        this.tsbtnKapat = new System.Windows.Forms.ToolStripButton();
        this.toolStrip1.SuspendLayout();
        this.SuspendLayout();
        // 
        // toolStrip1
        // 
        this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnKaydet,
            this.tsbtnYeniKayit,
            this.tsbtnKapat});
        this.toolStrip1.Location = new System.Drawing.Point(0, 0);
        this.toolStrip1.Name = "toolStrip1";
        this.toolStrip1.Size = new System.Drawing.Size(340, 39);
        this.toolStrip1.TabIndex = 2;
        this.toolStrip1.Text = "toolStrip1";
        // 
        // tsbtnKaydet
        // 
        this.tsbtnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnKaydet.Image")));
        this.tsbtnKaydet.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.tsbtnKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.tsbtnKaydet.Name = "tsbtnKaydet";
        this.tsbtnKaydet.Size = new System.Drawing.Size(99, 36);
        this.tsbtnKaydet.Text = "Kaydet(F5)";
        this.tsbtnKaydet.Click += new System.EventHandler(this.tsbtnKaydet_Click);
        // 
        // tsbtnYeniKayit
        // 
        this.tsbtnYeniKayit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnYeniKayit.Image")));
        this.tsbtnYeniKayit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.tsbtnYeniKayit.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.tsbtnYeniKayit.Name = "tsbtnYeniKayit";
        this.tsbtnYeniKayit.Size = new System.Drawing.Size(104, 36);
        this.tsbtnYeniKayit.Text = "YeniKayıt(F3)";
        this.tsbtnYeniKayit.Click += new System.EventHandler(this.tsbtnYeniKayit_Click);
        // 
        // txtAnaBirim
        // 
        this.txtAnaBirim.Location = new System.Drawing.Point(80, 81);
        this.txtAnaBirim.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
        this.txtAnaBirim.Name = "txtAnaBirim";
        this.txtAnaBirim.Size = new System.Drawing.Size(110, 20);
        this.txtAnaBirim.TabIndex = 25;
        this.txtAnaBirim.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // label17
        // 
        this.label17.AutoSize = true;
        this.label17.Location = new System.Drawing.Point(12, 81);
        this.label17.Name = "label17";
        this.label17.Size = new System.Drawing.Size(29, 13);
        this.label17.TabIndex = 26;
        this.label17.Text = "Birim";
        // 
        // tsbtnKapat
        // 
        this.tsbtnKapat.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnKapat.Image")));
        this.tsbtnKapat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.tsbtnKapat.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.tsbtnKapat.Name = "tsbtnKapat";
        this.tsbtnKapat.Size = new System.Drawing.Size(101, 36);
        this.tsbtnKapat.Text = "Kapat(ESC)";
        this.tsbtnKapat.Click += new System.EventHandler(this.tsbtnKapat_Click);
        // 
        // frmStokBirim
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.ClientSize = new System.Drawing.Size(340, 154);
        this.Controls.Add(this.txtAnaBirim);
        this.Controls.Add(this.label17);
        this.Controls.Add(this.toolStrip1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.KeyPreview = true;
        this.Name = "frmStokBirim";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "StokBirim";
        this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStokBirim_KeyDown);
        this.toolStrip1.ResumeLayout(false);
        this.toolStrip1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton tsbtnKaydet;
    private System.Windows.Forms.ToolStripButton tsbtnYeniKayit;
    public System.Windows.Forms.TextBox txtAnaBirim;
    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.ToolStripButton tsbtnKapat;
  }
}