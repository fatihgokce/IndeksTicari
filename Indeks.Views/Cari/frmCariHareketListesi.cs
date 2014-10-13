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
using Indeks.Data.Helper;
using Indeks.Data.Report;
using Indeks.Views.ReportHelp;
namespace Indeks.Views {
    public partial class frmCariHareketListesi : Form {
        IManagerFactory _mng;
        ICariHareketManager _mngCariHar;
        CariHareketleriDurumu _cariDurum;
        string _cariKodu;
        public frmCariHareketListesi(CariHareketleriDurumu cariHareketDurum,string cariKodu) {
            InitializeComponent();
            _mng = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
            _mngCariHar = _mng.GetCariHareketManager();
            _cariDurum = cariHareketDurum;
            _cariKodu = cariKodu;
            LoadData();
        }
        void LoadData() {
            try {
                DataTable _source = _mngCariHar.CariHareketDokumu(UserInfo.Sube.Id, _cariKodu,_cariDurum);
                _source.Replace("HareketTuru", "2", "NakitTahsilat");
                _source.Replace("HareketTuru", "3", "NakitÖdeme");
                _source.Replace("HareketTuru", "4", "AlınanMal"); _source.Replace("HareketTuru", "5", "SatılanMal");
                _source.Replace("HareketTuru", "6", "AlınanMalIadesi"); _source.Replace("HareketTuru", "7", "SatılanMalIadesi");
                _source.Replace("HareketTuru", "8", "AlınanÇek"); _source.Replace("HareketTuru", "9", "VerilenÇek");
                _source.Replace("HareketTuru", "10", "ÇekCirosu"); _source.Replace("HareketTuru", "11", "AlınanÇekIade");
                _source.Replace("HareketTuru", "12", "VerilenÇekGeriAlınması"); _source.Replace("HareketTuru", "13", "KarşılıksızÇek");
                _source.Replace("HareketTuru", "14", "AlınanSenet"); _source.Replace("HareketTuru", "15", "VerilenSenet");
                _source.Replace("HareketTuru", "16", "SenetCirosu"); _source.Replace("HareketTuru", "17", "AlınanSenetIade");
                _source.Replace("HareketTuru", "18", "VerilenSenetGeriAlınması"); _source.Replace("HareketTuru", "19", "KarşılıksızSenet");
                _source.Replace("HareketTuru", "20", "Veresiye"); _source.Replace("HareketTuru", "21", "GelenHavale");
                _source.Replace("HareketTuru", "22", "GönderilenHavale");
                dataGridView1.DataSource = _source;
            } catch (Exception exc) {
                LogWrite.Write(exc);
                MessageBox.Show(exc.Message);
            }
        }
    }
}
