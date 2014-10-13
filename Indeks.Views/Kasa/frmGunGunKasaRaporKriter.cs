using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Indeks.Data.BusinessObjects;
using Indeks.Data.ManagerObjects;
using Indeks.Data.Helper;
using Indeks.Data.Report;
using Indeks.Views.ReportHelp;
using Doddle.Reporting;
using Doddle.Reporting.Writers;
using System.IO;
using System.Diagnostics;
using Indeks.Views.DataExtension;
namespace Indeks.Views {
    public partial class frmGunGunKasaRaporKriter : BaseKasaRapor {
        //IManagerFactory _mng;
        //IKasaHarManager _mngKasaHar;
        //IKasaManager _mngKasa;
        List<KasaGunlukGelirGider> _data;
        public frmGunGunKasaRaporKriter():base() {
            InitializeComponent();          
           
            SelectCheckBoxes(checkedListBoxHareketTipleri,true);
            chbHepsi.Checked = true;
            LoadKasa(cmboxKasalar);
        }

        string GetTarihAraligi() {

            string st = dtpStart.Value.ToString("d");
            string fd = dtpFinish.Value.ToString("d");
            return string.Format("{0}-{1}", st, fd);

        }
        private void btnPrint_Click(object sender, EventArgs e) {
            frmRaporDialog frm = new frmRaporDialog(true, true, true, false);
            frm.ShowDialog();
            try {
                ReportTo? dest = frm.GetReportDestination();
                if (dest.HasValue) {
                    if (dest.Value != ReportTo.CrytalReport) {

                        // Create the report and turn our query into a ReportSource
                        var report = new Report(_data.ToReportSource());
                        // Customize the Text Fields
                        report.TextFields.Title = "Gün gün Kasa Raporu";
                        report.TextFields.Header = string.Format(@"
    Kasa  :{0}
    Rapor Tarihi: {1}
    Tarih Aralığı:{2}
",
                          cmboxKasalar.Text, DateTime.Now, GetTarihAraligi());


                        // Render hints allow you to pass additional hints to the reports as they are being rendered
                        report.DataFields["Gelir"].ShowTotals = true;
                        report.DataFields["Gider"].ShowTotals = true;
                        report.DataFields["Bakiye"].ShowTotals = true;
                        // Customize the data fields
                        report.RenderHints["HtmlStyle"] = "th { font-size: 14px !important;font-weight:bold !important}";
                        report.DataFields["Gelir"].DataFormatString = "{0:F2}";
                        report.DataFields["Gider"].DataFormatString = "{0:F2}";
                        report.DataFields["Bakiye"].DataFormatString = "{0:F2}";
                        report.DataFields["Tarih"].DataFormatString = "{0:d}";
                        string fileName = "gunGunKasaRaporu.xls";
                        IReportWriter writer = new ExcelReportWriter();
                        if (dest.Value == ReportTo.Html) {
                            writer = new HtmlReportWriter();
                            fileName = "gunGunKasaRaporu.html";
                        } else if (dest.Value == ReportTo.Csv) {
                            writer = new DelimitedTextReportWriter();
                            fileName = "gunGunKasaRaporu.txt";
                        }
                        string file = Path.Combine(Engine.DokumanPath(), fileName);
                        FileStream fs = new FileStream(file, FileMode.Create);

                        writer.WriteReport(report, fs);
                        fs.Close();
                        Process prc = new Process();
                        prc.StartInfo.FileName = file;
                        prc.Start();
                    }
                }
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }

        }
        void LoadGrid() {
            try {
                KasaHareketDurumlari helper =GetKasaHareketDurumlari(checkedListBoxHareketTipleri);
                
                helper.BeginDate = dtpStart.Value;
                helper.EndDate = dtpFinish.Value;
                _data = _mngKasaHar.GetGunlukGelirGider(helper,cmboxKasalar.Text,UserInfo.Sube.Id);
                dataGridView1.DataSource = _data;
                if (_data != null && _data.Count > 0) {
                    tslabToplamGelir.Text = _data.Sum(x => x.Gelir).ToString("F2");
                    tslabToplamGider.Text = _data.Sum(x => x.Gider).ToString("F2") ;
                    tslabToplamBakiye.Text = _data.Sum(x => x.Bakiye).ToString("F2") ;
                }

            } catch (Exception exc) {
                LogWrite.Write(exc);
                MessageBox.Show(exc.Message);
            }

        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            if (tabControl1.SelectedTab.Name == "tabPageRapor")
                LoadGrid();
        }

        private void chbHepsi_CheckedChanged(object sender, EventArgs e) {
            SelectCheckBoxes(checkedListBoxHareketTipleri,chbHepsi.Checked);
        }
       

        private void btnRapor_Click(object sender, EventArgs e) {
            LoadGrid();
            btnPrint.Visible = true;
        }
    }
}
