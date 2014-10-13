using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Indeks.Data.BusinessObjects;
using Indeks.Data.ManagerObjects;
using Indeks.Views.ReportHelp;
using Doddle.Reporting;
using Doddle.Reporting.Writers;
using System.IO;
using System.Diagnostics;
using Indeks.Views.Models;
using System.Linq;
namespace Indeks.Views
{
  public partial class frmBankaHareketRapor : Form
  {
    IManagerFactory mngFac;
    IHesapHareketManager mngHesap;
    List<HesapHareket> hareketList;
    public frmBankaHareketRapor()
    {
      InitializeComponent();
      mngFac = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
      mngHesap = mngFac.GetHesapHareketManager();
    }
    DataTable ListToDataTable() {
        DataTable dt = new DataTable();
        dt.Columns.AddRange(
                            new DataColumn[]
                          {
                            new DataColumn("Tarih"),
                            new DataColumn("HareketTuru"),
                            new DataColumn("DekontNo",typeof(string)),
                            new DataColumn("CariKod"),new DataColumn("FisNo"),                           
                            new DataColumn("Tutar",typeof(double)),
                            new DataColumn("Aciklama")
                          });
        foreach (var item in hareketList) {
            DataRow dr = dt.NewRow();
            dr["Tarih"] =item.Tarih.ToStringOrEmpty();
            dr["HareketTuru"] =item.HareketTuru.ToStringOrEmpty();
            dr["DekontNo"] = item.DekontNo.ToStringOrEmpty();
            dr["CariKod"] = item.CariKod.ToStringOrEmpty();
            dr["FisNo"] =item.FisNo.ToStringOrEmpty();
            dr["Tutar"] = item.Tutar.ToStringOrEmpty("0");
            dr["Aciklama"] = item.Aciklama.ToStringOrEmpty();
            dt.Rows.Add(dr);
        }
        ReplaceCoumnOfDataTable(dt);
        return dt;
    }
    
    private void ReplaceCoumnOfDataTable(DataTable dt) {
        dt.Replace("HareketTuru", "1", "ParaYatirma(+)");
        dt.Replace("HareketTuru", "2", "ParaCekme(-)");
        dt.Replace("HareketTuru", "3", "GelenHavale(+)");
        dt.Replace("HareketTuru", "4", "GidenHavale(-)");
        dt.Replace("HareketTuru", "5", "KrediKarti");
        dt.Replace("HareketTuru", "6", "ÇekÖdeme");
        dt.Replace("HareketTuru", "7", "ÇekTahsil");
        dt.Replace("HareketTuru", "8", "SenetTahsil");
    }
    private void btnRaporla_Click(object sender, EventArgs e)
    {
      try
      {

        HesapHareketTuru? turu = null;
        turu = HareketTipiniBelirle(turu);
        hareketList= mngHesap.GetHesapNoWithDate(UserInfo.Sube.Id, txtHesapNo.Text, dateTimeStart.Value.JustDate(), dateTimeFinish.Value.JustDate(),turu);
        dataGridView1.Columns[clTutar.Name].DefaultCellStyle.Format = "F2";
          dataGridView1.AutoGenerateColumns = false;
  
        hareketList.Replace("HareketTuru", "1", "ParaYatirma(+)");
        hareketList.Replace("HareketTuru","2","ParaCekme(-)");
        hareketList.Replace("HareketTuru", "3", "GelenHavale(+)");
        hareketList.Replace("HareketTuru", "4", "GidenHavale(-)");
        hareketList.Replace("HareketTuru", "5", "KrediKarti");
        hareketList.Replace("HareketTuru", "6", "ÇekÖdeme");
        hareketList.Replace("HareketTuru", "7", "ÇekTahsil");
        hareketList.Replace("HareketTuru", "8", "SenetTahsil");
        if (hareketList.Count > 0) {
            btnPrint.Visible = true;
            tslabToplamTutar.Text = hareketList.Sum(x => x.Tutar).ToString("F2");
        } else
            btnPrint.Visible = false;
        dataGridView1.DataSource = hareketList;

      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      }
    }

    private HesapHareketTuru? HareketTipiniBelirle(HesapHareketTuru? turu) {
        if (cmboxHareketTipi.Text.Trim() == "ParaYatirma(+)")
            turu = HesapHareketTuru.ParaYatirma;
        else if (cmboxHareketTipi.Text.Trim() == "ParaCekme(-)")
            turu = HesapHareketTuru.ParaCekme;
        else if (cmboxHareketTipi.Text.Trim() == "GelenHavale(+)")
            turu = HesapHareketTuru.GelenHavale;
        else if (cmboxHareketTipi.Text.Trim() == "GidenHavale(-)")
            turu = HesapHareketTuru.GonderilenHavale;
        else if (cmboxHareketTipi.Text.Trim() == "KrediKarti")
            turu = HesapHareketTuru.KrediKarti;
        else if (cmboxHareketTipi.Text.Trim() == "ÇekÖdeme")
            turu = HesapHareketTuru.CekOdeme;
        else if (cmboxHareketTipi.Text.Trim() == "ÇekTahsil")
            turu = HesapHareketTuru.CekTahsil;
        else if (cmboxHareketTipi.Text.Trim() == "SenetTahsil")
            turu = HesapHareketTuru.SenetTahsil;
        return turu;
    }

    private void btnHesapRehber_Click(object sender, EventArgs e)
    {
      frmBankaHesapRehber frm = new frmBankaHesapRehber();
      frm.Owner = this;
      frm.Show();
    }
    string GetTarihAraligi() {
        string st = dateTimeStart.Value.ToString("d");
        string fd = dateTimeFinish.Value.ToString("d");
        return string.Format("{0}-{1}", st, fd);
    }
    private void btnPrint_Click(object sender, EventArgs e)
    {
      
      frmRaporDialog frm = new frmRaporDialog(true, true, true, false);
      frm.ShowDialog();
      ReportTo? dest = frm.GetReportDestination();
      if (dest.HasValue) {
          try {
              if (dest != ReportTo.CrytalReport) {
                  var report = new Report(ListToDataTable().ToReportSource());
                  // Customize the Text Fields
                 
                  report.TextFields.Title ="Banka Hareket Raporu";
                  report.TextFields.Header = string.Format(@"
            Rapor Tarihi  :{0}
            HesapNo       :{1}
            BankaAdı      :{2}
            HesapSahibi   :{3}
            ŞubeAdı       :{4}
            ParaBirimi    :{5}           
            Tarih Aralığı :{6} 
            ", DateTime.Now,txtHesapNo.Text,txtBankaAdi.Text,txtHesapSahip.Text,txtSubeAdi.Text
             ,txtParaBirimi.Text,GetTarihAraligi());
                  report.DataFields["Tarih"].DataFormatString = "{0:d}";                 
                  report.DataFields["Tutar"].DataFormatString = "{0:F2}";
                  report.DataFields["Tutar"].ShowTotals = true;
                  string fileName = "bankaRaporu";
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
                  //frmBankaHarReport frm2 = new frmBankaHarReport(hareketList);
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
