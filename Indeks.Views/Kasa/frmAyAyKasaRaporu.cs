using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Indeks.Data.BusinessObjects;
using Indeks.Data.Helper;
using Doddle.Reporting;
using Indeks.Views.ReportHelp;
using Doddle.Reporting.Writers;
using System.IO;
using System.Diagnostics;

namespace Indeks.Views {
    public partial class frmAyAyKasaRaporu : BaseKasaRapor {
        DataTable _source;
        public frmAyAyKasaRaporu():base() {
            InitializeComponent();
            SelectCheckBoxes(checkedListBoxHareketTipleri, true);
            chbHepsi.Checked = true;
            LoadKasa(cmboxKasalar);
            maskedTextBoxYil.Text = DateTime.Now.Year.ToString();
        }

        private void chbHepsi_CheckedChanged(object sender, EventArgs e) {
            SelectCheckBoxes(checkedListBoxHareketTipleri, chbHepsi.Checked);
        }

        private void btnRapor_Click(object sender, EventArgs e) {
            LoadGrid();
            btnPrint.Visible = true;
        }
        double ToplamGelir() {
            if (_source == null)
                return 0;
            return double.Parse(_source.Compute("sum(Gelir)", "").ToString());
        }
        double ToplamGider() {
            if (_source == null)
                return 0;
            return double.Parse(_source.Compute("sum(Gider)", "").ToString());
        }
        double ToplamBakiye() {
            if (_source == null)
                return 0;
            return double.Parse(_source.Compute("sum(Bakiye)", "").ToString());
        }
        void LoadGrid() {
            try {
                KasaHareketDurumlari helper = GetKasaHareketDurumlari(checkedListBoxHareketTipleri);

                int yil =int.Parse( maskedTextBoxYil.Text);
                _source = _mngKasaHar.AyAyGelirGiderRaporu(helper, cmboxKasalar.Text, UserInfo.Sube.Id,yil);
                _source.Replace("Ay", "1", "Ocak"); _source.Replace("Ay", "2", "Şubat");
                _source.Replace("Ay", "3", "Mart"); _source.Replace("Ay", "4", "Nisan");
                _source.Replace("Ay", "5", "Mayıs"); _source.Replace("Ay", "6", "Haziran");
                _source.Replace("Ay", "7", "Temmuz"); _source.Replace("Ay", "8", "Ağustos");
                _source.Replace("Ay", "9", "Eylül");
                _source.Replace("Ay", "01", "Ocak"); _source.Replace("Ay", "02", "Şubat");
                _source.Replace("Ay", "03", "Mart"); _source.Replace("Ay", "04", "Nisan");
                _source.Replace("Ay", "05", "Mayıs"); _source.Replace("Ay", "06", "Haziran");
                _source.Replace("Ay", "07", "Temmuz"); _source.Replace("Ay", "08", "Ağustos");
                _source.Replace("Ay", "09", "Eylül");
                _source.Replace("Ay", "10", "Ekim");
                _source.Replace("Ay", "11", "Kasım"); _source.Replace("Ay", "12", "Aralık");
                dataGridView1.DataSource = _source;
                if (_source != null && _source.Rows.Count > 0) {
                    tslabToplamGelir.Text =ToplamGelir().ToString("F2");
                    tslabToplamGider.Text =ToplamGider().ToString("F2");
                    tslabToplamBakiye.Text =ToplamBakiye().ToString("F2");
                    dataGridView1.Columns["Bakiye"].DefaultCellStyle.Format = "F2";
                }

            } catch (Exception exc) {
                LogWrite.Write(exc);
                MessageBox.Show(exc.Message);
            }

        }

        private void btnPrint_Click(object sender, EventArgs e) {
            frmRaporDialog frm = new frmRaporDialog(true, true, true, false);
            frm.ShowDialog();
            try {
                ReportTo? dest = frm.GetReportDestination();
                if (dest.HasValue) {
                    if (dest.Value != ReportTo.CrytalReport) {

                        // Create the report and turn our query into a ReportSource
                        var report = new Report(_source.ToReportSource());
                        // Customize the Text Fields
                        report.TextFields.Title = "Ay Ay Kasa Raporu";
                        report.TextFields.Header = string.Format(@"
    Kasa  :{0}
    Rapor Tarihi: {1}
    Yıl: {2}
  ", cmboxKasalar.Text, DateTime.Now, maskedTextBoxYil.Text);

                        report.DataFields["Gelir"].ShowTotals = true;
                        report.DataFields["Gider"].ShowTotals = true;
                        report.DataFields["Bakiye"].ShowTotals = true;
                        // Render hints allow you to pass additional hints to the reports as they are being rendered
                        //report.RenderHints.BooleanCheckboxes = true;
                        // Customize the data fields
                        //report.RenderHints["HtmlStyle"] = "td { font-size: 14px !important; }";
                        //report.DataFields["Gelir"].DataFormatString = "{0:c}";
                        //report.DataFields["Gider"].DataFormatString = "{0:c}";
                        //report.DataFields["Bakiye"].DataFormatString = "{0:c}";

                        string fileName = "ayAyKasaRaporu.xls";
                        IReportWriter writer = new ExcelReportWriter();
                        if (dest.Value == ReportTo.Html) {
                            writer = new HtmlReportWriter();
                            fileName = "ayAyGunKasaRaporu.html";
                        } else if (dest.Value == ReportTo.Csv) {
                            writer = new DelimitedTextReportWriter();
                            fileName = "ayAyKasaRaporu.txt";
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
      
    }
}
