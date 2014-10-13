using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using Indeks.Views.Models;
namespace Indeks.Views
{
  public partial class frmKurStp1 : Form
  {
    frmLogin _frmLogin;
    public frmKurStp1(frmLogin frmLogin)
    {
      InitializeComponent();
      this._frmLogin = frmLogin;
      cmbPaket.DataSource = Enum.GetValues(typeof(IndeksPaket));

    }

    private void btnKaydet_Click(object sender, EventArgs e)
    {
      try
      {
        //Server=FATIH;Initial Catalog=HAN2009;Password=sapass;User ID=sa
        StringBuilder conStr=new StringBuilder();
        conStr.AppendFormat("Server={0};",txtServer.Text);
        conStr.AppendFormat("Initial Catalog={0};",txtDatabase.Text);
        conStr.AppendFormat("Password={0};",txtPassword.Text);
        conStr.AppendFormat("User ID={0}",txtUserID.Text);
        Settings set = new Settings { ConnectionString = conStr.ToString() };
        //Engine.SaveConnectinString(conStr.ToString());
        //set.Paket = (IndeksPaket)Enum.Parse(typeof(IndeksPaket), cmbPaket.Text);
        set.Paket = IndeksPaket.Pro;
        set.Kurulum = "0";
          set.DataBase = "MsSql";
        Engine.SaveSettings(set);
        frmKurStp2 frm = new frmKurStp2(_frmLogin, this,txtDatabase.Text);
        this.Hide();
        frm.ShowDialog(); 
      }
      catch (Exception exc)
      {
        MessageBox.Show(exc.Message);
        LogWrite.Write(exc);
      }
    }

    private void frmKurStp1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        SendKeys.Send("{TAB}");
      }
    }

    private void btnTest_Click(object sender, EventArgs e) {
        try {
            StringBuilder conStr = new StringBuilder();
            conStr.AppendFormat("Server={0};", txtServer.Text);
            conStr.AppendFormat("Initial Catalog={0};", txtDatabase.Text);
            conStr.AppendFormat("Password={0};", txtPassword.Text);
            conStr.AppendFormat("User ID={0}", txtUserID.Text);
            Settings set = new Settings { ConnectionString = conStr.ToString() };
            //set.Paket = (IndeksPaket)Enum.Parse(typeof(IndeksPaket), cmbPaket.Text);
            set.Paket = IndeksPaket.Pro;
            set.DataBase = "MsSql";
            set.Kurulum = "0";
            //Engine.SaveConnectinString(conStr.ToString());
            Engine.SaveSettings(set);
            ProcessDataBase prc = new ProcessDataBase();
            bool test= prc.TestConnection();
            if (test)
                MessageBox.Show("Bağlandı");
            else
                MessageBox.Show("Bağlanamadı");

        } catch (Exception exc) {
            MessageBox.Show(exc.Message);
            LogWrite.Write(exc);
        
        }
    }
  }
}
