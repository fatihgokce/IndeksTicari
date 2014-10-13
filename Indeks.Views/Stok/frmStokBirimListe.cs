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
  public partial class frmStokBirimListe : Form
  {
    IManagerFactory mngFac;
    IStokBirimManager mngStokBirim;
    TextBox _desTextBox;
    public frmStokBirimListe(TextBox destTextBox)
    {
      InitializeComponent();
      mngFac = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
      mngStokBirim = mngFac.GetStokBirimManager();
      _desTextBox = destTextBox;
      LoadGrid();
    }
    public void LoadGrid()
    {
      try
      {
        dataGridViewCari.AutoGenerateColumns = false;
        dataGridViewCari.DataSource = mngStokBirim.GetAll();
      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      }
    }

    private void dataGridViewCari_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      _desTextBox.Text = dataGridViewCari.CurrentRow.Cells[clBirim.Name].Value.ToStringOrEmpty().Trim();
      _desTextBox.Focus();
      this.Close();
    }

    private void btnYeni_Click(object sender, EventArgs e)
    {
      frmStokBirim frm = new frmStokBirim();
      frm.Owner = this;
      frm.ShowDialog();
    }

    private void btnDuzelt_Click(object sender, EventArgs e)
    {
      int? id = dataGridViewCari.CurrentRow.Cells[clId.Name].Value.ToString().ParseNullable<int>(x => int.Parse(x));
      string birim = dataGridViewCari.CurrentRow.Cells[clBirim.Name].Value.ToStringOrEmpty();
      frmStokBirim frm = new frmStokBirim(id,birim);
      frm.Owner = this;
      frm.ShowDialog();
    }
  }
}
