using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Indeks.Data.ManagerObjects;
using Indeks.Data.Helper;
using System.Diagnostics;
using System.IO;
using Indeks.Views.ReportHelp;
using Doddle.Reporting.Writers;
using Doddle.Reporting;
using Indeks.Data.BusinessObjects;
namespace Indeks.Views {
    public partial class frmFaturaRapor : Form {
        IManagerFactory _mng;
        ICariManager _mngCari;
        IFatIrsUstManager _mngFatUst;
        DataTable _source;
        bool _isFatura;
        public frmFaturaRapor(bool isFatura) {
            InitializeComponent();
            _mng = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
            _mngCari = _mng.GetCariManager();
            _mngFatUst = _mng.GetFatirsUstManager();
            _isFatura = isFatura;
            SettingScreen();
            txtCariKodu.DataSource = () =>
            {
                try {
                    return _mngCari.GetCariKodsBySubeKodu(UserInfo.Sube.Id, txtCariKodu.Text).ToStringList(15, txtCariKodu.Ayirac);
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                    LogWrite.Write(exc);
                }
                return null;

            };
        }
        void SettingScreen() {
            checkedListBoxFatTipleri.Items.Clear();
            checkedListBoxFaturalar.Items.Clear();
            if (_isFatura) {
                this.Text = "FaturaRaporu";
                tabPageFiltre.Text = "FaturaRaporu";
                groupBoxIrsaliyeFatura.Text = "Faturalar";
                groupBoxFaturaTipleri.Text = "Fatura Tipleri";              
                checkedListBoxFaturalar.Items.AddRange
                    (
                    new string[] { "AlışFaturası", "SatışFaturası" }
                    );
                checkedListBoxFatTipleri.Items.AddRange
                    (
                    new string[] { "Vadeli", "Peşin", "Iade", "KrediKartı" }
                    );
            } else {
                this.Text = "İrsaliyeRaporu";
                tabPageFiltre.Text = "İrsaliyeRaporu";
                groupBoxIrsaliyeFatura.Text = "İrsaliyeler";
                groupBoxFaturaTipleri.Text = "İrsaliye Tipleri";
                checkedListBoxFaturalar.Items.AddRange
                    (
                    new string[] { "AlışIrsaliyesi", "SatışIrsaliyesi" }
                    );
                checkedListBoxFatTipleri.Items.AddRange
                    (
                    new string[] { "Vadeli", "Peşin", "Iade", }
                    );
            }
        }
        void LoadGrid() {
            try {
                DateTime? dtTarBas = null, dtTarBit = null, dtVadeBas = null, dtVadeBit = null;
                if ((dtTarBasTar.Value != dtTarBitTar.Value && dtTarBasTar.Value < dtTarBitTar.Value)) {
                    dtTarBas = dtTarBasTar.Value;
                    dtTarBit = dtTarBitTar.Value;
                }
                if ((dtVadeBasTar.Value != dtVadeBitTar.Value && dtVadeBasTar.Value < dtVadeBitTar.Value)) {
                    dtVadeBas = dtVadeBasTar.Value;
                    dtVadeBit = dtVadeBitTar.Value;
                }
             
                _source=_mngFatUst.FaturaRapor(UserInfo.Sube.Id,
                    SecilenFaturaDurumlari(),SecilenFaturaTipDurumlari(),txtCariKodu.Text,
                    dtTarBas,dtTarBit,dtVadeBas,dtVadeBit);
                _source.Replace("FaturaIrsaliyeTuru", "1", "SatışFaturası");
                _source.Replace("FaturaIrsaliyeTuru", "2", "AlışFaturası");
                _source.Replace("FaturaIrsaliyeTuru", "3", "SatışIrsaliyesi");
                _source.Replace("FaturaIrsaliyeTuru", "4", "AlışIrsaliyesi");
                _source.Replace("FaturaIrsaliyeTuru", "7", "SatışFaturası");
                _source.Replace("FaturaIrsaliyeTipi", "1", "Peşin");
                _source.Replace("FaturaIrsaliyeTipi", "2", "Vadeli");
                _source.Replace("FaturaIrsaliyeTipi", "4", "Iade");
                _source.Replace("FaturaIrsaliyeTipi", "5", "KrediKartı");
                dataGridView1.DataSource = _source;
                if (_source != null && _source.Rows.Count > 0) {
                    tslabToplamKdvTutar.Text = toplamKdvTutar().ToString("F2");
                    tslabToplamBrutTutar.Text = toplamBrutTutar().ToString("F2");
                    tslabToplamTutar.Text = toplamTutar().ToString("F2");
                    tslabToplamIskonto.Text = toplamIskonto().ToString("F2");
                    dataGridView1.Columns["Tutar"].DefaultCellStyle.Format = "F2";
                    dataGridView1.Columns["KdvTutar"].DefaultCellStyle.Format = "F2";
                    dataGridView1.Columns["BrutTutar"].DefaultCellStyle.Format = "F2";
                }


            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }
        double toplamKdvTutar() {
            if (_source != null && _source.Rows.Count > 0)
                return double.Parse(_source.Compute("sum(KdvTutar)", "").ToString());
            else
                return 0;
        }
        double toplamBrutTutar() {
            if (_source != null && _source.Rows.Count > 0)
                return double.Parse(_source.Compute("sum(BrutTutar)", "").ToString());
            else
                return 0;
        }
        double toplamIskanto() {
            if (_source != null && _source.Rows.Count > 0)
                return double.Parse(_source.Compute("sum(Iskanto)", "").ToString());
            else
                return 0;
        }
        double toplamTutar() {
            if (_source != null && _source.Rows.Count > 0)
                return double.Parse(_source.Compute("sum(Tutar)", "").ToString());
            else
                return 0;
        }
        double toplamIskonto() {
            if (_source != null && _source.Rows.Count > 0)
                return double.Parse(_source.Compute("sum(Iskanto)", "").ToString());
            else
                return 0;
        }
        FaturaIrsaliyeDurumlari SecilenFaturaDurumlari() {
            FaturaIrsaliyeDurumlari durum = new FaturaIrsaliyeDurumlari();
            
            foreach (object itemChecked in checkedListBoxFaturalar.CheckedItems) {
                itemChecked.IfEqualToSetTrue(itemChecked.ToString(), "AlışFaturası", (s) => { durum.AlisFaturasi = s; });
                itemChecked.IfEqualToSetTrue(itemChecked.ToString(), "SatışFaturası", (s) => { durum.SatisFaturasi = s; });
                itemChecked.IfEqualToSetTrue(itemChecked.ToString(), "AlışIrsaliyesi", (s) => { durum.AlisIrsaliyesi = s; });
                itemChecked.IfEqualToSetTrue(itemChecked.ToString(), "SatışIrsaliyesi", (s) => { durum.SatisIrsaliyesi = s; });   
                
            }
            if (checkedListBoxFaturalar.CheckedItems.Count == 0) {
                if (_isFatura) {
                    durum.AlisFaturasi = true; durum.SatisFaturasi = true;
                } else { durum.SatisIrsaliyesi = true; durum.AlisIrsaliyesi = true; }
            }

            return durum;
        }
        FaturaTipDurum SecilenFaturaTipDurumlari() {
            FaturaTipDurum durum = new FaturaTipDurum();

            foreach (object itemChecked in checkedListBoxFatTipleri.CheckedItems) {
                itemChecked.IfEqualToSetTrue(itemChecked.ToString(), "Vadeli", (s) => { durum.Vadeli = s; });
                itemChecked.IfEqualToSetTrue(itemChecked.ToString(), "Peşin", (s) => { durum.Pesin = s; });
                itemChecked.IfEqualToSetTrue(itemChecked.ToString(), "Iade", (s) => { durum.Iade = s; });
                itemChecked.IfEqualToSetTrue(itemChecked.ToString(), "KrediKartı", (s) => { durum.KrediKarti = s; });
            }

            return durum;
        }
        private void btnRapor_Click(object sender, EventArgs e) {
            LoadGrid();
            btnPrint.Visible = true;
        }
        string SecilenCari() {
            if (string.IsNullOrEmpty(txtCariKodu.Text))
                return "Bütün Cariler";
            else {
                Cari cari = _mngCari.GetById(txtCariKodu.Text,false);
                if (cari != null)
                    return cari.Id + " " + cari.CariIsim;
                else
                    return "";
            }           
        }
        private void btnPrint_Click(object sender, EventArgs e) {
            frmRaporDialog frm = new frmRaporDialog(true, true, true, false);
            frm.ShowDialog();
            ReportTo? dest = frm.GetReportDestination();
            if (dest.HasValue) {
                try {
                    if (dest != ReportTo.CrytalReport) {
                        var report = new Report(_source.ToReportSource());
                        // Customize the Text Fields
                        report.RenderHints.IncludePageNumbers = true;
                        report.TextFields.Title = tabPageFiltre.Text;
                        report.TextFields.Header = string.Format(@"
            Rapor Tarihi:{0}
            Cari:{1}                  
            ", DateTime.Now, SecilenCari()
             );
                        //report.DataFields["Tarih"].DataFormatString = "{0:d}";
                        //report.DataFields["BirimFiyat"].DataFormatString = "{0:F2}";
                        //report.DataFields["Tutar"].DataFormatString = "{0:F2}";
                        report.RenderHints["HtmlStyle"] = "th { font-size: 13px !important;font-weight:bold !important;}";
                        report.RenderHints["HtmlStyle"] = "td { font-size: 11px !important;line-height:1em; }";
                        report.DataFields["KdvTutar"].ShowTotals = true;
                        report.DataFields["BrutTutar"].ShowTotals = true;
                        report.DataFields["Iskanto"].ShowTotals = true;
                        report.DataFields["Tutar"].ShowTotals = true;
                        string fileName =_isFatura? "FaturaRaporu":"İrsaliyeRaporu";

                        IReportWriter writer = new ExcelReportWriter();
                        if (dest.Value == ReportTo.Excel) {
                            fileName = fileName + ".xls";
                        } else if (dest.Value == ReportTo.Html) {
                            writer = new HtmlReportWriter();
                            fileName = fileName + ".html";
                        } else if (dest.Value == ReportTo.Csv) {
                            writer = new DelimitedTextReportWriter();
                            fileName = fileName + ".txt";
                        }
                        string file = Path.Combine(Engine.DokumanPath(), fileName);
                        FileStream fs = new FileStream(file, FileMode.Create);

                        writer.WriteReport(report, fs);
                        fs.Close();
                        Process prc = new Process();
                        prc.StartInfo.FileName = file;
                        prc.Start();
                    } else {
                        //frmStokAlisSatisRaporCrytalRapor frm2 = new frmStokAlisSatisRaporCrytalRapor(_source);
                        //frm2.Show();

                    }
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                    LogWrite.Write(exc);
                }
            }
        }

        private void btnCariRehber_Click(object sender, EventArgs e) {
            frmCariRehber frm = new frmCariRehber();
            frm.Owner = this;
            frm.ShowDialog();

        }
    }
}
