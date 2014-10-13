using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Indeks.Data.BusinessObjects;
namespace Indeks.Views.ReportHelp
{
    public enum ReportTo { 
    Excel,Html,Csv,CrytalReport
    }
  public class ConvertToDataTable
  {
    public DataTable HesapHareketToDataTable(List<HesapHareket> liste)
    {
      DataTable dt = new DataTable();
      dt.Columns.AddRange(
                          new DataColumn[]
                          {
                            new DataColumn("BankaAdi"),
                            new DataColumn("HesapSahibi"),
                            new DataColumn("SubeAdi",typeof(string)),
                            new DataColumn("HesapNo",typeof(string)),
                            new DataColumn("ParaBirimi"),
                            new DataColumn("Tarih",typeof(DateTime)),
                            new DataColumn("HareketTuru",typeof(string)),
                            new DataColumn("Tutar",typeof(double)),
                            new DataColumn("DekontNo",typeof(string)),
                            new DataColumn("Aciklama",typeof(string))                           
                          }
                         );

      foreach (HesapHareket har in liste)
      {
        DataRow dr = dt.NewRow();
       
        dr["BankaAdi"] = har.BankaHesap.BankaAdi;
        dr["HesapSahibi"] = har.BankaHesap.HesapSahibi;
        dr["SubeAdi"] = har.BankaHesap.SubeAdi;
        dr["HesapNo"] = har.BankaHesap.HesapNo;
        dr["ParaBirimi"] = har.BankaHesap.ParaBirimi;
        dr["Tarih"] = har.Tarih;
        dr["HareketTuru"] = har.HareketTuru;
        dr["Tutar"] = har.Tutar;
        dr["DekontNo"] = har.DekontNo;
        dr["Aciklama"] = har.Aciklama;
       
        dt.Rows.Add(dr);
      }
      return dt;
    }
  }
}
