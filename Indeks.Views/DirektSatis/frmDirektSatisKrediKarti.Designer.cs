namespace Indeks.Views
{
  partial class frmDirektSatisKrediKarti
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDirektSatisKrediKarti));
      this.labBanka = new System.Windows.Forms.Label();
      this.txtBankaHesapNo = new System.Windows.Forms.TextBox();
      this.btnBankaRehber = new System.Windows.Forms.Button();
      this.btnSec = new System.Windows.Forms.Button();
      this.btnBankaEkle = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // labBanka
      // 
      this.labBanka.AutoSize = true;
      this.labBanka.Location = new System.Drawing.Point(9, 23);
      this.labBanka.Margin = new System.Windows.Forms.Padding(0);
      this.labBanka.Name = "labBanka";
      this.labBanka.Size = new System.Drawing.Size(52, 13);
      this.labBanka.TabIndex = 48;
      this.labBanka.Text = "HesapNo";
      // 
      // txtBankaHesapNo
      // 
      this.txtBankaHesapNo.Location = new System.Drawing.Point(64, 23);
      this.txtBankaHesapNo.Name = "txtBankaHesapNo";
      this.txtBankaHesapNo.Size = new System.Drawing.Size(138, 20);
      this.txtBankaHesapNo.TabIndex = 49;
      // 
      // btnBankaRehber
      // 
      this.btnBankaRehber.Location = new System.Drawing.Point(208, 23);
      this.btnBankaRehber.Name = "btnBankaRehber";
      this.btnBankaRehber.Size = new System.Drawing.Size(34, 20);
      this.btnBankaRehber.TabIndex = 50;
      this.btnBankaRehber.Text = "...";
      this.btnBankaRehber.UseVisualStyleBackColor = true;
      this.btnBankaRehber.Click += new System.EventHandler(this.btnBankaRehber_Click);
      // 
      // btnSec
      // 
      this.btnSec.Location = new System.Drawing.Point(12, 77);
      this.btnSec.Name = "btnSec";
      this.btnSec.Size = new System.Drawing.Size(75, 23);
      this.btnSec.TabIndex = 51;
      this.btnSec.Text = "Seç(F5)";
      this.btnSec.UseVisualStyleBackColor = true;
      this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
      // 
      // btnBankaEkle
      // 
      this.btnBankaEkle.Location = new System.Drawing.Point(248, 23);
      this.btnBankaEkle.Name = "btnBankaEkle";
      this.btnBankaEkle.Size = new System.Drawing.Size(34, 20);
      this.btnBankaEkle.TabIndex = 52;
      this.btnBankaEkle.Text = "+";
      this.btnBankaEkle.UseVisualStyleBackColor = true;
      this.btnBankaEkle.Click += new System.EventHandler(this.btnBankaEkle_Click);
      // 
      // frmDirektSatisKrediKarti
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.ClientSize = new System.Drawing.Size(305, 130);
      this.Controls.Add(this.btnBankaEkle);
      this.Controls.Add(this.btnSec);
      this.Controls.Add(this.labBanka);
      this.Controls.Add(this.txtBankaHesapNo);
      this.Controls.Add(this.btnBankaRehber);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.Name = "frmDirektSatisKrediKarti";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "DirektSatisKrediKarti";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDirektSatisKrediKarti_KeyDown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labBanka;
    public System.Windows.Forms.TextBox txtBankaHesapNo;
    private System.Windows.Forms.Button btnBankaRehber;
    private System.Windows.Forms.Button btnSec;
    private System.Windows.Forms.Button btnBankaEkle;
  }
}