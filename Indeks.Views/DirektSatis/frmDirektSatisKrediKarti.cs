using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Indeks.Views
{
  public partial class frmDirektSatisKrediKarti : Form
  {
    public frmDirektSatisKrediKarti()
    {
      InitializeComponent();
    }

    private void btnBankaRehber_Click(object sender, EventArgs e)
    {
      frmBankaHesapRehber frm = new frmBankaHesapRehber();
      frm.Owner = this;
      frm.ShowDialog();
      txtBankaHesapNo.Focus();
    }

    private void btnBankaEkle_Click(object sender, EventArgs e)
    {
      frmHesapEkle frm = new frmHesapEkle();
      frm.Owner = this;
      frm.ShowDialog();
    }
    void Kapat()
    {
      if (this.Owner is frmDirektSatis)
      {
        frmDirektSatis frm = (frmDirektSatis)this.Owner;
        frm.HesapNo = txtBankaHesapNo.Text;
        frm.SatisYap = true;
      }
      this.Close();
    }
    private void btnSec_Click(object sender, EventArgs e)
    {
      Kapat();
    }

    private void frmDirektSatisKrediKarti_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        SendKeys.Send("{TAB}");
      }
      else if (Keys.F5 == e.KeyCode)
      {
        Kapat();
      }
    }
  }
}
