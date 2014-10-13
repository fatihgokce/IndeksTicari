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
    public partial class frmSenetRapor : Form {
        IManagerFactory _mng;
        ICariManager _mngCari;
        ISenetManager _mngSenet;
        DataTable _source;
        public frmSenetRapor() {
            InitializeComponent();
            _mng = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
            _mngCari = _mng.GetCariManager();
            _mngSenet = _mng.GetSenetManager();
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
        double toplamTutar() {
            if (_source != null && _source.Rows.Count > 0)
                return double.Parse(_source.Compute("sum(Tutar)", "").ToString());
            else
                return 0;
        }
        void LoadGrid() {
            try {


                _source = _mngSenet.SenetRaporu(UserInfo.Sube.Id,
                    txtCariKodu.Text, dtTarBasTar.Value.JustDate(), dtTarBitTar.Value.JustDate()
                    , dtVadeBasTar.Value.JustDate(), dtVadeBitTar.Value.JustDate());
                 

                _source.Replace("SenetTip", "0", "Verilen");
                _source.Replace("SenetTip", "1", "Alınan");
                _source.Replace("SenetDurum", "1", "Beklemede");
                _source.Replace("SenetDurum", "2", "TahsilEdildi");
                _source.Replace("SenetDurum", "3", "CiroEdildi");
                _source.Replace("SenetDurum", "4", "BankayaTahsileVerildi");
                _source.Replace("SenetDurum", "5", "TahsilBankaHesaba");
                _source.Replace("SenetDurum", "5", "IadeEdildi");
                _source.Replace("SenetDurum", "6", "BankaTeminatVerildi");
                _source.Replace("SenetDurum", "7", "Karşılıksız");
                _source.Replace("SenetDurum", "8", "Ödendi");
                _source.Replace("SenetDurum", "9", "GeriAlindı");
                dataGridView1.DataSource = _source;
                if (_source != null && _source.Rows.Count > 0) {

                    tslabToplamTutar.Text = toplamTutar().ToString("F2");

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
            this.txtCariKodu.Focus();
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
               
            ", DateTime.Now, SecilenCari()
             );
                        //report.DataFields["Tarih"].DataFormatString = "{0:d}";
                        //report.DataFields["BirimFiyat"].DataFormatString = "{0:F2}";
                        //report.DataFields["Tutar"].DataFormatString = "{0:F2}";
                        report.DataFields["Tutar"].ShowTotals = true;
                        string fileName = "SenetRapuru";

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
