using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Indeks.Data.BusinessObjects;
using Indeks.Data.ManagerObjects;
using Indeks.Data.Helper;
using Indeks.Data.Report;
using Indeks.Views.DataExtension;
using System.Windows.Forms;
namespace Indeks.Views {
    public  class BaseKasaRapor:BaseForm {
        IManagerFactory _mng;
        public IKasaHarManager _mngKasaHar;
        public IKasaManager _mngKasa;
        public BaseKasaRapor() {
            _mng = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
            _mngKasa = _mng.GetKasaManager();
            _mngKasaHar = _mng.GetKasaHarManager();
        }
        public KasaHareketDurumlari GetKasaHareketDurumlari(CheckedListBox listBox) {
            KasaHareketDurumlari helper = new KasaHareketDurumlari();
            foreach (object itemChecked in listBox.CheckedItems) {
                itemChecked.IfEqualToSetTrue(itemChecked.ToString(), "MalAlış", (s) => { helper.MalAlis = s; });
                itemChecked.IfEqualToSetTrue(itemChecked.ToString(), "MalSatış", (s) => { helper.MalSatis = s; });
                itemChecked.IfEqualToSetTrue(itemChecked.ToString(), "CaridenTahsilat", (s) => { helper.CaridenTahsilat = s; });
                itemChecked.IfEqualToSetTrue(itemChecked.ToString(), "CariyeÖdeme", (s) => { helper.CariyeOdeme = s; });
                itemChecked.IfEqualToSetTrue(itemChecked.ToString(), "BankayaYatan", (s) => { helper.BankayaYatan = s; });
                itemChecked.IfEqualToSetTrue(itemChecked.ToString(), "BankadanÇekilen", (s) => { helper.BankadanCekilen = s; });
                itemChecked.IfEqualToSetTrue(itemChecked.ToString(), "ÇekGelir", (s) => { helper.CekGelir = s; });
                itemChecked.IfEqualToSetTrue(itemChecked.ToString(), "ÇekGider", (s) => { helper.CekGider = s; });
                itemChecked.IfEqualToSetTrue(itemChecked.ToString(), "SenetGelir", (s) => { helper.SenetGelir = s; });
                itemChecked.IfEqualToSetTrue(itemChecked.ToString(), "SenetGider", (s) => { helper.SenetGider = s; });
                itemChecked.IfEqualToSetTrue(itemChecked.ToString(), "ÖzelGelir", (s) => { helper.OzelGelir = s; });
                itemChecked.IfEqualToSetTrue(itemChecked.ToString(), "ÖzelGider", (s) => { helper.OzelGider = s; });

            }
            return helper;
        
        }
        public void SelectCheckBoxes(CheckedListBox listBox, bool state) {
            for (int i = 0; i < listBox.Items.Count; i++) {
                listBox.SetItemChecked(i, state);
            }
        }
        public void LoadKasa(ComboBox cmb) {
            try {
                bool first = true;
                List<Kasa> kasalar = _mngKasa.GetKasaBySubeKodu(UserInfo.Sube.Id);
                foreach (Kasa kas in kasalar) {
                    cmb.Items.Add(kas.Id);
                    if (first) {
                        cmb.Text = kas.Id;
                        first = false;
                    }
                }
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }
    }
}
