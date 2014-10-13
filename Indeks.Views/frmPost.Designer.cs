namespace Indeks.Views {
    partial class frmPost {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPost));
            this.txtSenetNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBankaRehber = new System.Windows.Forms.Button();
            this.txtBankaKodu = new IndeksControl.AutoCompleteTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnKaydet = new System.Windows.Forms.ToolStripButton();
            this.tsbtnKapat = new System.Windows.Forms.ToolStripButton();
            this.mdHesabaGecis = new IndeksControl.maskedDate();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSenetNo
            // 
            this.txtSenetNo.Location = new System.Drawing.Point(114, 101);
            this.txtSenetNo.Name = "txtSenetNo";
            this.txtSenetNo.Size = new System.Drawing.Size(145, 20);
            this.txtSenetNo.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(10, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 90;
            this.label7.Text = "KesintiOran";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "HesabaGeçişTarih";
            // 
            // btnBankaRehber
            // 
            this.btnBankaRehber.Location = new System.Drawing.Point(265, 48);
            this.btnBankaRehber.Name = "btnBankaRehber";
            this.btnBankaRehber.Size = new System.Drawing.Size(34, 19);
            this.btnBankaRehber.TabIndex = 76;
            this.btnBankaRehber.TabStop = false;
            this.btnBankaRehber.Text = "...";
            this.btnBankaRehber.UseVisualStyleBackColor = true;
            // 
            // txtBankaKodu
            // 
            this.txtBankaKodu.Ayirac = "";
            this.txtBankaKodu.AyracBoslukKullan = true;
            this.txtBankaKodu.DataSource = null;
            this.txtBankaKodu.ListForeColor = System.Drawing.Color.White;
            this.txtBankaKodu.ListItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBankaKodu.Location = new System.Drawing.Point(114, 48);
            this.txtBankaKodu.Name = "txtBankaKodu";
            this.txtBankaKodu.NextTabControlName = "";
            this.txtBankaKodu.Size = new System.Drawing.Size(145, 20);
            this.txtBankaKodu.TabIndex = 75;
            this.txtBankaKodu.WidthAutoComplete = 145;
            this.txtBankaKodu.WidthKod = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(12, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 85;
            this.label5.Text = "Banka";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnKaydet,
            this.tsbtnKapat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(415, 39);
            this.toolStrip1.TabIndex = 74;
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
            // tsbtnKapat
            // 
            this.tsbtnKapat.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnKapat.Image")));
            this.tsbtnKapat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnKapat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnKapat.Name = "tsbtnKapat";
            this.tsbtnKapat.Size = new System.Drawing.Size(101, 36);
            this.tsbtnKapat.Text = "Kapat(ESC)";
            // 
            // mdHesabaGecis
            // 
            this.mdHesabaGecis.Location = new System.Drawing.Point(114, 75);
            this.mdHesabaGecis.Name = "mdHesabaGecis";
            this.mdHesabaGecis.Size = new System.Drawing.Size(145, 20);
            this.mdHesabaGecis.TabIndex = 91;
            // 
            // frmPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(415, 176);
            this.Controls.Add(this.mdHesabaGecis);
            this.Controls.Add(this.txtSenetNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBankaRehber);
            this.Controls.Add(this.txtBankaKodu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.Name = "frmPost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Post";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSenetNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBankaRehber;
        public IndeksControl.AutoCompleteTextBox txtBankaKodu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnKaydet;
        private System.Windows.Forms.ToolStripButton tsbtnKapat;
        private IndeksControl.maskedDate mdHesabaGecis;
    }
}