using System;
using System.Collections.Generic;

using System.Text;
using NHibernate;
using Indeks.Data.BusinessObjects;
using Indeks.Data.Base;
using NHibernate.Criterion;
namespace Indeks.Data.ManagerObjects
{
  public partial interface IDizaynKalemManager : IManagerBase<DizaynKalem, int>
  {
    List<DizaynKalem> GetByDizaynGenelNo(int dizaynGenelNo);
  }
  public class DizaynKalemManager: ManagerBase<DizaynKalem,int>, IDizaynKalemManager
  {
    #region IDizaynKalemManager Members
    public List<DizaynKalem> GetByDizaynGenelNo(int dizaynGenelNo)
    {
      ICriteria criteria = Session.CreateCriteria(typeof(DizaynKalem));
      ICriteria subeCriteria = criteria.CreateCriteria("DizaynGenel");
      subeCriteria.Add(NHibernate.Criterion.Expression.Eq("Id", dizaynGenelNo));
      return criteria.List<DizaynKalem>() as List<DizaynKalem>;
    }
    #endregion
  }
}
