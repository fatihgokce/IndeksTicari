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
  public partial interface IStokCategoryManager : IManagerBase<StokCategory, string>
  {
    // Get Methods
      List<KodIsim> GetListRootCategoriesKodAndName(string categoryName);
    List<StokCategory> GetListRootCategories();
    List<KodIsim> GetListParentSubCategoryKodAndName(string parentCategoryKod, string categoryName);
    List<StokCategory> GetListParentSubCategory(string parentCategoryKod);
    List<StokCategory> GetListParentSubCategory(StokCategory category);
    List<StokCategory> GetCategoryOfAllSubCategory(StokCategory category);
  }
  public class StokCategoryManager : ManagerBase<StokCategory, string>, IStokCategoryManager
  {
      public List<StokCategory> GetListRootCategories() {
          IQuery query = Session.CreateQuery("from StokCategory cc where (cc.ParentCategory is null or cc.ParentCategory='')")
                       .SetMaxResults(GetMaxResult);
          return query.List<StokCategory>() as List<StokCategory>;
      }

      public List<KodIsim> GetListRootCategoriesKodAndName(string categoryName)
    {
          KodIsim kodIsim = null;
          return Session.QueryOver<StokCategory>().Where(x => x.ParentCategory==null 
              && (x.Id.IsLike(categoryName, MatchMode.Anywhere) || x.CategoryName.IsLike(categoryName, MatchMode.Anywhere)))
              .SelectList(liste =>
                  liste.SelectGroup(c => c.Id).WithAlias(() => kodIsim.Kod)
                  .SelectGroup(c => c.CategoryName).WithAlias(() => kodIsim.Isim)

              ).TransformUsing(Transformers.AliasToBean<KodIsim>())
              .Take(GetMaxResult).List<KodIsim>() as List<KodIsim>;
     
    }
    public List<KodIsim> GetListParentSubCategoryKodAndName(string parentCategoryKod, string categoryName)
    {
          KodIsim kodIsim = null;      
          return Session.QueryOver<StokCategory>().Where(x => x.ParentCategory.Id==parentCategoryKod
              && (x.Id.IsLike(categoryName, MatchMode.Anywhere) || x.CategoryName.IsLike(categoryName, MatchMode.Anywhere)))
              .SelectList(liste =>
                  liste.SelectGroup(c => c.Id).WithAlias(() => kodIsim.Kod)
                  .SelectGroup(c => c.CategoryName).WithAlias(() => kodIsim.Isim)

              ).TransformUsing(Transformers.AliasToBean<KodIsim>())
              .Take(GetMaxResult).List<KodIsim>() as List<KodIsim>;
        
    }
    public List<StokCategory> GetListParentSubCategory(string parentCategoryKod) {
        IQuery query = Session.CreateQuery("from StokCategory cc where cc.ParentCategory.Id=:pid ")
                  .SetString("pid", parentCategoryKod).SetMaxResults(GetMaxResult);
        return query.List<StokCategory>() as List<StokCategory>;
    }
    public List<StokCategory> GetListParentSubCategory(StokCategory category) {
        return GetListParentSubCategory(category.Id);

    }
    List<StokCategory> retVal;
    public List<StokCategory> GetCategoryOfAllSubCategory(StokCategory category) {
        retVal = new List<StokCategory>();
        GetAllSubCategorys(category);
        return retVal;
    }
    void GetAllSubCategorys(StokCategory cat) {
        List<StokCategory> lisSubCategorys = GetListParentSubCategory(cat);
        foreach (StokCategory ca in lisSubCategorys) {
            retVal.Add(ca);
            GetAllSubCategorys(ca);
        }
    }
  }
}
