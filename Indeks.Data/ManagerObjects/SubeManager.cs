using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using Indeks.Data.BusinessObjects;
using Indeks.Data.Base;

namespace Indeks.Data.ManagerObjects
{
  public partial interface ISubeManager : IManagerBase<Sube, string>
  {
    IList<Sube> GetSpeedSube();
  }

  partial class SubeManager : ManagerBase<Sube, string>, ISubeManager
  {
    #region Constructors
    public SubeManager()
      : base()
    {
    }
    #endregion
    #region Get Methods
    public IList<Sube> GetSpeedSube()
    {
      SessionSimple ss = new SessionSimple();
      IList<Sube> liste = ss.GetSession().CreateCriteria<Sube>().List<Sube>();
      ss.CloseSession();
      return liste;

    }
    #endregion
  }
}