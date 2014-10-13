using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Indeks.Data.BusinessObjects;
using Indeks.Data.ManagerObjects;
namespace Indeks.Views
{
  public partial class frmStokSearch : BaseForm
  {
      private const int LVStokKoduColumnIndex = 1;
    IManagerFactory managerFctry;
    IStokManager managerStk;
    IStokHareketManager _mngStokHar;
    IStokCategoryManager mngStokCat;
    IKurManager mngKur;
    FTIRSIP _ftirsip;//fatura için
    bool _stokKaydet;
    public frmStokSearch()
    {
      InitializeComponent();
    }
    public frmStokSearch(FTIRSIP ftirsip)
    {
      InitializeComponent();
      _ftirsip = ftirsip;
    }

    private void frmStokSearch_Load(object sender, EventArgs e)
    {
      _stokKaydet = true;
      managerFctry = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
      managerStk = managerFctry.GetStokManager();
      mngStokCat = managerFctry.GetStokCategoryManager();
      _mngStokHar = managerFctry.GetStokHareketManager();
      mngKur = managerFctry.GetKurManager();
      LoadStok();
      Form frm=this.Owner;
      if (frm is frmStok) {
          tsbtnYeniKayit.Enabled = false;
          _stokKaydet = false;
      }
    }
    void LoadStok() {
        try {
            LoadAllStok((List<Stok>)managerStk.GetBySUBE_KODU(UserInfo.Sube.Id));
        } catch (Exception exc) {
            MessageBox.Show(exc.Message);
            LogWrite.Write(exc);
        }
    }
    void LoadAllStok(List<Stok>stokList)
    {
      try
      {
        listView1.Items.Clear();
        List<Stok> listStok = stokList;
        foreach (Stok stok in listStok)
        {
          double miktar=_mngStokHar.GetStokMiktar(stok.Id);
          ListViewItem item = new ListViewItem(miktar.ToString("F2"));
          item.SubItems.Add(stok.Id);  
          item.SubItems.Add(stok.StokAdi);
          item.SubItems.Add(stok.AlisKdvOrani.ToStringOrEmpty());
          item.SubItems.Add(stok.SatisKdvOrani.ToStringOrEmpty());
          item.SubItems.Add(stok.AnaBirim);
          item.SubItems.AddNullControlData(stok.AsgariMiktar);
          item.SubItems.AddNullControlData(stok.AzamiMiktar);
          item.SubItems.Add("");
          //item.SubItems.Add(stok.AlisDovTipi.ProperyToStringOrEmpty(x => x.Isim));
          item.SubItems.AddNullControlData(stok.SatisFiyat1);
          //item.SubItems.Add(stok.SatDovTipi.ProperyToStringOrEmpty(x => x.Isim));
          item.SubItems.Add(stok.Grup1.ProperyToStringOrEmpty(x => x.Id));
          item.SubItems.Add(stok.Grup2.ProperyToStringOrEmpty(x => x.Id));
          item.SubItems.Add(stok.Grup3.ProperyToStringOrEmpty(x => x.Id));
          item.SubItems.Add(stok.Grup4.ProperyToStringOrEmpty(x => x.Id));
          item.SubItems.Add(stok.Grup5.ProperyToStringOrEmpty(x => x.Id));
          item.SubItems.Add(stok.Barkod1); item.SubItems.Add(stok.Barkod2);
          item.SubItems.Add(stok.Barkod3);

          if (miktar <= 0) {
            item.BackColor = Color.Red;
            item.ForeColor = Color.White;
              
          }
          listView1.Items.Add(item);

        }
      }
      catch (Exception exc)
      {
        LogWrite.Write(exc);
        MessageBox.Show(exc.Message);
      }
    }

    private void txtStokKodu_TextChanged(object sender, EventArgs e)
    {
      try
      {
        Stok stok = new Stok() { Id = txtStokKodu.Text, StokAdi = txtStokAdi.Text,Sube=UserInfo.Sube };
        stok.Grup1 = new StokCategory() { Id = txtGrupKodu.Text,Sube=UserInfo.Sube };
        stok.Grup2 = new StokCategory() { Id = txtKod1.Text,Sube=UserInfo.Sube };
        stok.Grup3 = new StokCategory() { Id = txtKod2.Text,Sube=UserInfo.Sube };
        stok.Grup4 = new StokCategory() { Id = txtKod3.Text,Sube=UserInfo.Sube };
        stok.Grup5 = new StokCategory() { Id = txtKod4.Text,Sube=UserInfo.Sube };
        LoadAllStok(managerStk.SearchStokByCriter(stok));
      }
      catch (Exception exc)
      {
        LogWrite.Write(exc); MessageBox.Show(exc.Message);
      }
    }

    private void listView1_DoubleClick(object sender, EventArgs e)
    {
        Sec();
    }
    void Sec() {
        try {
            
            Stok stok = managerStk.GetById(listView1.SelectedItems[0].SubItems[clStokKodu.DisplayIndex].Text, false);
            if (this.Owner is frmDirektSatis) {
                frmDirektSatis frmD = (frmDirektSatis)this.Owner;
                if (stok != null) {
                    if (!string.IsNullOrEmpty(stok.Barkod1))
                        frmD.txtBarkod.Text = stok.Barkod1;
                    else
                        frmD.txtBarkod.Text = stok.Id;
                    frmD.txtSatisFiyat.Text = stok.SatisFiyat1.GetValueOrDefault().ToString();
                    frmD.labSecilenUrun.Text = string.Format("{0} {1}", stok.Id, stok.StokAdi);
                    frmD.txtSatisFiyat.Focus();
                }
                this.Close();
            }
            if (this.Owner is frmStok) {
                frmStok frmStk = (frmStok)this.Owner;
                if (stok != null) {
                    frmStk.txtStokKodu.Text = stok.Id;
                    frmStk.txtStokIsmi.Text = stok.StokAdi;
                    frmStk.txtAlisKdvOrani.Text = stok.AlisKdvOrani.ToString();
                    frmStk.txtSatisKdvOrani.Text = stok.SatisKdvOrani.ToString();
                    frmStk.txtAnaBirim.Text = stok.AnaBirim;
                    frmStk.txtAltBirim1.Text = stok.AltBirim1;
                    frmStk.txtCarpan1.Text = stok.Carpan1.FromNullableToString();
                    frmStk.labAltBirim1.Text = frmStk.labAltBirim2.Text = frmStk.labAltBirim3.Text = stok.AnaBirim;
                    frmStk.txtAltBirim2.Text = stok.AltBirim2;
                    frmStk.txtCarpan2.Text = stok.Carpan2.FromNullableToString();
                    frmStk.txtAltBirim3.Text = stok.AltBirim3;
                    frmStk.txtCarpan3.Text = stok.Carpan3.FromNullableToString();

                    frmStk.txtAsgariMiktar.Text = stok.AsgariMiktar.FromNullableToString();
                    frmStk.txtAzamiMiktar.Text = stok.AzamiMiktar.FromNullableToString();
                    frmStk.txtAlisFyt1.Text = stok.AlisFiyat1.FromNullableToString();
                    frmStk.txtAlisFyt2.Text = stok.AlisFiyat2.FromNullableToString();
                    frmStk.txtAlisFyt3.Text = stok.AlisFiyat3.FromNullableToString();
                    //frmStk.cmbAlisFytKur.Text = item.SubItems[7].Text;
                    frmStk.txtSatisFyt1.Text = stok.SatisFiyat1.FromNullableToString();
                    frmStk.txtSatisFyt2.Text = stok.SatisFiyat2.FromNullableToString();
                    frmStk.txtSatisFyt3.Text = stok.SatisFiyat3.FromNullableToString();
                    //frmStk.cmbSatisFyt.Text = item.SubItems[9].Text;
                    frmStk.txtStGrup1.Text = stok.Grup1.ProperyToStringOrEmpty(x => x.Id);
                    frmStk.txtStGrup2.Text = stok.Grup2.ProperyToStringOrEmpty(x => x.Id);
                    frmStk.txtStGrup3.Text = stok.Grup3.ProperyToStringOrEmpty(x => x.Id);
                    frmStk.txtStGrup4.Text = stok.Grup4.ProperyToStringOrEmpty(x => x.Id);
                    frmStk.txtStGrup5.Text = stok.Grup5.ProperyToStringOrEmpty(x => x.Id);

                    frmStk.txtBarkod1.Text = stok.Barkod1;
                    frmStk.txtBarkod2.Text = stok.Barkod2;
                    frmStk.txtBarkod3.Text = stok.Barkod3;
                    frmStk.chkSubelerdeOrtak.Checked = stok.SubelerdeOrtak.HasValue ? stok.SubelerdeOrtak.Value : false;
                }
                this.Close();
            } else if (this.Owner is frmStokAlisSatisRaporKriter) {
                frmStokAlisSatisRaporKriter frmStk2 = (frmStokAlisSatisRaporKriter)this.Owner;               
                ListViewItem item = listView1.SelectedItems[0];
                frmStk2.txtStokKodu.Text = item.SubItems[clStokKodu.DisplayIndex].Text;
                this.Close();
            } else if (this.Owner is frmFatura) {
                frmFatura frm = (frmFatura)this.Owner;
                ListViewItem item = listView1.SelectedItems[0];
                if (stok != null) {
                    frm.txtBarkod.Text = stok.Barkod1; //item.SubItems[13].Text;
                    frm.txtStokKodu.Text = stok.Id;//item.SubItems[0].Text;
                    frm.txtStokIsmi.Text = stok.StokAdi;//item.SubItems[1].Text;
                }               

                if (FTIRSIP.AlisFat == _ftirsip || FTIRSIP.AlisIrs == _ftirsip) {
                    frm.txtFyt.Text = stok.AlisFiyat1.FromNullableToString();//item.SubItems[6].Text;
                } else if (FTIRSIP.SatisFat == _ftirsip || FTIRSIP.SatisIrs == _ftirsip) {
                    frm.txtFyt.Text = stok.SatisFiyat1.FromNullableToString();//item.SubItems[7].Text;
                }
                frm.txtStokKodu.Focus();
                this.Close();
            } else if (this.Owner is frmSiparis) {
                frmSiparis frm = (frmSiparis)this.Owner;
                ListViewItem item = listView1.SelectedItems[0];
               
                if (stok != null) {
                    frm.txtBarkod.Text = stok.Barkod1; //item.SubItems[13].Text;
                    frm.txtStokKodu.Text = stok.Id;//item.SubItems[0].Text;
                    frm.txtStokIsmi.Text = stok.StokAdi;//item.SubItems[1].Text;
                }
               
                if (FTIRSIP.SaticiSip == _ftirsip) {
                    frm.txtFyt.Text = stok.AlisFiyat1.FromNullableToString();//item.SubItems[6].Text;
                } else if (FTIRSIP.MusSip == _ftirsip) {
                    frm.txtFyt.Text = stok.SatisFiyat1.FromNullableToString();//item.SubItems[7].Text;
                }
                frm.txtStokKodu.Focus();
                this.Close();
            } else if (this.Owner is frmStokHareketKriter) {
                frmStokHareketKriter frmStk = (frmStokHareketKriter)this.Owner;
                ListViewItem item = listView1.SelectedItems[0];
                frmStk.txtStokKodu.Text = item.SubItems[clStokKodu.DisplayIndex].Text;
                this.Close();
            } else if (this.Owner is frmStokMaliyetRaporu) {
                frmStokMaliyetRaporu frmStk = (frmStokMaliyetRaporu)this.Owner;
                ListViewItem item = listView1.SelectedItems[0];
                frmStk.txtStokKodu.Text = item.SubItems[clStokKodu.DisplayIndex].Text;
                this.Close();
            } else if (this.Owner is frmStokAlisSatisRaporKriter) {
                frmStokAlisSatisRaporKriter frmStk = (frmStokAlisSatisRaporKriter)this.Owner;
                ListViewItem item = listView1.SelectedItems[0];
                frmStk.txtStokKodu.Text = item.SubItems[clStokKodu.DisplayIndex].Text;
                this.Close();
            } else if (this.Owner is frmStokDurumRaporu) {
                frmStokDurumRaporu frmStk = (frmStokDurumRaporu)this.Owner;
                ListViewItem item = listView1.SelectedItems[0];
                frmStk.txtStokKodu.Text = item.SubItems[clStokKodu.DisplayIndex].Text;
                this.Close();
            }
        } catch { }
    }
    private void frmStokSearch_KeyDown(object sender, KeyEventArgs e)
    {
        //if (e.KeyCode == Keys.Enter) {
        //    SendKeys.Send("{TAB}");
        if (e.KeyCode == Keys.F3)
            yeniKayit();
        else if (e.KeyCode == Keys.F7)
            KayitSil();
        else if (e.KeyCode == Keys.Escape)
            this.Close();
    }

    private void tsbtnYeniKayit_Click(object sender, EventArgs e) {
        yeniKayit();
    }
    void KayitSil() {
        try {
            DialogResult re = MessageBox.Show("Kayıt Silinsin mi?", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (re == DialogResult.Yes) {
                ListViewItem item = listView1.SelectedItems[0];
                string stokKodu = item.SubItems[clStokKodu.DisplayIndex].Text;
                if (string.IsNullOrEmpty(stokKodu)) {
                    MessageBox.Show("stok seçiniz");
                    return;
                }
                Stok stok = managerStk.GetById(stokKodu,true);
                managerStk.BeginTransaction();
                managerStk.Delete(stok);
                managerStk.CommitTransaction();
              
                LoadStok();

            }
        } catch (Exception exc) {
            LogWrite.Write(exc);
            MessageBox.Show(exc.Message);
        }
    }
    void yeniKayit() {
        if (_stokKaydet) {
            frmStok frm = new frmStok();
            frm.Owner = this;
            frm.ShowDialog();
            LoadStok();
        }
    }
    private void tsbtnSil_Click(object sender, EventArgs e) {
        KayitSil();
    }

    private void tsbtnKapat_Click(object sender, EventArgs e) {
        this.Close();
    }

    private void listView1_Enter(object sender, EventArgs e) {
        //Sec();
    }

    private void listView1_KeyUp(object sender, KeyEventArgs e) {
        if (e.KeyCode == Keys.Enter)
            Sec();
    }
   
  }
}
