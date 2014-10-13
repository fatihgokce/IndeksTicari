using System;
using System.Collections.Generic;

using System.Text;
using Indeks.Data.Base;
//using Iesi.Collections.Generic;
namespace Indeks.Data.BusinessObjects
{
  public class StokCategory : BusinessBase<string>
  {
    public virtual string CategoryName { get; set; }
    public virtual StokCategory ParentCategory { get; set; }
    //ISet<StokCategory> _childCategories = new HashedSet<StokCategory>();
    private ICollection<StokCategory> _childCategories = new HashSet<StokCategory>();
    public virtual Sube Sube { get; set; }
    public virtual ICollection<StokCategory> ChildCategories
    {
      get { return _childCategories; }
      set { _childCategories = value; }
    }
    public override int GetHashCode()
    {
      System.Text.StringBuilder sb = new System.Text.StringBuilder();
      sb.Append(this.GetType().FullName);
      sb.Append(CategoryName);
      return sb.ToString().GetHashCode();
    }
  }
}
