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
    public partial class frmOzelGelirGiderListe : Form {
        IOzelGelirGiderManager _mngOzelGelirGider;
        GelirGider _gelirGider;
        public frmOzelGelirGiderListe(GelirGider gelirGider) {
            InitializeComponent();
            _gelirGider = gelirGider;
            _mngOzelGelirGider = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType()).GetOzelGelirGiderManager();
            LoadGrid();
        }
        void LoadGrid() {
            try {
                dataGridView1.DataSource = _mngOzelGelirGider.GetList<OzelGelirGider>(x=>x.GelirGider==_gelirGider);
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            Sec();
        }
        void Sec() {
            try {
                DataGridViewRow dr = dataGridView1.CurrentRow;
                if (this.Owner is frmKasaKayitlari) {
                    frmKasaKayitlari frm = (frmKasaKayitlari)this.Owner;
                    frm.txtOzelGelirGiderKodu.Text = dr.Cells[clId.Name].Value.ToStringOrEmpty();
                    frm.txtOzelGelirGiderAdi.Text = dr.Cells[clIsmi.Name].Value.ToStringOrEmpty();
                    frm.txtOzelKdvOrani.Text = dr.Cells[clKdvOrani.Name].Value.ToStringOrEmpty();
                } else if (this.Owner is frmOzelGelirGiderRapor) {
                    frmOzelGelirGiderRapor frm = (frmOzelGelirGiderRapor)this.Owner;
                    frm.txtOzelGelirGiderKod.Text = dr.Cells[clId.Name].Value.ToStringOrEmpty();
                }
                this.Close();
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            
            }
        }
        private void btnSec_Click(object sender, EventArgs e) {
            Sec();
        }

        private void btnDuzelt_Click(object sender, EventArgs e) {
            try {
                DataGridViewRow dr = dataGridView1.CurrentRow;
                string kod = dr.Cells[clId.Name].Value.ToStringOrEmpty();
                if (string.IsNullOrEmpty(kod))
                    MessageBox.Show("grid den özel gelir gider seçiniz.");
                else {
                    frmOzelGelirGider frm = new frmOzelGelirGider(kod,_gelirGider);
                    frm.ShowDialog();
                    LoadGrid();
                }
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }

        private void btnYeni_Click(object sender, EventArgs e) {
            frmOzelGelirGider frm = new frmOzelGelirGider(_gelirGider);
            frm.ShowDialog();
            LoadGrid();
        }

        private void btnSil_Click(object sender, EventArgs e) {
            try {
                  DialogResult re = MessageBox.Show("Kayıt Silinsin mi?", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                  if (re == DialogResult.Yes) {
                      DataGridViewRow dr = dataGridView1.CurrentRow;
                      string kod = dr.Cells[clId.Name].Value.ToStringOrEmpty();
                      OzelGelirGider ozel = _mngOzelGelirGider.GetById(kod,false);
                      if (ozel != null) {
                          _mngOzelGelirGider.BeginTransaction();
                          _mngOzelGelirGider.Delete(ozel);
                          _mngOzelGelirGider.CommitTransaction();
                          LoadGrid();
                      }
                  }
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }
    }
}
