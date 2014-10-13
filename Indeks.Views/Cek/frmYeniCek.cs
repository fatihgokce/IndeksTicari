using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Indeks.Data.BusinessObjects;
using Indeks.Data.ManagerObjects;
namespace Indeks.Views {
    public partial class frmYeniCek : BaseForm {
        IManagerFactory g_mngFac;
        ICariManager g_mngCari;
        ICariHareketManager g_mngCariHar;
        ICekManager g_mngCek;
        CekDurum g_cekDurum;
        CekTip g_cekTip;
        int? g_cekId;
        IBankaHesapManager g_mngBanka;
        public frmYeniCek(CekDurum cekDurum,CekTip cekTip) {
            InitializeComponent();
            g_cekTip = cekTip;
            g_cekDurum = cekDurum;
            g_cekId = null;
            InitializeData();
        }
        public frmYeniCek(int cekId,CekDurum cekDurum, CekTip cekTip) {
            InitializeComponent();
            g_cekId = cekId;
            g_cekTip = cekTip;
            g_cekDurum = cekDurum;
            InitializeData();
            SetCek();
        }
        void SetCek() {
            try {
                Cek cek = g_mngCek.SingleOrDefault<Cek>(x=>x.Id==g_cekId.Value);
                if (cek != null) {
                    txtCariKodu.Text = cek.CariKodu;
                    dateIslem.Value = cek.IslemTarih;
                    dateVade.Value = cek.VadeTarih;
                    txtHesapNo.Text = cek.Banka;
                    txtSube.Text = cek.SubeAdi;
                    txtBanka.Text = cek.HesapNo;
                    txtCekNo.Text = cek.CekNo;
                    txtTutar.Text = cek.Tutar.ToString();
                    txtAsilSahip.Text = cek.AsilSahibi;
                    txtAciklama.Text = cek.Aciklama;
                
                }
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            
            }
        }
        void InitializeData() {
            g_mngFac = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
            g_mngCari = g_mngFac.GetCariManager();
            g_mngCek = g_mngFac.GetCekManager();
            g_mngBanka = g_mngFac.GetBankaHesapManager();
            g_mngCariHar = g_mngFac.GetCariHareketManager();
            txtCariKodu.DataSource = () =>
            {
                try {
                    return g_mngCari.GetCariKodsBySubeKodu(UserInfo.Sube.Id, txtCariKodu.Text).ToStringList(15,txtCariKodu.Ayirac);
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                    LogWrite.Write(exc);
                }
                return null;
            };
            if (g_cekTip == CekTip.Verilen) {
                btnBankaRehber.Visible = true;
                txtHesapNo.DataSource = () =>
                {
                    try {
                        return g_mngBanka.GetBankaHesapNoBySubeKodu(UserInfo.Sube.Id, txtHesapNo.Text);
                    } catch (Exception exc) {
                        LogWrite.Write(exc);
                        MessageBox.Show(exc.Message);
                    }
                    return null;
                };
            }
        }

        private void frmYeniCek_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                SendKeys.Send("{TAB}");
            } else if (Keys.F5 == e.KeyCode) {
                Kaydet();
            } else if (Keys.Escape == e.KeyCode) {
                this.Close();
            } 
        }
        void Kaydet() {
            try {
                Cek cek = null;
                if (g_cekId.HasValue)
                    cek = g_mngCek.GetById(g_cekId.Value, false);
                if (cek == null) {
                    cek = new Cek();
                    cek.KayitTarih = DateTime.Now;
                }
                Cari cari = g_mngCari.GetById(txtCariKodu.Text,false);
                if (cari == null) {
                    MessageBox.Show("Cari bulunamadı,lütfen geçerli bir cari kodu giriniz");
                    txtCariKodu.Focus();
                    return;
                }
                cek.Aciklama = txtAciklama.Text;
                cek.AsilSahibi = txtAsilSahip.Text;
                cek.Banka = txtBanka.Text;
                cek.CariKodu = txtCariKodu.Text;
                cek.CekDurum = g_cekDurum;
                cek.CekNo = txtCekNo.Text;
                cek.CekTip = g_cekTip;
                cek.HesapNo = txtHesapNo.Text;
                cek.IslemTarih = dateIslem.Value.JustDate();
                cek.Sube = UserInfo.Sube;
                cek.SubeAdi = txtSube.Text;
                cek.Tutar = txtTutar.Text.ParseStruct(x => double.Parse(x));
                cek.VadeTarih = dateVade.Value.JustDate();
                BeginTransaction();  
                
                g_mngCek.SaveOrUpdate(cek);
                CariHareket cahar =null;
                CariHarTuru tur=g_cekTip==CekTip.Alinan?CariHarTuru.AlinanCek:CariHarTuru.VerilenCek;
               // cahar=g_mngCariHar.GetByFisNoAndHareketTuruAndCariKod(UserInfo.Sube.Id,cek.Id.ToString(),tur,cek.CariKodu);
                cahar = g_mngCariHar.GetByCekOrSenetIdAndHareketTuruAndCariKod(UserInfo.Sube.Id, cek.Id,
                    tur, cek.CariKodu);                   
                if (cahar == null) {
                    cahar = new CariHareket();
                    cahar.CekSenetId = cek.Id;
                    cahar.Sube = UserInfo.Sube;
                    cahar.Tarih = DateTime.Today;
                }
                cahar.Cari = cari;
                if (g_cekTip == CekTip.Alinan) {
                    cahar.Alacak = cek.Tutar;
                    cahar.HareketTuru = CariHarTuru.AlinanCek;
                    cahar.Aciklama = string.Format("{0} çek no ile ödeme",cek.Id);
                   
                } else if (g_cekTip == CekTip.Verilen) {
                    cahar.Borc = cek.Tutar;
                    cahar.HareketTuru = CariHarTuru.VerilenCek;
                    cahar.Aciklama = string.Format("{0} çek no ile borçlu", cek.Id);
                    
                }
                
                cahar.VadeTarih = cek.VadeTarih;
                g_mngCariHar.SaveOrUpdate(cahar);
               
                this.Close();
            } catch (Exception exc) {
                LogWrite.Write(exc);
                MessageBox.Show(exc.Message);
            } finally {
                try {
                    CommitTransaction();
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                    LogWrite.Write(exc);
                }
            }
        }

        private void btnCariRehber_Click(object sender, EventArgs e) {
            frmCariRehber frm = new frmCariRehber();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void btnBankaRehber_Click(object sender, EventArgs e) {
            frmBankaHesapRehber frm = new frmBankaHesapRehber();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void txtHesapNo_KeyUp(object sender, KeyEventArgs e) {
            if (!string.IsNullOrEmpty(txtHesapNo.Text)
                && (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)) {
                BankaHesap hesap = g_mngBanka.GetByHesapNo(UserInfo.Sube.Id,txtHesapNo.Text);
                if (hesap != null) {
                    txtBanka.Text = hesap.BankaAdi;
                    txtSube.Text = hesap.SubeAdi;
                }
            }
        }

        private void tsbtnKaydet_Click(object sender, EventArgs e) {
            Kaydet();
        }

        private void tsbtnKapat_Click(object sender, EventArgs e) {
            this.Close();
        }

        
    }
}
