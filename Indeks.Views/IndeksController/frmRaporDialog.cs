using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Indeks.Views.ReportHelp;
namespace Indeks.Views {
    public partial class frmRaporDialog : Form {
        ReportTo? _to=null;
     
        public frmRaporDialog(bool enableExcel,bool enableHtml,bool enableCsv,bool enableCrytalReport) {
            InitializeComponent();           
            btnExcel.Enabled = enableExcel;
            btnHtml.Enabled = enableHtml; btnCsv.Enabled = enableCsv; btnCrytal.Enabled = enableCrytalReport;
        }
        public ReportTo? GetReportDestination() {
            return _to;
        }

        private void btnExcel_Click(object sender, EventArgs e) {
            if (sender == btnExcel)
                _to = ReportTo.Excel;
            else if (sender == btnHtml)
                _to = ReportTo.Html;
            else if (sender == btnCsv)
                _to = ReportTo.Csv;
            else if (sender == btnCrytal)
                _to = ReportTo.CrytalReport;
            this.Close();
            
        }

       
    }
}
