using System;
using System.Collections.Generic;
using Indeks.Data.BusinessObjects;
using Indeks.Data.Base;
using NHibernate.Criterion;
using Indeks.Data.Report;
using NHibernate;
using System.Data;
using Indeks.Data.Helper;
using System.Text;
namespace Indeks.Data.ManagerObjects
{
  public interface IKasaHarManager : IManagerBase<KasaHareket, int>

  {
    KasaHareket GetBySubeKoduTipAndFisNo(string subeKodu,KasaHarTip tip, string fisNo);
    DataTable KasaHareketDokumu(string subeKodu,string kasaKodu, DateTime startDate, DateTime finishDate);
    double GetKasaGelirGiderBySubeKoduAndKasaKodu(string subeKodu, string kasaKodu, KasaGelirGider gelirGider);
    KasaHareket GetByTipAndCekOrSenetId(string subeKodu, KasaHarTip kasaHareketTip, int cekOrsenetId);
    List<KasaGunlukGelirGider> GetGunlukGelirGider(KasaHareketDurumlari helper, string kasaKodu, string subeKodu);
    DataTable OzelGelirGiderRapor(string subeKodu,GelirGider gelirGider,string gelirGiderKod,DateTime beginDate,DateTime endDate);
    DataTable AyAyGelirGiderRaporu(KasaHareketDurumlari durumlar, string kasaKodu, string subeKodu, int yil);
    double KasalardakiToplamGelir(string subeKodu,DateTime?beginDate,DateTime?endDate);

  }
  public class KasaHarManager:ManagerBase<KasaHareket,int>,IKasaHarManager
  {
      public double KasalardakiToplamGelir(string subeKodu,DateTime? beginDate, DateTime? endDate) {
          if (beginDate.HasValue && endDate.HasValue) {
              double gelir= Session.QueryOver<KasaHareket>().Where(x => x.Sube.Id == subeKodu && x.GelirGider == KasaHareket.DetermineGelirGider(KasaGelirGider.Gelir)
                 && x.Tarih.Value.IsBetween(beginDate.Value).And(endDate.Value)).Select(
                    Projections.Sum<KasaHareket>(x => x.Tutar)
                    ).SingleOrDefault<double>();
              double gider = Session.QueryOver<KasaHareket>().Where(x => x.Sube.Id == subeKodu && x.GelirGider == KasaHareket.DetermineGelirGider(KasaGelirGider.Gider)
                && x.Tarih.Value.IsBetween(beginDate.Value).And(endDate.Value)).Select(
                   Projections.Sum<KasaHareket>(x => x.Tutar)
                   ).SingleOrDefault<double>();
              return gelir - gider;
          } else {
              double gelir= Session.QueryOver<KasaHareket>().Where(x => x.Sube.Id == subeKodu && x.GelirGider == KasaHareket.DetermineGelirGider(KasaGelirGider.Gelir)).Select(
                    Projections.Sum<KasaHareket>(x => x.Tutar)
                    ).SingleOrDefault<double>();
              double gider = Session.QueryOver<KasaHareket>().Where(x => x.Sube.Id == subeKodu && x.GelirGider == KasaHareket.DetermineGelirGider(KasaGelirGider.Gider)).Select(
                 Projections.Sum<KasaHareket>(x => x.Tutar)
                 ).SingleOrDefault<double>();
              return gelir - gider;
          }
      }
      public DataTable AyAyGelirGiderRaporu(KasaHareketDurumlari durumlar, string kasaKodu, string subeKodu,int yil) {
          IDbConnection con = Session.Connection;
          IDbCommand cmd = con.CreateCommand();
          StringBuilder query = new StringBuilder();
          query.AppendFormat(@"select {0} Ay,SUM(case when kh.GELIR_GIDER='G' then
                          kh.Tutar else 0 end) as GelirToplam
                         ,sum(case when kh.GELIR_GIDER='C' then kh.Tutar else 0 end) as GiderToplam
         ,sum((case when kh.GELIR_GIDER='G' then kh.Tutar else 0 end)-
         (case when kh.GELIR_GIDER='C' then kh.Tutar else 0 end)) as Bakiye
         from KasaHareket kh where ", SqlTypeHelper.GetMonth("kh.Tarih"));

          string or = "";

          string and = "";
          string beginParentez = "(";
          query.ConditionAppend(durumlar.MalAlis,
              string.Format("{0} (kh.TIP='F' and kh.GELIR_GIDER='C')  ", beginParentez), () =>
              { or = "or";and = "and";beginParentez = "";});
          query.ConditionAppend(durumlar.MalSatis,
             string.Format("{0} {1} (kh.TIP='F' and kh.GELIR_GIDER='G')  ", beginParentez,or), () =>
             { or = "or"; and = "and"; beginParentez = ""; });
          query.ConditionAppend(durumlar.CaridenTahsilat,
             string.Format("{0} {1} (kh.TIP='C' and kh.GELIR_GIDER='G')  ", beginParentez,or), () =>
             { or = "or"; and = "and"; beginParentez = ""; });
          query.ConditionAppend(durumlar.CariyeOdeme,
            string.Format("{0} {1} (kh.TIP='C' and kh.GELIR_GIDER='C')  ", beginParentez, or), () =>
            { or = "or"; and = "and"; beginParentez = ""; });
          query.ConditionAppend(durumlar.BankayaYatan,
              string.Format("{0} {1} (kh.TIP='B' and kh.GELIR_GIDER='C')  ", beginParentez, or), () =>
              { or = "or"; and = "and"; beginParentez = ""; });
          query.ConditionAppend(durumlar.BankadanCekilen,
             string.Format("{0} {1} (kh.TIP='B' and kh.GELIR_GIDER='G')  ", beginParentez, or), () =>
             { or = "or"; and = "and"; beginParentez = ""; });
          query.ConditionAppend(durumlar.CekGelir,
            string.Format("{0} {1} (kh.TIP='E' and kh.GELIR_GIDER='G')  ", beginParentez, or), () =>
            { or = "or"; and = "and"; beginParentez = ""; });
          query.ConditionAppend(durumlar.CekGider,
            string.Format("{0} {1} (kh.TIP='E' and kh.GELIR_GIDER='C')  ", beginParentez, or), () =>
            { or = "or"; and = "and"; beginParentez = ""; });
          query.ConditionAppend(durumlar.SenetGelir,
             string.Format("{0} {1} (kh.TIP='S' and kh.GELIR_GIDER='G')  ", beginParentez, or), () =>
             { or = "or"; and = "and"; beginParentez = ""; });
          query.ConditionAppend(durumlar.SenetGider,
            string.Format("{0} {1} (kh.TIP='S' and kh.GELIR_GIDER='C')  ", beginParentez, or), () =>
            { or = "or"; and = "and"; beginParentez = ""; });
          query.ConditionAppend(durumlar.OzelGelir,
            string.Format("{0} {1} (kh.TIP='O' and kh.GELIR_GIDER='G')  ", beginParentez, or), () =>
            { or = "or"; and = "and"; beginParentez = ""; });
          query.ConditionAppend(durumlar.OzelGider,
            string.Format("{0} {1} (kh.TIP='O' and kh.GELIR_GIDER='C')  ", beginParentez, or), () =>
            { or = ""; and = "and"; beginParentez = ""; });
         
          if (beginParentez == "")
              query.Append(")");
          //query.AppendFormat(" {0} kh.Tarih between '{1}' and '{2}' ", and, durum.BeginDate.ToString("yyyy-MM-dd"), durum.EndDate.ToString("yyyy-MM-dd"));
          query.AppendFormat(" {0} {1}='{2}'", and, SqlTypeHelper.GetYear("kh.Tarih"), yil);
          query.AppendFormat(" and kh.KASA_KOD='{0}' and kh.SUBE_KODU='{1}'", kasaKodu, subeKodu);
          query.AppendFormat("  group by {0}", SqlTypeHelper.GetMonth("kh.Tarih"));
          cmd.CommandText = query.ToString();
         
          IDataReader dr = null;
          DataTable dt = new DataTable();
          try {
              dr = cmd.ExecuteReader();
             
              dt.Columns.AddRange(
                                new DataColumn[]
                          {
                            new DataColumn("Ay",typeof(string)),
                             new DataColumn("Gelir",typeof(double)),
                            new DataColumn("Gider",typeof(double)),
                            new DataColumn("Bakiye",typeof(double))                           
                          }
                               );
              while (dr.Read()) {
                  DataRow drow = dt.NewRow();
                  drow[0] = dr[0].ToStringOrEmpty();
                  drow[1] = dr[1].ToStringOrEmpty("0");
                  drow[2] = dr[2].ToStringOrEmpty("0");
                  drow[3] = dr[3].ToStringOrEmpty("0");                 
                  dt.Rows.Add(drow);
              }
          } catch (Exception exc) {
              throw exc;
          } finally {
              if (dr != null && !dr.IsClosed)
                  dr.Close();
          }

          return dt;
      }
      public List<KasaGunlukGelirGider> GetGunlukGelirGider(KasaHareketDurumlari helper, string kasaKodu, string subeKodu) {
          IDbConnection con = Session.Connection;
          IDbCommand cmd = con.CreateCommand();
          StringBuilder query = new StringBuilder();
          query.AppendFormat(@"select kh.Tarih,SUM(case when kh.GELIR_GIDER='G' then
                          kh.Tutar else 0 end) as GelirToplam
                         ,sum(case when kh.GELIR_GIDER='C' then kh.Tutar else 0 end) as GiderToplam
         ,sum((case when kh.GELIR_GIDER='G' then kh.Tutar else 0 end)-
         (case when kh.GELIR_GIDER='C' then kh.Tutar else 0 end)) as Bakiye
         from KasaHareket kh where ");
  
          string or = "";
         
          string and="";
          string beginParentez = "(";
         
          if (helper.MalAlis) {
              query.AppendFormat("{0} (kh.TIP='F' and kh.GELIR_GIDER='C')  ",beginParentez);        
              or = "or";             
              and="and";
              beginParentez = "";
          }
          if (helper.MalSatis) {
              query.AppendFormat("{0} {1} (kh.TIP='F' and kh.GELIR_GIDER='G') ",beginParentez,or);
              or = "or";             
              and="and";
              beginParentez = "";
          }
          if (helper.CaridenTahsilat) {
              query.AppendFormat("{0} {1} (kh.TIP='C' and kh.GELIR_GIDER='G') ", beginParentez,or);
              or = "or";             
              and="and";
              beginParentez = "";
          }
          if (helper.CariyeOdeme) {
              query.AppendFormat("{0}{1} (kh.TIP='C' and kh.GELIR_GIDER='C') ", beginParentez,or);
              or = "or";             
              and="and";
              beginParentez = "";
          }
          if (helper.BankayaYatan) {
              query.AppendFormat("{0}{1} (kh.TIP='B' and kh.GELIR_GIDER='C') ",beginParentez,or);
              or = "or";            
              and="and";
              beginParentez = "";
          }
          if (helper.BankadanCekilen) {
              query.AppendFormat("{0}{1} (kh.TIP='B' and kh.GELIR_GIDER='G') ",beginParentez,or);
              or = "or";
              and="and";
              beginParentez = "";
          }
          if (helper.CekGider) {
              query.AppendFormat("{0}{1} (kh.TIP='E' and kh.GELIR_GIDER='C') ",beginParentez, or);
              or = "or";
              and="and";
              beginParentez = "";
          }
          if (helper.CekGelir) {
              query.AppendFormat("{0}{1} (kh.TIP='E' and kh.GELIR_GIDER='G') ",beginParentez, or);
              or = "or";
              and="and";
              beginParentez = "";
          }
          if (helper.SenetGider) {
              query.AppendFormat("{0}{1} (kh.TIP='S' and kh.GELIR_GIDER='C') ",beginParentez,or);
              or = "or";
              and="and";
              beginParentez = "";
          }
          if (helper.SenetGelir) {
              query.AppendFormat("{0}{1} (kh.TIP='S' and kh.GELIR_GIDER='G') ",beginParentez, or);
              or = "or";
              and="and";
              beginParentez = "";
          }
          if (helper.OzelGider) {
              query.AppendFormat("{0}{1} (kh.TIP='O' and kh.GELIR_GIDER='C') ",beginParentez, or);
              or = "or";
              and="and";
              beginParentez = "";
          }
          if (helper.OzelGelir) {
              query.AppendFormat("{0}{1} (kh.TIP='O' and kh.GELIR_GIDER='G') ",beginParentez, or);
              or = "";
              and="and";
              beginParentez = "";
          }
          if (beginParentez == "")
              query.Append(")");
          query.AppendFormat(" {0} {1} between '{2}' and '{3}' ", and, SqlTypeHelper.GetDate("kh.Tarih"), helper.BeginDate.JustDate().ToString("yyyy-MM-dd"), helper.EndDate.JustDate().ToString("yyyy-MM-dd"));
          query.AppendFormat(" and kh.KASA_KOD='{0}' and kh.SUBE_KODU='{1}'", kasaKodu, subeKodu);
          query.Append(" group by kh.Tarih");
          cmd.CommandText = query.ToString();
          List<KasaGunlukGelirGider> liste;
           IDataReader dr=null;
          try {
              dr= cmd.ExecuteReader();
              liste = new List<KasaGunlukGelirGider>();
              while (dr.Read()) {
                  KasaGunlukGelirGider item = new KasaGunlukGelirGider();
                  item.Tarih = DateTime.Parse(dr["Tarih"].ToString());
                  item.Gelir = double.Parse(dr["GelirToplam"].ToString());
                  item.Gider = double.Parse(dr["GiderToplam"].ToString());
                  item.Bakiye = double.Parse(dr["Bakiye"].ToString());
                  liste.Add(item);
              }
          } catch (Exception exc) {
              throw exc;
          } finally {
              if (dr != null && !dr.IsClosed)
                  dr.Close();
          }
          
          return liste;
      }
     
      public KasaHareket GetByTipAndCekOrSenetId(string subeKodu, KasaHarTip kasaHareketTip, int cekOrsenetId) {
          return Session.QueryOver<KasaHareket>().Where(x=>x.Sube.Id==subeKodu && 
              x.CekSenetId==cekOrsenetId && x.Tip==KasaHareket.DetermineTip(kasaHareketTip)).SingleOrDefault();
      }

      public KasaHareket GetBySubeKoduTipAndFisNo(string subeKodu, KasaHarTip tip, string fisNo)
      {
      //ICriteria criter = Session.CreateCriteria<KasaHareket>().Add(Expression.Eq("FisNo", fisNo)).Add(Expression.Eq("Tip",tip));
      //return criter.UniqueResult<KasaHareket>();

      return Session.QueryOver<KasaHareket>().Where(x=>x.Sube.Id==subeKodu && 
                              x.FisNo==fisNo && x.Tip==KasaHareket.DetermineTip(tip)).SingleOrDefault();
    }
    public DataTable KasaHareketDokumu(string subeKodu, string kasaKodu, DateTime startDate, DateTime finishDate)
    {
          string query = @"select kh.Kasa.Id,kh.Tip,kh.GelirGider,kh.FisNo,kh.Tutar,kh.Tarih,kh.Aciklama 
                    from KasaHareket kh where kh.Kasa.Sube.Id=:sid and kh.Kasa.Id=:kkodu and kh.Tarih  between :sd and :fd";

      IQuery qry = Session.CreateQuery(query).SetString("sid", subeKodu)
                           .SetString("kkodu", kasaKodu).SetDateTime("sd", startDate)
                           .SetDateTime("fd", finishDate);
     
      //IResultTransformer rTransform = new AliasToBeanConstructorResultTransformer(typeof(DataTable).GetConstructors()[0]);
      //qry.SetResultTransformer(rTransform);
      IList<object[]> liste = qry.List<object[]>();
      DataTable dt = new DataTable();
      dt.Columns.AddRange(
                          new DataColumn[]
                          {
                            new DataColumn("KasaKod",typeof(string)),
                             new DataColumn("HareketTipi",typeof(string)),
                            new DataColumn("Gelir/Gider",typeof(string)),
                            new DataColumn("FisNo",typeof(string)),
                            new DataColumn("Tutar",typeof(double)),
                            new DataColumn("Tarih",typeof(DateTime)),
                            new DataColumn("Aciklama")
                          }
                         );

      foreach (object[] objarray in liste)
      {
        DataRow dr = dt.NewRow();
        int i = 0;
        foreach (object obj in objarray)
        {
          dr[i] = obj.ToStringOrEmpty();
          i++;
        }
        dt.Rows.Add(dr);
      }
      return dt;
    }
    public double GetKasaGelirGiderBySubeKoduAndKasaKodu(string subeKodu, string kasaKodu, KasaGelirGider gelirGider)
    {
      double res = 0;
      string strGelirGider = gelirGider == KasaGelirGider.Gelir ? "G" : "C";
      ICriteria criter=Session.CreateCriteria<KasaHareket>().SetProjection(Projections.Sum("Tutar"))
                               .Add(Expression.Eq("GelirGider",strGelirGider)).CreateCriteria("Kasa").Add(Expression.Eq("Id",kasaKodu));
      ICriteria subeCriteria = criter.CreateCriteria("Sube");
      subeCriteria.Add(NHibernate.Criterion.Expression.Eq("Id", subeKodu));
      object obj = criter.UniqueResult();
      if (obj != null)
        res = Convert.ToDouble(obj);
      return res;
    }
    public DataTable OzelGelirGiderRapor(string subeKodu,GelirGider gelirGider, string gelirGiderKod, DateTime beginDate, DateTime endDate) {
        IDbConnection con = Session.Connection;
        IDbCommand cmd = con.CreateCommand();
        StringBuilder query = new StringBuilder();
        query.AppendFormat(@" select o.Kod,o.Ismi,kh.KDV_ORANI KdvOranı,kh.KDV_TUTAR KdvTutar,kh.Tutar,kh.Aciklama
  from KasaHareket kh inner join OzelGelirGider o 
  on (kh.OzelGelirGiderKod=o.Kod)
  where ");
        query.AppendFormat(" kh.SUBE_KODU='{0}' and ",subeKodu);
        query.AppendFormat("o.GelirGider={0} and {1} between '{2}' and '{3}'  ", (byte)gelirGider, SqlTypeHelper.GetDate("kh.Tarih"), beginDate.JustDate().ToString("yyyy-MM-dd"), endDate.JustDate().ToString("yyyy-MM-dd"));
        if (!string.IsNullOrEmpty(gelirGiderKod))
            query.AppendFormat(" and o.Kod='{0}'",gelirGiderKod);
        cmd.CommandText = query.ToString();
        IDataReader dread=null;
        DataTable dt = new DataTable();
        try {
            dread = cmd.ExecuteReader();
            dt.Columns.AddRange(
                                new DataColumn[]
                          {
                            new DataColumn("ÖzelKod",typeof(string)),
                             new DataColumn("ÖzelKodIsmi",typeof(string)),
                            new DataColumn("KdvOranı",typeof(double)),
                            new DataColumn("KdvTutar",typeof(double)),
                            new DataColumn("Tutar",typeof(double)),
                            new DataColumn("Açıklama",typeof(string))
                          }
                               );
            while (dread.Read()) {
                DataRow dr = dt.NewRow();
                dr[0] = dread[0].ToStringOrEmpty();
                dr[1] = dread[1].ToStringOrEmpty();
                dr[2] = dread[2].ToStringOrEmpty("0");
                dr[3] = dread[3].ToStringOrEmpty("0");
                dr[4] = dread[4].ToStringOrEmpty("0");
                dr[5] = dread[5].ToStringOrEmpty();
                dt.Rows.Add(dr);
            }
        } catch (Exception exc) { throw exc; } finally {
            if ( dread!=null && !dread.IsClosed)
                dread.Close();
        }
        return dt;
    }
  }
}
