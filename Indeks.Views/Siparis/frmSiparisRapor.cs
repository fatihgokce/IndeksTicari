using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Indeks.Data.ManagerObjects;
using Indeks.Data.Helper;
using System.Diagnostics;
using System.IO;
using Indeks.Views.ReportHelp;
using Doddle.Reporting.Writers;
using Doddle.Reporting;
using Indeks.Data.BusinessObjects;
namespace Indeks.Views {
    public partial class frmSiparisRapor : Form {
        IManagerFactory _mng;
        ICariManager _mngCari;
        ISiparisUstManager _mngSipUst;
        DataTable _source;
        public frmSiparisRapor() {
            InitializeComponent();
            _mng = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
            _mngCari = _mng.GetCariManager();
            _mngSipUst = _mng.GetSiparisUstManager();
            txtCariKodu.DataSource = () =>
            {
                try {
                    return _mngCari.GetCariKodsBySubeKodu(UserInfo.Sube.Id, txtCariKodu.Text).ToStringList(15, txtCariKodu.Ayirac);
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                    LogWrite.Write(exc);
                }
                return null;

            };
        }
        SiparisDurum SecilenSiparisDurumlari()
        {
            SiparisDurum durum = new SiparisDurum();
            durum.MusteriSiparis = cbMusteriSip.Checked;
            durum.SaticiSiparis = cbSaticiSip.Checked;
            if (!cbSaticiSip.Checked & !cbMusteriSip.Checked) {
                durum.SaticiSiparis = true;
                durum.MusteriSiparis = true;
            }
            return durum;
        }
         double toplamKdvTutar() {
            if (_source != null && _source.Rows.Count > 0)
                return double.Parse(_source.Compute("sum(KdvTutar)", "").ToString());
            else
                return 0;
        }
        double toplamBrutTutar() {
            if (_source != null && _source.Rows.Count > 0)
                return double.Parse(_source.Compute("sum(BrutTutar)", "").ToString());
            else
                return 0;
        }
        double toplamIskanto() {
            if (_source != null && _source.Rows.Count > 0)
                return double.Parse(_source.Compute("sum(Iskanto)", "").ToString());
            else
                return 0;
        }
        double toplamTutar() {
            if (_source != null && _source.Rows.Count > 0)
                return double.Parse(_source.Compute("sum(Tutar)", "").ToString());
            else
                return 0;
        }
        //double toplamIskonto() {
        //    if (_source != null && _source.Rows.Count > 0)
        //        return double.Parse(_source.Compute("sum(Iskanto)", "").ToString());
        //    else
        //        return 0;
        //}
        void LoadGrid() {
            try {
                DateTime? tarBas = null, tarBit = null, tesBas = null, tesBit = null;
                if ((dtTarBasTar.Value != dtTarBitTar.Value && dtTarBasTar.Value < dtTarBitTar.Value)) {
                    tarBas = dtTarBasTar.Value;
                    tarBit = dtTarBitTar.Value;
                }
                if ((dtTesBasTar.Value != dtTesBitTar.Value && dtTesBasTar.Value < dtTesBitTar.Value)) {
                    tesBas = dtTesBasTar.Value;
                    tesBit = dtTesBitTar.Value;
                }

                _source = _mngSipUst.SiparisRapor(UserInfo.Sube.Id,SecilenSiparisDurumlari(),
                    txtCariKodu.Text,tarBas, tarBit, tesBas, tesBit);
                _source.Replace("SiprasTip", "5", "MüşteriSiparişi");
                _source.Replace("SiprasTip", "6", "SatıcıSiparişi");
               
                dataGridView1.DataSource = _source;
                if (_source != null && _source.Rows.Count > 0) {
                    tslabToplamKdvTutar.Text = toplamKdvTutar().ToString("F2");
                    tslabToplamBrutTutar.Text = toplamBrutTutar().ToString("F2");
                    tslabToplamTutar.Text = toplamTutar().ToString("F2");
                    tslabToplamIskonto.Text = toplamIskanto().ToString("F2");

                }


            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }
        private void btnRapor_Click(object sender, EventArgs e) {
            LoadGrid();
            btnPrint.Visible = true;
        }

        private void btnCariRehber_Click(object sender, EventArgs e) {
            frmCariRehber frm = new frmCariRehber();
            frm.Owner = this;
            frm.ShowDialog();
        }
        string SecilenCari() {
            if (string.IsNullOrEmpty(txtCariKodu.Text))
                return "Bütün Cariler";
            else {
                Cari cari = _mngCari.GetById(txtCariKodu.Text, false);
                if (cari != null)
                    return cari.Id + " " + cari.CariIsim;
                else
                    return "";
            }
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
                        report.TextFields.Title = tabPageFiltre.Text;
                        report.TextFields.Header = string.Format(@"
            Rapor Tarihi:{0}
            Cari:{1}                
            ", DateTime.Now, SecilenCari(), toplamKdvTutar().ToString("F2"), toplamBrutTutar().ToString("F2"),
             toplamIskanto().ToString("F2"), toplamTutar().ToString("F2")
             );
                        report.RenderHints["HtmlStyle"] = "th { font-size: 13px !important;font-weight:bold !important;}";
                        report.RenderHints["HtmlStyle"] = "td { font-size: 11px !important;line-height:1em; }";
                        report.DataFields["KdvTutar"].ShowTotals = true;
                        report.DataFields["BrutTutar"].ShowTotals = true;
                        report.DataFields["Iskanto"].ShowTotals = true;
                        report.DataFields["Tutar"].ShowTotals = true;
                        string fileName ="SiparisRaporu";

                        IReportWriter writer = new ExcelReportWriter();
                        if (dest.Value == ReportTo.Excel) {
                            fileName = fileName + ".xls";
                        } else if (dest.Value == ReportTo.Html) {
                            writer = new HtmlReportWriter();
                            fileName = fileName + ".html";
                        } else if (dest.Value == ReportTo.Csv) {
                            writer = new DelimitedTextReportWriter();
                            fileName = fileName + ".txt";
                        }
                        string file = Path.Combine(Engine.DokumanPath(), fileName);
                        FileStream fs = new FileStream(file, FileMode.Create);

                        writer.WriteReport(report, fs);
                        fs.Close();
                        Process prc = new Process();
                        prc.StartInfo.FileName = file;
                        prc.Start();
                    } else {
                        //frmStokAlisSatisRaporCrytalRapor frm2 = new frmStokAlisSatisRaporCrytalRapor(_source);
                        //frm2.Show();

                    }
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                    LogWrite.Write(exc);
                }
            }
        }
    }
}
