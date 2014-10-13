using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using NHibernate.Criterion;
using Indeks.Data.BusinessObjects;
using Indeks.Data.Base;
using NHibernate.Transform;

namespace Indeks.Data.ManagerObjects
{
  public partial interface IStokManager : IManagerBase<Stok, string>
  {
    // Get Methods
    IList<Stok> GetBySATISDOVIZTIPI(System.Int32 kur1);
    IList<Stok> GetByALISDOVIZTIPI(System.Int32 kur2);
    IList<Stok> GetByGRUP_KODU(System.String stokGrup);
    IList<Stok> GetByKOD1(System.String stokKod1);
    IList<Stok> GetByKOD2(System.String stokKod2);
    IList<Stok> GetByKOD3(System.String stokKod3);
    IList<Stok> GetByKOD4(System.String stokKod4);
    IList<Stok> GetBySUBE_KODU(string sube);
    List<KodIsim> StokKods(string stokKodIsim, Sube sube);
    List<Stok> SearchStokByCriter(Stok stok);
    Stok GetBySubeAndBarkod1(string subeKodu, string barkod);
  }

  partial class StokManager : ManagerBase<Stok, string>, IStokManager
  {
    #region Constructors
    public StokManager() : base() { }
    #endregion

    #region Get Methods
    public IList<Stok> GetBySATISDOVIZTIPI(System.Int32 kur1)
    {
      ICriteria criteria = Session.CreateCriteria(typeof(Stok));
      ICriteria kur1Criteria = criteria.CreateCriteria("Kur1");
      kur1Criteria.Add(NHibernate.Criterion.Expression.Eq("Id", kur1));

      return criteria.List<Stok>();
    }

    public IList<Stok> GetByALISDOVIZTIPI(System.Int32 kur2)
    {
      ICriteria criteria = Session.CreateCriteria(typeof(Stok));
      ICriteria kur2Criteria = criteria.CreateCriteria("Kur2");
      kur2Criteria.Add(NHibernate.Criterion.Expression.Eq("Id", kur2));
      return criteria.List<Stok>();
    }
    public IList<Stok> GetByGRUP_KODU(System.String stokGrup)
    {
      ICriteria criteria = Session.CreateCriteria(typeof(Stok));
      ICriteria stokGrupCriteria = criteria.CreateCriteria("StokGrup");
      stokGrupCriteria.Add(NHibernate.Criterion.Expression.Eq("Id", stokGrup));
      return criteria.List<Stok>();
    }

    public IList<Stok> GetByKOD1(System.String stokKod1)
    {
      ICriteria criteria = Session.CreateCriteria(typeof(Stok));
      ICriteria stokKod1Criteria = criteria.CreateCriteria("StokKod1");
      stokKod1Criteria.Add(NHibernate.Criterion.Expression.Eq("Id", stokKod1));
      return criteria.List<Stok>();
    }

    public IList<Stok> GetByKOD2(System.String stokKod2)
    {
      ICriteria criteria = Session.CreateCriteria(typeof(Stok));
      ICriteria stokKod2Criteria = criteria.CreateCriteria("StokKod2");
      stokKod2Criteria.Add(NHibernate.Criterion.Expression.Eq("Id", stokKod2));
      return criteria.List<Stok>();
    }

    public IList<Stok> GetByKOD3(System.String stokKod3)
    {
      ICriteria criteria = Session.CreateCriteria(typeof(Stok));
      ICriteria stokKod3Criteria = criteria.CreateCriteria("StokKod3");
      stokKod3Criteria.Add(NHibernate.Criterion.Expression.Eq("Id", stokKod3));
      return criteria.List<Stok>();
    }

    public IList<Stok> GetByKOD4(System.String stokKod4)
    {
      ICriteria criteria = Session.CreateCriteria(typeof(Stok));
      ICriteria stokKod4Criteria = criteria.CreateCriteria("StokKod4");
      stokKod4Criteria.Add(NHibernate.Criterion.Expression.Eq("Id", stokKod4));
      return criteria.List<Stok>();
    }

    public IList<Stok> GetBySUBE_KODU(string sube)
    {    
        return Session.QueryOver<Stok>().Where(x => (x.Sube.Id == sube || x.SubelerdeOrtak == true)
          ).OrderBy(x => x.KayitTarih).Desc.Take(GetMaxResult).List();
    }
    public List<KodIsim> StokKods(string stokKodIsim, Sube sube)
    {
      //ICriteria criteria = Session.CreateCriteria(typeof(Stok)).SetProjection(Projections.Property("Id"))
      //                     .Add(Expression.Like("Id", stokKod, MatchMode.Start)).SetMaxResults(GetMaxResult);
      //ICriteria subeCriteria = criteria.CreateCriteria("Sube");
      //subeCriteria.Add(NHibernate.Criterion.Expression.Eq("Id", sube.Id));
      //return criteria.List<string>() as List<string>;
      //IQuery query = Session.CreateQuery("select st.Id from Stok st where st.Sube=:sube and st.Id like :st").SetString("st", stokKod + "%").SetEntity("sube", sube).SetMaxResults(10);
      //return (List<string>)query.List<string>();
        KodIsim kodIsim = null;
        return Session.QueryOver<Stok>().Where(x => (x.Sube == sube || x.SubelerdeOrtak == true)
            && (x.Id.IsLike(stokKodIsim, MatchMode.Anywhere) || x.StokAdi.IsLike(stokKodIsim, MatchMode.Anywhere)))
            .SelectList(liste =>
                liste.SelectGroup(c => c.Id).WithAlias(() => kodIsim.Kod)
                .SelectGroup(c => c.StokAdi).WithAlias(() => kodIsim.Isim)

            ).TransformUsing(Transformers.AliasToBean<KodIsim>())
            .Take(GetMaxResult).List<KodIsim>() as List<KodIsim>;
    }
    public List<Stok> SearchStokByCriter(Stok stok)
    {
        IQueryOver<Stok, Stok> over = Session.QueryOver<Stok>().Where(x => (x.Sube.Id == stok.Sube.Id || x.SubelerdeOrtak == true));
        if (!string.IsNullOrEmpty(stok.Id))
            over.Where(s=>s.Id.IsLike(stok.Id,MatchMode.Start));
        if (!string.IsNullOrEmpty(stok.StokAdi))
            over.Where(s => s.StokAdi.IsLike(stok.StokAdi, MatchMode.Start));
        if (!string.IsNullOrEmpty(stok.Grup1.Id))
            over.Where(s => s.Grup1.Id.IsLike(stok.Grup1.Id, MatchMode.Start));
        if (!string.IsNullOrEmpty(stok.Grup2.Id))
            over.Where(s => s.Grup2.Id.IsLike(stok.Grup2.Id, MatchMode.Start));

        if (!string.IsNullOrEmpty(stok.Grup3.Id))
            over.Where(s => s.Grup3.Id.IsLike(stok.Grup3.Id, MatchMode.Start));
        if (!string.IsNullOrEmpty(stok.Grup4.Id))
            over.Where(s => s.Grup4.Id.IsLike(stok.Grup4.Id, MatchMode.Start));
        if (!string.IsNullOrEmpty(stok.Grup5.Id))
            over.Where(s => s.Grup5.Id.IsLike(stok.Grup5.Id, MatchMode.Start));
        return over.Take(GetMaxResult).List() as List<Stok>;
      
    }
    public Stok GetBySubeAndBarkod1(string subeKodu, string barkod)
    {
      ////Barkod1,Sube
      //ICriteria criter = Session.CreateCriteria<Stok>().Add(Expression.Eq("Barkod1", barkod));
      //criter.CreateCriteria("Sube").Add(Expression.Eq("Id", subeKodu));
      ////object obj= criter.List<Stok>()[0];
      ////return obj as Stok;
      //return criter.UniqueResult<Stok>();
        return SingleOrDefault<Stok>(x => (x.Sube.Id == subeKodu || x.SubelerdeOrtak == true) && x.Barkod1 == barkod);
    }
    #endregion
  }
}