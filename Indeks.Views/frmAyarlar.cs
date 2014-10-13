using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Indeks.Data.Base;
using Indeks.Data.BusinessObjects;
using Indeks.Data.ManagerObjects;
namespace Indeks.Views {
    public partial class frmAyarlar : Form {
        AyarlarManager _mngAyar;
        public frmAyarlar() {
            InitializeComponent();
            _mngAyar = new AyarlarManager(UserInfo.Sube.Id);
            SetData();
        }
        void SetData() {
            try {
                chkOtomatikCariKaydet.Checked = _mngAyar.OtomatikCariKaydet;
                txtYedek.Text = _mngAyar.DatabaseYedeklemeYeri;
                cmbFatTipi.Text = _mngAyar.VarSayilanFaturaTipi;
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }
        private void frmAyarlar_KeyDown(object sender, KeyEventArgs e) {
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
                _mngAyar.OtomatikCariKaydet = chkOtomatikCariKaydet.Checked;
                _mngAyar.EkleAyar(new Ayarlar { Ad = "YedeklemeYeri",SubeKodu=UserInfo.Sube.Id, Deger1 = txtYedek.Text, SubelerdeOrtak = true });
                _mngAyar.EkleAyar(new Ayarlar { Ad ="VarSayilanFaturaTipi", SubeKodu = UserInfo.Sube.Id, Deger1 = cmbFatTipi.Text, SubelerdeOrtak = true });
                _mngAyar.BeginTransaction();
                _mngAyar.Save();

                MessageBox.Show("Ayarlar kaydedildi");
               
            } catch (Exception) {

            } finally {
                try {
                    _mngAyar.CommitTransaction();
                    Form frm = this.Owner;
                    if (frm != null) {
                        if (frm is frmAnaSayfa) {
                            this.Close();
                        }
                    }
                } catch (Exception exc) {
                    LogWrite.Write(exc);
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void tsbtnKaydet_Click(object sender, EventArgs e) {
            Kaydet();
        }

        private void btnOpenDialog_Click(object sender, EventArgs e) {
            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                txtYedek.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void tsbtnKapat_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}

