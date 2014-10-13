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
    public partial class frmOzelGelirGider : Form {
        IOzelGelirGiderManager _mngOzel;
        string _kod;
        GelirGider _gelirGider;
        public frmOzelGelirGider(string ozelGelirGiderKod,GelirGider gelirGider) {
            _kod = ozelGelirGiderKod;
            InitializeComponent();
            _gelirGider = gelirGider;
            _mngOzel = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType()).GetOzelGelirGiderManager();
            SetData();
        }
        public frmOzelGelirGider(GelirGider gelirGider) {
            InitializeComponent();
            _gelirGider = gelirGider;
            _mngOzel = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType()).GetOzelGelirGiderManager();
        }
        
        void SetData() {
            try {
                OzelGelirGider ozel = _mngOzel.GetById(_kod,false);
                txtKod.Text = ozel.Id;
                txtIsim.Text = ozel.Ismi;
                txtKdvOrani.Text = ozel.KdvOrani.GetValueOrDefault().ToString();
                txtIsim.Focus();
                txtKod.Enabled = false;
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }
        void Kaydet() {
            try {
                OzelGelirGider ozel = null;
                if (!string.IsNullOrEmpty(_kod))
                    ozel = _mngOzel.GetById(_kod, false);
                else { 
                    ozel = new OzelGelirGider();
                    ozel.Id = txtKod.Text; 
                }
                if (ozel == null) {
                    ozel = new OzelGelirGider();
                    ozel.Id = txtKod.Text;
                }
                ozel.Ismi = txtIsim.Text;
                ozel.KdvOrani = txtKdvOrani.Text.ParseNullable<double>(x => double.Parse(x));
                ozel.GelirGider = _gelirGider;
                _mngOzel.BeginTransaction();
                _mngOzel.SaveOrUpdate(ozel);
               
                this.Close();
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            } finally {
                try {
                    _mngOzel.CommitTransaction();
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                    LogWrite.Write(exc);
                }
            }
        }
        private void frmOzelGelirGider_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                SendKeys.Send("{TAB}");
            } else if (Keys.F5 == e.KeyCode) {
                Kaydet();
            } else if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void tsbtnKaydet_Click(object sender, EventArgs e) {
            Kaydet();
        }

        private void tsbtnKapat_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
