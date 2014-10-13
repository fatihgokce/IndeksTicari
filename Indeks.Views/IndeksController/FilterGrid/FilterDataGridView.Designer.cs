namespace Indeks.Views.Controller {
    partial class FilterDataGridView {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterDataGridView));
            this.tsFilterSort = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.ddlFilterType = new System.Windows.Forms.ToolStripComboBox();
            this.txtFilter = new System.Windows.Forms.ToolStripTextBox();
            this.btnFilterDt = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statLblRecordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.grd = new System.Windows.Forms.DataGridView();
            this.tsFilterSort.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // tsFilterSort
            // 
            this.tsFilterSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsFilterSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsFilterSort.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel5,
            this.ddlFilterType,
            this.txtFilter,
            this.btnFilterDt});
            this.tsFilterSort.Location = new System.Drawing.Point(0, 0);
            this.tsFilterSort.Name = "tsFilterSort";
            this.tsFilterSort.Size = new System.Drawing.Size(751, 25);
            this.tsFilterSort.TabIndex = 0;
            this.tsFilterSort.Text = "toolStrip1";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(33, 22);
            this.toolStripLabel5.Text = "Filter";
            // 
            // ddlFilterType
            // 
            this.ddlFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlFilterType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ddlFilterType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ddlFilterType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ddlFilterType.Items.AddRange(new object[] {
            "Custom",
            "Like"});
            this.ddlFilterType.Name = "ddlFilterType";
            this.ddlFilterType.Size = new System.Drawing.Size(75, 25);
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(300, 25);
            // 
            // btnFilterDt
            // 
            this.btnFilterDt.BackColor = System.Drawing.SystemColors.Control;
            this.btnFilterDt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFilterDt.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnFilterDt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFilterDt.Image = ((System.Drawing.Image)(resources.GetObject("btnFilterDt.Image")));
            this.btnFilterDt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilterDt.Name = "btnFilterDt";
            this.btnFilterDt.Size = new System.Drawing.Size(23, 22);
            this.btnFilterDt.Text = "Execute Filter";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statLblRecordCount});
            this.toolStrip1.Location = new System.Drawing.Point(0, 206);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(751, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statLblRecordCount
            // 
            this.statLblRecordCount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.statLblRecordCount.ForeColor = System.Drawing.Color.White;
            this.statLblRecordCount.Name = "statLblRecordCount";
            this.statLblRecordCount.Size = new System.Drawing.Size(54, 20);
            this.statLblRecordCount.Text = "0 row(s)";
            // 
            // grd
            // 
            this.grd.AllowUserToAddRows = false;
            this.grd.AllowUserToDeleteRows = false;
            this.grd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grd.BackgroundColor = System.Drawing.Color.White;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(0, 25);
            this.grd.MultiSelect = false;
            this.grd.Name = "grd";
            this.grd.ReadOnly = true;
            this.grd.RowHeadersVisible = false;
            this.grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd.Size = new System.Drawing.Size(751, 181);
            this.grd.TabIndex = 3;
            // 
            // FilterDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.grd);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tsFilterSort);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FilterDataGridView";
            this.Size = new System.Drawing.Size(751, 231);
            this.tsFilterSort.ResumeLayout(false);
            this.tsFilterSort.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsFilterSort;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox ddlFilterType;
        private System.Windows.Forms.ToolStripTextBox txtFilter;
        private System.Windows.Forms.ToolStripButton btnFilterDt;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripStatusLabel statLblRecordCount;
        public System.Windows.Forms.DataGridView grd;
    }
}
