using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Indeks.Data.Base;
using Indeks.Data.BusinessObjects;
using Indeks.Data.ManagerObjects;
using Indeks.Views.ReportHelp;
using Doddle.Reporting;
using Doddle.Reporting.Writers;
using System.IO;
using System.Diagnostics;
using Indeks.Views.Models;
namespace Indeks.Views {
    public partial class frmStokDurumRaporu : Form {
        IManagerFactory mngFac;
        IStokManager mngStok;
        IStokHareketManager mngStokHar;
        DataTable _source;
       
       
        public frmStokDurumRaporu() {
            InitializeComponent();
            mngFac = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
            mngStok = mngFac.GetStokManager();
            mngStokHar = mngFac.GetStokHareketManager();
            txtStokKodu.DataSource = () =>
            {
                try {
                    return mngStok.StokKods(txtStokKodu.Text, UserInfo.Sube).ToStringList(35, txtStokKodu.Ayirac);
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                    LogWrite.Write(exc);
                }
                return null;
            };
        }
        void LoadGrid() {
            try {

                //_source = mngStokHar.StokAlisSatisRapor(UserInfo.Sube.Id, txtStokKodu.Text, dtpStart.Value.JustDate(),
                //dtpFinish.Value.JustDate(), _alisGirisKod);
                _source= mngStokHar.StokDurumRapor(UserInfo.Sube.Id,txtStokKodu.Text);
                dataGridView1.DataSource = _source;
                if (_source != null && _source.Rows.Count > 0) {
                    tslabToplamMiktar.Text = ToplamMiktar().ToString("F2");                   
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

        private void rbButunStoklar_CheckedChanged(object sender, EventArgs e) {
            if (sender == rbButunStoklar) {
                grbStokKodu.Enabled = false;
                txtStokKodu.Text = String.Empty;
            } else {
                grbStokKodu.Enabled = true;
            }
        }
        double ToplamMiktar() {
            if (_source != null && _source.Rows.Count > 0)
                return double.Parse(_source.Compute("sum(Miktar)", "").ToString());
            else
                return 0;
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
                        report.TextFields.Title = "StokDurumRaporu";
                        report.TextFields.Header = string.Format(@"
            Rapor Tarihi:{0}
   
            ", DateTime.Now);
                        report.DataFields["Miktar"].ShowTotals = true;
                        string fileName ="stokDurumRaporu";
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
                        //frmStokDurumRaporForCrytalRapor frm2 = new frmStokDurumRaporForCrytalRapor(_source);
                        //frm2.Show();

                    }
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                    LogWrite.Write(exc);
                }
            }
        }

        private void btnStokRehber_Click(object sender, EventArgs e) {
            frmStokSearch frm = new frmStokSearch();
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
