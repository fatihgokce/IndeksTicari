using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using Indeks.Data.BusinessObjects;
using Indeks.Data.Base;
using NHibernate.Criterion;
using NHibernate.Transform;
namespace Indeks.Data.ManagerObjects
{
  public partial interface ICariManager : IManagerBase<Cari, string>
  {
    // Get Methods
    IList<Cari> GetBySUBE_KODU(string sube);
    //List<string> GetCariKodsBySubeKodu(string subeKodu, string cariKod);
    //List<string> GetCariKodsBySubeKodu(string subeKodu, string cariKod,FTIRSIP ftirsip);
    List<KodIsim> GetCariKodsBySubeKodu(string subeKodu, string cariKodIsim);
    List<KodIsim> GetCariKodsBySubeKodu(string subeKodu, string cariKodIsim, FTIRSIP ftirsip);
    List<Cari> SearchCariByCriter(Cari cari);
  }

  partial class CariManager : ManagerBase<Cari, string>, ICariManager
  {
    #region Constructors
    public CariManager() : base() { }
    #endregion

    #region Get Methods
    public List<KodIsim> GetCariKodsBySubeKodu(string subeKodu, string cariKodIsim) {
        KodIsim kodIsim=null;
        return Session.QueryOver<Cari>().Where(x => (x.Sube.Id == subeKodu || x.SubelerdeOrtak == true)
            && (x.Id.IsLike(cariKodIsim, MatchMode.Anywhere) || x.CariIsim.IsLike(cariKodIsim,MatchMode.Anywhere)))
            .SelectList(liste =>
                liste.SelectGroup(c => c.Id).WithAlias(() => kodIsim.Kod)
                .SelectGroup(c => c.CariIsim).WithAlias(() => kodIsim.Isim)

            ).TransformUsing(Transformers.AliasToBean<KodIsim>())
            .Take(GetMaxResult).List<KodIsim>() as List<KodIsim>;

          
    }
    public List<KodIsim> GetCariKodsBySubeKodu(string subeKodu, string cariKodIsim, FTIRSIP ftirsip) {
        KodIsim kodIsim=null;
        IQueryOver<Cari,Cari>over= Session.QueryOver<Cari>().Where(x => (x.Sube.Id == subeKodu || x.SubelerdeOrtak == true)
           && (x.Id.IsLike(cariKodIsim, MatchMode.Anywhere) || x.CariIsim.IsLike(cariKodIsim, MatchMode.Anywhere)));
          if(FTIRSIP.AlisFat==ftirsip || FTIRSIP.AlisIrs==ftirsip)
              over.And(x=>(x.CariTip=="S" || x.CariTip=="AS"));
          else if(FTIRSIP.SatisFat==ftirsip || FTIRSIP.SatisIrs==ftirsip)
              over.And(x=>(x.CariTip=="A" || x.CariTip=="AS"));
        return over.SelectList(liste=>
            liste.SelectGroup(c=>c.Id).WithAlias(()=>kodIsim.Kod)
            .SelectGroup(c=>c.CariIsim).WithAlias(()=>kodIsim.Isim)
            ).TransformUsing(Transformers.AliasToBean<KodIsim>())
            .Take(GetMaxResult).List<KodIsim>() as List<KodIsim>;
       
    }
  
    public IList<Cari> GetBySUBE_KODU(string sube)
    {    
        return Session.QueryOver<Cari>().Where(x => (x.Sube.Id == sube || x.SubelerdeOrtak == true)
            ).OrderBy(x => x.KayitTarih).Desc.Take(GetMaxResult).List();
    }
    public List<Cari> SearchCariByCriter(Cari cari)
    {
      IQueryOver<Cari,Cari> over = Session.QueryOver<Cari>().Where(x => (x.Sube.Id == cari.Sube.Id || x.SubelerdeOrtak == true));
      if (!string.IsNullOrEmpty(cari.Id))
          over.Where(x => x.Id.IsLike(cari.Id, MatchMode.Start));
      if (!string.IsNullOrEmpty(cari.CariIsim))
          over.Where(x => x.CariIsim.IsLike(cari.CariIsim, MatchMode.Start));
      if (!string.IsNullOrEmpty(cari.CariTip))
          over.Where(x => x.CariTip.IsLike(cari.CariTip, MatchMode.Start));
      if (!string.IsNullOrEmpty(cari.Grup1.Id))
          over.Where(x => x.Grup1.Id.IsLike(cari.Grup1.Id, MatchMode.Start));
      if (!string.IsNullOrEmpty(cari.Grup2.Id))
          over.Where(x => x.Grup2.Id.IsLike(cari.Grup2.Id, MatchMode.Start));
      if (!string.IsNullOrEmpty(cari.Grup3.Id))
          over.Where(x => x.Grup3.Id.IsLike(cari.Grup3.Id, MatchMode.Start));
      if (!string.IsNullOrEmpty(cari.Grup4.Id))
          over.Where(x => x.Grup4.Id.IsLike(cari.Grup4.Id, MatchMode.Start));
      return over.Take(GetMaxResult).List() as List<Cari>;
     
    }
    #endregion
  }
}