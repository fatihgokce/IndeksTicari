using System;
using System.Collections.Generic;

using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using Indeks.Data.BusinessObjects;
using Indeks.Data.Base;
using System.Data.Common;
using System.Data.SQLite;
namespace Indeks.Views
{
  public class ProcessDataBase
  {
    private readonly string ConString;
    public ProcessDataBase() {

        //reg.Write("Server", txtServer.Text);
        //reg.Write("DataBase", txtDatabase.Text);
        //reg.Write("UserId", txtUserID.Text);
        //reg.Write("Password", txtPassword.Text);
        //Data Source=GOKCE;Initial Catalog=HanMhs;Password=sapass;User ID=sa      
        ConString = Engine.GetConString();
        if (Engine.GetSqlServerType() == SqlServerType.SQL2005) {
            string[] ary = ConString.Split(';');
            ConString = "";
            ConString += ary[0] + ";";
            ConString += "Initial Catalog=master;";
            ConString += ary[2] + ";";
            ConString += ary[3];
        }
    }
    public bool TestConnection() {
        try {
            DbConnection con = GetConnection() ;
           
           
            con.Open();
            con.Close();
            return true;

        } catch (Exception exc) {
            return false;
        }
        
    }
    DbConnection GetConnection() {
        if (Engine.GetSqlServerType() == SqlServerType.SQL2005)
            return new SqlConnection(ConString);
        else
            return new SQLiteConnection(ConString); 
    }
    public ProcessDataBase(string conString)
    {
      ConString = conString;
    }
    public List<Sube> SubeListe()
    {
      List<Sube> liste = new List<Sube>();
      DbConnection connection =GetConnection();
      connection.Open();
      DbCommand cmd =connection.CreateCommand();
      cmd.CommandText="select SUBE_KODU from  Sube";
      cmd.Connection=connection;
      DbDataReader dr = cmd.ExecuteReader();
      while (dr.Read())
      {
        Sube sube = new Sube { Id = Convert.ToString(dr[0]) };
        liste.Add(sube);
      }
      return liste;

    }
    public void ExecuteNonQueries(string query, TextBox txtBox)
    {
      string[] strArray = query.Split(new string[] { "GO\r\n", "GO ", "GO\t" }, StringSplitOptions.RemoveEmptyEntries);
      SqlConnection connection = new SqlConnection(ConString);
      connection.Open();

      SqlCommand cmd = new SqlCommand();
      cmd.Connection = connection;
      foreach (string str in strArray)
      {
        cmd.CommandText = str;
        txtBox.Text = str;
        cmd.ExecuteNonQuery();
        //new SqlCommand(str, connection).ExecuteNonQuery();
      }
      connection.Close();
    }
    public void ExecuteNonQueries(string query)
    {
        DbConnection connection = GetConnection();        
        DbCommand cmd = connection.CreateCommand();
        cmd.CommandText = query;
        cmd.Connection = connection;
        try {
            connection.Open();
            string[] strArray = query.Split(new string[] { "GO\r\n", "GO ", "GO\t" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string str in strArray) {
                cmd.CommandText = str;              
                cmd.ExecuteNonQuery();
                //new SqlCommand(str, connection).ExecuteNonQuery();
            }
            
            connection.Close();
        } catch (Exception exc) {
            throw exc;
        } finally {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }       
    }


  }
}
