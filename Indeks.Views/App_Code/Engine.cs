using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Xml.Linq;
using System.Windows.Forms;

//using Han.Xml;
using Indeks.Views.Models;
using Indeks.Data.Base;
using System.Reflection;
namespace Indeks.Views
{
  public class Engine
  {
    private static string XmlPath = Path.Combine(Application.StartupPath, "Xmls//settings.xml");
  
    public static string RaporPath() {

      //return @"D:\Project2010\Han\Indeks.Views\Rapor";
      return Path.Combine(Application.StartupPath, "Rapor"); ;
    }
    public static string DokumanPath() {

        //return @"D:\Project2010\Han\Indeks.Views\Dokumanlar";
       return Path.Combine(Application.StartupPath, "Dokumanlar"); ;
    }
    public static string DataBasePath() {
  
       //return @"D:\Project2010\Han\Indeks.Views\Db";
        return Path.Combine(Application.StartupPath, "Db");
    }
    public static string SqlLitePath() {

        //return @"D:\Project2010\Han\Indeks.Views\Db";
        return Path.Combine(Application.StartupPath, "SqlLite");
    }
    public static string GetSqlLiteConString() {
        string veriTaban="Data Source=";       
        veriTaban+=Path.Combine( DataBasePath(),"Indeks.db");
        veriTaban+=";Version=3;";
        return veriTaban;
    }
    public static void SaveSettings(Settings settings) {
        XDocument xmlDoc;
        xmlDoc = XDocument.Load(XmlPath);
        var x = (from s in xmlDoc.Descendants("Settings")
                 select
                  s).Single();
        x.Element("DataBase").Value = settings.DataBase.ToStringOrEmpty();
        x.Element("ConnectionString").Value = settings.ConnectionString;
        x.Element("Paket").Value = settings.Paket.ToString();
        x.Element("Kurulum").Value = settings.Kurulum;  
        xmlDoc.Save(XmlPath);
    
    }
    public static string GetConString()
    {     
        Settings set = FindSettings();
        if (set.DataBase == "SqlLite")
            return GetSqlLiteConString();
        else
            return set.ConnectionString;
    }
    public static Settings FindSettings() {
        XDocument xmlDoc = XDocument.Load(XmlPath);
        var query = from x in xmlDoc.Descendants("Settings")
                    select new Settings
                    {
                        ConnectionString = x.Element("ConnectionString").Value,
                        DataBase = x.Element("DataBase").Value,
                        Paket = GetIndeksPaket(x.Element("Paket").Value),
                        Kurulum = x.Element("Kurulum").Value
                    };

        return query.SingleOrDefault();
        //return new Settings(); // fatura form hata düzeliyor aktif edince

    }
    public static SqlServerType GetSqlServerType() {
        string sql = FindSettings().DataBase;
        if (sql == "MsSql")
            return SqlServerType.SQL2005;
        else
            return SqlServerType.SqlLite;
    }
    private static IndeksPaket GetIndeksPaket(string value) {
        if (string.IsNullOrEmpty(value))
            return IndeksPaket.Eko;
        return (IndeksPaket)Enum.Parse(typeof(IndeksPaket), value);
    }
    public static string Versiyon() {
        try {
            System.Version version = Assembly.GetExecutingAssembly().GetName().Version;
            return version.Major + "." + version.Minor + "." + version.Build ;
        } catch (Exception) {
            return "?.?.?";
        }
    }
   
   
  }
}
