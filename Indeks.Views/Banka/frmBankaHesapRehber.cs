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
namespace Indeks.Views
{
  public partial class frmBankaHesapRehber : Form
  {
    IBankaHesapManager mngBankaHesap;
    public frmBankaHesapRehber()
    {
      InitializeComponent();
      dataGridView1.AutoGenerateColumns = false;
      
      IManagerFactory mng = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
      mngBankaHesap = mng.GetBankaHesapManager();      
      LoadGrid();
    }
    void LoadGrid()
    {
      try
      {
        dataGridView1.DataSource = mngBankaHesap.GetAll();
      }
      catch (Exception exc)
      {
        LogWrite.Write(exc);
        MessageBox.Show(exc.Message);
      }
    }
    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      try
      {
        if (this.Owner is frmBankaHareket)
        {
          frmBankaHareket frm = (frmBankaHareket)this.Owner;
          frm.txtHesapNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToStringOrEmpty().Trim();

        }
        else if (this.Owner is frmBankaHareketRapor)
        {
          frmBankaHareketRapor frm = (frmBankaHareketRapor)this.Owner;
          frm.txtHesapNo.Text = dataGridView1.CurrentRow.Cells[clHesapNo.Name].Value.ToStringOrEmpty().Trim();
          frm.txtHesapSahip.Text = dataGridView1.CurrentRow.Cells[clHesapSahibi.Name].Value.ToStringOrEmpty();
          frm.txtBankaAdi.Text = dataGridView1.CurrentRow.Cells[clBankaAdi.Name].Value.ToStringOrEmpty();
          frm.txtSubeAdi.Text = dataGridView1.CurrentRow.Cells[clSubeAdi.Name].Value.ToStringOrEmpty();
          frm.txtParaBirimi.Text = dataGridView1.CurrentRow.Cells[clParaBirimi.Name].Value.ToStringOrEmpty();
        }
        else if (this.Owner is frmFatura)
        {
          frmFatura frm = (frmFatura)this.Owner;
          frm.txtBankaHesapNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToStringOrEmpty().Trim();
        }
        else if (this.Owner is frmDirektSatisKrediKarti)
        {
          frmDirektSatisKrediKarti frm = (frmDirektSatisKrediKarti)this.Owner;
          frm.txtBankaHesapNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToStringOrEmpty().Trim();
        } else if (this.Owner is frmCekDurum) {
            frmCekDurum frm = (frmCekDurum)this.Owner;
            frm.txtBankaHesap.Text = dataGridView1.CurrentRow.Cells[clHesapNo.Name].Value.ToStringOrEmpty().Trim();
        } else if (this.Owner is frmYeniCek) {
            frmYeniCek frm = (frmYeniCek)this.Owner;
            DataGridViewRow dr=dataGridView1.CurrentRow;
            frm.txtHesapNo.Text = dr.Cells[clHesapNo.Name].Value.ToStringOrEmpty();
            frm.txtBanka.Text = dr.Cells[clBankaAdi.Name].Value.ToStringOrEmpty();
            frm.txtSube.Text = dr.Cells[clSubeAdi.Name].Value.ToStringOrEmpty();
        } else if (this.Owner is frmSenetDurum) {
            frmSenetDurum frm = (frmSenetDurum)this.Owner;
            frm.txtBankaHesap.Text = dataGridView1.CurrentRow.Cells[clHesapNo.Name].Value.ToStringOrEmpty().Trim();
        }
        this.Close();
      }
      catch (Exception exc)
      {
        LogWrite.Write(exc);
        MessageBox.Show(exc.Message);
      }
    }
  }
}
