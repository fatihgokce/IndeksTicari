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
  public partial class frmKullanici : BaseForm
  {
    IManagerFactory managerFactory;
    IKullaniciManager managerUser;
   
    public frmKullanici()
    {
      InitializeComponent();
    }
    public int? KulNo
    {
      get;set;
    }
    private void frmKullanici_Load(object sender, EventArgs e)
    {
      dataGridView1.AutoGenerateColumns = false;
      managerFactory = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
      managerUser = managerFactory.GetKullaniciManager();
      LoadAllUsers();
    }
   
    void LoadAllUsers()
    {
      try
      {
        List<Kullanici> liste= managerUser.GetList<Kullanici>(x=>x.Sube==UserInfo.Sube);         
        dataGridView1.DataSource = liste;
       
      }
      catch (Exception exc)
      {
        LogWrite.Write(exc);
        MessageBox.Show(exc.Message);
      }
    }
    void Kaydet()
    {
      try
      {
          if (!UserInfo.Kullanici.Adminmi.Value) {
              MessageBox.Show("Sadece admin kullanıcılar kayıt hakkına sahip");
          }
        Kullanici kul = null;
        if (KulNo.HasValue)
          kul = managerUser.GetById(KulNo.Value, true);
        if (kul == null)
          kul = new Kullanici();
        kul.UserName = txtUserName.Text;
        kul.Adminmi = chkAdmin.Checked ? true : false;
        kul.SubelerdeOrtak = chbSubelerdeOrtak.Checked;
        if(!string.IsNullOrEmpty(txtPassword.Text))
          kul.Password =Kullanici.Encryt(txtPassword.Text);
        kul.Sube = UserInfo.Sube;
        managerUser.BeginTransaction();
        managerUser.SaveOrUpdate(kul);
       
        LoadAllUsers();
        YeniKayit();
      }
      catch (Exception exc)
      {
        LogWrite.Write(exc);
        MessageBox.Show(exc.Message);
      } finally {
          try {
              managerUser.CommitTransaction();
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
    void KayitSil() {
        if (!UserInfo.Kullanici.Adminmi.Value) {
            MessageBox.Show("Sadece admin kullanıcılar kayıt silme hakkına sahip");
        }
        DialogResult re = MessageBox.Show("Kayıt Silinsin mi?", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        if (re == DialogResult.Yes) {
            try {

                Kullanici kul = null;
                if (KulNo.HasValue)
                    kul = managerUser.GetById(KulNo.Value, true);
                if (kul == null)
                    return;
                if (kul != null && kul.Adminmi.Value && UserInfo.Kullanici.Id!=1) {
                    MessageBox.Show("Admin kullanıcıyı silemezsiniz");
                    return;
                }
                if (kul != null && kul.Id == UserInfo.Kullanici.Id) {
                    MessageBox.Show("Giriş yapılan kullanıcıyı silemezsiniz");
                    return;
                }
                managerUser.BeginTransaction();
                managerUser.Delete(kul);

                LoadAllUsers();
                YeniKayit();
            } catch (Exception) {

            } finally {
                try {
                    managerUser.CommitTransaction();
                } catch (Exception exc) {
                    MessageBox.Show(exc.Message);
                    LogWrite.Write(exc);
                }
            }
        }
    }
    private void btnSil_Click(object sender, EventArgs e)
    {
      KayitSil();
    }
    private void btnYeni_Click(object sender, EventArgs e)
    {
      YeniKayit();
    }
    void YeniKayit()
    {
      CleareForm.ClearThisConrol(this).BeginClear();
      txtUserName.Focus();
      KulNo = null;
    }
    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
        if (dataGridView1.CurrentRow != null) {
            try {
                if (!IsNullObject(dataGridView1.CurrentRow.Cells["gvClUserNo"].Value))
                    KulNo = int.Parse(dataGridView1.CurrentRow.Cells["gvClUserNo"].Value.ToString());
                if (!IsNullObject(dataGridView1.CurrentRow.Cells["gvClUserName"].Value))
                    txtUserName.Text = dataGridView1.CurrentRow.Cells["gvClUserName"].Value.ToString();
                if (!IsNullObject(dataGridView1.CurrentRow.Cells["gvClAdmin"].Value))
                    chkAdmin.Checked = (bool)dataGridView1.CurrentRow.Cells["gvClAdmin"].Value;
                else
                    chkAdmin.Checked = false;
                if (!IsNullObject(dataGridView1.CurrentRow.Cells[clSubelerdeOrtak.Name].Value))
                    chbSubelerdeOrtak.Checked = (bool)dataGridView1.CurrentRow.Cells[clSubelerdeOrtak.Name].Value;
                else
                    chbSubelerdeOrtak.Checked = false;
                txtUserName.Focus();
            } catch (Exception exc) {
                LogWrite.Write(exc);
                MessageBox.Show(exc.Message);
            }
        }
    }
    private void frmKullanici_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        SendKeys.Send("{TAB}");
      }
      else if (e.KeyCode == Keys.F5)
        Kaydet();
      else if (e.KeyCode == Keys.F7)
        KayitSil();
      else if (e.KeyCode == Keys.F3)
        YeniKayit();        
    }

   
  }
}
