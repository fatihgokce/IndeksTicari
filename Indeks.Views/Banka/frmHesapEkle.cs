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
using System.Linq;
namespace Indeks.Views
{
  public partial class frmHesapEkle : BaseForm
  {
    IBankaHesapManager mngBankaHesap;
    int? selectedBankaHesapId = null;
    IBankaManager mngBanka;
    public frmHesapEkle()
    {
      InitializeComponent();
      dataGridView1.AutoGenerateColumns = false;
      txtHesapNo.Focus();
      IManagerFactory mng = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
      mngBankaHesap = mng.GetBankaHesapManager();
      mngBanka = mng.GetBankaManager();
      LoadGrid();
      LoadBanka();
    }
    void LoadBanka() {
        try {
            cmbBankaListe.DataSource = mngBanka.GetAll().Select(x => x.BankaIsim).ToList();
        } catch (Exception exc) {
            MessageBox.Show(exc.Message);
            LogWrite.Write(exc);
        }
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
    void KayitSil()
    {
      try
      {
        DialogResult re = MessageBox.Show("Kayıt Silinsin mi?", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        if (re == DialogResult.Yes)
        {
          if (selectedBankaHesapId != null)
          {
            BankaHesap bh = mngBankaHesap.GetById(selectedBankaHesapId.Value, false);
            BeginTransaction();
            mngBankaHesap.Delete(bh);
            CommitTransaction();            
            YeniKayit();
            LoadGrid();
          }
        }
      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      }
    }
    void Kaydet()
    {
        if (string.IsNullOrEmpty(txtHesapNo.Text)) {
            MessageBox.Show("hesap numarası giriniz");
            txtHesapNo.Focus();
            return;
        }
      try
      {
        BankaHesap hesap = null;
        if (selectedBankaHesapId != null)
          hesap = mngBankaHesap.GetById(selectedBankaHesapId.Value, false);
        if (hesap == null)
        {
          hesap = new BankaHesap();
          BankaHesap bh = mngBankaHesap.GetByHesapNo(UserInfo.Sube.Id, txtHesapNo.Text.Trim());
          if (bh != null)
          {
            MessageBox.Show(txtHesapNo.Text+ " nolu hesap var");
            return;
          }
        }
        hesap.BankaAdi = cmbBankaListe.Text.Trim();
        hesap.HesapNo = txtHesapNo.Text.Trim();
        hesap.HesapSahibi = txtHesapSahip.Text.Trim();
        hesap.ParaBirimi = cmbParaBirimi.Text.Trim();
        hesap.Sube = UserInfo.Sube;
        hesap.SubeAdi = txtSubeAdi.Text.Trim();
        mngBankaHesap.BeginTransaction();
        mngBankaHesap.SaveOrUpdate(hesap);
        mngBankaHesap.CommitTransaction();
        if (this.Owner is frmDirektSatisKrediKarti)
        {
          frmDirektSatisKrediKarti frm = (frmDirektSatisKrediKarti)this.Owner;
          frm.txtBankaHesapNo.Text = hesap.HesapNo;
          this.Close();
        }
        YeniKayit();
        LoadGrid();
      }
      catch (Exception exc)
      {
        LogWrite.Write(exc);
        MessageBox.Show(exc.Message);
      }
    }
    private void tsbtnKaydet_Click(object sender, EventArgs e)
    {
      Kaydet();
    }
    void YeniKayit()
    {
      CleareForm.ClearThisConrol(this).BeginClear();
      selectedBankaHesapId = null;
      txtHesapNo.Focus();
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      try
      {
        txtHesapNo.Text= dataGridView1.CurrentRow.Cells["clHesapNo"].Value.ToStringOrEmpty().Trim();
        cmbBankaListe.Text = dataGridView1.CurrentRow.Cells["clBankaAdi"].Value.ToStringOrEmpty().Trim();
        txtHesapSahip.Text = dataGridView1.CurrentRow.Cells["clHesapSahibi"].Value.ToStringOrEmpty().Trim();
        txtSubeAdi.Text = dataGridView1.CurrentRow.Cells["clSubeAdi"].Value.ToStringOrEmpty().Trim();
        cmbParaBirimi.Text = dataGridView1.CurrentRow.Cells["clParaBirimi"].Value.ToStringOrEmpty().Trim();
       
        selectedBankaHesapId = dataGridView1.CurrentRow.Cells["clId"].Value.ToString().ParseNullable<int>(x => int.Parse(x));
       
        txtHesapNo.Focus();
       
      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      }
    }

    private void frmHesapEkle_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        SendKeys.Send("{TAB}");
      }
      else if (Keys.F5 == e.KeyCode)
        Kaydet();
      else if (Keys.F7 == e.KeyCode)
        KayitSil();
      else if (Keys.F3 == e.KeyCode)
        YeniKayit();
      else if (Keys.Escape == e.KeyCode)
          this.Close();
    }

    private void tsbtnSil_Click(object sender, EventArgs e)
    {
      KayitSil();
    }

    private void tsbtnYeni_Click(object sender, EventArgs e)
    {
      YeniKayit();
    }

    private void toolStripButton1_Click(object sender, EventArgs e) {
        this.Close();
    }
  }
}
