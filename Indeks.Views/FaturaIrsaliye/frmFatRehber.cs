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
  public partial class frmFatRehber : Form
  {
    Form _frm;
    FTIRSIP _ftirsip;
    IManagerFactory _mngFac;
    IFatIrsUstManager _mngFatIrsUst;
    ISiparisUstManager _mngSipUst;
    public frmFatRehber(Form form,FTIRSIP ftirsip)
    {
      InitializeComponent();
      _frm = form;
      _ftirsip = ftirsip;
      _mngFac = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
      _mngFatIrsUst = _mngFac.GetFatirsUstManager();
      _mngSipUst = _mngFac.GetSiparisUstManager();
      try
      {
        dataGridView1.AutoGenerateColumns = false;
        if (_frm is frmFatura)
        {          
          dataGridView1.DataSource = _mngFatIrsUst.GetListByFtirsipAndSubeKodu(ftirsip,UserInfo.Sube.Id);
          clTeslimTarih.Visible = false;
          clFatirsNo.HeaderText = "IrsaliyeNo";
          if (ftirsip == FTIRSIP.SatisFat || ftirsip == FTIRSIP.AlisFat || ftirsip == FTIRSIP.DirektSatis) { 
              clSevkTarih.Visible = false;
              clFatirsNo.HeaderText = "FaturaNo";
          }
        }
        else if (_frm is frmSiparis)
        {
          EkranAyarla();
          dataGridView1.DataSource = _mngSipUst.GetListByFtirsipAndSubeKodu(ftirsip,UserInfo.Sube.Id);
          clSevkTarih.Visible = false;
          clFatirsNo.HeaderText = "SiparişNo";
        }
      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      }
    }
    void EkranAyarla()
    {
      gbTarih.Location = gbFatTip.Location;
      gbFatTip.Visible = false;
      gbVadeTarih.Location = new Point(gbVadeTarih.Location.X,gbTarih.Location.Y+gbTarih.Height+2);
    }

    void loadListe(List<FatIrsUst> liste)
    {
      dataGridView1.AutoGenerateColumns = false;
      dataGridView1.DataSource = liste;
    }
    void loadListe(List<SiparisUst> liste)
    {
      dataGridView1.AutoGenerateColumns = false;
      dataGridView1.DataSource = liste;
    }
    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      //if (_frm is frmFatura)
      //{
      //  frmFatura frmFat = (frmFatura)this.Owner;
      //  frmFat.txtFatNo.Text = dataGridView1.CurrentRow.Cells["clFatirsNo"].Value.ToStringOrEmpty();
      //  this.Close();
      //}
    }
    void SearchFatIrsUst()
    {
      try
      {
        if (_frm is frmFatura)
        {
          FatIrsUst fat = new FatIrsUst();
          fat.FatirsNo = txtFatirsNo.Text;
          fat.CariKodu = txtCariKodu.Text;
          FatTipi tip = FatTipi.AcikFat;
          fat.Ftirsip = _ftirsip;
          if (rbIade.Checked)
            tip = FatTipi.IadeFat;
          else if (rbPesin.Checked)
            tip = FatTipi.KapaliFat;
          else if (rbVadeli.Checked)
            tip = FatTipi.AcikFat;
          else
            tip = FatTipi.KrediKarti;
          fat.FatTipi = tip;
          fat.Sube = UserInfo.Sube;
          DateTime? dtTarBas = null, dtTarBit = null, dtVadeBas = null, dtVadeBit = null;
          if ((dtTarBasTar.Value != dtTarBitTar.Value && dtTarBasTar.Value < dtTarBitTar.Value) /*&& (rbIade.Checked || rbPesin.Checked)*/)
          {
            dtTarBas = dtTarBasTar.Value;
            dtTarBit = dtTarBitTar.Value;
          }
          if ((dtVadeBasTar.Value != dtVadeBitTar.Value && dtVadeBasTar.Value < dtVadeBitTar.Value) && (rbVadeli.Checked))
          {
            dtVadeBas = dtVadeBasTar.Value;
            dtVadeBit = dtVadeBitTar.Value;
          }
          List<FatIrsUst> liste = _mngFatIrsUst.GetListByCriter(fat, dtTarBas, dtTarBit, dtVadeBas, dtVadeBit);
          loadListe(liste);
        }
        else if (_frm is frmSiparis)
        {
          SiparisUst fat = new SiparisUst();
          fat.FatirsNo = txtFatirsNo.Text;
          fat.CariKodu = txtCariKodu.Text;
          fat.Ftirsip = _ftirsip;
          fat.Sube = UserInfo.Sube;
          DateTime? dtTarBas = null, dtTarBit = null, dtVadeBas = null, dtVadeBit = null;
          if ((dtTarBasTar.Value != dtTarBitTar.Value && dtTarBasTar.Value < dtTarBitTar.Value) /*&& (rbIade.Checked || rbPesin.Checked)*/)
          {
            dtTarBas = dtTarBasTar.Value;
            dtTarBit = dtTarBitTar.Value;
          }
          if ((dtVadeBasTar.Value != dtVadeBitTar.Value && dtVadeBasTar.Value < dtVadeBitTar.Value) && (rbVadeli.Checked))
          {
            dtVadeBas = dtVadeBasTar.Value;
            dtVadeBit = dtVadeBitTar.Value;
          }
          List<SiparisUst> liste = _mngSipUst.GetListByCriter(fat, dtTarBas, dtTarBit, dtVadeBas, dtVadeBit);
          loadListe(liste);
        }
      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      }
    }
    private void txtStokKodu_TextChanged(object sender, EventArgs e)
    {
      SearchFatIrsUst();
    }

    private void rbVadeli_CheckedChanged(object sender, EventArgs e)
    {
      SearchFatIrsUst();
    }

    private void dtTarBasTar_ValueChanged(object sender, EventArgs e)
    {
      SearchFatIrsUst();
    }

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (_frm is frmFatura)
      {
        frmFatura frmFat = (frmFatura)this.Owner;
        frmFat.txtFatNo.Text = dataGridView1.CurrentRow.Cells["clFatirsNo"].Value.ToStringOrEmpty();
        frmFat.txtFatNo.Focus();
        this.Close();
      }
      else if (_frm is frmSiparis)
      {
        frmSiparis frmFat = (frmSiparis)this.Owner;
        frmFat.txtFatNo.Text = dataGridView1.CurrentRow.Cells["clFatirsNo"].Value.ToStringOrEmpty();
        frmFat.txtFatNo.Focus();
        this.Close();
      }
    }

    private void stokListesiToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmStokListe frm = new frmStokListe(_ftirsip,dataGridView1.CurrentRow.Cells[clFatirsNo.Name].Value.ToStringOrEmpty());
      frm.ShowDialog();
    }
  }
}
