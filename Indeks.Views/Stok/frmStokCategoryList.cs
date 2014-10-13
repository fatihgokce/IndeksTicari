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
using Indeks.Views.Models;
namespace Indeks.Views {
    public partial class frmStokCariCategoryList : BaseForm {
        IManagerFactory _mngFac;
        IStokCategoryManager _mngCatStok;
        ICariCategoryManager _mngCatCari;
        string _parentCategory="";
        TextBox _txtBox;
        bool _useParent;
        StokCariCategory _stokCari;
        public frmStokCariCategoryList(StokCariCategory stokCari,TextBox textBox) {
            InitializeComponent();
            _txtBox = textBox;
            _stokCari = stokCari;
            initData();
            LoadData();
            _useParent = false;
        }
        public frmStokCariCategoryList(StokCariCategory stokCari, TextBox textBox, string parentCategory) {
            InitializeComponent();
            _txtBox = textBox;
            _parentCategory = parentCategory;
            _useParent = true;
            _stokCari = stokCari;
            initData();
            LoadData(_parentCategory);
        }
        void initData() {
            _mngFac = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
            _mngCatStok = _mngFac.GetStokCategoryManager();
            _mngCatCari = _mngFac.GetCariCategoryManager();
            dataGridView1.AutoGenerateColumns = false;            
        }
        public void LoadData(string parentCategory) {
            try {
                if (StokCariCategory.Stok == _stokCari)
                    dataGridView1.DataSource = _mngCatStok.GetListParentSubCategory(parentCategory);
                else
                    dataGridView1.DataSource = _mngCatCari.GetListParentSubCategory(parentCategory);
               
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }
        public void LoadData() {
            try {
                if (_stokCari == StokCariCategory.Stok)
                    dataGridView1.DataSource = _mngCatStok.GetListRootCategories();
                else
                    dataGridView1.DataSource = _mngCatCari.GetListRootCategories();
              
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
        }
        void Sec() {
            try {
                DataGridViewRow dr = dataGridView1.CurrentRow;
                _txtBox.Text = dr.Cells[clId.Name].Value.ToStringOrEmpty();
               
                this.Close();
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);

            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            Sec();
        }

        private void btnSec_Click(object sender, EventArgs e) {
            Sec();
        }

        private void btnYeni_Click(object sender, EventArgs e) {
            frmYeniCariStokKategori frm = new frmYeniCariStokKategori(_stokCari);
            frm.Owner = this;
            frm.ShowDialog();
            if (_useParent)
                LoadData(_parentCategory);
            else
                LoadData();
        }

        private void btnDuzelt_Click(object sender, EventArgs e) {
            try {
                DataGridViewCell cell = dataGridView1.CurrentRow.Cells[clId.Name];
                if (cell != null) {
                    string str = cell.Value.ToStringOrEmpty();
                    frmYeniCariStokKategori frm = new frmYeniCariStokKategori(_stokCari,str);
                    frm.ShowDialog();
                    if (_useParent)
                        LoadData(_parentCategory);
                    else
                        LoadData();
                }
            } catch (Exception exc) {
                MessageBox.Show(exc.Message); LogWrite.Write(exc);
            }

        }

        private void btnSil_Click(object sender, EventArgs e) {
            DialogResult re = MessageBox.Show("Kayıt Silinsin mi?", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            bool beginTrans=false;
            if (re == DialogResult.Yes) {
                try {
                    DataGridViewRow dr = dataGridView1.SelectedRows[0];
                    if (dr != null) {
                        if (StokCariCategory.Stok == _stokCari) {
                            StokCategory sc = _mngCatStok.GetById(dr.Cells[clId.Name].Value.ToString(), false);
                            beginTrans = true;
                            BeginTransaction();
                           
                            sc.ParentCategory = null;
                            _mngCatStok.Delete(sc);
                        }
                        if (StokCariCategory.Cari == _stokCari) {
                            CariCategory cc = _mngCatCari.GetById(dr.Cells[clId.Name].Value.ToString(), false);
                            beginTrans = true;
                            BeginTransaction();
                            
                            cc.ParentCategory = null;
                            _mngCatCari.Delete(cc);
                        }
                    }
                } catch (Exception) { } finally {
                    try {
                        if (beginTrans)
                            CommitTransaction();
                        if (_useParent)
                            LoadData(_parentCategory);
                        else
                            LoadData();
                    } catch (Exception exc) {
                        MessageBox.Show(exc.Message); LogWrite.Write(exc);
                    }
                }
            }
        }
    }
}
