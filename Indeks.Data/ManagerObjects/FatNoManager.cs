using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using Indeks.Data.BusinessObjects;
using Indeks.Data.Base;
using NHibernate.Criterion;
using Indeks.Data.Helper;
namespace Indeks.Data.ManagerObjects
{
  //public partial interface IFaturaNoManager : IManagerBase<FaturaNo, int>
  //{
  //  // Get Methods
  //  IList<FaturaNo> GetBySUBE_KODU(string sube);
  //  string GetLastFatNoBySubeKoduAndFatNoTip(string subeKodu, string fatNoTip);
  //  List<string> GetFatNumaraBySubeKoduAndFatNoTip(string fatNo, string subeKodu, string fatNoTip);
  //}


  //partial class FaturaNoManager : ManagerBase<FaturaNo, int>, IFaturaNoManager
  //{
  //  #region Constructors
  //  public FaturaNoManager()
  //    : base()
  //  {
  //  }
  //  #endregion
  //  public List<string> StokKods(string stokKod, Sube sube)
  //  {
  //    IQuery query = Session.CreateQuery("select st.Id from Stok st where st.Sube=:sube and st.StokAdi like :st").SetString("st", stokKod + "%").SetEntity("sube", sube).SetMaxResults(10);
  //    return (List<string>)query.List<string>();
  //  }
  //  #region Get Methods

  //  public List<string> GetFatNumaraBySubeKoduAndFatNoTip(string fatNo, string subeKodu, string fatNoTip)
  //  {
  //    ICriteria criteria = Session.CreateCriteria<FaturaNo>().SetProjection(Projections.Property("Numara")).Add(Expression.Eq("Tip", fatNoTip)).Add(Expression.Like("Numara", fatNo, MatchMode.Start)).AddOrder(Order.Desc("Id"));
  //    ICriteria subCriter = criteria.CreateCriteria("Sube").Add(Expression.Eq("Id", subeKodu));
  //    return criteria.List<string>() as List<string>;
  //  }
  //  public IList<FaturaNo> GetBySUBE_KODU(string sube)
  //  {
  //    ICriteria criteria = Session.CreateCriteria(typeof(FaturaNo));
  //    ICriteria subeCriteria = criteria.CreateCriteria("Sube");
  //    subeCriteria.Add(NHibernate.Criterion.Expression.Eq("Id", sube));
  //    return criteria.List<FaturaNo>();
  //  }
  //  public string GetLastFatNoBySubeKoduAndFatNoTip(string subeKodu, string fatNoTip)
  //  {
  //    ICriteria criteria = Session.CreateCriteria<FaturaNo>().SetProjection(Projections.Property("Numara")).Add(Expression.Eq("Tip", fatNoTip)).AddOrder(Order.Desc("Id")).SetMaxResults(1);
  //    ICriteria subCriter = criteria.CreateCriteria("Sube").Add(Expression.Eq("Id", subeKodu));
  //    return criteria.UniqueResult() as string;
  //  }
  //  #endregion
  //}
}