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
  public partial class frmSubeDegistir : Form
  {
    IManagerFactory mngFac;
    ISubeManager mngSube;
    public frmSubeDegistir()
    {
      InitializeComponent();
      mngFac = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
      mngSube = mngFac.GetSubeManager();
      LoadSube();
      cmbSubeKodu.Focus();
    }
    void LoadSube()
    {
      try
      {
        IList<Sube> liste = mngSube.GetAll();
        bool first = true;
        foreach (Sube sube in liste)
        {
          cmbSubeKodu.Items.Add(sube);
          if (first)
          {
            cmbSubeKodu.Text = sube.Id.ToString();
            txtSubeIsmi.Text = sube.SubeIsmi;
            first = false;
          }
        }
      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      }
    }

    private void cmbSubeKodu_SelectedIndexChanged(object sender, EventArgs e)
    {
      Sube sube = (Sube)cmbSubeKodu.SelectedItem;
      txtSubeIsmi.Text = sube.SubeIsmi;
    }

    private void btnDegistir_Click(object sender, EventArgs e)
    {
      try
      {
        UserInfo.Sube = (Sube)cmbSubeKodu.SelectedItem;
        Form frm = this.Owner;
        frm.Text = "IndeksTicari" + "-" + UserInfo.Sube.Id.ToString() + "-" + UserInfo.Sube.SubeIsmi;
        this.Close();
      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      }
    }

    private void btnIptal_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
