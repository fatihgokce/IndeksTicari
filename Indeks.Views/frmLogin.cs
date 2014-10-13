using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Indeks.Data.BusinessObjects;
using Indeks.Data.ManagerObjects;
using System.Threading;
using System.Globalization;
using System.Diagnostics;
using Indeks.Views.Models;
namespace Indeks.Views
{
  public partial class frmLogin : BaseForm
  {
    IManagerFactory mngFac;
    ISubeManager mngSube;
    IKullaniciManager mngUSer;
    //Thread th;
    //BackgroundWorker bw;
    DataBase _dataBase;
    public frmLogin()
    {      
      frmLogin.CheckForIllegalCrossThreadCalls = false;
      CultureInfo ci = new CultureInfo("tr-TR");
      Thread.CurrentThread.CurrentCulture = ci;     
      Thread.CurrentThread.CurrentUICulture =ci;
      ReadRegistry();
      mngFac = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
      mngSube = mngFac.GetSubeManager();
      mngUSer = mngFac.GetKullaniciManager();
      InitializeComponent();
    
      this.Visible = true;
      this.Show();
    
      //ThreadStart ths = new ThreadStart(LoadAsynData);
      //th = new Thread(ths);
      //th.Start();
      backgroundWorker1.RunWorkerAsync();
      LoadAllSube();
     
    }
    void ReadRegistry()
    {
      try
      {
          Settings set = Engine.FindSettings();
          string kurulumTamamlanmadi = "0";
          if (set.Kurulum ==kurulumTamamlanmadi) {
              frmBaslangic frm = new frmBaslangic();
              frm.Owner = this;
              this.Visible = false;
              frm.ShowDialog();
              set = Engine.FindSettings();
              if (set.DataBase == "SqlLite") {
                  string constr = Engine.GetConString();
                  if (string.IsNullOrEmpty(constr.Trim()) || set.Kurulum == kurulumTamamlanmadi) {
                      string str = Engine.GetSqlLiteConString();                   
                      set.ConnectionString = str;
                      set.Kurulum = "1";
                      Engine.SaveSettings(set);
                  }
              } else {
                  string server = Engine.GetConString();
                  if (string.IsNullOrEmpty(server)) {
                      frmKurStp1 frm2 = new frmKurStp1(this);
                      this.Hide();
                      frm2.ShowDialog();
                  }
              }
          } 
      }
      catch (Exception exc)
      {
        LogWrite.Write(exc);
      }
    }
    private void btnIptal_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void btnGiris_Click(object sender, EventArgs e)
    {
      try
      {
          Kullanici kul = mngUSer.GetKullaniciByUserNamePassword(Kullanici.Encryt(txtSifre.Text), txtKulAdi.Text, cmbSube.Text);
          //Kullanici kul = mngUSer.GetKullaniciByUserNamePassword(txtSifre.Text, txtKulAdi.Text, int.Parse(cmbSube.Text));
          if (kul != null) {
              UserInfo.Kullanici = kul;
              UserInfo.Sube = mngSube.GetById(cmbSube.Text, false);
              mngUSer.CloeseSession();
              frmAnaSayfa frm = new frmAnaSayfa();
              frm.Show();
              this.Hide();
          } else {
              MessageBox.Show("Kullanıcı Adı veya şifre yanlış");
          }
        //InitiliazeHanData();
        //Kullanici kul = new Kullanici();
        //kul.Password = "111";
        //kul.Sube = new Sube { Id = 1 };
        //mngUSer.BeginTransaction();
        //mngUSer.Save(kul);
        //mngUSer.CommitTransaction();
        //Kullanici k2 = mngUSer.GetKullaniciByUserNamePassword("123","hasan",1);
        //k2.Sube = new Sube { Id = 499 };
        //mngUSer.BeginTransaction();
        //mngUSer.SaveOrUpdate(k2);
        //mngUSer.CommitTransaction();
        //FinalizeHanData();
      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      }
      //UserInfo.Sube = new Sube { Id = 1 };
      //frmAnaSayfa frm = new frmAnaSayfa();
      //frm.Show();
      //this.Hide();

    }
    void LoadAllSube() {
        try {
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //mngFac = new ManagerFactory(Engine.GetConString(), Engine.GetSqlServerType());
            //mngSube = mngFac.GetSubeManager();
            //mngUSer = mngFac.GetKullaniciManager();
            ProcessDataBase pd = new ProcessDataBase(Engine.GetConString());
            IList<Sube> listSube = pd.SubeListe();
            bool first = true;
            foreach (Sube sube in listSube) {
                cmbSube.Items.Add(sube.Id);
                if (first) {
                    cmbSube.Text = sube.Id;
                    first = false;
                }      
            }



            //List<Sube>liste=  mngSube.GetAll();
            //foreach (Sube sube in liste)
            //    cmbSube.Items.Add(sube.Id);
            //TimeSpan ts = stopwatch.Elapsed;

            //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            //ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

            //txtKulAdi.Text = elapsedTime;
            //stopwatch.Stop();
        } catch (Exception exc) {
            MessageBox.Show(exc.Message);
            LogWrite.Write(exc);
        }
    }
  

    private void frmLogin_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        SendKeys.Send("{TAB}");
      }
    }
    void LoadAsynData() {
        try {
            //Stopwatch stopwatch =new Stopwatch();
            //stopwatch.Start();

            IList<Sube> listSube = mngSube.GetAll();
            mngSube.CloeseSession();
            //foreach (Sube sube in listSube)
            //  cmbSube.Items.Add(sube.Id);
            //ChangePanels();
            //stopwatch.Stop();
            //txtKulAdi.Text = stopwatch.Elapsed.Seconds.ToString();
        } catch (Exception exc) {
            MessageBox.Show(exc.Message);
            LogWrite.Write(exc);
        }
    }
    private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
      LoadAsynData();
    }
  }
}
