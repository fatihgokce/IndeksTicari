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
  public partial class frmSube : BaseForm
  {
    IManagerFactory managerFactory;
    ISubeManager managerSube;
    public frmSube():base()
    {
      InitializeComponent();     
    }    
    private void frmSube_Load(object sender, EventArgs e)
    {
      dataGridView1.AutoGenerateColumns = false;
      managerFactory = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
      managerSube = managerFactory.GetSubeManager();
      LoadAllSube();    
    }
    void LoadAllSube()
    {
     
      try
      {
        IList<Sube> listSube = managerSube.GetAll();       
        dataGridView1.DataSource = listSube;        
      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      }
    }

    private void frmSube_FormClosed(object sender, FormClosedEventArgs e)
    {
      //FinalizeHanData();
    }
    void AssignSubeValue(Sube sube)
    {
      sube.SubeIsmi = txtSubeIsmi.Text;
      sube.Adres = txtAdres.Text;
      sube.VergiNo = txtVergiNo.Text;
      sube.VergiDairesi = txtVergiDairesi.Text;
      sube.Aktif = chkAktif.Checked ? true : false;
      sube.Merkezmi = chkMerkez.Checked ? true : false;
    }
    private void btnKaydet_Click(object sender, EventArgs e)
    {
      Kaydet();
    }
    void Kaydet()
    {
      Sube sube=new Sube() ;
      //AssignSubeValue(sube);
      try
      {
        sube = managerSube.GetById(txtSubeKodu.Text, false);
        if (sube == null)
          sube = new Sube();
        AssignSubeValue(sube);
        sube.Id = txtSubeKodu.Text;
        BeginTransaction();
        managerSube.SaveOrUpdate(sube);
       
        LoadAllSube();
        YeniKayit();
      }
      catch (Exception)
      {  
      } finally {
          try {
              CommitTransaction();
          } catch (Exception exc) {
              LogWrite.Write(exc);
              MessageBox.Show(exc.Message);
          }
      }
    }
    private void btnYeni_Click(object sender, EventArgs e)
    {
      YeniKayit();
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
        if (dataGridView1.CurrentRow != null) {
            ClearFormData(this);
            if (!IsNullObject(dataGridView1.CurrentRow.Cells["gvClSubeKodu"].Value))
                txtSubeKodu.Text = dataGridView1.CurrentRow.Cells["gvClSubeKodu"].Value.ToString();
            if (!IsNullObject(dataGridView1.CurrentRow.Cells["gvClSubeIsmi"].Value))
                txtSubeIsmi.Text = dataGridView1.CurrentRow.Cells["gvClSubeIsmi"].Value.ToString();
            if (!IsNullObject(dataGridView1.CurrentRow.Cells["gvClVergiDairesi"].Value))
                txtVergiDairesi.Text = dataGridView1.CurrentRow.Cells["gvClVergiDairesi"].Value.ToString();
            if (!IsNullObject(dataGridView1.CurrentRow.Cells["gvClVergiNo"].Value))
                txtVergiNo.Text = dataGridView1.CurrentRow.Cells["gvClVergiNo"].Value.ToString();
            if (!IsNullObject(dataGridView1.CurrentRow.Cells["gvClAdres"].Value))
                txtAdres.Text = dataGridView1.CurrentRow.Cells["gvClAdres"].Value.ToString();
            if (!IsNullObject(dataGridView1.CurrentRow.Cells["gvClMerkez"].Value))
                chkMerkez.Checked = (bool)dataGridView1.CurrentRow.Cells["gvClMerkez"].Value;
            else
                chkMerkez.Checked = false;
            if (!IsNullObject(dataGridView1.CurrentRow.Cells["gvClAktif"].Value))
                chkAktif.Checked = (bool)dataGridView1.CurrentRow.Cells["gvClAktif"].Value;
            else
                chkAktif.Checked = false;

        }
    }
    void KayitSil()
    {
         DialogResult re = MessageBox.Show("Kayıt Silinsin mi?", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
         if (re == DialogResult.Yes) {
             try {

                 Sube sube = managerSube.GetById(txtSubeKodu.Text, true);
                 if (!UserInfo.Kullanici.Adminmi.Value) {
                     MessageBox.Show("Sadece admin kullanıcı şube silebilir");
                     return;
                 }
                 if (sube != null && UserInfo.Sube.Id == sube.Id) {
                     MessageBox.Show("Bulunduğunuz şubeyi silemezsiniz");
                     return;
                 }
                 managerSube.BeginTransaction();
                 managerSube.Delete(sube);
                 LoadAllSube();
                 btnYeni_Click(this, EventArgs.Empty);
             } catch (Exception exc) {
                 MessageBox.Show(exc.Message);
                 LogWrite.Write(exc);
             } finally {
                 try {
                     managerSube.CommitChanges();
                 } catch (Exception exc) {
                     LogWrite.Write(exc);
                     MessageBox.Show(exc.Message);
                 }
             }
         }
    }
    private void btnSil_Click(object sender, EventArgs e)
    {
      KayitSil();
    }
    void YeniKayit()
    {
      ClearFormData(this);
      txtSubeKodu.Focus();
    }
    private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
    {
      btnKaydet_Click(this,EventArgs.Empty);
    }

    private void duzeltToolStripMenuItem_Click(object sender, EventArgs e)
    {
      btnDuzelt_Click(this, EventArgs.Empty);
    }

    private void silToolStripMenuItem_Click(object sender, EventArgs e)
    {
      btnSil_Click(this, EventArgs.Empty);
    }

    private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
    {
      btnYeni_Click(this, EventArgs.Empty);
    }

    private void btnDuzelt_Click(object sender, EventArgs e)
    {
      try
      {
        Sube sube = managerSube.GetById(txtSubeKodu.Text,true);
        AssignSubeValue(sube);
        managerSube.SaveOrUpdate(sube);
        managerSube.CommitChanges();
        LoadAllSube();

      }
      catch (Exception exc)
      {
        LogWrite.Write(exc);
        MessageBox.Show(exc.Message);
      }
    }

    private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void frmSube_KeyDown(object sender, KeyEventArgs e)
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
        KayitSil();
      }
      else if (e.KeyCode == Keys.F3)
      {
        YeniKayit();
      }
    } 
  }
}
