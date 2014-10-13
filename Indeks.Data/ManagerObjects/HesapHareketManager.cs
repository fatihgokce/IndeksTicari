using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using Indeks.Data.BusinessObjects;
using Indeks.Data.Base;
using NHibernate.Criterion;
using System.Data;
namespace Indeks.Data.ManagerObjects
{
  public partial interface IHesapHareketManager : IManagerBase<HesapHareket,int>
  {
    HesapHareket GetBySubeKoduAndFisNoAndHesapNo(string subeKodu, string fisNo, string hesapNo);
    IList<HesapHareket> GetBySUBE_KODU(string sube);
    IList<HesapHareket> GetHareketTuruAndSubeKodu(string subeKodu, HesapHareketTuru hareketTuru);
    List<HesapHareket> GetHesapNoWithDate(string subeKodu, string hesapNo, DateTime startDate, DateTime finishDate, HesapHareketTuru? hareketTuru);
   
      HesapHareket GetByFisNoAndHareketTuru(string subeKodu,string fisNo,HesapHareketTuru hareketTuru);
    HesapHareket GetByCekOrSenetIdAndHareketTuru(string subeKodu, int cekOrsenetId, HesapHareketTuru hareketTuru);
    double BankalardakiToplamPara(string subeKodu, DateTime? beginDate, DateTime? endDate);
  }
  public class HesapHareketManager:ManagerBase<HesapHareket,int>,IHesapHareketManager
  {
      public double BankalardakiToplamPara(string subeKodu, DateTime? beginDate, DateTime? endDate) {
          if (beginDate.HasValue && endDate.HasValue) {
              double gelir = Session.QueryOver<HesapHareket>().Where(x => x.Sube.Id == subeKodu
                 && x.Tarih.IsBetween(beginDate.Value).And(endDate.Value)
                 && (x.HareketTuru == HesapHareketTuru.GelenHavale || x.HareketTuru == HesapHareketTuru.KrediKarti
                 || x.HareketTuru == HesapHareketTuru.ParaYatirma || x.HareketTuru == HesapHareketTuru.SenetTahsil
                 || x.HareketTuru == HesapHareketTuru.CekTahsil)
                 )
                 .Select(
                    Projections.Sum<HesapHareket>(x => x.Tutar)
                    ).SingleOrDefault<double>();
              double gider = Session.QueryOver<HesapHareket>().Where(x => x.Sube.Id == subeKodu
                && x.Tarih.IsBetween(beginDate.Value).And(endDate.Value)
                && (x.HareketTuru == HesapHareketTuru.GonderilenHavale || x.HareketTuru == HesapHareketTuru.ParaCekme
                || x.HareketTuru==HesapHareketTuru.CekOdeme)
                )
                .Select(
                   Projections.Sum<HesapHareket>(x => x.Tutar)
                   ).SingleOrDefault<double>();
              double net = gelir - gider;
              return net;
          } else {
              double gelir = Session.QueryOver<HesapHareket>().Where(x => x.Sube.Id == subeKodu
                 && (x.HareketTuru == HesapHareketTuru.GelenHavale || x.HareketTuru == HesapHareketTuru.KrediKarti
                 || x.HareketTuru == HesapHareketTuru.ParaYatirma || x.HareketTuru == HesapHareketTuru.SenetTahsil
                 || x.HareketTuru == HesapHareketTuru.CekTahsil)
                 )
                 .Select(
                    Projections.Sum<HesapHareket>(x => x.Tutar)
                    ).SingleOrDefault<double>();
              double gider = Session.QueryOver<HesapHareket>().Where(x => x.Sube.Id == subeKodu
                && (x.HareketTuru == HesapHareketTuru.GonderilenHavale || x.HareketTuru == HesapHareketTuru.ParaCekme
                || x.HareketTuru==HesapHareketTuru.CekOdeme)
                )
                .Select(
                   Projections.Sum<HesapHareket>(x => x.Tutar)
                   ).SingleOrDefault<double>();
              double net = gelir - gider;
              return net;
          
          }
      }
      public HesapHareket GetByCekOrSenetIdAndHareketTuru(string subeKodu, int cekOrsenetId, HesapHareketTuru hareketTuru) {
          return Session.QueryOver<HesapHareket>().Where(x => x.Sube.Id == subeKodu && x.CekSenetId == cekOrsenetId
              && x.HareketTuru == hareketTuru).SingleOrDefault();
      }
      public HesapHareket GetByFisNoAndHareketTuru(string subeKodu, string fisNo, HesapHareketTuru hareketTuru) {
          return Session.QueryOver<HesapHareket>().Where(x => x.Sube.Id == subeKodu &&
              x.FisNo == fisNo && x.HareketTuru == hareketTuru).SingleOrDefault();
      }
    public HesapHareket GetBySubeKoduAndFisNoAndHesapNo(string subeKodu, string fisNo, string hesapNo)
    {
      ICriteria criteria = Session.CreateCriteria(typeof(HesapHareket)).Add(Expression.Eq("FisNo",fisNo));
     
      ICriteria subeCriteria = criteria.CreateCriteria("Sube");
      subeCriteria.Add(NHibernate.Criterion.Expression.Eq("Id", subeKodu));
      ICriteria bankaCriteria = criteria.CreateCriteria("BankaHesap");
      bankaCriteria.Add(NHibernate.Criterion.Expression.Eq("HesapNo", hesapNo));
      return criteria.UniqueResult<HesapHareket>();
    }
    public List<HesapHareket> GetHesapNoWithDate(string subeKodu,string hesapNo, DateTime startDate, DateTime finishDate, HesapHareketTuru? hareketTuru)
    {     
        
        ICriteria criteria = Session.CreateCriteria(typeof(HesapHareket)).Add(Expression.Between("Tarih", startDate, finishDate));
        if (hareketTuru.HasValue)
            criteria.Add(Expression.Eq("HareketTuru",hareketTuru.Value));
        ICriteria subeCriteria = criteria.CreateCriteria("Sube");
        subeCriteria.Add(NHibernate.Criterion.Expression.Eq("Id", subeKodu));
        ICriteria bankaCriteria = criteria.CreateCriteria("BankaHesap");
        bankaCriteria.Add(NHibernate.Criterion.Expression.Eq("HesapNo", hesapNo));
        return criteria.List<HesapHareket>() as List<HesapHareket>;
       

    }
    public IList<HesapHareket> GetBySUBE_KODU(string sube)
    {
      ICriteria criteria = Session.CreateCriteria(typeof(HesapHareket)).SetMaxResults(GetMaxResult);
      ICriteria subeCriteria = criteria.CreateCriteria("Sube");
      subeCriteria.Add(NHibernate.Criterion.Expression.Eq("Id", sube));
      return criteria.List<HesapHareket>();
    }
    public IList<HesapHareket> GetHareketTuruAndSubeKodu(string subeKodu, HesapHareketTuru hareketTuru)
    {
      ICriteria criteria = Session.CreateCriteria(typeof(HesapHareket)).Add(Expression.Eq("HareketTuru", hareketTuru)).SetMaxResults(GetMaxResult);
      ICriteria subeCriteria = criteria.CreateCriteria("Sube");
      subeCriteria.Add(NHibernate.Criterion.Expression.Eq("Id",subeKodu));
      return criteria.List<HesapHareket>();
    }
  }
}
