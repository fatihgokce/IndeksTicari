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
  public partial class frmCariRehber : BaseForm
  {
    IManagerFactory mngFct;
    ICariManager mngCari;
    ICariCategoryManager mngCariCat;
    bool _cariKaydet;
    public frmCariRehber()
    {
        _cariKaydet = true;
      InitializeComponent();
      mngFct = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
      mngCari = mngFct.GetCariManager();
      mngCariCat = mngFct.GetCariCategoryManager();
     
     
      LoadCari();
    }
    void LoadCari() {
        try {
            IList<Cari> liste = mngCari.GetBySUBE_KODU(UserInfo.Sube.Id);
            LoadAllCari(liste);
        } catch (Exception exc) {
            MessageBox.Show(exc.Message);
            LogWrite.Write(exc);
        }
    }
    private void txtCariKod_TextChanged(object sender, EventArgs e)
    {
      LoadCariByCriter();
    }
    void LoadCariByCriter()
    {
      try
      {
        Cari cari = new Cari { Id = txtCariKod.Text, CariIsim = txtCariIsim.Text, Sube = UserInfo.Sube };
     
        if (rbAlici.Checked)
          cari.CariTip = "A";
        else if (rbSatici.Checked)
          cari.CariTip = "S";
        else
          cari.CariTip = "AS";
        cari.Grup1 = new CariCategory { Id = txtGrup1.Text, Sube = UserInfo.Sube };
        cari.Grup2 = new CariCategory { Id = txtGrup2.Text, Sube = UserInfo.Sube };
        cari.Grup3 = new CariCategory { Id = txtGrup3.Text, Sube = UserInfo.Sube };
        cari.Grup4 = new CariCategory { Id = txtGrup4.Text, Sube = UserInfo.Sube };
        LoadAllCari(mngCari.SearchCariByCriter(cari));
      }
      catch (Exception exc)
      {
        LogWrite.Write(exc); MessageBox.Show(exc.Message);
      }
    }
    void LoadAllCari(IList<Cari> liste)
    {
      try
      {
        
        listView1.Items.Clear();
        foreach (Cari cari in liste)
        {
          ListViewItem item = new ListViewItem(cari.Id);
          item.SubItems.Add(cari.CariIsim);
          item.SubItems.Add(cari.CariTel);
          item.SubItems.Add(cari.Fax);
          item.SubItems.Add(cari.CepTel);
          item.SubItems.Add(cari.CariAdres);
          item.SubItems.Add(cari.Il);
          item.SubItems.Add(cari.Ilce);
          item.SubItems.Add(cari.VergiDairesi);
          item.SubItems.Add(cari.VergiNumarasi);
          item.SubItems.Add(cari.CariEmail);       
          item.SubItems.Add(cari.WebAdresi);
          item.SubItems.Add(cari.YetkiliKisi);
          item.SubItems.Add(cari.Grup1.ProperyToStringOrEmpty(x => x.Id));
          item.SubItems.Add(cari.Grup2.ProperyToStringOrEmpty(x => x.Id));
          item.SubItems.Add(cari.Grup3.ProperyToStringOrEmpty(x => x.Id));
          item.SubItems.Add(cari.Grup4.ProperyToStringOrEmpty(x => x.Id));
          item.SubItems.Add(cari.CariTip);
          item.SubItems.Add(cari.AlisFiyatKod);
          item.SubItems.Add(cari.SatisFiyatKod);
          listView1.Items.Add(item);
        }
      }
      catch (Exception exc)
      {
        LogWrite.Write(exc);
        MessageBox.Show(exc.Message);
      }
    }
    void KayitSil() {
           DialogResult re = MessageBox.Show("Kayıt Silinsin mi?", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        if (re == DialogResult.Yes) {
            try {
                ListViewItem item = listView1.SelectedItems[0];
                string cariKodu = item.SubItems[0].Text;
                if (string.IsNullOrEmpty(cariKodu)) {
                    MessageBox.Show("cari seçiniz");
                    return;
                }
                Cari cari = mngCari.GetById(cariKodu, true);
                mngCari.BeginTransaction();
                mngCari.Delete(cari);                

            } catch (Exception) {
            } finally {
                try {
                    mngCari.CommitTransaction();
                    LoadCari();
                } catch (Exception exc) { MessageBox.Show(exc.Message); LogWrite.Write(exc); }
            }
       }
    }
    void yeniKayit() {
        if (_cariKaydet) {
            frmCari frm = new frmCari();
            frm.Owner = this;
            frm.ShowDialog();
            LoadCari();
        }
    }
    private void listView1_DoubleClick(object sender, EventArgs e)
    {
        Sec();
    }
    void Sec() {
        try {
            if (this.Owner is frmCari) {
                frmCari frmCari = (frmCari)this.Owner;
                frmCari.YeniKayit();
                ListViewItem item = listView1.SelectedItems[0];
                frmCari.txtCariKodu.Text = item.SubItems[0].Text;
                frmCari.txtCariIsim.Text = item.SubItems[1].Text;
                frmCari.txtTel.Text = item.SubItems[2].Text;
                frmCari.txtFax.Text = item.SubItems[3].Text;
                frmCari.txtCepTel.Text = item.SubItems[4].Text;
                frmCari.txtCariAdres.Text = item.SubItems[5].Text;
                frmCari.txtIl.Text = item.SubItems[6].Text;
                frmCari.txtIlce.Text = item.SubItems[7].Text;
                frmCari.txtVergiDairesi.Text = item.SubItems[8].Text;
                frmCari.txtVergiNumarasi.Text = item.SubItems[9].Text;
                frmCari.txtCariEmil.Text = item.SubItems[10].Text;
                frmCari.txtWebAdres.Text = item.SubItems[11].Text;
                frmCari.txtYetkiliKisi.Text = item.SubItems[12].Text;
                frmCari.txtCariGrup1.Text = item.SubItems[13].Text;
                frmCari.txtCariGrup2.Text = item.SubItems[14].Text;
                frmCari.txtCariGrup3.Text = item.SubItems[15].Text;
                frmCari.txtCariGrup4.Text = item.SubItems[16].Text;
                if (item.SubItems[17].Text.Contains("AS"))
                    frmCari.rbAliciSatici.Checked = true;
                else if (item.SubItems[17].Text.Contains("S"))
                    frmCari.rbSatici.Checked = true;
                else
                    frmCari.rbAlici.Checked = true;
                frmCari.cmbAlisFiyatKod.Text = item.SubItems[18].Text;
                frmCari.cmbSatisFiyatKod.Text = item.SubItems[19].Text;
                frmCari.txtCariKodu.ReadOnly = true;
                frmCari.txtCariIsim.Focus();
                Cari cari = mngCari.GetById(frmCari.txtCariKodu.Text, false);
                frmCari.chkSubelerdeOrtak.Checked = cari.SubelerdeOrtak.HasValue ? cari.SubelerdeOrtak.Value : false;

            } else if (this.Owner is frmFatura) {
                frmFatura frm = (frmFatura)this.Owner;
                ListViewItem item = listView1.SelectedItems[0];
                frm.txtCari.Text = item.SubItems[0].Text;

            } else if (this.Owner is frmSiparis) {
                frmSiparis frm = (frmSiparis)this.Owner;
                ListViewItem item = listView1.SelectedItems[0];
                frm.txtCari.Text = item.SubItems[0].Text;

            } else if (this.Owner is frmBankaHareket) {
                frmBankaHareket frm = (frmBankaHareket)this.Owner;
                ListViewItem item = listView1.SelectedItems[0];
                frm.txtCariKodu.Text = item.SubItems[0].Text;

            } else if (this.Owner is frmDirekSatisVeresiye) {
                frmDirekSatisVeresiye frm = (frmDirekSatisVeresiye)this.Owner;
                ListViewItem item = listView1.SelectedItems[0];
                frm.txtCariKodu.Text = item.SubItems[0].Text;

            } else if (this.Owner is frmYeniCek) {
                frmYeniCek frm = (frmYeniCek)this.Owner;
                ListViewItem item = listView1.SelectedItems[0];
                frm.txtCariKodu.Text = item.SubItems[0].Text;
            } else if (this.Owner is frmCekDurum) {
                frmCekDurum frm = (frmCekDurum)this.Owner;
                ListViewItem item = listView1.SelectedItems[0];
                frm.txtCari.Text = item.SubItems[0].Text;

            } else if (this.Owner is frmSenetDurum) {
                frmSenetDurum frm = (frmSenetDurum)this.Owner;
                ListViewItem item = listView1.SelectedItems[0];
                frm.txtCari.Text = item.SubItems[0].Text;

            } else if (this.Owner is frmKasaKayitlari) {
                frmKasaKayitlari frm = (frmKasaKayitlari)this.Owner;
                ListViewItem item = listView1.SelectedItems[0];
                frm.txtCariKod.Text = item.SubItems[0].Text;

            } else if (this.Owner is frmCariGenelBorcAlacakDokumu) {
                frmCariGenelBorcAlacakDokumu frm = (frmCariGenelBorcAlacakDokumu)this.Owner;
                ListViewItem item = listView1.SelectedItems[0];
                frm.txtCariKodu.Text = item.SubItems[0].Text;

            } else if (this.Owner is frmCariHareketDokumu) {
                frmCariHareketDokumu frm = (frmCariHareketDokumu)this.Owner;
                ListViewItem item = listView1.SelectedItems[0];
                frm.txtCariKodu.Text = item.SubItems[0].Text;

            } else if (this.Owner is frmFaturaRapor) {
                frmFaturaRapor frm = (frmFaturaRapor)this.Owner;
                ListViewItem item = listView1.SelectedItems[0];
                frm.txtCariKodu.Text = item.SubItems[0].Text;
            } else if (this.Owner is frmSiparisRapor) {
                frmSiparisRapor frm = (frmSiparisRapor)this.Owner;
                ListViewItem item = listView1.SelectedItems[0];
                frm.txtCariKodu.Text = item.SubItems[0].Text;
            } else if (this.Owner is frmCekRapor) {
                frmCekRapor frm = (frmCekRapor)this.Owner;
                ListViewItem item = listView1.SelectedItems[0];
                frm.txtCariKodu.Text = item.SubItems[0].Text;
            } else if (this.Owner is frmSenetRapor) {
                frmSenetRapor frm = (frmSenetRapor)this.Owner;
                ListViewItem item = listView1.SelectedItems[0];
                frm.txtCariKodu.Text = item.SubItems[0].Text;
            } else if (this.Owner is frmYeniSenet) {
                frmYeniSenet frm = (frmYeniSenet)this.Owner;
                ListViewItem item = listView1.SelectedItems[0];
                frm.txtCariKodu.Text = item.SubItems[0].Text;
            } else if (this.Owner is frmHizliCari) {
                frmHizliCari frm = (frmHizliCari)this.Owner;
                ListViewItem item = listView1.SelectedItems[0];
                frm.txtCariKodu.Text = item.SubItems[0].Text;
                frm.txtCariIsim.Text = item.SubItems[1].Text;
                frm.txtTel.Text = item.SubItems[2].Text;
                frm.txtCepTel.Text = item.SubItems[4].Text;
                frm.txtCariAdres.Text = item.SubItems[5].Text;
                frm.txtVergiDairesi.Text = item.SubItems[8].Text;
                frm.txtVergiNumarasi.Text = item.SubItems[9].Text;
            }
            this.Close();

        } catch {

        }
    }
    private void rbAlici_CheckedChanged(object sender, EventArgs e)
    {
      LoadCariByCriter();
    }

    private void frmCariRehber_KeyDown(object sender, KeyEventArgs e)
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

    private void tsbtnSil_Click(object sender, EventArgs e) {
        KayitSil();
    }

    private void tsbtnKapat_Click(object sender, EventArgs e) {
        this.Close();
    }

    private void bakiyeGosterToolStripMenuItem_Click(object sender, EventArgs e) {
        try {
            ListViewItem item = listView1.SelectedItems[0];
            string cariKodu = item.SubItems[0].Text;
            frmCariBakiye frm = new frmCariBakiye(cariKodu);
            frm.ShowDialog();
        } catch (Exception exc) { LogWrite.Write(exc); MessageBox.Show(exc.Message); }
    }

    private void silToolStripMenuItem_Click(object sender, EventArgs e) {
        KayitSil();
    }

    private void frmCariRehber_Load(object sender, EventArgs e) {
        Form frm = this.Owner;
        if (frm != null && frm is frmCari) {
            _cariKaydet = false;
            tsbtnYeniKayit.Enabled = false;
        }
    }

    private void listView1_Enter(object sender, EventArgs e) {
       // Sec();
    }

    private void listView1_KeyUp(object sender, KeyEventArgs e) {
        if (e.KeyCode == Keys.Enter)
            Sec();
    } 
  }
}
