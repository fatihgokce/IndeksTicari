namespace Indeks.Views
{
  partial class frmKurStp2
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
        this.grboxClientServer = new System.Windows.Forms.GroupBox();
        this.btnDevam = new System.Windows.Forms.Button();
        this.rbtnServer = new System.Windows.Forms.RadioButton();
        this.rbtnClient = new System.Windows.Forms.RadioButton();
        this.grboxSqlKurulumu = new System.Windows.Forms.GroupBox();
        this.btnKapat = new System.Windows.Forms.Button();
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.btnKur = new System.Windows.Forms.Button();
        this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
        this.grboxClientServer.SuspendLayout();
        this.grboxSqlKurulumu.SuspendLayout();
        this.SuspendLayout();
        // 
        // grboxClientServer
        // 
        this.grboxClientServer.Controls.Add(this.btnDevam);
        this.grboxClientServer.Controls.Add(this.rbtnServer);
        this.grboxClientServer.Controls.Add(this.rbtnClient);
        this.grboxClientServer.Location = new System.Drawing.Point(12, 30);
        this.grboxClientServer.Name = "grboxClientServer";
        this.grboxClientServer.Size = new System.Drawing.Size(347, 149);
        this.grboxClientServer.TabIndex = 1;
        this.grboxClientServer.TabStop = false;
        this.grboxClientServer.Text = "Client/Server";
        // 
        // btnDevam
        // 
        this.btnDevam.BackColor = System.Drawing.SystemColors.MenuBar;
        this.btnDevam.ForeColor = System.Drawing.SystemColors.ControlText;
        this.btnDevam.Location = new System.Drawing.Point(16, 105);
        this.btnDevam.Name = "btnDevam";
        this.btnDevam.Size = new System.Drawing.Size(75, 23);
        this.btnDevam.TabIndex = 2;
        this.btnDevam.Text = "Devam";
        this.btnDevam.UseVisualStyleBackColor = false;
        this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
        // 
        // rbtnServer
        // 
        this.rbtnServer.AutoSize = true;
        this.rbtnServer.Location = new System.Drawing.Point(16, 56);
        this.rbtnServer.Name = "rbtnServer";
        this.rbtnServer.Size = new System.Drawing.Size(56, 17);
        this.rbtnServer.TabIndex = 1;
        this.rbtnServer.TabStop = true;
        this.rbtnServer.Text = "Server";
        this.rbtnServer.UseVisualStyleBackColor = true;
        // 
        // rbtnClient
        // 
        this.rbtnClient.AutoSize = true;
        this.rbtnClient.Location = new System.Drawing.Point(16, 33);
        this.rbtnClient.Name = "rbtnClient";
        this.rbtnClient.Size = new System.Drawing.Size(51, 17);
        this.rbtnClient.TabIndex = 0;
        this.rbtnClient.TabStop = true;
        this.rbtnClient.Text = "Client";
        this.rbtnClient.UseVisualStyleBackColor = true;
        // 
        // grboxSqlKurulumu
        // 
        this.grboxSqlKurulumu.Controls.Add(this.btnKapat);
        this.grboxSqlKurulumu.Controls.Add(this.textBox1);
        this.grboxSqlKurulumu.Controls.Add(this.btnKur);
        this.grboxSqlKurulumu.Location = new System.Drawing.Point(12, 196);
        this.grboxSqlKurulumu.Name = "grboxSqlKurulumu";
        this.grboxSqlKurulumu.Size = new System.Drawing.Size(347, 158);
        this.grboxSqlKurulumu.TabIndex = 2;
        this.grboxSqlKurulumu.TabStop = false;
        this.grboxSqlKurulumu.Text = "Sql Kurulumu";
        this.grboxSqlKurulumu.Visible = false;
        // 
        // btnKapat
        // 
        this.btnKapat.BackColor = System.Drawing.SystemColors.MenuBar;
        this.btnKapat.Enabled = false;
        this.btnKapat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        this.btnKapat.Location = new System.Drawing.Point(100, 119);
        this.btnKapat.Name = "btnKapat";
        this.btnKapat.Size = new System.Drawing.Size(75, 23);
        this.btnKapat.TabIndex = 4;
        this.btnKapat.Text = "Kapat";
        this.btnKapat.UseVisualStyleBackColor = false;
        this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
        // 
        // textBox1
        // 
        this.textBox1.Location = new System.Drawing.Point(16, 19);
        this.textBox1.Multiline = true;
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new System.Drawing.Size(312, 79);
        this.textBox1.TabIndex = 3;
        // 
        // btnKur
        // 
        this.btnKur.BackColor = System.Drawing.SystemColors.MenuBar;
        this.btnKur.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        this.btnKur.Location = new System.Drawing.Point(19, 119);
        this.btnKur.Name = "btnKur";
        this.btnKur.Size = new System.Drawing.Size(75, 23);
        this.btnKur.TabIndex = 2;
        this.btnKur.Text = "Kur";
        this.btnKur.UseVisualStyleBackColor = false;
        this.btnKur.Click += new System.EventHandler(this.btnKur_Click);
        // 
        // frmKurStp2
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.ClientSize = new System.Drawing.Size(378, 188);
        this.Controls.Add(this.grboxSqlKurulumu);
        this.Controls.Add(this.grboxClientServer);
        this.Name = "frmKurStp2";
        this.ShowIcon = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Kurulum";
        this.grboxClientServer.ResumeLayout(false);
        this.grboxClientServer.PerformLayout();
        this.grboxSqlKurulumu.ResumeLayout(false);
        this.grboxSqlKurulumu.PerformLayout();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox grboxClientServer;
    private System.Windows.Forms.Button btnDevam;
    private System.Windows.Forms.RadioButton rbtnServer;
    private System.Windows.Forms.RadioButton rbtnClient;
    private System.Windows.Forms.GroupBox grboxSqlKurulumu;
    private System.Windows.Forms.Button btnKapat;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button btnKur;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
  }
}