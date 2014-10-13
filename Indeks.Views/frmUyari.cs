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
using Indeks.Data.Base;
namespace Indeks.Views {
    public partial class frmUyari : Form {
        IManagerFactory _mngFac;
        IFatIrsUstManager _mngFatIrsUst;
        ISiparisUstManager _mngSipUst;
        ICekManager _mngCek;
        ISenetManager _mngSenet;
        public frmUyari() {
            InitializeComponent();
            _mngFac = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
            _mngFatIrsUst = _mngFac.GetFatirsUstManager();
            _mngSipUst = _mngFac.GetSiparisUstManager();
            _mngCek = _mngFac.GetCekManager();
            _mngSenet = _mngFac.GetSenetManager();
            LoadValues();
        }
        void LoadValues() {
            try {
                dataGridViewFatura.AutoGenerateColumns = false;
                dataGridViewIrsaliye.AutoGenerateColumns = false;
                dataGridViewSiparis.AutoGenerateColumns = false;
                dataGridViewCek.AutoGenerateColumns = false;
                dataGridViewSenet.AutoGenerateColumns = false;
                List<Senet> senetListe = _mngSenet.GetListSenetByVadeTarih(UserInfo.Sube.Id,DateTime.Today);
                List<Cek> cekListe = _mngCek.GetListCekByVadeTarih(UserInfo.Sube.Id,DateTime.Today);
                List<FatIrsUst> fatListe = _mngFatIrsUst.GetListFaturaToday(UserInfo.Sube.Id);
                List<FatIrsUst> irsListe = _mngFatIrsUst.GetListIrsaliyeSevkToday(UserInfo.Sube.Id);
                List<SiparisUst> sipListe = _mngSipUst.GetListSiparisTeslimToday(UserInfo.Sube.Id);
                dataGridViewFatura.DataSource = fatListe;
                dataGridViewIrsaliye.DataSource = irsListe;
                dataGridViewSiparis.DataSource = sipListe;
                dataGridViewCek.DataSource = cekListe;
                dataGridViewSenet.DataSource = senetListe;
                if (fatListe.Count > 0) {
                    tabPageFat.ForeColor = Color.Red;
                    tabPageFat.Text = string.Format("{0} tane vadesi gelmiş Faturanız var",fatListe.Count);                    
                }
                if (irsListe.Count > 0) {
                    tabPageIrs.ForeColor = Color.Red;
                    tabPageIrs.Text = string.Format("{0} tane sevk tarihi gelmiş İrsaliyeniz var",irsListe.Count);
                }
                if (sipListe.Count > 0) {
                    tabPageSip.ForeColor = Color.Red;
                    tabPageSip.Text = string.Format("{0} tane teslim tarihi gelmiş Siparişiniz var", sipListe.Count);
                }
                if (cekListe.Count > 0) {
                    tabPageCek.ForeColor = Color.Red;
                    tabPageCek.Text = string.Format("{0} tane vadesi gelmiş Çekiniz var", cekListe.Count);
                }
                if (senetListe.Count > 0) {
                    tabPageSen.ForeColor = Color.Red;
                    tabPageSen.Text = string.Format("{0} tane vadesi gelmiş Senetiniz var", senetListe.Count);
                }
            } catch (Exception exc) {
                MessageBox.Show(exc.Message); LogWrite.Write(exc);
            }
        }
    }
}
