using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
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
namespace Indeks.Views
{
  public partial class frmStokAlisSatisRaporKriter : Form
  {
    IManagerFactory mngFac;
    IStokManager mngStok;
    IStokHareketManager mngStokHar;
    DataTable _source;
    StokAlisSatisRapor _alisSatis;
    string _alisGirisKod;
  
    public frmStokAlisSatisRaporKriter(StokAlisSatisRapor alisSatis)
    {
      InitializeComponent();
      _alisSatis = alisSatis;
      _alisGirisKod = alisSatis == StokAlisSatisRapor.AlisRapor ? "G" : "C";
      tabPage2.Text=this.Text = alisSatis == StokAlisSatisRapor.AlisRapor ? "MalAlışRaporu" : "MalSatışRaporu";
      mngFac = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
      mngStok = mngFac.GetStokManager();
      mngStokHar = mngFac.GetStokHareketManager();
      txtStokKodu.DataSource = () =>
      {
        try
        {
          return mngStok.StokKods(txtStokKodu.Text, UserInfo.Sube).ToStringList(35,txtStokKodu.Ayirac);
        }
        catch (Exception exc)
        {
          MessageBox.Show(exc.Message);
          LogWrite.Write(exc);
        }
        return null;
      };
    }

   
    //frmStokAlisSatisRaporCrytalRapor frm =new frmStokAlisSatisRaporCrytalRapor();
    //frm.GirisCikisKod = rbAlis.Checked ? "G" : "C";
    //frm.StartDate = dtStart.Value;
    //frm.FinishDate = dtFinish.Value;
    //frm.StokKodu = txtStokKodu.Text;
    //frm.LoadRapor();
    //mainForm.ShowForm(frm,true);
    //this.Close();
   
    private void frmStokAlisSatisRaporKriter_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        SendKeys.Send("{TAB}");
      }
    }

    private void rbButunStoklar_CheckedChanged(object sender, EventArgs e) {
        if (sender == rbButunStoklar) {
            grbStokKodu.Enabled = false;
            txtStokKodu.Text = String.Empty;
        } else {
            grbStokKodu.Enabled = true;
        }
    }

    private void btnRapor_Click(object sender, EventArgs e) {
        LoadGrid();
        btnPrint.Visible = true;
    }
    void LoadGrid() {
        try {
           
            _source = mngStokHar.StokAlisSatisRapor(UserInfo.Sube.Id, txtStokKodu.Text, dtpStart.Value.JustDate(),
            dtpFinish.Value.JustDate(),_alisGirisKod);         
            dataGridView1.DataSource = _source;
            if (_source != null && _source.Rows.Count > 0) {
                tslabToplamMiktar.Text = ToplamMiktar().ToString("F2");
                tslabToplamTutar.Text = ToplamTutar().ToString("F2");
            }
        } catch (Exception exc) {
            MessageBox.Show(exc.Message);
            LogWrite.Write(exc);
        }
    }
    string GetTarihAraligi() {
        string st = dtpStart.Value.ToString("d");
        string fd = dtpFinish.Value.ToString("d");
        return string.Format("{0}-{1}", st, fd);
    }
    string SecilenStok() {
        if (rbButunStoklar.Checked)
            return "Bütün Stoklar";
        else {
            Stok stok = mngStok.GetById(txtStokKodu.Text,false);
            if (stok != null)
                return string.Format("StokKodu={0},StokAdı={1}", stok.Id, stok.StokAdi);
        }
        string st = dtpStart.Value.ToString("d");
        string fd = dtpFinish.Value.ToString("d");
        return string.Format("{0}-{1}", st, fd);
    }
    double ToplamMiktar() {
        if (_source == null)
            return 0;
        return double.Parse(_source.Compute("sum(Miktar)", "").ToString());
    }
    double ToplamTutar() {
        if (_source == null)
            return 0;
        return double.Parse(_source.Compute("sum(Tutar)", "").ToString());
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
            Stok:{2}
            Toplam Adet:{2}
            Toplam Tutar:{3}
            Rapor Tarih Aralığı:{4} 
            ", DateTime.Now,SecilenStok(), _source.Compute("sum(Miktar)", ""), _source.Compute("sum(Tutar)", ""),GetTarihAraligi());
                    report.DataFields["Tarih"].DataFormatString = "{0:d}";
                    report.DataFields["BirimFiyat"].DataFormatString = "{0:F2}";
                    report.DataFields["Tutar"].DataFormatString = "{0:F2}";
                    string fileName =StokAlisSatisRapor.AlisRapor == _alisSatis ? "malAlisRapor" : "malSatisRapor"; 
                    IReportWriter writer = new ExcelReportWriter();
                    if (dest.Value == ReportTo.Excel) {
                        fileName = fileName + ".xls";
                    }
                    else if (dest.Value == ReportTo.Html) {
                        writer = new HtmlReportWriter();
                        fileName = fileName+".html";
                    } else if (dest.Value == ReportTo.Csv) {
                        writer = new DelimitedTextReportWriter();
                        fileName = fileName+".txt";
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

    private void btnStokRehber_Click(object sender, EventArgs e) {
        frmStokSearch frm = new frmStokSearch();
        frm.Owner = this;
        frm.ShowDialog();
    }
  }
}
