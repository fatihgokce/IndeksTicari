using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using Indeks.Data.Base;
using Indeks.Data.BusinessObjects;
using Indeks.Data.ManagerObjects;
namespace Indeks.Views
{
  public partial class frmDizaynKalem : BaseForm
  {
    int _genelNo;
    IManagerFactory mng;
    IDizaynKalemManager mngDizaynKalem;
    int? _selectedDizaynKalem=null; 
    public frmDizaynKalem(int genelNo)
    {
      InitializeComponent();
      _genelNo = genelNo;
      mng = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
      mngDizaynKalem = mng.GetDizaynKalemManager();
      LoadKalemList();
    }
    void LoadKalemList()
    {
      try
      {
        dataGridView1.AutoGenerateColumns = false;
        dataGridView1.DataSource = mngDizaynKalem.GetByDizaynGenelNo(_genelNo);
      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      }
    }
    private void chkBaslik_CheckedChanged(object sender, EventArgs e)
    {
      if (chkBaslik.Checked)
      {
        txtAciklama.Enabled = true;
      }
      else
      {
        txtAciklama.Text = "";
        txtAciklama.Enabled = false;
      }
    }
    void Kaydet()
    {
      try
      {
        DizaynKalem kal = null;
        if(_selectedDizaynKalem!=null)
          kal = mngDizaynKalem.GetById(_selectedDizaynKalem.Value,false);
        if (kal == null)
          kal = new DizaynKalem();
        //1-Ust
        //2-Alt
        //3-Kalem
        string sahaYeri = "";
        if (cmbSahaYeri.SelectedIndex == 0)
          sahaYeri = "1";
        else if (cmbSahaYeri.SelectedIndex == 1)
          sahaYeri = "2";
        else
          sahaYeri = "3";
        kal.SahaYeri = sahaYeri;
        kal.AlanIsim = cmbAlanIsim.Text;
        kal.BaslikYaz = chkBaslik.Checked;
        kal.Aciklama = txtAciklama.Text;
        kal.Satir = txtSatir.Text.ParseStruct<byte>(x => byte.Parse(x));
        kal.Sutun = txtSutun.Text.ParseStruct<byte>(x=>byte.Parse(x));
        kal.Uzunluk = txtUzunluk.Text.ParseNullable<byte>(x => byte.Parse(x));
        kal.Ondalik = txtOndalik.Text.ParseNullable<byte>(x=>byte.Parse(x));
        kal.DizaynGenel = new DizaynGenel { Id = _genelNo };
        mngDizaynKalem.BeginTransaction();
        mngDizaynKalem.SaveOrUpdate(kal);
       
        YeniKalem();
        LoadKalemList();
      }
      catch (Exception)
      { } finally {
          try {
              mngDizaynKalem.CommitTransaction();
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

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      try
      {

        DataGridViewRow dgr = dataGridView1.CurrentRow;
        if (dgr != null) {
            string sahayeri = dgr.Cells["clSahaYeri"].Value.ToStringOrEmpty();
            const string ust = "1";
            const string alt = "2";

            if (sahayeri == ust)
                cmbSahaYeri.SelectedIndex = 0;
            else if (sahayeri == alt)
                cmbSahaYeri.SelectedIndex = 1;
            else
                cmbSahaYeri.SelectedIndex = 2;
            cmbAlanIsim.Text = dgr.Cells["clAlanIsim"].Value.ToStringOrEmpty();
            if (!IsNullObject(dataGridView1.CurrentRow.Cells["clBaslikYaz"].Value))
                chkBaslik.Checked = (bool)dataGridView1.CurrentRow.Cells["clBaslikYaz"].Value;
            else
                chkBaslik.Checked = false;
            txtAciklama.Text = dgr.Cells["clAciklama"].Value.ToStringOrEmpty();
            txtSatir.Text = dgr.Cells["clSatir"].Value.ToStringOrEmpty();
            txtSutun.Text = dgr.Cells["clSutun"].Value.ToStringOrEmpty();
            txtUzunluk.Text = dgr.Cells["clUzunluk"].Value.ToStringOrEmpty();
            txtOndalik.Text = dgr.Cells["clOndalik"].Value.ToStringOrEmpty();
            _selectedDizaynKalem = dgr.Cells["clId"].Value.ToString().ParseNullable<int>(x => int.Parse(x));
            cmbSahaYeri.Focus();
        }
      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      }
    }
    void YeniKalem()
    {
      CleareForm.ClearThisConrol(groupBox1).BeginClear();
      cmbAlanIsim.SelectedIndex = 0;
      cmbSahaYeri.SelectedIndex = 0;
      txtOndalik.Text="0";
      txtUzunluk.Text = "0";
      txtAciklama.Enabled = false;
      txtAciklama.Text = "";
      chkBaslik.Checked = false;
      cmbSahaYeri.Focus();
      _selectedDizaynKalem = null;
    }
    void KalemSil()
    {
      try
      {
        DialogResult re = MessageBox.Show("Kayıt Silinsin mi?", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        if (re == DialogResult.Yes)
        {
          if (_selectedDizaynKalem != null)
          {
            DizaynKalem kal = mngDizaynKalem.GetById(_selectedDizaynKalem.Value,false);
            mngDizaynKalem.BeginTransaction();
            mngDizaynKalem.Delete(kal);
          
            YeniKalem();
            LoadKalemList();
          }
        }
      }
      catch (Exception)
      {} finally {
          try {
              mngDizaynKalem.CommitTransaction();
          } catch (Exception exc) {
              MessageBox.Show(exc.Message);
              LogWrite.Write(exc);
          }
      }
    }
    private void frmDizaynKalem_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        SendKeys.Send("{TAB}");
      }
      else if (Keys.F5 == e.KeyCode)
        Kaydet();
      else if (e.KeyCode == Keys.F7)
        KalemSil();
      else if (e.KeyCode == Keys.F3)
        YeniKalem();
    }

    private void cmbSahaYeri_SelectedIndexChanged(object sender, EventArgs e)
    {
//Aciklama
//FaturaNo
//FaturaTarih
//FaturaSaat
//IrsaliyeNo
//SevkTarih
//SevkSaat
//CariAdSoyad
//CariAdres
//CariKod
//VergiDairesi
//VergiNumarasi
//CariTelefon
//CariBakiye
//StokKodu
//StokIsim
//Kdv
//Adet
//BirimFiyat
//Tutar
//Yalniz
//IndirimToplam
//FaturaToplam
//KdvToplam
//GenelToplam
//VadeTarih
//Barkod


      cmbAlanIsim.Items.Clear();
      if (cmbSahaYeri.SelectedIndex == 0)
      {
        cmbAlanIsim.Items.AddRange(new string[] { "Aciklama", "FaturaNo", "FaturaTarih", "FaturaSaat", "IrsaliyeNo", "SevkTarih", "SevkSaat", "CariAdSoyad", "CariAdres", "CariKod", "VergiDairesi", "VergiNumarasi", "CariTelefon", "CariBakiye" });
      }
      else if (cmbSahaYeri.SelectedIndex == 1)
      {
        cmbAlanIsim.Items.AddRange(new string[] { "Aciklama", "Yalniz", "IndirimToplam", "FaturaToplam", "KdvToplam", "GenelToplam", "VadeTarih" });
       
      }
      else
      {
        cmbAlanIsim.Items.AddRange(new string[] { "StokKodu", "StokIsim", "Kdv", "Adet", "BirimFiyat", "Tutar","Birim","Barkod" });
      }
      cmbAlanIsim.SelectedIndex = 0;

    }
    private void btnSil_Click(object sender, EventArgs e)
    {
      KalemSil();
    }

    private void btnYeni_Click(object sender, EventArgs e)
    {
      YeniKalem();
    }  
  }
}
