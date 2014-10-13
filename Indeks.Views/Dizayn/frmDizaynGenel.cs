using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using Indeks.Data.BusinessObjects;
using Indeks.Data.ManagerObjects;
using System.Management;
using System.Threading;
namespace Indeks.Views
{
  public partial class frmDizaynGenel : Form
  {
    int _dizaynNo;
    IManagerFactory mng;
    IDizaynGenelManager mngDizaynGenel;
    DizaynGenel _dizGenel=null;
    Thread th;
    public frmDizaynGenel(int dizaynNo)
    {
      InitializeComponent();
      mng = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
      mngDizaynGenel = mng.GetDizaynGenelManager();
      _dizaynNo = dizaynNo;
     
    
   
      frmLogin.CheckForIllegalCrossThreadCalls = false;
      ThreadStart ths = new ThreadStart(LoadYaziciListesi);
      th = new Thread(ths);
      th.Start();
      SetDatalari();
      //LoadYaziciListesi();
    }
    void LoadYaziciListesi()
    {
      try
      {
        labLoading.Text = "Yazıcı Listesi yükleniyor,lütfen bekleyin.";
        btnIleri.Enabled = false;
        using (ManagementClass printerClass = new ManagementClass("win32_printer"))
        {
          ManagementObjectCollection printers = printerClass.GetInstances();
          //bool first = true;
          foreach (ManagementObject printer in printers)
          {          
            cmbYaziciListe.Items.Add(printer["Name"]);
            //if (first)
            //{
            //  cmbYaziciListe.Text = printer["Name"].ToStringOrEmpty();
            //  first = false;
            //}
            //if ((bool)printer["Shared"] == true)
            //  Console.WriteLine("------> Shared as: {0}", printer["ShareName"]);
          }
        }
        btnIleri.Enabled = true;
        labLoading.Visible = false;
        pbLoading.Visible = false;
      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      }
    }
    void SetDatalari()
    {
      try
      {
        _dizGenel = mngDizaynGenel.GetByDizaynNo(_dizaynNo);
        if (_dizGenel != null)
        {
          txtBasimAdet.Text = _dizGenel.BasimAdedi.ToString();
          txtFontAdi.Text = _dizGenel.FontAdi;
          txtFontBuyukluk.Text = _dizGenel.FontBuyukluk.ToString();
          txtKalBasSat.Text = _dizGenel.KalBasSat.FromNullableToString();
          txtMaxKalAdet.Text = _dizGenel.MaxKalemAdedi.FromNullableToString();
          txtSatSay.Text = _dizGenel.SatSay.ToString();
          txtSutSay.Text = _dizGenel.SutSay.ToString();
          txtTopBasSat.Text = _dizGenel.TopBasSat.FromNullableToString();
          cmbYaziciListe.Text = _dizGenel.YaziciAdi;
          chbBaskiOnizleme.Checked = _dizGenel.BaskiOnizleme;
          if (_dizGenel.Yataymi)
              rbYatay.Checked = true;
          else
              rbDikey.Checked = true;
          string sonunda= _dizGenel.TopKalSonunda;
          if (sonunda == "B")
            rbBos.Checked = true;
          else if (sonunda == "E")
            rbEvet.Checked = true;
          else
            rbHayir.Checked = true;
        }
      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      }
    }
    private void btnFontDialog_Click(object sender, EventArgs e)
    {
      DialogResult dr = fontDialog1.ShowDialog();
      if (dr == DialogResult.OK)
      {
        txtFontAdi.Text = fontDialog1.Font.Name;
        txtFontBuyukluk.Text = fontDialog1.Font.Size.ToString();
      }
    }

    private void btnIleri_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(cmbYaziciListe.Text))
      {
        MessageBox.Show("Yazıcı seçmelisiniz");
        cmbYaziciListe.Focus();
        return;
      }
      try
      {
        if (_dizGenel == null)
          _dizGenel = new DizaynGenel();
        _dizGenel.BasimAdedi = txtBasimAdet.Text.ParseStruct(x => byte.Parse(x));
        _dizGenel.BaskiOnizleme = chbBaskiOnizleme.Checked;
        _dizGenel.Dizayn = new Dizayn { Id = _dizaynNo };
        _dizGenel.FontAdi = txtFontAdi.Text;
        _dizGenel.FontBuyukluk = txtFontBuyukluk.Text.ParseStruct(x=>float.Parse(x));
        _dizGenel.KalBasSat = txtKalBasSat.Text.ParseNullable<byte>(x => byte.Parse(x));
        _dizGenel.MaxKalemAdedi = txtMaxKalAdet.Text.ParseNullable<byte>(x=>byte.Parse(x));
        _dizGenel.SatSay = txtSatSay.Text.ParseStruct(x => byte.Parse(x));
        _dizGenel.SutSay = txtSutSay.Text.ParseStruct(x=>byte.Parse(x));
        _dizGenel.TopBasSat = txtTopBasSat.Text.ParseNullable<byte>(x=>byte.Parse(x));
        if (rbDikey.Checked)
            _dizGenel.Yataymi = false;
        else
            _dizGenel.Yataymi = true;
        string sonunda="";
        if(rbBos.Checked)
          sonunda="B";
        else if(rbEvet.Checked)
          sonunda="E";
        else
          sonunda="H";
        _dizGenel.TopKalSonunda = sonunda;
        _dizGenel.YaziciAdi = cmbYaziciListe.Text;
        mngDizaynGenel.BeginTransaction();
        _dizGenel=mngDizaynGenel.SaveOrUpdate(_dizGenel);
      
        frmDizaynKalem frm = new frmDizaynKalem(_dizGenel.Id);
        frm.Show();
        this.Close();
      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      } finally {
          try {
              mngDizaynGenel.CommitTransaction();
          } catch (Exception exc) {
              MessageBox.Show(exc.Message);
              LogWrite.Write(exc);
          }
      }
    }
  }
}
