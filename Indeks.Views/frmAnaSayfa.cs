using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Indeks.Data.BusinessObjects;
using Indeks.Data.Helper;
using Indeks.Views.Helper;
using Indeks.Views.Models;
using Indeks.Data.Base;
using Indeks.Data.ManagerObjects;
using System.IO;
using System.Diagnostics;
namespace Indeks.Views
{
  public partial class frmAnaSayfa : BaseForm
  {
    //bool firsLoad = true;


    ScreenState g_screenState;
    AyarlarManager _mngAyar;
    bool first = true;
  
    private readonly string[] FORM_NAMES={"STOK","FATURA"};
    public frmAnaSayfa():base()
    {
        
      InitializeComponent();
      first = true;
      _mngAyar = new AyarlarManager(UserInfo.Sube.Id);
      InitializeScreenValues();
      g_screenState.ChangeTo(Engine.FindSettings().Paket);    
      //backgroundWorker1.RunWorkerAsync();
    
    
    
      this.Text = "IndeksTicari" + "-" + UserInfo.Sube.Id.ToString() + "-" + UserInfo.Sube.SubeIsmi;

      /*
       -Analizler
       * Ciro,Envanter,Gün Özeti,StokHareket Kontrol,Genel Kar/Zarar Analizi,Mali Envanter
       * ,Birim GelirGider Analizi,
       -Yardımcı Proğramlar
       * Şube Açma,Kullnanıcı Kaydetme
       */
      //labVersiyon.Text = "Versiyon:{0}".With(Engine.Versiyon());
      Uyar();
     
    }
    void Uyar() {
        try {
            IManagerFactory _mngFac;
            IFatIrsUstManager _mngFatIrsUst;
            ISiparisUstManager _mngSipUst;
            ICekManager _mngCek;
            ISenetManager _mngSenet;
            _mngFac = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
            _mngFatIrsUst = _mngFac.GetFatirsUstManager();
            _mngSipUst = _mngFac.GetSiparisUstManager();
            _mngCek = _mngFac.GetCekManager();
            _mngSenet = _mngFac.GetSenetManager();
            List<Senet> senetListe = _mngSenet.GetListSenetByVadeTarih(UserInfo.Sube.Id, DateTime.Today);
            List<Cek> cekListe = _mngCek.GetListCekByVadeTarih(UserInfo.Sube.Id, DateTime.Today);
            List<FatIrsUst> fatListe = _mngFatIrsUst.GetListFaturaToday(UserInfo.Sube.Id);
            List<FatIrsUst> irsListe = _mngFatIrsUst.GetListIrsaliyeSevkToday(UserInfo.Sube.Id);
            List<SiparisUst> sipListe = _mngSipUst.GetListSiparisTeslimToday(UserInfo.Sube.Id);
            //labelFat.Text = labelIrs.Text = labelSip.Text = labelSenet.Text = labelCek.Text = "";
            if(fatListe.Count>0 || senetListe.Count>0 || cekListe.Count>0 || irsListe.Count>0 || sipListe.Count>0)
            {
                frmUyari frm = new frmUyari();
                frm.ShowDialog();
            }
            if (fatListe.Count > 0) {
                
                //labelFat.Text = string.Format("{0} tane vadesi gelmiş Faturanız var", fatListe.Count);
            }
            if (irsListe.Count > 0) {               
                //labelIrs.Text = string.Format("{0} tane sevk tarihi gelmiş İrsaliyeniz var", irsListe.Count);
            }
            if (sipListe.Count > 0) {           
                //labelSip.Text = string.Format("{0} tane teslim tarihi gelmiş Siparişiniz var", sipListe.Count);
            }
            if (cekListe.Count > 0) {       
                //labelCek.Text = string.Format("{0} tane vadesi gelmiş Çekiniz var", cekListe.Count);
            }
            if (senetListe.Count > 0) {              
                //labelSenet.Text = string.Format("{0} tane vadesi gelmiş Senetiniz var", senetListe.Count);
            }
        } catch (Exception exc) {
            MessageBox.Show(exc.Message); LogWrite.Write(exc);
        }
    }
    
    void InitializeScreenValues() {
        Size size = new Size(281, 56);
        Point point = new Point(12, 201);
        g_screenState = new ScreenState();
        g_screenState
            .WhenStateIs(IndeksPaket.Eko)
            .DisableToolStripItem(cekSenetToolStripMenuItem,cekSenetStripDropDownButton1,siparisToolStripMenuItem
            ,toolStripSplitBtnSiparis);
        if (Engine.GetSqlServerType() == SqlServerType.SqlLite) {
            yedekAlToolStripMenuItem.Visible = true;
            yedekDenGeriDonToolStripMenuItem.Visible = true;
        } else {
            yedekAlToolStripMenuItem.Visible = false;
            yedekDenGeriDonToolStripMenuItem.Visible = false;
        }

       
    }
    private void frmAnaSayfa_Load(object sender, EventArgs e)
    {
        this.Text = "IndeksTicari {0}".With(Engine.Versiyon());
    }
    private void subeAcMenuItem1_Click(object sender, EventArgs e)
    {
      frmSube frm = new frmSube();
      ShowForm(frm, true);
    }
    private void btnCari_Click(object sender, EventArgs e)
    {
      frmCari frm = new frmCari();
      frm.Show();
    }

    private void kullaniciKaydetmeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmKullanici frm = new frmKullanici();
      ShowForm(frm,false);
    }

    private void btnStok_Click(object sender, EventArgs e)
    {
      frmStok frm = new frmStok();
      frm.Show();
    }

    private void frmAnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
    {
      //if (Application.OpenForms.Count > 2)
      //{
      //  MessageBox.Show("Açık olan modulleri kapatınız", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      //  e.Cancel = true;
      //}
      //else
      //{
      //  DialogResult re = MessageBox.Show("Programdan Çıkmak istiyormusunuz?", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
      //  if (re == DialogResult.Yes)
      //  {
      //    e.Cancel = false;
      //    Application.ExitThread();
      //  }
      //  else
      //    e.Cancel = true;
      //}
      DialogResult re = MessageBox.Show("Programdan Çıkmak istiyormusunuz?", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
      if (re == DialogResult.Yes)
      {
        e.Cancel = false;
        Application.ExitThread();
      }
      else
        e.Cancel = true;
    }
    public void ShowForm(Form frm,bool doMazimize)
    {
      //this.IsMdiContainer = true;
      //frm.MdiParent = this;
      if(doMazimize)
        frm.WindowState = FormWindowState.Maximized;
      //frm.FormClosed += delegate(System.Object o, FormClosedEventArgs e2) { treeView1.SelectedNode = null; };
      //frm.FormClosed += (o,e2)=>{ treeView1.SelectedNode = null; };
      //form2.Activate();
      //form2.TopLevel = true;
      //form2.Focus();

      //form2.BringToFront();      
      frm.BringToFront();
      frm.Activate();
    
      frm.Focus();  
      
      frm.Show();     
         
     
    }
   
    void AddPropertiesForm(Form frm)
    {
        frm.Dock = DockStyle.Fill;
        frm.FormBorderStyle = FormBorderStyle.None;
        frm.TopLevel = false;
        frm.Parent = this;
    }
    private void ShowInTab(Form frm) {
        bool exist = false;
        foreach (TabPage t in closableTab1.TabPages)
        {
            if ("T" + frm.Name == t.Name)
            {
                closableTab1.SelectedTab = t;
                exist = true;
            }
        }
        if(!exist)
        {
            TabPage t = new TabPage(frm.Name);
            t.Name ="T"+t.Text;
            closableTab1.TabPages.Add(t);
            t.Controls.Add(frm);
            closableTab1.SelectedTab = t;
            frm.Show();
        }
    }
    private void btnStok_Click_1(object sender, EventArgs e)
    {
      frmStok frm = new frmStok();
      frm.Name = "STOK";
      AddPropertiesForm(frm);
      ShowInTab(frm);
      //frm.ShowDialog();
      //ShowForm(frm,true);
    }
    private void musteriSiparisToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmSiparis frm = new frmSiparis(FTIRSIP.MusSip);
      frm.Name = "MUSTERI SIPARIS";
      AddPropertiesForm(frm);
      ShowInTab(frm);
        //ShowForm(frm, true);
    }
    private void saticiSiparisToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmSiparis frm = new frmSiparis(FTIRSIP.SaticiSip);
      frm.Name = "SATICI SIPARIS";
      AddPropertiesForm(frm);
      ShowInTab(frm);
        //ShowForm(frm, true);
    }     
    private void tsbtnSatisFat_Click(object sender, EventArgs e)
    {
      frmFatura frm = new frmFatura(Indeks.Data.BusinessObjects.FTIRSIP.SatisFat, FatNoTip.Fatura);
      frm.Name = "SATIS FATURA";
      AddPropertiesForm(frm);
      ShowInTab(frm);
        //ShowForm(frm, true);
    }
    private void tsbtnAlisFat_Click(object sender, EventArgs e)
    {      
      frmFatura frm = new frmFatura(Indeks.Data.BusinessObjects.FTIRSIP.AlisFat, FatNoTip.Fatura);
      frm.Name = "ALIS FATURA";
      AddPropertiesForm(frm);
      ShowInTab(frm);
        //ShowForm(frm, true);
    }
    private void tsbtnDirekSat_Click(object sender, EventArgs e)
    {
      frmDirektSatis frm = new frmDirektSatis();
      frm.Name = "DIREKT SATIS";
      AddPropertiesForm(frm);
      ShowInTab(frm);
        //ShowForm(frm, true);
    }
    private void tsbtnCari_Click(object sender, EventArgs e)
    {
      frmCari frm = new frmCari();
      frm.Name = "CARI";
      AddPropertiesForm(frm);
      ShowInTab(frm);
        //ShowForm(frm, true);
    }
    private void tsbtnKasa_Click(object sender, EventArgs e)
    {
      frmKasaKayitlari frm = new frmKasaKayitlari();
      frm.Name = "KASA KAYITLARI";
      AddPropertiesForm(frm);
      ShowInTab(frm);
        //ShowForm(frm, false);
    }
    private void stokKayıtToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmStok frm = new frmStok();
      frm.Name = "STOK";
      AddPropertiesForm(frm);
      ShowInTab(frm);
      //frm.ShowDialog();
      //ShowForm(frm, true);
    }
    private void stokHareketDokumuToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmStokHareketKriter frm = new frmStokHareketKriter();
        frm.Name = "STOK HAREKET";
        AddPropertiesForm(frm);
        ShowInTab(frm);
        //frm.Show();
    }
    private void stokAlisSatisRaporuToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmStokAlisSatisRaporKriter frm = new frmStokAlisSatisRaporKriter(StokAlisSatisRapor.AlisRapor);
      frm.Name = "STOK ALIS SATIS RAPORU";
      AddPropertiesForm(frm);
      ShowInTab(frm);
      //ShowForm(frm, false);
    }
    private void satisFaturasiToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmFatura frm = new frmFatura(Indeks.Data.BusinessObjects.FTIRSIP.SatisFat, FatNoTip.Fatura);
      frm.Name = "SATIS FATURA";
      AddPropertiesForm(frm);
      ShowInTab(frm);
        //ShowForm(frm, true);
    }
    private void alisFaturasiToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmFatura frm = new frmFatura(Indeks.Data.BusinessObjects.FTIRSIP.AlisFat, FatNoTip.Fatura);
      frm.Name = "ALIS FATURA";
      AddPropertiesForm(frm);
      ShowInTab(frm);
        //ShowForm(frm, true);
    }
    private void satisIrsaliyeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmFatura frm = new frmFatura(Indeks.Data.BusinessObjects.FTIRSIP.SatisIrs, FatNoTip.Irsaliye);
      frm.Name = "SATIS IRSALIYE";
      AddPropertiesForm(frm);
      ShowInTab(frm);
        //ShowForm(frm, true);
    }
    private void alisIrsaliyeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmFatura frm = new frmFatura(Indeks.Data.BusinessObjects.FTIRSIP.AlisIrs, FatNoTip.Irsaliye);
      frm.Name = "ALIS IRSALIYE";
      AddPropertiesForm(frm);
      ShowInTab(frm);
        //ShowForm(frm, true);
    }
    private void direktSatisToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmFatura frm = new frmFatura(FTIRSIP.DirektSatis, FatNoTip.Fatura);
      frm.Name = "DIREKT SATIS";
      AddPropertiesForm(frm);
      ShowInTab(frm);
        //ShowForm(frm, true);
    }
    private void tsmMusteriSiparis_Click(object sender, EventArgs e)
    {
      frmSiparis frm = new frmSiparis(FTIRSIP.MusSip);
      frm.Name = "MUSTERI SIPARIS";
      AddPropertiesForm(frm);
      ShowInTab(frm);
        //ShowForm(frm, true);
    }
    private void tsmSaticiSiparis_Click(object sender, EventArgs e)
    {
      frmSiparis frm = new frmSiparis(FTIRSIP.SaticiSip);
      frm.Name = "SATICI SIPARIS";
      AddPropertiesForm(frm);
      ShowInTab(frm);
        //ShowForm(frm, true);
    }
    private void cariKaydetToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmCari frm = new frmCari();
      frm.Name = "CARI";
      AddPropertiesForm(frm);
      ShowInTab(frm);
      //ShowForm(frm, true);
    }
    private void cariHareketDokumuToolStripMenuItem_Click(object sender, EventArgs e)
    {       
        //frmGenelAlacakBorcKriter frm = new frmGenelAlacakBorcKriter(new frmGenelBorcAlacakRapor(), this);
        //ShowForm(frm, false);
        frmCariHareketDokumu frm = new frmCariHareketDokumu();
        frm.Name = "CARI HAREKET DOKUMU";
        AddPropertiesForm(frm);
        ShowInTab(frm);
        //frm.Show();
    }
    private void genelBorcAlacakDokumuToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmCariGenelBorcAlacakDokumu frm = new frmCariGenelBorcAlacakDokumu();
        frm.Show();
    }
    private void kasaKaydetToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmKasaTanimlama frm = new frmKasaTanimlama();   
      ShowForm(frm, false);     
    }
    private void kasaKayitlariToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmKasaKayitlari frm = new frmKasaKayitlari();
      frm.Name = "KASA KAYITLARI";
      AddPropertiesForm(frm);
      ShowInTab(frm);
        //ShowForm(frm, false);
    }
    private void kasaHareketDokumuToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmKasaHareketDokumu frm = new frmKasaHareketDokumu(this);
      ShowForm(frm, false);
    }
    private void subeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmSube frm = new frmSube();
      ShowForm(frm, false);
    }
    private void kullanıciToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmKullanici frm = new frmKullanici();
      ShowForm(frm, false);
     
    }
    private void dizaynToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmDizaynKayit frm = new frmDizaynKayit();
      //ShowForm(frm, false);

      frm.Show();
    }
    private void subeDegistirToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (Application.OpenForms.Count > 2)
      {
        MessageBox.Show("Açık olan modulleri kapatınız", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }
      frmSubeDegistir frm = new frmSubeDegistir();
      frm.Owner = this;
      ShowForm(frm, false);
    }
    private void stokDurumRaporuToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmStokDurumRaporu frm = new frmStokDurumRaporu();
      ShowForm(frm,false);
    }
    private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
      //frmStokDurumRaporForCrytalRapor frm = new frmStokDurumRaporForCrytalRapor();
      //frm.Dispose();
      //backgroundWorker1.Dispose();
    }
    private void toolStripMenuItemHesapEkle_Click(object sender, EventArgs e)
    {
      frmHesapEkle frm = new frmHesapEkle();
      ShowForm(frm, false);
    }
    private void tsmHesapEkle_Click(object sender, EventArgs e)
    {
      frmHesapEkle frm = new frmHesapEkle();
      ShowForm(frm,false);
    }

    private void tsmParaYatirma_Click(object sender, EventArgs e)
    {
      frmBankaHareket frm = new frmBankaHareket(HesapHareketTuru.ParaYatirma);
      ShowForm(frm,false);
    }

    private void tsmParaCekme_Click(object sender, EventArgs e)
    {
      frmBankaHareket frm = new frmBankaHareket(HesapHareketTuru.ParaCekme);
      ShowForm(frm, false);
    }

    private void paraYatirmaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmBankaHareket frm = new frmBankaHareket(HesapHareketTuru.ParaYatirma);
      ShowForm(frm, false);
    }

    private void paraCekmeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmBankaHareket frm = new frmBankaHareket(HesapHareketTuru.ParaCekme);
      ShowForm(frm, false);
    }

    private void hareketRaporToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmBankaHareketRapor frm = new frmBankaHareketRapor();
      ShowForm(frm,false);
    }

    private void tsmGelenHavale_Click(object sender, EventArgs e)
    {
      frmBankaHareket frm = new frmBankaHareket(HesapHareketTuru.GelenHavale);
      ShowForm(frm, false);
    }

    private void tsmGonderilenHavale_Click(object sender, EventArgs e)
    {
      frmBankaHareket frm = new frmBankaHareket(HesapHareketTuru.GonderilenHavale);
      ShowForm(frm, false);
    }

    private void cekGirisToolStripMenuItem_Click(object sender, EventArgs e) {
        frmCek frm = new frmCek();
        ShowForm(frm, false);

    }

    private void senetGirisToolStripMenuItem_Click(object sender, EventArgs e) {
        frmSenet frm = new frmSenet();
        ShowForm(frm,false);
    }

    private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e) {
        frmAyarlar frm = new frmAyarlar();
        ShowForm(frm,false);
    }

    private void gunVeGunKasaRaporuToolStripMenuItem_Click(object sender, EventArgs e) {
        frmGunGunKasaRaporKriter frm = new frmGunGunKasaRaporKriter();
        ShowForm(frm,false);
    }

    private void ozelGelirRaporuToolStripMenuItem_Click(object sender, EventArgs e) {
        frmOzelGelirGiderRapor frm = new frmOzelGelirGiderRapor(GelirGider.Gelir);
        frm.Show();
    }

    private void ozelGiderRaporuToolStripMenuItem_Click(object sender, EventArgs e) {
        frmOzelGelirGiderRapor frm = new frmOzelGelirGiderRapor(GelirGider.Gider);
        frm.Show();
    }

    private void stokSatisRaporuToolStripMenuItem_Click(object sender, EventArgs e) {
        frmStokAlisSatisRaporKriter frm = new frmStokAlisSatisRaporKriter(StokAlisSatisRapor.SatisRapor);
        frm.Name = "STOK ALIS SATIS RAPORU";
        AddPropertiesForm(frm);
        ShowInTab(frm);
        //ShowForm(frm, false);
    }

    private void StokAlisMaliyetRaporuToolStripMenuItem_Click(object sender, EventArgs e) {
        frmStokMaliyetRaporu frm = new frmStokMaliyetRaporu();
        frm.Name = "STOK ALIS MALIYET RAPORU";
        AddPropertiesForm(frm);
        ShowInTab(frm);
        //frm.Show();
    }

    private void StokSatisMaliyetRaporuToolStripMenuItem_Click(object sender, EventArgs e) {
        frmStokMaliyetRaporu frm = new frmStokMaliyetRaporu();
        frm.Name = "STOK SATIS MALIYET RAPORU";
        AddPropertiesForm(frm);
        ShowInTab(frm);
        //frm.Show();
    }

    private void ayAyKasaRaporuToolStripMenuItem_Click(object sender, EventArgs e) {
        frmAyAyKasaRaporu frm = new frmAyAyKasaRaporu();
        frm.Show();
    }

    private void satisIrsaliyesiToolStripMenuItem_Click(object sender, EventArgs e) {
        frmFatura frm = new frmFatura(Indeks.Data.BusinessObjects.FTIRSIP.SatisIrs, FatNoTip.Irsaliye);
        frm.Name = "SATIS IRSALIYE";
        AddPropertiesForm(frm);
        ShowInTab(frm);
        //ShowForm(frm, true);
    }

    private void alisIrsaliyesiToolStripMenuItem_Click(object sender, EventArgs e) {
        frmFatura frm = new frmFatura(Indeks.Data.BusinessObjects.FTIRSIP.AlisIrs, FatNoTip.Irsaliye);
        frm.Name = "ALIS IRSALIYE";
        AddPropertiesForm(frm);
        ShowInTab(frm);
        //ShowForm(frm, true);
    }

    private void faturaRaporuToolStripMenuItem_Click(object sender, EventArgs e) {
        frmFaturaRapor frm = new frmFaturaRapor(true);
        frm.Name = "FATURA RAPORU";
        AddPropertiesForm(frm);
        ShowInTab(frm);
        //frm.Show();
    }

    private void irsaliyeRaporuToolStripMenuItem_Click(object sender, EventArgs e) {
        frmFaturaRapor frm = new frmFaturaRapor(false);
        frm.Name = "IRSALIYE RAPORU";
        AddPropertiesForm(frm);
        ShowInTab(frm);
        //frm.Show();
    }

    private void siparisRaporuToolStripMenuItem_Click(object sender, EventArgs e) {
        frmSiparisRapor frm = new frmSiparisRapor();
        frm.Name = "SIPARIS RAPORU";
        AddPropertiesForm(frm);
        ShowInTab(frm);
        //frm.Show();
    }

    private void cekRaporuToolStripMenuItem_Click(object sender, EventArgs e) {
        frmCekRapor frm = new frmCekRapor();
        frm.Name = "CEK RAPORU";
        AddPropertiesForm(frm);
        ShowInTab(frm);
        //frm.Show();
    }

    private void senetRaporuToolStripMenuItem_Click(object sender, EventArgs e) {
        frmSenetRapor frm = new frmSenetRapor();
        frm.Show();
    }
    string GetDbFiledirectory() {
        string dbDir = Engine.GetConString();
        dbDir = dbDir.Replace("Data Source=", "");
        dbDir = dbDir.Replace(";Version=3;", "");
        return dbDir;
    }
    private void yedekAlToolStripMenuItem_Click(object sender, EventArgs e) {
        if (Application.OpenForms.Count > 2) {
            MessageBox.Show("Açık olan modulleri kapatınız", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        try {
            string yedekDir = _mngAyar.DatabaseYedeklemeYeri;
            if (string.IsNullOrEmpty(yedekDir)) {
                MessageBox.Show("Yedek alınacak yeri belirtiniz.");
                frmAyarlar frm = new frmAyarlar();
                frm.Owner = this;
                frm.ShowDialog();
            }
            _mngAyar.LoadValues();
            yedekDir = _mngAyar.DatabaseYedeklemeYeri;
            string dbDir = GetDbFiledirectory() ;
           
            DirectoryInfo df = new DirectoryInfo(yedekDir);
            string fileName = "Indeks_" + DateTime.Today.ToShortDateString() + ".db";
            string newFileDir = Path.Combine(yedekDir,fileName);
            if (df.Exists)
                File.Copy(dbDir,newFileDir, true);
            else {
                df.Create();
                File.Copy(dbDir, newFileDir, true);
            }
            MessageBox.Show("Yedeği kaydedildi");
        } catch (Exception exc) {
            MessageBox.Show(exc.Message);
            LogWrite.Write(exc);
        }
    }

    private void yedekDenGeriDonToolStripMenuItem_Click(object sender, EventArgs e) {
        if (Application.OpenForms.Count > 2) {
            MessageBox.Show("Açık olan modulleri kapatınız", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        try {
            DialogResult dia= openFileDialog1.ShowDialog();
            if (dia == DialogResult.OK) {
                string dbDir = GetDbFiledirectory();
               
                File.Copy(openFileDialog1.FileName,dbDir,true);
                MessageBox.Show("Yedek den geri dönüldü");
            }
           
        } catch (Exception exc) 
        { 
            MessageBox.Show(exc.Message);
            LogWrite.Write(exc);
        }
    }

    private void hakkimizdaToolStripMenuItem_Click(object sender, EventArgs e) {
        frmHakkimizda frm = new frmHakkimizda();
        frm.ShowDialog();
    }

    private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e) {
        try {
            Process prc = new Process();
            prc.StartInfo.FileName = "calc.exe";
            prc.Start();
        } catch (Exception exc) {
            MessageBox.Show(exc.Message);
            LogWrite.Write(exc);
        }
    }
   
    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
        try {
            if (!first) {
                Process prc = new Process();
                //prc.StartInfo.FileName = linkLabel1.Text;
                prc.Start();
                first = false;
            }
            first = false;
        } catch (Exception exc) {
            MessageBox.Show(exc.Message);
            LogWrite.Write(exc);
        }
    }

    private void genelDurumRaporuToolStripMenuItem_Click(object sender, EventArgs e) {
        frmGenelDurumRaporu frm = new frmGenelDurumRaporu();
        frm.Show();
    }

    private void yardimToolStripMenuItem_Click(object sender, EventArgs e) {       
             try {
            if (!first) {
                Process prc = new Process();
                prc.StartInfo.FileName = "www.indeksyazilim.com/Home.aspx/Dokumantasyon";
                prc.Start();
                first = false;
            }
            first = false;
        } catch (Exception exc) {
            MessageBox.Show(exc.Message);
            LogWrite.Write(exc);
        }
    }

  

    private void sqlCalistirToolStripMenuItem_Click(object sender, EventArgs e) {
        frmSqlRun frm = new frmSqlRun();
        frm.Show();
    }

    private void yeniVeritabaniToolStripMenuItem_Click(object sender, EventArgs e) {
        frmYeniVeriTabani frm = new frmYeniVeriTabani();
        frm.Show();
    }
  }
}
