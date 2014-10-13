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
  public partial class frmKasaTanimlama : BaseForm
  {
    IManagerFactory mngFct;
    IKasaManager mngKasa;
    public frmKasaTanimlama()
    {
      InitializeComponent();
      mngFct = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
      mngKasa = mngFct.GetKasaManager();
      
      txtKasaKodu.DataSource =delegate
      {
        try
        {
          return mngKasa.GetKasaKodsBySubeKodu(UserInfo.Sube.Id,txtKasaKodu.Text);
        }
        catch (Exception exc)
        {
          LogWrite.Write(exc);
          MessageBox.Show(exc.Message);
        }
        return null;
      }; 
      dataGridView1.AutoGenerateColumns = false;
      LoadGrid();
     
    }
    void LoadGrid()
    {
      try
      {
        dataGridView1.DataSource = mngKasa.GetKasaBySubeKodu(UserInfo.Sube.Id);
      }
      catch (Exception exc)
      {
        LogWrite.Write(exc);
        MessageBox.Show(exc.Message);
      }
    }

    private void txtKasaKodu_KeyUp(object sender, KeyEventArgs e)
    {
        try {
            if (!string.IsNullOrEmpty(txtKasaKodu.Text) && e.KeyCode == Keys.Tab) {
                Kasa kasa = mngKasa.GetById(txtKasaKodu.Text, false);
                if (kasa != null) {
                    txtKasaIsmi.Text = kasa.KasaIsmi;
                    txtSonDevirTutar.Text = kasa.SonDevirTutar.FromNullableToString();
                    dateTimePicker1.Text = kasa.SonDevirTarih.FromNullableToString();
                }
                txtKasaIsmi.Focus();
            }
        } catch (Exception exc) {
            LogWrite.Write(exc);
            MessageBox.Show(exc.Message);
        }
    }

    private void frmKasaTanimlama_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        SendKeys.Send("{TAB}");
      }
      else if (Keys.F5 == e.KeyCode)
      {
        Kaydet();
      }
      else if (Keys.F7 == e.KeyCode)
        KayitSil();
      else if (Keys.F3 == e.KeyCode)
        YeniKayit(); 
    }
    void YeniKayit()
    {
      CleareForm.ClearThisConrol(groupBox1)
                .BeginClear();
      txtKasaKodu.Enabled = true;
      txtKasaKodu.Focus();
    }
    void KayitSil() {
        DialogResult re = MessageBox.Show("Kayıt Silinsin mi?", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        if (re == DialogResult.Yes) {
            try {

                Kasa kasa = mngKasa.GetById(txtKasaKodu.Text, true);
                mngKasa.BeginTransaction();
                mngKasa.Delete(kasa);
                LoadGrid();
                YeniKayit();

            } catch (Exception exc) {
                LogWrite.Write(exc);
                MessageBox.Show(exc.Message);
            } finally {
                try {
                    mngKasa.CommitTransaction();
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
        Kasa kasa = mngKasa.GetById(txtKasaKodu.Text, false);
        if (kasa == null)
          kasa = new Kasa();
        kasa.Id = txtKasaKodu.Text;
        kasa.KasaIsmi = txtKasaIsmi.Text;
        kasa.SonDevirTarih = dateTimePicker1.Value.JustDate();
        kasa.SonDevirTutar = txtSonDevirTutar.Text.ParseNullable<double>(x => double.Parse(x));
        kasa.KayitTarih = DateTime.Now;
        kasa.Sube = UserInfo.Sube;
        mngKasa.BeginTransaction();
        mngKasa.SaveOrUpdate(kasa);
     
        YeniKayit();
        LoadGrid();
      }
      catch (Exception)
      {

      } finally {
          try {
              mngKasa.CommitTransaction();
          } catch (Exception exc) {
              MessageBox.Show(exc.Message);
              LogWrite.Write(exc);
          }
      }
    }

    private void btnKaydet_Click(object sender, EventArgs e)
    {
      Kaydet();
    }

    private void btnSil_Click(object sender, EventArgs e)
    {
      KayitSil();
    }

    private void btnYeni_Click(object sender, EventArgs e)
    {
      YeniKayit();
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
        try {
            if (dataGridView1.CurrentRow != null) {
                YeniKayit();

                txtKasaKodu.Text = dataGridView1.CurrentRow.Cells["clKasaKod"].Value.ToStringOrEmpty();
                txtKasaIsmi.Text = dataGridView1.CurrentRow.Cells["clKasaIsmi"].Value.ToStringOrEmpty();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["clSonDevirTarih"].Value.ToStringOrEmpty();
                txtSonDevirTutar.Text = dataGridView1.CurrentRow.Cells["clSonDevirTutar"].Value.ToStringOrEmpty();
                txtKasaKodu.Enabled = false;
                txtKasaIsmi.Focus();
            }
        } catch (Exception exc) {
            LogWrite.Write(exc); MessageBox.Show(exc.Message);
        }
    }

    private void frmKasaTanimlama_FormClosing(object sender, FormClosingEventArgs e) {
        txtKasaKodu.CloseAutoComplete();
    }
  }
}
