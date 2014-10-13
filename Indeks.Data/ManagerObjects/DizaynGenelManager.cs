using System;
using System.Collections.Generic;

using System.Text;
using NHibernate;
using Indeks.Data.BusinessObjects;
using Indeks.Data.Base;
using NHibernate.Criterion;
namespace Indeks.Data.ManagerObjects
{
  public partial interface IDizaynGenelManager : IManagerBase<DizaynGenel,int>
  {
    DizaynGenel GetByDizaynNo(int dizaynNo);
  }
  public class DizaynGenelManager : ManagerBase<DizaynGenel,int>, IDizaynGenelManager
  {
    #region IDizaynGenelManager Members
    public DizaynGenel GetByDizaynNo(int dizaynNo)
    {
      ICriteria criteria = Session.CreateCriteria(typeof(DizaynGenel));
      ICriteria dizaynCriteria = criteria.CreateCriteria("Dizayn");
      dizaynCriteria.Add(NHibernate.Criterion.Expression.Eq("Id",dizaynNo));
      return criteria.UniqueResult<DizaynGenel>();
    }
    #endregion
  }
}
