namespace Indeks.Views {
    partial class frmRaporDialog {
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCrytal = new System.Windows.Forms.Button();
            this.btnCsv = new System.Windows.Forms.Button();
            this.btnHtml = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnCrytal, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCsv, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnHtml, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnExcel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(187, 152);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCrytal
            // 
            this.btnCrytal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCrytal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCrytal.Location = new System.Drawing.Point(4, 115);
            this.btnCrytal.Name = "btnCrytal";
            this.btnCrytal.Size = new System.Drawing.Size(179, 33);
            this.btnCrytal.TabIndex = 3;
            this.btnCrytal.Text = "CrytalRapor";
            this.btnCrytal.UseVisualStyleBackColor = true;
            this.btnCrytal.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnCsv
            // 
            this.btnCsv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCsv.Location = new System.Drawing.Point(4, 78);
            this.btnCsv.Name = "btnCsv";
            this.btnCsv.Size = new System.Drawing.Size(179, 30);
            this.btnCsv.TabIndex = 2;
            this.btnCsv.Text = "Csv";
            this.btnCsv.UseVisualStyleBackColor = true;
            this.btnCsv.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnHtml
            // 
            this.btnHtml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHtml.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHtml.Location = new System.Drawing.Point(4, 41);
            this.btnHtml.Name = "btnHtml";
            this.btnHtml.Size = new System.Drawing.Size(179, 30);
            this.btnHtml.TabIndex = 1;
            this.btnHtml.Text = "Html";
            this.btnHtml.UseVisualStyleBackColor = true;
            this.btnHtml.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExcel.Location = new System.Drawing.Point(4, 4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(179, 30);
            this.btnExcel.TabIndex = 0;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // frmRaporDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 152);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "frmRaporDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaporDialog";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnCrytal;
        private System.Windows.Forms.Button btnCsv;
        private System.Windows.Forms.Button btnHtml;

    }
}