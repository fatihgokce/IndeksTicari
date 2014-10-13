namespace Indeks.Views
{
  partial class frmStokBirimListe
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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokBirimListe));
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.dataGridViewCari = new System.Windows.Forms.DataGridView();
        this.clBirim = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.btnYeni = new System.Windows.Forms.Button();
        this.btnDuzelt = new System.Windows.Forms.Button();
        this.groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCari)).BeginInit();
        this.SuspendLayout();
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.dataGridViewCari);
        this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
        this.groupBox1.Location = new System.Drawing.Point(0, 0);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(404, 270);
        this.groupBox1.TabIndex = 0;
        this.groupBox1.TabStop = false;
        // 
        // dataGridViewCari
        // 
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
        this.dataGridViewCari.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        this.dataGridViewCari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dataGridViewCari.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
        this.dataGridViewCari.BackgroundColor = System.Drawing.SystemColors.Window;
        this.dataGridViewCari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridViewCari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clBirim,
            this.clId});
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        this.dataGridViewCari.DefaultCellStyle = dataGridViewCellStyle2;
        this.dataGridViewCari.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dataGridViewCari.Location = new System.Drawing.Point(3, 16);
        this.dataGridViewCari.MultiSelect = false;
        this.dataGridViewCari.Name = "dataGridViewCari";
        this.dataGridViewCari.ReadOnly = true;
        this.dataGridViewCari.RowHeadersVisible = false;
        this.dataGridViewCari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dataGridViewCari.Size = new System.Drawing.Size(398, 251);
        this.dataGridViewCari.TabIndex = 4;
        this.dataGridViewCari.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCari_CellDoubleClick);
        // 
        // clBirim
        // 
        this.clBirim.DataPropertyName = "Birim";
        this.clBirim.HeaderText = "Birim";
        this.clBirim.Name = "clBirim";
        this.clBirim.ReadOnly = true;
        // 
        // clId
        // 
        this.clId.DataPropertyName = "Id";
        this.clId.HeaderText = "Id";
        this.clId.Name = "clId";
        this.clId.ReadOnly = true;
        this.clId.Visible = false;
        // 
        // btnYeni
        // 
        this.btnYeni.Location = new System.Drawing.Point(202, 283);
        this.btnYeni.Name = "btnYeni";
        this.btnYeni.Size = new System.Drawing.Size(75, 23);
        this.btnYeni.TabIndex = 1;
        this.btnYeni.Text = "Yeni";
        this.btnYeni.UseVisualStyleBackColor = true;
        this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
        // 
        // btnDuzelt
        // 
        this.btnDuzelt.Location = new System.Drawing.Point(283, 283);
        this.btnDuzelt.Name = "btnDuzelt";
        this.btnDuzelt.Size = new System.Drawing.Size(75, 23);
        this.btnDuzelt.TabIndex = 2;
        this.btnDuzelt.Text = "Düzelt";
        this.btnDuzelt.UseVisualStyleBackColor = true;
        this.btnDuzelt.Click += new System.EventHandler(this.btnDuzelt_Click);
        // 
        // frmStokBirimListe
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.ClientSize = new System.Drawing.Size(404, 318);
        this.Controls.Add(this.btnDuzelt);
        this.Controls.Add(this.btnYeni);
        this.Controls.Add(this.groupBox1);
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.Name = "frmStokBirimListe";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "StokBirimListe";
        this.groupBox1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCari)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DataGridView dataGridViewCari;
    private System.Windows.Forms.DataGridViewTextBoxColumn clBirim;
    private System.Windows.Forms.DataGridViewTextBoxColumn clId;
    private System.Windows.Forms.Button btnYeni;
    private System.Windows.Forms.Button btnDuzelt;
  }
}