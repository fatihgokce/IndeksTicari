using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using Indeks.Data.BusinessObjects;
using Indeks.Data.Base;
using NHibernate.Criterion;
using Indeks.Data.Helper;
using System.Data;
namespace Indeks.Data.ManagerObjects
{
  public partial interface IFatIrsUstManager : IManagerBase<FatIrsUst, int>
  {
    // Get Methods
    IList<FatIrsUst> GetByCARI_KODU(System.String cari);
    List<string> GetByBelgeTipAndSubeKodu(string subeKodu, FTIRSIP ftirsip, string fatNo);
    FatIrsUst GetByBelgeNoBelgeTipAndSubeKodu(string belgeNo, FTIRSIP ftirsip, string subeKodu);
    string GetLastArtiOneFatIrsNoBySubeKoduAndFtirsip(string subeKodu, FTIRSIP ftirsip);
    List<FatIrsUst> GetListByFtirsipAndSubeKodu(FTIRSIP ftirsip,string subeKodu);
    List<FatIrsUst> GetListByCriter(FatIrsUst fat, DateTime? dtTarBas, DateTime? dtTarBit, DateTime? dtVadeBas, DateTime? dtVadeBit);
    DataTable FaturaRapor(string subeKodu,FaturaIrsaliyeDurumlari fatDurum,FaturaTipDurum fatTipDurum,string cariKodu
        , DateTime? dtTarBas, DateTime? dtTarBit, DateTime? dtVadeBas, DateTime? dtVadeBit);
    List<FatIrsUst> GetListFaturaToday(string subeKodu);
    List<FatIrsUst> GetListIrsaliyeSevkToday(string subeKodu);
  }

  partial class FatIrsUstManager : ManagerBase<FatIrsUst, int>, IFatIrsUstManager
  {
    #region Constructors
    public FatIrsUstManager()
      : base()
    {
    }
    #endregion
    #region Get Methods
    public List<FatIrsUst> GetListIrsaliyeSevkToday(string subeKodu) {
        return Session.QueryOver<FatIrsUst>().Where(
            x=>x.Sube.Id==subeKodu && (x.Ftirsip==FTIRSIP.AlisIrs || x.Ftirsip==FTIRSIP.SatisIrs)
            && x.SevkTarihi==DateTime.Today).List() as List<FatIrsUst>;
    }
    public List<FatIrsUst> GetListFaturaToday(string subeKodu) {
        return Session.QueryOver<FatIrsUst>().Where(
            x => x.Sube.Id == subeKodu && (x.Ftirsip == FTIRSIP.AlisFat || x.Ftirsip == FTIRSIP.SatisFat)
            && x.VadeTarih == DateTime.Today).List() as List<FatIrsUst>;
    }
    public DataTable FaturaRapor(string subeKodu,FaturaIrsaliyeDurumlari fatDurum, FaturaTipDurum fatTipDurum, string cariKodu
      , DateTime? dtTarBas, DateTime? dtTarBit, DateTime? dtVadeBas, DateTime? dtVadeBit) {
        StringBuilder query = new StringBuilder(
            @"select f.FATIRSNO FaturaIrsaliyeNo,f.FTIRSIP FaturaIrsaliyeTuru,f.FAT_TIPI FaturaIrsaliyeTipi
,f.CARI_KODU CariKodu,f.KdvTutar,f.BrutTutar,f.SatirIsk Iskanto
,f.GenelToplam Tutar,f.TARIH Tarih,f.VadeTarih 
from FatIrsUst f");
 
        string and = "and";
        string and2="and";
        string or="";
  //      public enum FTIRSIP : byte
  //{
  //  SatisFat = 1, AlisFat, SatisIrs, AlisIrs, MusSip, SaticiSip,DirektSatis
  //}
  //public enum FatTipi : byte
  //{
  //  KapaliFat = 1, AcikFat, MuhtelifFat, IadeFat,KrediKarti, ZayiIadeFat
  //}
        string beginParentez = "(";
        query.AppendFormat(" where f.SUBE_KODU='{0}' ",subeKodu);
        query.ConditionAppend(!string.IsNullOrEmpty(cariKodu), "{0} f.CARI_KODU='{1}' ".With(and,cariKodu),
            () => { and = "and"; });
        query.ConditionAppend(fatDurum.AlisFaturasi, " {0} {1} f.FTIRSIP=2 ".With(and2, beginParentez),
            () => { or = "or"; beginParentez = ""; and2 = ""; });
        query.ConditionAppend(fatDurum.SatisFaturasi, " {0} {1} {2} f.FTIRSIP=1 or f.FTIRSIP=7  ".With(and2, beginParentez, or),
            () => { beginParentez = ""; });
        query.ConditionAppend(fatDurum.AlisIrsaliyesi, " {0} {1} f.FTIRSIP=4 ".With(and2, beginParentez),
          () => { or = "or"; beginParentez = ""; and2 = ""; });
        query.ConditionAppend(fatDurum.SatisIrsaliyesi, " {0} {1} {2} f.FTIRSIP=3 ".With(and2, beginParentez, or),
            () => { beginParentez = ""; });
        or = "";
        and2 = "and";
        query.ConditionAppend((beginParentez == ""), " ) ");
        beginParentez = "(";
        query.ConditionAppend(fatTipDurum.Iade, " {0} {1} f.FAT_TIPI=4 ".With(and2, beginParentez),
            () => { or = "or"; beginParentez = ""; and2 = ""; });
        query.ConditionAppend(fatTipDurum.KrediKarti, " {0} {1} {2} f.FAT_TIPI=5 ".With(and2, beginParentez,or),
         () => { or = "or"; beginParentez = ""; and2 = ""; });
        query.ConditionAppend(fatTipDurum.Pesin, " {0} {1} {2} f.FAT_TIPI=1 ".With(and2, beginParentez, or),
       () => { or = "or"; beginParentez = ""; and2 = ""; });
        query.ConditionAppend(fatTipDurum.Vadeli, " {0} {1} {2} f.FAT_TIPI=2 ".With(and2, beginParentez, or),
       () => { or = "or"; beginParentez = ""; and2 = ""; });
        query.ConditionAppend((beginParentez == ""), " ) ");
        if (dtTarBas.HasValue && dtTarBit.HasValue) {
            query.Append(" {0} {1} between '{2}' and '{3}' ".With(and, SqlTypeHelper.GetDate("f.TARIH"), dtTarBas.Value.JustDate().ToString("yyyy-MM-dd"), dtTarBit.Value.JustDate().ToString("yyyy-MM-dd")));
            and = "and";
        }
        if (dtVadeBas.HasValue && dtVadeBit.HasValue) {
            query.Append(" {0} {1} between '{2}' and '{3}' ".With(and, SqlTypeHelper.GetDate("f.VadeTarih"), dtVadeBas.Value.JustDate().ToString("yyyy-MM-dd"), dtVadeBit.Value.JustDate().ToString("yyyy-MM-dd")));
            and = "and";
        }
        //query.ConditionAppend((dtTarBas.HasValue && dtTarBit.HasValue),
        //    " {0} f.TARIH=between '{1}' and '{2}' ".With(and, dtTarBas.Value.ToString("yyyy-MM-dd"), dtTarBit.Value.ToString("yyyy-MM-dd"))
        //    , () => {and = "and"; });
        //query.ConditionAppend((dtVadeBas!=null && dtVadeBit!=null) && (dtTarBas.HasValue && dtTarBit.HasValue),
        //    " {0} f.TARIH=between '{1}' and '{2}' ".With(and, dtTarBas.Value.ToString("yyyy-MM-dd"), dtTarBit.Value.ToString("yyyy-MM-dd")));
        IDbConnection con = Session.Connection;
        IDbCommand cmd = con.CreateCommand();
        cmd.CommandText = query.ToString();

        IDataReader dr = null;

        DataTable dt = new DataTable();
        dt.Columns.AddRange(
                            new DataColumn[]
                          {
                            new DataColumn("FaturaIrsaliyeNo"),
                            new DataColumn("FaturaIrsaliyeTuru"),
                            new DataColumn("FaturaIrsaliyeTipi"),
                            new DataColumn("CariKodu",typeof(string)),                           
                            new DataColumn("KdvTutar",typeof(double)),
                            new DataColumn("BrutTutar",typeof(double)),
                             new DataColumn("Iskanto",typeof(double)),
                            new DataColumn("Tutar",typeof(double)),
                            new DataColumn("Tarih",typeof(DateTime)),
                             new DataColumn("VadeTarih")
                          });
        try {
            dr = cmd.ExecuteReader();
            while (dr.Read()) {
                DataRow dar = dt.NewRow();
                dar["FaturaIrsaliyeNo"] = dr["FaturaIrsaliyeNo"].ToStringOrEmpty();
                dar["FaturaIrsaliyeTuru"] = dr["FaturaIrsaliyeTuru"].ToStringOrEmpty();
                dar["FaturaIrsaliyeTipi"] = dr["FaturaIrsaliyeTipi"].ToStringOrEmpty();
                dar["CariKodu"] = dr["CariKodu"].ToStringOrEmpty();
                dar["KdvTutar"] = dr["KdvTutar"].ToDouble();
                dar["BrutTutar"] = dr["BrutTutar"].ToDouble();
                dar["Iskanto"] = dr["Iskanto"].ToDouble();
                dar["Tutar"] = dr["Tutar"].ToDouble();
                dar["Tarih"] = dr["Tarih"].ToStringOrEmpty("");
                dar["VadeTarih"] = dr["VadeTarih"].ToDate();

                dt.Rows.Add(dar);
            }
        } catch (Exception exc) { throw exc; } finally {
            if (dr != null && !dr.IsClosed)
                dr.Close();
        }

        return dt;        
    }
    public List<FatIrsUst> GetListByCriter(FatIrsUst fat, DateTime? dtTarBas, DateTime? dtTarBit, DateTime? dtVadeBas, DateTime? dtVadeBit)
    {
      ICriteria crit = Session.CreateCriteria<FatIrsUst>();
      if (!string.IsNullOrEmpty(fat.FatirsNo))
        crit.Add(Expression.Like("FatirsNo",fat.FatirsNo, MatchMode.Start));      
      crit.Add(Expression.Eq("FatTipi", fat.FatTipi));
      if(dtTarBas.HasValue && dtTarBit.HasValue)
        crit.Add(Expression.Between("Tarih",dtTarBas.Value.JustDate(),dtTarBit.Value.JustDate()));
      if(dtVadeBas.HasValue && dtVadeBit.HasValue)
      crit.Add(Expression.Between("VadeTarih", dtVadeBas.Value.JustDate(), dtVadeBit.Value.JustDate()));
      if (!string.IsNullOrEmpty(fat.CariKodu))
        crit.Add(Expression.Like("CariKodu",fat.CariKodu,MatchMode.Start));
      crit.Add(Expression.Eq("Ftirsip",fat.Ftirsip));
      crit.CreateCriteria("Sube").Add(Expression.Eq("Id", fat.Sube.Id)).SetMaxResults(GetMaxResult);
      return (List<FatIrsUst>)crit.List<FatIrsUst>();
    }
    public List<FatIrsUst> GetListByFtirsipAndSubeKodu(FTIRSIP ftirsip, string subeKodu)
    {
      ICriteria criteria = Session.CreateCriteria(typeof(FatIrsUst)).Add(Expression.Eq("Ftirsip",ftirsip)).SetMaxResults(GetMaxResult);
      ICriteria subeCriter = criteria.CreateCriteria("Sube").Add(Expression.Eq("Id", subeKodu));
      return criteria.List<FatIrsUst>() as List<FatIrsUst>;
    }
    public FatIrsUst GetByBelgeNoBelgeTipAndSubeKodu(string belgeNo, FTIRSIP ftirsip, string subeKodu)
    {
      ICriteria criteria = Session.CreateCriteria(typeof(FatIrsUst)).Add(Expression.Eq("FatirsNo", belgeNo)).Add(Expression.Eq("Ftirsip", ftirsip));
      ICriteria subeCriter = criteria.CreateCriteria("Sube").Add(Expression.Eq("Id", subeKodu));
      return criteria.UniqueResult<FatIrsUst>();
    }
    public List<string> GetByBelgeTipAndSubeKodu(string subeKodu, FTIRSIP ftirsip, string fatNo)
    {
      ICriteria criteria = Session.CreateCriteria(typeof(FatIrsUst)).SetProjection(Projections.Property("FatirsNo")).Add(Expression.Eq("Ftirsip", ftirsip))
        .Add(Expression.Like("FatirsNo", fatNo, MatchMode.Start)).SetMaxResults(GetMaxResult);
      ICriteria subeCriteria = criteria.CreateCriteria("Sube");
      subeCriteria.Add(NHibernate.Criterion.Expression.Eq("Id", subeKodu));
      return criteria.List<string>() as List<string>;
    }
    public IList<FatIrsUst> GetByCARI_KODU(System.String cari)
    {
      ICriteria criteria = Session.CreateCriteria(typeof(FatIrsUst));
      //ICriteria cariCriteria = criteria.CreateCriteria("Cari");
      //cariCriteria.Add(NHibernate.Criterion.Expression.Eq("Id", cari));
      return criteria.Add(Expression.Eq("CariKodu", cari)).List<FatIrsUst>();
    }
    public string GetLastArtiOneFatIrsNoBySubeKoduAndFtirsip(string subeKodu, FTIRSIP ftirsip)
    {

      ICriteria criteria = Session.CreateCriteria(typeof(FatIrsUst)).SetProjection(Projections.Max("FatirsNo"))
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
    #endregion
  }
}