using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Indeks.Data.ManagerObjects;
using Indeks.Data.BusinessObjects;
using System.IO;
using Indeks.Views.ReportHelp;
namespace Indeks.Views {
    public partial class frmStokHareketListesi : Form {
        IManagerFactory mngFac;
        IStokHareketManager mngstokHar;
        string _stokKodu;
        string _gcKod;
        DateTime? _beginDate;
        DateTime? _finishDate;
        public frmStokHareketListesi(string stokKodu,string gcKod,DateTime? beginDate,DateTime? fisihDate) {
            InitializeComponent();
            mngFac = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
            mngstokHar = mngFac.GetStokHareketManager();
            _stokKodu = stokKodu;
            _gcKod = gcKod;
            _finishDate = fisihDate;
            _beginDate = beginDate;
            LoadData();
        }
        void LoadData() {
            try {
                DataTable _source = new DataTable();
                if (_beginDate.HasValue && _finishDate.HasValue)
                    _source = mngstokHar.StokHareketDokumu(UserInfo.Sube.Id, _stokKodu, _gcKod,_beginDate.Value
                        ,_finishDate.Value);
                else
                    _source = mngstokHar.StokHareketDokumu(UserInfo.Sube.Id, _stokKodu, _gcKod);
                _source.Replace("GCKod", "G", "MalAlış"); _source.Replace("GCKod", "C", "MalSatış");
                _source.Replace("Tip", "F", "Fatura"); _source.Replace("Tip", "I", "İrsaliye");
                dataGridView1.DataSource = _source;
                dataGridView1.Columns["Tutar"].DefaultCellStyle.Format = "F2";
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            
        }

        private void faturayaGitToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                DataGridViewRow r = dataGridView1.CurrentRow;
                if (r != null) {
                    string fisNo = dataGridView1.CurrentRow.Cells["FisNo"].Value.ToStringOrEmpty();
                    string tip = dataGridView1.CurrentRow.Cells["Tip"].Value.ToStringOrEmpty();
                    string kod = dataGridView1.CurrentRow.Cells["GCKod"].Value.ToStringOrEmpty();
                    FTIRSIP ftir = FTIRSIP.AlisFat;
                    Indeks.Data.Helper.FatNoTip fatn = Indeks.Data.Helper.FatNoTip.Fatura;
                    if (tip == "Fatura") {
                        fatn = Indeks.Data.Helper.FatNoTip.Fatura;
                        if (kod == "MalAlış")
                            ftir = FTIRSIP.AlisFat;
                        else {
                            if (fisNo.StartsWith("0ds"))
                                ftir = FTIRSIP.DirektSatis;
                            else
                                ftir = FTIRSIP.SatisFat;
                        }
                    } else if (tip == "İrsaliye") {
                        fatn = Indeks.Data.Helper.FatNoTip.Irsaliye;
                        if (kod == "MalAlış")
                            ftir = FTIRSIP.AlisIrs;
                        else
                            ftir = FTIRSIP.SatisFat;
                    }
                    frmFatura frm = new frmFatura(ftir, fatn, fisNo);
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                }
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }
    }
}
