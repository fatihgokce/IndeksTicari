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
    public partial class frmStokCariCategoryTree : Form {
        IManagerFactory _mngFac;
        IStokCategoryManager _mngStkCat;
        ICariCategoryManager _mngCariCat;
        StokCariCategory _stokCari;
        bool firsLoad = true;
        public frmStokCariCategoryTree(StokCariCategory stokCari) {
            InitializeComponent();
            _mngFac = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
            _mngStkCat = _mngFac.GetStokCategoryManager();
            _mngCariCat = _mngFac.GetCariCategoryManager();
            _stokCari = stokCari;
            LoadCategory();
      
            treeView1.ExpandAll();
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
        void RecursiveAddNode(ICollection<StokCategory> liste, TreeNode parentNode) {
            foreach (var item in liste) {
                TreeNode cn = new TreeNode();
                cn.Text = string.Format("{0}-{1}", item.Id, item.CategoryName);
                parentNode.Nodes.Add(cn);
                RecursiveAddNode(item.ChildCategories, cn);

            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) {
            if (firsLoad) {
                firsLoad = false;
                treeView1.SelectedNode = null;
                return;
            }
            try {
                string[] ary = treeView1.SelectedNode.Text.Split('-');;
                if (ary.Length > 0) {
                    if (this.Owner is frmStokMaliyetRaporu) {
                        frmStokMaliyetRaporu frm = (frmStokMaliyetRaporu)this.Owner;
                        frm.txtStokGrup.Text = ary[0];
                    }
                }
                this.Close();
            } catch (Exception exc) {
                MessageBox.Show(exc.Message); LogWrite.Write(exc);
            }
        }

    }
}
