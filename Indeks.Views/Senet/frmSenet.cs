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
    public partial class frmSenet : BaseForm {
        IManagerFactory _mngFac;
        ISenetManager _mngSenet;
        ICariHareketManager _mngCariHar;
        IKasaHarManager _mngKasaHar;
        IHesapHareketManager _mngHesapHar;
        public frmSenet() {
            InitializeComponent();
            _mngFac = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
            _mngSenet = _mngFac.GetSenetManager();
            _mngCariHar = _mngFac.GetCariHareketManager();
            _mngHesapHar = _mngFac.GetHesapHareketManager();
            _mngKasaHar = _mngFac.GetKasaHarManager();
            dataGridViewSenet.AutoGenerateColumns = false;
            cmbSenetTip.DataSource = Enum.GetValues(typeof(SenetTip));
            LoadGrid();
            LoadSenetDurum();
        }
        void LoadSenetDurum() {
            Array ary = Enum.GetValues(typeof(SenetDurum));
            cmbSenetDurum.Items.Add("Hepsi");
            foreach (object obj in ary)
                cmbSenetDurum.Items.Add(obj);

        }
        void LoadGrid() {
            try {
                dataGridViewSenet.DataSource = _mngSenet.GetListSUBE_KODU(UserInfo.Sube.Id);
            } catch (Exception exc) {
                LogWrite.Write(exc);
                MessageBox.Show(exc.Message);
            }


        }
        void Ara() {
            try {
                SenetDurum? durum = null;
                string key = string.Empty;
                if (!string.IsNullOrEmpty(txtAnahtarKelime.Text) && txtAnahtarKelime.Text.CompareTo("Aranacak kelime...") != 0)
                    key = txtAnahtarKelime.Text;
                if (!String.IsNullOrEmpty(cmbSenetDurum.Text) && cmbSenetDurum.Text.Trim() != "Hepsi")
                    durum = (SenetDurum)Enum.Parse(typeof(CekDurum), cmbSenetDurum.Text);
                dataGridViewSenet.DataSource = _mngSenet.GetListWithSearchKey(UserInfo.Sube.Id, key, durum);
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }

        private void txtAnahtarKelime_KeyDown(object sender, KeyEventArgs e) {
            if (txtAnahtarKelime.Text == "Aranacak kelime...")
                txtAnahtarKelime.Text = string.Empty;
            if (e.KeyCode == Keys.Enter) {
                Ara();
            }
        }

        private void txtAnahtarKelime_Leave(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtAnahtarKelime.Text)) {
                txtAnahtarKelime.Text = "Aranacak kelime...";
                LoadGrid();
            }
        }

        private void btnAra_Click(object sender, EventArgs e) {
            Ara();  
        }

        private void btnYeniCek_Click(object sender, EventArgs e) {
            SenetTip tip = (SenetTip)Enum.Parse(typeof(CekTip), cmbSenetTip.Text);
            frmYeniSenet frm = new frmYeniSenet(SenetDurum.Beklemede, tip);
            frm.ShowDialog();
            LoadGrid();
        }

        private void btnSil_Click(object sender, EventArgs e) { 
            DialogResult re = MessageBox.Show("Kayıt Silinsin mi?", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (re == DialogResult.Yes) {
                try {

                    DataGridViewRow dr = dataGridViewSenet.SelectedRows[0];
                    if (dr != null) {
                        string subeKodu = UserInfo.Sube.Id;
                        Senet senet = _mngSenet.SingleOrDefault<Senet>(x => x.Id == int.Parse(dr.Cells[clId.Name].Value.ToString()));
                        CariHarTuru tur = senet.SenetTip == SenetTip.Alinan ? CariHarTuru.AlinanSenet :
                              CariHarTuru.VerilenCek;
                        CariHareket cahar = _mngCariHar.GetByCekOrSenetIdAndHareketTuruAndCariKod(UserInfo.Sube.Id, senet.Id, tur, senet.CariKodu);
                        HesapHareket hesap = _mngHesapHar.GetByCekOrSenetIdAndHareketTuru(subeKodu, senet.Id, HesapHareketTuru.SenetTahsil);
                        KasaHareket kasahar = _mngKasaHar.GetByTipAndCekOrSenetId(subeKodu
                    , KasaHarTip.Senet, senet.Id);
                        BeginTransaction();
                        if (hesap != null)
                            _mngHesapHar.Delete(hesap);
                        if (kasahar != null)
                            _mngKasaHar.Delete(kasahar);
                        _mngSenet.Delete(senet);
                        _mngCariHar.Delete(cahar);

                    }

                } catch (Exception exc) {
                    LogWrite.Write(exc);
                    MessageBox.Show(exc.Message);
                } finally {
                    try {
                        CommitTransaction();
                        LoadGrid();
                    } catch (Exception exc) {
                        MessageBox.Show(exc.Message);
                        LogWrite.Write(exc);
                    }
                }
            }
        }
        void Duzelt() {
            DataGridViewRow dr = dataGridViewSenet.CurrentRow;
            if (dr != null) {
                SenetDurum durum = (SenetDurum)Enum.Parse(typeof(SenetDurum), dr.Cells[clDurum.Name].Value.ToString());
                if (durum == SenetDurum.Beklemede) {
                    int id = dr.Cells[clId.Name].Value.ToStringOrEmpty().ParseStruct(x => int.Parse(x));
                    SenetTip tip = (SenetTip)Enum.Parse(typeof(SenetTip), dr.Cells[clSenetTip.Name].Value.ToString());

                    frmYeniSenet frm = new frmYeniSenet(id, durum, tip);
                    frm.ShowDialog();
                    LoadGrid();
                } else {
                    MessageBox.Show("Seneti düzeltebilmek için senetin durumunu Beklemede durumuna getirmeniz gerekli.");
                }
            }
        }
        private void dataGridViewSenet_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            Duzelt(); 
        }

        private void btnDuzelt_Click(object sender, EventArgs e) {
            Duzelt();
        }

        private void btnSenetDurum_Click(object sender, EventArgs e) {
            DataGridViewRow dr = dataGridViewSenet.CurrentRow;
            if (dr != null) {
                SenetDurum durum = (SenetDurum)Enum.Parse(typeof(SenetDurum), dr.Cells[clDurum.Name].Value.ToString());
                SenetTip tip = (SenetTip)Enum.Parse(typeof(SenetTip), dr.Cells[clSenetTip.Name].Value.ToString());
                int senetId = dr.Cells[clId.Name].Value.ToString().ParseStruct<int>(x => int.Parse(x));
                frmSenetDurum frm = new frmSenetDurum(senetId, tip, durum);
                frm.ShowDialog();
                LoadGrid();
            }
        }

       
    }
}
