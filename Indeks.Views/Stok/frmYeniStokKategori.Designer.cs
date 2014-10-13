namespace Indeks.Views {
    partial class frmYeniCariStokKategori {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYeniCariStokKategori));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.chkAnaKategori = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCatCode = new System.Windows.Forms.TextBox();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.txtSelectedCategory = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 90);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(290, 177);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // chkAnaKategori
            // 
            this.chkAnaKategori.AutoSize = true;
            this.chkAnaKategori.Location = new System.Drawing.Point(12, 54);
            this.chkAnaKategori.Name = "chkAnaKategori";
            this.chkAnaKategori.Size = new System.Drawing.Size(84, 17);
            this.chkAnaKategori.TabIndex = 0;
            this.chkAnaKategori.Text = "AnaKategori";
            this.chkAnaKategori.UseVisualStyleBackColor = true;
            this.chkAnaKategori.CheckedChanged += new System.EventHandler(this.chkAnaKategori_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "AnaKategorisi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori Kodu";
            // 
            // txtCatCode
            // 
            this.txtCatCode.Location = new System.Drawing.Point(9, 332);
            this.txtCatCode.Name = "txtCatCode";
            this.txtCatCode.Size = new System.Drawing.Size(179, 20);
            this.txtCatCode.TabIndex = 2;
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(9, 371);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(290, 20);
            this.txtCatName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kategori Adı";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnKaydet,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(361, 39);
            this.toolStrip1.TabIndex = 7;
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
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(101, 36);
            this.toolStripButton1.Text = "Kapat(ESC)";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // txtSelectedCategory
            // 
            this.txtSelectedCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSelectedCategory.Location = new System.Drawing.Point(9, 293);
            this.txtSelectedCategory.Name = "txtSelectedCategory";
            this.txtSelectedCategory.ReadOnly = true;
            this.txtSelectedCategory.Size = new System.Drawing.Size(290, 20);
            this.txtSelectedCategory.TabIndex = 8;
            this.txtSelectedCategory.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Seçilen Ana Kategori";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmYeniCariStokKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(361, 405);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSelectedCategory);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtCatName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCatCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkAnaKategori);
            this.Controls.Add(this.treeView1);
            this.KeyPreview = true;
            this.Name = "frmYeniCariStokKategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YeniKategori";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmYeniCariStokKategori_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.CheckBox chkAnaKategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCatCode;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnKaydet;
        private System.Windows.Forms.TextBox txtSelectedCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}