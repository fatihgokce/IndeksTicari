using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Indeks.Data.BusinessObjects;
using Indeks.Data.Base;
using Indeks.Data.ManagerObjects;
namespace Indeks.Views
{
  public partial class frmHizliCari : BaseForm
  {
    IManagerFactory mngFct;
    ICariManager mngCari;
    public frmHizliCari()
    {
      InitializeComponent();
      mngFct = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
      mngCari = mngFct.GetCariManager();
      txtCariKodu.DataSource = () =>
      {
        try
        {
          return mngCari.GetCariKodsBySubeKodu(UserInfo.Sube.Id, txtCariKodu.Text).ToStringList(15,txtCariKodu.Ayirac);
        }
        catch (Exception exc)
        {
          MessageBox.Show(exc.Message);
          LogWrite.Write(exc);
        }
        return null;
      };
    }

    private void frmHizliCari_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        SendKeys.Send("{TAB}");
      }
      else if (Keys.F5 == e.KeyCode)
      {
        Kaydet();
      }
      else if (Keys.Escape == e.KeyCode)
        Kapat();
    }
    void Kapat()
    {
      this.Close();
    }
    void Kaydet()
    {
      try
      {
        if (string.IsNullOrEmpty(txtCariKodu.Text))
        {
          MessageBox.Show("cari kodu boş olamaz");
          txtCariKodu.Focus();
        }
        Cari cari = mngCari.GetById(txtCariKodu.Text,false) ;
        if (cari == null) {
            cari = new Cari();
            cari.KayitTarih = DateTime.Today;
        }
        cari.Id = txtCariKodu.Text;
        cari.CariIsim = txtCariIsim.Text;
        if (Char.IsDigit(txtTel.Text[1]))
          cari.CariTel = txtTel.Text;
        if (Char.IsDigit(txtCepTel.Text[1]))
          cari.CepTel =  txtCepTel.Text;
        cari.CariAdres = txtCariAdres.Text;
        cari.CariTel = txtTel.Text;
        cari.CepTel = txtCepTel.Text;
        cari.VergiDairesi = txtVergiDairesi.Text;
        cari.VergiNumarasi = txtVergiNumarasi.Text;
        //if (rbAliciSatici.Checked)
        //  cari.CariTip = "AS";
        //else if (rbAlici.Checked)
        //  cari.CariTip = "A";
        //else
        //  cari.CariTip = "S";
        cari.CariTip = "A";
      
        cari.Sube = UserInfo.Sube;
        mngCari.BeginTransaction();
        cari = mngCari.Save(cari);
      
        if (this.Owner is frmDirekSatisVeresiye)
        {
          frmDirekSatisVeresiye frm = (frmDirekSatisVeresiye)this.Owner;
          frm.txtCariKodu.Text = cari.Id;
        }
        if (this.Owner is frmDirektSatis) {
            frmDirektSatis frm = (frmDirektSatis)this.Owner;
            frm.KasaCariKodu = cari.Id;
            frm.SatisYap = true;
        }
        this.Close();
      }
      catch (Exception)
      {
      } finally {
          try {
              mngCari.CommitTransaction();
          } catch (Exception exc) {
              MessageBox.Show(exc.Message);
              LogWrite.Write(exc);
          }
      }
      //finally { CommitTransaction(); }
    }
    private void tsbtnKaydet_Click(object sender, EventArgs e)
    {
      Kaydet();
    }

    private void tsbtnKapat_Click(object sender, EventArgs e)
    {
      Kapat();
    }

    private void frmHizliCari_FormClosing(object sender, FormClosingEventArgs e) {
        txtCariKodu.CloseAutoComplete();
    }

    private void btnCariRehber_Click(object sender, EventArgs e) {
        CleareForm.ClearThisConrol(groupBox1)
                             .BeginClear();
        frmCariRehber frm = new frmCariRehber();
        frm.Owner = this;
        frm.Show();
        txtCariKodu.Focus();
    }

    private void txtCariKodu_KeyUp(object sender, KeyEventArgs e) {
        if (!string.IsNullOrEmpty(txtCariKodu.Text)) {
            try {
                Cari cari = mngCari.GetById(txtCariKodu.Text, false);
                if (cari != null) {
                    CleareForm.ClearThisConrol(groupBox1)
                              .NotClearTheseConrols(txtCariKodu)
                              .BeginClear();
                    txtCariIsim.Text = cari.CariIsim;
                    txtTel.Text = cari.CariTel;
                    txtCepTel.Text = cari.CepTel;
                    txtCariAdres.Text = cari.CariAdres;

                    txtVergiDairesi.Text = cari.VergiDairesi;
                    txtVergiNumarasi.Text = cari.VergiNumarasi;
                    txtCariKodu.CloseAutoComplete();
                    if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
                        txtCariIsim.Focus();
                    //txtCariIsim.Focus();
                } else {
                    CleareForm.ClearThisConrol(groupBox1).NotClearTheseConrols(txtCariKodu).BeginClear();
                    if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
                        txtCariIsim.Focus();
                }
            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            }
            //txtCariIsim.Focus();
        } else
            CleareForm.ClearThisConrol(groupBox1).NotClearTheseConrols(txtCariKodu).BeginClear();
    }

    private void txtCariKodu_TextChanged(object sender, EventArgs e) {

    }
  }
}
