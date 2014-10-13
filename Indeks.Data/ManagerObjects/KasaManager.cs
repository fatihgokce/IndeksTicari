using System;
using System.Collections.Generic;

using System.Text;
using Indeks.Data.BusinessObjects;
using Indeks.Data.Base;
using NHibernate.Criterion;
using Indeks.Data.Report;
using NHibernate;
namespace Indeks.Data.ManagerObjects
{
  public partial interface IKasaManager : IManagerBase<Kasa,string>
  {
    List<Kasa> GetKasaBySubeKodu(string subeKodu);
    List<string> GetKasaKodsBySubeKodu(string subeKodu, string kasaKod);
  }
  public class KasaManager:ManagerBase<Kasa,string>,IKasaManager
  {

    #region IKasaManager Members
    public List<Kasa> GetKasaBySubeKodu(string subeKodu)
    {
      ICriteria criteria = Session.CreateCriteria(typeof(Kasa));
      ICriteria subeCriteria = criteria.CreateCriteria("Sube");
      subeCriteria.Add(NHibernate.Criterion.Expression.Eq("Id", subeKodu));
      return criteria.List<Kasa>() as List<Kasa>;
    }
    public List<string> GetKasaKodsBySubeKodu(string subeKodu, string kasaKod)
    {
      ICriteria criteria = Session.CreateCriteria(typeof(Kasa)).SetProjection(Projections.Property("Id"))
        .Add(Expression.Like("Id", kasaKod, MatchMode.Start)).SetMaxResults(GetMaxResult);
      ICriteria subeCriteria = criteria.CreateCriteria("Sube");
      subeCriteria.Add(NHibernate.Criterion.Expression.Eq("Id", subeKodu));
      return criteria.List<string>() as List<string>;
    }
    #endregion
  }
}
