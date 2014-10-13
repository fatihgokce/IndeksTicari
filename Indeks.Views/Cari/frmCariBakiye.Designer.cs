namespace Indeks.Views {
    partial class frmCariBakiye {
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
            this.labBorc = new System.Windows.Forms.Label();
            this.labAlacak = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlacakMiktar = new System.Windows.Forms.TextBox();
            this.txtBorcMiktar = new System.Windows.Forms.TextBox();
            this.txtBakiyeMiktar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labBorc
            // 
            this.labBorc.AutoSize = true;
            this.labBorc.Location = new System.Drawing.Point(19, 64);
            this.labBorc.Name = "labBorc";
            this.labBorc.Size = new System.Drawing.Size(35, 13);
            this.labBorc.TabIndex = 0;
            this.labBorc.Text = "label1";
            // 
            // labAlacak
            // 
            this.labAlacak.AutoSize = true;
            this.labAlacak.Location = new System.Drawing.Point(19, 19);
            this.labAlacak.Name = "labAlacak";
            this.labAlacak.Size = new System.Drawing.Size(35, 13);
            this.labAlacak.TabIndex = 1;
            this.labAlacak.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bakiye:";
            // 
            // txtAlacakMiktar
            // 
            this.txtAlacakMiktar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtAlacakMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlacakMiktar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtAlacakMiktar.Location = new System.Drawing.Point(131, 19);
            this.txtAlacakMiktar.Name = "txtAlacakMiktar";
            this.txtAlacakMiktar.ReadOnly = true;
            this.txtAlacakMiktar.Size = new System.Drawing.Size(133, 26);
            this.txtAlacakMiktar.TabIndex = 6;
            // 
            // txtBorcMiktar
            // 
            this.txtBorcMiktar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtBorcMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBorcMiktar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtBorcMiktar.Location = new System.Drawing.Point(131, 64);
            this.txtBorcMiktar.Name = "txtBorcMiktar";
            this.txtBorcMiktar.ReadOnly = true;
            this.txtBorcMiktar.Size = new System.Drawing.Size(133, 26);
            this.txtBorcMiktar.TabIndex = 7;
            // 
            // txtBakiyeMiktar
            // 
            this.txtBakiyeMiktar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtBakiyeMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBakiyeMiktar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtBakiyeMiktar.Location = new System.Drawing.Point(131, 101);
            this.txtBakiyeMiktar.Name = "txtBakiyeMiktar";
            this.txtBakiyeMiktar.ReadOnly = true;
            this.txtBakiyeMiktar.Size = new System.Drawing.Size(133, 26);
            this.txtBakiyeMiktar.TabIndex = 8;
            // 
            // frmCariBakiye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(293, 148);
            this.Controls.Add(this.txtBakiyeMiktar);
            this.Controls.Add(this.txtBorcMiktar);
            this.Controls.Add(this.txtAlacakMiktar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labAlacak);
            this.Controls.Add(this.labBorc);
            this.KeyPreview = true;
            this.Name = "frmCariBakiye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CariBakiye";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labBorc;
        private System.Windows.Forms.Label labAlacak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlacakMiktar;
        private System.Windows.Forms.TextBox txtBorcMiktar;
        private System.Windows.Forms.TextBox txtBakiyeMiktar;
    }
}