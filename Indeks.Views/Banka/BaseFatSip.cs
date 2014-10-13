using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Indeks.Data.BusinessObjects;
using Indeks.Data.ManagerObjects;
using Indeks.Data.Report;
using System.Windows.Forms;

namespace Indeks.Views {
    public  class BaseFatSip:BaseForm {
        protected FTIRSIP _ftirsip;
        protected IManagerFactory mng;
        protected IStokManager mngStk;
        protected IStokHareketManager mngSth;
        protected ICariManager mngCari;
        protected Stok _currentStok = null;
        protected Indeks.Print.HesaplaGenelToplam genelToplamlar;
        protected IList<StokHarRpr> listeStok;
        AyarlarManager mngAyar;
        public BaseFatSip():base() {
            mng = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
            mngCari = mng.GetCariManager();
            mngSth = mng.GetStokHareketManager();
            mngStk = mng.GetStokManager();
            //mngAyar = new AyarlarManager(UserInfo.Sube.Id);
        }
        public void DoldurStokBirimleri(Stok stok,ComboBox cmbBox) {
            cmbBox.Items.Clear();
            cmbBox.Text = "";
            if (!string.IsNullOrEmpty(stok.AnaBirim)) {
                cmbBox.Items.Add(stok.AnaBirim.Trim());
                cmbBox.Text = stok.AnaBirim.Trim();
            }
            if (!string.IsNullOrEmpty(stok.AltBirim1))
                cmbBox.Items.Add(stok.AltBirim1.Trim());
            if (!string.IsNullOrEmpty(stok.AltBirim2))
                cmbBox.Items.Add(stok.AltBirim2.Trim());
            if (!string.IsNullOrEmpty(stok.AltBirim3))
                cmbBox.Items.Add(stok.AltBirim3.Trim());
        }
        public string GetCariFiyat(Cari cari, Stok stok, bool alici) {
            if (alici) {
                if (cari.AlisFiyatKod.Trim() == "AlisFiyat1")
                    return stok.AlisFiyat1.FromNullableToString();
                else if (cari.AlisFiyatKod.Trim() == "AlisFiyat2")
                    return stok.AlisFiyat2.FromNullableToString();
                else if (cari.AlisFiyatKod.Trim() == "AlisFiyat3")
                    return stok.AlisFiyat3.FromNullableToString();
            } else {
                if (cari.SatisFiyatKod.Trim() == "SatisFiyat1")
                    return stok.SatisFiyat1.FromNullableToString();
                else if (cari.SatisFiyatKod.Trim() == "SatisFiyat2")
                    return stok.SatisFiyat2.FromNullableToString();
                else if (cari.SatisFiyatKod.Trim() == "SatisFiyat3")
                    return stok.SatisFiyat3.FromNullableToString();
            }
            return "";
        }
        public bool CariVarmi(string cariKodu) {
            try {
                Cari cari = mngCari.GetById(cariKodu,false);
                if (cari == null)
                    return false;
                else
                    return true;

            } catch (Exception exc) {
                LogWrite.Write(exc);
                MessageBox.Show(exc.Message);
            }
            return false;
        }
        public bool OtomatikCariKaydedilsin() {
            try {
                mngAyar = new AyarlarManager(UserInfo.Sube.Id);
                return mngAyar.OtomatikCariKaydet;
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
            return false;
        }
        string BulcariTip() {
            if (_ftirsip == FTIRSIP.AlisFat || _ftirsip == FTIRSIP.AlisIrs || _ftirsip == FTIRSIP.SaticiSip)
                return "S";
            else if (_ftirsip == FTIRSIP.SatisFat || _ftirsip == FTIRSIP.SatisIrs || _ftirsip == FTIRSIP.MusSip)
                return "A";
            return "";
        }
        protected void CariKaydet(string cariKodu)
        {
            try {
                Cari cari = new Cari();
                cari.Id = cariKodu;
                cari.CariIsim = cariKodu;
                cari.KayitTarih = DateTime.Now;
                cari.Sube = UserInfo.Sube;
                cari.CariTip = BulcariTip();
                mngCari.BeginTransaction();
                mngCari.Save(cari);
                
            } catch (Exception exc) {
                LogWrite.Write(exc);
                MessageBox.Show(exc.Message);
            } finally {
                try {
                    mngCari.CommitTransaction();
                } catch (Exception exc) {
                    LogWrite.Write(exc);
                    MessageBox.Show(exc.Message);
                }
            }
        }
        
    }
}
