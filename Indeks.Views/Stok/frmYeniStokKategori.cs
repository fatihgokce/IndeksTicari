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
    public partial class frmYeniCariStokKategori : BaseForm {
        IManagerFactory _mngFac;
        IStokCategoryManager _mngStkCat;
        ICariCategoryManager _mngCariCat;
        string _categoryId;
        StokCariCategory _stokCari;
        public frmYeniCariStokKategori(StokCariCategory stokCari) {
            InitializeComponent();
            _mngFac = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
            _mngStkCat = _mngFac.GetStokCategoryManager();
            _mngCariCat = _mngFac.GetCariCategoryManager();
            _stokCari = stokCari;
            LoadCategory();
            treeView1.ExpandAll();

        }
        public frmYeniCariStokKategori(StokCariCategory stokCari, string categoryId)
        :this(stokCari){
           // InitializeComponent();
            //_mngFac = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
            //_mngStkCat = _mngFac.GetStokCategoryManager();
            //_mngCariCat = _mngFac.GetCariCategoryManager();
            //_stokCari = stokCari;
            //LoadCategory();
            //treeView1.ExpandAll();
            _categoryId = categoryId;
            setData();
        }
        void setData() {
            try {
                if (_stokCari == StokCariCategory.Stok) {
                    StokCategory sc = _mngStkCat.GetById(_categoryId, false);
                    if (sc != null && sc.ParentCategory != null) {
                        txtSelectedCategory.Text = string.Format("{0}", sc.ParentCategory.Id);
                        txtCatCode.Text = sc.Id;
                        txtCatName.Text = sc.CategoryName;
                        txtCatCode.Enabled = false;
                    } else if(sc!=null) {
                       
                        txtCatCode.Text = sc.Id;
                        txtCatName.Text = sc.CategoryName;
                        chkAnaKategori.Checked = true;
                        txtCatCode.Enabled = false;
                    }
                } else {
                    CariCategory cc = _mngCariCat.GetById(_categoryId, false);
                    if (cc != null && cc.ParentCategory != null) {
                        txtSelectedCategory.Text = string.Format("{0}", cc.ParentCategory.Id);
                        txtCatCode.Text = cc.Id;
                        txtCatName.Text = cc.CategoryName;
                        txtCatCode.Enabled = false;
                    } else if (cc != null) {                      
                        txtCatCode.Text = cc.Id;
                        txtCatName.Text = cc.CategoryName;
                        txtCatCode.Enabled = false;
                        chkAnaKategori.Checked = true;
                    }
                }
            } catch (Exception exc) {
                LogWrite.Write(exc);
                MessageBox.Show(exc.Message);
            }
        }

        void LoadCategory() {
            try {
                if (StokCariCategory.Stok == _stokCari) {
                    List<StokCategory> liste = _mngStkCat.GetListRootCategories();
                    foreach (var item in liste) {
                        TreeNode tn = new TreeNode();
                        tn.Text = string.Format("{0}-{1}", item.Id, item.CategoryName);
                        RecursiveAddNode(item.ChildCategories, tn);
                        treeView1.Nodes.Add(tn);
                    }
                } else {
                    List<CariCategory> liste = _mngCariCat.GetListRootCategories();
                    foreach (var item in liste) {
                        TreeNode tn = new TreeNode();
                        tn.Text = string.Format("{0}-{1}", item.Id, item.CategoryName);
                        RecursiveAddNode(item.ChildCategories, tn);
                        treeView1.Nodes.Add(tn);
                    }
                }
            } catch (Exception exc) {
                LogWrite.Write(exc);
                MessageBox.Show(exc.Message);
            }
        }
        void RecursiveAddNode(ICollection<CariCategory> liste, TreeNode parentNode) {
            foreach (var item in liste) {
                TreeNode cn = new TreeNode();
                cn.Text = string.Format("{0}-{1}", item.Id, item.CategoryName);
                parentNode.Nodes.Add(cn);
                RecursiveAddNode(item.ChildCategories, cn);

            }
        }
        void RecursiveAddNode(ICollection<StokCategory> liste,TreeNode parentNode) {
            foreach (var item in liste) {
                TreeNode cn = new TreeNode();
                cn.Text = string.Format("{0}-{1}", item.Id, item.CategoryName);
                parentNode.Nodes.Add(cn);
                RecursiveAddNode(item.ChildCategories,cn);

            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) {
            try {
                string[] txtpar = treeView1.SelectedNode.Text.Split('-');
                if(txtpar.Length>0)
                    txtSelectedCategory.Text = txtpar[0];
            } catch (Exception exc) {
                MessageBox.Show(exc.Message); LogWrite.Write(exc);
            }
        }

        private void chkAnaKategori_CheckedChanged(object sender, EventArgs e) {
            if (chkAnaKategori.Checked) {
                treeView1.Enabled = false;
                txtSelectedCategory.Text = "";
            } else {
                treeView1.Enabled = true;
            }
        }
        void Kaydet() {
            if (string.IsNullOrEmpty(txtCatCode.Text)) {
                errorProvider1.SetError(txtCatCode, "kategori kodunu giriniz");
                return;
            }
            if (string.IsNullOrEmpty(txtCatName.Text)) {
                errorProvider1.SetError(txtCatName, "kategori ismini giriniz");
                return;
            }
            if (!chkAnaKategori.Checked && string.IsNullOrEmpty(txtSelectedCategory.Text)) {
                errorProvider1.SetError(txtSelectedCategory, "ana kategori seçiniz");
                return;
            }
            try {
                if (StokCariCategory.Stok == _stokCari) {
                    StokCategory sc = _mngStkCat.GetById(txtCatCode.Text, false);
                    if (sc == null)
                        sc = new StokCategory { Id = txtCatCode.Text };
                    sc.CategoryName = txtCatName.Text;
                    if (chkAnaKategori.Checked)
                        sc.ParentCategory = null;
                    else {
                        StokCategory parent = _mngStkCat.GetById(txtSelectedCategory.Text, false);
                        sc.ParentCategory = parent;
                    }
                    sc.Sube = UserInfo.Sube;
                    BeginTransaction();
                    _mngStkCat.SaveOrUpdate(sc);
                } else {
                    CariCategory cc = _mngCariCat.GetById(txtCatCode.Text, false);
                    if (cc == null)
                        cc = new CariCategory { Id = txtCatCode.Text };
                    cc.CategoryName = txtCatName.Text;
                    if (chkAnaKategori.Checked)
                        cc.ParentCategory = null;
                    else {
                        CariCategory parent = _mngCariCat.GetById(txtSelectedCategory.Text, false);
                        cc.ParentCategory = parent;
                    }
                    cc.Sube = UserInfo.Sube;
                    BeginTransaction();
                    _mngCariCat.SaveOrUpdate(cc);
                }
            } catch (Exception) {
            } finally {
                try {
                    CommitTransaction();
                    this.Close();
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                    LogWrite.Write(exc);
                }
            }
        }
        private void frmYeniCariStokKategori_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                SendKeys.Send("{TAB}");
            } else if (e.KeyCode == Keys.F5) {
                Kaydet();
            } else if (e.KeyCode == Keys.Escape) {
                this.Close();
            } 
        }

        private void toolStripButton1_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
