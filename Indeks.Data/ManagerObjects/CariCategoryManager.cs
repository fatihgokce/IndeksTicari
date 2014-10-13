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
  public partial interface ICariCategoryManager : IManagerBase<CariCategory,string>
  {
    // Get Methods
    List<KodIsim> GetListRootCategoriesKodAndName(string categoryName);
    List<KodIsim> GetListParentSubCategoryKodAndName(string parentCategoryKod,string categoryName);
    List<CariCategory> GetListRootCategories();
    List<CariCategory> GetListParentSubCategory(string parentCategoryKod);
  }
  public class CariCategoryManager:ManagerBase<CariCategory,string>,ICariCategoryManager
  {
      public List<CariCategory> GetListRootCategories() {
          IQuery query = Session.CreateQuery("from CariCategory cc where (cc.ParentCategory is null or cc.ParentCategory='')")
                       .SetMaxResults(GetMaxResult);
          return query.List<CariCategory>() as List<CariCategory>;
      }
      public List<CariCategory> GetListParentSubCategory(string parentCategoryKod) {
          IQuery query = Session.CreateQuery("from CariCategory cc where cc.ParentCategory.Id=:pid ")
                    .SetString("pid", parentCategoryKod).SetMaxResults(GetMaxResult);
          return query.List<CariCategory>() as List<CariCategory>;
      }
    public List<KodIsim> GetListRootCategoriesKodAndName(string categoryName)
    {
          KodIsim kodIsim = null;
          return Session.QueryOver<CariCategory>().Where(x => x.ParentCategory == null
              && (x.Id.IsLike(categoryName, MatchMode.Anywhere) || x.CategoryName.IsLike(categoryName, MatchMode.Anywhere)))
              .SelectList(liste =>
                  liste.SelectGroup(c => c.Id).WithAlias(() => kodIsim.Kod)
                  .SelectGroup(c => c.CategoryName).WithAlias(() => kodIsim.Isim)

              ).TransformUsing(Transformers.AliasToBean<KodIsim>())
              .Take(GetMaxResult).List<KodIsim>() as List<KodIsim>;
      //IQuery query = Session.CreateQuery("select cc.Id from CariCategory cc where (cc.ParentCategory is null or cc.ParentCategory='') and cc.Id like :cname")
      //             .SetString("cname",categoryName + "%").SetMaxResults(GetMaxResult);
      //return query.List<string>() as List<string>;
    }
    public List<KodIsim> GetListParentSubCategoryKodAndName(string parentCategoryKod, string categoryName)
    {
        KodIsim kodIsim = null;
        return Session.QueryOver<CariCategory>().Where(x => x.ParentCategory.Id == parentCategoryKod
            && (x.Id.IsLike(categoryName, MatchMode.Anywhere) || x.CategoryName.IsLike(categoryName, MatchMode.Anywhere)))
            .SelectList(liste =>
                liste.SelectGroup(c => c.Id).WithAlias(() => kodIsim.Kod)
                .SelectGroup(c => c.CategoryName).WithAlias(() => kodIsim.Isim)

            ).TransformUsing(Transformers.AliasToBean<KodIsim>())
            .Take(GetMaxResult).List<KodIsim>() as List<KodIsim>;
      //IQuery query = Session.CreateQuery("select cc.Id from CariCategory cc where cc.Sube.Id=:sk and cc.ParentCategory.Id=:pid and cc.Id like :cname")
      //          .SetString("cname", categoryName + "%").SetString("pid",parentCategoryKod).SetMaxResults(GetMaxResult);

      //return query.List<string>() as List<string>;
    }
  }
}
