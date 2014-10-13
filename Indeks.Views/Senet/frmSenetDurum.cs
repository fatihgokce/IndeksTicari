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
    public partial class frmSenetDurum : BaseCekSenet {
        SenetTip _senetTip;
        SenetDurum _senetDurum;
        int _senetId;
        //IManagerFactory _mngFac;
      
        //ICariManager _mngCari;
        //ICariHareketManager _mngCahar;
        //IBankaHesapManager _mngBanka;
        //IHesapHareketManager _mngHesapHar;
        //IKasaManager _mngKasa;
        //IKasaHarManager _mngKasaHar;

        ISenetManager _mngSenet;
        Senet _senet;
        ScreenState _screenState;
        public frmSenetDurum(int senetId,SenetTip senetTip,SenetDurum senetDurum):base() {
            InitializeComponent();
            //_mngFac = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
           
            //_mngCari = _mngFac.GetCariManager();
            //_mngCahar = _mngFac.GetCariHareketManager();
            //_mngBanka = _mngFac.GetBankaHesapManager();
            //_mngHesapHar = _mngFac.GetHesapHareketManager();
            //_mngKasa = _mngFac.GetKasaManager();
            //_mngKasaHar = _mngFac.GetKasaHarManager();
            _mngSenet = _mngFac.GetSenetManager();
            _senetId = senetId;
            _senetTip = senetTip;
            _senetDurum = senetDurum;
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
        void SetData() {
            try {
                labSuanDurum.Text = _senetDurum.ToString();
                _senet = _mngSenet.GetById(_senetId, false);
                Cari cari = _mngCari.GetById(_senet.CariKodu, false);
                labCariKod.Text = cari.Id;
                labCariIsim.Text = cari.CariIsim;
                dateIslem.Value = _senet.IslemTarih;
                txtAciklama.Text = _senet.Aciklama;
                if (_senet.SenetTip == SenetTip.Alinan) {
                    string key = "rb" + _senet.SenetDurum.ToString();
                    RadioButton rb = (RadioButton)grbAlinanSenet.Controls.Find(key, true)[0];
                    rb.Checked = true;
                    if (rb == rbTahsilEdildi) {
                        if (!string.IsNullOrEmpty(_senet.DurumKasaKod))
                            cmbKasa.Text = _senet.DurumKasaKod;
                    } else if (rb == rbCiroEdildi) {
                        txtCari.Text = _senet.DurumCariKod;
                    } else if (rb == rbBankaTeminatVerildi || rb == rbBankayaTahsileVerildi
                        || rb == rbTahsilBankaHesaba) {
                        txtBankaHesap.Text = _senet.DurumBankaHesapNo;
                    }
                } else {
                    if (_senet.SenetDurum == SenetDurum.Beklemede)
                        rbBeklemedeVerilen.Checked = true;
                    else {
                        string str = "rb" + _senet.SenetDurum.ToString();
                        RadioButton rb = (RadioButton)grbVerilenSenet.Controls.Find(str, true)[0];
                        rb.Checked = true;
                    }
                }
            } catch (Exception exc) {
                LogWrite.Write(exc);
                MessageBox.Show(exc.Message);
            }
        }
      
        void InitializeScreenValues() {
            Size size = new Size(281, 56);
            Point point = new Point(12, 201);
            _screenState = new ScreenState();
            _screenState
                .WhenStateIs(SenetDurum.Beklemede)
                .DisableControls(grbBanka, grbCari, grbKasa);
            _screenState
                .WhenStateIs(SenetDurum.CiroEdildi)
                .EnableControls(grbCari).DisableControls(grbBanka, grbKasa)
                .SetSize(size, grbCari).SetLocation(point, grbCari);
            _screenState
                .WhenStateIs(SenetDurum.IadeEdildi)
                .DisableControls(grbBanka, grbCari, grbKasa);
            _screenState
                .WhenStateIs(SenetDurum.Karsiliksiz)
                .DisableControls(grbBanka, grbCari, grbKasa);
            _screenState
              .WhenStateIs(SenetDurum.TahsilBankaHesaba)
              .EnableControls(grbBanka).DisableControls(grbCari, grbKasa)
              .SetSize(size, grbBanka).SetLocation(point, grbBanka);
            _screenState
            .WhenStateIs(SenetDurum.TahsilEdildi)
            .EnableControls(grbKasa).DisableControls(grbCari, grbBanka)
            .SetSize(size, grbKasa).SetLocation(point, grbKasa);
            _screenState
             .WhenStateIs(SenetDurum.BankaTeminatVerildi)
             .EnableControls(grbBanka).DisableControls(grbCari, grbKasa)
             .SetSize(size, grbBanka).SetLocation(point, grbBanka);
            _screenState
             .WhenStateIs(SenetDurum.BankayaTahsileVerildi)
             .EnableControls(grbBanka).DisableControls(grbCari, grbKasa)
             .SetSize(size, grbBanka).SetLocation(point, grbBanka);           

        }
        void SetControlLocation() {
            if (_senetTip == SenetTip.Verilen) {
                grbVerilenSenet.Location = grbAlinanSenet.Location;
                grbVerilenSenet.Visible = true;
                grbAlinanSenet.Visible = false;
                grbBanka.Visible = false;
                grbCari.Visible = false;
                grbKasa.Visible = false;
                if (_senetDurum == SenetDurum.Beklemede || _senetDurum == SenetDurum.GeriAlindi) {               
                    grbBanka.Visible = false;
                    grbCari.Visible = false;
                    grbKasa.Visible = false;
                } else {//ödendi                  
                    Size size = new Size(281, 56);
                    Point point = new Point(12, 201);
                    grbKasa.Visible = true;
                    grbKasa.Size = size;
                    grbKasa.Location = point;                
                }
                rbBeklemedeVerilen.Click += (o, y) => {
                    grbBanka.Visible = false;
                    grbCari.Visible = false;
                    grbKasa.Visible = false;
                };
                rbGeriAlindi.Click += (o, y) =>
                {
                    grbBanka.Visible = false;
                    grbCari.Visible = false;
                    grbKasa.Visible = false;
                };
                rbOdendi.Click += (o, y) =>
                    {
                        Size size = new Size(281, 56);
                        Point point = new Point(12, 201);
                        grbKasa.Visible = true;
                        grbKasa.Size = size;
                        grbKasa.Location = point;    
                    };
            } else {
                SetSecreenState(_senetDurum);

            }
        }
        void SetSecreenState(SenetDurum durum) {
            _screenState.ChangeTo(durum);

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
            SenetDurum durum = (SenetDurum)Enum.Parse(typeof(SenetDurum), durumName);
            SetSecreenState(durum);
        }
        SenetDurum FindVerilenSenetDurum() {
            if (rbBeklemedeVerilen.Checked)
                return SenetDurum.Beklemede;
            else {
                string durum = grbVerilenSenet.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked).Name.Substring(2);

                return (SenetDurum)Enum.Parse(typeof(SenetDurum), durum);
            }
        }
        SenetDurum FindAlinanSenetDurum() {
            string durumName = grbAlinanSenet.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked).Name.Substring(2);
            SenetDurum durum = (SenetDurum)Enum.Parse(typeof(SenetDurum), durumName);
            return durum;
        }
        void ChangeDurum(SenetDurum durum) {
            try {
                _senet.SenetDurum = durum;
                _senet.Aciklama = txtAciklama.Text;
                _senet.IslemTarih = dateIslem.Value;
                _mngSenet.BeginTransaction();
                _mngSenet.SaveOrUpdate(_senet);
               
            } catch (Exception) {
            } finally {
                try {
                    _mngSenet.CommitTransaction();
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                    LogWrite.Write(exc);
                }
            }
        }
        //void CariHareketSil(CariHarTuru hareketTuru, string cariKodu) {
        //    try {
        //        CariHareket har = _mngCahar.GetByCekOrSenetIdAndHareketTuruAndCariKod(UserInfo.Sube.Id, _senet.Id, hareketTuru, cariKodu);

        //        _mngCahar.BeginTransaction();
        //        _mngCahar.Delete(har);
        //        _mngCahar.CommitTransaction();

        //    } catch (Exception exc) {
        //        MessageBox.Show(exc.Message);
        //        LogWrite.Write(exc);
        //    }

        //}
        //void KasaHareketSil() {
        //    try {

        //        KasaHareket har = _mngKasaHar.GetByTipAndCekOrSenetId(UserInfo.Sube.Id
        //            , KasaHareket.DetermineTip(KasaHarTip.Senet), _senet.Id);
        //        if (har != null) {
        //            _mngKasaHar.BeginTransaction();
        //            _mngKasaHar.Delete(har);
        //            _mngKasaHar.CommitTransaction();
        //        }

        //    } catch (Exception exc) {
        //        MessageBox.Show(exc.Message);
        //        LogWrite.Write(exc);
        //    }
        //}
        //void KasaHareketKaydet(KasaHarTip harTip, KasaGelirGider gelirGider, string kasaKod, string aciklama) {
        //    try {
        //        KasaHareket har = new KasaHareket();
        //        har.Kasa = _mngKasa.GetById(kasaKod, false);
        //        har.Aciklama = aciklama;
        //        har.CekSenetId = _senet.Id;
        //        har.GelirGider = KasaHareket.DetermineGelirGider(gelirGider);
        //        har.Sube = UserInfo.Sube;
        //        har.Tarih = DateTime.Now;
        //        har.Tip = KasaHareket.DetermineTip(harTip);
        //        har.Tutar = _senet.Tutar;
        //        _mngKasaHar.BeginTransaction();
        //        _mngKasaHar.Save(har);
        //        _mngKasaHar.CommitTransaction();
        //    } catch (Exception exc) {
        //        MessageBox.Show(exc.Message);
        //        LogWrite.Write(exc);
        //    }
        //}
        //void CarihareketKaydet(CariHarTuru harTur, string aciklama, bool alacakIsle, string cariKod) {
        //    try {
        //        CariHareket cahar = new CariHareket();
        //        cahar.Aciklama = aciklama;
        //        if (alacakIsle)
        //            cahar.Alacak = _senet.Tutar;
        //        else
        //            cahar.Borc = _senet.Tutar;
        //        cahar.Cari = _mngCari.GetById(cariKod, false);
        //        cahar.CekSenetId = _senet.Id;
        //        cahar.HareketTuru = harTur;
        //        cahar.Sube = UserInfo.Sube;
        //        cahar.Tarih = DateTime.Now;
        //        _mngCahar.BeginTransaction();
        //        _mngCahar.Save(cahar);
        //        _mngCahar.CommitTransaction();

        //    } catch (Exception exc) {
        //        MessageBox.Show(exc.Message);
        //        LogWrite.Write(exc);
        //    }
        //}
        //void BankaHareketSil(HesapHareketTuru hareketTuru) {
        //    try {
        //        HesapHareket har = _mngHesapHar.GetByCekOrSenetIdAndHareketTuru(UserInfo.Sube.Id, _senet.Id, hareketTuru);
        //        if (har != null) {
        //            _mngHesapHar.BeginTransaction();
        //            _mngHesapHar.Delete(har);
        //            _mngHesapHar.CommitTransaction();
        //        }
        //    } catch (Exception exc) {
        //        MessageBox.Show(exc.Message);
        //        LogWrite.Write(exc);
        //    }
        //}
        //void BankaHesapHareketKaydet(string hesapNo) {
        //    try {
        //        HesapHareket har = new HesapHareket();
        //        har.Aciklama = string.Format("{0} senet ile tahsil", _senet.Id.ToString());
        //        har.BankaHesap = _mngBanka.GetByHesapNo(UserInfo.Sube.Id, hesapNo);
        //        har.CekSenetId = _senet.Id;
        //        har.HareketTuru = HesapHareketTuru.SenetTahsil;
        //        har.Sube = UserInfo.Sube;
        //        har.Tarih = DateTime.Now;
        //        har.Tutar = _senet.Tutar;
        //        _mngHesapHar.BeginTransaction();
        //        _mngHesapHar.Save(har);
        //        _mngHesapHar.CommitTransaction();
        //    } catch (Exception exc) {
        //        LogWrite.Write(exc);
        //        MessageBox.Show(exc.Message);
        //    }
        //}
        void VerilenDurumKaydet() {

            SenetDurum simdikiDurum = FindVerilenSenetDurum();
            if (_senet.SenetDurum != simdikiDurum) {
                if (simdikiDurum == SenetDurum.Beklemede) {
                    if (_senet.SenetDurum == SenetDurum.GeriAlindi) {
                        CariHareketSil(_senet.Id,CariHarTuru.VerilenSenetGeriAlinmasi, _senet.CariKodu);                       

                    } else if (_senet.SenetDurum == SenetDurum.Odendi) {
                        KasaHareketSil(_senet.Id,KasaHarTip.Senet);                       
                    }
                    ChangeDurum(simdikiDurum);
                } else if (simdikiDurum == SenetDurum.Odendi) {
                       if (_senet.SenetDurum == SenetDurum.GeriAlindi) {
                        CariHareketSil(_senet.Id,CariHarTuru.VerilenSenetGeriAlinmasi, _senet.CariKodu);                      
                    }
                    KasaHareketKaydet(KasaHarTip.Senet, KasaGelirGider.Gider, cmbKasa.Text, string.Format("{0} senet ödemesi", _senet.Id), _senet.Id, _senet.Tutar);
                    ChangeDurum(simdikiDurum);
                } else if (simdikiDurum == SenetDurum.GeriAlindi) {
                   if (_senet.SenetDurum == SenetDurum.Odendi) {                      
                        KasaHareketSil(_senet.Id, KasaHarTip.Senet);
                    }
                    CarihareketKaydet(CariHarTuru.VerilenSenetGeriAlinmasi, string.Format("{0} senetin geri alınması", _senet.Id), true, _senet.CariKodu,
                          _senet.Id, _senet.Tutar);
                    ChangeDurum(simdikiDurum);
                }

            }
        }
        void AlinanSenetDurumBeklemdeyeAl() {
          
            if (_senet.SenetDurum == SenetDurum.TahsilEdildi) {
                KasaHareketSil(_senet.Id, KasaHarTip.Senet);
            } else if (_senet.SenetDurum == SenetDurum.CiroEdildi) {
                CariHareketSil(_senet.Id,CariHarTuru.SenetCirosu, _senet.DurumCariKod);

            } else if (_senet.SenetDurum == SenetDurum.TahsilBankaHesaba) {
                BankaHareketSil(_senet.Id,HesapHareketTuru.SenetTahsil);
            } else if (_senet.SenetDurum == SenetDurum.IadeEdildi) {
                CariHareketSil(_senet.Id,CariHarTuru.AlinanSenetIade, _senet.CariKodu);
            } else if (_senet.SenetDurum == SenetDurum.Karsiliksiz) {
                CariHareketSil(_senet.Id, CariHarTuru.KarsiliksizSenet, _senet.CariKodu);
            }
            _senet.DurumBankaHesapNo = string.Empty;
            _senet.DurumCariKod = string.Empty;
            _senet.DurumKasaKod = string.Empty;
            ChangeDurum(SenetDurum.Beklemede);
        }
        void AlinanSenetDurumTahsilEdildiyeAl() {
           
            if (_senet.SenetDurum == SenetDurum.CiroEdildi) {
                CariHareketSil(_senet.Id, CariHarTuru.SenetCirosu, _senet.DurumCariKod);
            } else if (_senet.SenetDurum == SenetDurum.TahsilBankaHesaba) {
                BankaHareketSil(_senet.Id,HesapHareketTuru.SenetTahsil);
            } else if (_senet.SenetDurum == SenetDurum.IadeEdildi) {
                CariHareketSil(_senet.Id, CariHarTuru.AlinanSenetIade, _senet.CariKodu);
            } else if (_senet.SenetDurum == SenetDurum.Karsiliksiz) {
                CariHareketSil(_senet.Id, CariHarTuru.KarsiliksizSenet, _senet.CariKodu);
            }
            KasaHareketKaydet(KasaHarTip.Senet, KasaGelirGider.Gelir, cmbKasa.Text,
              string.Format("{0} senet no ile çek tahsili,cariKodu:{1} ", _senet.Id.ToString(), _senet.CariKodu),_senet.Id,_senet.Tutar);
            _senet.DurumKasaKod = cmbKasa.Text;
            _senet.DurumBankaHesapNo = string.Empty;
            _senet.DurumCariKod = string.Empty;
            ChangeDurum(SenetDurum.TahsilEdildi);
        }
        void AlinanSenetDurumCiroEdildiyeAl() {
          
            if (_senet.SenetDurum == SenetDurum.TahsilEdildi) {
                KasaHareketSil(_senet.Id, KasaHarTip.Senet);
            } else if (_senet.SenetDurum == SenetDurum.TahsilBankaHesaba) {
                BankaHareketSil(_senet.Id,HesapHareketTuru.SenetTahsil);
            } else if (_senet.SenetDurum == SenetDurum.IadeEdildi) {
                CariHareketSil(_senet.Id, CariHarTuru.AlinanSenetIade, _senet.CariKodu);
            } else if (_senet.SenetDurum == SenetDurum.Karsiliksiz) {
                CariHareketSil(_senet.Id, CariHarTuru.KarsiliksizSenet, _senet.CariKodu);
            }
            string aciklama = string.Format("{0} senet id ile senet cirosu:cariKodu:{1}", _senet.Id.ToString(), txtCari.Text);
            _senet.DurumKasaKod = string.Empty;
            _senet.DurumBankaHesapNo = string.Empty;
            _senet.DurumCariKod = txtCari.Text;
            ChangeDurum(SenetDurum.CiroEdildi);
            CarihareketKaydet(CariHarTuru.SenetCirosu, aciklama, false, txtCari.Text,_senet.Id,_senet.Tutar);
        }
        void AlinanSenetDurumBankayaTeminataVerildi() {

           
            if (_senet.SenetDurum == SenetDurum.TahsilEdildi) {
                KasaHareketSil(_senet.Id, KasaHarTip.Senet);
            } else if (_senet.SenetDurum == SenetDurum.TahsilBankaHesaba) {
                BankaHareketSil(_senet.Id,HesapHareketTuru.SenetTahsil);
            } else if (_senet.SenetDurum == SenetDurum.IadeEdildi) {
                CariHareketSil(_senet.Id, CariHarTuru.AlinanSenetIade, _senet.CariKodu);
            } else if (_senet.SenetDurum == SenetDurum.CiroEdildi) {
                CariHareketSil(_senet.Id, CariHarTuru.SenetCirosu, _senet.DurumCariKod);
            } else if (_senet.SenetDurum == SenetDurum.Karsiliksiz) {
                CariHareketSil(_senet.Id, CariHarTuru.KarsiliksizSenet, _senet.CariKodu);
            }
            _senet.DurumKasaKod = string.Empty;
            _senet.DurumBankaHesapNo =txtBankaHesap.Text;
            _senet.DurumCariKod = string.Empty;
            ChangeDurum(SenetDurum.BankaTeminatVerildi);
        }
        void AlinanSenetDurumTahsilBankaHesabinaAl() {
            if (string.IsNullOrEmpty(txtBankaHesap.Text)) {
                MessageBox.Show("Banka hesabınızı giriniz.");
                return;
            }
           
            if (_senet.SenetDurum == SenetDurum.TahsilEdildi) {
               KasaHareketSil(_senet.Id,KasaHarTip.Senet);
            } else if (_senet.SenetDurum == SenetDurum.IadeEdildi) {
                CariHareketSil(_senet.Id, CariHarTuru.AlinanSenetIade, _senet.CariKodu);
            } else if (_senet.SenetDurum == SenetDurum.CiroEdildi) {
                CariHareketSil(_senet.Id, CariHarTuru.SenetCirosu, _senet.DurumCariKod);
            } else if (_senet.SenetDurum == SenetDurum.Karsiliksiz) {
                CariHareketSil(_senet.Id, CariHarTuru.KarsiliksizSenet, _senet.CariKodu);
            }
            _senet.DurumKasaKod = string.Empty;
            _senet.DurumBankaHesapNo = txtBankaHesap.Text;
            _senet.DurumCariKod = string.Empty;
            ChangeDurum(SenetDurum.TahsilBankaHesaba);
            BankaHesapHareketKaydet(_senet.Id,_senet.Tutar,txtBankaHesap.Text,_senet.CariKodu,
                string.Format("{0} senet ile tahsil {1} kodlu cariden", _senet.Id.ToString(),_senet.CariKodu),
                HesapHareketTuru.SenetTahsil);
        }
        void AlinanSenetDurumIadeEdildiyeAl() {           
            if (_senet.SenetDurum == SenetDurum.TahsilEdildi) {
                KasaHareketSil(_senet.Id, KasaHarTip.Senet);
            } else if (_senet.SenetDurum == SenetDurum.TahsilBankaHesaba) {
                BankaHareketSil(_senet.Id,HesapHareketTuru.SenetTahsil);
            } else if (_senet.SenetDurum == SenetDurum.CiroEdildi) {
                CariHareketSil(_senet.Id, CariHarTuru.SenetCirosu, _senet.DurumCariKod);
            } else if (_senet.SenetDurum == SenetDurum.Karsiliksiz) {
                CariHareketSil(_senet.Id, CariHarTuru.KarsiliksizSenet, _senet.CariKodu);
            }
            string aciklama = string.Format("{0} senet no ile senet iadesi:cariKodu:{1}", _senet.Id.ToString(), _senet.CariKodu);
            _senet.DurumKasaKod = string.Empty;
            _senet.DurumBankaHesapNo = string.Empty;
            _senet.DurumCariKod = string.Empty;
            ChangeDurum(SenetDurum.IadeEdildi);
            CarihareketKaydet(CariHarTuru.AlinanSenetIade, aciklama, false,_senet.CariKodu,_senet.Id,_senet.Tutar);
        }
        void AlinanSenetDurumKarsilizaAl() {           
            if (_senet.SenetDurum == SenetDurum.TahsilEdildi) {
                KasaHareketSil(_senet.Id, KasaHarTip.Senet);
            } else if (_senet.SenetDurum == SenetDurum.TahsilBankaHesaba) {
                BankaHareketSil(_senet.Id,HesapHareketTuru.SenetTahsil);
            } else if (_senet.SenetDurum == SenetDurum.IadeEdildi) {
                CariHareketSil(_senet.Id, CariHarTuru.AlinanSenetIade, _senet.CariKodu);
            } else if (_senet.SenetDurum == SenetDurum.CiroEdildi) {
                CariHareketSil(_senet.Id, CariHarTuru.SenetCirosu, _senet.DurumCariKod);
            }
            _senet.DurumKasaKod = string.Empty;
            _senet.DurumBankaHesapNo = string.Empty;
            _senet.DurumCariKod = string.Empty;
            string aciklama = string.Format("{0} senet karşılıksız:cariKodu:{1}",_senet.Id.ToString(), _senet.CariKodu);
            CarihareketKaydet(CariHarTuru.KarsiliksizSenet, aciklama, false,_senet.CariKodu ,_senet.Id, _senet.Tutar);
            ChangeDurum(SenetDurum.Karsiliksiz);
        }
        void AlinanSenetDurumBankayaTahsileVerildiyeAl() {

            if (_senet.SenetDurum == SenetDurum.TahsilEdildi) {
                KasaHareketSil(_senet.Id, KasaHarTip.Senet);
            } else if (_senet.SenetDurum == SenetDurum.CiroEdildi) {
                CariHareketSil(_senet.Id, CariHarTuru.CekCirosu, _senet.DurumCariKod);

            } else if (_senet.SenetDurum == SenetDurum.TahsilBankaHesaba) {
                BankaHareketSil(_senet.Id,HesapHareketTuru.CekTahsil);
            } else if (_senet.SenetDurum == SenetDurum.IadeEdildi) {
                CariHareketSil(_senet.Id, CariHarTuru.AlinanCekIade, _senet.CariKodu);
            } else if (_senet.SenetDurum == SenetDurum.Karsiliksiz) {
                CariHareketSil(_senet.Id, CariHarTuru.KarsiliksizSenet, _senet.CariKodu);
            }
            _senet.DurumBankaHesapNo = txtBankaHesap.Text;
            _senet.DurumCariKod = string.Empty;
            _senet.DurumKasaKod = string.Empty;
            ChangeDurum(SenetDurum.BankayaTahsileVerildi);
        }
        void AlinanDurumKaydet() {
            SenetDurum simdikiDurum = FindAlinanSenetDurum();
            if (_senet.SenetDurum != simdikiDurum) {
                // Beklemede
                if (simdikiDurum == SenetDurum.Beklemede) {
                    AlinanSenetDurumBeklemdeyeAl();
                } else if (simdikiDurum == SenetDurum.TahsilEdildi) { 
                    AlinanSenetDurumTahsilEdildiyeAl(); 
                } else if (simdikiDurum == SenetDurum.CiroEdildi) {
                    AlinanSenetDurumCiroEdildiyeAl();
                } else if (simdikiDurum == SenetDurum.BankayaTahsileVerildi) {
                    AlinanSenetDurumBankayaTahsileVerildiyeAl();
                } else if (simdikiDurum == SenetDurum.BankaTeminatVerildi) {
                    AlinanSenetDurumBankayaTeminataVerildi();
                } else if (simdikiDurum == SenetDurum.TahsilBankaHesaba) {
                    AlinanSenetDurumTahsilBankaHesabinaAl();
                } else if (simdikiDurum == SenetDurum.IadeEdildi) {
                    AlinanSenetDurumIadeEdildiyeAl();
                } else if (simdikiDurum == SenetDurum.Karsiliksiz) {
                    AlinanSenetDurumKarsilizaAl();
                }
            }
        }
        void Kaydet() {
            if (_senetTip == SenetTip.Verilen)
                VerilenDurumKaydet();
            else if (_senetTip == SenetTip.Alinan)
                AlinanDurumKaydet();
            this.Close();
        }
        private void tsbtnKaydet_Click(object sender, EventArgs e) {
            Kaydet();
        }

        private void frmSenetDurum_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.F5)
                Kaydet();
            else if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
