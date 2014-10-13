using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using Indeks.Data.BusinessObjects;
using Indeks.Data.Base;

namespace Indeks.Data.ManagerObjects
{
  public partial interface IKurManager : IManagerBase<Kur, int>
  {
    // Get Methods
    Kur GetByKurName(string kurName);
  }

  partial class KurManager : ManagerBase<Kur, int>, IKurManager
  {
    #region Constructors
    public KurManager()
      : base()
    {
    }
    #endregion
    #region IKurManager Members
    public Kur GetByKurName(string kurName)
    {
      IQuery query = Session.CreateQuery("from Kur k where k.Isim=:kur_isim").SetString("kur_isim", kurName);
      return query.UniqueResult<Kur>();
    }
    #endregion
  }
}