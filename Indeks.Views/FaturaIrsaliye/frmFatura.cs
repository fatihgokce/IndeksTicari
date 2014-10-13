using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Indeks.Data.BusinessObjects;
using Indeks.Data.ManagerObjects;
using Indeks.Data.Helper;
using Indeks.Data.Report;
using Indeks.Print;
namespace Indeks.Views
{
  public partial class frmFatura :BaseFatSip
  {
    
    SiparisUst _sipUst=null;
    FatNoTip _fatNoTip;
    //IManagerFactory mng;
    //IFaturaNoManager mngFatNo;
    IFatIrsUstManager mngFatUst;
    //IStokManager mngStk;
    //ICariManager mngCari;
    //IStokHareketManager mngSth;
    ICariHareketManager mngCariHrk;
    IKasaHarManager mngKasaHar;
    IKasaManager mngKasa;
    IDizaynManager mngDizayn;
    ISiparisKalemManager mngSipKalem;
    ISiparisUstManager mngSipUst;
    IBankaHesapManager mngBanka;
    IHesapHareketManager mngHesapHar;
    AyarlarManager _mngAyar;
    int? _selectedStokHarId=null;
    string _selectedStokKodu = string.Empty;
    
    //Stok _currentStok = null;
    FatIrsUst _currentFatUst = null;
    //HesaplaGenelToplam genelToplamlar;
    //IList<StokHarRpr> listeStok;
    
    //public frmFatura()
    //{
    //  InitializeComponent();
    //}
    public frmFatura(FTIRSIP ftirsip, FatNoTip fatNoTip):base()
    {
      InitializeComponent();
       
      this._ftirsip = ftirsip;
      this._fatNoTip = fatNoTip;
      SetDatalari();
    }
    public frmFatura(FTIRSIP ftirsip, FatNoTip fatNoTip,string fisNo)
        : base() {
        InitializeComponent();

        this._ftirsip = ftirsip;
        this._fatNoTip = fatNoTip;             
        SetDatalari();
        txtFatNo.Text = fisNo;  
        FaturaDatalariYukle();
    }
    public frmFatura(FTIRSIP ftirsip,SiparisUst sipUst, FatNoTip fatNoTip,IList<StokHarRpr>stokListe):base()
    {
      InitializeComponent();
     
      this._ftirsip = ftirsip;
      this._fatNoTip = fatNoTip;
      this._sipUst = sipUst;

      SetDatalari();
      dateTarih.Text = sipUst.Tarih.ToString("d");
      cmbFatTipi.Text = "Vadeli";
      txtCari.Text = sipUst.CariKodu;
      chkKdvDahilmi.Checked = sipUst.KdvDahilmi;
      dateVadeTarihi.Value = sipUst.VadeTarih.Value;
      this.listeStok = stokListe;
      mngSipKalem = mng.GetSiparisKalemManager();
      mngSipUst = mng.GetSiparisUstManager();
      EnableCari(true);
      LoadSthHarToGrid(stokListe);
      TopluStokHareketKaydet(stokListe);

    }
    void TopluStokHareketKaydet(IList<StokHarRpr> liste)
    {
        bool isBegin = false;
        if (liste.Count > 0)
            isBegin = true;
      try
      {
          if(isBegin)
              BeginTransaction();
          string fisNo = txtFatNo.Text.Trim();
          if (string.IsNullOrEmpty(fisNo)) {
              if (FTIRSIP.AlisFat == _ftirsip)
                  fisNo = "af000000000001";
              else if(FTIRSIP.AlisIrs==_ftirsip)
                  fisNo = "ai000000000001";
              else if (FTIRSIP.SatisFat == _ftirsip)
                  fisNo = "sf000000000001";
              else if (FTIRSIP.SatisIrs == _ftirsip)
                  fisNo = "si000000000001";
              txtFatNo.Text = fisNo;
          }
        foreach (StokHarRpr rpr in liste)
        {
          StokHareket har = new StokHareket();
          har.BirimFiyat = rpr.Fiyat;
          har.FisNo = txtFatNo.Text;
          har.FTIRSIP = _ftirsip;
          har.GCMiktar = rpr.Miktar;
          har.HareketBirim = rpr.HareketBirim;
          har.HareketMiktar = rpr.HareketMiktar;
          har.Isk1 = rpr.Isk1; har.Isk2 = rpr.Isk2; har.Isk3 = rpr.Isk3;
          har.Isk4 = rpr.Isk4; har.Isk5 = rpr.Isk5;
          har.Kdv = rpr.KdvOrani;
          har.SipNum = _sipUst.FatirsNo;
          har.StharGckod = _sipUst.Ftirsip == FTIRSIP.MusSip ? "C" : "G";
          har.StharHtur = StokHareket.DetermineHarTur(_fatNoTip);
          har.Stok = new Stok { Id = rpr.StokKodu };
          har.Sube = UserInfo.Sube;
          har.Tarih = _sipUst.Tarih;        
          mngSth.Save(har);
          
        }
      } catch (Exception) {
      } finally {
          try {
              if (isBegin)
                  CommitTransaction();
          } catch (Exception exc) {
              LogWrite.Write(exc);
              MessageBox.Show(exc.Message);
          }
      }
    }

    void SetDatalari()
    {
        if (this._fatNoTip == FatNoTip.Irsaliye) {
            groupBoxFaturaKayit.Text = "İrsaliye Kayıt";
        }
        txtCari.WidthAutoComplete = 200;
        dateTarih.initializeTimePiceker();
        dateSevkIrsaliye.initializeTimePiceker();
       
        //dateSevkIrsaliye.Text = DateTime.Today.ToString("d");
        //dateTarih.Text = DateTime.Today.ToString("d");
      //mng = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
      mngHesapHar = mng.GetHesapHareketManager();
      mngBanka = mng.GetBankaHesapManager();
      mngCariHrk = mng.GetCariHareketManager();
      //mngFatNo = mng.GetFaturaNoManager();
      mngFatUst = mng.GetFatirsUstManager();
      //mngStk = mng.GetStokManager();
      //mngCari = mng.GetCariManager();
      //mngSth = mng.GetStokHareketManager();
      mngKasa = mng.GetKasaManager();
      mngKasaHar = mng.GetKasaHarManager();
      mngDizayn = mng.GetDizaynManager();
      _mngAyar =new AyarlarManager(UserInfo.Sube.Id);
      this.Text = _ftirsip.ToString();
      //txtFatNo.DataSource=()=>(mngFatNo.GetFatNumaraBySubeKoduAndFatNoTip(txtFatNo.Text,UserInfo.Sube.Id,fatNoTip.ToEqualDatabaseValue()));
      txtStokKodu.DataSource = () =>
      {
        try
        {
          return mngStk.StokKods(txtStokKodu.Text, UserInfo.Sube).ToStringList(35,txtStokKodu.Ayirac);
        }
        catch (Exception exc)
        {
          MessageBox.Show(exc.Message);
          LogWrite.Write(exc);
        }
        return null;
      };
      txtCari.DataSource = () =>
      {
        try
        {
          return mngCari.GetCariKodsBySubeKodu(UserInfo.Sube.Id, txtCari.Text, _ftirsip).ToStringList(15,txtCari.Ayirac);
        }
        catch (Exception exc)
        {
          MessageBox.Show(exc.Message);
          LogWrite.Write(exc);
        }
        return null;

      };
      txtFatNo.DataSource = () =>
      {
        try
        {
          return mngFatUst.GetByBelgeTipAndSubeKodu(UserInfo.Sube.Id, _ftirsip, txtFatNo.Text);
        }
        catch (Exception exc)
        {
          MessageBox.Show(exc.Message);
          LogWrite.Write(exc);
        }
        return null;
      };
      EnableCari(true);

      if (_fatNoTip == FatNoTip.Irsaliye)
      {
        labFatNo.Text = "İrsaliye No";
        cbFaturaBas.Text = "İrsaliye Bas";
        btnFatKaydet.Text = "İrsaliye Kaydet(Alt+K)";
        btnFatSil.Text = "İrsaliye Sil(Alt+S)";
        int mesafe = dateSevkIrsaliye.Location.Y - txtFatNo.Location.Y - dateSevkIrsaliye.Height - 3;
        //ViewConrol.HideContols(cmbKasalar).IncerementPosHeight((-1) * cmbKasalar.Height, btnFatKaydet, btnKalemKaydet, btnKalemSil)
        //          .HideContols(chkIrsaliyeli,labIrsNo,txtIrsaliyeNo).IncerementPosHeight((-1)*mesafe,grboxUstBilgi,labFatNo,txtFatNo);
        ViewConrol.HideContols(chkIrsaliyeli, labIrsNo, txtIrsaliyeNo).IncerementPosHeight((-1) * mesafe, grboxUstBilgiler, labFatNo, txtFatNo, btnFatRehber);
        flPanelFatBtns.Controls.Remove(labKasa);
        flPanelFatBtns.Controls.Remove(cmbKasalar);
        string fatTipi = _mngAyar.VarSayilanFaturaTipi;
        if (!string.IsNullOrEmpty(fatTipi))
            cmbFatTipi.Text = fatTipi;
      }
      else if(_fatNoTip==FatNoTip.Fatura)
      {        
        flPanelFatBtns2.Controls.Remove(btnIrsFatu);
        AdjustIrsaliyeTarih(chkIrsaliyeli.Checked);
        LoadKasa();
        string fatTipi = _mngAyar.VarSayilanFaturaTipi;
        if (!string.IsNullOrEmpty(fatTipi))
            cmbFatTipi.Text = fatTipi;
      }
      if (_ftirsip == FTIRSIP.SatisFat || _ftirsip==FTIRSIP.DirektSatis)
      {
        cmbFatTipi.Items.Add("KrediKarti");
      }
       
      //flPanelFatBtns.Controls.Remove(labVadeTarih);
      //flPanelFatBtns.Controls.Remove(dateVadeTarihi);
      //flPanelFatBtns.Controls.Remove(labBanka);
      //flPanelFatBtns.Controls.Remove(txtBankaHesapNo);
      //flPanelFatBtns.Controls.Remove(btnBankaRehber);
      //flPanelFatBtns.Controls.Remove(labKasa);
      //flPanelFatBtns.Controls.Remove(cmbKasalar);
      GetLastArtiFatIrsNo();
      this.Focus();
      txtFatNo.Focus();
      txtFatNo.SelectionStart = txtFatNo.Text.Length;
      //txtFatNo.SelectAll();
      LoadDizayn();
      //txtFatNo.Text = "";
      if (_ftirsip == FTIRSIP.DirektSatis)
      {
        int mesafe = dateSevkIrsaliye.Location.Y - txtFatNo.Location.Y - dateSevkIrsaliye.Height - 3;
        //ViewConrol.HideContols(cmbKasalar).IncerementPosHeight((-1) * cmbKasalar.Height, btnFatKaydet, btnKalemKaydet, btnKalemSil)
        //          .HideContols(chkIrsaliyeli,labIrsNo,txtIrsaliyeNo).IncerementPosHeight((-1)*mesafe,grboxUstBilgi,labFatNo,txtFatNo);
        ViewConrol.HideContols(chkIrsaliyeli, labIrsNo, txtIrsaliyeNo).IncerementPosHeight((-1) * mesafe, grboxUstBilgiler, labFatNo, txtFatNo, btnFatRehber);
        //cmbFatTipi.Text = "Peşin";
        //cmbFatTipi.Enabled = false;
        //chkKdvDahilmi.Enabled = false;
        chkKdvDahilmi.Checked = true;
        
      }
      AyarlaEkranFatTipi();
      txtMiktar.Text = "1";
    }
    void LoadDizayn()
    {
      try
      {
        bool first = true;
        List<Dizayn> liste = mngDizayn.GetAll();
        foreach (Dizayn diz in liste)
        {
          cmbDizayn.Items.Add(diz);
          if (first)
          {
            cmbDizayn.Text = diz.DizaynAdi;
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
    void GetLastArtiFatIrsNo()
    {
      try
      {
          if (_ftirsip == FTIRSIP.SatisFat || _ftirsip == FTIRSIP.SatisIrs) {
              txtFatNo.Text = mngFatUst.GetLastArtiOneFatIrsNoBySubeKoduAndFtirsip(UserInfo.Sube.Id, _ftirsip);
              txtFatNo.Focus();
              txtFatNo.SelectionStart = txtFatNo.Text.Length;
          } else
              txtFatNo.Focus();
      }
      catch (Exception exc)
      {
        LogWrite.Write(exc);
        MessageBox.Show(exc.Message);
      }
    }
    void LoadKasa()
    {
      try
      {
        List<Kasa> kasalar = mngKasa.GetKasaBySubeKodu(UserInfo.Sube.Id);
        bool first = true;
        foreach (Kasa kas in kasalar)
        {
          cmbKasalar.Items.Add(kas.Id);
          if (first)
          {
            first = false;
            cmbKasalar.Text = kas.Id;
          }
        }
      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      }
    }
    void AyarlaEkranFatTipi() {
        if (cmbFatTipi.Text.Trim() == "Peşin") {
            EnableCari(false);
            flPanelFatBtns.Controls.Remove(labVadeTarih);
            flPanelFatBtns.Controls.Remove(dateVadeTarihi);
            flPanelFatBtns.Controls.Remove(labBanka);
            flPanelFatBtns.Controls.Remove(txtBankaHesapNo);
            flPanelFatBtns.Controls.Remove(btnBankaRehber);
            flPanelFatBtns.Controls.AddRange(new Control[] { labKasa, cmbKasalar });
            LoadKasa();
        } else if (cmbFatTipi.Text.Trim() == "Vadeli" || cmbFatTipi.Text.Trim() == "Iade") {
            EnableCari(true);
            //if(cmbFatTipi.Text!="Iade")
            flPanelFatBtns.Controls.Remove(labKasa);
            flPanelFatBtns.Controls.Remove(cmbKasalar);
            flPanelFatBtns.Controls.Remove(labBanka);
            flPanelFatBtns.Controls.Remove(txtBankaHesapNo);
            flPanelFatBtns.Controls.Remove(btnBankaRehber);
            flPanelFatBtns.Controls.AddRange(new Control[] { labVadeTarih, dateVadeTarihi });
        } else if (cmbFatTipi.Text.Trim() == "KrediKarti") {
            EnableCari(false);
            flPanelFatBtns.Controls.Remove(labKasa);
            flPanelFatBtns.Controls.Remove(cmbKasalar);
            flPanelFatBtns.Controls.Remove(labVadeTarih);
            flPanelFatBtns.Controls.Remove(dateVadeTarihi);

            flPanelFatBtns.Controls.AddRange(new Control[] { labBanka, txtBankaHesapNo, btnBankaRehber });
        }
    }
    private void cmbFatTipi_SelectedIndexChanged(object sender, EventArgs e)
    {
        AyarlaEkranFatTipi();
    }
    void EnableCari(bool val)
    {
      txtCari.Enabled = val;
      btnCariRehber.Enabled = val;
      if (!val)
      {
        txtCari.Text = "";        
      }
      else
        cmbKasalar.Text = "";
      cmbKasalar.Enabled =! val;

      //btnSrcCari.Enabled = val;
    }
    
    void SaveStokHar()
    {
        if (string.IsNullOrEmpty(txtFatNo.Text)) {
            string msj = "";
            if (FatNoTip.Fatura == _fatNoTip)
                msj = "Fatura numarasını giriniz";
            else
                msj = "irsaliye numarasını giriniz";
            MessageBox.Show(msj);
            txtFatNo.Focus();
            return;
        }
        try {
            StokHareket sh = null;
            if (_selectedStokHarId != null) {
                sh = mngSth.GetById(_selectedStokHarId.Value, false);
            }
            if (sh == null)
                sh = new StokHareket();
            if (_currentStok == null)
                _currentStok = mngStk.GetById(txtStokKodu.Text, false);
            sh.Stok = _currentStok;
            sh.BirimFiyat = txtFyt.Text.ParseNullable<double>(x => double.Parse(x));
            sh.FisNo = txtFatNo.Text;
            sh.HareketBirim = cmbBirim.Text;
            if (string.IsNullOrEmpty(cmbBirim.Text.Trim())) {
                sh.GCMiktar = txtMiktar.Text.ParseStruct<double>(x => double.Parse(x));
                sh.HareketMiktar = sh.GCMiktar;
            } else if (cmbBirim.Text.Trim() == _currentStok.AnaBirim.Trim()) {
                sh.GCMiktar = txtMiktar.Text.ParseStruct<double>(x => double.Parse(x));
                sh.HareketMiktar = sh.GCMiktar;
            } else if (cmbBirim.Text.Trim() == _currentStok.AltBirim1.Trim()) {
                sh.HareketMiktar = txtMiktar.Text.ParseNullable<double>(x => double.Parse(x));
                sh.GCMiktar = sh.HareketMiktar.GetValueOrDefault() * _currentStok.Carpan1.GetValueOrDefault();
            } else if (cmbBirim.Text.Trim() == _currentStok.AltBirim2.Trim()) {
                sh.HareketMiktar = txtMiktar.Text.ParseNullable<double>(x => double.Parse(x));
                sh.GCMiktar = sh.HareketMiktar.GetValueOrDefault() * _currentStok.Carpan2.GetValueOrDefault();
            } else if (cmbBirim.Text.Trim() == _currentStok.AltBirim3.Trim()) {
                sh.HareketMiktar = txtMiktar.Text.ParseNullable<double>(x => double.Parse(x));
                sh.GCMiktar = sh.HareketMiktar.GetValueOrDefault() * _currentStok.Carpan3.GetValueOrDefault();
            }
            if (string.IsNullOrEmpty(sh.HareketBirim.Trim()))
                sh.HareketBirim = _currentStok.AnaBirim.Trim();
            sh.Isk1 = txtIsk1.Text.ParseStruct<double>(x => double.Parse(x));
            sh.Isk2 = txtIsk2.Text.ParseStruct<double>(x => double.Parse(x));
            sh.Isk3 = txtIsk3.Text.ParseStruct<double>(x => double.Parse(x));
            sh.Isk4 = txtIsk4.Text.ParseStruct<double>(x => double.Parse(x));
            sh.Isk5 = txtIsk5.Text.ParseStruct<double>(x => double.Parse(x));
            //sh.Kdv = _currentStok.KdvOrani.GetValueOrDefault();
            sh.Kdv = txtKdv.Text.ParseStruct<double>(x=>double.Parse(x));

            sh.StharGckod = StokHareket.DetermineGCKodu(_ftirsip);
            sh.StharHtur = StokHareket.DetermineHarTur(_fatNoTip);
            sh.FTIRSIP = _ftirsip;
            if (_ftirsip == FTIRSIP.DirektSatis)
                sh.DirektSatis = "E";
            sh.Tarih = dateTarih.Text.ToDate();
            sh.Sube = UserInfo.Sube;
            mngSth.BeginTransaction();
            mngSth.SaveOrUpdate(sh);
           
            _currentStok = null;
            _selectedStokHarId = null;
            LoadSthHarToGrid();
            YeniKalem();
        } catch (Exception exc) {
            MessageBox.Show(exc.Message);
            LogWrite.Write(exc);
           
        } finally {
           
            try {
                mngSth.CommitTransaction();
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }
    }
    void YeniKalem()
    {
      CleareForm.ClearThisConrol(groupBox2)
                       .NotClearTheseConrols(grboxGenelToplam, cmbKasalar,cmbDizayn,dateVadeTarihi,txtBankaHesapNo)
                       .BeginClear();
      //ClearFormData(groupBox2);
     // txtStokKodu.Focus();
      txtBarkod.Focus();
      cmbBirim.Items.Clear();
      _currentStok = null;
      _selectedStokHarId = null;
      txtMiktar.Text = "1";
    }
    void KalemSil()
    {
      try
      {
        DialogResult re = MessageBox.Show("Kayıt Silinsin mi?", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        if (re == DialogResult.Yes)
        {
          if (_selectedStokHarId != null)
          {
            StokHareket sh = mngSth.GetById(_selectedStokHarId.Value,false);
            BeginTransaction();
            mngSth.Delete(sh);
            
            HesaplaToplamlari();         
            _selectedStokHarId = null;
            LoadSthHarToGrid();
            YeniKalem();
          }
        }
      }
      catch (Exception)
      {} finally {
          try {
              CommitTransaction();
          } catch (Exception exc) {
              MessageBox.Show(exc.Message);
              LogWrite.Write(exc);
          }
      }
    }
    void HesaplaGenelToplamlari(IList<StokHarRpr> stokListe)
    {
      try
      {
        if (stokListe == null)
          stokListe = mngSth.GetByFisNoAndSubeKodu(txtFatNo.Text,UserInfo.Sube.Id,_ftirsip);
        HesaplaGenelToplam hes = new HesaplaGenelToplam(stokListe, chkKdvDahilmi.Checked);
        txtGenelAraTop.Text = hes.AraToplam().ToString("F2");
        txtGenelBrut.Text = hes.BrutHesapla().ToString("F2");
        txtGenelGenelTop.Text = hes.GenelToplam().ToString("F2");
        txtGenelIskTop.Text = hes.SatirIskantosuToplam().ToString("F2");
        txtGenelTopKdv.Text = hes.ToplamaKdvHesapla().ToString("F2");
        genelToplamlar = hes;
      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      }
    }
    void LoadSthHarToGrid(IList<StokHarRpr>liste)
    {
      try
      {        
        dataGridView1.AutoGenerateColumns = false;       
        dataGridView1.DataSource = liste;        
        if (liste.Count == 0)
        {
          btnFatKaydet.Enabled = false;
          btnIrsFatu.Enabled = false;
          btnFatSil.Enabled = false;
        }
        else
        {
          btnFatKaydet.Enabled = true;
          btnFatSil.Enabled = true;
        }
        HesaplaGenelToplamlari(liste);
      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
      }
    }
    void LoadSthHarToGrid()
    {
      try
      {
        //BeginTransaction();
        dataGridView1.AutoGenerateColumns = false;
        dataGridView1.Columns[clTutar.Name].DefaultCellStyle.Format="F2";
        IList<StokHarRpr>rpr=mngSth.GetByFisNoAndSubeKodu(txtFatNo.Text,UserInfo.Sube.Id,_ftirsip);
        dataGridView1.DataSource = rpr;
        listeStok = rpr;
        if (rpr.Count == 0)
        {
          btnFatKaydet.Enabled = false;        
          btnIrsFatu.Enabled = false;
          btnFatSil.Enabled = false;
        }
        else
        {
          btnFatKaydet.Enabled = true;
          btnFatSil.Enabled = true;
        }
        //CommitTransaction();
        HesaplaGenelToplamlari(rpr);
      }
      catch(Exception exc)
      {
        MessageBox.Show(exc.Message);
      }
    }
    private void frmFatura_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter) {
            SendKeys.Send("{TAB}");
        } else if (e.KeyCode == Keys.F5) {
            SaveStokHar();
        } else if (e.KeyCode == Keys.F7) {
            KalemSil();
        } else if (e.KeyCode == Keys.F3)
            YeniKalem();
        else if (e.Alt && e.KeyCode == Keys.Y)
            Yeni();
        else if (e.Alt && e.KeyCode == Keys.K)
            FaturaKaydet();
        else if (e.Alt && e.KeyCode == Keys.S)
            FaturaSil();
    }


    void SetFiyat()
    {
        try {
            DoldurStokBirimleri(_currentStok, cmbBirim);
            txtStokMiktar.Text = mngSth.GetStokMiktar(txtStokKodu.Text).ToString();

            if (FTIRSIP.AlisFat == _ftirsip || FTIRSIP.AlisIrs == _ftirsip) {
                txtKdv.Text = _currentStok.AlisKdvOrani.ToString();
                if (!string.IsNullOrEmpty(txtCari.Text)) {
                    Cari cari = mngCari.GetById(txtCari.Text, false);
                    if (cari != null && !string.IsNullOrEmpty(cari.SatisFiyatKod)) {
                        txtFyt.Text = GetCariFiyat(cari, _currentStok, true);
                    } else
                        txtFyt.Text = _currentStok.AlisFiyat1.FromNullableToString();
                } else
                    txtFyt.Text = _currentStok.AlisFiyat1.FromNullableToString();
            } else if (FTIRSIP.SatisFat == _ftirsip || FTIRSIP.SatisIrs == _ftirsip) {
                txtKdv.Text = _currentStok.SatisKdvOrani.ToString();
                if (!string.IsNullOrEmpty(txtCari.Text)) {
                    Cari cari = mngCari.GetById(txtCari.Text, false);
                    if (cari != null && !string.IsNullOrEmpty(cari.SatisFiyatKod)) {
                        txtFyt.Text = GetCariFiyat(cari, _currentStok, false);
                    } else
                        txtFyt.Text = _currentStok.SatisFiyat1.FromNullableToString();
                } else
                    txtFyt.Text = _currentStok.SatisFiyat1.FromNullableToString();
            }
        } catch (Exception exc) {
            MessageBox.Show(exc.Message); LogWrite.Write(exc);
        }
    }
    private void txtStokKodu_KeyUp(object sender, KeyEventArgs e)
    {
      if (!string.IsNullOrEmpty(txtStokKodu.Text) && e.KeyCode == Keys.Tab)
      {
        try
        {
          //if(_currentStok==null)
            _currentStok = mngStk.GetById(txtStokKodu.Text, false);
          if (_currentStok != null)
          {
           
            txtStokIsmi.Text = _currentStok.StokAdi;
            txtBarkod.Text = _currentStok.Barkod1;
            
            double miktar = mngSth.GetStokMiktar(txtStokKodu.Text);
            if (miktar < 0)
            {
              MessageBox.Show("Stok Miktarı sıfırın altında");
            }
            else if (_currentStok.AsgariMiktar.GetValueOrDefault() > miktar)
            {
              MessageBox.Show("Stok miktarı asgari stok miktarının altında");
            }
            if (_selectedStokHarId == null || _selectedStokKodu != txtStokKodu.Text)
            {
             
              SetFiyat();
            }
            cmbBirim.Focus();
          }
          else
          {
            frmStok frm = new frmStok(this,_ftirsip);
            txtStokKodu.CloseAutoComplete();
            frm.txtStokIsmi.Focus();
            frm.WindowState =FormWindowState.Maximized;
            frm.ShowDialog();
            txtMiktar.Text = "1";
          }

        }
        catch (Exception exc)
        {
          MessageBox.Show(exc.Message);
          LogWrite.Write(exc);
        }
      }
    } 

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        try {
            DataGridViewRow r = dataGridView1.CurrentRow;
            if (r != null) {
                txtStokKodu.Text = _selectedStokKodu = dataGridView1.CurrentRow.Cells["clStokKodu"].Value.ToStringOrEmpty();
                _currentStok = mngStk.GetById(_selectedStokKodu, false);
                DoldurStokBirimleri(_currentStok, cmbBirim);
                txtStokIsmi.Text = dataGridView1.CurrentRow.Cells["clStokAdi"].Value.ToStringOrEmpty();
                txtMiktar.Text = dataGridView1.CurrentRow.Cells["clMiktar"].Value.ToStringOrEmpty();
                cmbBirim.Text = dataGridView1.CurrentRow.Cells[clHareketBirim.Name].Value.ToStringOrEmpty();
                txtFyt.Text = dataGridView1.CurrentRow.Cells["clFiyat"].Value.ToStringOrEmpty();
                txtIsk1.Text = dataGridView1.CurrentRow.Cells["clIsk1"].Value.ToStringOrEmpty();
                txtIsk2.Text = dataGridView1.CurrentRow.Cells["clIsk2"].Value.ToStringOrEmpty();
                txtIsk3.Text = dataGridView1.CurrentRow.Cells["clIsk3"].Value.ToStringOrEmpty();
                txtIsk4.Text = dataGridView1.CurrentRow.Cells["clIsk4"].Value.ToStringOrEmpty();
                txtIsk5.Text = dataGridView1.CurrentRow.Cells["clIsk5"].Value.ToStringOrEmpty();
                txtBarkod.Text = dataGridView1.CurrentRow.Cells["clBarkod"].Value.ToStringOrEmpty();
                _selectedStokHarId = dataGridView1.CurrentRow.Cells["clId"].Value.ToString().ParseNullable<int>(x => int.Parse(x));
                txtTutar.Text = dataGridView1.CurrentRow.Cells["clTutar"].Value.ToStringOrEmpty();
                txtBarkod.Focus();
                txtStokMiktar.Text = mngSth.GetStokMiktar(txtStokKodu.Text).ToString();
                txtKdv.Text = dataGridView1.CurrentRow.Cells[clKdvOrani.Name].Value.ToStringOrEmpty();
            }
        } catch (Exception exc) {
            MessageBox.Show(exc.Message);
            LogWrite.Write(exc);
        }
      
    }
   
    void SetFaturaTipAndCari(FatTipi fatTipi,string cariKodu)
    {
      if (FatTipi.KapaliFat == fatTipi)
      {
        cmbFatTipi.Text = "Peşin";
        EnableCari(false);
      } 
      else if(FatTipi.KrediKarti==fatTipi)
      {
        cmbFatTipi.Text = "KrediKarti";
        EnableCari(false);
      }
      else if(FatTipi.AcikFat==fatTipi || FatTipi.IadeFat==fatTipi)
      {
        if (fatTipi == FatTipi.AcikFat)
          cmbFatTipi.Text = "Vadeli";
        else
          cmbFatTipi.Text = "Iade";
        EnableCari(true);
        txtCari.Text = cariKodu;
      }
    }
    void FaturaDatalariYukle() {
        try {
            _currentFatUst = mngFatUst.GetByBelgeNoBelgeTipAndSubeKodu(txtFatNo.Text, _ftirsip, UserInfo.Sube.Id);
            if (_currentFatUst != null) {
                CleareForm.ClearThisConrol(this).NotClearTheseConrols(cmbDizayn, cbFaturaBas, cmbKasalar, txtMiktar).BeginClear();
                dataGridView1.DataSource = null;
                txtFatNo.Text = _currentFatUst.FatirsNo;
                txtCari.Text = _currentFatUst.CariKodu;
                SetFaturaTipAndCari(_currentFatUst.FatTipi, _currentFatUst.CariKodu);
                dateTarih.Text = _currentFatUst.Tarih.ToString("d");
                chkKdvDahilmi.Checked = _currentFatUst.KdvDahilmi.Value;
                cmbKasalar.Text = _currentFatUst.KasaKodu;

                chkIrsaliyeli.Checked = _currentFatUst.Irsaliyeli;
                txtBankaHesapNo.Text = _currentFatUst.HesapNo;
                if (_currentFatUst.Irsaliyeli || _currentFatUst.Ftirsip == FTIRSIP.AlisIrs || _currentFatUst.Ftirsip == FTIRSIP.SatisIrs) {
                    dateSevkIrsaliye.Text = _currentFatUst.SevkTarihi == null ? DateTime.Today.ToString("d") : _currentFatUst.SevkTarihi.Value.ToString("d");
                    txtIrsaliyeNo.Text = _currentFatUst.IrsaliyeNo;
                }
                btnFatKaydet.Enabled = true;
                btnIrsFatu.Enabled = true;
                LoadSthHarToGrid();
                if (_ftirsip == FTIRSIP.DirektSatis)
                    dateTarih.Focus();
                if (_currentFatUst.FatTipi == FatTipi.AcikFat || _currentFatUst.FatTipi == FatTipi.IadeFat)
                    dateVadeTarihi.Value = _currentFatUst.VadeTarih.Value;
                else if (_currentFatUst.FatTipi == FatTipi.KapaliFat)
                    cmbKasalar.Text = _currentFatUst.KasaKodu;
                else if (_currentFatUst.FatTipi == FatTipi.KrediKarti)
                    txtBankaHesapNo.Text = _currentFatUst.HesapNo;

            } else {

                if (_sipUst == null) {
                    string temp = txtFatNo.Text;
                    //CleareForm.ClearThisConrol(this).NotClearTheseConrols(txtFatNo).BeginClear();
                    InitializeForm();
                    txtFatNo.Text = temp;
                }
                //dateTarih.Text = DateTime.Today.ToString("d");// hüsnü istek üzerine
                //dateSevkIrsaliye.Text = DateTime.Today.ToString("d");

            }
            if (FatNoTip.Irsaliye == _fatNoTip)
                dateSevkIrsaliye.Focus();
            else
                chkIrsaliyeli.Focus();

        } catch (Exception exc) {
            MessageBox.Show(exc.Message);
            LogWrite.Write(exc);
        }
    }
    private void txtFatNo_KeyUp(object sender, KeyEventArgs e)
    {
      if (!string.IsNullOrEmpty(txtFatNo.Text) && (e.KeyCode == Keys.Tab || e.KeyCode==Keys.Enter))
      {
          FaturaDatalariYukle();
       
      }
    }
    void SiparisKapat()
    {
      try
      {
        if (_sipUst != null && mngSipUst!=null)
        {
          _sipUst.Kapatilmis = true;
          mngSipUst.BeginTransaction();
          mngSipUst.SaveOrUpdate(_sipUst);        
        }
      } catch (Exception) {
      } finally {
          try {
              mngSipUst.CommitTransaction();
          } catch (Exception exc) {
              MessageBox.Show(exc.Message);
              LogWrite.Write(exc);
          }
      }
    }
    void FaturaKaydet() {
        try {
            if (cmbFatTipi.Text.Trim() == "Peşin") {
                if (_fatNoTip == FatNoTip.Fatura || _fatNoTip == FatNoTip.Irsaliye) {
                   
                    if (_ftirsip == FTIRSIP.DirektSatis || _ftirsip == FTIRSIP.AlisFat || _ftirsip == FTIRSIP.SatisFat || _ftirsip == FTIRSIP.AlisIrs || _ftirsip == FTIRSIP.SatisIrs) {

                        if (string.IsNullOrEmpty(cmbKasalar.Text)) {
                            MessageBox.Show("Lütfen kasa seçiniz");
                            cmbKasalar.Focus();
                            return;
                        }
                        BeginTransaction();
                        if (_ftirsip == FTIRSIP.DirektSatis || _ftirsip == FTIRSIP.AlisFat || _ftirsip == FTIRSIP.SatisFat) {
                            KasaHareket kasaHar = mngKasaHar.GetBySubeKoduTipAndFisNo(UserInfo.Sube.Id, KasaHarTip.Fatura, txtFatNo.Text);
                            if (kasaHar == null)
                                kasaHar = new KasaHareket();
                            if (_ftirsip == FTIRSIP.AlisFat)
                                kasaHar.GelirGider = "C";
                            else
                                kasaHar.GelirGider = "G";
                            kasaHar.FisNo = txtFatNo.Text;
                            kasaHar.Tip = KasaHareket.DetermineTip(KasaHarTip.Fatura);
                            //kasaHar.Tip =FTIRSIP.AlisFat==_ftirsip? KasaHareket.DetermineTip(KasaHarTip.MalAlis)
                            //  : KasaHareket.DetermineTip(KasaHarTip.MalSatis) ;
                            kasaHar.Kasa = mngKasa.GetById(cmbKasalar.Text, false);
                            kasaHar.KdvTutar = genelToplamlar.ToplamaKdvHesapla();
                            kasaHar.Tutar = genelToplamlar.GenelToplam();
                            kasaHar.Tarih = dateTarih.Text.ToDate();
                            kasaHar.Sube = UserInfo.Sube;
                            if (_ftirsip == FTIRSIP.DirektSatis)
                                kasaHar.DirektSatis = "E";
                            mngKasaHar.SaveOrUpdate(kasaHar);
                        }
                        if (_currentFatUst == null)
                            _currentFatUst = new FatIrsUst();
                        _currentFatUst.FatirsNo = txtFatNo.Text;
                        _currentFatUst.FatTipi = FatTipi.KapaliFat;
                        _currentFatUst.Ftirsip = _ftirsip;
                        _currentFatUst.KdvDahilmi = chkKdvDahilmi.Checked;
                        _currentFatUst.Sube = UserInfo.Sube;
                        _currentFatUst.Tarih = dateTarih.Text.ToDate();
                        _currentFatUst.BrutTutar = genelToplamlar.BrutHesapla();
                        _currentFatUst.GenelToplam = genelToplamlar.GenelToplam();
                        _currentFatUst.KdvTutar = genelToplamlar.ToplamaKdvHesapla();
                        _currentFatUst.SatirIsk = genelToplamlar.SatirIskantosuToplam();
                        _currentFatUst.KasaKodu = cmbKasalar.Text;
                        _currentFatUst.Irsaliyeli = chkIrsaliyeli.Checked;
                        _currentFatUst.VadeTarih = null;
                        if (_ftirsip == FTIRSIP.AlisIrs || _ftirsip == FTIRSIP.SatisIrs)
                            _currentFatUst.SevkTarihi = dateSevkIrsaliye.Text.ToDate();
                        if (chkIrsaliyeli.Checked) {
                            _currentFatUst.IrsaliyeNo = txtIrsaliyeNo.Text;
                            _currentFatUst.SevkTarihi = dateSevkIrsaliye.Text.ToDate();
                        }
                        mngFatUst.SaveOrUpdate(_currentFatUst);
                        //CommitTransaction();
                        // daha önce cari olarak kaydedilmiş bir kayıt ise cari hareket silinir veya banka
                        CariHareketSil(_currentFatUst.FatirsNo);
                        BankaHareketSil();
                        if (cbFaturaBas.Checked) {
                            Dizayn diz = (Dizayn)cmbDizayn.SelectedItem;
                            PrintFatIrs print = new PrintFatIrs(mng, _currentFatUst, diz, listeStok, genelToplamlar);
                            print.Print();
                        }
                        if (_sipUst != null)
                            SiparisKapat();
                        //if (_ftirsip == FTIRSIP.AlisFat || _ftirsip == FTIRSIP.SatisFat)
                        //{
                        InitializeForm();
                        GetLastArtiFatIrsNo();
                        //}
                        //else
                        //  btnIrsFatu.Enabled = true;

                    }

                }
            } else if (cmbFatTipi.Text.Trim() == "Vadeli" || cmbFatTipi.Text.Trim() == "Iade") {// açık ve iade faturalar için
                if (_ftirsip==FTIRSIP.DirektSatis || _ftirsip == FTIRSIP.AlisFat || _ftirsip == FTIRSIP.SatisFat || _ftirsip == FTIRSIP.AlisIrs || _ftirsip == FTIRSIP.SatisIrs) {
                    if (string.IsNullOrEmpty(txtCari.Text)) {
                        MessageBox.Show("Geçerli bir cari kodu giriniz");
                        return;
                    }
                    if (!string.IsNullOrEmpty(txtCari.Text) && !CariVarmi(txtCari.Text)) {
                        if (OtomatikCariKaydedilsin()) {
                            CariKaydet(txtCari.Text);
                        } else {
                            MessageBox.Show("Geçerli bir cari kodu giriniz");
                            return;
                        }
                    } 
                    BeginTransaction();
                    if (_ftirsip == FTIRSIP.AlisFat || _ftirsip == FTIRSIP.SatisFat || _ftirsip==FTIRSIP.DirektSatis) {
                       
                      
                        CariHareket cahar = mngCariHrk.GetByFisNo(UserInfo.Sube.Id, txtFatNo.Text);
                        if (cahar == null)
                            cahar = new CariHareket();
                        if (_ftirsip == FTIRSIP.AlisFat) {
                            cahar.Alacak = genelToplamlar.GenelToplam();
                            cahar.HareketTuru = cmbFatTipi.Text.Trim() == "Vadeli" ? CariHarTuru.AlinanMal
                              : CariHarTuru.AlinanMalIadesi;
                        } else {
                            cahar.Borc = genelToplamlar.GenelToplam();
                            cahar.HareketTuru = cmbFatTipi.Text.Trim() == "Vadeli" ? CariHarTuru.SatilanMal
                              : CariHarTuru.SatilanMalIadesi;
                        }
                        cahar.Cari = mngCari.GetById(txtCari.Text, false);
                        cahar.FisNo = txtFatNo.Text;
                        cahar.Tarih = dateTarih.Text.ToDate();
                        //cahar.HareketTuru =cmbFatTipi.Text=="Vadeli"? "B":"C";//Fatura(B),IadeFatura(C)
                        cahar.Sube = UserInfo.Sube;
                        //if (cmbFatTipi.Text != "Iade")//Açık fatura ise
                        cahar.VadeTarih = dateVadeTarihi.Value.JustDate();
                        mngCariHrk.SaveOrUpdate(cahar);
                    }
                    if (_currentFatUst == null)
                        _currentFatUst = new FatIrsUst();
                    _currentFatUst.FatirsNo = txtFatNo.Text;
                    _currentFatUst.FatTipi = cmbFatTipi.Text.Trim() == "Iade" ? FatTipi.IadeFat : FatTipi.AcikFat;
                    _currentFatUst.Ftirsip = _ftirsip;
                    _currentFatUst.KdvDahilmi = chkKdvDahilmi.Checked;
                    _currentFatUst.Sube = UserInfo.Sube;
                    _currentFatUst.Tarih = dateTarih.Text.ToDate();
                    _currentFatUst.BrutTutar = genelToplamlar.BrutHesapla();
                    _currentFatUst.GenelToplam = genelToplamlar.GenelToplam();
                    _currentFatUst.KdvTutar = genelToplamlar.ToplamaKdvHesapla();
                    _currentFatUst.SatirIsk = genelToplamlar.SatirIskantosuToplam();
                    _currentFatUst.CariKodu = txtCari.Text;
                    _currentFatUst.Irsaliyeli = chkIrsaliyeli.Checked;
                    _currentFatUst.VadeTarih = dateVadeTarihi.Value.JustDate();
                    if (_ftirsip == FTIRSIP.AlisIrs || _ftirsip == FTIRSIP.SatisIrs)
                        _currentFatUst.SevkTarihi = dateSevkIrsaliye.Text.ToDate();
                    if (chkIrsaliyeli.Checked) {
                        _currentFatUst.IrsaliyeNo = txtIrsaliyeNo.Text;
                        _currentFatUst.SevkTarihi = dateSevkIrsaliye.Text.ToDate();
                    }
                    mngFatUst.SaveOrUpdate(_currentFatUst);
                    //CommitTransaction();
                    // daha önce kasahareket işlenmiş se siler veya banka ise
                    KasaHareketSil(_currentFatUst.FatirsNo);
                    BankaHareketSil();
                  
                    if (cbFaturaBas.Checked) {
                        Dizayn diz = (Dizayn)cmbDizayn.SelectedItem;
                        PrintFatIrs print = new PrintFatIrs(mng, _currentFatUst, diz, listeStok, genelToplamlar);
                        print.Print();
                    }
                    if (_sipUst != null)
                        SiparisKapat();
                    //if (_ftirsip == FTIRSIP.AlisFat || _ftirsip == FTIRSIP.SatisFat)
                    //{
                    InitializeForm();
                    GetLastArtiFatIrsNo();
                    //}
                    //else
                    //  btnIrsFatu.Enabled = true;

                }
            } else if (cmbFatTipi.Text.Trim() == "KrediKarti") {
                if (_ftirsip == FTIRSIP.SatisFat || _ftirsip == FTIRSIP.DirektSatis) {
                    if (string.IsNullOrEmpty(txtBankaHesapNo.Text)) {
                        MessageBox.Show("lütfen banka hesap numarasını giriniz");
                        txtBankaHesapNo.Focus();
                        return;
                    }
                   
                    HesapHareket hesap = mngHesapHar.GetBySubeKoduAndFisNoAndHesapNo(UserInfo.Sube.Id, txtFatNo.Text, txtBankaHesapNo.Text.Trim());
                    if (hesap == null)
                        hesap = new HesapHareket();
                    hesap.Aciklama = txtFatNo.Text + " fiş no kredi kartı ile gelir";
                    BankaHesap banka = mngBanka.GetByHesapNo(UserInfo.Sube.Id, txtBankaHesapNo.Text);
                    if (banka == null) {
                        MessageBox.Show("banka hesap numarası bulunamadı, lütfen geçerli bir banka hesap numarası giriniz");
                        txtBankaHesapNo.Focus();
                        return;
                    }
                    BeginTransaction();
                    hesap.BankaHesap = banka;
                    hesap.FisNo = txtFatNo.Text;
                    hesap.HareketTuru = HesapHareketTuru.KrediKarti;
                    hesap.Sube = UserInfo.Sube;
                    hesap.Tarih = dateTarih.Text.ToDate();
                    hesap.Tutar = genelToplamlar.GenelToplam();
                    mngHesapHar.SaveOrUpdate(hesap);

                    if (_currentFatUst == null)
                        _currentFatUst = new FatIrsUst();
                    _currentFatUst.FatirsNo = txtFatNo.Text;
                    _currentFatUst.FatTipi = FatTipi.KrediKarti;
                    _currentFatUst.Ftirsip = _ftirsip;
                    _currentFatUst.KdvDahilmi = chkKdvDahilmi.Checked;
                    _currentFatUst.Sube = UserInfo.Sube;
                    _currentFatUst.Tarih = dateTarih.Text.ToDate();
                    _currentFatUst.BrutTutar = genelToplamlar.BrutHesapla();
                    _currentFatUst.GenelToplam = genelToplamlar.GenelToplam();
                    _currentFatUst.KdvTutar = genelToplamlar.ToplamaKdvHesapla();
                    _currentFatUst.SatirIsk = genelToplamlar.SatirIskantosuToplam();
                    _currentFatUst.CariKodu = txtCari.Text;
                    _currentFatUst.Irsaliyeli = chkIrsaliyeli.Checked;
                    _currentFatUst.VadeTarih = null;
                    _currentFatUst.HesapNo = txtBankaHesapNo.Text.Trim();
                    if (chkIrsaliyeli.Checked) {
                        _currentFatUst.IrsaliyeNo = txtIrsaliyeNo.Text;
                        _currentFatUst.SevkTarihi = dateSevkIrsaliye.Text.ToDate();
                    }
                    mngFatUst.SaveOrUpdate(_currentFatUst);
                    //CommitTransaction();
                    // daha önce kasahareket işlenmiş se siler veya banka ise
                    KasaHareketSil(_currentFatUst.FatirsNo);
                    CariHareketSil(_currentFatUst.FatirsNo);
                    if (cbFaturaBas.Checked) {
                        Dizayn diz = (Dizayn)cmbDizayn.SelectedItem;
                        PrintFatIrs print = new PrintFatIrs(mng, _currentFatUst, diz, listeStok, genelToplamlar);
                        print.Print();
                    }
                    if (_sipUst != null)
                        SiparisKapat();
                    //if (_ftirsip == FTIRSIP.AlisFat || _ftirsip == FTIRSIP.SatisFat)
                    //{
                    InitializeForm();
                    GetLastArtiFatIrsNo();
                    //}
                    //else
                    //  btnIrsFatu.Enabled = true;
                }
            }

        } catch (Exception ex) {
           
        } finally {
            try {
                CommitTransaction();
             
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }
    }
    private void btnFatKaydet_Click(object sender, EventArgs e)
    {
        FaturaKaydet();
    }
    void InitializeForm()
    {
      dataGridView1.DataSource = null;
      dateVadeTarihi.Value = DateTime.Today;
      
      CleareForm.ClearThisConrol(this).NotClearTheseConrols(chkKdvDahilmi,cmbDizayn, cbFaturaBas,cmbKasalar,cmbFatTipi).BeginClear();
      //dateTarih.Text = DateTime.Today.ToString("d");
      //dateSevkIrsaliye.Text = DateTime.Today.ToString("d");
      dateTarih.Text = "";
      dateSevkIrsaliye.Text = "";
      //if (_ftirsip != FTIRSIP.DirektSatis) {
      //    cmbFatTipi.SelectedIndex = 0;
      //    cmbFatTipi.Text = "Vadeli";
      //}
      _currentFatUst = null;
      _currentStok = null;
      _selectedStokHarId = null;
      _selectedStokKodu = null;
      _sipUst = null;
      listeStok = null;
      txtMiktar.Text = "1";
      if (cmbKasalar.Items.Count > 1)
        cmbKasalar.SelectedIndex = 0;
      if (cmbDizayn.Items.Count > 1)
        cmbDizayn.SelectedIndex = 0;
    }
    private void btnKalemKaydet_Click(object sender, EventArgs e)
    {
      SaveStokHar();
    }

    private void chkKdvDahilmi_CheckedChanged(object sender, EventArgs e)
    {
      HesaplaToplamlari();
      HesaplaGenelToplamlari(null);
    }

    private void txtMiktar_TextChanged_1(object sender, EventArgs e) {
        try {
            HesaplaToplamlari();
            double d = txtFyt.Text.ParseStruct<double>(x => double.Parse(x));
            txtTutar.Text = ((txtMiktar.Text.ParseStruct<double>(x => double.Parse(x))) * d).ToString(2);
        } catch (Exception exc) {
            MessageBox.Show(exc.Message);
            LogWrite.Write(exc);
        }
    }
    void HesaplaToplamlari()
    {
      try
      {
        if (_currentStok == null)
          _currentStok = mngStk.GetById(txtStokKodu.Text, false);
        //HesaplaToplam hes = new HesaplaToplam(_ftirsip)
        //{
        //  Fiyat = txtFyt.Text.ParseNullable<double>(x => double.Parse(x)),
        //  KdvDahil = chkKdvDahilmi.Checked,
        //  Miktar = txtMiktar.Text.ParseStruct<double>(x => double.Parse(x)),
        //  Stok = _currentStok
        //};
        //hes.IskontoOranlari.Add(txtIsk1.Text.ParseNullable<double>(x => double.Parse(x)));
        //hes.IskontoOranlari.Add(txtIsk2.Text.ParseNullable<double>(x => double.Parse(x)));
        //hes.IskontoOranlari.Add(txtIsk3.Text.ParseNullable<double>(x => double.Parse(x)));
        //hes.IskontoOranlari.Add(txtIsk4.Text.ParseNullable<double>(x => double.Parse(x)));
        //hes.IskontoOranlari.Add(txtIsk5.Text.ParseNullable<double>(x => double.Parse(x)));
        
        //txtBrutToplam.Text = (hes.BrutHesapla()).ToString("F2");
        //txtIskToplam.Text = (hes.SatirIskantosuToplam()).ToString("F2");
        //txtAraToplam.Text = ( hes.AraToplam()).ToString("F2");
        //txtKdvToplam.Text = ( hes.KdvHesapla()).ToString("F2");
        //txtGenelToplam.Text = (hes.GenelToplam()).ToString("F2");
      }
      catch (Exception exc)
      {
        LogWrite.Write(exc);
        MessageBox.Show(exc.Message);
      }
    }

    private void btnKalemSil_Click(object sender, EventArgs e)
    {
      KalemSil();
    }

    private void btnStokSearch_Click(object sender, EventArgs e)
    {
      CleareForm.ClearThisConrol(grboxUstBilgiler)
                .NotClearTheseConrols(txtCari)
                .BeginClear() ;
    }

    private void txtCari_KeyUp(object sender, KeyEventArgs e)
    {
        if (!string.IsNullOrEmpty(txtCari.Text) && e.KeyCode == Keys.Tab) {
            try {
                Cari cari = mngCari.GetById(txtCari.Text,false);
                if (cari == null) {
                    frmCari frm = new frmCari();
                    frm.Owner = this;
                    frm.txtCariKodu.Text = txtCari.Text;
                    frm.txtCariKodu.Focus();
                    frm.ShowDialog();
                } else {
                    if (chkKdvDahilmi.Enabled)
                        chkKdvDahilmi.Focus();
                    else
                        txtBarkod.Focus();
                }
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }
    
    }

    private void chkIrsaliyeli_CheckedChanged(object sender, EventArgs e)
    {
      AdjustIrsaliyeTarih(chkIrsaliyeli.Checked);
    }
    void AdjustIrsaliyeTarih(bool irsaliyeli)
    {
      int mesafe = (dateSevkIrsaliye.Height + txtIrsaliyeNo.Height + (dateSevkIrsaliye.Location.Y - txtIrsaliyeNo.Location.Y) - txtIrsaliyeNo.Height);

      if (irsaliyeli)
      {
        ViewConrol.ShowControls(labSevkTarihi, dateSevkIrsaliye,labIrsNo,txtIrsaliyeNo)
            .IncerementPosHeight(mesafe, grboxUstBilgiler, labFatNo, txtFatNo,btnFatRehber, chkIrsaliyeli);
      }
      else
      {
        ViewConrol.HideContols(labSevkTarihi, dateSevkIrsaliye,labIrsNo,txtIrsaliyeNo)
          .IncerementPosHeight((-1) * mesafe, grboxUstBilgiler, labFatNo, txtFatNo,btnFatRehber, chkIrsaliyeli);
        txtIrsaliyeNo.Text = "";
      }
    }

    private void btnIrsFatu_Click(object sender, EventArgs e)
    {
      frmIrsFatura frm=new frmIrsFatura(txtFatNo.Text,_ftirsip);
      frm.ShowDialog();
      InitializeForm();
      GetLastArtiFatIrsNo();
    }
    private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
    {
      if (/*!string.IsNullOrEmpty(txtBarkod.Text) && */(e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter))
      {
        try
        {
          if(!string.IsNullOrEmpty(txtBarkod.Text))
          {
            if (_currentStok == null)
            {
              _currentStok = mngStk.GetBySubeAndBarkod1(UserInfo.Sube.Id, txtBarkod.Text);
              if (_currentStok != null)
              {

                txtStokIsmi.Text = _currentStok.StokAdi;
                txtStokKodu.Text = _currentStok.Id;
                txtKdv.Text = _currentStok.KdvOrani.FromNullableToString();
                if (_selectedStokHarId == null || _selectedStokKodu != txtStokKodu.Text)
                {
                  //DoldurStokBirimleri(_currentStok);
                  //txtStokMiktar.Text = mngSth.GetStokMiktar(txtStokKodu.Text).ToString();
                  //if (FTIRSIP.AlisFat == _ftirsip || FTIRSIP.AlisIrs == _ftirsip)
                  //{
                  //  txtFyt.Text = _currentStok.AlisFiyat1.FromNullableToString();
                  //}
                  //else if (FTIRSIP.SatisFat == _ftirsip || FTIRSIP.SatisIrs == _ftirsip)
                  //{
                  //  txtFyt.Text = _currentStok.SatisFiyat1.FromNullableToString();
                  //}
                  SetFiyat();
                }
              }
              else
                YeniKalem();
            }
          }
          txtStokKodu.Focus();
        }
        catch (Exception exc)
        {
          MessageBox.Show(exc.Message);
          LogWrite.Write(exc);
        }
      }
     
    }  

    private void btnYeniKalem_Click(object sender, EventArgs e)
    {
      YeniKalem();
    }

    private void btnCariRehber_Click(object sender, EventArgs e)
    {
      frmCariRehber frm = new frmCariRehber();
      frm.Owner = this;
      frm.Show();
      txtCari.Focus();
    }

    private void btnStokRehber_Click(object sender, EventArgs e)
    {
      frmStokSearch frm = new frmStokSearch(_ftirsip);
      frm.Owner = this;
      frm.Show();
      txtStokKodu.Focus();
    }

    void CariHareketSil(string fatNo)
    {
        try {
            CariHareket cahar = mngCariHrk.GetByFisNo(UserInfo.Sube.Id, fatNo);
            if (cahar != null) {
                mngCariHrk.BeginTransaction();
                mngCariHrk.Delete(cahar);
               
            }
        } catch (Exception) {
        } finally {
            try {
                mngCariHrk.CommitTransaction();
            } catch (Exception exc) {
                LogWrite.Write(exc);
                MessageBox.Show(exc.Message);
            }
        }
    }
    void KasaHareketSil(string fatNo)
    {
      try
      {
        KasaHareket kahar = mngKasaHar.GetBySubeKoduTipAndFisNo(UserInfo.Sube.Id,KasaHarTip.Fatura, fatNo);
        if (kahar != null)
        {
          mngKasaHar.BeginTransaction();
          mngKasaHar.Delete(kahar);
         
        }
      } catch (Exception) {
      } finally {
          try {
              mngKasaHar.CommitTransaction();
          } catch (Exception exc) {
              LogWrite.Write(exc);
              MessageBox.Show(exc.Message);
          }
      }
    }
    void BankaHareketSil()
    {
      try
      {
        HesapHareket hehar = mngHesapHar.GetBySubeKoduAndFisNoAndHesapNo(UserInfo.Sube.Id,txtFatNo.Text,txtBankaHesapNo.Text);
        if (hehar != null)
        {
          mngHesapHar.BeginTransaction();
          mngHesapHar.Delete(hehar);
          
        }
      } catch (Exception) {
      } finally {
          try {
              mngHesapHar.CommitTransaction();
          } catch (Exception exc) {
              LogWrite.Write(exc);
              MessageBox.Show(exc.Message);
          }
      }
    }
    void FaturaSil() {
        DialogResult re = MessageBox.Show("Kayıt Silinsin mi?", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        if (re == DialogResult.Yes) {
            try {
                if (_currentFatUst != null) {
                    BeginTransaction();

                    if ((FTIRSIP.AlisFat == _ftirsip || FTIRSIP.SatisFat == _ftirsip || FTIRSIP.DirektSatis==_ftirsip) && (FatTipi.AcikFat == _currentFatUst.FatTipi || FatTipi.IadeFat == _currentFatUst.FatTipi)) {
                        CariHareketSil(_currentFatUst.FatirsNo);
                    } else if ((FTIRSIP.AlisFat == _ftirsip || FTIRSIP.SatisFat == _ftirsip || FTIRSIP.DirektSatis==_ftirsip) && (FatTipi.KapaliFat == _currentFatUst.FatTipi || FatTipi.IadeFat == _currentFatUst.FatTipi)) {
                        KasaHareketSil(_currentFatUst.FatirsNo);
                    }
                    if ((FTIRSIP.SatisFat == _ftirsip || FTIRSIP.DirektSatis==_ftirsip) && FatTipi.KrediKarti == _currentFatUst.FatTipi)
                        BankaHareketSil();
                    mngSth.TopluHareketSil(_currentFatUst.FatirsNo, _ftirsip);
                    //mngFatUst.BeginTransaction();
                    mngFatUst.Delete(_currentFatUst);
                   
                    InitializeForm();
                    GetLastArtiFatIrsNo();
                }

            } catch (Exception) {
            } finally {
                try {
                    //mngFatUst.CommitTransaction();
                    CommitTransaction();
                } catch (Exception exc) {
                    LogWrite.Write(exc);
                    MessageBox.Show(exc.Message);
                }
            }
        }
    }
    private void btnFatSil_Click(object sender, EventArgs e)
    {
        FaturaSil();
    }

    private void btnFatRehber_Click(object sender, EventArgs e)
    {
      frmFatRehber frm = new frmFatRehber(this, _ftirsip);
      frm.Owner = this;
      frm.WindowState = FormWindowState.Maximized;
      frm.Show();
      txtFatNo.Focus();
      //ProcessDataBase db = new ProcessDataBase();
      //string str = "BACKUP DATABASE [HAN2009] TO DISK = 'D:\\film' WITH FORMAT";
      //db.ExecuteNonQueries(str,txtBarkod);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      frmFatRehber frm = new frmFatRehber(this, _ftirsip);
      frm.Owner = this;
      frm.WindowState = FormWindowState.Maximized;
      frm.Show();
    }

    private void btnBankaRehber_Click(object sender, EventArgs e)
    {
      frmBankaHesapRehber frm = new frmBankaHesapRehber();
      frm.Owner = this;
      frm.ShowDialog();
      txtBankaHesapNo.Focus();
    }
    void Yeni() {
        InitializeForm();
        GetLastArtiFatIrsNo();
    }
    private void btnYeni_Click(object sender, EventArgs e)
    {
        Yeni();
    }

    private void frmFatura_FormClosing(object sender, FormClosingEventArgs e) {
        txtStokKodu.CloseAutoComplete();
        txtCari.CloseAutoComplete();
        txtFatNo.CloseAutoComplete();
        bool isBegin = false;
        if (listeStok != null && listeStok.Count > 0) {
            try {
                FatIrsUst fat = mngFatUst.GetByBelgeNoBelgeTipAndSubeKodu(txtFatNo.Text, _ftirsip, UserInfo.Sube.Id);
                if (fat == null) {
                    isBegin = true;
                    BeginTransaction();
                    mngSth.TopluHareketSil(txtFatNo.Text, _ftirsip);
                }
            } catch (Exception) {
            } finally {
                try {
                    //mngFatUst.CommitTransaction();
                    if(isBegin)
                        CommitTransaction();
                } catch (Exception exc) {
                    LogWrite.Write(exc);
                    MessageBox.Show(exc.Message);
                }
            }
        }
    }

    private void dateSevkIrsaliye_KeyDown(object sender, KeyEventArgs e) {
        if (dateSevkIrsaliye.SelectionStart == 0 && Char.IsNumber(dateSevkIrsaliye.Text[0])) {
            dateSevkIrsaliye.Text = "";
        }
    }   
  }
}
