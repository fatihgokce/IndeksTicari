using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Indeks.Data.BusinessObjects;
using Indeks.Data.ManagerObjects;
using Indeks.Views.Models;
namespace Indeks.Views
{
  public partial class frmCari : BaseForm
  {
    IManagerFactory mngFct;
    ICariManager mngCari;
    ICariCategoryManager mngCariCat;
   
    public frmCari()
    {
      InitializeComponent();
      InitializeData();     
    }
    
    void InitializeData() {
        mngFct = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
        mngCari = mngFct.GetCariManager();
        mngCariCat = mngFct.GetCariCategoryManager();
       // LoadAllCari();
        IList<Cari> listef = mngCari.GetBySUBE_KODU(UserInfo.Sube.Id);
        filterDataGridView1.grd.DataSource = listef;
        ManagerIl mngIl = new ManagerIl();
        //txtIl.DataSource = () =>
        //  {
        //    try
        //    {
        //      System.Globalization.CultureInfo dil;
        //      dil = new System.Globalization.CultureInfo("tr-TR");

        //      //txtIl.SelectionStart = txtIl.Text.Length;
        //      string str = txtIl.Text.ToUpper(dil);
        //      return mngIl.IlListe(str) ;
        //    }
        //    catch (Exception exc)
        //    {
        //      MessageBox.Show(exc.Message);
        //      LogWrite.Write(exc);
        //    }
        //    return null;
        //  };
        //txtIlce.DataSource = () =>
        //{
        //  try
        //  {
        //    if (string.IsNullOrEmpty(txtIl.Text))
        //      return null;
        //    System.Globalization.CultureInfo dil;
        //    dil = new System.Globalization.CultureInfo("tr-TR");

        //    //txtIl.SelectionStart = txtIl.Text.Length;
        //    string str = txtIl.Text.ToUpper(dil);
        //    int il = mngIl.SehirId(str);
        //    string ilce = txtIlce.Text.ToUpper(dil);
        //    return mngIl.IlceListe(ilce,il);
        //  }
        //  catch (Exception exc)
        //  {
        //    MessageBox.Show(exc.Message);
        //    LogWrite.Write(exc);
        //  }
        //  return null;
        //};
        txtCariKodu.DataSource = () =>
        {
            try {
                return mngCari.GetCariKodsBySubeKodu(UserInfo.Sube.Id, txtCariKodu.Text).ToStringList(15, txtCariKodu.Ayirac);
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
            return null;
        };
        txtCariGrup1.DataSource = () =>
        {
            try {
                List<string> liste = mngCariCat.GetListRootCategoriesKodAndName(txtCariGrup1.Text).ToStringList(30,"");
                return liste;
            } catch (Exception exc) {
                LogWrite.Write(exc);
                MessageBox.Show(exc.Message);
            }
            return null;
        };
        txtCariGrup2.DataSource = () =>
        {
            try {
                CariCategory parent = mngCariCat.GetById(txtCariGrup1.Text, false);
                if (parent == null)
                    return null;
                else {
                    List<string> liste = mngCariCat.GetListParentSubCategoryKodAndName(parent.Id, txtCariGrup2.Text).ToStringList(30,"");
                    return liste;
                }
            } catch (Exception exc) {
                LogWrite.Write(exc);
                MessageBox.Show(exc.Message);
            }
            return null;
        };
        txtCariGrup3.DataSource = () =>
        {
            try {
                CariCategory parent = mngCariCat.GetById(txtCariGrup2.Text, false);
                if (parent == null)
                    return null;
                else {
                    List<string> liste = mngCariCat.GetListParentSubCategoryKodAndName(parent.Id, txtCariGrup3.Text).ToStringList(30,"");
                    return liste;
                }
            } catch (Exception exc) {
                LogWrite.Write(exc);
                MessageBox.Show(exc.Message);
            }
            return null;
        };
        txtCariGrup4.DataSource = () =>
        {
            try {
                CariCategory parent = mngCariCat.GetById(txtCariGrup3.Text, false);
                if (parent == null)
                    return null;
                else {
                    List<string> liste = mngCariCat.GetListParentSubCategoryKodAndName(parent.Id, txtCariGrup4.Text).ToStringList(30,"");
                    return liste;
                }
            } catch (Exception exc) {
                LogWrite.Write(exc);
                MessageBox.Show(exc.Message);
            }
            return null;
        };
    }

    private void frmCari_Load(object sender, EventArgs e)
    {
        
    }
    void LoadAllCari()
    {
      try
      {      
        IList<Cari>liste = mngCari.GetBySUBE_KODU(UserInfo.Sube.Id);
        //listView1.Items.Clear();
        dataGridViewCari.DataSource = null;
        dataGridViewCari.Rows.Clear();
        foreach (Cari cari in liste)
        {
          //ListViewItem item = new ListViewItem(cari.Id);
          //item.SubItems.Add(cari.CariIsim);
          //item.SubItems.Add(cari.CariTel);
          //item.SubItems.Add(cari.CariAdres);
          //item.SubItems.Add(cari.CariEmail);
          //item.SubItems.Add(cari.VergiDairesi);
          //item.SubItems.Add(cari.VergiNumarasi);
          //item.SubItems.Add(cari.Fax);
          //item.SubItems.Add(cari.WebAdresi);
          //item.SubItems.Add(cari.Il);
          //item.SubItems.Add(cari.Ilce);
          //item.SubItems.Add(cari.Grup1.ProperyToStringOrEmpty(x => x.Id));
          //item.SubItems.Add(cari.Grup2.ProperyToStringOrEmpty(x => x.Id));
          //item.SubItems.Add(cari.CariTip);
          //listView1.Items.Add(item);
          List<string> listeRow = new List<string>();
          listeRow.Add(cari.Id);
          listeRow.Add(cari.CariIsim);
          listeRow.Add(cari.CariTel);
          listeRow.Add(cari.Fax);
          listeRow.Add(cari.CepTel); 
          listeRow.Add(cari.CariAdres);
          listeRow.Add(cari.Il);
          listeRow.Add(cari.Ilce);
          listeRow.Add(cari.VergiDairesi);
          listeRow.Add(cari.VergiNumarasi);
          listeRow.Add(cari.CariEmail);          
          listeRow.Add(cari.WebAdresi);
          listeRow.Add(cari.YetkiliKisi);
          listeRow.Add(cari.AlisFiyatKod);
          listeRow.Add(cari.SatisFiyatKod);
          listeRow.Add(cari.Grup1.ProperyToStringOrEmpty(x => x.Id));
          listeRow.Add(cari.Grup2.ProperyToStringOrEmpty(x => x.Id));
          listeRow.Add(cari.Grup3.ProperyToStringOrEmpty(x => x.Id));
          listeRow.Add(cari.Grup4.ProperyToStringOrEmpty(x => x.Id));
          listeRow.Add(cari.CariTip);
          dataGridViewCari.Rows.Add(listeRow.ToArray());
         
        }
      }
      catch (Exception exc)
      {
        LogWrite.Write(exc);
        MessageBox.Show(exc.Message);
      }
    } 
    private void btnKaydet_Click(object sender, EventArgs e)
    {
      Kaydet();
    }
    void Kaydet()
    {
      if (string.IsNullOrEmpty(txtCariKodu.Text))
      {
        MessageBox.Show("lütfen Cari kodunu giriniz.");
        txtCariKodu.Focus();
        return;
      }
      try {

          Cari cari = mngCari.GetById(txtCariKodu.Text, false);
          if (cari == null) {
              cari = new Cari();
              cari.Id = txtCariKodu.Text;
              cari.KayitTarih = DateTime.Now;
          }
          cari.CariIsim = txtCariIsim.Text;
          if (Char.IsDigit(txtTel.Text[1]))
              cari.CariTel = txtTel.Text;
          if (Char.IsDigit(txtCepTel.Text[1]))
              cari.CepTel = txtCepTel.Text;
          cari.CariAdres = txtCariAdres.Text.Trim();
          cari.CariEmail = txtCariEmil.Text;

          if (rbAliciSatici.Checked)
              cari.CariTip = "AS";
          else if (rbAlici.Checked)
              cari.CariTip = "A";
          else
              cari.CariTip = "S";
          cari.VergiDairesi = txtVergiDairesi.Text;
          cari.VergiNumarasi = txtVergiNumarasi.Text;
          cari.WebAdresi = txtWebAdres.Text;
          if (Char.IsDigit(txtFax.Text[1]))
              cari.Fax = txtFax.Text;
          cari.Sube = UserInfo.Sube;
          cari.Il = txtIl.Text;
          cari.Ilce = txtIlce.Text;
          cari.YetkiliKisi = txtYetkiliKisi.Text;
          cari.SatisFiyatKod = cmbSatisFiyatKod.Text;
          cari.AlisFiyatKod = cmbAlisFiyatKod.Text;
          cari.SubelerdeOrtak = chkSubelerdeOrtak.Checked;
          CariCategory parentCat1 = null;
          CariCategory parentCat2 = null;
          CariCategory parentCat3 = null;
          CariCategory parentCat4 = null;
          BeginTransaction();
          if (!string.IsNullOrEmpty(txtCariGrup1.Text)) {
              parentCat1 = mngCariCat.GetById(txtCariGrup1.Text, false);
              if (parentCat1 == null) {
                  //mngCariCat.BeginTransaction();
                  cari.Grup1 = parentCat1 = mngCariCat.Save(new CariCategory() { Id = txtCariGrup1.Text, Sube = UserInfo.Sube });
                  //mngCariCat.CommitTransaction();
              } else
                  cari.Grup1 = parentCat1;
          } else
              cari.Grup1 = null;
          if (parentCat1 != null && !string.IsNullOrEmpty(txtCariGrup1.Text) && !string.IsNullOrEmpty(txtCariGrup2.Text)) {

              parentCat2 = mngCariCat.GetById(txtCariGrup2.Text, false);
              if (parentCat2 == null) {
                  //mngCariCat.BeginTransaction();
                  parentCat2 = new CariCategory { Id = txtCariGrup2.Text, Sube = UserInfo.Sube, ParentCategory = parentCat1 };
                  cari.Grup2 = mngCariCat.SaveOrUpdate(parentCat2);
                  //mngCariCat.CommitTransaction();
              } else
                  cari.Grup2 = parentCat2;
          } else
              cari.Grup2 = null;
          if (parentCat2 != null && !string.IsNullOrEmpty(txtCariGrup2.Text) && !string.IsNullOrEmpty(txtCariGrup3.Text)) {

              parentCat3 = mngCariCat.GetById(txtCariGrup3.Text, false);
              if (parentCat3 == null) {
                  //mngCariCat.BeginTransaction();
                  parentCat3 = new CariCategory { Id = txtCariGrup3.Text, Sube = UserInfo.Sube, ParentCategory = parentCat2 };
                  cari.Grup3 = mngCariCat.SaveOrUpdate(parentCat3);
                  //mngCariCat.CommitTransaction();
              } else
                  cari.Grup3 = parentCat3;
          } else
              cari.Grup3 = null;
          if (parentCat3 != null && !string.IsNullOrEmpty(txtCariGrup3.Text) && !string.IsNullOrEmpty(txtCariGrup4.Text)) {

              parentCat4 = mngCariCat.GetById(txtCariGrup4.Text, false);
              if (parentCat4 == null) {
                  //mngCariCat.BeginTransaction();
                  parentCat4 = new CariCategory { Id = txtCariGrup4.Text, Sube = UserInfo.Sube, ParentCategory = parentCat3 };
                  cari.Grup4 = mngCariCat.SaveOrUpdate(parentCat4);
                  //mngCariCat.CommitTransaction();
              } else
                  cari.Grup4 = parentCat4;
          } else
              cari.Grup4 = null;
          //mngCari.BeginTransaction();

          mngCari.SaveOrUpdate(cari);


          Form frm = this.Owner;
          if (frm != null) {
              if (frm is frmCariRehber)
                  this.Close();
              else if (frm is frmFatura) {
                  frmFatura f = (frmFatura)frm;
                  f.txtCari.Text = txtCariKodu.Text;
                  f.txtCari.Focus();
                  this.Close();
              } else if (frm is frmSiparis) {
                  frmSiparis f = (frmSiparis)frm;
                  f.txtCari.Text = txtCariKodu.Text;
                  f.txtCari.Focus();
                  this.Close();
              }
          } else {
              //LoadAllCari();
              btnYeni_Click(this, EventArgs.Empty);
              txtCariKodu.Focus();
          }
      } catch (Exception exc) {
          LogWrite.Write(exc);
          MessageBox.Show(exc.Message);
      } finally {

          try {         
              CommitTransaction();
          } catch (Exception exc) {
              MessageBox.Show(exc.Message);
              LogWrite.Write(exc);
          }
      }
    }
    void KayitSil() {
        DialogResult re = MessageBox.Show("Kayıt Silinsin mi?", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        if (re == DialogResult.Yes) {
            try {

                Cari cari = mngCari.GetById(txtCariKodu.Text, true);
                mngCari.BeginTransaction();
                mngCari.Delete(cari);

                LoadAllCari();
                btnYeni_Click(this, EventArgs.Empty);
            } catch (Exception) { } finally {
                try {
                    mngCari.CommitTransaction();
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                    LogWrite.Write(exc);
                }
            }
        }
    }
    private void btnSil_Click(object sender, EventArgs e)
    {
      KayitSil();
    }
    private void btnYeni_Click(object sender, EventArgs e)
    {
      YeniKayit();
    }
    public void YeniKayit()
    {
      CleareForm.ClearThisConrol(this).BeginClear();
      txtCariKodu.Focus();
      txtCariKodu.ReadOnly = false;
    }
    private void frmCari_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter) {
            SendKeys.Send("{TAB}");
        } else if (Keys.F5 == e.KeyCode) {
            Kaydet();
        } else if (Keys.F7 == e.KeyCode)
            KayitSil();
        else if (Keys.F3 == e.KeyCode)
            YeniKayit();
        else if (Keys.Escape == e.KeyCode)
            this.Close();

    }
    private void txtCariKodu_KeyUp(object sender, KeyEventArgs e)
    {
      if (!string.IsNullOrEmpty(txtCariKodu.Text) && e.KeyCode == Keys.Tab)
      {
        try
        {
          Cari cari = mngCari.GetById(txtCariKodu.Text, false);
          if (cari != null)
          {
            CleareForm.ClearThisConrol(groupBox1)
                      .NotClearTheseConrols(txtCariKodu)
                      .BeginClear();
            txtCariIsim.Text = cari.CariIsim;
            txtTel.Text = cari.CariTel;
            txtCepTel.Text = cari.CepTel;
            txtCariAdres.Text = cari.CariAdres;
            txtCariEmil.Text = cari.CariEmail;
            txtVergiDairesi.Text = cari.VergiDairesi;
            txtVergiNumarasi.Text = cari.VergiNumarasi;
            txtWebAdres.Text = cari.WebAdresi;
            txtFax.Text = cari.Fax;
        
            if (cari.CariTip.Contains("AS"))
              rbAliciSatici.Checked = true;
            else if (cari.CariTip.Contains("S"))
              rbSatici.Checked = true;
            else
              rbAlici.Checked = true;
            txtCariGrup1.Text = cari.Grup1.ProperyToStringOrEmpty(x=>x.Id);
            txtCariGrup2.Text = cari.Grup2.ProperyToStringOrEmpty(x=>x.Id);
            txtCariGrup3.Text = cari.Grup3.ProperyToStringOrEmpty(x => x.Id);
            txtCariGrup4.Text = cari.Grup4.ProperyToStringOrEmpty(x => x.Id);
            txtIl.Text = cari.Il;
            txtIlce.Text = cari.Ilce;
            txtYetkiliKisi.Text = cari.YetkiliKisi;
            cmbAlisFiyatKod.Text = cari.AlisFiyatKod;
            cmbSatisFiyatKod.Text = cari.SatisFiyatKod;
            chkSubelerdeOrtak.Checked = cari.SubelerdeOrtak.HasValue ? cari.SubelerdeOrtak.Value : false;
          }
        }
        catch (Exception exc)
        {
          MessageBox.Show(exc.Message);
          LogWrite.Write(exc);
        }
        txtCariIsim.Focus();
      }
    }

    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        //ListViewItem item = listView1.SelectedItems[0];
        //txtCariKodu.Text =item.SubItems[0].Text;
        //txtCariIsim.Text = item.SubItems[1].Text;
        //txtTel.Text = item.SubItems[2].Text;
        //txtCariAdres.Text = item.SubItems[3].Text;
        //txtCariEmil.Text = item.SubItems[4].Text;
        //txtVergiDairesi.Text = item.SubItems[5].Text;
        //txtVergiNumarasi.Text = item.SubItems[6].Text;
        //txtFax.Text = item.SubItems[7].Text;
        //txtWebAdres.Text =item.SubItems[8].Text;
        //txtIl.Text = item.SubItems[9].Text;
        //txtIlce.Text = item.SubItems[10].Text;
       
        //txtCariGrup1.Text = item.SubItems[11].Text;
        //txtCariGrup2.Text = item.SubItems[12].Text;
        //rbAlici.Checked = item.SubItems[13].Text.Contains("A") ? true : false;
        //rbSatici.Checked = !rbAlici.Checked;
        //txtCariKodu.ReadOnly = true;
        //txtCariIsim.Focus();    
        
      }
      catch
      {
        txtCariIsim.Focus();
      }
    }

    private void btnCariRehber_Click(object sender, EventArgs e)
    {
      frmCariRehber frm = new frmCariRehber();
      frm.Owner = this;
      frm.Show();
      txtCariKodu.Focus();
    }

    private void dataGridViewCari_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        try {
            if (dataGridViewCari.CurrentRow != null) {
                DataGridViewRow dr = dataGridViewCari.CurrentRow;
                CleareForm.ClearThisConrol(this).BeginClear();
                txtCariKodu.Text = dr.Cells["clCariKod"].Value.ToStringOrEmpty();
                txtCariIsim.Text = dr.Cells["clIsim"].Value.ToStringOrEmpty();
                txtTel.Text = dr.Cells["clTelefon"].Value.ToStringOrEmpty();
                txtCepTel.Text = dr.Cells["clCepTel"].Value.ToStringOrEmpty();
                txtCariAdres.Text = dr.Cells["clAdres"].Value.ToStringOrEmpty();
                txtCariEmil.Text = dr.Cells["clEmail"].Value.ToStringOrEmpty();
                txtVergiDairesi.Text = dr.Cells["clVergiDairesi"].Value.ToStringOrEmpty();
                txtVergiNumarasi.Text = dr.Cells["clVergiNumarasi"].Value.ToStringOrEmpty();
                txtFax.Text = dr.Cells["clFax"].Value.ToStringOrEmpty();
                txtWebAdres.Text = dr.Cells["clWebAdres"].Value.ToStringOrEmpty();
                txtIl.Text = dr.Cells["clil"].Value.ToStringOrEmpty();
                txtIlce.Text = dr.Cells["clilce"].Value.ToStringOrEmpty();
                txtCariGrup1.Text = dr.Cells["clGrup1"].Value.ToStringOrEmpty();
                txtCariGrup2.Text = dr.Cells["clGrup2"].Value.ToStringOrEmpty();
                txtCariGrup3.Text = dr.Cells["clGrup3"].Value.ToStringOrEmpty();
                txtCariGrup4.Text = dr.Cells["clGrup4"].Value.ToStringOrEmpty();
                txtYetkiliKisi.Text = dr.Cells["clYetkiliKisi"].Value.ToStringOrEmpty();
                cmbAlisFiyatKod.Text = dr.Cells[clAlisFiyatKod.Name].Value.ToStringOrEmpty();
                cmbSatisFiyatKod.Text = dr.Cells[clSatisFiyatKod.Name].Value.ToStringOrEmpty();
                if (dr.Cells["clCariTip"].Value.ToStringOrEmpty().Contains("AS"))
                    rbAliciSatici.Checked = true;
                else if (dr.Cells["clCariTip"].Value.ToStringOrEmpty().Contains("S"))
                    rbSatici.Checked = true;
                else
                    rbAlici.Checked = true;
                txtCariIsim.Focus();
                Cari cari = mngCari.GetById(txtCariKodu.Text, false);
                chkSubelerdeOrtak.Checked = cari.SubelerdeOrtak.HasValue ? cari.SubelerdeOrtak.Value : false;
            }
        } catch (Exception exc) {
            MessageBox.Show(exc.Message);
            LogWrite.Write(exc);
        }
    }

    private void txtIl_TextChanged(object sender, EventArgs e)
    {
      //try
      //{
      //  if (txtIl.Text != string.Empty)
      //  {
      //    System.Globalization.CultureInfo dil;
      //    dil = new System.Globalization.CultureInfo("tr-TR");
       
      //    //txtIl.SelectionStart = txtIl.Text.Length;
      //    txtIl.Text = txtIl.Text.ToUpper(dil);
          
      //  }
      //}
      //catch (Exception ht)
      //{ MessageBox.Show("Hata oluştu"); }
    }

    private void tsbtnKaydet_Click(object sender, EventArgs e)
    {
      Kaydet();
    }

    private void tsbtnSil_Click(object sender, EventArgs e)
    {
      KayitSil();
    }

    private void tsbtnYeniKayit_Click(object sender, EventArgs e)
    {
      YeniKayit();
    }

    private void btnStReh1_Click(object sender, EventArgs e) {
        frmStokCariCategoryList frm = new frmStokCariCategoryList(StokCariCategory.Cari, txtCariGrup1);
        frm.ShowDialog();
        txtCariGrup2.Focus();
    }

    private void btnStReh2_Click(object sender, EventArgs e) {
        frmStokCariCategoryList frm = new frmStokCariCategoryList(StokCariCategory.Cari, txtCariGrup2, txtCariGrup1.Text);
        frm.ShowDialog();
        txtCariGrup3.Focus();
    }

    private void btnStReh3_Click(object sender, EventArgs e) {
        frmStokCariCategoryList frm = new frmStokCariCategoryList(StokCariCategory.Cari, txtCariGrup3, txtCariGrup2.Text);
        frm.ShowDialog();
        txtCariGrup4.Focus();
    }

    private void btnStReh4_Click(object sender, EventArgs e) {
        frmStokCariCategoryList frm = new frmStokCariCategoryList(StokCariCategory.Cari, txtCariGrup4, txtCariGrup3.Text);
        frm.ShowDialog();
        txtCariGrup4.Focus();
    }

    private void toolStripButton1_Click(object sender, EventArgs e) {
        this.Close();
    }

    private void frmCari_FormClosing(object sender, FormClosingEventArgs e) {
        txtCariKodu.CloseAutoComplete();
    }

   

   
  }
}
