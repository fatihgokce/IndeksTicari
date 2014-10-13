using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using Indeks.Data.BusinessObjects;
using Indeks.Data.Base;
using NHibernate.Criterion;
using System.Data;
using Indeks.Data.Helper;
namespace Indeks.Data.ManagerObjects
{
  public partial interface ISiparisUstManager : IManagerBase<SiparisUst, int>
  {
    // Get Methods
    //IList<FatIrsUst> GetByCARI_KODU(System.String cari);
    List<string> GetByBelgeTipAndSubeKodu(string subeKodu, FTIRSIP ftirsip, string fatNo);
    SiparisUst GetByBelgeNoBelgeTipAndSubeKodu(string belgeNo, FTIRSIP ftirsip, string subeKodu);
    string GetLastArtiOneSipNoBySubeKoduAndFtirsip(string subeKodu, FTIRSIP ftirsip);
    List<SiparisUst> GetListByFtirsipAndSubeKodu(FTIRSIP ftirsip, string subeKodu);
    List<SiparisUst> GetListByCriter(SiparisUst sip, DateTime? dtTarBas, DateTime? dtTarBit, DateTime? dtVadeBas, DateTime? dtVadeBit);
    DataTable SiparisRapor(string subeKodu, SiparisDurum siparisDurum, string cariKodu
    , DateTime? tarBas, DateTime? tarBit, DateTime? tesBas, DateTime? tesBit);
    List<SiparisUst> GetListSiparisTeslimToday(string subeKodu);
  }
     
  public class SiparisUstManager: ManagerBase<SiparisUst, int>, ISiparisUstManager
  {
      public List<SiparisUst> GetListSiparisTeslimToday(string subeKodu) {
          return Session.QueryOver<SiparisUst>().Where(
              x => x.Sube.Id == subeKodu 
              && x.TeslimTarih == DateTime.Today && x.Kapatilmis==false).List() as List<SiparisUst>;
      }
      public DataTable SiparisRapor(string subeKodu, SiparisDurum siparisDurum, string cariKodu
    , DateTime? tarBas, DateTime? tarBit, DateTime? tesBas, DateTime? tesBit) {
          StringBuilder query = new StringBuilder(
               @" select su.FATIRSNO SiparisNo,su.FTIRSIP SiprasTip,
  su.CARI_KODU CariKodu,su.KdvTutar,su.BrutTutar,
  su.SatirIsk Iskanto,su.GenelToplam Tutar,su.TARIH Tarih,
  su.TESLIM_TARIH TeslimTarih 
  from SiparisUst su ");

          string and = "and";
          string and2 = "and";
          string or = "";
          //      public enum FTIRSIP : byte
          //{
          //  SatisFat = 1, AlisFat, SatisIrs, AlisIrs, MusSip, SaticiSip,DirektSatis
          //}
          //public enum FatTipi : byte
          //{
          //  KapaliFat = 1, AcikFat, MuhtelifFat, IadeFat,KrediKarti, ZayiIadeFat
          //}
          string beginParentez = "(";
          query.AppendFormat(" where su.SUBE_KODU='{0}' ", subeKodu);
          query.ConditionAppend(!string.IsNullOrEmpty(cariKodu), "{0} su.CARI_KODU='{1}' ".With(and, cariKodu),
              () => { and = "and"; });
          query.ConditionAppend(siparisDurum.MusteriSiparis, " {0} {1} su.FTIRSIP=5 ".With(and2, beginParentez),
              () => { or = "or"; beginParentez = ""; and2 = ""; });
          query.ConditionAppend(siparisDurum.SaticiSiparis, " {0} {1} {2} su.FTIRSIP=6 ".With(and2, beginParentez, or),
              () => { beginParentez = ""; });         
         
          query.ConditionAppend((beginParentez == ""), " ) ");
   
        
          if (tarBas.HasValue && tarBit.HasValue) {
              query.Append(" {0} {1}=between '{2}' and '{3}' ".With(and, SqlTypeHelper.GetDate("f.TARIH"), tarBas.Value.JustDate().ToString("yyyy-MM-dd"), tarBit.Value.JustDate().ToString("yyyy-MM-dd")));
              and = "and";
          }
          if (tesBas.HasValue && tesBit.HasValue) {
              query.Append(" {0} {1}=between '{2}' and '{3}' ".With(and, SqlTypeHelper.GetDate("f.VadeTarih"), tesBas.Value.JustDate().ToString("yyyy-MM-dd"), tesBit.Value.JustDate().ToString("yyyy-MM-dd")));
              and = "and";
          }
         
          IDbConnection con = Session.Connection;
          IDbCommand cmd = con.CreateCommand();
          cmd.CommandText = query.ToString();

          IDataReader dr = null;

          DataTable dt = new DataTable();
          dt.Columns.AddRange(
                              new DataColumn[]
                          {
                            new DataColumn("SiparisNo"),
                            new DataColumn("SiprasTip"),
                            new DataColumn("CariKodu",typeof(string)),                           
                            new DataColumn("KdvTutar",typeof(double)),
                            new DataColumn("BrutTutar",typeof(double)),
                             new DataColumn("Iskanto",typeof(double)),
                            new DataColumn("Tutar",typeof(double)),
                            new DataColumn("Tarih",typeof(DateTime)),
                             new DataColumn("TeslimTarih")
                          });
          try {
              dr = cmd.ExecuteReader();
              while (dr.Read()) {
                  DataRow dar = dt.NewRow();
                  dar["SiparisNo"] = dr["SiparisNo"].ToStringOrEmpty();
                  dar["SiprasTip"] = dr["SiprasTip"].ToStringOrEmpty();

                  dar["CariKodu"] = dr["CariKodu"].ToStringOrEmpty();
                  dar["KdvTutar"] = dr["KdvTutar"].ToDouble();
                  dar["BrutTutar"] = dr["BrutTutar"].ToDouble();
                  dar["Iskanto"] = dr["Iskanto"].ToDouble();
                  dar["Tutar"] = dr["Tutar"].ToDouble();
                  dar["Tarih"] = dr["Tarih"].ToStringOrEmpty("");
                  dar["TeslimTarih"] = dr["TeslimTarih"].ToDate();

                  dt.Rows.Add(dar);
              }
          } catch (Exception exc) { throw exc; } finally {
              if (dr != null && !dr.IsClosed)
                  dr.Close();
          }

          return dt;  
      }
    public List<SiparisUst> GetListByCriter(SiparisUst sip, DateTime? dtTarBas, DateTime? dtTarBit, DateTime? dtVadeBas, DateTime? dtVadeBit)
    {
      ICriteria crit = Session.CreateCriteria<SiparisUst>();
      if (!string.IsNullOrEmpty(sip.FatirsNo))
        crit.Add(Expression.Like("FatirsNo", sip.FatirsNo, MatchMode.Start));
    
      if (dtTarBas.HasValue && dtTarBit.HasValue)
        crit.Add(Expression.Between("Tarih", dtTarBas.Value.JustDate(), dtTarBit.Value.JustDate()));
      if (dtVadeBas.HasValue && dtVadeBit.HasValue)
        crit.Add(Expression.Between("VadeTarih", dtVadeBas.Value.JustDate(), dtVadeBit.Value.JustDate()));
      if (!string.IsNullOrEmpty(sip.CariKodu))
        crit.Add(Expression.Like("CariKodu", sip.CariKodu, MatchMode.Start));
      crit.Add(Expression.Eq("Ftirsip", sip.Ftirsip));
      crit.CreateCriteria("Sube").Add(Expression.Eq("Id", sip.Sube.Id)).SetMaxResults(GetMaxResult);
      return (List<SiparisUst>)crit.List<SiparisUst>();
    } 
    public List<SiparisUst> GetListByFtirsipAndSubeKodu(FTIRSIP ftirsip, string subeKodu)
    {
      ICriteria criteria = Session.CreateCriteria(typeof(SiparisUst)).Add(Expression.Eq("Ftirsip", ftirsip)).SetMaxResults(GetMaxResult);
      ICriteria subeCriter = criteria.CreateCriteria("Sube").Add(Expression.Eq("Id", subeKodu));
      return criteria.List<SiparisUst>() as List<SiparisUst>;
    }
    public SiparisUst GetByBelgeNoBelgeTipAndSubeKodu(string belgeNo, FTIRSIP ftirsip, string subeKodu)
    {
      ICriteria criteria = Session.CreateCriteria(typeof(SiparisUst)).Add(Expression.Eq("FatirsNo", belgeNo)).Add(Expression.Eq("Ftirsip", ftirsip));
      ICriteria subeCriter = criteria.CreateCriteria("Sube").Add(Expression.Eq("Id", subeKodu));
      return criteria.UniqueResult<SiparisUst>();
    }
    public List<string> GetByBelgeTipAndSubeKodu(string subeKodu, FTIRSIP ftirsip, string fatNo)
    {
      ICriteria criteria = Session.CreateCriteria(typeof(SiparisUst)).SetProjection(Projections.Property("FatirsNo")).Add(Expression.Eq("Ftirsip", ftirsip))
        .Add(Expression.Like("FatirsNo", fatNo, MatchMode.Start)).SetMaxResults(GetMaxResult);
      ICriteria subeCriteria = criteria.CreateCriteria("Sube");
      subeCriteria.Add(NHibernate.Criterion.Expression.Eq("Id", subeKodu));
      return criteria.List<string>() as List<string>;
    }
    public string GetLastArtiOneSipNoBySubeKoduAndFtirsip(string subeKodu, FTIRSIP ftirsip)
    {

      ICriteria criteria = Session.CreateCriteria(typeof(SiparisUst)).SetProjection(Projections.Max("FatirsNo"))
                                  .Add(Expression.Eq("Ftirsip", ftirsip)).SetMaxResults(1);
      ICriteria subeCriteria = criteria.CreateCriteria("Sube");
      subeCriteria.Add(NHibernate.Criterion.Expression.Eq("Id", subeKodu));
      string fatNo = criteria.UniqueResult<string>();

      if (!string.IsNullOrEmpty(fatNo))
      {

        for (int i = fatNo.Length - 1; i > 0; i--)
        {
          if (char.IsDigit(fatNo[i]))
          {
            int deger = int.Parse(fatNo[i].ToString());
            deger = deger + 1;
            if (deger > 9)
            {
              fatNo = fatNo.Remove(i, 1);
              fatNo = fatNo.Insert(i, "0");
            }
            else
            {
              fatNo = fatNo.Remove(i, 1);
              fatNo = fatNo.Insert(i, deger.ToString());
              break;
            }
          }
          else
          {
            break;
          }
        }
      }
      return fatNo;
    }
  }
}
