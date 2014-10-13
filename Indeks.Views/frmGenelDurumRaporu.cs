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
using System.Threading;
namespace Indeks.Views {
    struct DurumGelirGider {
        public double KasadakiPara { get; set; }
        public double CarilerdenToplamAlacak { get; set; }
        public double BankadakiPara { get; set; }
        public double TahsilEdilecekCekler { get; set; }
        public double TahsilEdilecekSenetler { get; set; }
        public double OrtalamaAlisFiyatinaGoreStokDegeri { get; set; }
        public double CarilerinToplamAlacagi { get; set; }
        public double OdenecekCekler { get; set; }
        public double OdenecekSenetler { get; set; }
    }
    struct DurumGiderler {
        public double CarilerinToplamAlacagi { get; set; }
        public double OdencekCekler { get; set; }
        public double OdencekSenetler { get; set; }
    }
    public partial class frmGenelDurumRaporu : Form {
        IManagerFactory _mng;
        IKasaHarManager _mngKasaHar;
        ICariHareketManager _mngCariHar;
        IHesapHareketManager _mngHesHar;
        ISenetManager _mngSenet;
        ICekManager _mngCek;
        IStokHareketManager _mngStokHar;
        DurumGelirGider _gelirler;
        //DurumGiderler _giderler;
        public frmGenelDurumRaporu() {
            InitializeComponent();
            frmGenelDurumRaporu.CheckForIllegalCrossThreadCalls = false;
            _mng = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
            _mngKasaHar = _mng.GetKasaHarManager();
            _mngCariHar = _mng.GetCariHareketManager();
            _mngHesHar = _mng.GetHesapHareketManager();
            _mngSenet = _mng.GetSenetManager();
            _mngCek = _mng.GetCekManager();
            _mngStokHar = _mng.GetStokHareketManager();
        }

        private void btnRapor_Click(object sender, EventArgs e) {
            labBekleyin.Text = "Lütfen Bekleyiniz";
            ThreadStart ths = new ThreadStart(LoadRaporlari);
            Thread th = new Thread(ths);
            th.Start();
            btnPrint.Visible = true;

        }
        void LoadRaporlari() {
            try {
                DateTime? bdt = null, fdt = null;
                if (rbTarihAralikli.Checked) {
                    bdt = dtpStart.Value.JustDate();
                    fdt = dtpFinish.Value.JustDate();                   
                }
                _gelirler = new DurumGelirGider();
                //_giderler = new DurumGiderler();
                _gelirler.OrtalamaAlisFiyatinaGoreStokDegeri = _mngStokHar.OrtalamaAlisFiyatinaGoreStokDegeri(UserInfo.Sube.Id,bdt,fdt);
                _gelirler.KasadakiPara=_mngKasaHar.KasalardakiToplamGelir(UserInfo.Sube.Id, bdt, fdt);
                _gelirler.CarilerdenToplamAlacak=_mngCariHar.CarilerinToplamBorcu(UserInfo.Sube.Id, bdt, fdt);
                _gelirler.CarilerinToplamAlacagi=_mngCariHar.CarilerinToplamAlacagi(UserInfo.Sube.Id, bdt, fdt);
                _gelirler.BankadakiPara=_mngHesHar.BankalardakiToplamPara(UserInfo.Sube.Id, bdt, fdt);
                _gelirler.TahsilEdilecekCekler= _mngCek.TahsilEdilcekCekToplami(UserInfo.Sube.Id,bdt,fdt);
                _gelirler.OdenecekCekler=_mngCek.OdencekCekToplami(UserInfo.Sube.Id, bdt, fdt);
                _gelirler.TahsilEdilecekSenetler=_mngSenet.TahsilEdilcekSenetToplami(UserInfo.Sube.Id,bdt,fdt);
                _gelirler.OdenecekSenetler=_mngSenet.OdencekSenetToplami(UserInfo.Sube.Id, bdt, fdt);

                txtKasaPara.Text =_gelirler.KasadakiPara.ToString("F2") ;
                txtCarilerdenAlacak.Text = _gelirler.CarilerdenToplamAlacak.ToString("F2") ;
                txtCarilereTopBorc.Text = _gelirler.CarilerinToplamAlacagi.ToString("F2");
                txtBankaPara.Text = _gelirler.BankadakiPara.ToString("F2") ;
                txtTahsilCek.Text =_gelirler.TahsilEdilecekCekler.ToString("F2");
                txtOdencekCekler.Text =_gelirler.OdenecekCekler .ToString("F2");
                txtTahsilSenet.Text =_gelirler.TahsilEdilecekSenetler.ToString("F2");
                txtOdencekSenetler.Text = _gelirler.OdenecekSenetler.ToString("F2") ;
                txtOrtalamAlisStokDegeri.Text = _gelirler.OrtalamaAlisFiyatinaGoreStokDegeri.ToString("F2");
                HesaplaToplamlari();
               
                labBekleyin.Text = "";
            } catch (Exception exc) {
                labBekleyin.Text = "";
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }
        double toplamGelir() {
            double topGelir = _gelirler.BankadakiPara + _gelirler.CarilerdenToplamAlacak;
            topGelir += _gelirler.KasadakiPara + _gelirler.TahsilEdilecekCekler;
            topGelir += _gelirler.TahsilEdilecekSenetler;           
            return topGelir;
        }
        double toplamGider() {
            double topGider = _gelirler.CarilerinToplamAlacagi + _gelirler.OdenecekCekler;
            topGider += _gelirler.OdenecekSenetler;
            return topGider;
        }
        double bakiye() {
            return toplamGelir() - toplamGider();
        }
        void HesaplaToplamlari() {
            double topGelir = _gelirler.BankadakiPara + _gelirler.CarilerdenToplamAlacak;
            topGelir += _gelirler.KasadakiPara + _gelirler.TahsilEdilecekCekler;
            topGelir += _gelirler.TahsilEdilecekSenetler;
            double topGider = _gelirler.CarilerinToplamAlacagi + _gelirler.OdenecekCekler;
            topGider += _gelirler.OdenecekSenetler ;
            double bakiye = topGelir - topGider;
            txtToplamGelir.Text = topGelir.ToString("F2");
            txtToplamGider.Text = topGider.ToString("F2");
            tslabToplamBakiye.Text = bakiye.ToString("F2");
        }
        private void rbButunTarih_CheckedChanged(object sender, EventArgs e) {
            grbTarih.Enabled = false;
        }

        private void rbTarihAralikli_CheckedChanged(object sender, EventArgs e) {
            grbTarih.Enabled = true;
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
        private void btnPrint_Click(object sender, EventArgs e) {
            frmRaporDialog frm = new frmRaporDialog(true, true, true, false);
            frm.ShowDialog();
            ReportTo? dest = frm.GetReportDestination();
            if (dest.HasValue) {
                try {
                    if (dest != ReportTo.CrytalReport) {
                        List<DurumGelirGider> liste = new List<DurumGelirGider>();
                       
                        liste.Add(_gelirler);
                       
                        var report = new Report(liste.ToReportSource());
                     
                     
                        // Customize the Text Fields
                        report.RenderHints.IncludePageNumbers = true;
                        report.TextFields.Title = "Genel Durum Raporu";
                        report.TextFields.Header = string.Format(@"
            Rapor Tarihi:{0} 
            Toplam Gelir:{1:F}
            Toplam Gider:{2:F}
            Bakiye:{3:F}
            Rapor Tarih Aralığı:{4}
            
            ", DateTime.Now,toplamGelir(),toplamGider(),bakiye(), GetTarihAraligi());
                        //report.DataFields["Alacak"].DataFormatString = "{0:F2}";
                        //report.DataFields["Borc"].DataFormatString = "{0:F2}";
                        //report.DataFields["AlacakBakiyesi"].DataFormatString = "{0:F2}";
                        //report.DataFields["BorcBakiyesi"].DataFormatString = "{0:F2}";
                        string fileName = "genelDurumRaporu.xls";
                        IReportWriter writer = new ExcelReportWriter();

                        if (dest.Value == ReportTo.Html) {
                            writer = new HtmlReportWriter();
                            fileName = "genelDurumRaporu.html";
                        } else if (dest.Value == ReportTo.Csv) {
                            writer = new DelimitedTextReportWriter();
                            fileName = "genelDurumRaporu.txt";
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
    }
}
