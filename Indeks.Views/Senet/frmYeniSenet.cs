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
    public partial class frmYeniSenet : BaseForm {
        IManagerFactory _mngFac;
        ICariManager _mngCari;
        ICariHareketManager _mngCariHar;
        ISenetManager _mngSenet;
        SenetDurum _senetDurum;
        SenetTip _senetTip;
        int? _senetId;
       public frmYeniSenet(SenetDurum senetDurum,SenetTip senetTip) {
            InitializeComponent();
            _senetTip = senetTip;
            _senetDurum = senetDurum;
            _senetId = null;

            InitializeData();
        }
        public frmYeniSenet(int senetId,SenetDurum senetDurum, SenetTip senetTip) {
            InitializeComponent();
            _senetTip = senetTip;
            _senetDurum = senetDurum;
            _senetId =senetId;
            InitializeData();
            SetSenet();
        }

        void InitializeData() {
            _mngFac = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
            _mngCari = _mngFac.GetCariManager();
            _mngSenet = _mngFac.GetSenetManager() ;
            _mngCariHar = _mngFac.GetCariHareketManager();
            txtCariKodu.DataSource = () =>
            {
                try {
                    return _mngCari.GetCariKodsBySubeKodu(UserInfo.Sube.Id, txtCariKodu.Text).ToStringList(15,txtCariKodu.Ayirac);
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                    LogWrite.Write(exc);
                }
                return null;
            };
            
        }
        void SetSenet() {
            try {
                Senet senet = _mngSenet.SingleOrDefault<Senet>(x => x.Id == _senetId.Value);
                if (senet != null) {
                    txtCariKodu.Text = senet.CariKodu;
                    dateIslem.Value = senet.IslemTarih;
                    dateVade.Value = senet.VadeTarih;
                    txtKefil1.Text = senet.Kefil1;
                    txtKefil2.Text =senet.Kefil2;
                    txtSenetNo.Text = senet.SenetNo;                   
                    txtTutar.Text = senet.Tutar.ToString();
                    txtAsilSahip.Text = senet.AsilSahibi;
                    txtAciklama.Text = senet.Aciklama;

                }
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);

            }
        }
        private void frmYeniSenet_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                SendKeys.Send("{TAB}");
            } else if (Keys.F5 == e.KeyCode) {
                Kaydet();
            } else if (e.KeyCode == Keys.Escape)
                Kapat();
        }
        void Kapat() {
            this.Close();
        }
        void Kaydet() {
            try {
                Senet senet = null;
                if (_senetId.HasValue)
                    senet = _mngSenet.GetById(_senetId.Value, false);
                if (senet == null) {
                    senet = new Senet();
                    senet.KayitTarih = DateTime.Now;
                }
                Cari cari = _mngCari.GetById(txtCariKodu.Text, false);
                if (cari == null) {
                    MessageBox.Show("Cari bulunamadı,lütfen geçerli bir cari kodu giriniz");
                    txtCariKodu.Focus();
                    return;
                }
                senet.Aciklama = txtAciklama.Text;
                senet.AsilSahibi = txtAsilSahip.Text;
                senet.CariKodu = txtCariKodu.Text;
                senet.IslemTarih = dateIslem.Value.JustDate();
                senet.VadeTarih = dateVade.Value.JustDate();
                senet.Kefil1 = txtKefil1.Text;
                senet.Kefil2 = txtKefil2.Text;
                senet.SenetTip = _senetTip;
                senet.SenetDurum =_senetDurum;
                senet.SenetNo = txtSenetNo.Text;
                senet.Sube = UserInfo.Sube;
                senet.Tutar = txtTutar.Text.ParseStruct(x=>double.Parse(x));
               
                BeginTransaction();

                _mngSenet.SaveOrUpdate(senet);
                CariHareket cahar = null;
                CariHarTuru tur = _senetTip == SenetTip.Alinan ? CariHarTuru.AlinanSenet : CariHarTuru.VerilenSenet;
                // cahar=g_mngCariHar.GetByFisNoAndHareketTuruAndCariKod(UserInfo.Sube.Id,cek.Id.ToString(),tur,cek.CariKodu);
                cahar = _mngCariHar.GetByCekOrSenetIdAndHareketTuruAndCariKod(UserInfo.Sube.Id, senet.Id,
                    tur, senet.CariKodu);                    
                   
                if (cahar == null) {
                    cahar = new CariHareket();
                    cahar.CekSenetId = senet.Id;
                    cahar.Sube = UserInfo.Sube;
                    cahar.Tarih = DateTime.Today;
                }
                cahar.Cari = cari;
                if (_senetTip == SenetTip.Alinan) {
                    cahar.Alacak = senet.Tutar;
                    cahar.HareketTuru = CariHarTuru.AlinanSenet;
                    cahar.Aciklama = string.Format("{0} senet no ile ödeme", senet.Id);

                } else if (_senetTip == SenetTip.Verilen) {
                    cahar.Borc = senet.Tutar;
                    cahar.HareketTuru = CariHarTuru.VerilenSenet;
                    cahar.Aciklama = string.Format("{0} senet no ile borçlu", senet.Id);

                }

                cahar.VadeTarih = senet.VadeTarih;
                _mngCariHar.SaveOrUpdate(cahar);

                
            } catch (Exception exc) {
                LogWrite.Write(exc);
                MessageBox.Show(exc.Message);
            } finally {
                try {
                    CommitTransaction();
                    this.Close();
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                    LogWrite.Write(exc);
                }
            }
        }

        private void tsbtnKaydet_Click(object sender, EventArgs e) {
            Kaydet();
        }

        private void tsbtnKapat_Click(object sender, EventArgs e) {
            Kapat();
        }

        private void btnCariRehber_Click(object sender, EventArgs e) {
            frmCariRehber frm = new frmCariRehber();
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
