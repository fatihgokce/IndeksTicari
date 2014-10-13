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
  public partial class frmDirekSatisVeresiye : Form
  {
    IManagerFactory mngFct;
    ICariManager mngCari;
    public frmDirekSatisVeresiye()
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

    private void btnCariRehber_Click(object sender, EventArgs e)
    {
      frmCariRehber frm = new frmCariRehber();
      frm.Owner = this;
      frm.Show();
    }

    private void frmDirekSatisVeresiye_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        //SendKeys.Send("{TAB}");
          if (!string.IsNullOrEmpty(txtCariKodu.Text))
              Kapat();
      }
      else if (Keys.F5 == e.KeyCode)
      {
        Kapat();
      }
    }

    private void btnHizliCari_Click(object sender, EventArgs e)
    {
      frmHizliCari frm = new frmHizliCari();
      frm.Owner = this;
      frm.ShowDialog();
    }
    void Kapat()
    {
      if (this.Owner is frmDirektSatis)
      {
        frmDirektSatis frm = (frmDirektSatis)this.Owner;
        frm.CariKodu = txtCariKodu.Text;
        frm.VadeTarih = dateTarih.Value;
        frm.SatisYap = true;
      }
      this.Close();
    }
    private void btnSec_Click(object sender, EventArgs e)
    {
      Kapat();
    }
  }
}
