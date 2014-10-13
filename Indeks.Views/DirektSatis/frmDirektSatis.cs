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
using Indeks.Print;                                                                   
namespace Indeks.Views
{
  public partial class frmDirektSatis : BaseForm
  {
    IManagerFactory mng;  
    IStokManager mngStk;   
    IStokHareketManager mngSth;   
    IKasaHarManager mngKasaHar;
    IKasaManager mngKasa;
    IFatIrsUstManager mngFatUst;
    ICariHareketManager mngCariHar;
    IHesapHareketManager mngHesapHar;
    IBankaHesapManager mngBanka;
    IDizaynManager mngDizayn;
    int? _selectedStokHarId = null;
    string _selectedStokKodu = string.Empty;
    Stok _currentStok = null;
    string _fisNo=string.Empty;
    HesaplaGenelToplam genelToplamlar;
    public string CariKodu { get; set; }
    public DateTime VadeTarih { get; set; }
    public string HesapNo { get; set; }
    public bool SatisYap { get; set; }
      // fatura bas işaretliyse cari kodu almak için 
    public string KasaCariKodu { get; set; }
    IList<StokHarRpr> listeStok;
    public frmDirektSatis()
    {
      InitializeComponent();
      mng = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
      mngHesapHar = mng.GetHesapHareketManager();
      mngBanka = mng.GetBankaHesapManager();
      mngStk = mng.GetStokManager();    
      mngSth = mng.GetStokHareketManager();
      mngKasa = mng.GetKasaManager();
      mngKasaHar = mng.GetKasaHarManager();
      mngFatUst = mng.GetFatirsUstManager();
      mngCariHar = mng.GetCariHareketManager();
      mngDizayn = mng.GetDizaynManager();
      SatisYap = false;
      //txtStokKodu.DataSource = () =>
      //{
      //  try
      //  {
      //    return mngStk.StokKods(txtStokKodu.Text, UserInfo.Sube);
      //  }
      //  catch (Exception exc)
      //  {
      //    MessageBox.Show(exc.Message);
      //    LogWrite.Write(exc);
      //  }
      //  return null;
      //};
      LoadKasa();
      SetFisNo();
      
      txtBarkod.Focus();
      txtMiktar.Text = "1";
      txtBarkod.Text = string.Empty;
      
      dataGridView1.DataSource = null;
      LoadDizayn();
    }
    void LoadDizayn() {
        try {
            bool first = true;
            List<Dizayn> liste = mngDizayn.GetAll();
            foreach (Dizayn diz in liste) {
                cmbDizayn.Items.Add(diz);
                if (first) {
                    cmbDizayn.Text = diz.DizaynAdi;
                    first = false;
                }
            }
        } catch (Exception exc) {
            MessageBox.Show(exc.Message);
            LogWrite.Write(exc);
        }
    }
    void SetFisNo()
    {
      try
      {
        //_fisNo = mngSth.GetLastArtiOneFisNoBySubeKodu(UserInfo.Sube.Id);
          _fisNo = mngFatUst.GetLastArtiOneFatIrsNoBySubeKoduAndFtirsip(UserInfo.Sube.Id,FTIRSIP.DirektSatis);
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
        bool first = true;
        cmboxKasaKodu.Items.Clear();
        foreach (Kasa kas in kasalar)
        {
          cmboxKasaKodu.Items.Add(kas.Id);
          if (first)
          {
            cmboxKasaKodu.Text = kas.Id;
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

    private void frmDirektSatis_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter && this.ActiveControl!=txtBarkod)
      {
        SendKeys.Send("{TAB}");
      }
      else if (e.KeyCode == Keys.F5)
      {
        KalemKaydet();
      }
      else if (e.KeyCode == Keys.F7)
      {
        KalemSil();
      }
      else if (e.KeyCode == Keys.F3)
        YeniKalem();
      else if (e.KeyCode == Keys.F9)
      {
        KasayaKaydet();
      }
      else if (e.KeyCode == Keys.F10)
      {
        VeresiyeSatis();
      }
      else if (e.KeyCode == Keys.F11)
      {
        KrediKartiSatis();
      }
      else if (e.KeyCode == Keys.F1 || e.KeyCode==Keys.Up)
      {
        MiktarArtir();
      }
      else if (e.KeyCode == Keys.F2 || e.KeyCode==Keys.Down)
      {
        MiktarAzalt();
      } else if (e.KeyCode == Keys.Escape) {
          this.Close();
      }
    }
    void KalemKaydet()
    {
        bool isBegin = false;
      try
      {
        StokHareket sh = null;
        if (_selectedStokHarId != null)
        {
          sh = mngSth.GetById(_selectedStokHarId.Value, false);
        }
        if (sh == null)
          sh = new StokHareket();
        if (_currentStok == null)
          _currentStok = mngStk.GetBySubeAndBarkod1(UserInfo.Sube.Id,txtBarkod.Text);
        if (_currentStok == null)
          _currentStok = mngStk.GetById(txtBarkod.Text,false);
        
        if(_currentStok==null)
          return;
        sh.Stok = _currentStok;
        sh.BirimFiyat = txtSatisFiyat.Text.ParseNullable<double>(x => double.Parse(x));
        sh.HareketBirim = _currentStok.AnaBirim;
        sh.HareketMiktar = txtMiktar.Text.ParseStruct<double>(x => double.Parse(x));
        sh.GCMiktar = txtMiktar.Text.ParseStruct<double>(x => double.Parse(x));       
        sh.StharGckod = StokHareket.DetermineGCKodu(FTIRSIP.SatisFat);
        sh.StharHtur = StokHareket.DetermineHarTur(FatNoTip.Fatura);
        sh.FTIRSIP = FTIRSIP.DirektSatis;
        sh.Tarih =DateTime.Today;
        sh.Sube = UserInfo.Sube;
        sh.FisNo = _fisNo;
        sh.DirektSatis = "E";
        sh.Kdv = _currentStok.SatisKdvOrani;
        isBegin = true;
        mngSth.BeginTransaction();
        mngSth.SaveOrUpdate(sh);
       
        listeStok = mngSth.GetByFisNoAndSubeKodu(_fisNo, UserInfo.Sube.Id, FTIRSIP.DirektSatis);
        YeniKalem();
        LoadGrid();
        
        txtMiktar.Text="1";
      }
      catch (Exception)
      {
      } finally {
          try {
              if(isBegin)
                  mngSth.CommitTransaction();  
          } catch (Exception exc) {
              MessageBox.Show(exc.Message);
              LogWrite.Write(exc);
          }
      }
    }
    void LoadGrid()
    {
      try
      {
        dataGridView1.AutoGenerateColumns = false;
        IList<StokHarRpr> rpr = mngSth.GetByFisNoAndSubeKodu(_fisNo, UserInfo.Sube.Id);
        dataGridView1.DataSource = rpr;
        HesaplaGenelToplam hes = new HesaplaGenelToplam(rpr,true);
        txtGenelAraTop.Text = hes.AraToplam().ToString("F2");
        //txtGenelBrut.Text = hes.BrutHesapla().ToString("F2");
        txtGenelGenelTop.Text = hes.GenelToplam().ToString("F2");      
        txtGenelTopKdv.Text = hes.ToplamaKdvHesapla().ToString("F2");
        genelToplamlar = hes;
      }
      catch(Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      }
    }
    private void btnKaydet_Click(object sender, EventArgs e)
    {
      KalemKaydet();
    }
    void YeniKalem()
    {
      CleareForm.ClearThisConrol(groupBox2)
                       .NotClearTheseConrols(txtGenelAraTop,txtGenelGenelTop,txtGenelTopKdv, cmboxKasaKodu,txtMiktar
                       ,chbFaturaBas,cmbDizayn)
                       .BeginClear();
   
      txtMiktar.Text = "1";
      txtMiktar.Focus();
      labSecilenUrun.Text = "";
      //txtBarkod.Focus();
      _currentStok = null;
      _selectedStokHarId = null;
    }
    void HesaplaToplamlari()
    {
      try
      {
        //if (_currentStok == null)
        //  _currentStok = mngStk.GetById(txtBarkod.Text, false);
        //HesaplaToplam hes = new HesaplaToplam
        //{
        //  Fiyat = txtSatisFiyat.Text.ParseNullable<double>(x => double.Parse(x)),
        //  KdvDahil =true,
        //  Miktar =(double)nudMiktar.Value,
        //  Stok = _currentStok
        //};       
        //txtBrutToplam.Text = (hes.BrutHesapla()).ToString("F2");    
        //txtAraToplam.Text = (hes.AraToplam()).ToString("F2");
        //txtKdvToplam.Text = (hes.KdvHesapla()).ToString("F2");
        //txtGenelToplam.Text = (hes.GenelToplam()).ToString("F2");
      }
      catch (Exception exc)
      {
        LogWrite.Write(exc);
        MessageBox.Show(exc.Message);
      }
    }    
    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      try
      {
          if (dataGridView1.CurrentRow != null) {
             
              //txtStokKodu.Text = _selectedStokKodu = dataGridView1.CurrentRow.Cells["clStokKodu"].Value.ToStringOrEmpty();
              _currentStok = null;
              txtMiktar.Text = dataGridView1.CurrentRow.Cells["clMiktar"].Value.ToStringOrEmpty();
              txtSatisFiyat.Text = dataGridView1.CurrentRow.Cells["clFiyat"].Value.ToStringOrEmpty();

              txtBarkod.Text = dataGridView1.CurrentRow.Cells["clBarkod"].Value.ToStringOrEmpty();
              _selectedStokHarId = dataGridView1.CurrentRow.Cells["clId"].Value.ToString().ParseNullable<int>(x => int.Parse(x));
              txtTutar.Text =double.Parse( dataGridView1.CurrentRow.Cells["clTutar"].Value.ToStringOrEmpty()).ToString("F2");
              //txtMiktar.Focus() ;
             
              //txtStokMiktar.Text = mngSth.GetStokMiktar(txtStokKodu.Text).ToString();
              if (string.IsNullOrEmpty(txtBarkod.Text))
                  txtBarkod.Text = dataGridView1.CurrentRow.Cells[clStokKodu.Name].Value.ToStringOrEmpty();
              txtBarkod.Focus();
          }
      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      }
    }
    private void txtMiktar_TextChanged(object sender, EventArgs e) {
        try {
            HesaplaToplamlari();
            double d = txtSatisFiyat.Text.ParseStruct<double>(x => double.Parse(x));
            txtTutar.Text = ((txtMiktar.Text.ParseStruct<double>(x => double.Parse(x))) * d).ToString("F2");
        } catch (Exception exc) {
            MessageBox.Show(exc.Message);
            LogWrite.Write(exc);
        }
    }
    private void btnKaydet_Click_1(object sender, EventArgs e)
    {
      KalemKaydet();
    }    
    void KalemSil()
    {
        bool isBegin = false;
      try
      {
        DialogResult re = MessageBox.Show("Kayıt Silinsin mi?", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        if (re == DialogResult.Yes)
        {
          if (_selectedStokHarId != null)
          {
            StokHareket sh = mngSth.GetById(_selectedStokHarId.Value, false);
            isBegin = true;
            mngSth.BeginTransaction();
            mngSth.Delete(sh);
            
            HesaplaToplamlari();
            _selectedStokHarId = null;
            LoadGrid();
            YeniKalem();
          }
        }
      }
      catch (Exception )
      {
      } finally {
          try {
              if(isBegin)
                  mngSth.CommitTransaction();
          } catch (Exception exc) {
              MessageBox.Show(exc.Message);
              LogWrite.Write(exc);
          }
      }
    }
    private void btnKasaKaydet_Click(object sender, EventArgs e)
    {
      KasayaKaydet();
    }
    void VeresiyeSatis()
    {       
      bool isBegin = false;
      try
      {
          if (dataGridView1.Rows.Count > 0 && (!string.IsNullOrEmpty(dataGridView1.Rows[0].Cells[clFiyat.Name].Value.ToStringOrEmpty()))) {
              frmDirekSatisVeresiye frm = new frmDirekSatisVeresiye();
              frm.Owner = this;
              frm.ShowDialog();
              if (SatisYap) {
                  FatIrsUst _currentFatUst = new FatIrsUst();
                  _currentFatUst.FatirsNo = _fisNo;
                  _currentFatUst.FatTipi = FatTipi.AcikFat;
                  _currentFatUst.Ftirsip = FTIRSIP.DirektSatis;
                  _currentFatUst.KdvDahilmi = true;
                  _currentFatUst.Sube = UserInfo.Sube;
                  _currentFatUst.Tarih = DateTime.Today;
                  _currentFatUst.BrutTutar = genelToplamlar.BrutHesapla();
                  _currentFatUst.GenelToplam = genelToplamlar.GenelToplam();
                  _currentFatUst.KdvTutar = genelToplamlar.ToplamaKdvHesapla();
                  _currentFatUst.SatirIsk = genelToplamlar.SatirIskantosuToplam();

                  _currentFatUst.CariKodu = CariKodu;
                  _currentFatUst.VadeTarih = VadeTarih.JustDate();
                  _currentFatUst.Irsaliyeli = false;
                  //mngFatUst.BeginTransaction();
                  isBegin = true;
                  BeginTransaction();
                  mngFatUst.Save(_currentFatUst);
                  // mngFatUst.CommitTransaction();
                  CariHareket cahar = new CariHareket();
                  cahar.Borc = genelToplamlar.GenelToplam();
                  cahar.Cari = new Cari { Id = CariKodu };
                  cahar.FisNo = _fisNo;
                  cahar.HareketTuru = CariHarTuru.SatilanMal;
                  cahar.Sube = UserInfo.Sube;
                  cahar.Tarih = DateTime.Today;
                  cahar.VadeTarih = VadeTarih.JustDate();
                  mngCariHar.Save(cahar);
                  if (chbFaturaBas.Checked) {
                      Dizayn diz = (Dizayn)cmbDizayn.SelectedItem;
                      PrintFatIrs print = new PrintFatIrs(mng, _currentFatUst, diz, listeStok, genelToplamlar);
                      print.Print();
                  }
                  InitializeForm();
              }
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
            if(isBegin)
                CommitTransaction();
        }
        catch (Exception exc)
        {
          MessageBox.Show(exc.Message);
          LogWrite.Write(exc);
        }
      }
    }
    void KasayaKaydet() {
        if (string.IsNullOrEmpty(cmboxKasaKodu.Text)) {
            MessageBox.Show("Kasa kodunu seçiniz");
            cmboxKasaKodu.Focus();
            return;
        }
        bool isBegin = false;
        if (dataGridView1.Rows.Count>0 && (!string.IsNullOrEmpty(dataGridView1.Rows[0].Cells[clFiyat.Name].Value.ToStringOrEmpty()))) {
            try {
                if (chbFaturaBas.Checked) {
                    frmHizliCari frm = new frmHizliCari();
                    frm.Owner = this;
                    frm.ShowDialog();
                } else
                    SatisYap = true;
                if (SatisYap) {
                   
                    FatIrsUst _currentFatUst = new FatIrsUst();
                    _currentFatUst.FatirsNo = _fisNo;
                    _currentFatUst.FatTipi = FatTipi.KapaliFat;
                    _currentFatUst.Ftirsip = FTIRSIP.DirektSatis;
                    _currentFatUst.KdvDahilmi = true;
                    _currentFatUst.Sube = UserInfo.Sube;
                    _currentFatUst.Tarih = DateTime.Today;
                    _currentFatUst.BrutTutar = genelToplamlar.BrutHesapla();
                    _currentFatUst.GenelToplam = genelToplamlar.GenelToplam();
                    _currentFatUst.KdvTutar = genelToplamlar.ToplamaKdvHesapla();
                    _currentFatUst.SatirIsk = genelToplamlar.SatirIskantosuToplam();
                    _currentFatUst.KasaKodu = cmboxKasaKodu.Text;
                    _currentFatUst.Irsaliyeli = false;
                    _currentFatUst.CariKodu = KasaCariKodu;
                    //mngFatUst.BeginTransaction();
                    isBegin = true;
                    BeginTransaction();
                    mngFatUst.Save(_currentFatUst);
                    // mngFatUst.CommitTransaction();
                    KasaHareket kasaHar = new KasaHareket();
                    kasaHar.GelirGider = "G";
                    kasaHar.FisNo = _fisNo;
                    //kasaHar.Tip =KasaHareket.DetermineTip(KasaHarTip.MalSatis);
                    kasaHar.Tip = KasaHareket.DetermineTip(KasaHarTip.Fatura);
                    kasaHar.Kasa = mngKasa.GetById(cmboxKasaKodu.Text, false);
                    kasaHar.KdvTutar = genelToplamlar.ToplamaKdvHesapla();
                    kasaHar.Tutar = genelToplamlar.GenelToplam();
                    kasaHar.Tarih = DateTime.Today;
                    kasaHar.Sube = UserInfo.Sube;
                    kasaHar.DirektSatis = "E";
                    //mngKasaHar.BeginTransaction();
                    mngKasaHar.Save(kasaHar);
                    //mngKasaHar.CommitTransaction();
                    if (chbFaturaBas.Checked) {
                        Dizayn diz = (Dizayn)cmbDizayn.SelectedItem;
                        PrintFatIrs print = new PrintFatIrs(mng, _currentFatUst, diz, listeStok, genelToplamlar);
                        print.Print();
                    }
                    
                    InitializeForm();
                }
            } catch (Exception exc) {
                LogWrite.Write(exc);
                MessageBox.Show(exc.Message);
            } finally {
                try {
                    if(isBegin)
                        CommitTransaction();
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                    LogWrite.Write(exc);
                }
            }
        }
    }
    void InitializeForm()
    {
      dataGridView1.DataSource = null;
      CleareForm.ClearThisConrol(this).NotClearTheseConrols(cmboxKasaKodu,txtMiktar,chbFaturaBas,cmbDizayn).BeginClear();
      YeniKalem();
      _fisNo = string.Empty;
      SetFisNo();
      //nudMiktar.Value = 1;
      //nudMiktar.Focus();
      txtMiktar.Text = "1";
      txtMiktar.Focus();
      txtBarkod.Focus();
      SatisYap = false;
      KasaCariKodu = string.Empty;
    }
    private void btnYeniKalem_Click(object sender, EventArgs e)
    {
      YeniKalem();
    }

    private void btnKalemSil_Click(object sender, EventArgs e)
    {
      KalemSil();
    }
    private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
    {
      if (!string.IsNullOrEmpty(txtBarkod.Text) && (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter))
      {
        try
        {

          //if (_currentStok == null)
            _currentStok = mngStk.GetBySubeAndBarkod1(UserInfo.Sube.Id, txtBarkod.Text);
          if (_currentStok == null)
            _currentStok = mngStk.GetById(txtBarkod.Text, false);
          if (_currentStok != null)
          {
            //txtStokKodu.Text = _currentStok.Id;
              if(string.IsNullOrEmpty(txtSatisFiyat.Text.Trim()) || txtSatisFiyat.Text.Trim()=="0")
                  txtSatisFiyat.Text = _currentStok.SatisFiyat1.GetValueOrDefault().ToString();
            txtSatisFiyat.Focus();
            labSecilenUrun.Text = string.Format("{0} {1}",_currentStok.Id,_currentStok.StokAdi);
           // KalemKaydet();
            //YeniKalem();
          }
        }
        catch (Exception exc)
        {
          MessageBox.Show(exc.Message);
          LogWrite.Write(exc);
        }
      }
   
    }
    private void txtStokKodu_KeyUp(object sender, KeyEventArgs e)
    {
      //if (!string.IsNullOrEmpty(txtStokKodu.Text) && e.KeyCode == Keys.Tab)
      //{
      //  try
      //  {
      //    _currentStok = mngStk.GetById(txtStokKodu.Text, false);
      //    if (_currentStok != null)
      //    {           
      //      txtBarkod.Text = _currentStok.Barkod1;

      //      if (_selectedStokHarId == null || _selectedStokKodu != txtStokKodu.Text)
      //      {             
      //        txtSatisFiyat.Text = _currentStok.Satisfiyat.FromNullableToString("F2");
      //      }
      //      txtSatisFiyat.Focus();
      //    }
      //  }
      //  catch (Exception exc)
      //  {
      //    MessageBox.Show(exc.Message);
      //    LogWrite.Write(exc);
      //  }
      //}
    }

    private void btnMiktarArti_Click(object sender, EventArgs e)
    {
      MiktarArtir();
    }
    void MiktarArtir()
    {
      try
      {
        if (string.IsNullOrEmpty(txtMiktar.Text))
        {
          txtMiktar.Text = "1";
          //txtBarkod.Focus();
          HesaplaTutarFiyat();
        }
        else
        {
          double d = txtMiktar.Text.ParseStruct<double>(x => double.Parse(x));
          d += 1;
          txtMiktar.Text = d.ToString();
          HesaplaTutarFiyat();
          //txtBarkod.Focus();
        }
      }
      catch (Exception exc)
      {
        LogWrite.Write(exc);
        MessageBox.Show(exc.Message);
      }
    }
    void HesaplaTutarFiyat() {
        if (!string.IsNullOrEmpty(txtSatisFiyat.Text) && !string.IsNullOrEmpty(txtMiktar.Text)) {
            double d = txtMiktar.Text.ParseStruct<double>(x => double.Parse(x));
            double s = txtSatisFiyat.Text.ParseStruct<double>(x => double.Parse(x));
            double f = d * s;
            txtTutar.Text = f.ToString("F2");
        } else {
            txtTutar.Text = "";
        }
    }
    void MiktarAzalt()
    {
      try
      {  
       
        double d = txtMiktar.Text.ParseStruct<double>(x => double.Parse(x));
        if (d > 1)
        {
          d -= 1;
          txtMiktar.Text = d.ToString();
        }
        HesaplaTutarFiyat();
        //txtBarkod.Focus();
      }
      catch (Exception exc)
      {
        LogWrite.Write(exc);
        MessageBox.Show(exc.Message);
      }
    }
    private void btnMiktarEksi_Click(object sender, EventArgs e)
    {
      MiktarAzalt();
    }

    private void tsbtnKalemKaydet_Click(object sender, EventArgs e)
    {
      KalemKaydet();
    }

    private void tsbtnKalemSil_Click(object sender, EventArgs e)
    {
      KalemSil();
    }

    private void tsbtnKasayaAktar_Click(object sender, EventArgs e)
    {
      KasayaKaydet();
    }

    private void txtBarkod_KeyUp(object sender, KeyEventArgs e)
    {
      //if (!string.IsNullOrEmpty(txtBarkod.Text) && (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter))
      //{

      //  if (_currentStok == null)
      //    _currentStok = mngStk.GetBySubeAndBarkod1(UserInfo.Sube.Id, txtBarkod.Text);
      //  if (_currentStok == null)
      //    _currentStok = mngStk.GetById(txtBarkod.Text, false);
      //  if (_currentStok != null)
      //  {
      //    //txtStokKodu.Text = _currentStok.Id;
      //    txtSatisFiyat.Text = _currentStok.Satisfiyat.GetValueOrDefault().ToString();
      //    KalemKaydet();
      //    YeniKalem();
      //  }
      //}
    }

    private void txtBarkod_KeyPress(object sender, KeyPressEventArgs e)
    {
      //if (!string.IsNullOrEmpty(txtBarkod.Text) && (e.KeyChar == (char)Keys.Tab || e.KeyChar == (char)Keys.Enter))
      //{

      //  if (_currentStok == null)
      //    _currentStok = mngStk.GetBySubeAndBarkod1(UserInfo.Sube.Id, txtBarkod.Text);
      //  if (_currentStok == null)
      //    _currentStok = mngStk.GetById(txtBarkod.Text, false);
      //  if (_currentStok != null)
      //  {
      //    //txtStokKodu.Text = _currentStok.Id;
      //    txtSatisFiyat.Text = _currentStok.Satisfiyat.GetValueOrDefault().ToString();
      //    KalemKaydet();
      //    YeniKalem();
      //  }
      //}
    }

    private void tsbtnVeresiye_Click(object sender, EventArgs e)
    {
      VeresiyeSatis();
    }
    void KrediKartiSatis() {
        if (dataGridView1.Rows.Count > 0 && (!string.IsNullOrEmpty(dataGridView1.Rows[0].Cells[clFiyat.Name].Value.ToStringOrEmpty()))) {
            bool isBegin = false;
            try {
                frmDirektSatisKrediKarti frm = new frmDirektSatisKrediKarti();
                frm.Owner = this;
                frm.ShowDialog();
                if (SatisYap) {
                    FatIrsUst _currentFatUst = new FatIrsUst();
                    _currentFatUst.FatirsNo = _fisNo;
                    _currentFatUst.FatTipi = FatTipi.KrediKarti;
                    _currentFatUst.Ftirsip = FTIRSIP.DirektSatis;
                    _currentFatUst.KdvDahilmi = true;
                    _currentFatUst.Sube = UserInfo.Sube;
                    _currentFatUst.Tarih = DateTime.Today;
                    _currentFatUst.BrutTutar = genelToplamlar.BrutHesapla();
                    _currentFatUst.GenelToplam = genelToplamlar.GenelToplam();
                    _currentFatUst.KdvTutar = genelToplamlar.ToplamaKdvHesapla();
                    _currentFatUst.SatirIsk = genelToplamlar.SatirIskantosuToplam();

                    _currentFatUst.HesapNo = HesapNo;

                    _currentFatUst.Irsaliyeli = false;
                    //mngFatUst.BeginTransaction();
                    isBegin = true;
                    BeginTransaction();
                    mngFatUst.Save(_currentFatUst);
                    // mngFatUst.CommitTransaction();
                    HesapHareket hesapHar = new HesapHareket();
                    hesapHar.Aciklama = _fisNo + " no ile direkt satış kredi kartı ile";
                    hesapHar.BankaHesap = mngBanka.GetByHesapNo(UserInfo.Sube.Id, HesapNo);
                    hesapHar.FisNo = _fisNo;
                    hesapHar.HareketTuru = HesapHareketTuru.KrediKarti;
                    hesapHar.Sube = UserInfo.Sube;
                    hesapHar.Tarih = DateTime.Today;
                    hesapHar.Tutar = genelToplamlar.GenelToplam();
                    mngHesapHar.Save(hesapHar);
                    if (chbFaturaBas.Checked) {
                        Dizayn diz = (Dizayn)cmbDizayn.SelectedItem;
                        PrintFatIrs print = new PrintFatIrs(mng, _currentFatUst, diz, listeStok, genelToplamlar);
                        print.Print();
                    }
                    InitializeForm();
                }
            } catch (Exception exc) {
                LogWrite.Write(exc);
                MessageBox.Show(exc.Message);
            } finally {
                try {
                    if(isBegin)
                        CommitTransaction();
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                    LogWrite.Write(exc);
                }
            }
        }
    }
    private void tsbtnKrediKarti_Click(object sender, EventArgs e)
    {
      KrediKartiSatis();
    }

    private void tsbtnSatisiptal_Click(object sender, EventArgs e)
    {
      frmFatura frm = new frmFatura(FTIRSIP.DirektSatis, FatNoTip.Fatura);
      frm.WindowState = FormWindowState.Maximized;
      frm.Show();
    }

    private void tsbtnKapat_Click(object sender, EventArgs e) {
        this.Close();
    }

    private void btnListe_Click(object sender, EventArgs e) {
        LoadKasa();
    }

    private void txtSatisFiyat_KeyDown(object sender, KeyEventArgs e) {
        if (!string.IsNullOrEmpty(txtSatisFiyat.Text)  && (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)) {
            try {

                if (_currentStok == null)
                    _currentStok = mngStk.GetBySubeAndBarkod1(UserInfo.Sube.Id, txtBarkod.Text);
                if (_currentStok == null)
                    _currentStok = mngStk.GetById(txtBarkod.Text, false);
                if (_currentStok != null) {
                    //txtStokKodu.Text = _currentStok.Id;
                    //txtSatisFiyat.Text = _currentStok.SatisFiyat1.GetValueOrDefault().ToString();
                    KalemKaydet();
                    //YeniKalem();
                }
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }
    }

    private void txtSatisFiyat_TextChanged(object sender, EventArgs e) {
        try {
            HesaplaTutarFiyat();
        } catch (Exception exc) {
            LogWrite.Write(exc);
            MessageBox.Show(exc.Message);
        }
    }

    private void tsbtnYeniKayit_Click(object sender, EventArgs e) {
        YeniKalem();
    }

    private void frmDirektSatis_FormClosing(object sender, FormClosingEventArgs e) {
        if (dataGridView1.Rows.Count > 0 && (!string.IsNullOrEmpty(dataGridView1.Rows[0].Cells[clFiyat.Name].Value.ToStringOrEmpty()))) {
            try {
                mngSth.TopluHareketSil(_fisNo,FTIRSIP.DirektSatis);
            } catch { }
        }
    }

    private void btnRehber_Click(object sender, EventArgs e) {
        frmStokSearch frm = new frmStokSearch();
        frm.Owner = this;
        frm.Show();
        txtBarkod.Focus();
    }

   
  }
}
