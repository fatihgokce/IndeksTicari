namespace Indeks.Views {
    partial class frmYeniVeriTabani {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSqlLiteSave = new System.Windows.Forms.Button();
            this.txtSqlLiteDb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSqlLiteDb);
            this.panel1.Controls.Add(this.btnSqlLiteSave);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 238);
            this.panel1.TabIndex = 0;
            // 
            // btnSqlLiteSave
            // 
            this.btnSqlLiteSave.Location = new System.Drawing.Point(25, 87);
            this.btnSqlLiteSave.Name = "btnSqlLiteSave";
            this.btnSqlLiteSave.Size = new System.Drawing.Size(75, 23);
            this.btnSqlLiteSave.TabIndex = 0;
            this.btnSqlLiteSave.Text = "Kaydet";
            this.btnSqlLiteSave.UseVisualStyleBackColor = true;
            this.btnSqlLiteSave.Click += new System.EventHandler(this.btnSqlLiteSave_Click);
            // 
            // txtSqlLiteDb
            // 
            this.txtSqlLiteDb.Location = new System.Drawing.Point(118, 40);
            this.txtSqlLiteDb.Name = "txtSqlLiteDb";
            this.txtSqlLiteDb.Size = new System.Drawing.Size(177, 20);
            this.txtSqlLiteDb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Veri Tabanı ismi";
            // 
            // frmYeniVeriTabani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 404);
            this.Controls.Add(this.panel1);
            this.Name = "frmYeniVeriTabani";
            this.Text = "YeniVeriTabani";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSqlLiteDb;
        private System.Windows.Forms.Button btnSqlLiteSave;
    }
}