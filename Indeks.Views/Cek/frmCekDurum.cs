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
using Indeks.Views.Helper;
using Indeks.Views.DataExtension;
namespace Indeks.Views {
    public partial class frmCekDurum : BaseCekSenet {
        CekTip g_cekTip;
        CekDurum g_cekDurum;
        int g_cekId;
      
        ICekManager g_mngCek;
       
        //IDictionary<CekDurum, ConfigureSecreen> g_screenState;
        ScreenState g_screenState;
       
        Cek g_cek;
        public frmCekDurum(int cekId,CekTip cekTip,CekDurum cekDurum):base() {
           
            InitializeComponent();           
            g_mngCek = _mngFac.GetCekManager();          
            g_cekId = cekId;
            g_cekTip = cekTip;
            g_cekDurum = cekDurum;
            SetData();
           
            txtBankaHesap.DataSource = () =>
            {
                try {
                    return _mngBanka.GetBankaHesapNoBySubeKodu(UserInfo.Sube.Id, txtBankaHesap.Text);
                } catch (Exception exc) {
                    LogWrite.Write(exc);
                    MessageBox.Show(exc.Message);
                }
                return null;
            };
            txtCari.DataSource = () =>
            {
                try {
                    return _mngCari.GetCariKodsBySubeKodu(UserInfo.Sube.Id, txtCari.Text).ToStringList(15,txtCari.Ayirac);
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                    LogWrite.Write(exc);
                }
                return null;
            };
            LoadKasa(cmbKasa);
            InitializeScreenValues();
            SetControlLocation();

        }
        void InitializeScreenValues() {
            Size size=new Size(281,56);
            Point point=new Point(12,201);
            g_screenState = new ScreenState();
            g_screenState
                .WhenStateIs(CekDurum.Beklemede)
                .DisableControls(grbBanka,grbCari,grbKasa);
            g_screenState
                .WhenStateIs(CekDurum.CiroEdildi)
                .EnableControls(grbCari).DisableControls(grbBanka,grbKasa)
                .SetSize(size,grbCari).SetLocation(point,grbCari);
            g_screenState
                .WhenStateIs(CekDurum.IadeEdildi)
                .DisableControls(grbBanka, grbCari, grbKasa);
            g_screenState
                .WhenStateIs(CekDurum.Karsiliksiz)
                .DisableControls(grbBanka, grbCari, grbKasa);
            g_screenState
              .WhenStateIs(CekDurum.TahsilBankaHesaba)
              .EnableControls(grbBanka).DisableControls(grbCari, grbKasa)
              .SetSize(size, grbBanka).SetLocation(point, grbBanka);
            g_screenState
            .WhenStateIs(CekDurum.TahsilEdildi)
            .EnableControls(grbKasa).DisableControls(grbCari, grbBanka)
            .SetSize(size, grbKasa).SetLocation(point, grbKasa);
            g_screenState
             .WhenStateIs(CekDurum.BankaTeminatVerildi)
             .EnableControls(grbBanka).DisableControls(grbCari, grbKasa)
             .SetSize(size, grbBanka).SetLocation(point, grbBanka);
            g_screenState
             .WhenStateIs(CekDurum.BankayaTahsileVerildi)
             .EnableControls(grbBanka).DisableControls(grbCari, grbKasa)
             .SetSize(size, grbBanka).SetLocation(point, grbBanka);
            //g_stateCek = new ScreenState();
            //g_stateCek.WhenStateIs(CekDurum.Beklemede)
            //    .Do(() => ChangeDurum(CekDurum.Beklemede));
           
        
        }
        void SetSecreenState(CekDurum durum) {
            g_screenState.ChangeTo(durum);           
       
        }
       
        void SetData() {
            try {
                labSuanDurum.Text = g_cekDurum.ToString();
                g_cek = g_mngCek.GetById(g_cekId,false);
                Cari cari = _mngCari.GetById(g_cek.CariKodu,false);
                labCariKod.Text = cari.Id;
                labCariIsim.Text = cari.CariIsim;
                dateIslem.Value = g_cek.IslemTarih;
                txtAciklama.Text = g_cek.Aciklama;
                if (g_cek.CekTip == CekTip.Alinan) {
                    string key = "rb" + g_cek.CekDurum.ToString();
                    RadioButton rb = (RadioButton)grbAlinanCek.Controls.Find(key, true)[0];
                    rb.Checked = true;
                    if (rb == rbTahsilEdildi) {
                        if (!string.IsNullOrEmpty(g_cek.DurumKasaKod))
                            cmbKasa.Text = g_cek.DurumKasaKod;
                    } else if (rb == rbCiroEdildi){
                        txtCari.Text = g_cek.DurumCariKod;
                    } else if (rb == rbBankaTeminatVerildi || rb == rbBankayaTahsileVerildi
                        || rb == rbTahsilBankaHesaba) {
                        txtBankaHesap.Text = g_cek.DurumBankaHesapNo;
                    }
                } else {
                    if (g_cek.CekDurum == CekDurum.Beklemede)
                        rbBeklemedeVerilen.Checked = true;
                    else {
                        string str = "rb" + g_cek.CekDurum.ToString();
                        RadioButton rb = (RadioButton)grbVerilenCek.Controls.Find(str, true)[0];
                        rb.Checked = true;
                    }
                }
            } catch (Exception exc) {
                LogWrite.Write(exc);
                MessageBox.Show(exc.Message);
            }
        }
        void SetControlLocation() {
            if (g_cekTip == CekTip.Verilen) {
                grbVerilenCek.Location = grbAlinanCek.Location;
                grbVerilenCek.Visible = true;
                grbAlinanCek.Visible = false;
                grbBanka.Visible = false;
                grbCari.Visible = false;
                grbKasa.Visible = false;
            } else {
                SetSecreenState(g_cekDurum);
            
            }
        }

        private void btnBankaRehber_Click(object sender, EventArgs e) {
            frmBankaHesapRehber frm = new frmBankaHesapRehber();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void btnCariRehber_Click(object sender, EventArgs e) {
            frmCariRehber frm = new frmCariRehber();
            frm.Owner = this;
            frm.ShowDialog();
        }

       

        private void rbBeklemede_Click(object sender, EventArgs e) {
            string durumName = ((RadioButton)sender).Name.Substring(2);
            CekDurum durum = (CekDurum)Enum.Parse(typeof(CekDurum),durumName);
            SetSecreenState(durum);
            
        }
        CekDurum FindVerilenCekDurum() {
            if (rbBeklemedeVerilen.Checked)
                return CekDurum.Beklemede;
            else {
                string durum = grbVerilenCek.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked).Name.Substring(2);

                return (CekDurum)Enum.Parse(typeof(CekDurum), durum);
            }
        }
        CekDurum FindAlinanCekDurum() {
            string durumName =grbAlinanCek.Controls.OfType<RadioButton>().FirstOrDefault(x=>x.Checked).Name.Substring(2);
            CekDurum durum = (CekDurum)Enum.Parse(typeof(CekDurum), durumName);
            return durum;
        }
        void ChangeDurum(CekDurum durum) {
            try {
                g_cek.CekDurum = durum;
                g_cek.Aciklama = txtAciklama.Text;
                g_cek.IslemTarih = dateIslem.Value;
                g_mngCek.BeginTransaction();
                g_mngCek.SaveOrUpdate(g_cek);
               
            } catch (Exception) {
            } finally {
                try {
                    g_mngCek.CommitTransaction();
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                    LogWrite.Write(exc);
                }
            }
        }
   
        void VerilenDurumKaydet() {

            CekDurum simdikiDurum = FindVerilenCekDurum();
            if (g_cek.CekDurum != simdikiDurum) {
                if (simdikiDurum == CekDurum.Beklemede) {
                    if (g_cek.CekDurum == CekDurum.GeriAlindi) {                       
                        CariHareketSil(g_cek.Id,CariHarTuru.VerilenCekGeriAlinmasi, g_cek.CariKodu);
                        ChangeDurum(simdikiDurum);

                    } else if (g_cek.CekDurum == CekDurum.Odendi) {
                        BankaHareketSil(g_cek.Id, HesapHareketTuru.CekOdeme);
                        ChangeDurum(simdikiDurum);
                    }
                } else if (simdikiDurum == CekDurum.Odendi) {
                    BankaHesapHareketKaydet(g_cek.Id, g_cek.Tutar, g_cek.HesapNo,g_cek.CariKodu, string.Format("{0}  çek ödemesi {1} kodlu cariye", g_cek.Id,g_cek.CariKodu), 
                        HesapHareketTuru.CekOdeme);
                    if (g_cek.CekDurum == CekDurum.GeriAlindi) {
                        CariHareketSil(g_cek.Id, CariHarTuru.VerilenCekGeriAlinmasi, g_cek.CariKodu);
                    }
                    ChangeDurum(simdikiDurum);
                } else if (simdikiDurum == CekDurum.GeriAlindi) {
                    if (g_cek.CekDurum == CekDurum.Odendi) {
                        BankaHareketSil(g_cek.Id,HesapHareketTuru.CekOdeme);
                    }
                    CarihareketKaydet(CariHarTuru.VerilenCekGeriAlinmasi, string.Format("{0}  çekin geri alınması", g_cek.Id), true, g_cek.CariKodu,
                           g_cek.Id, g_cek.Tutar);
                    ChangeDurum(simdikiDurum);
                }

            }
        }
        void AlinanCekDurumBeklemdeyeAl() {
            
            if (g_cek.CekDurum == CekDurum.TahsilEdildi) {
                KasaHareketSil(g_cek.Id, KasaHarTip.Cek);             
            } else if (g_cek.CekDurum == CekDurum.CiroEdildi) {
                CariHareketSil(g_cek.Id, CariHarTuru.CekCirosu, g_cek.DurumCariKod);
               
            }else if (g_cek.CekDurum == CekDurum.TahsilBankaHesaba) {
                BankaHareketSil(g_cek.Id,HesapHareketTuru.CekTahsil);               
            } else if (g_cek.CekDurum == CekDurum.IadeEdildi) {
                CariHareketSil(g_cek.Id, CariHarTuru.AlinanCekIade, g_cek.CariKodu);
            } else if (g_cek.CekDurum == CekDurum.Karsiliksiz) {
                CariHareketSil(g_cek.Id, CariHarTuru.KarsiliksizCek, g_cek.CariKodu);
            }
            g_cek.DurumBankaHesapNo = string.Empty;
            g_cek.DurumCariKod = string.Empty;
            g_cek.DurumKasaKod = string.Empty;
            ChangeDurum(CekDurum.Beklemede);
        }
        void AlinanCekDurumTahsilEdildiyeAl() {
            
            if (g_cek.CekDurum == CekDurum.CiroEdildi) {
                CariHareketSil(g_cek.Id, CariHarTuru.CekCirosu, g_cek.DurumCariKod);                
            } else if (g_cek.CekDurum == CekDurum.TahsilBankaHesaba) {
                BankaHareketSil(g_cek.Id, HesapHareketTuru.CekTahsil);               
            } else if (g_cek.CekDurum == CekDurum.IadeEdildi) {
                CariHareketSil(g_cek.Id, CariHarTuru.AlinanCekIade, g_cek.CariKodu);
            } else if (g_cek.CekDurum == CekDurum.Karsiliksiz) {
                CariHareketSil(g_cek.Id, CariHarTuru.KarsiliksizCek, g_cek.CariKodu);
            }
            KasaHareketKaydet(KasaHarTip.Cek, KasaGelirGider.Gelir, cmbKasa.Text,
               string.Format("{0} çek no ile çek tahsili,cariKodu:{1} ", g_cek.Id.ToString(), g_cek.CariKodu),g_cek.Id,g_cek.Tutar);
            g_cek.DurumKasaKod = cmbKasa.Text;
            g_cek.DurumBankaHesapNo = string.Empty;
            g_cek.DurumCariKod = string.Empty;
            ChangeDurum(CekDurum.TahsilEdildi);
            
        }
        void AlinanCekDurumCiroEdildiyeAl() {
            
            if (g_cek.CekDurum == CekDurum.TahsilEdildi) {
                KasaHareketSil(g_cek.Id, KasaHarTip.Cek);
            } else if (g_cek.CekDurum == CekDurum.TahsilBankaHesaba) {
                BankaHareketSil(g_cek.Id, HesapHareketTuru.CekTahsil);
            } else if (g_cek.CekDurum == CekDurum.IadeEdildi) {
                CariHareketSil(g_cek.Id, CariHarTuru.AlinanCekIade, g_cek.CariKodu);
            } else if (g_cek.CekDurum == CekDurum.Karsiliksiz) {
                CariHareketSil(g_cek.Id, CariHarTuru.KarsiliksizCek, g_cek.CariKodu);
            }
            string aciklama = string.Format("{0} çek no ile çek cirosu:cariKodu:{1}", g_cek.Id.ToString(), txtCari.Text);
            g_cek.DurumKasaKod = string.Empty;
            g_cek.DurumBankaHesapNo = string.Empty;
            g_cek.DurumCariKod = txtCari.Text;
            ChangeDurum(CekDurum.CiroEdildi);
            CarihareketKaydet(CariHarTuru.CekCirosu, aciklama, false, txtCari.Text,g_cek.Id,g_cek.Tutar);
        }
        void AlinanCekDurumBankayaTahsileVerildiyeAl() {

            if (g_cek.CekDurum == CekDurum.TahsilEdildi) {
                KasaHareketSil(g_cek.Id, KasaHarTip.Cek);
            } else if (g_cek.CekDurum == CekDurum.CiroEdildi) {
                CariHareketSil(g_cek.Id, CariHarTuru.CekCirosu, g_cek.DurumCariKod);

            } else if (g_cek.CekDurum == CekDurum.TahsilBankaHesaba) {
                BankaHareketSil(g_cek.Id, HesapHareketTuru.CekTahsil);
            } else if (g_cek.CekDurum == CekDurum.IadeEdildi) {
                CariHareketSil(g_cek.Id, CariHarTuru.AlinanCekIade, g_cek.CariKodu);
            } else if (g_cek.CekDurum == CekDurum.Karsiliksiz) {
                CariHareketSil(g_cek.Id, CariHarTuru.KarsiliksizCek, g_cek.CariKodu);
            }
            g_cek.DurumBankaHesapNo = txtBankaHesap.Text;
            g_cek.DurumCariKod = string.Empty;
            g_cek.DurumKasaKod = string.Empty;
            ChangeDurum(CekDurum.BankayaTahsileVerildi);
        }
        void AlinanCekDurumBankayaTeminataVerildiyeAl() {

            if (g_cek.CekDurum == CekDurum.TahsilEdildi) {
                KasaHareketSil(g_cek.Id, KasaHarTip.Cek);
            } else if (g_cek.CekDurum == CekDurum.CiroEdildi) {
                CariHareketSil(g_cek.Id, CariHarTuru.CekCirosu, g_cek.DurumCariKod);

            } else if (g_cek.CekDurum == CekDurum.TahsilBankaHesaba) {
                BankaHareketSil(g_cek.Id, HesapHareketTuru.CekTahsil);
            } else if (g_cek.CekDurum == CekDurum.IadeEdildi) {
                CariHareketSil(g_cek.Id, CariHarTuru.AlinanCekIade, g_cek.CariKodu);
            } else if (g_cek.CekDurum == CekDurum.Karsiliksiz) {
                CariHareketSil(g_cek.Id, CariHarTuru.KarsiliksizCek, g_cek.CariKodu);
            }
            g_cek.DurumBankaHesapNo =txtBankaHesap.Text;
            g_cek.DurumCariKod = string.Empty;
            g_cek.DurumKasaKod = string.Empty;
            ChangeDurum(CekDurum.BankaTeminatVerildi);
        }
        void AlinanCekDurumBankayaTeminataVerildi() {
           
            if (g_cek.CekDurum == CekDurum.TahsilEdildi) {
                KasaHareketSil(g_cek.Id, KasaHarTip.Cek);
            } else if (g_cek.CekDurum == CekDurum.TahsilBankaHesaba) {
                BankaHareketSil(g_cek.Id, HesapHareketTuru.CekTahsil);
            } else if (g_cek.CekDurum == CekDurum.IadeEdildi) {
                CariHareketSil(g_cek.Id, CariHarTuru.AlinanCekIade, g_cek.CariKodu);
            } else if (g_cek.CekDurum == CekDurum.CiroEdildi) {
                CariHareketSil(g_cek.Id, CariHarTuru.CekCirosu, g_cek.DurumCariKod);
            } else if (g_cek.CekDurum == CekDurum.Karsiliksiz) {
                CariHareketSil(g_cek.Id, CariHarTuru.KarsiliksizCek, g_cek.CariKodu);
            }

            g_cek.DurumKasaKod = string.Empty;
            g_cek.DurumBankaHesapNo = txtBankaHesap.Text;
            g_cek.DurumCariKod = string.Empty;
            ChangeDurum(CekDurum.BankaTeminatVerildi);
        }
         void AlinanCekDurumTahsilBankaHesabinaAl() {
            if (string.IsNullOrEmpty(txtBankaHesap.Text)) {
                MessageBox.Show("Banka hesabınızı giriniz.");
                return;
            }
            
            if (g_cek.CekDurum == CekDurum.TahsilEdildi) {
                KasaHareketSil(g_cek.Id, KasaHarTip.Cek);
            } else if (g_cek.CekDurum == CekDurum.IadeEdildi) {
                CariHareketSil(g_cek.Id, CariHarTuru.AlinanCekIade, g_cek.CariKodu);
            } else if (g_cek.CekDurum == CekDurum.CiroEdildi) {
                CariHareketSil(g_cek.Id, CariHarTuru.CekCirosu, g_cek.DurumCariKod);
            } else if (g_cek.CekDurum == CekDurum.Karsiliksiz) {
                CariHareketSil(g_cek.Id, CariHarTuru.KarsiliksizCek, g_cek.CariKodu);
            }
            g_cek.DurumKasaKod = string.Empty;
            g_cek.DurumBankaHesapNo = txtBankaHesap.Text;
            g_cek.DurumCariKod = string.Empty;
            ChangeDurum(CekDurum.TahsilBankaHesaba);
            BankaHesapHareketKaydet(g_cek.Id, g_cek.Tutar, txtBankaHesap.Text,g_cek.CariKodu, 
                string.Format("{0} çek ile tahsil {1} kodlu cariden",g_cek.Id.ToString(),g_cek.CariKodu),
                HesapHareketTuru.CekTahsil
                );
        }
         void AlinanCekDurumKarsilizaAl() {

             if (g_cek.CekDurum == CekDurum.TahsilEdildi) {
                 KasaHareketSil(g_cek.Id, KasaHarTip.Cek);
             } else if (g_cek.CekDurum == CekDurum.TahsilBankaHesaba) {
                 BankaHareketSil(g_cek.Id, HesapHareketTuru.CekTahsil);
             } else if (g_cek.CekDurum == CekDurum.IadeEdildi) {
                 CariHareketSil(g_cek.Id, CariHarTuru.AlinanCekIade, g_cek.CariKodu);
             } else if (g_cek.CekDurum == CekDurum.CiroEdildi) {
                 CariHareketSil(g_cek.Id, CariHarTuru.CekCirosu, g_cek.DurumCariKod);
             }
              g_cek.DurumKasaKod = string.Empty;
              g_cek.DurumBankaHesapNo = string.Empty;
              g_cek.DurumCariKod = string.Empty;
              string aciklama = string.Format("{0} çek no  karşılıksız:cariKodu:{1}", g_cek.Id.ToString(), g_cek.CariKodu);
              CarihareketKaydet(CariHarTuru.KarsiliksizCek, aciklama, false, g_cek.CariKodu, g_cek.Id, g_cek.Tutar);
              ChangeDurum(CekDurum.Karsiliksiz);

         }
         void AlinanCekDurumIadeEdildiyeAl() {
             
             if (g_cek.CekDurum == CekDurum.TahsilEdildi) {
                 KasaHareketSil(g_cek.Id, KasaHarTip.Cek);
             } else if (g_cek.CekDurum == CekDurum.TahsilBankaHesaba) {
                 BankaHareketSil(g_cek.Id, HesapHareketTuru.CekTahsil);
             } else if (g_cek.CekDurum == CekDurum.CiroEdildi) {
                 CariHareketSil(g_cek.Id, CariHarTuru.CekCirosu, g_cek.DurumCariKod);
             } else if (g_cek.CekDurum == CekDurum.Karsiliksiz) {
                 CariHareketSil(g_cek.Id, CariHarTuru.KarsiliksizCek, g_cek.CariKodu);
             }
             string aciklama = string.Format("{0} çek no ile çek iadesi:cariKodu:{1}", g_cek.Id.ToString(), g_cek.CariKodu);
             g_cek.DurumKasaKod = string.Empty;
             g_cek.DurumBankaHesapNo = string.Empty;
             g_cek.DurumCariKod = string.Empty;
             ChangeDurum(CekDurum.IadeEdildi);
             CarihareketKaydet(CariHarTuru.AlinanCekIade, aciklama, false,g_cek.CariKodu,g_cek.Id,g_cek.Tutar);
         }
        void AlinanDurumKaydet() {
            CekDurum simdikiDurum = FindAlinanCekDurum();
            if (g_cek.CekDurum != simdikiDurum) { 
            // Beklemede
                if (simdikiDurum == CekDurum.Beklemede) {
                    AlinanCekDurumBeklemdeyeAl();
                } else if (simdikiDurum == CekDurum.TahsilEdildi){ 
                    AlinanCekDurumTahsilEdildiyeAl(); 
                } else if (simdikiDurum == CekDurum.CiroEdildi) {
                    AlinanCekDurumCiroEdildiyeAl();
                } else if (simdikiDurum == CekDurum.BankayaTahsileVerildi) {
                    AlinanCekDurumBankayaTahsileVerildiyeAl();
                } else if (simdikiDurum == CekDurum.BankaTeminatVerildi) {
                    AlinanCekDurumBankayaTeminataVerildi();
                } else if (simdikiDurum == CekDurum.TahsilBankaHesaba) {
                    AlinanCekDurumTahsilBankaHesabinaAl();
                } else if (simdikiDurum == CekDurum.IadeEdildi) {
                    AlinanCekDurumIadeEdildiyeAl();
                } else if (simdikiDurum == CekDurum.Karsiliksiz) {
                    AlinanCekDurumKarsilizaAl();
                }
            }
        }
        void Kaydet() {
            if (g_cekTip == CekTip.Verilen)
                VerilenDurumKaydet();
            else if (g_cekTip == CekTip.Alinan)
                AlinanDurumKaydet();
            this.Close();
        }
        private void frmCekDurum_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.F5)
                Kaydet();
        }

        private void tsbtnKaydet_Click(object sender, EventArgs e) {
            Kaydet();
        }

      
    }
}
