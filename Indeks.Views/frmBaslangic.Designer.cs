namespace Indeks.Views {
    partial class frmBaslangic {
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbSqlLite = new System.Windows.Forms.RadioButton();
            this.rbMsSql = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veri Tabanını Seçiniz";
            // 
            // rbSqlLite
            // 
            this.rbSqlLite.AutoSize = true;
            this.rbSqlLite.Checked = true;
            this.rbSqlLite.Location = new System.Drawing.Point(38, 64);
            this.rbSqlLite.Name = "rbSqlLite";
            this.rbSqlLite.Size = new System.Drawing.Size(57, 17);
            this.rbSqlLite.TabIndex = 1;
            this.rbSqlLite.TabStop = true;
            this.rbSqlLite.Text = "SqlLite";
            this.rbSqlLite.UseVisualStyleBackColor = true;
            // 
            // rbMsSql
            // 
            this.rbMsSql.AutoSize = true;
            this.rbMsSql.Location = new System.Drawing.Point(38, 97);
            this.rbMsSql.Name = "rbMsSql";
            this.rbMsSql.Size = new System.Drawing.Size(54, 17);
            this.rbMsSql.TabIndex = 2;
            this.rbMsSql.Text = "MsSql";
            this.rbMsSql.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Devam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBaslangic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 189);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbMsSql);
            this.Controls.Add(this.rbSqlLite);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBaslangic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbSqlLite;
        private System.Windows.Forms.RadioButton rbMsSql;
        private System.Windows.Forms.Button button1;
    }
}