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
using Indeks.Data.Helper;
namespace Indeks.Views {
    public partial class frmCariGenelBorcAlacakDokumu : Form {
        IManagerFactory _mngFac;
        ICariHareketManager _mngCariHar;
        ICariManager _mngCari;
        DataTable _source;
        DateTime? sd = null, fd = null;
        public frmCariGenelBorcAlacakDokumu() {
            InitializeComponent();
            _mngFac = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
            _mngCariHar = _mngFac.GetCariHareketManager();
            _mngCari = _mngFac.GetCariManager();
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

        private void rbButunCariler_CheckedChanged(object sender, EventArgs e) {
            if (sender == rbButunCariler) {
                grbCariKodu.Enabled = false;
                txtCariKodu.Text = string.Empty;
            } else
                grbCariKodu.Enabled = true;
        }

        private void rbButunTarih_CheckedChanged(object sender, EventArgs e) {
            if (rbButunTarih == sender) {
                grbTarih.Enabled = false;
                sd =fd= null;
            } else
                grbTarih.Enabled = true;
        }

        private void btnRapor_Click(object sender, EventArgs e) {
            LoadGrid();
            btnPrint.Visible = true;
        }
        void LoadGrid() {
            try {           
                
                if (rbTarihAralikli.Checked) {
                    sd = dtpStart.Value;
                    fd = dtpFinish.Value;
                }
                _source = _mngCariHar.GenelBorcAlacakDokumu(UserInfo.Sube.Id,txtCariKodu.Text,sd,fd);
                dataGridView1.DataSource = _source;
                if (_source != null && _source.Rows.Count > 0) {
                    double borc = double.Parse(_source.Compute("sum(Borc)", "").ToString());
                    double alacak = double.Parse(_source.Compute("sum(Alacak)", "").ToString());
                    tslabCariToplamBorc.Text=borc.ToString("F2");
                    tslabCariToplamAlacak.Text=alacak.ToString("F2");
                    tslabCariBakiyesi.Text=(borc-alacak).ToString("F2");
                    dataGridView1.Columns["Borc"].DefaultCellStyle.Format = "F2";
                    dataGridView1.Columns["Alacak"].DefaultCellStyle.Format = "F2";
                    dataGridView1.Columns["BorcBakiyesi"].DefaultCellStyle.Format = "F2";
                    dataGridView1.Columns["AlacakBakiyesi"].DefaultCellStyle.Format = "F2";
                }

            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }
        string GetTarihAraligi() {
            if (rbButunTarih.Checked) {
                return "Bütün Tarihler";
            } else {
                string st = dtpStart.Value.ToString("d");
                string fd = dtpFinish.Value.ToString("d");
                return string.Format("{0}-{1}", st, fd);
            }
        }
        string RaporCariString() {
            if (rbButunCariler.Checked) {
                return "Bütün Cariler";
            } else {
                Cari cari = _mngCari.GetById(txtCariKodu.Text,false);
                if (cari != null)
                    return "CariKodu="+cari.Id + " Cari Ismi=" + cari.CariIsim;
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
                        report.TextFields.Title = "Cari Genel Borç Alacak Dokümü";
                        report.TextFields.Header = string.Format(@"
            Rapor Tarihi:{0}
            Cari:{1}           
            Rapor Tarih Aralığı:{2}
            
            ", DateTime.Now,RaporCariString(), GetTarihAraligi());
                        report.DataFields["Alacak"].DataFormatString = "{0:F2}";
                        report.DataFields["Borc"].DataFormatString = "{0:F2}";
                        report.DataFields["AlacakBakiyesi"].DataFormatString = "{0:F2}";
                        report.DataFields["BorcBakiyesi"].DataFormatString = "{0:F2}";
                        report.DataFields["Alacak"].ShowTotals = true;
                        report.DataFields["Borc"].ShowTotals = true;
                        report.DataFields["AlacakBakiyesi"].ShowTotals = true;
                        report.DataFields["BorcBakiyesi"].ShowTotals = true;  
                        string fileName = "cariGenelborcAlacakDokumu.xls";
                        IReportWriter writer = new ExcelReportWriter();

                        if (dest.Value == ReportTo.Html) {
                            writer = new HtmlReportWriter();
                            fileName = "cariGenelborcAlacakDokumu.html";
                        } else if (dest.Value == ReportTo.Csv) {
                            writer = new DelimitedTextReportWriter();
                            fileName = "cariGenelborcAlacakDokumu.txt";
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

        private void btnCariRehber_Click(object sender, EventArgs e) {
            frmCariRehber frm = new frmCariRehber();
            frm.Owner = this;
            frm.Show();
        }

        private void cariListesiToolStripMenuItem_Click(object sender, EventArgs e) {
            CariHareketleriDurumu durum = new CariHareketleriDurumu();
            if (rbTarihAralikli.Checked) {
                durum.BeginDate = dtpStart.Value;
                durum.EndDate = dtpFinish.Value;
            }
            frmCariHareketListesi frm = new frmCariHareketListesi(durum,dataGridView1.CurrentRow
                .Cells[0].Value.ToStringOrEmpty());
            frm.ShowDialog();
        }
    }
}
