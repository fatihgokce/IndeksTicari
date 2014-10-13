using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Doddle.Reporting;
using Doddle.Reporting.Writers;
using System.Diagnostics;
using Indeks.Data.ManagerObjects;
using Indeks.Data.BusinessObjects;
using System.IO;
using Indeks.Views.ReportHelp;
namespace Indeks.Views {
    public partial class frmOzelGelirGiderRapor : Form {
        IManagerFactory mngFac;
        IKasaHarManager mngKasaHar;
        DataTable _source;
        GelirGider _gelirGider;
        public frmOzelGelirGiderRapor(GelirGider gelirGider) {
            InitializeComponent();
            mngFac = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
            mngKasaHar = mngFac.GetKasaHarManager();
            _gelirGider = gelirGider;
            if (_gelirGider == GelirGider.Gelir) {
                this.Text = "Özel Gelir Raporu";
                rbButunGelirGider.Text = "Bütün Gelirler";
                rbOzelGelirGiderLod.Text = "ÖzelGelirKod";
            } else {
                this.Text = "Özel Gider Raporu";
                rbButunGelirGider.Text = "Bütün Giderler";
                rbOzelGelirGiderLod.Text = "ÖzelGiderKod";
            }
        }
        private void btnOzelRehber_Click(object sender, EventArgs e) {
            frmOzelGelirGiderListe frm = new frmOzelGelirGiderListe(_gelirGider);
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void btnRapor_Click(object sender, EventArgs e) {
            LoadGrid();
            btnPrint.Visible = true;           
        }
        void LoadGrid() {
            try {
                _source = mngKasaHar.OzelGelirGiderRapor(UserInfo.Sube.Id,_gelirGider, txtOzelGelirGiderKod.Text, dtpStart.Value, dtpFinish.Value);
                dataGridView1.DataSource = _source;
                if (_source != null && _source.Rows.Count > 0) { 
                tslabToplamKdvTutar.Text=double.Parse( _source.Compute("sum(KdvTutar)", "").ToString()).ToString("F2");
                tslabToplamTutar.Text = double.Parse(_source.Compute("sum(Tutar)", "").ToString()).ToString("F2");
                }
            } catch (Exception exc) {
                LogWrite.Write(exc);
                MessageBox.Show(exc.Message);
            }
        }
        string GetTarihAraligi() {

            string st = dtpStart.Value.ToString("d");
            string fd = dtpFinish.Value.ToString("d");
            return string.Format("{0}-{1}", st, fd);

        }
        private void btnPrint_Click(object sender, EventArgs e) {
            frmRaporDialog frm = new frmRaporDialog(true, true, true, false);
            frm.ShowDialog();
            ReportTo? dest = frm.GetReportDestination();
            if (dest.HasValue) {
                try {
                    if (dest != ReportTo.CrytalReport) {
                        var report = new Report(_source.ToReportSource());
                        // Customize the Text Fields
                        report.RenderHints.IncludePageNumbers = true;
                        report.TextFields.Title =_gelirGider==GelirGider.Gelir?"Özel Gelir Raporu":"Özel Gider Raporu";
                        report.TextFields.Header = string.Format(@"
            Rapor Tarihi:{0}
            Tarih Aralığı:{1}
            
            ", DateTime.Now,GetTarihAraligi());

                        report.DataFields["KdvTutar"].ShowTotals = true;
                        report.DataFields["Tutar"].ShowTotals = true;
                        string rprName = report.TextFields.Title;
                        string fileName = rprName+ ".xls"; 
                        IReportWriter writer = new ExcelReportWriter();

                        if (dest.Value == ReportTo.Html) {
                            writer = new HtmlReportWriter();
                            fileName = rprName+".html";
                        } else if (dest.Value == ReportTo.Csv) {
                            writer = new DelimitedTextReportWriter();
                            fileName = rprName+".txt";
                        }
                        string file = Path.Combine(Engine.DokumanPath(), fileName);
                        FileStream fs = new FileStream(file, FileMode.Create);

                        writer.WriteReport(report, fs);
                        fs.Close();
                        Process prc = new Process();
                        prc.StartInfo.FileName = file;
                        prc.Start();
                    } else {
                        //frmStokHareketDokumuForCrytalReport frm2 = new frmStokHareketDokumuForCrytalReport(_source);
                        //frm2.Show();

                    }
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                    LogWrite.Write(exc);
                }
            }
        }

        private void rbButunGelirGider_CheckedChanged(object sender, EventArgs e) {
            if (sender == rbButunGelirGider) {
                grbOzelGelirGider.Enabled = false;
                txtOzelGelirGiderKod.Text = "";
            } else
                grbOzelGelirGider.Enabled = true;
        }
    }
}
