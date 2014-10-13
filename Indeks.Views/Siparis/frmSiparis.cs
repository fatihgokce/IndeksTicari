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
  public partial class frmSiparis : BaseFatSip
  {
   
   
    ISiparisKalemManager mngSipKal;
    ISiparisUstManager mngSipUst;   

    //IStokManager mngStk;
    //IStokHareketManager mngSth;
    //ICariManager mngCari;    
  
    IDizaynManager mngDizayn;
    int? _selectedSipKalId = null;
    string _selectedStokKodu = string.Empty;

    //Stok _currentStok = null;
    SiparisUst _currentSipUst = null;
    //HesaplaGenelToplam genelToplamlar;
    //IList<StokHarRpr> listeStok;
    public frmSiparis(FTIRSIP ftirsip):base()
    {
      InitializeComponent();

      this._ftirsip = ftirsip;
  
      //mng = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
      mngSipUst = mng.GetSiparisUstManager();
      mngSipKal = mng.GetSiparisKalemManager();
      //mngStk = mng.GetStokManager();
      //mngCari = mng.GetCariManager();
      //mngSth = mng.GetStokHareketManager();
     
      mngDizayn = mng.GetDizaynManager();
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
          return mngCari.GetCariKodsBySubeKodu(UserInfo.Sube.Id, txtCari.Text, ftirsip).ToStringList(15,txtCari.Ayirac);
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
          return mngSipUst.GetByBelgeTipAndSubeKodu(UserInfo.Sube.Id, _ftirsip, txtFatNo.Text);
        }
        catch (Exception exc)
        {
          MessageBox.Show(exc.Message);
          LogWrite.Write(exc);
        }
        return null;
      };

      GetLastArtiSipNo();
      this.Focus();
      txtFatNo.Focus();
      //txtFatNo.SelectAll();
      txtFatNo.SelectionStart = txtFatNo.Text.Length;
      LoadDizayn();
      dateTarih.initializeTimePiceker();
      dtTeslimTarih.initializeTimePiceker();
      filterDataGridView1.grd.CellClick += new DataGridViewCellEventHandler(grd_CellClick);
    }

    void grd_CellClick(object sender, DataGridViewCellEventArgs e) {
        try {
            if (filterDataGridView1.grd.CurrentRow != null) {
                DataGridViewRow currentRow = filterDataGridView1.grd.CurrentRow;
                txtStokKodu.Text = _selectedStokKodu = currentRow.Cells["clStokKodu"].Value.ToStringOrEmpty();
                _currentStok = mngStk.GetById(_selectedStokKodu, false);
                DoldurStokBirimleri(_currentStok, cmbBirim);
                txtStokIsmi.Text = currentRow.Cells["clStokAdi"].Value.ToStringOrEmpty();
                txtMiktar.Text = currentRow.Cells["clMiktar"].Value.ToStringOrEmpty();
                cmbBirim.Text = currentRow.Cells[clHareketBirim.Name].Value.ToStringOrEmpty();
                txtFyt.Text = currentRow.Cells["clFiyat"].Value.ToStringOrEmpty();
                txtIsk1.Text = currentRow.Cells["clIsk1"].Value.ToStringOrEmpty();
                txtIsk2.Text = currentRow.Cells["clIsk2"].Value.ToStringOrEmpty();
                txtIsk3.Text = currentRow.Cells["clIsk3"].Value.ToStringOrEmpty();
                txtIsk4.Text = currentRow.Cells["clIsk4"].Value.ToStringOrEmpty();
                txtIsk5.Text = currentRow.Cells["clIsk5"].Value.ToStringOrEmpty();
                txtBarkod.Text = currentRow.Cells["clBarkod"].Value.ToStringOrEmpty();
                _selectedSipKalId = currentRow.Cells["clId"].Value.ToString().ParseNullable<int>(x => int.Parse(x));
                txtTutar.Text = currentRow.Cells["clTutar"].Value.ToStringOrEmpty();
                txtBarkod.Focus();
                txtStokMiktar.Text = mngSth.GetStokMiktar(txtStokKodu.Text).ToString();
                txtKdv.Text = currentRow.Cells[clKdvOrani.Name].Value.ToStringOrEmpty();
            }
        } catch (Exception exc) {
            MessageBox.Show(exc.Message);
            LogWrite.Write(exc);
        }
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
    void GetLastArtiSipNo()
    {
      try
      {
        txtFatNo.Text = mngSipUst.GetLastArtiOneSipNoBySubeKoduAndFtirsip(UserInfo.Sube.Id, _ftirsip);
        txtFatNo.Focus();
        txtFatNo.SelectionStart = txtFatNo.Text.Length;
      }
      catch (Exception exc)
      {
        LogWrite.Write(exc);
        MessageBox.Show(exc.Message);
      }
    }
    void KalemKaydet()
    {
        try {
            SiparisKalem kalem = null;
            if (_selectedSipKalId != null) {
                kalem = mngSipKal.GetById(_selectedSipKalId.Value, false);
            }
            if (kalem == null)
                kalem = new SiparisKalem();
            if (_currentStok == null)
                _currentStok = mngStk.GetById(txtStokKodu.Text, false);
            kalem.Stok = _currentStok;
            kalem.BirimFiyat = txtFyt.Text.ParseNullable<double>(x => double.Parse(x));
            kalem.FisNo = txtFatNo.Text;
            kalem.HareketBirim = cmbBirim.Text;
            if (string.IsNullOrEmpty(cmbBirim.Text)) {
                kalem.GCMik = txtMiktar.Text.ParseStruct<double>(x => double.Parse(x));
                kalem.HareketMiktar = kalem.GCMik;
            } else if (cmbBirim.Text.Trim() == _currentStok.AnaBirim.Trim()) {
                kalem.GCMik = txtMiktar.Text.ParseStruct<double>(x => double.Parse(x));
                kalem.HareketMiktar = kalem.GCMik;
            } else if (cmbBirim.Text.Trim() == _currentStok.AltBirim1.Trim()) {
                kalem.HareketMiktar = txtMiktar.Text.ParseNullable<double>(x => double.Parse(x));
                kalem.GCMik = kalem.HareketMiktar.GetValueOrDefault() * _currentStok.Carpan1.GetValueOrDefault();
            } else if (cmbBirim.Text.Trim() == _currentStok.AltBirim2.Trim()) {
                kalem.HareketMiktar = txtMiktar.Text.ParseNullable<double>(x => double.Parse(x));
                kalem.GCMik = kalem.HareketMiktar.GetValueOrDefault() * _currentStok.Carpan2.GetValueOrDefault();
            } else if (cmbBirim.Text.Trim() == _currentStok.AltBirim3.Trim()) {
                kalem.HareketMiktar = txtMiktar.Text.ParseNullable<double>(x => double.Parse(x));
                kalem.GCMik = kalem.HareketMiktar.GetValueOrDefault() * _currentStok.Carpan3.GetValueOrDefault();
            }
            if (string.IsNullOrEmpty(kalem.HareketBirim.Trim()))
                kalem.HareketBirim = _currentStok.AnaBirim.Trim();
            kalem.GCMik = txtMiktar.Text.ParseStruct<double>(x => double.Parse(x));
            kalem.Isk1 = txtIsk1.Text.ParseStruct<double>(x => double.Parse(x));
            kalem.Isk2 = txtIsk2.Text.ParseStruct<double>(x => double.Parse(x));
            kalem.Isk3 = txtIsk3.Text.ParseStruct<double>(x => double.Parse(x));
            kalem.Isk4 = txtIsk4.Text.ParseStruct<double>(x => double.Parse(x));
            kalem.Isk5 = txtIsk5.Text.ParseStruct<double>(x => double.Parse(x));
            //kalem.KdvOrani = _currentStok.KdvOrani.GetValueOrDefault();
            kalem.KdvOrani= txtKdv.Text.ParseStruct<double>(x => double.Parse(x));
            kalem.GCKod = StokHareket.DetermineGCKodu(_ftirsip);

            kalem.Ftirsip = _ftirsip;
            kalem.Tarih = dateTarih.Text.ToDate();

            kalem.Sube = UserInfo.Sube;
            mngSipKal.BeginTransaction();
            mngSipKal.SaveOrUpdate(kalem);
           
            _currentStok = null;
            _selectedSipKalId = null;
            LoadSiparisToGrid();
            YeniKalem();
        } catch (Exception exc) {
            LogWrite.Write(exc);
            MessageBox.Show(exc.Message);
        } finally {
            try {
                mngSipKal.CommitTransaction();
            } catch (Exception exc) {
                LogWrite.Write(exc);
                MessageBox.Show(exc.Message);
            }
        }
    }
    void LoadSiparisToGrid()
    {
      try
      {
       
        //dataGridView1.AutoGenerateColumns = false;
        //dataGridView1.Columns[clTutar.Name].DefaultCellStyle.Format = "F2";

        filterDataGridView1.grd.AutoGenerateColumns = false;
        filterDataGridView1.grd.Columns[clTutar.Name].DefaultCellStyle.Format = "F2";
        IList<StokHarRpr> rpr = mngSipKal.GetByFisNoAndSubeKodu(txtFatNo.Text, UserInfo.Sube.Id, _ftirsip);
        //dataGridView1.DataSource = rpr;
        filterDataGridView1.grd.DataSource = rpr;
        listeStok = rpr;
        filterDataGridView1.KayitSayisi = rpr.Count;
        if (rpr.Count == 0)
        {
          btnFatKaydet.Enabled = false;
          btnFaturalastir.Enabled = false;
          btnFatSil.Enabled = false;
          btnIrsaliyestir.Enabled = false;
        }
        else
        {
          btnFatKaydet.Enabled = true;
          btnFaturalastir.Enabled = true;
          btnFatSil.Enabled = true;
          btnIrsaliyestir.Enabled = true;
        }
      
        HesaplaGenelToplamlari(rpr);
      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
      }
    }
    void HesaplaGenelToplamlari(IList<StokHarRpr> stokListe)
    {
      try
      {
        if (stokListe == null)
          stokListe = mngSipKal.GetByFisNoAndSubeKodu(txtFatNo.Text, UserInfo.Sube.Id, _ftirsip);
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
    void YeniKalem()
    {
      CleareForm.ClearThisConrol(groupBox2)
                       .NotClearTheseConrols(grboxGenelToplam, cmbDizayn)
                       .BeginClear();
      //ClearFormData(groupBox2);
      // txtStokKodu.Focus();
      txtBarkod.Focus();
      cmbBirim.Items.Clear();
      _currentStok = null;
      _selectedSipKalId = null;
    }
    void KalemSil()
    {
      try
      {
        DialogResult re = MessageBox.Show("Kayıt Silinsin mi?", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        if (re == DialogResult.Yes)
        {
          if (_selectedSipKalId != null)
          {
            SiparisKalem sh = mngSipKal.GetById(_selectedSipKalId.Value, false);
            BeginTransaction();
            mngSipKal.Delete(sh);
           
            HesaplaToplamlari();
            _selectedSipKalId = null;
            LoadSiparisToGrid();
            YeniKalem();
          }
        }
      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      } finally {
          try {
              CommitTransaction();
          } catch (Exception exc) {
              LogWrite.Write(exc);
              MessageBox.Show(exc.Message);
          }
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

    private void frmSiparis_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter) {
            SendKeys.Send("{TAB}");
        } else if (e.KeyCode == Keys.F5) {
            KalemKaydet();
        } else if (e.KeyCode == Keys.F7) {
            KalemSil();
        } else if (e.KeyCode == Keys.F3)
            YeniKalem();
        else if (e.Alt && e.KeyCode == Keys.K)
            SiparisKaydet();
        else if (e.Alt && e.KeyCode == Keys.S)
            SiparisSil();
        else if (e.Alt && e.KeyCode == Keys.Y)
            YeniSiparis();
    }
    //void DoldurStokBirimleri(Stok stok)
    //{
    //  cmbBirim.Items.Clear();
    //  if (!string.IsNullOrEmpty(stok.AnaBirim))
    //  {
    //    cmbBirim.Items.Add(stok.AnaBirim.Trim());
    //    cmbBirim.Text = stok.AnaBirim.Trim();
    //  }
    //  if (!string.IsNullOrEmpty(stok.AltBirim1))
    //    cmbBirim.Items.Add(stok.AltBirim1.Trim());
    //  if (!string.IsNullOrEmpty(stok.AltBirim2))
    //    cmbBirim.Items.Add(stok.AltBirim2.Trim());
    //  if (!string.IsNullOrEmpty(stok.AltBirim3))
    //    cmbBirim.Items.Add(stok.AltBirim3.Trim());
    //}
    void SetFiyat()
    {
        try {
            DoldurStokBirimleri(_currentStok, cmbBirim);
            txtStokMiktar.Text = mngSth.GetStokMiktar(txtStokKodu.Text).ToString();

            if (FTIRSIP.SaticiSip == _ftirsip) {
                txtKdv.Text = _currentStok.AlisKdvOrani.ToString();
                if (!string.IsNullOrEmpty(txtCari.Text)) {
                    Cari cari = mngCari.GetById(txtCari.Text, false);
                    if (cari != null && !string.IsNullOrEmpty(cari.SatisFiyatKod)) {
                        txtFyt.Text = GetCariFiyat(cari, _currentStok, true);
                    } else
                        txtFyt.Text = _currentStok.AlisFiyat1.FromNullableToString();
                } else
                    txtFyt.Text = _currentStok.AlisFiyat1.FromNullableToString();
            } else if (FTIRSIP.MusSip == _ftirsip) {
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
            LogWrite.Write(exc);
            MessageBox.Show(exc.Message);
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
            txtKdv.Text = _currentStok.KdvOrani.FromNullableToString();
            if (_selectedSipKalId == null || _selectedStokKodu != txtStokKodu.Text)
            {        
              SetFiyat();
            }
            cmbBirim.Focus() ;
          }
          else
          {
            frmStok frm = new frmStok(this, _ftirsip);
            txtStokKodu.CloseAutoComplete();
            frm.txtStokIsmi.Focus();
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
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
            if (dataGridView1.CurrentRow != null) {
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
                _selectedSipKalId = dataGridView1.CurrentRow.Cells["clId"].Value.ToString().ParseNullable<int>(x => int.Parse(x));
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

    private void txtFatNo_KeyUp(object sender, KeyEventArgs e)
    {
      if (!string.IsNullOrEmpty(txtFatNo.Text) && (e.KeyCode == Keys.Tab || e.KeyCode==Keys.Enter))
      {
        try
        {
          
          _currentSipUst = mngSipUst.GetByBelgeNoBelgeTipAndSubeKodu(txtFatNo.Text, _ftirsip, UserInfo.Sube.Id);
          if (_currentSipUst != null)
          {
            CleareForm.ClearThisConrol(this).BeginClear();
            dataGridView1.DataSource = null;
            txtFatNo.Text = _currentSipUst.FatirsNo;
            txtCari.Text = _currentSipUst.CariKodu;
            dtTeslimTarih.Text = _currentSipUst.TeslimTarih.ToString("d");
            dateTarih.Text = _currentSipUst.Tarih.ToString("d");
            chkKdvDahilmi.Checked = _currentSipUst.KdvDahilmi;
            dateVadeTarihi.Value = _currentSipUst.VadeTarih.Value;
            btnFatKaydet.Enabled = true;
            btnIrsaliyestir.Enabled = true;
            if (_currentSipUst.Kapatilmis)
            {
              MessageBox.Show(_currentSipUst.FatirsNo +" numaralı sipariş kapatılmış.");
            }
            LoadSiparisToGrid();
          }
          else
          {
            string str = txtFatNo.Text;
            InitializeForm();
            txtFatNo.Text = str;
          }
          txtCari.Focus();

        }
        catch (Exception exc)
        {
          MessageBox.Show(exc.Message);
          LogWrite.Write(exc);
        }
       
      }
    }
    void SiparisKaydet() {
        try {
            if (_currentSipUst == null)
                _currentSipUst = new SiparisUst();
            _currentSipUst.FatirsNo = txtFatNo.Text;
            _currentSipUst.TeslimTarih = dtTeslimTarih.Text.ToDate();
            _currentSipUst.Ftirsip = _ftirsip;
            _currentSipUst.KdvDahilmi = chkKdvDahilmi.Checked;
            _currentSipUst.Sube = UserInfo.Sube;
            _currentSipUst.Tarih = dateTarih.Text.ToDate();
            _currentSipUst.BrutTutar = genelToplamlar.BrutHesapla();
            _currentSipUst.GenelToplam = genelToplamlar.GenelToplam();
            _currentSipUst.KdvTutar = genelToplamlar.ToplamaKdvHesapla();
            _currentSipUst.SatirIsk = genelToplamlar.SatirIskantosuToplam();
            if (!CariVarmi(txtCari.Text)) {
                if (OtomatikCariKaydedilsin()) {
                    CariKaydet(txtCari.Text);
                } else {
                    MessageBox.Show("Geçerli bir cari kodu giriniz");
                    return;
                }
            }
            _currentSipUst.CariKodu = txtCari.Text;
            _currentSipUst.VadeTarih = dateVadeTarihi.Value.JustDate();
            mngSipUst.BeginTransaction();
            mngSipUst.SaveOrUpdate(_currentSipUst);
           

            if (cbFaturaBas.Checked) {
                //Dizayn diz = (Dizayn)cmbDizayn.SelectedItem;
                //PrintFatIrs print = new PrintFatIrs(mng, _currentSipUst, diz, listeStok, genelToplamlar);
                //print.Print();
            }
            InitializeForm();
            GetLastArtiSipNo();


        } catch (Exception exc) {
            LogWrite.Write(exc);
            MessageBox.Show(exc.Message);
        } finally {
            try {
                mngSipUst.CommitTransaction();
            } catch (Exception exc) {
                LogWrite.Write(exc);
                MessageBox.Show(exc.Message);
            }
        }
    }
    private void btnFatKaydet_Click(object sender, EventArgs e)
    {
        SiparisKaydet();
    }
    void InitializeForm()
    {
      dataGridView1.DataSource = null;
      YeniKalem();
      _currentSipUst = null;
      _currentStok = null;
      _selectedSipKalId = null;
      _selectedStokKodu = "";
      dateVadeTarihi.Value = DateTime.Today;
      CleareForm.ClearThisConrol(this).BeginClear();      
    }

    private void btnKalemKaydet_Click(object sender, EventArgs e)
    {
      KalemKaydet();
    }

    private void btnKalemSil_Click(object sender, EventArgs e)
    {
      KalemSil();
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
    private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
    {
      if (/*!string.IsNullOrEmpty(txtBarkod.Text) && */(e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter))
      {
        try
        {
          if (!string.IsNullOrEmpty(txtBarkod.Text))
          {
            if (_currentStok == null)
            {
              _currentStok = mngStk.GetBySubeAndBarkod1(UserInfo.Sube.Id, txtBarkod.Text);
              if (_currentStok != null)
              {
               
                txtStokIsmi.Text = _currentStok.StokAdi;
                txtStokKodu.Text = _currentStok.Id;
                txtKdv.Text = _currentStok.KdvOrani.FromNullableToString();
                if (_selectedSipKalId == null || _selectedStokKodu != txtStokKodu.Text)
                {
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

    private void btnFatRehber_Click(object sender, EventArgs e)
    {
      frmFatRehber frm = new frmFatRehber(this, _ftirsip);
      frm.Owner = this;
      frm.WindowState = FormWindowState.Maximized;
      frm.Show();
      txtFatNo.Focus();
    }

    private void txtMiktar_TextChanged(object sender, EventArgs e) {
        try {
            HesaplaToplamlari();
            double d = txtFyt.Text.ParseStruct<double>(x => double.Parse(x));
            txtTutar.Text = ((txtMiktar.Text.ParseStruct<double>(x => double.Parse(x))) * d).ToString("F2");
        } catch (Exception exc) {
            LogWrite.Write(exc);
            MessageBox.Show(exc.Message);
        }
    }

    private void txtCari_KeyUp(object sender, KeyEventArgs e)
    {     
       
      if (!string.IsNullOrEmpty(txtCari.Text) && e.KeyCode == Keys.Tab) {
          try {
              Cari cari = mngCari.GetById(txtCari.Text, false);
              if (cari == null) {
                  frmCari frm = new frmCari();
                  frm.Owner = this;
                  frm.txtCariKodu.Text = txtCari.Text;
                  frm.txtCariKodu.Focus();
                  frm.ShowDialog();
              } else {
                  dateTarih.Focus();
              }
          } catch (Exception exc) {
              MessageBox.Show(exc.Message);
              LogWrite.Write(exc);
          }
      }
    }
    void SiparisSil() {
         bool isBegin = false;
        try {
           
            if (_currentSipUst != null) {
                DialogResult re = MessageBox.Show("Kayıt Silinsin mi?", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (re == DialogResult.Yes) {
                    isBegin = true;
                    mngSipKal.TopluKalemSil(_currentSipUst.FatirsNo, _ftirsip);
                    BeginTransaction();
                    mngSipUst.Delete(_currentSipUst);
                   
                    //mngSipUst.CommitTransaction();
                  
                }
            }
        } catch (Exception) {
        } finally {
            try {
                if (isBegin) { 
                    mngSipUst.Delete(_currentSipUst);
                    CommitTransaction();
                    InitializeForm();
                    GetLastArtiSipNo();
                }
            } catch (Exception exc) {
                LogWrite.Write(exc);
                MessageBox.Show(exc.Message);
            }
        }
    }
    private void btnFatSil_Click(object sender, EventArgs e)
    {
        SiparisSil();
    }

    private void btnStokRehber_Click(object sender, EventArgs e)
    {
      frmStokSearch frm = new frmStokSearch(_ftirsip);
      frm.Owner = this;
      frm.Show();
      txtStokKodu.Focus();
    }

    private void btnFaturalastir_Click(object sender, EventArgs e) {
        if (_currentSipUst != null && !_currentSipUst.Kapatilmis) {
            FTIRSIP desFtir = FTIRSIP.MusSip == _ftirsip ? FTIRSIP.SatisFat : FTIRSIP.AlisFat;
            frmFatura frm = new frmFatura(desFtir, _currentSipUst, FatNoTip.Fatura, listeStok);
            frm.WindowState = FormWindowState.Maximized;
            frm.txtBarkod.Focus();
            frm.ShowDialog();
            YeniSiparis();
        }
    }

    private void btnIrsaliyestir_Click(object sender, EventArgs e) {
        if (_currentSipUst != null && !_currentSipUst.Kapatilmis) {
            FTIRSIP desFtir = FTIRSIP.MusSip == _ftirsip ? FTIRSIP.SatisIrs : FTIRSIP.AlisIrs;
            frmFatura frm = new frmFatura(desFtir, _currentSipUst, FatNoTip.Irsaliye, listeStok);
            frm.WindowState = FormWindowState.Maximized;
            frm.txtBarkod.Focus();
            frm.ShowDialog();
            YeniSiparis();
        }
    }

    private void chkKdvDahilmi_CheckedChanged(object sender, EventArgs e)
    {
      HesaplaToplamlari();
      HesaplaGenelToplamlari(null);
    }
    void YeniSiparis() {
        InitializeForm();
        GetLastArtiSipNo();
    }
    private void btnYeni_Click(object sender, EventArgs e) {
        YeniSiparis();
    }  
  }
}
