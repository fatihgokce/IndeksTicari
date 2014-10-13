using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Indeks.Views.Models;
namespace Indeks.Views
{
  public partial class frmKurStp2 : Form
  {
    frmLogin _frmLogin;
    Thread th;
    frmKurStp1 _frmKurStep1;
    string dataBasePath = string.Empty;
    string _database=string.Empty;
    public frmKurStp2(frmLogin frmLogin, frmKurStp1 frmKurStep1,string database)
    {
      InitializeComponent();
      this._frmLogin = frmLogin;
      frmLogin.CheckForIllegalCrossThreadCalls = false;
      _database = database;
      _frmKurStep1 = frmKurStep1;
    }
    void ChangeGroupBox()
    {
      grboxSqlKurulumu.Visible = true;
      grboxClientServer.Visible = false;
      Point tmpP = grboxClientServer.Location;
      grboxClientServer.Location = grboxSqlKurulumu.Location;
      grboxSqlKurulumu.Location = tmpP;

    }
    private void btnDevam_Click(object sender, EventArgs e)
    {
      if (rbtnClient.Checked)
      {
        _frmLogin.Show();
        _frmKurStep1.Close();
        this.Close();
      }
      else if (rbtnServer.Checked)
      {
        ChangeGroupBox();
        this.Text = "Step3";

      }
    }

    private void btnKur_Click(object sender, EventArgs e)
    {
      folderBrowserDialog1.Description = "Database in kurlulacağı dizin";
     
      DialogResult res = folderBrowserDialog1.ShowDialog();
      if (res == DialogResult.OK)
      {
        dataBasePath = folderBrowserDialog1.SelectedPath;
      }
      btnKur.Enabled = false;
      ThreadStart ths = new ThreadStart(ConstructDataBase);
      th = new Thread(ths);
      th.Start();    
    }
    void ConstructDataBase()
    {
      try
      {
        string pathScript = Path.Combine(Application.StartupPath, @"script/scripts.txt");
        StreamReader sr = new StreamReader(pathScript);
        string sqlScripts = sr.ReadToEnd();
        sr.Close();        

        string database =_database;
        sqlScripts = sqlScripts.Replace("#DataBaseName#", database);
        string pathMdf = dataBasePath;
        string pathLdf = pathMdf;
        pathMdf = Path.Combine(dataBasePath, database + ".mdf");
        pathLdf = Path.Combine(dataBasePath, database + "_log.ldf");
        sqlScripts = sqlScripts.Replace("#PathMdf#", pathMdf);
        sqlScripts = sqlScripts.Replace("#PathLdf#", pathLdf);
        sqlScripts = sqlScripts.Replace("HAN_log", database + "_log");
        ProcessDataBase pData = new ProcessDataBase();
        pData.ExecuteNonQueries(sqlScripts, textBox1);
        btnKapat.Enabled = true;
        Settings set = Engine.FindSettings();
        set.Kurulum = "1";
        Engine.SaveSettings(set);
      }
      catch (Exception exc)
      {
        LogWrite.Write(exc);
        MessageBox.Show(exc.Message);
      }
    }

    private void btnKapat_Click(object sender, EventArgs e)
    {
      _frmLogin.Show();
      _frmKurStep1.Close();
      this.Close();
    }
  }
}
