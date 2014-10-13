using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Indeks.Data.BusinessObjects;
using Indeks.Data.ManagerObjects;
using Indeks.Data.Base;
namespace Indeks.Views
{
  public partial class frmBankaHareket : BaseForm
  {  
    int? _kasaHarId;
    int? _hareketId = null;
    int? _cariHarId;
    HesapHareketTuru _hareketTuru;
    IManagerFactory mngFac;
    IBankaHesapManager mngBanka;
    IHesapHareketManager mngHesap;
    IKasaManager mngKasa;
    IKasaHarManager mngKasaHar;
    ICariManager mngCari;
    ICariHareketManager mngCariHar;
    public frmBankaHareket(HesapHareketTuru hareketTuru)
    {
      InitializeComponent();
      mngFac = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
      mngBanka = mngFac.GetBankaHesapManager();
      mngHesap = mngFac.GetHesapHareketManager();
      mngKasa = mngFac.GetKasaManager();
      mngKasaHar = mngFac.GetKasaHarManager();
      mngCari = mngFac.GetCariManager();
      mngCariHar = mngFac.GetCariHareketManager();
      _hareketTuru = hareketTuru;

      txtCariKodu.DataSource = () =>
      {
        try
        {
          return mngCari.GetCariKodsBySubeKodu(UserInfo.Sube.Id, txtCariKodu.Text).ToStringList(15,txtCariKodu.Ayirac);
        }
        catch (Exception exc)
        {
          MessageBox.Show(exc.Message);
          LogWrite.Write(exc);
        }
        return null;
      };
      txtHesapNo.DataSource=()=>
      {
        try
        {
          return mngBanka.GetBankaHesapNoBySubeKodu(UserInfo.Sube.Id,txtHesapNo.Text);
        }
        catch(Exception exc)
        {
          LogWrite.Write(exc);
          MessageBox.Show(exc.Message);
        }
        return null;
      };
      //LoadGrid();
      SetLocation();
    }
    void SetLocation()
    {
      if (_hareketTuru == HesapHareketTuru.ParaCekme || _hareketTuru == HesapHareketTuru.ParaYatirma)
      {
        clCariKodu.Visible = false;
        labCariKasaKodu.Text = "KasaKodu";
        txtCariKodu.Visible = false;
        btnCariRehber.Visible = false;
        if (_hareketTuru == HesapHareketTuru.ParaCekme)
          this.Text = "Banka para çekme";
        else
          this.Text = "Banka para yatırma";
        LoadKasa();
      }
      else
      {
        clKasaKod.Visible = false;
        labCariKasaKodu.Text = "CariKodu";
        txtCariKodu.Location = new Point(cmbKasaKodu.Location.X,cmbKasaKodu.Location.Y);
        txtCariKodu.Visible = true;
        cmbKasaKodu.Visible = false;
        btnCariRehber.Location = new Point(txtCariKodu.Location.X+txtCariKodu.Size.Width + 3, txtCariKodu.Location.Y);
        btnCariRehber.Visible = true;
        if (_hareketTuru == HesapHareketTuru.GelenHavale)
          this.Text = "Gelen Havale";
        else
          this.Text = "Göderilen Havale";
      }
    }
    void LoadKasa()
    {
      try
      {
        bool first = true;
        List<Kasa> kasalar = mngKasa.GetKasaBySubeKodu(UserInfo.Sube.Id);
        foreach (Kasa kas in kasalar)
        {
          cmbKasaKodu.Items.Add(kas.Id);
          if (first)
          {
            cmbKasaKodu.Text = kas.Id;
            first = false;
          }
        }
      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      }
    }
    private void btnRehber_Click(object sender, EventArgs e)
    {
      frmBankaHesapRehber frm = new frmBankaHesapRehber();
      frm.Owner = this;
      frm.Show();
      txtHesapNo.Focus();
      txtHesapNo.SelectionStart = txtHesapNo.Text.Length;
    }
    void LoadGrid()
    {
      try
      {
        IList<HesapHareket> liste = mngHesap.GetHareketTuruAndSubeKodu(UserInfo.Sube.Id,_hareketTuru);
        //listView1.Items.Clear();
        dataGridView1.DataSource = null;
        dataGridView1.Rows.Clear();
        foreach (HesapHareket hh in liste)
        {
  
          List<string> listeRow = new List<string>();
          listeRow.Add(hh.BankaHesap.ProperyToStringOrEmpty(x=>x.HesapNo));
          listeRow.Add(hh.Tarih.ToShortDateString());
          listeRow.Add(hh.DekontNo);
          listeRow.Add(hh.Tutar.FromNumberToString(2));
          listeRow.Add(hh.Aciklama);
          listeRow.Add(hh.Id.ToString());          
          dataGridView1.Rows.Add(listeRow.ToArray());

        }
      }
      catch (Exception exc)
      {
        LogWrite.Write(exc);
        MessageBox.Show(exc.Message);
      }
    }
  
    void Kaydet()
    {
      try
      {
        if (_hareketId == null)
        {
          BeginTransaction();
          KasaHareket kasahar=null;
          CariHareket cariHar = null;
          if (_hareketTuru == HesapHareketTuru.ParaCekme || _hareketTuru == HesapHareketTuru.ParaYatirma)
          {
            kasahar = new KasaHareket();
            kasahar.GelirGider = _hareketTuru == HesapHareketTuru.ParaYatirma ? "C" : "G";
            kasahar.Kasa = new Kasa { Id = cmbKasaKodu.Text };
            kasahar.Sube = UserInfo.Sube;
            kasahar.Tarih = dateTarih.Value.JustDate();
            //kasahar.Tip =_hareketTuru == HesapHareketTuru.ParaCekme? KasaHareket.DetermineTip(KasaHarTip.BankaParaCekme):
            //                                                        KasaHareket.DetermineTip(KasaHarTip.BankaParaYatirma);
            kasahar.Tip = KasaHareket.DetermineTip(KasaHarTip.Banka);
            kasahar.Tutar = txtTutar.Text.ParseStruct(x => double.Parse(x));
            kasahar = mngKasaHar.Save(kasahar);
          }            
          else
          {
            cariHar = new CariHareket();
            if (_hareketTuru == HesapHareketTuru.GelenHavale)
            {
              cariHar.Alacak = txtTutar.Text.ParseStruct(x => double.Parse(x));
              cariHar.HareketTuru = CariHarTuru.GelenHavale;
            }
            else
            {
              cariHar.Borc = txtTutar.Text.ParseStruct(x => double.Parse(x));
              cariHar.HareketTuru = CariHarTuru.GonderilenHavale;
            }
            cariHar.Cari = new Cari { Id = txtCariKodu.Text };
         
            cariHar.Sube = UserInfo.Sube;
            cariHar.Tarih = dateTarih.Value.JustDate();
            cariHar = mngCariHar.Save(cariHar);
          }
          
          HesapHareket har = new HesapHareket();         
       
          har.Aciklama = txtAciklama.Text;
          har.BankaHesap = mngBanka.GetByHesapNo(UserInfo.Sube.Id, txtHesapNo.Text);
          har.DekontNo = txtDekontNo.Text;
          har.HareketTuru =_hareketTuru;
          har.Sube = UserInfo.Sube;
          har.Tarih = dateTarih.Value.JustDate();
          har.Tutar = txtTutar.Text.ParseStruct(x => double.Parse(x));
          if (_hareketTuru == HesapHareketTuru.ParaCekme || _hareketTuru == HesapHareketTuru.ParaYatirma)
          {
            har.KasaHarId = kasahar.Id;
            har.KasaKod = cmbKasaKodu.Text;
          }
          else
          {
            har.CariHarId = cariHar.Id;
            har.CariKod = txtCariKodu.Text;
          }
          har= mngHesap.Save(har);
          
          List<string> listeRow = new List<string>();
          listeRow.Add(har.BankaHesap.ProperyToStringOrEmpty(x=>x.HesapNo));
          listeRow.Add(har.Tarih.ToShortDateString());
          listeRow.Add(har.DekontNo);
          listeRow.Add(har.Tutar.ToString());
          listeRow.Add(har.KasaKod);
          listeRow.Add(har.CariKod);
          listeRow.Add(har.Aciklama);
          listeRow.Add(har.Id.ToString());
          if (cariHar != null)
            listeRow.Add(har.CariHarId.Value.ToString());
          else
            listeRow.Add("");
          if (kasahar != null)
            listeRow.Add(har.KasaHarId.Value.ToString());
          else
            listeRow.Add("");
          dataGridView1.Rows.Add(listeRow.ToArray());
          YeniKayit();
        }
        else
        {
          BeginTransaction();
          KasaHareket kasahar = null;
          CariHareket cariHar = null;
          if (_hareketTuru == HesapHareketTuru.ParaCekme || _hareketTuru == HesapHareketTuru.ParaYatirma)
          {
            kasahar = mngKasaHar.GetById(_kasaHarId.Value, false);
            kasahar.GelirGider = _hareketTuru == HesapHareketTuru.ParaYatirma ? "G" : "C";
            kasahar.Kasa = new Kasa { Id = cmbKasaKodu.Text };
            kasahar.Sube = UserInfo.Sube;
            kasahar.Tarih = dateTarih.Value.JustDate();
            //kasahar.Tip = _hareketTuru == HesapHareketTuru.ParaCekme ? KasaHareket.DetermineTip(KasaHarTip.BankaParaCekme) :
            //                                                       KasaHareket.DetermineTip(KasaHarTip.BankaParaYatirma)
            kasahar.Tip = KasaHareket.DetermineTip(KasaHarTip.Banka);
            kasahar.Tutar = txtTutar.Text.ParseStruct(x => double.Parse(x));
            kasahar = mngKasaHar.SaveOrUpdate(kasahar);
          }
          else
          {
            cariHar = mngCariHar.GetById(_cariHarId.Value,false);
            if (_hareketTuru == HesapHareketTuru.GelenHavale)
            {
              cariHar.Alacak = txtTutar.Text.ParseStruct(x => double.Parse(x));
              cariHar.HareketTuru = CariHarTuru.GelenHavale;
            }
            else
            {
              cariHar.Borc = txtTutar.Text.ParseStruct(x => double.Parse(x));
              cariHar.HareketTuru = CariHarTuru.GonderilenHavale;
            }
            cariHar.Cari = new Cari { Id = txtCariKodu.Text };
          
            cariHar.Sube = UserInfo.Sube;
            cariHar.Tarih = dateTarih.Value.JustDate();
            cariHar = mngCariHar.SaveOrUpdate(cariHar);
          }
          HesapHareket har = mngHesap.GetById(_hareketId.Value,false);          
          har.Aciklama = txtAciklama.Text;
          har.BankaHesap = mngBanka.GetByHesapNo(UserInfo.Sube.Id, txtHesapNo.Text);
          har.DekontNo = txtDekontNo.Text;
          har.HareketTuru = _hareketTuru;
          har.Sube = UserInfo.Sube;
          har.Tarih = dateTarih.Value.JustDate();
          har.Tutar = txtTutar.Text.ParseStruct(x => double.Parse(x));
          if(kasahar!=null)
            har.KasaHarId = kasahar.Id;
          if (cariHar != null)
            har.CariHarId = cariHar.Id;
          har.KasaKod = cmbKasaKodu.Text;
          har.CariKod = txtCariKodu.Text;
          har = mngHesap.SaveOrUpdate(har);
          DataGridViewRow dr = dataGridView1.SelectedRows[0];
          dr.Cells["clHesapNo"].Value = txtHesapNo.Text;
          dr.Cells["clTarih"].Value = dateTarih.Text;
          dr.Cells["clDekontNo"].Value = txtDekontNo.Text;
          dr.Cells["clTutar"].Value = txtTutar.Text;
          dr.Cells["clAciklama"].Value = txtAciklama.Text;
          dr.Cells["clKasaKod"].Value = cmbKasaKodu.Text;
          dr.Cells["clCariKodu"].Value = txtCariKodu.Text;
          YeniKayit();
        }
      }
      catch (Exception exc)
      {
        LogWrite.Write(exc);
        MessageBox.Show(exc.Message);
      }
      finally
      {
        try
        {
          CommitTransaction();
        }
        catch (Exception exc)
        {
          MessageBox.Show(exc.Message);
          LogWrite.Write(exc);
        }
      }
    }

    private void tsbtnKaydet_Click(object sender, EventArgs e)
    {
      Kaydet();
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      try
      {
          if (dataGridView1.CurrentRow != null) {
              DataGridViewRow dr = dataGridView1.CurrentRow;
              _hareketId = null;
              CleareForm.ClearThisConrol(this).BeginClear();
              txtHesapNo.Text = dr.Cells["clHesapNo"].Value.ToStringOrEmpty();
              dateTarih.Text = dr.Cells["clTarih"].Value.ToStringOrEmpty();
              txtDekontNo.Text = dr.Cells["clDekontNo"].Value.ToStringOrEmpty();
              txtTutar.Text = dr.Cells["clTutar"].Value.ToStringOrEmpty();
              txtAciklama.Text = dr.Cells["clAciklama"].Value.ToStringOrEmpty();
              _hareketId = dr.Cells["clId"].Value.ToString().ParseNullable<int>(x => int.Parse(x));
              _kasaHarId = dr.Cells["clKasaHarId"].Value.ToString().ParseNullable<int>(x => int.Parse(x));
              _cariHarId = dr.Cells[clCariHarId.Name].Value.ToString().ParseNullable<int>(x => int.Parse(x));
              cmbKasaKodu.Text = dr.Cells["clKasaKod"].Value.ToStringOrEmpty();
              txtCariKodu.Text = dr.Cells["clCariKodu"].Value.ToStringOrEmpty();
              txtHesapNo.Focus();
          }
      }
      catch (Exception exc)
      {
        LogWrite.Write(exc);
        MessageBox.Show(exc.Message);
      }
    }

    private void frmBankaHareket_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter) {
            SendKeys.Send("{TAB}");
        } else if (Keys.F5 == e.KeyCode) {
            Kaydet();
        } else if (Keys.F7 == e.KeyCode)
            KayitSil();
        else if (Keys.F3 == e.KeyCode)
            YeniKayit();
        else if (Keys.Escape == e.KeyCode)
            this.Close();

    }
    void KayitSil()
    {
         DialogResult re = MessageBox.Show("Kayıt Silinsin mi?", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
         if (re == DialogResult.Yes && _hareketId != null) {
             try {
                 BeginTransaction();

                 if (_hareketTuru == HesapHareketTuru.ParaCekme || _hareketTuru == HesapHareketTuru.ParaYatirma) {
                     KasaHareket kasahar = mngKasaHar.GetById(_kasaHarId.Value, false);
                     mngKasaHar.Delete(kasahar);
                 } else {
                     CariHareket ch = mngCariHar.GetById(_cariHarId.Value, true);
                     mngCariHar.Delete(ch);
                 }
                 HesapHareket hh = mngHesap.GetById(_hareketId.Value, true);
                 mngHesap.Delete(hh);
                 DataGridViewRow dr = dataGridView1.SelectedRows[0];
                 dataGridView1.Rows.Remove(dr); ;
                 YeniKayit();
             } catch (Exception exc) {
                 LogWrite.Write(exc);
                 MessageBox.Show(exc.Message);
             } finally {
                 try {
                     CommitTransaction();
                 } catch (Exception exc) {
                     LogWrite.Write(exc);
                     MessageBox.Show(exc.Message);
                 }
             }

         }
    }
    void YeniKayit()
    {
      _kasaHarId = null;
      _hareketId = null;
      _cariHarId = null;
      CleareForm.ClearThisConrol(this).BeginClear();
      txtHesapNo.Focus();
    }

    private void tsbtnSil_Click(object sender, EventArgs e)
    {
      KayitSil();
    }

    private void tsbtnYeni_Click(object sender, EventArgs e)
    {
      YeniKayit();
    }

    private void btnCariRehber_Click(object sender, EventArgs e)
    {
      frmCariRehber frm = new frmCariRehber();
      frm.Owner = this;
      frm.ShowDialog();
    }

    private void tsbtnKapat_Click(object sender, EventArgs e) {
        this.Close();
    }
  }
}
