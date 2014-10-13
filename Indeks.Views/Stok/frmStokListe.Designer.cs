namespace Indeks.Views
{
  partial class frmStokListe
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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokListe));
        this.dataGridView1 = new System.Windows.Forms.DataGridView();
        this.clBarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clStokKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clStokAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clIsk1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clIsk2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clIsk3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clIsk4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clIsk5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        this.SuspendLayout();
        // 
        // dataGridView1
        // 
        this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
        this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
        this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clBarkod,
            this.clStokKodu,
            this.clStokAdi,
            this.clFiyat,
            this.clMiktar,
            this.clIsk1,
            this.clIsk2,
            this.clIsk3,
            this.clIsk4,
            this.clIsk5,
            this.clId,
            this.clTutar});
        dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
        dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
        dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
        this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dataGridView1.GridColor = System.Drawing.SystemColors.Desktop;
        this.dataGridView1.Location = new System.Drawing.Point(0, 0);
        this.dataGridView1.MultiSelect = false;
        this.dataGridView1.Name = "dataGridView1";
        this.dataGridView1.ReadOnly = true;
        this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        this.dataGridView1.RowHeadersVisible = false;
        this.dataGridView1.RowHeadersWidth = 21;
        this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
        this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
        this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
        this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dataGridView1.Size = new System.Drawing.Size(720, 254);
        this.dataGridView1.TabIndex = 1000;
        // 
        // clBarkod
        // 
        this.clBarkod.DataPropertyName = "Barkod";
        this.clBarkod.HeaderText = "Barkod";
        this.clBarkod.Name = "clBarkod";
        this.clBarkod.ReadOnly = true;
        this.clBarkod.Width = 66;
        // 
        // clStokKodu
        // 
        this.clStokKodu.DataPropertyName = "StokKodu";
        this.clStokKodu.HeaderText = "StokKodu";
        this.clStokKodu.Name = "clStokKodu";
        this.clStokKodu.ReadOnly = true;
        this.clStokKodu.Width = 79;
        // 
        // clStokAdi
        // 
        this.clStokAdi.DataPropertyName = "StokAdi";
        this.clStokAdi.HeaderText = "StokAd";
        this.clStokAdi.Name = "clStokAdi";
        this.clStokAdi.ReadOnly = true;
        this.clStokAdi.Width = 67;
        // 
        // clFiyat
        // 
        this.clFiyat.DataPropertyName = "Fiyat";
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        this.clFiyat.DefaultCellStyle = dataGridViewCellStyle2;
        this.clFiyat.HeaderText = "Fiyat";
        this.clFiyat.Name = "clFiyat";
        this.clFiyat.ReadOnly = true;
        this.clFiyat.Width = 54;
        // 
        // clMiktar
        // 
        this.clMiktar.DataPropertyName = "Miktar";
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        this.clMiktar.DefaultCellStyle = dataGridViewCellStyle3;
        this.clMiktar.HeaderText = "Miktar";
        this.clMiktar.Name = "clMiktar";
        this.clMiktar.ReadOnly = true;
        this.clMiktar.Width = 61;
        // 
        // clIsk1
        // 
        this.clIsk1.DataPropertyName = "Isk1";
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        this.clIsk1.DefaultCellStyle = dataGridViewCellStyle4;
        this.clIsk1.HeaderText = "Isk1";
        this.clIsk1.Name = "clIsk1";
        this.clIsk1.ReadOnly = true;
        this.clIsk1.Width = 52;
        // 
        // clIsk2
        // 
        this.clIsk2.DataPropertyName = "Isk2";
        dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        this.clIsk2.DefaultCellStyle = dataGridViewCellStyle5;
        this.clIsk2.HeaderText = "Isk2";
        this.clIsk2.Name = "clIsk2";
        this.clIsk2.ReadOnly = true;
        this.clIsk2.Width = 52;
        // 
        // clIsk3
        // 
        this.clIsk3.DataPropertyName = "Isk3";
        dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        this.clIsk3.DefaultCellStyle = dataGridViewCellStyle6;
        this.clIsk3.HeaderText = "Isk3";
        this.clIsk3.Name = "clIsk3";
        this.clIsk3.ReadOnly = true;
        this.clIsk3.Width = 52;
        // 
        // clIsk4
        // 
        this.clIsk4.DataPropertyName = "Isk4";
        dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        this.clIsk4.DefaultCellStyle = dataGridViewCellStyle7;
        this.clIsk4.HeaderText = "Isk4";
        this.clIsk4.Name = "clIsk4";
        this.clIsk4.ReadOnly = true;
        this.clIsk4.Width = 52;
        // 
        // clIsk5
        // 
        this.clIsk5.DataPropertyName = "Isk5";
        dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        this.clIsk5.DefaultCellStyle = dataGridViewCellStyle8;
        this.clIsk5.HeaderText = "Isk5";
        this.clIsk5.Name = "clIsk5";
        this.clIsk5.ReadOnly = true;
        this.clIsk5.Width = 52;
        // 
        // clId
        // 
        this.clId.DataPropertyName = "Id";
        this.clId.HeaderText = "Id";
        this.clId.Name = "clId";
        this.clId.ReadOnly = true;
        this.clId.Visible = false;
        this.clId.Width = 41;
        // 
        // clTutar
        // 
        this.clTutar.DataPropertyName = "Tutar";
        dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        this.clTutar.DefaultCellStyle = dataGridViewCellStyle9;
        this.clTutar.HeaderText = "Tutar";
        this.clTutar.Name = "clTutar";
        this.clTutar.ReadOnly = true;
        this.clTutar.Width = 57;
        // 
        // frmStokListe
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.ClientSize = new System.Drawing.Size(720, 254);
        this.Controls.Add(this.dataGridView1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.Name = "frmStokListe";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "StokListesi";
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn clBarkod;
    private System.Windows.Forms.DataGridViewTextBoxColumn clStokKodu;
    private System.Windows.Forms.DataGridViewTextBoxColumn clStokAdi;
    private System.Windows.Forms.DataGridViewTextBoxColumn clFiyat;
    private System.Windows.Forms.DataGridViewTextBoxColumn clMiktar;
    private System.Windows.Forms.DataGridViewTextBoxColumn clIsk1;
    private System.Windows.Forms.DataGridViewTextBoxColumn clIsk2;
    private System.Windows.Forms.DataGridViewTextBoxColumn clIsk3;
    private System.Windows.Forms.DataGridViewTextBoxColumn clIsk4;
    private System.Windows.Forms.DataGridViewTextBoxColumn clIsk5;
    private System.Windows.Forms.DataGridViewTextBoxColumn clId;
    private System.Windows.Forms.DataGridViewTextBoxColumn clTutar;
  }
}