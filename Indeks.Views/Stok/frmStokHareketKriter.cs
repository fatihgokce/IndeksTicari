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
    public partial class frmStokHareketKriter : Form {
        IManagerFactory mngFac;
        IStokHareketManager mngstokHar;
        IStokManager mngStk;
        DataTable _source;
        public frmStokHareketKriter() {
            InitializeComponent();
            grbStokKodu.Enabled = false;
            mngFac = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
            mngstokHar = mngFac.GetStokHareketManager();
            mngStk = mngFac.GetStokManager();
            txtStokKodu.DataSource = () =>
            {
                try {
                    return mngStk.StokKods(txtStokKodu.Text, UserInfo.Sube).ToStringList(35, txtStokKodu.Ayirac);
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                    LogWrite.Write(exc);
                }
                return null;
            };
        }
        private void btnStokRehber_Click(object sender, EventArgs e) {
            frmStokSearch frm = new frmStokSearch();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void btnRapor_Click(object sender, EventArgs e) {
            LoadGrid();
            btnPrint.Visible = true;
        }
        void LoadGrid() {
            try {
                string gcKod = GetGirisCikisKod();
                _source = mngstokHar.StokHareketDokumu(UserInfo.Sube.Id,txtStokKodu.Text,gcKod,dtpStart.Value.JustDate(), dtpFinish.Value.JustDate());
                _source.Replace("GCKod", "G", "MalAlış"); _source.Replace("GCKod", "C", "MalSatış");
                _source.Replace("Tip", "F", "Fatura"); _source.Replace("Tip", "I", "İrsaliye");
             
                dataGridView1.DataSource = _source;
                if (_source != null && _source.Rows.Count > 0) {
                    tslabToplamMiktar.Text = ToplamMiktar().ToString("F2");
                    tslabToplamTutar.Text = ToplamTutar().ToString("F2");
                    dataGridView1.Columns["Tutar"].DefaultCellStyle.Format = "F2";
                }
              
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }
        double ToplamMiktar() {
            if (_source == null)
                return 0;
            return double.Parse(_source.Compute("sum(GCMiktar)", "").ToString());
        }
        double ToplamTutar() {
            if (_source == null)
                return 0;
            return double.Parse(_source.Compute("sum(Tutar)", "").ToString());
        }
        private void btnPrint_Click(object sender, EventArgs e) {
            frmRaporDialog frm = new frmRaporDialog(true, true, true, false);
            frm.ShowDialog(); 
            ReportTo? dest=frm.GetReportDestination();
            if (dest.HasValue) {
                try {
                    if (dest != ReportTo.CrytalReport) {
                        var report = new Report(_source.ToReportSource());
                        // Customize the Text Fields
                        report.RenderHints.IncludePageNumbers = true;
                        report.TextFields.Title = "Stok Hareket Dökümü";
                        report.TextFields.Header = string.Format(@"
            Rapor Tarihi:{0}
            Tarih Aralığı:{1}
            Hareket:{2} 
            ", DateTime.Now, GetTarihAraligi(), GetGirisCikisStrting());
                        report.DataFields["Tarih"].DataFormatString = "{0:d}";
                        report.DataFields["BirimFiyat"].DataFormatString = "{0:F2}";
                        report.DataFields["Tutar"].DataFormatString = "{0:F2}";
                        report.DataFields["GCMiktar"].ShowTotals = true;
                        report.DataFields["Tutar"].ShowTotals = true;
                        string fileName = "kasahareketDokumu.xls";
                        IReportWriter writer = new ExcelReportWriter();                  
                     
                        if (dest.Value == ReportTo.Html) {
                            writer = new HtmlReportWriter();
                            fileName = "kasahareketDokumu.html";
                        } else if (dest.Value == ReportTo.Csv) {
                            writer = new DelimitedTextReportWriter();
                            fileName = "kasahareketDokumu.txt";
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
        string GetGirisCikisKod() {
            if (rbCikis.Checked)
                return "C";
            if (rbGiris.Checked)
                return "G";
            return "";
        }
        string GetTarihAraligi() {       
            string st = dtpStart.Value.ToString("d");
            string fd = dtpFinish.Value.ToString("d");
            return string.Format("{0}-{1}",st,fd);
        }
        string GetGirisCikisStrting() {
            if (rbCikis.Checked)
                return "MalSatış";
            if (rbGiris.Checked)
                return "MalAlış";
            return "Mal Alış ve Satış";
        }
        private void rbButunStoklar_CheckedChanged(object sender, EventArgs e) {
            if (sender == rbButunStoklar) {
                grbStokKodu.Enabled = false;
                txtStokKodu.Text = String.Empty;
            } else {
                grbStokKodu.Enabled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
           
        }

        private void faturayaGitToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                DataGridViewRow r = dataGridView1.CurrentRow;
                if (r != null) {
                    string fisNo = dataGridView1.CurrentRow.Cells["FisNo"].Value.ToStringOrEmpty();
                    string tip = dataGridView1.CurrentRow.Cells["Tip"].Value.ToStringOrEmpty();
                    string kod = dataGridView1.CurrentRow.Cells["GCKod"].Value.ToStringOrEmpty();
                    FTIRSIP ftir = FTIRSIP.AlisFat;
                    Indeks.Data.Helper.FatNoTip fatn = Indeks.Data.Helper.FatNoTip.Fatura;
                    if (tip == "Fatura") {
                        fatn = Indeks.Data.Helper.FatNoTip.Fatura;
                        if (kod == "MalAlış")
                            ftir = FTIRSIP.AlisFat;
                        else {
                            if (fisNo.StartsWith("0ds"))
                                ftir = FTIRSIP.DirektSatis;
                            else
                                ftir = FTIRSIP.SatisFat;
                        }
                    } else if (tip == "İrsaliye") {
                        fatn = Indeks.Data.Helper.FatNoTip.Irsaliye;
                        if (kod == "MalAlış")
                            ftir = FTIRSIP.AlisIrs;
                        else
                            ftir = FTIRSIP.SatisFat;
                    }
                    frmFatura frm = new frmFatura(ftir, fatn, fisNo);
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                }
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }
    }
}
