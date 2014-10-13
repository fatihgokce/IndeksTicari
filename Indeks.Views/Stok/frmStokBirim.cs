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
  public partial class frmStokBirim : BaseForm
  {
    int? _birimId = null;
    string _birim;
    IManagerFactory mngFac;
    IStokBirimManager mngStBirim;
    public frmStokBirim()
    {
      InitializeComponent();
      InitializeData();
    }
    public frmStokBirim(int?birimId,string birim)
    {
      InitializeComponent();
      _birimId = birimId;
      _birim = birim;
      txtAnaBirim.Text = _birim;
      InitializeData();
    }
    void InitializeData()
    {
        mngFac = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
      mngStBirim = mngFac.GetStokBirimManager();
    }
    void InitializeForm()
    {
      txtAnaBirim.Text = "";
      _birimId = null;
      _birim = "";
    }
    private void frmStokBirim_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.F5) {
            Kaydet();
        } else if (e.KeyCode == Keys.F3)
            InitializeForm();
        else if (e.KeyCode == Keys.Escape)
            this.Close();
    }
    void Kaydet()
    {
      try
      {
        StokBirim sbirim = null;
        if (_birimId != null)
        {
          sbirim = mngStBirim.GetById(_birimId.Value, false);
          mngStBirim.TopluHareketBirimDegistir(txtAnaBirim.Text,sbirim.Birim);
        }
        if (sbirim == null)
          sbirim = new StokBirim();
        sbirim.Birim = txtAnaBirim.Text.Trim();
        mngStBirim.BeginTransaction();
        mngStBirim.SaveOrUpdate(sbirim);
      
        if (this.Owner is frmStokBirimListe)
        {
          frmStokBirimListe frm = (frmStokBirimListe)this.Owner;
          frm.LoadGrid();
          this.Close();
        }
        InitializeForm();

      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      } finally {
          try {
              mngStBirim.CommitTransaction();
          } catch (Exception exc) {
              MessageBox.Show(exc.Message);
              LogWrite.Write(exc);
          }
      }
    }

    private void tsbtnKaydet_Click(object sender, EventArgs e) {
        Kaydet();
    }

    private void tsbtnYeniKayit_Click(object sender, EventArgs e) {
        InitializeForm();
    }

    private void tsbtnKapat_Click(object sender, EventArgs e) {
        this.Close();
    }
  }
}
