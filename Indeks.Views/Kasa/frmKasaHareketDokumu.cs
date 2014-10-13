using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Indeks.Data.BusinessObjects;
using Indeks.Data.ManagerObjects;
using Indeks.Data.Helper;
using Indeks.Data.Report;
using Indeks.Views.ReportHelp;
using Doddle.Reporting;
using Doddle.Reporting.Writers;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Indeks.Views
{
  public partial class frmKasaHareketDokumu : Form
  {
    IManagerFactory mng;
    IKasaManager mngKasa;
    IKasaHarManager mngkasaHar;
    frmAnaSayfa mainForm;
    DataTable _source;
    public frmKasaHareketDokumu(frmAnaSayfa mainForm)
    {
      InitializeComponent();
      this.mainForm = mainForm;
      mng = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
      mngKasa = mng.GetKasaManager();
      mngkasaHar = mng.GetKasaHarManager();
      LoadKasa();
    }
    void LoadKasa()
    {
      try
      {
        List<Kasa> kasalar = mngKasa.GetKasaBySubeKodu(UserInfo.Sube.Id);
        bool first = true;
        foreach (Kasa kas in kasalar)
        {
          cmboxKasalar.Items.Add(kas.Id);
          if (first)
          {
            first = false;
            cmboxKasalar.Text = kas.Id;
          }
        }
      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      }
    }

    private void btnRapor_Click(object sender, EventArgs e)
    {
      //frmKasaHareketRapor frm =new frmKasaHareketRapor();
      //frm.KasaKdu = cmboxKasalar.Text;
      //frm.startDate = dtpStart.Value;
      //frm.endDate = dtpFinish.Value;
      //frm.LoadRapor();
      //mainForm.ShowForm(frm,true);
      //this.Close();
        LoadGrid();
        btnPrint.Visible = true;
    }

    private void frmKasaKriter_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        SendKeys.Send("{TAB}");
      }
    }
    void LoadGrid() {
        try {
            _source = mngkasaHar.KasaHareketDokumu(UserInfo.Sube.Id,cmboxKasalar.Text,dtpStart.Value.JustDate(), dtpFinish.Value.JustDate());
            _source.Replace("Gelir/Gider", "G", "Gelir");
            _source.Replace("Gelir/Gider", "C", "Gider");
            _source.Replace("HareketTipi", "B", "Banka");
            _source.Replace("HareketTipi", "C", "Cari");
            _source.Replace("HareketTipi", "F", "Fatura");
            _source.Replace("HareketTipi", "E", "Çek");
            _source.Replace("HareketTipi", "S", "Senet");
            _source.Replace("HareketTipi", "O", "Özel");
            dataGridView1.DataSource = _source;
            if (_source != null && _source.Rows.Count > 0) {
                dataGridView1.Columns["Tutar"].DefaultCellStyle.Format = "F2";
                tslabToplamTutar.Text = double.Parse(_source.Compute("sum(Tutar)", "").ToString()).ToString("F2"); 
            }
        } catch (Exception exc) {
            MessageBox.Show(exc.Message);
            LogWrite.Write(exc);
        }
    }
    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
        //if (tabControl1.SelectedTab.Name == "tabPageRapor")
        //    LoadGrid();
    }
    string GetTarihAraligi() {
      
        string st = dtpStart.Value.ToString("d");
        string fd = dtpFinish.Value.ToString("d");
        return string.Format("{0}-{1}", st, fd);
        
    }
    private void btnPrint_Click(object sender, EventArgs e) {
        frmRaporDialog frm = new frmRaporDialog(true, true, true, false);
        frm.ShowDialog();
        ReportTo? dest = frm.GetReportDestination();
        if (dest.HasValue) {
            try {
                if (dest.Value != ReportTo.CrytalReport) {


                    // Create the report and turn our query into a ReportSource
                    var report = new Report(_source.ToReportSource());
                    // Customize the Text Fields

                    report.TextFields.Title = "Kasa Hareket Dökümü";
                    report.TextFields.Header = string.Format(@"
            Rapor Tarihi:{0}
            Tarih Aralığı:{1}
            Kasa:{2} 
            ", DateTime.Now,GetTarihAraligi(), _source.Rows[0]["KasaKod"].ToStringOrEmpty());
                    // Render hints allow you to pass additional hints to the reports as they are being rendered
                    report.RenderHints.BooleanCheckboxes = true;
                    // Customize the data fields
                    report.DataFields["Tutar"].ShowTotals = true;
                    report.DataFields["KasaKod"].Hidden = true;
                    //report.DataFields["Tutar"].DataFormatString = "{0:c}";
                    report.DataFields["Tarih"].DataFormatString = "{0:d}";
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

                }
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }

        }
    }

    private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

    }

    private void cariListesiToolStripMenuItem_Click(object sender, EventArgs e) {
        if (dataGridView1.DataSource != null) {
            if (dataGridView1.CurrentRow.Cells[3].Value != null
                && !string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[3].Value.ToString())) {
                frmStokListe frm = new frmStokListe(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                frm.ShowDialog();
            }
        }
    }

  
  }
}
