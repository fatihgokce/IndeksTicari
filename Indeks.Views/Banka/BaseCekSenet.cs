using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Indeks.Data.BusinessObjects;
using Indeks.Data.ManagerObjects;
using Indeks.Data.Report;
using System.Windows.Forms;

namespace Indeks.Views {
    public class BaseCekSenet:BaseForm {
        protected IManagerFactory _mngFac;
       
        protected ICariManager _mngCari;
        protected ICariHareketManager _mngCahar;
        protected IBankaHesapManager _mngBanka;
        protected IHesapHareketManager _mngHesapHar;
        protected IKasaManager _mngKasa;
        protected IKasaHarManager _mngKasaHar;
        public BaseCekSenet() {
            _mngFac = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());

            _mngCari = _mngFac.GetCariManager();
            _mngCahar = _mngFac.GetCariHareketManager();
            _mngBanka = _mngFac.GetBankaHesapManager();
            _mngHesapHar = _mngFac.GetHesapHareketManager();
            _mngKasa = _mngFac.GetKasaManager();
            _mngKasaHar = _mngFac.GetKasaHarManager();
        }
        public void LoadKasa(ComboBox cmbBox) {
            try {
                List<Kasa> kasalar = _mngKasa.GetKasaBySubeKodu(UserInfo.Sube.Id);
                bool first = true;
                foreach (Kasa kas in kasalar) {
                    cmbBox.Items.Add(kas.Id);
                    if (first) {
                        cmbBox.Text = kas.Id;
                        first = false;
                    }
                }
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }
        public void CarihareketKaydet(CariHarTuru harTur, string aciklama, bool alacakIsle, string cariKod,
            int cekSenetId,double tutar) {
            try {
                CariHareket cahar = new CariHareket();
                cahar.Aciklama = aciklama;
                if (alacakIsle)
                    cahar.Alacak = tutar;
                else
                    cahar.Borc = tutar;
                cahar.Cari = _mngCari.GetById(cariKod, false);
                cahar.CekSenetId = cekSenetId;
                cahar.HareketTuru = harTur;
                cahar.Sube = UserInfo.Sube;
                cahar.Tarih = DateTime.Today;
                cahar.VadeTarih = DateTime.Today;
                _mngCahar.BeginTransaction();
                _mngCahar.Save(cahar);
              
            } catch (Exception) {
            } finally {
                try {
                    _mngCahar.CommitTransaction();
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                    LogWrite.Write(exc);
                }
            }
        }
        public void KasaHareketKaydet(KasaHarTip harTip, KasaGelirGider gelirGider, string kasaKod, string aciklama,int cekSenetId,double tutar) {
            try {
                KasaHareket har = new KasaHareket();
                har.Kasa = _mngKasa.GetById(kasaKod, false);
                har.Aciklama = aciklama;
                har.CekSenetId = cekSenetId;
                har.GelirGider = KasaHareket.DetermineGelirGider(gelirGider);
                har.Sube = UserInfo.Sube;
                har.Tarih = DateTime.Today;
                har.Tip = KasaHareket.DetermineTip(harTip);
                har.Tutar =tutar;
                _mngKasaHar.BeginTransaction();
                _mngKasaHar.Save(har);
               
            } catch (Exception) {
            } finally {
                try {
                    _mngKasaHar.CommitTransaction();
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                    LogWrite.Write(exc);
                }
            }
        }
        public void KasaHareketSil(int cekSenetId,KasaHarTip kasaTip) {
            bool isBegin = false;
            try {

                KasaHareket har = _mngKasaHar.GetByTipAndCekOrSenetId(UserInfo.Sube.Id
                    ,kasaTip, cekSenetId);
                if (har != null) {
                    isBegin = true;
                    _mngKasaHar.BeginTransaction();
                    _mngKasaHar.Delete(har);
                }

            } catch (Exception) {
            } finally {
                try {
                    if(isBegin)
                        _mngKasaHar.CommitTransaction();
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                    LogWrite.Write(exc);
                }
            }
        }
        public void CariHareketSil(int cekSenetId,CariHarTuru hareketTuru, string cariKodu) {
            bool isBegin = false;
            try {
                CariHareket har = _mngCahar.GetByCekOrSenetIdAndHareketTuruAndCariKod(UserInfo.Sube.Id, cekSenetId, hareketTuru, cariKodu);
                if (har != null) {
                    isBegin = true;
                    _mngCahar.BeginTransaction();
                    _mngCahar.Delete(har);
                }

            } catch (Exception){
            } finally {
                try {
                    if(isBegin)
                        _mngCahar.CommitTransaction();
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                    LogWrite.Write(exc);
                }
            }

        }
        public void BankaHareketSil(int cekSenetId,HesapHareketTuru hareketTuru) {
            bool isBegin = false;
            try {
                HesapHareket har = _mngHesapHar.GetByCekOrSenetIdAndHareketTuru(UserInfo.Sube.Id, cekSenetId, hareketTuru);
                if (har != null) {
                    isBegin = true;
                    _mngHesapHar.BeginTransaction();
                    _mngHesapHar.Delete(har); 
                }
            } catch (Exception) {
            } finally {
                try {
                    if(isBegin)
                        _mngHesapHar.CommitTransaction();
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                    LogWrite.Write(exc);
                }
            }
        }
        public void BankaHesapHareketKaydet(int cekSenetId,double tutar,string hesapNo,string cariKodu,string aciklama,
            HesapHareketTuru hareketTuru) {
            try {
                HesapHareket har = new HesapHareket();
                har.Aciklama = aciklama;
                har.BankaHesap = _mngBanka.GetByHesapNo(UserInfo.Sube.Id, hesapNo);
                har.CekSenetId = cekSenetId;
                har.HareketTuru =hareketTuru;
                har.CariKod = cariKodu;
                har.Sube = UserInfo.Sube;
                har.Tarih = DateTime.Today;
                har.Tutar = tutar;
                _mngHesapHar.BeginTransaction();
                _mngHesapHar.Save(har);               
            } catch (Exception) {
            } finally {
                try {
                    _mngHesapHar.CommitTransaction();
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                    LogWrite.Write(exc);
                }
            }
        }
    }
}
