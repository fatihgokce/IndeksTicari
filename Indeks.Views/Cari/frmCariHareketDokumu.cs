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
namespace Indeks.Views {
    public partial class frmCariHareketDokumu : Form {
        IManagerFactory _mng;
        ICariManager _mngCari;
        ICariHareketManager _mngCariHar;
        DataTable _source;
        DateTime? sd = null, fd = null;
        public frmCariHareketDokumu() {
            InitializeComponent();
            _mng = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
            _mngCariHar = _mng.GetCariHareketManager();
            _mngCari = _mng.GetCariManager();
            SelectCheckBoxes(true);
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
            } else { grbCariKodu.Enabled = true; }
        }

        private void rbButunTarih_CheckedChanged(object sender, EventArgs e) {
            if (sender == rbButunTarih) {
                grbTarih.Enabled = false;
                sd = null;
                fd = null;
            } else { grbTarih.Enabled = true; }
        }

        private void btnRapor_Click(object sender, EventArgs e) {
            LoadGrid();
            btnPrint.Visible = true;

        }
        void SelectCheckBoxes(bool state) {
            for (int i = 0; i < checkedListBoxHareketTipleri.Items.Count; i++) {
                checkedListBoxHareketTipleri.SetItemChecked(i, state);
            }
        }

        private void chbHepsi_CheckedChanged(object sender, EventArgs e) {
            SelectCheckBoxes(chbHepsi.Checked);
        }
        void LoadGrid() {
            try {

                if (rbTarihAralikli.Checked) {
                    sd = dtpStart.Value;
                    fd = dtpFinish.Value;
                }
                CariHareketleriDurumu durum = SecilenCariDurumlari();
                durum.EndDate = fd;
                durum.BeginDate = sd;
                //             Devir=1,
                //NakitTahsilat=2,NakitOdeme=3,
                //AlinanMal=4,SatilanMal=5,AlinanMalIadesi=6
                //,SatilanMalIadesi=7,
                //AlinanCek=8,VerilenCek=9,CekCirosu=10,AlinanCekIade=11,
                //VerilenCekGeriAlinmasi, KarsiliksizCek, AlinanSenet=14,
                //VerilenSenet,SenetCirosu,AlinanSenetIade=17,
                //VerilenSenetGeriAlinmasi,
                //KarsiliksizSenet,Veresiye,
                //GelenHavale,GonderilenHavale=22
                _source = _mngCariHar.CariHareketDokumu(UserInfo.Sube.Id, txtCariKodu.Text, durum);
                _source.Replace("HareketTuru", "2", "NakitTahsilat");
                _source.Replace("HareketTuru", "3", "NakitÖdeme");
                _source.Replace("HareketTuru", "4", "AlınanMal"); _source.Replace("HareketTuru", "5", "SatılanMal");
                _source.Replace("HareketTuru", "6", "AlınanMalIadesi"); _source.Replace("HareketTuru", "7", "SatılanMalIadesi");
                _source.Replace("HareketTuru", "8", "AlınanÇek"); _source.Replace("HareketTuru", "9", "VerilenÇek");
                _source.Replace("HareketTuru", "10", "ÇekCirosu"); _source.Replace("HareketTuru", "11", "AlınanÇekIade");
                _source.Replace("HareketTuru", "12", "VerilenÇekGeriAlınması"); _source.Replace("HareketTuru", "13", "KarşılıksızÇek");
                _source.Replace("HareketTuru", "14", "AlınanSenet"); _source.Replace("HareketTuru", "15", "VerilenSenet");
                _source.Replace("HareketTuru", "16", "SenetCirosu"); _source.Replace("HareketTuru", "17", "AlınanSenetIade");
                _source.Replace("HareketTuru", "18", "VerilenSenetGeriAlınması"); _source.Replace("HareketTuru", "19", "KarşılıksızSenet");
                _source.Replace("HareketTuru", "20", "Veresiye"); _source.Replace("HareketTuru", "21", "GelenHavale");
                _source.Replace("HareketTuru", "22", "GönderilenHavale");

                dataGridView1.DataSource = _source;
                if (_source != null && _source.Rows.Count > 0) {
                    tslabToplamBorc.Text = ToplamBorc().ToString("F2");
                    tslabToplamAlacak.Text = ToplamAlacak().ToString("F2");
                    tslabTopBakiye.Text = ToplamBakiye().ToString("F2");
                    dataGridView1.Columns["Borc"].DefaultCellStyle.Format = "F2";
                    dataGridView1.Columns["Alacak"].DefaultCellStyle.Format = "F2";
                }
            } catch (Exception exc) {
                LogWrite.Write(exc);
                MessageBox.Show(exc.Message);
            }

        }
        CariHareketleriDurumu SecilenCariDurumlari() {
            CariHareketleriDurumu durum = new CariHareketleriDurumu();        
            
            foreach (object itemChecked in checkedListBoxHareketTipleri.CheckedItems) {

                if (itemChecked.ToString() == "NakitTahsilat")
                    durum.NakitTahsilat = true;
                if (itemChecked.ToString() == "NakitOdeme")
                    durum.NakitOdeme = true;
                if (itemChecked.ToString() == "AlinanMal")
                    durum.AlinanMal = true;
                if (itemChecked.ToString() == "SatilanMal")
                    durum.SatilanMal = true;
                if (itemChecked.ToString() == "AlinanMalIadesi")
                    durum.AlinanMalIadesi = true;
                if (itemChecked.ToString() == "SatilanMalIadesi")
                    durum.SatilanMalIadesi = true;
                if (itemChecked.ToString() == "AlinanCek")
                    durum.AlinanCek = true;
                if (itemChecked.ToString() == "VerilenCek")
                    durum.VerilenCek = true;
                if (itemChecked.ToString() == "CekCirosu")
                    durum.CekCirosu = true;

                if (itemChecked.ToString() == "AlinanCekIade")
                    durum.AlinanCekIade = true;
                if (itemChecked.ToString() == "VerilenCekGeriAlinmasi")
                    durum.VerilenCekGeriAlinmasi = true;
                if (itemChecked.ToString() == "KarsiliksizCek")
                    durum.KarsiliksizCek = true;

                if (itemChecked.ToString() == "AlinanSenet")
                    durum.AlinanSenet = true;
                if (itemChecked.ToString() == "VerilenSenet")
                    durum.VerilenSenet = true;
                if (itemChecked.ToString() == "SenetCirosu")
                    durum.SenetCirosu = true;

                if (itemChecked.ToString() == "AlinanSenetIade")
                    durum.AlinanSenetIade = true;
                if (itemChecked.ToString() == "VerilenSenetGeriAlinmasi")
                    durum.VerilenSenetGeriAlinmasi = true;
                if (itemChecked.ToString() == "KarsiliksizSenet")
                    durum.KarsiliksizSenet = true;

                if (itemChecked.ToString() == "Veresiye")
                    durum.Veresiye = true;
                if (itemChecked.ToString() == "GelenHavale")
                    durum.GelenHavale = true;
                if (itemChecked.ToString() == "GonderilenHavale")
                    durum.GonderilenHavale = true;
            }      
          
            return durum;
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
                    Cari cari = _mngCari.GetById(txtCariKodu.Text, false);
                    if (cari != null)
                        return cari.Id +" " + cari.CariIsim;
                    else
                        return "";
                
            }
        }
        double ToplamBakiye() {
            if (_source==null)
                return 0;
            double b = double.Parse(_source.Compute("sum(Borc)", "").ToString());
            double a = double.Parse(_source.Compute("sum(Alacak)", "").ToString());
            return b - a;
        }
        double ToplamBorc() {
            if (_source == null)
                return 0;
            double b = double.Parse(_source.Compute("sum(Borc)", "").ToString());
            return b;
        }
        double ToplamAlacak() {
            if (_source == null)
                return 0;
            double b = double.Parse(_source.Compute("sum(Alacak)", "").ToString());
            return b;
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
                        report.TextFields.Title = tabPage2.Text;
                        report.TextFields.Header = string.Format(@"
            Rapor Tarihi:{0}
            Rapor Tarih Aralığı:{1}
            Cari:{2}         
            ", DateTime.Now, GetTarihAraligi(), RaporCariString());
                        report.DataFields["Tarih"].DataFormatString = "{0:d}";
                        report.DataFields["Borc"].DataFormatString = "{0:F2}";
                        report.DataFields["Alacak"].DataFormatString = "{0:F2}";
                        report.DataFields["Alacak"].ShowTotals = true;
                        report.DataFields["Borc"].ShowTotals = true;
                        string fileName = "cariHareketDokumu.xls";
                        IReportWriter writer = new ExcelReportWriter();
                       
                        if (dest.Value == ReportTo.Html) {
                            writer = new HtmlReportWriter();
                            fileName = "cariHareketDokumu.html";
                        } else if (dest.Value == ReportTo.Csv) {
                            writer = new DelimitedTextReportWriter();
                            fileName = "cariHareketDokumu.txt";
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

        private void btnCariRehber_Click(object sender, EventArgs e) {
            frmCariRehber frm = new frmCariRehber();
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
