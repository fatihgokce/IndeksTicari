using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using Indeks.Data.BusinessObjects;
using Indeks.Data.Base;

namespace Indeks.Data.ManagerObjects
{
  public partial interface IKullaniciManager : IManagerBase<Kullanici, int>
  {
    // Get Methods
    IList<Kullanici> GetBySEBE_KODU(string sube);
    Kullanici GetKullaniciByUserNamePassword(string password, string userName, string subeKodu);
  }

  partial class KullaniciManager : ManagerBase<Kullanici, int>, IKullaniciManager
  {
    #region Constructors
    public KullaniciManager()
      : base()
    {
    }
    #endregion
    #region Get Methods
    public IList<Kullanici> GetBySEBE_KODU(string sube)
    {
      ICriteria criteria = Session.CreateCriteria(typeof(Kullanici));
      ICriteria subeCriteria = criteria.CreateCriteria("Sube");
      subeCriteria.Add(NHibernate.Criterion.Expression.Eq("Id", sube));
      return criteria.List<Kullanici>();
    }
    public Kullanici GetKullaniciByUserNamePassword(string password, string userName, string subeKodu)
    {
      IQuery query = Session.CreateQuery("from Kullanici k where k.Password=:pass and k.UserName=:uname and (k.Sube.Id=:skodu or k.SubelerdeOrtak=true)")
                     .SetString("pass", password).SetString("uname", userName).SetString("skodu", subeKodu);
      return query.UniqueResult<Kullanici>();
    }
    #endregion
  }
}