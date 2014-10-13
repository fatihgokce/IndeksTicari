using System;
using System.Windows.Forms;
using Indeks.Data.BusinessObjects;
using Indeks.Data.ManagerObjects;
namespace Indeks.Views {
    public partial class frmCek : BaseForm {
        IManagerFactory mngFac;
        ICekManager mngCek;
        ICariHareketManager mngCahar;
        IHesapHareketManager mngHesapHar;
        IKasaHarManager mngKasaHar;
            public frmCek() {
            InitializeComponent();
                mngFac=new ManagerFactory(Engine.GetConString(),Engine.GetSqlServerType());
                mngCek=mngFac.GetCekManager();
                mngCahar = mngFac.GetCariHareketManager();
                mngHesapHar = mngFac.GetHesapHareketManager();
                mngKasaHar = mngFac.GetKasaHarManager();
                dataGridViewCek.AutoGenerateColumns = false;
                LoadGrid();
                cmbCekTip.DataSource = Enum.GetValues(typeof(CekTip));
                LoadCekDurum();            
        }
        void LoadCekDurum() {            
            Array ary = Enum.GetValues(typeof(CekDurum));
            cmbCekDurum.Items.Add("Hepsi");
            foreach (object obj in ary)
                cmbCekDurum.Items.Add(obj);
            
        }
        void LoadGrid() {
            try {
                dataGridViewCek.DataSource = mngCek.GetListBySUBE_KODU(UserInfo.Sube.Id);
            } catch (Exception exc) {
                LogWrite.Write(exc);
                MessageBox.Show(exc.Message);
            }
            
        
        }


        private void dataGridViewCek_CellClick(object sender, DataGridViewCellEventArgs e) {
            //DataGridViewRow dr = dataGridViewCek.CurrentRow;
            //string s=dr.Cells[clDurum.Name].Value.ToString();
            //CekDurum durum = (CekDurum)Enum.Parse(typeof(CekDurum),s,true);
            //MessageBox.Show(durum.ToString());

                
        }
        void Ara() {
            try {
                CekDurum? durum=null;
                string key=string.Empty;
                if (!string.IsNullOrEmpty(txtAnahtarKelime.Text) && txtAnahtarKelime.Text.CompareTo("Aranacak kelime...") != 0)
                    key = txtAnahtarKelime.Text;
                if (!String.IsNullOrEmpty(cmbCekDurum.Text) && cmbCekDurum.Text.Trim() != "Hepsi")
                    durum = (CekDurum)Enum.Parse(typeof(CekDurum),cmbCekDurum.Text);
                dataGridViewCek.DataSource = mngCek.GetListWithSearhKey(UserInfo.Sube.Id,key,durum);
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
            CekTip tip =(CekTip) Enum.Parse(typeof(CekTip), cmbCekTip.Text);
            frmYeniCek frm = new frmYeniCek(CekDurum.Beklemede,tip);
            frm.ShowDialog();
            LoadGrid();
        }

        private void btnSil_Click(object sender, EventArgs e) {
            DialogResult re = MessageBox.Show("Kayıt Silinsin mi?", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (re == DialogResult.Yes) {
                try {

                    DataGridViewRow dr = dataGridViewCek.SelectedRows[0];
                    if (dr != null) {
                        string subeKodu = UserInfo.Sube.Id;
                        Cek cek = mngCek.SingleOrDefault<Cek>(x => x.Id == int.Parse(dr.Cells[clId.Name].Value.ToString()));
                        CariHarTuru tur = cek.CekTip == CekTip.Alinan ? CariHarTuru.AlinanCek :
                              CariHarTuru.VerilenCek;
                        CariHareket cahar = mngCahar.GetByCekOrSenetIdAndHareketTuruAndCariKod
                                          (UserInfo.Sube.Id, cek.Id, tur, cek.CariKodu);

                        HesapHareket hesap = mngHesapHar.GetByCekOrSenetIdAndHareketTuru(subeKodu, cek.Id, HesapHareketTuru.CekTahsil);
                        KasaHareket kasahar = mngKasaHar.GetByTipAndCekOrSenetId(subeKodu
                    , KasaHarTip.Cek, cek.Id);
                        BeginTransaction();
                        if (hesap != null)
                            mngHesapHar.Delete(hesap);
                        if (kasahar != null)
                            mngKasaHar.Delete(kasahar);
                        mngCek.Delete(cek);
                        mngCahar.Delete(cahar);

                    }

                } catch (Exception) {
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

        private void dataGridViewCek_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            Duzelt();            
        }

        private void btnCekDurum_Click(object sender, EventArgs e) {
            DataGridViewRow dr = dataGridViewCek.CurrentRow;
            if (dr != null) {
                CekDurum durum = (CekDurum)Enum.Parse(typeof(CekDurum),dr.Cells[clDurum.Name].Value.ToString());
                CekTip tip = (CekTip)Enum.Parse(typeof(CekTip),dr.Cells[clCekTip.Name].Value.ToString());
                int cekId = dr.Cells[clId.Name].Value.ToString().ParseStruct<int>(x=>int.Parse(x));
                frmCekDurum frm = new frmCekDurum(cekId, tip, durum);
                frm.ShowDialog();
                LoadGrid();
            }
        }
        void Duzelt() {
            DataGridViewRow dr = dataGridViewCek.CurrentRow;
            if (dr != null) {
                CekDurum durum = (CekDurum)Enum.Parse(typeof(CekDurum), dr.Cells[clDurum.Name].Value.ToString());
                if (durum == CekDurum.Beklemede) {
                    int id = dr.Cells[clId.Name].Value.ToStringOrEmpty().ParseStruct(x => int.Parse(x));
                    CekTip tip = (CekTip)Enum.Parse(typeof(CekTip), dr.Cells[clCekTip.Name].Value.ToString());

                    frmYeniCek frm = new frmYeniCek(id, durum, tip);
                    frm.ShowDialog();
                    LoadGrid();
                } else {
                    MessageBox.Show("Çeki düzeltebilmek için çekin durumunu Beklemede durumuna getirmeniz gerekli.");
                }
            }
        }
        private void btnDuzelt_Click(object sender, EventArgs e) {
            Duzelt();

        }

        private void dataGridViewCek_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

    }
}
