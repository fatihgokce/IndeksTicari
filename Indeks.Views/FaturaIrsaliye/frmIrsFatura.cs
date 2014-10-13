using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using Indeks.Data.BusinessObjects;
using Indeks.Data.ManagerObjects;
using Indeks.Data.Report;
namespace Indeks.Views
{
  public partial class frmIrsFatura : BaseForm
  {

    IManagerFactory mng;
    IFatIrsUstManager mngFatUst;
    ICariManager mngCari;
    IStokHareketManager mngSth;
    ICariHareketManager mngCariHrk;
    IKasaHarManager mngKasaHar;
    IKasaManager mngKasa;
    FatIrsUst _fatIrsUst;
    FTIRSIP _ftirsip;
    string _irsNo;
    public frmIrsFatura(string IrsNo,FTIRSIP ftirsip)
    {
      _irsNo = IrsNo;
      _ftirsip = ftirsip;
      mng = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
      mngFatUst = mng.GetFatirsUstManager();
      mngCari = mng.GetCariManager();
      mngSth = mng.GetStokHareketManager();
      mngKasa = mng.GetKasaManager();
      mngKasaHar = mng.GetKasaHarManager();
      mngCariHrk = mng.GetCariHareketManager();
      InitializeComponent();
      try
      {
        _fatIrsUst = mngFatUst.GetByBelgeNoBelgeTipAndSubeKodu(_irsNo, _ftirsip, UserInfo.Sube.Id);
        if (_fatIrsUst.FatTipi == FatTipi.KapaliFat || _fatIrsUst.FatTipi == FatTipi.MuhtelifFat)
        {
          LoadKasa();
          cmboxKasalar.Enabled = true;
        }
        txtFatNo.Text = mngFatUst.GetLastArtiOneFatIrsNoBySubeKoduAndFtirsip(UserInfo.Sube.Id,DetermineFtirsip(ftirsip));
      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      }
    }
    void LoadKasa()
    {
      try
      {
        List<Kasa> kasalar = mngKasa.GetKasaBySubeKodu(UserInfo.Sube.Id);
        foreach (Kasa kas in kasalar)
          cmboxKasalar.Items.Add(kas.Id);
      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      }
    }
    FTIRSIP DetermineFtirsip(FTIRSIP ftirsip)
    {
      if (FTIRSIP.AlisIrs == ftirsip)
        return FTIRSIP.AlisFat;
      else
        return FTIRSIP.SatisFat;
    }
    private void btnKaydet_Click(object sender, EventArgs e)
    {
      try {
        mngSth.UpdateStokHarByFisNoAndFtirsip(_fatIrsUst.FatirsNo, _ftirsip, DetermineFtirsip(_ftirsip), txtFatNo.Text);
        BeginTransaction();         
      

        if (_fatIrsUst.FatTipi==FatTipi.MuhtelifFat || _fatIrsUst.FatTipi==FatTipi.KapaliFat)
        {
       
               
          KasaHareket kasaHar =new KasaHareket();
         
          if (_fatIrsUst.Ftirsip == FTIRSIP.AlisIrs)
          {
            _fatIrsUst.Ftirsip = FTIRSIP.AlisFat;
            kasaHar.GelirGider = "C";
          }
          else
          {
            _fatIrsUst.Ftirsip = FTIRSIP.SatisFat;
            kasaHar.GelirGider = "G";
          }
          kasaHar.FisNo = txtFatNo.Text;
          kasaHar.Tip =KasaHareket.DetermineTip(KasaHarTip.Fatura);
          //kasaHar.Tip = FTIRSIP.AlisFat == _fatIrsUst.Ftirsip ? KasaHareket.DetermineTip(KasaHarTip.MalAlis)
          //      : KasaHareket.DetermineTip(KasaHarTip.MalSatis);  
          kasaHar.Kasa = mngKasa.GetById(cmboxKasalar.Text, false);
          kasaHar.KdvTutar =_fatIrsUst.KdvTutar.Value;
          kasaHar.Tutar =_fatIrsUst.GenelToplam.Value;
          kasaHar.Tarih = dateTarih.Value.JustDate();
          kasaHar.Sube = UserInfo.Sube;
          mngKasaHar.Save(kasaHar);           
          _fatIrsUst.FatirsNo = txtFatNo.Text;
          _fatIrsUst.Tarih = dateTarih.Value.JustDate();           
                
          _fatIrsUst.KasaKodu = cmboxKasalar.Text;
          _fatIrsUst.Kapatilmis = "S";    
          mngFatUst.SaveOrUpdate(_fatIrsUst);
           
        }
        else // açık,iade
        {
        
                  
          CariHareket cahar =new CariHareket();
          if (_fatIrsUst.Ftirsip == FTIRSIP.AlisIrs)
          {
            cahar.Alacak = _fatIrsUst.GenelToplam.Value;
            cahar.HareketTuru = CariHarTuru.AlinanMal;
          }
          else
          {
            cahar.Borc = _fatIrsUst.GenelToplam.Value;
            cahar.HareketTuru = CariHarTuru.SatilanMal;
          }
          cahar.Cari = mngCari.GetById(_fatIrsUst.CariKodu, false);
          cahar.FisNo = txtFatNo.Text;
          cahar.Tarih =dateTarih.Value.JustDate();
          //cahar.HareketTuru = "B";//Fatura
          cahar.Sube = UserInfo.Sube;
          if (_fatIrsUst.FatTipi == FatTipi.AcikFat)
            cahar.VadeTarih = _fatIrsUst.VadeTarih;
          mngCariHrk.Save(cahar); 
       
          _fatIrsUst.FatirsNo = txtFatNo.Text;
          _fatIrsUst.Ftirsip = DetermineFtirsip(_ftirsip);         
          _fatIrsUst.Tarih = dateTarih.Value;
          _fatIrsUst.Kapatilmis = "S";
          mngFatUst.SaveOrUpdate(_fatIrsUst);
          
                

        }
        this.Close();
       
      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      } finally {
          try {
              CommitTransaction();
          } catch (Exception exc) {
              MessageBox.Show(exc.Message);
              LogWrite.Write(exc);
          }
      }
    }

    private void frmIrsFatura_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        SendKeys.Send("{TAB}");
      }
    }
  }
}
