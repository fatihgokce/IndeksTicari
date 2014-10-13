using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Indeks.Data.BusinessObjects;
using Indeks.Data.Report;
using Indeks.Data.Base;
using Indeks.Data.ManagerObjects;
namespace Indeks.Views {
    public partial class frmStokListe : Form {
        IManagerFactory mngFac;
        IStokHareketManager mngStokHar;
        public frmStokListe(string fisNo) {
            InitializeComponent();
            mngFac = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
            mngStokHar = mngFac.GetStokHareketManager();
            try {
                dataGridView1.AutoGenerateColumns = false;
                IList<StokHarRpr> rpr = mngStokHar.GetByFisNoAndSubeKodu(fisNo, UserInfo.Sube.Id);
                dataGridView1.DataSource = rpr;
                dataGridView1.Columns[clTutar.Name].DefaultCellStyle.Format = "F2";
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }

        public frmStokListe(FTIRSIP ftirsip, string fisNo) {
            InitializeComponent();
            mngFac = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
            mngStokHar = mngFac.GetStokHareketManager();
            try {
                dataGridView1.AutoGenerateColumns = false;
                IList<StokHarRpr> rpr = mngStokHar.GetByFisNoAndSubeKodu(fisNo, UserInfo.Sube.Id, ftirsip);
                dataGridView1.DataSource = rpr;
                dataGridView1.Columns[clTutar.Name].DefaultCellStyle.Format = "F2";
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }

    }
}
