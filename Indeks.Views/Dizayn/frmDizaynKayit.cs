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
  public partial class frmDizaynKayit : BaseForm
  {
    IManagerFactory mng;
    IDizaynManager mngDizayn;
    int? _selectedDizayn = null;
    public frmDizaynKayit()
    {
      InitializeComponent();
      mng = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
      mngDizayn = mng.GetDizaynManager();
      LoadGrid();
      cmboxDizaynTipi.SelectedIndex = 0;
     
    }
    void LoadGrid()
    {
      try
      {
        dataGridView1.AutoGenerateColumns = false;
        dataGridView1.DataSource = mngDizayn.GetAll();
      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      }
    }

    private void frmDizaynKayit_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        SendKeys.Send("{TAB}");
      }
      else if (e.KeyCode == Keys.F5)
      {
        Kaydet();
      }
      else if (e.KeyCode == Keys.F7)
      {
        Sil();
      }
      else if (e.KeyCode == Keys.F3)
        YeniKalem();

    }
    void Sil() {
        DialogResult re = MessageBox.Show("Kayıt Silinsin mi?", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        if (re == DialogResult.Yes) {
            try {

                if (_selectedDizayn != null) {
                    Dizayn d = mngDizayn.GetById(_selectedDizayn.Value, false);
                    mngDizayn.BeginTransaction();
                    mngDizayn.Delete(d);

                    YeniKalem();
                }

            } catch (Exception exc) {
                MessageBox.Show(exc.Message);
                LogWrite.Write(exc);
            } finally {
                try {
                    mngDizayn.CommitTransaction();
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                    LogWrite.Write(exc);
                }
            }
        }
    }

    void Kaydet()
    {
      try
      {
        Dizayn dizayn = null;
        if (_selectedDizayn != null)
          dizayn = mngDizayn.GetById(_selectedDizayn.Value, false);
        else
          dizayn = new Dizayn();
        dizayn.DizaynAdi = txtDizaynAdi.Text;
        dizayn.DizaynTipi = cmboxDizaynTipi.SelectedIndex == 0 ? DizaynTipi.SatisFatura : DizaynTipi.SatisIrsaliye;
        dizayn.Sube = UserInfo.Sube;
        mngDizayn.BeginTransaction();
        mngDizayn.SaveOrUpdate(dizayn);
       
        LoadGrid();
        YeniKalem();
          

      }
      catch (Exception )
      { } finally {
          try {
              mngDizayn.CommitTransaction();
          } catch (Exception exc) {
              MessageBox.Show(exc.Message);
              LogWrite.Write(exc);
          }
      }
    }

    private void btnNext_Click(object sender, EventArgs e) {
        try {
            frmDizaynGenel frm = new frmDizaynGenel(_selectedDizayn.Value);
            frm.Show();
            this.Close();
        } catch (Exception exc) {
            MessageBox.Show(exc.Message);
            LogWrite.Write(exc);
        }
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
        if (dataGridView1.CurrentRow != null) {
            try {
                txtDizaynAdi.Text = dataGridView1.CurrentRow.Cells["clDizaynAdi"].Value.ToStringOrEmpty();

                cmboxDizaynTipi.Text = dataGridView1.CurrentRow.Cells["clDizaynTipi"].Value.ToStringOrEmpty() == "SatisFatura" ? "1-SatışFaturası" : "2-SatışIrsaliyesi";
                _selectedDizayn = dataGridView1.CurrentRow.Cells["clId"].Value.ToString().ParseNullable<int>(x => int.Parse(x));
                btnNext.Enabled = true;
            } catch (Exception exc) {
                LogWrite.Write(exc);
                MessageBox.Show(exc.Message);
            }
        }
    }

    private void btnKaydet_Click(object sender, EventArgs e)
    {
      Kaydet();
    }
    void YeniKalem()
    {
      CleareForm.ClearThisConrol(groupBox1)      
                       .BeginClear();
      cmboxDizaynTipi.SelectedIndex = 0;
     
      _selectedDizayn = null;
      btnNext.Enabled = false;
    }

    private void btnSil_Click(object sender, EventArgs e)
    {
      Sil();
    }

    private void btnYeni_Click(object sender, EventArgs e)
    {
      YeniKalem();
    }
  }
}
