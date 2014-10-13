using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace Indeks.Views
{
  public class ManagerIl
  {
    public List<string> IlListe(string il)
    {
      string path = Path.Combine(Application.StartupPath, @"iller\iller.mdb");
      OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+path+"");
      con.Open();
      OleDbCommand cmd = new OleDbCommand("select sehir from sehir where sehir like '"+il+"%'",con);      
      OleDbDataReader rd = cmd.ExecuteReader();
      List<string> liste = new List<string>();
      while (rd.Read())
        liste.Add(rd[0].ToStringOrEmpty());
      con.Close();
      return liste;
    }
    public int SehirId(string il)
    {
      string path = Path.Combine(Application.StartupPath, @"iller\iller.mdb");
      OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + "");
      con.Open();
      OleDbCommand cmd = new OleDbCommand("select id from sehir where sehir='"+il+"'", con);
      object obj = cmd.ExecuteScalar();
      int i=0;
      if(obj!=null)
        i=int.Parse(obj.ToString());
      con.Close();
      return i;
    }
    public List<string> IlceListe(string ilce,int ilId)
    {
      string path = Path.Combine(Application.StartupPath, @"iller\iller.mdb");
      OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + "");
      con.Open();
      OleDbCommand cmd = new OleDbCommand("select c.ilce from ilceler c where c.sehir="+ilId+" and c.ilce like '" + ilce + "%'", con);
      OleDbDataReader rd = cmd.ExecuteReader();
      List<string> liste = new List<string>();
      while (rd.Read())
        liste.Add(rd[0].ToStringOrEmpty());
      con.Close();
      return liste;
    }
  }
}
