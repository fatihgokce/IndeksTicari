namespace Indeks.Views
{
  partial class frmBankaHesapRehber
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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankaHesapRehber));
        this.dataGridView1 = new System.Windows.Forms.DataGridView();
        this.clHesapNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clBankaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clHesapSahibi = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clSubeAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clParaBirimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        this.SuspendLayout();
        // 
        // dataGridView1
        // 
        this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
        this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
        this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
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
            this.clHesapNo,
            this.clBankaAdi,
            this.clHesapSahibi,
            this.clSubeAdi,
            this.clParaBirimi,
            this.clId});
        dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
        dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
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
        this.dataGridView1.Size = new System.Drawing.Size(444, 266);
        this.dataGridView1.TabIndex = 1001;
        this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
        // 
        // clHesapNo
        // 
        this.clHesapNo.DataPropertyName = "HesapNo";
        this.clHesapNo.HeaderText = "HesapNo";
        this.clHesapNo.Name = "clHesapNo";
        this.clHesapNo.ReadOnly = true;
        this.clHesapNo.Width = 77;
        // 
        // clBankaAdi
        // 
        this.clBankaAdi.DataPropertyName = "BankaAdi";
        this.clBankaAdi.HeaderText = "BankaAdı";
        this.clBankaAdi.Name = "clBankaAdi";
        this.clBankaAdi.ReadOnly = true;
        this.clBankaAdi.Width = 78;
        // 
        // clHesapSahibi
        // 
        this.clHesapSahibi.DataPropertyName = "HesapSahibi";
        this.clHesapSahibi.HeaderText = "HesapSahibi";
        this.clHesapSahibi.Name = "clHesapSahibi";
        this.clHesapSahibi.ReadOnly = true;
        this.clHesapSahibi.Width = 92;
        // 
        // clSubeAdi
        // 
        this.clSubeAdi.DataPropertyName = "SubeAdi";
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        this.clSubeAdi.DefaultCellStyle = dataGridViewCellStyle2;
        this.clSubeAdi.HeaderText = "ŞubeAdı";
        this.clSubeAdi.Name = "clSubeAdi";
        this.clSubeAdi.ReadOnly = true;
        this.clSubeAdi.Width = 72;
        // 
        // clParaBirimi
        // 
        this.clParaBirimi.DataPropertyName = "ParaBirimi";
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        this.clParaBirimi.DefaultCellStyle = dataGridViewCellStyle3;
        this.clParaBirimi.HeaderText = "ParaBirimi";
        this.clParaBirimi.Name = "clParaBirimi";
        this.clParaBirimi.ReadOnly = true;
        this.clParaBirimi.Width = 78;
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
        // frmBankaHesapRehber
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.ClientSize = new System.Drawing.Size(444, 266);
        this.Controls.Add(this.dataGridView1);
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.Name = "frmBankaHesapRehber";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "BankaHesapRehber";
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn clHesapNo;
    private System.Windows.Forms.DataGridViewTextBoxColumn clBankaAdi;
    private System.Windows.Forms.DataGridViewTextBoxColumn clHesapSahibi;
    private System.Windows.Forms.DataGridViewTextBoxColumn clSubeAdi;
    private System.Windows.Forms.DataGridViewTextBoxColumn clParaBirimi;
    private System.Windows.Forms.DataGridViewTextBoxColumn clId;
  }
}