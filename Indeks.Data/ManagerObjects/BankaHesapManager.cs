using System;
using System.Collections.Generic;

using System.Text;
using NHibernate;
using Indeks.Data.BusinessObjects;
using Indeks.Data.Base;
using NHibernate.Criterion;
namespace Indeks.Data.ManagerObjects
{
  public partial interface IBankaHesapManager : IManagerBase<BankaHesap, int>
  {
    List<string> GetBankaHesapNoBySubeKodu(string subeKodu, string hesapNo);
    BankaHesap GetByHesapNo(string subeKodu,string hesapNo);
  }
  public class BankaHesapManager:ManagerBase<BankaHesap,int>,IBankaHesapManager
  {
    public List<string> GetBankaHesapNoBySubeKodu(string subeKodu, string hesapNo)
    {
      ICriteria criteria = Session.CreateCriteria(typeof(BankaHesap)).SetProjection(Projections.Property("HesapNo"))
        .Add(Expression.Like("HesapNo", hesapNo, MatchMode.Start)).SetMaxResults(GetMaxResult);
      ICriteria subeCriteria = criteria.CreateCriteria("Sube");
      subeCriteria.Add(NHibernate.Criterion.Expression.Eq("Id", subeKodu));
      return criteria.List<string>() as List<string>;
    }
    public BankaHesap GetByHesapNo(string subeKodu,string hesapNo)
    {
      ICriteria criteria = Session.CreateCriteria(typeof(BankaHesap))
       .Add(Expression.Eq("HesapNo", hesapNo));
      ICriteria subeCriteria = criteria.CreateCriteria("Sube");
      subeCriteria.Add(NHibernate.Criterion.Expression.Eq("Id", subeKodu));
      return criteria.UniqueResult<BankaHesap>();
    }
  }
}
