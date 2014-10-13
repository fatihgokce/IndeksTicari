using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Indeks.Data.BusinessObjects;
using Indeks.Data.ManagerObjects;
using Indeks.Data.Base;
using System.Globalization;
using Indeks.Views.Models;
namespace Indeks.Views
{
  public partial class frmStok :BaseForm
  {
    IManagerFactory managerFctry;
    IStokManager managerStk;    
    IKurManager mngKur;
    string _selectedStok=string.Empty;
    IStokCategoryManager mngStokCat;
    Form frmFatSiip=null;
    FTIRSIP ftirsip;
    public frmStok()
    {
      InitializeComponent();     
      YukleDatalari();
      txtStokKodu.Focus();
    }
    public frmStok(Form frmFatSip, FTIRSIP ftirsip)
    {
      InitializeComponent();
    
      this.frmFatSiip = frmFatSip;
      this.ftirsip = ftirsip;
      YukleDatalari();
      if (frmFatSiip is frmFatura)
      {
        frmFatura f = frmFatSiip as frmFatura;
        txtStokKodu.Text = f.txtStokKodu.Text;
        txtBarkod1.Text = f.txtBarkod.Text;
      }
      else if (frmFatSiip is frmSiparis)
      {
        frmSiparis f = frmFatSiip as frmSiparis;
        txtStokKodu.Text = f.txtStokKodu.Text;
        txtBarkod1.Text = f.txtBarkod.Text;
      }
    }
    void YukleDatalari()
    {
      managerFctry = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
      managerStk = managerFctry.GetStokManager();

      mngKur = managerFctry.GetKurManager();
      mngStokCat = managerFctry.GetStokCategoryManager();    
      this.Activate();
      txtStokKodu.Focus();
      //Deneme(managerStk, "2");
      txtStGrup1.DataSource = () =>
      {
        try
        {
            return mngStokCat.GetListRootCategoriesKodAndName(txtStGrup1.Text).ToStringList(30,"");
        }
        catch (Exception exc)
        {
          MessageBox.Show(exc.Message);
          LogWrite.Write(exc);
        }
        return null;
      };
      txtStGrup2.DataSource = () =>
      {
        try
        {
          if (!string.IsNullOrEmpty(txtStGrup1.Text) && !string.IsNullOrEmpty(txtStGrup2.Text))
              return mngStokCat.GetListParentSubCategoryKodAndName(txtStGrup1.Text, txtStGrup2.Text).ToStringList(30,"");
          else
            return null;
        }
        catch (Exception exc)
        {
          LogWrite.Write(exc);
          MessageBox.Show(exc.Message);
        }
        return null;
      };
      txtStGrup3.DataSource = () =>
      {
        try
        {
          if (!string.IsNullOrEmpty(txtStGrup2.Text) && !string.IsNullOrEmpty(txtStGrup2.Text))
              return mngStokCat.GetListParentSubCategoryKodAndName(txtStGrup2.Text, txtStGrup3.Text).ToStringList(30,"");
          else
            return null;
        }
        catch (Exception exc)
        {
          MessageBox.Show(exc.Message);
          LogWrite.Write(exc);
        }
        return null;
      };
      txtStGrup4.DataSource = () =>
      {
        try
        {
          if (!string.IsNullOrEmpty(txtStGrup3.Text) && !string.IsNullOrEmpty(txtStGrup4.Text))
              return mngStokCat.GetListParentSubCategoryKodAndName(txtStGrup3.Text, txtStGrup4.Text).ToStringList(30,"");
          else
            return null;
        }
        catch (Exception exc)
        {
          MessageBox.Show(exc.Message);
          LogWrite.Write(exc);
        }
        return null;
      };
      txtStGrup5.DataSource = () =>
      {
        try
        {
          if (!string.IsNullOrEmpty(txtStGrup4.Text) && !string.IsNullOrEmpty(txtStGrup5.Text))
              return mngStokCat.GetListParentSubCategoryKodAndName(txtStGrup4.Text, txtStGrup5.Text).ToStringList(30,"");
          else
            return null;
        }
        catch (Exception exc)
        {
          MessageBox.Show(exc.Message);
          LogWrite.Write(exc);
        }
        return null;
      };
      txtStokKodu.DataSource = () =>
      {
        try
        {
          return managerStk.StokKods(txtStokKodu.Text, UserInfo.Sube).ToStringList(35,txtStokKodu.Ayirac);
        }
        catch (Exception exc)
        {
          MessageBox.Show(exc.Message);
          LogWrite.Write(exc);
        }
        return null;
      };
      txtStokKodu.Text = "";
    }
    private void frmStok_Load(object sender, EventArgs e)
    {
       // Deneme<Stok, string>(managerStk, "st001");
    }
    //T Deneme<T, IdT>(IManagerBase<T, IdT> mng,IdT id)
    //{
    //  return mng.GetById(id,false);
    //}     

   
  
    void AssStokValues(Stok stok)
    {
      CultureInfo ci = new CultureInfo("tr-TR");
      stok.StokAdi = txtStokIsmi.Text;
      //stok.KdvOrani = txtAlisKdvOrani.Text.ParseNullable<double>(x => double.Parse(x, ci));
      stok.AlisKdvOrani = txtAlisKdvOrani.Text.ParseStruct<double>(x => double.Parse(x, ci));
      stok.SatisKdvOrani = txtSatisKdvOrani.Text.ParseStruct<double>(x => double.Parse(x, ci));
      stok.AnaBirim = txtAnaBirim.Text.Trim();
      stok.AltBirim1 = txtAltBirim1.Text.Trim();
      stok.Carpan1 = txtCarpan1.Text.ParseNullable<double>(x=>double.Parse(x,ci));
      stok.AltBirim2 = txtAltBirim2.Text.Trim();
      stok.Carpan2 = txtCarpan2.Text.ParseNullable<double>(x => double.Parse(x, ci));
      stok.AltBirim3 = txtAltBirim3.Text.Trim();
      stok.Carpan3 = txtCarpan3.Text.ParseNullable<double>(x => double.Parse(x, ci));

      stok.AsgariMiktar = txtAsgariMiktar.Text.ParseNullable<int>(x=>int.Parse(x,ci));
      stok.AzamiMiktar = txtAzamiMiktar.Text.ParseNullable<int>(x=>int.Parse(x,ci));
      stok.AlisFiyat1 = txtAlisFyt1.Text.ParseNullable<double>(delegate(string x) { return double.Parse(x, ci); });
      stok.AlisFiyat2 = txtAlisFyt2.Text.ParseNullable<double>(delegate(string x) { return double.Parse(x, ci); });
      stok.AlisFiyat3 = txtAlisFyt3.Text.ParseNullable<double>(delegate(string x) { return double.Parse(x, ci); });
      //stok.AlisDovTipi = mngKur.GetByKurName(cmbAlisFytKur.Text);
      stok.SatisFiyat1 = txtSatisFyt1.Text.ParseNullable<double>(x=>double.Parse(x,ci));
      stok.SatisFiyat2 = txtSatisFyt2.Text.ParseNullable<double>(x => double.Parse(x, ci));
      stok.SatisFiyat3 = txtSatisFyt3.Text.ParseNullable<double>(x => double.Parse(x, ci));
      //stok.SatDovTipi = mngKur.GetByKurName(cmbSatisFyt.Text);
      stok.SubelerdeOrtak = chkSubelerdeOrtak.Checked;
      StokCategory parentCat1 = null;
      StokCategory parentCat2 = null;
      StokCategory parentCat3 = null;
      StokCategory parentCat4 = null;
     
      if (!string.IsNullOrEmpty(txtStGrup1.Text))
      {
        parentCat1 = mngStokCat.GetById(txtStGrup1.Text, false);
        if (parentCat1 == null)
        {
          //mngStokCat.BeginTransaction();
          stok.Grup1 = parentCat1 = mngStokCat.Save(new StokCategory() { Id = txtStGrup1.Text, Sube = UserInfo.Sube });
          //mngStokCat.CommitTransaction();
        }
        else
          stok.Grup1 = parentCat1;
      }
      else
        stok.Grup1 = null;
      if (parentCat1 != null && !string.IsNullOrEmpty(txtStGrup1.Text) && !string.IsNullOrEmpty(txtStGrup2.Text))
      {

        parentCat2 = mngStokCat.GetById(txtStGrup2.Text, false);
        if (parentCat2 == null)
        {
          //mngStokCat.BeginTransaction();
          parentCat2 = new StokCategory { Id = txtStGrup2.Text, Sube = UserInfo.Sube, ParentCategory = parentCat1 };
          stok.Grup2 = mngStokCat.Save(parentCat2);
          //mngStokCat.CommitTransaction();
        }
        else
          stok.Grup2 = parentCat2;
      }
      else
        stok.Grup2 = null;
      if (parentCat2 != null && !string.IsNullOrEmpty(txtStGrup2.Text) && !string.IsNullOrEmpty(txtStGrup3.Text))
      {

        parentCat3 = mngStokCat.GetById(txtStGrup3.Text, false);
        if (parentCat3 == null)
        {
          //mngStokCat.BeginTransaction();
          parentCat3 = new StokCategory { Id = txtStGrup3.Text, Sube = UserInfo.Sube, ParentCategory = parentCat2 };
          stok.Grup3 = mngStokCat.Save(parentCat3);
          //mngStokCat.CommitTransaction();
        }
        else
          stok.Grup3 = parentCat3;
      }
      else
        stok.Grup3 = null;
      if (parentCat3 != null && !string.IsNullOrEmpty(txtStGrup3.Text) && !string.IsNullOrEmpty(txtStGrup4.Text))
      {

        parentCat4 = mngStokCat.GetById(txtStGrup4.Text, false);
        if (parentCat4 == null)
        {
          //mngStokCat.BeginTransaction();
          parentCat4 = new StokCategory { Id = txtStGrup4.Text, Sube = UserInfo.Sube, ParentCategory = parentCat3 };
          stok.Grup4 = mngStokCat.Save(parentCat4);
          //mngStokCat.CommitTransaction();
        }
        else
          stok.Grup4 = parentCat4;
      }
      else
        stok.Grup4 = null;
      if (parentCat4 != null && !string.IsNullOrEmpty(txtStGrup4.Text) && !string.IsNullOrEmpty(txtStGrup5.Text))
      {
        StokCategory parentCat5 = mngStokCat.GetById(txtStGrup5.Text, false);
        if (parentCat5 == null)
        {
          //mngStokCat.BeginTransaction();
          parentCat5 = new StokCategory { Id = txtStGrup5.Text, Sube = UserInfo.Sube, ParentCategory = parentCat4 };
          stok.Grup5 = mngStokCat.Save(parentCat5);
          //mngStokCat.CommitTransaction();
        }
        else
          stok.Grup5 = parentCat5;
      }
      else
        stok.Grup5 = null;
 
      stok.Barkod1 = txtBarkod1.Text; stok.Barkod2 = txtBarkod2.Text;stok.Barkod3 = txtBarkod3.Text;
      
    }
    void Kaydet()
    {
      try
      {
        //textBox1.Text = val.ToString("N04", ci);
        //CultureInfo ci = new CultureInfo("tr-TR");
          if (string.IsNullOrEmpty(txtStokKodu.Text) || string.IsNullOrEmpty(txtAlisKdvOrani.Text) || string.IsNullOrEmpty(txtSatisKdvOrani.Text))
        {
          MessageBox.Show("Stok Kodunu ve kdv oranını giriniz");
          return;
        }
        Stok stok =managerStk.GetById(txtStokKodu.Text,false);
        if (stok == null)
        {
          stok = new Stok();
          stok.KayitTarih = DateTime.Now;
        }
        stok.Id = txtStokKodu.Text;
        BeginTransaction();
        AssStokValues(stok);
        stok.Sube = UserInfo.Sube;
        //managerStk.BeginTransaction();
        stok=managerStk.SaveOrUpdate(stok);
        //managerStk.CommitTransaction();
        YonlendirForma();
        Form frm = this.Owner;
        if (frm is frmStokSearch)
            this.Close();
        //LoadAllStok();
        YeniKayit();
      }
      catch (Exception exc)
      {
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

    private void YonlendirForma() {
        if (frmFatSiip != null) {
            if (frmFatSiip is frmFatura) {
                frmFatura f = frmFatSiip as frmFatura;
                f.txtBarkod.Text = txtBarkod1.Text;
                f.txtStokKodu.Text = txtStokKodu.Text;
                f.txtStokIsmi.Text = txtStokIsmi.Text;
                if (FTIRSIP.AlisFat == ftirsip || FTIRSIP.AlisIrs == ftirsip)
                    f.txtFyt.Text = txtAlisFyt1.Text;
                else
                    f.txtFyt.Text = txtSatisFyt1.Text;
                this.Close();
            } else if (frmFatSiip is frmSiparis) {
                frmSiparis f = frmFatSiip as frmSiparis;
                f.txtBarkod.Text = txtBarkod1.Text;
                f.txtStokKodu.Text = txtStokKodu.Text;
                f.txtStokIsmi.Text = txtStokIsmi.Text;
                if (FTIRSIP.AlisFat == ftirsip || FTIRSIP.AlisIrs == ftirsip)
                    f.txtFyt.Text = txtAlisFyt1.Text;
                else
                    f.txtFyt.Text = txtSatisFyt1.Text;
                this.Close();
            }
        }
    }
    private void btnKaydet_Click(object sender, EventArgs e)
    {
      Kaydet();
    }
    void YeniKayit()
    {
      CleareForm.ClearThisConrol(this)
                .BeginClear();
      txtStokKodu.Focus();
      labAltBirim1.Text = "";
      labAltBirim2.Text = "";
      labAltBirim3.Text = "";      
    }
    private void btnNew_Click(object sender, EventArgs e)
    {
      YeniKayit();
    }
    void KayitSil() {
        DialogResult re = MessageBox.Show("Kayıt Silinsin mi?", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        if (re == DialogResult.Yes) {
            try {
               

                Stok stok = managerStk.GetById(txtStokKodu.Text, true);
                managerStk.BeginTransaction();
                managerStk.Delete(stok);               
                YeniKayit();

            } catch (Exception) {
            } finally {
                try {
                    managerStk.CommitTransaction();
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                    LogWrite.Write(exc);
                }
            }
        }
    }
    private void btnDelete_Click(object sender, EventArgs e)
    {
      KayitSil();
    }
    private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }
    private void btnStokSearch_Click(object sender, EventArgs e)
    {
      frmStokSearch frm = new frmStokSearch();
      frm.Owner = this;
      frm.Show();
      txtStokKodu.Focus();
    }
    private void txtStokKodu_KeyUp(object sender, KeyEventArgs e)
    {
      if (!string.IsNullOrEmpty(txtStokKodu.Text) && e.KeyCode == Keys.Tab)
      {
        try
        {
          Stok stok = managerStk.GetById(txtStokKodu.Text,false);
          if (stok != null)
          {
            txtStokIsmi.Text = stok.StokAdi;
            txtAlisKdvOrani.Text = stok.AlisKdvOrani.ToStringOrEmpty();
            txtSatisKdvOrani.Text = stok.SatisKdvOrani.ToStringOrEmpty();
            txtAnaBirim.Text = stok.AnaBirim;
            labAltBirim1.Text = stok.AnaBirim;
            labAltBirim2.Text = stok.AnaBirim;
            labAltBirim3.Text = stok.AnaBirim;
            txtAltBirim1.Text = stok.AltBirim1;
            txtCarpan1.Text = stok.Carpan1.FromNullableToString();
            
            txtAltBirim2.Text = stok.AltBirim2;
            txtCarpan2.Text = stok.Carpan2.FromNullableToString();
            txtAltBirim3.Text = stok.AltBirim3;
            txtCarpan3.Text = stok.Carpan3.FromNullableToString();
            txtAsgariMiktar.Text = stok.AsgariMiktar.FromNullableToString();
            txtAzamiMiktar.Text = stok.AzamiMiktar.FromNullableToString();
            txtAlisFyt1.Text = stok.AlisFiyat1.FromNullableToString();
            txtAlisFyt2.Text = stok.AlisFiyat2.FromNullableToString();
            txtAlisFyt3.Text = stok.AlisFiyat3.FromNullableToString();
            //cmbAlisFytKur.Text = stok.AlisDovTipi.ProperyToStringOrEmpty(x => x.Isim);
            //cmbSatisFyt.Text = stok.SatDovTipi.ProperyToStringOrEmpty(x => x.Isim);
            txtSatisFyt1.Text = stok.SatisFiyat1.FromNullableToString();
            txtSatisFyt2.Text = stok.SatisFiyat2.FromNullableToString();
            txtSatisFyt3.Text = stok.SatisFiyat3.FromNullableToString();
            txtStGrup1.Text = stok.Grup1.ProperyToStringOrEmpty(x => x.Id);
            txtStGrup2.Text = stok.Grup2.ProperyToStringOrEmpty(x => x.Id);
            txtStGrup3.Text = stok.Grup3.ProperyToStringOrEmpty(x => x.Id);
            txtStGrup4.Text = stok.Grup4.ProperyToStringOrEmpty(x => x.Id);
            txtStGrup5.Text = stok.Grup5.ProperyToStringOrEmpty(x => x.Id);

            txtBarkod1.Text = stok.Barkod1;
            txtBarkod2.Text = stok.Barkod2;
            txtBarkod3.Text = stok.Barkod3;
            chkSubelerdeOrtak.Checked = stok.SubelerdeOrtak.HasValue ? stok.SubelerdeOrtak.Value : false;
          }
          txtStokIsmi.Focus();
        }
        catch (Exception exc)
        {
          LogWrite.Write(exc);
          MessageBox.Show(exc.Message);
        }
      } 
    }
    private void frmStok_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter) {
            SendKeys.Send("{TAB}");
        } else if (e.KeyCode == Keys.F5) {
            Kaydet();
        } else if (e.KeyCode == Keys.F7) {
            KayitSil();
        } else if (e.KeyCode == Keys.F3) {
            YeniKayit();
        } else if (e.Alt && e.KeyCode == Keys.D && !string.IsNullOrEmpty(txtStokKodu.Text)) {
            txtStokIsmi.Text = txtStokKodu.Text;
            txtStokIsmi.Focus();
            txtStokIsmi.SelectionStart = txtStokIsmi.Text.Length;

        } else if (e.KeyCode == Keys.Escape)
            this.Close();
      //else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
      //  SelectRow();
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
    
    private void txtAnaBirim_TextChanged(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(txtAnaBirim.Text))
      {
        labAltBirim1.Text = labAltBirim2.Text = labAltBirim3.Text = txtAnaBirim.Text;
      }
    }

    private void btnAnaBirim_Click(object sender, EventArgs e)
    {
      frmStokBirimListe frm = new frmStokBirimListe(txtAnaBirim);
      frm.Owner = this;
      frm.ShowDialog();
    }

    private void btnAltBirim1_Click(object sender, EventArgs e)
    {
      frmStokBirimListe frm = new frmStokBirimListe(txtAltBirim1);
      frm.Owner = this;
      frm.ShowDialog();
    }

    private void btnAltBirim2_Click(object sender, EventArgs e)
    {
      frmStokBirimListe frm = new frmStokBirimListe(txtAltBirim2);
      frm.Owner = this;
      frm.ShowDialog();
    }

    private void btnAltBirim3_Click(object sender, EventArgs e)
    {
      frmStokBirimListe frm = new frmStokBirimListe(txtAltBirim3);
      frm.Owner = this;
      frm.ShowDialog();
    }

    private void btnStReh1_Click(object sender, EventArgs e) {
        frmStokCariCategoryList frm = new frmStokCariCategoryList(StokCariCategory.Stok,txtStGrup1);
        frm.ShowDialog();
        txtStGrup2.Focus();
    }

    private void btnStReh2_Click(object sender, EventArgs e) {
        frmStokCariCategoryList frm = new frmStokCariCategoryList(StokCariCategory.Stok,txtStGrup2,txtStGrup1.Text);
        frm.ShowDialog();
        txtStGrup3.Focus();
    }

    private void btnStReh3_Click(object sender, EventArgs e) {
        frmStokCariCategoryList frm = new frmStokCariCategoryList(StokCariCategory.Stok,txtStGrup3,txtStGrup2.Text);
        frm.ShowDialog();
        txtStGrup4.Focus();
    }

    private void btnStReh4_Click(object sender, EventArgs e) {
        frmStokCariCategoryList frm = new frmStokCariCategoryList(StokCariCategory.Stok, txtStGrup4, txtStGrup3.Text);
        frm.ShowDialog();
        txtStGrup5.Focus();
    }

    private void btnStReh5_Click(object sender, EventArgs e) {
        frmStokCariCategoryList frm = new frmStokCariCategoryList(StokCariCategory.Stok, txtStGrup5, txtStGrup4.Text);
        frm.ShowDialog();
        txtBarkod1.Focus();
    }

    private void tsbtnKapat_Click(object sender, EventArgs e) {
        this.Close();
    }

    private void frmStok_FormClosing(object sender, FormClosingEventArgs e) {
        txtStokKodu.CloseAutoComplete();
    }    
  }
}
