using System;
using System.Collections.Generic;

using System.Text;
using Indeks.Data.BusinessObjects;
using Indeks.Data.Base;
using NHibernate;
using NHibernate.Criterion;
using System.Data;
using Indeks.Data.Helper;
namespace Indeks.Data.ManagerObjects
{
  public interface ICariHareketManager : IManagerBase<CariHareket, int>
  {
    // Get Methods 
    CariHareket GetByFisNo(string subeKodu,string fisNo);
    CariHareket GetByCekOrSenetIdAndHareketTuruAndCariKod(string subeKodu,int cekOrSenetId, CariHarTuru caharTur, string cariKodu);
    DataTable GenelBorcAlacakDokumu(string subeKodu,string cariKodu, DateTime?startDate, DateTime?finishDate);
    DataTable GenelBorcAlacakDokumu(string subeKodu, string cariKodu);
    DataTable GenelBorcAlacakDokumu(string subeKodu, DateTime?startDate, DateTime? finishDate);
    DataTable CariHareketDokumu(string subeKodu, string cariKodu, CariHareketleriDurumu hareketler);
    double GetCariHesapBakiyesi(string subeKodu, string cariKodu);
    double GetCariToplamAlacak(string subeKodu, string cariKodu);
    double GetCariToplamBorc(string subeKodu, string cariKodu);
    double CarilerinToplamBorcu(string subeKodu, DateTime? beginDate, DateTime? endDate);
    double CarilerinToplamAlacagi(string subeKodu, DateTime? beginDate, DateTime? endDate);
  }
  public class CariHareketManager : ManagerBase<CariHareket, int>, ICariHareketManager
  {
    #region ICariHareketManager Members  
      public double CarilerinToplamBorcu(string subeKodu, DateTime? beginDate, DateTime? endDate) {
          if (beginDate.HasValue && endDate.HasValue)
              return Session.QueryOver<CariHareket>().Where(x => x.Sube.Id == subeKodu
                 && x.Tarih.IsBetween(beginDate.Value).And(endDate.Value)).Select(
                    Projections.Sum<CariHareket>(x => x.Borc)
                    ).SingleOrDefault<double>();
          else
              return Session.QueryOver<CariHareket>().Where(x => x.Sube.Id == subeKodu).Select(
                    Projections.Sum<CariHareket>(x => x.Borc)
                    ).SingleOrDefault<double>();
      }
      public double CarilerinToplamAlacagi(string subeKodu, DateTime? beginDate, DateTime? endDate) {
          if (beginDate.HasValue && endDate.HasValue)
              return Session.QueryOver<CariHareket>().Where(x => x.Sube.Id == subeKodu
                 && x.Tarih.IsBetween(beginDate.Value).And(endDate.Value)).Select(
                    Projections.Sum<CariHareket>(x => x.Alacak)
                    ).SingleOrDefault<double>();
          else
              return Session.QueryOver<CariHareket>().Where(x => x.Sube.Id == subeKodu).Select(
                    Projections.Sum<CariHareket>(x => x.Alacak)
                    ).SingleOrDefault<double>();
      }
    public CariHareket GetByFisNo(string subeKodu, string fisNo) {
          return Session.QueryOver<CariHareket>().Where(x => x.Sube.Id == subeKodu && x.FisNo == fisNo).SingleOrDefault();
      }
    public DataTable CariHareketDokumu(string subeKodu,string cariKodu,CariHareketleriDurumu hareketler)
    {
        StringBuilder query = new StringBuilder();
        query.AppendFormat(@"SELECT cari.CARI_KODU CariKod,cari.CARI_ISIM CariIsim,
cari.CARI_TEL Telefon,
cari.CEP_TEL CepTelefonu,cari.CARI_ADRES Adres,
ch.FisNo FisNo,ch.Borc Borc,ch.Alacak Alacak,ch.HareketTuru HareketTuru,ch.Tarih,ch.VadeTarih,ch.Aciklama
FROM  Cari cari INNER JOIN
      CariHareket ch ON cari.CARI_KODU =ch.CariKodu
where (cari.SUBE_KODU='{0}' or SubelerdeOrtak=1)  ", subeKodu);
        string or = "";

        string and = "and";
        string beginParentez = "(";
        query.ConditionAppend(hareketler.NakitTahsilat,
            string.Format("{0} {1} ch.HareketTuru=2   ", and, beginParentez), () =>
            {or = "or"; and = ""; beginParentez = ""; });
        query.ConditionAppend(hareketler.NakitOdeme,
               string.Format("{0} {1} {2} ch.HareketTuru=3   ", and, beginParentez, or), () =>
               { or = "or"; and = ""; beginParentez = ""; });
        query.ConditionAppend(hareketler.AlinanMal,
                string.Format("{0} {1} {2} ch.HareketTuru=4   ", and, beginParentez, or), () =>
                { or = "or"; and = ""; beginParentez = ""; });
        query.ConditionAppend(hareketler.SatilanMal,
              string.Format("{0} {1} {2} ch.HareketTuru=5   ", and, beginParentez, or), () =>
              { or = "or"; and = ""; beginParentez = ""; });
        query.ConditionAppend(hareketler.AlinanMalIadesi,
               string.Format("{0} {1} {2} ch.HareketTuru=6   ", and, beginParentez, or), () =>
               { or = "or"; and = ""; beginParentez = ""; });
        query.ConditionAppend(hareketler.SatilanMalIadesi,
                string.Format("{0} {1} {2} ch.HareketTuru=7   ", and, beginParentez, or), () =>
                { or = "or"; and = ""; beginParentez = ""; });
        query.ConditionAppend(hareketler.AlinanCek,
               string.Format("{0} {1} {2} ch.HareketTuru=8   ", and, beginParentez, or), () =>
               { or = "or"; and = ""; beginParentez = ""; });
        query.ConditionAppend(hareketler.VerilenCek,
                string.Format("{0} {1} {2} ch.HareketTuru=9   ", and, beginParentez, or), () =>
                { or = "or"; and = ""; beginParentez = ""; });        
       
        if (hareketler.CekCirosu) {
            query.AppendFormat("{0} {1} {2} ch.HareketTuru=10   ", and, beginParentez, or);
            or = "or";
            and = "";
            beginParentez = "";
        }
        if (hareketler.AlinanCekIade) {
            query.AppendFormat("{0} {1} {2} ch.HareketTuru=11   ", and, beginParentez, or);
            or = "or";
            and = "";
            beginParentez = "";
        }
        if (hareketler.VerilenCekGeriAlinmasi) {
            query.AppendFormat("{0} {1} {2} ch.HareketTuru=12   ", and, beginParentez, or);
            or = "or";
            and = "";
            beginParentez = "";
        }
        if (hareketler.KarsiliksizCek) {
            query.AppendFormat("{0} {1} {2} ch.HareketTuru=13   ", and, beginParentez, or);
            or = "or";
            and = "";
            beginParentez = "";
        }
        if (hareketler.AlinanSenet) {
            query.AppendFormat("{0} {1} {2} ch.HareketTuru=14   ", and, beginParentez, or);
            or = "or";
            and = "";
            beginParentez = "";
        }
        if (hareketler.VerilenSenet) {
            query.AppendFormat("{0} {1} {2} ch.HareketTuru=15   ", and, beginParentez, or);
            or = "or";
            and = "";
            beginParentez = "";
        }
        if (hareketler.SenetCirosu) {
            query.AppendFormat("{0} {1} {2} ch.HareketTuru=16   ", and, beginParentez, or);
            or = "or";
            and = "";
            beginParentez = "";
        }
        if (hareketler.AlinanSenetIade) {
            query.AppendFormat("{0} {1} {2} ch.HareketTuru=17   ", and, beginParentez, or);
            or = "or";
            and = "";
            beginParentez = "";
        }
        if (hareketler.VerilenSenetGeriAlinmasi) {
            query.AppendFormat("{0} {1} {2} ch.HareketTuru=18   ", and, beginParentez, or);
            or = "or";
            and = "";
            beginParentez = "";
        }
        if (hareketler.KarsiliksizSenet) {
            query.AppendFormat("{0} {1} {2} ch.HareketTuru=19   ", and, beginParentez, or);
            or = "or";
            and = "";
            beginParentez = "";
        }
        if (hareketler.Veresiye) {
            query.AppendFormat("{0} {1} {2} ch.HareketTuru=20  ", and, beginParentez, or);
            or = "or";
            and = "";
            beginParentez = "";
        }
        if (hareketler.GelenHavale) {
            query.AppendFormat("{0} {1} {2} ch.HareketTuru=21  ", and, beginParentez, or);
            or = "or";
            and = "";
            beginParentez = "";
        }
        if (hareketler.GonderilenHavale) {
            query.AppendFormat("{0} {1} {2} ch.HareketTuru=22  ", and, beginParentez, or);
            or = "or";
            and = "";
            beginParentez = "";
        }  
       
       
        if (beginParentez == "")
            query.Append(")");
        if(hareketler.BeginDate.HasValue && hareketler.EndDate.HasValue)
            query.AppendFormat(" and {0} between '{1}' and '{2}' ", SqlTypeHelper.GetDate("ch.Tarih"), hareketler.BeginDate.Value.JustDate().ToString("yyyy-MM-dd"),
                 hareketler.EndDate.Value.JustDate().ToString("yyyy-MM-dd"));
        if (!string.IsNullOrEmpty(cariKodu))
            query.AppendFormat(" and ch.CariKodu='{0}'",cariKodu);
        IDbConnection con = Session.Connection;
        IDbCommand cmd = con.CreateCommand();
        cmd.CommandText = query.ToString();
    
        IDataReader dr = null;
    
      DataTable dt = new DataTable();
      dt.Columns.AddRange(
                          new DataColumn[]
                          {
                            new DataColumn("CariKod"),
                            new DataColumn("CariIsim"),
                            new DataColumn("Telefon"),
                            new DataColumn("CepTelefonu"),
                            new DataColumn("Adres"),
                            new DataColumn("FisNo",typeof(string)),
                            new DataColumn("HareketTuru"),                           
                            new DataColumn("Borc",typeof(double)),new DataColumn("Alacak",typeof(double)),
                            new DataColumn("Tarih",typeof(DateTime)),
                            new DataColumn("VadeTarih"),
                            new DataColumn("Aciklama")
                          });
      try {
          dr = cmd.ExecuteReader();
          while (dr.Read()) {
              DataRow dar = dt.NewRow();
              dar["CariKod"] = dr["CariKod"].ToStringOrEmpty();
              dar["CariIsim"] = dr["CariIsim"].ToStringOrEmpty();
              dar["Telefon"] = dr["Telefon"].ToStringOrEmpty();
              dar["CepTelefonu"] = dr["CepTelefonu"].ToStringOrEmpty();
              dar["Adres"] = dr["Adres"].ToStringOrEmpty();
              dar["HareketTuru"] = dr["HareketTuru"].ToStringOrEmpty();
              dar["FisNo"] = dr["FisNo"].ToStringOrEmpty();
              dar["Borc"] = dr["Borc"].ToStringOrEmpty("0");
              dar["Alacak"] = dr["Alacak"].ToStringOrEmpty("0");
              dar["Tarih"] = dr["Tarih"].ToStringOrEmpty();
              dar["VadeTarih"] = dr["VadeTarih"].ToDate();
              dar["Aciklama"] = dr["Aciklama"].ToStringOrEmpty();
              dt.Rows.Add(dar); 
          }
      } catch (Exception exc) { throw exc; } 
      finally {
          if (dr != null && !dr.IsClosed)
              dr.Close();
      }
     
      return dt;
    }
    public DataTable GenelBorcAlacakDokumu(string subeKodu, string cariKodu) {
        return GenelBorcAlacakDokumu(subeKodu,cariKodu,null,null);
    }
    public DataTable GenelBorcAlacakDokumu(string subeKodu, DateTime? startDate, DateTime? finishDate) {
        return GenelBorcAlacakDokumu(subeKodu, "", startDate, finishDate);
    }
    public DataTable GenelBorcAlacakDokumu(string subeKodu, string cariKodu, DateTime? startDate, DateTime? finishDate)
    {

        StringBuilder query = new StringBuilder();
        query.AppendFormat(@"SELECT cari.CARI_KODU CariKod,cari.CARI_ISIM CariIsim,cari.CARI_TEL Telefon,
cari.CEP_TEL CepTelefonu,cari.CARI_ADRES Adres,
sum(ch.Borc) as Borc ,sum(ch.Alacak) as Alacak,
(case when (sum(ch.Borc)-sum(ch.Alacak))>0 then sum(ch.Borc)-sum(ch.Alacak) else 0 end ) as BorcBakiyesi,
(case when (sum(ch.Alacak)-sum(ch.Borc))>0 then sum(ch.Alacak)-sum(ch.Borc) else 0 end ) as AlacakBakiyesi
             FROM  Cari cari INNER JOIN
             CariHareket ch ON cari.CARI_KODU =ch.CariKodu
             where (cari.SUBE_KODU='{0}' or SubelerdeOrtak=1)", subeKodu);
        if (startDate.HasValue && finishDate.HasValue)
            query.AppendFormat(" and {0} BETWEEN '{1}' and '{2}'", SqlTypeHelper.GetDate("ch.Tarih"), startDate.Value.JustDate().ToString("yyyy-MM-dd")
                , finishDate.Value.JustDate().ToString("yyyy-MM-dd"));     
        
        if (!string.IsNullOrEmpty(cariKodu))
            query.AppendFormat(" and cari.CARI_KODU='{0}'", cariKodu);
        query.Append(" group by cari.CARI_KODU,cari.CariTip,cari.CARI_ISIM,cari.CARI_TEL");
      DataTable dt = new DataTable();
      IDbConnection con = Session.Connection;
      IDbCommand cmd = con.CreateCommand();
      IDataReader dataRead = null;
      cmd.CommandText = query.ToString();
      dt.Columns.AddRange(
                          new DataColumn[]
                          {
                            new DataColumn("CariKod"),
                            new DataColumn("CariIsim"),new DataColumn("Telefon"),
                            new DataColumn("CepTelefonu"),
                            new DataColumn("Adres"),
                            new DataColumn("Borc",typeof(double)),new DataColumn("Alacak",typeof(double)),
                            new DataColumn("BorcBakiyesi",typeof(double)),
                            new DataColumn("AlacakBakiyesi",typeof(double))
                          }
                         );

      try {
          dataRead = cmd.ExecuteReader();
         
          while (dataRead.Read()) {
              DataRow dr = dt.NewRow();
              dr["CariKod"] = dataRead[0].ToStringOrEmpty();
              dr["CariIsim"] = dataRead[1].ToStringOrEmpty();
              dr["Telefon"] = dataRead[2].ToStringOrEmpty();
              dr["CepTelefonu"] = dataRead[3].ToStringOrEmpty();
              dr["Adres"] = dataRead[4].ToStringOrEmpty();
              dr["Borc"] = dataRead[5].ToStringOrEmpty("0");
              dr["Alacak"] = dataRead[6].ToStringOrEmpty("0");
              dr["BorcBakiyesi"] = dataRead[7].ToStringOrEmpty("0");
              dr["AlacakBakiyesi"] = dataRead[8].ToStringOrEmpty("0");
              dt.Rows.Add(dr);
          }


      } catch (Exception exc) { throw exc; } finally {
          if (dataRead != null && !dataRead.IsClosed)
              dataRead.Close();
      }
    
      return dt;
    }
    public double GetCariHesapBakiyesi(string subeKodu, string cariKodu)
    {
      IQuery query = Session.CreateQuery("select sum(ch.Alacak)-sum(ch.Borc) from CariHareket ch where ch.Sube.Id=:sk and ch.Cari.Id=:ck")
                            .SetString("sk",subeKodu).SetString("ck",cariKodu);
      object obj = query.UniqueResult();
      if (obj != null)
        return Convert.ToDouble(obj);
      else
        return 0;
    }
    public CariHareket GetByCekOrSenetIdAndHareketTuruAndCariKod(string subeKodu,int cekOrSenetId, CariHarTuru caharTur, string cariKodu) {
        return Session.QueryOver<CariHareket>()
               .Where(x => x.Sube.Id == subeKodu && x.CekSenetId == cekOrSenetId && x.HareketTuru == caharTur
               && x.Cari.Id==cariKodu).SingleOrDefault();        
    }
    public double GetCariToplamAlacak(string subeKodu, string cariKodu) {
        return Session.QueryOver<CariHareket>().Where(x=>x.Sube.Id==subeKodu && x.Cari.Id==cariKodu).Select(
            Projections.Sum<CariHareket>(x => x.Alacak)
            ).SingleOrDefault<double>();
    }
    public double GetCariToplamBorc(string subeKodu, string cariKodu) {
        return Session.QueryOver<CariHareket>().Where(x => x.Sube.Id == subeKodu && x.Cari.Id == cariKodu).Select(
            Projections.Sum<CariHareket>(x => x.Borc)
            ).SingleOrDefault<double>();
    }
    #endregion
  }
}
