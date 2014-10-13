using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
    public partial class frmStokMaliyetRaporu : Form {
        IManagerFactory mngFac;
        IStokManager mngStok;
        IStokHareketManager mngStokHar;
        DataTable _source;
        
        //string _alisGirisKod;
        DateTime? sd = null,fd=null;
        public frmStokMaliyetRaporu() {
            InitializeComponent();
            //_alisSatis = alisSatis;
            //_alisGirisKod = alisSatis == StokAlisSatisRapor.AlisRapor ? "G" : "C";
            //tabPageFiltre.Text = this.Text = alisSatis == StokAlisSatisRapor.AlisRapor ?
            //    "MalAlışMaliyetRaporu" : "MalSatışMaliyetRaporu";
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
                //_source = mngStokHar.StokMaliyetRaporu(UserInfo.Sube.Id,_alisGirisKod, txtStokKodu.Text,sd,
                //fd);
                _source = mngStokHar.StokMalMaliyetRaporu(UserInfo.Sube.Id, txtStokKodu.Text,txtStokGrup.Text,sd,fd);
                dataGridView1.DataSource = _source;
                if (_source != null && _source.Rows.Count > 0) {
                    tslabEldekiMalMiktar.Text = eldekiMalMiktar().ToString("F2");
                    tslabToplamAlisMiktar.Text = toplamAlisMiktar().ToString("F2");
                    tslabToplamAlisTutar.Text = toplamAlisTutar().ToString("F2");
                    tslabToplamSatisMiktar.Text = toplamSatisMiktar().ToString("F2");
                    tslabToplamSatisTutar.Text = toplamSatisTutar().ToString("F2");
                    tslabTopKalanMalinMaliyeti.Text = toplamKalanMalinMaliyeti().ToString("F2");
                }
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }
        string GetTarihAraligi() {
            if (rbButunTarih.Checked)
                return "Bütün Tarihler";
            else {
                string st = dtpStart.Value.ToString("d");
                string fd = dtpFinish.Value.ToString("d");
                return string.Format("{0}-{1}", st, fd);
            }
        }
        double toplamAlisMiktar() {
            if (_source != null && _source.Rows.Count > 0)
                return double.Parse(_source.Compute("sum(AlisMiktar)", "").ToString());
            else
                return 0;
        }
        double toplamSatisMiktar() {
            if (_source != null && _source.Rows.Count > 0)
                return double.Parse(_source.Compute("sum(SatisMiktar)", "").ToString());
            else
                return 0;
        }
        double eldekiMalMiktar() {
            if (_source != null && _source.Rows.Count > 0)
                return double.Parse(_source.Compute("sum(KalanMiktar)", "").ToString());
            else
                return 0;
        }
        double toplamAlisTutar() {
            if (_source != null && _source.Rows.Count > 0)
                return double.Parse(_source.Compute("sum(AlisTutar)", "").ToString());
            else
                return 0;
        }
        double toplamSatisTutar() {
            if (_source != null && _source.Rows.Count > 0)
                return double.Parse(_source.Compute("sum(SatisTutar)", "").ToString());
            else
                return 0;
        }
        double toplamKalanMalinMaliyeti() {
            if (_source != null && _source.Rows.Count > 0)
                return double.Parse(_source.Compute("sum(KalanMalinMaliyeti)", "").ToString());
            else
                return 0;
        }
        string SecilenStok() {
            if (rbButunStoklar.Checked)
                return "Bütün stoklar";
            else {                      
                    Stok stok = mngStok.GetById(txtStokKodu.Text, false);
                    if (stok != null)
                        return "StokKodu=" + stok.Id + " Stok Ismi=" + stok.StokAdi;
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
            Stok:{1}
            Rapor Tarih Aralığı:{2}            
            ", DateTime.Now, SecilenStok(),GetTarihAraligi()
            );

                        //report.DataFields["Tarih"].DataFormatString = "{0:d}";
                        //report.DataFields["BirimFiyat"].DataFormatString = "{0:F2}";
                        //report.DataFields["Tutar"].DataFormatString = "{0:F2}";
                        report.RenderHints["HtmlStyle"] = "th { font-size: 13px !important;font-weight:bold !important;}";
                        report.RenderHints["HtmlStyle"] = "td { font-size: 11px !important;line-height:1em; }";
                        report.DataFields["KalanMiktar"].ShowTotals = true;
                        report.DataFields["SatisMiktar"].ShowTotals = true;
                        report.DataFields["AlisMiktar"].ShowTotals = true;
                        report.DataFields["OrtalamaAlisFiyat"].ShowTotals = true;
                        report.DataFields["OrtalamaSatisFiyat"].ShowTotals = true;
                        report.DataFields["AlisTutar"].ShowTotals = true;

                        report.DataFields["SatisTutar"].ShowTotals = true;
                        report.DataFields["KalanMalinMaliyeti"].ShowTotals = true;

                        string fileName ="malMaliyetRaporu";
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

        private void rbButunTarih_CheckedChanged(object sender, EventArgs e) {
            if (sender == rbButunTarih) {
                fd = sd = null; grbTarih.Enabled = false;
            } else {
                grbTarih.Enabled = true;
            }
        }

        private void rbButunStoklar_CheckedChanged(object sender, EventArgs e) {
            if (sender == rbButunStoklar) {
                grbStokKodu.Enabled = false; txtStokKodu.Text = string.Empty;
            } else {
                grbStokKodu.Enabled = true;
            }
        }

        private void btnGrupRehber_Click(object sender, EventArgs e) {
            frmStokCariCategoryTree frm = new frmStokCariCategoryTree(StokCariCategory.Stok);
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void btnStokRehber_Click(object sender, EventArgs e) {
            frmStokSearch frm = new frmStokSearch();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void stokListesiToolStripMenuItem_Click(object sender, EventArgs e) {
            DateTime? begin = null, end = null;
            if (rbTarihAralikli.Checked) {
                begin = dtpStart.Value;
                end = dtpFinish.Value;
            }
            frmStokHareketListesi frm = new frmStokHareketListesi(
                dataGridView1.CurrentRow.Cells[0].Value.ToStringOrEmpty(), "", begin, end);

            frm.ShowDialog();
        }

        private void cmsStokListesi_Opening(object sender, CancelEventArgs e) {
           
        }

        private void kalanMiktarSifirUstu_Click(object sender, EventArgs e) {

        }

        private void kalanMiktarEksiyeDusenlerListesiToolStripMenuItem_Click(object sender, EventArgs e) {
            if (_source != null && _source.Rows.Count > 1) {
                try {
                   
                } catch (Exception exc) {
                    LogWrite.Write(exc);
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void kalanMiktarSifirinUstundeOlanlarToolStripMenuItem_Click(object sender, EventArgs e) {
            if (_source != null) {
                DataView view = new DataView(_source);
                view.RowFilter = "KalanMiktar>0";
                dataGridView1.DataSource = view;
                _source = view.ToTable();
            }
        }

        private void kalanMiktarSifirinAltindaOlanlarToolStripMenuItem_Click(object sender, EventArgs e) {
            if (_source != null) {
                DataView view = new DataView(_source);
                view.RowFilter = "KalanMiktar<0";
                dataGridView1.DataSource = view;
                _source = view.ToTable();
            }
        }
    }
}
