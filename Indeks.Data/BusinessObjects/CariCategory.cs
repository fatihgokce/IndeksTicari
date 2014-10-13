using System;
using System.Collections.Generic;
using System.Text;
using Indeks.Data.Base;

namespace Indeks.Data.BusinessObjects
{
  public class CariCategory:BusinessBase<string>
  {
    public virtual string CategoryName { get; set; }
    public virtual CariCategory ParentCategory { get; set; }
    //ISet<CariCategory> _childCategories = new HashedSet<CariCategory>();
    private ICollection<CariCategory> _childCategories = new HashSet<CariCategory>();
    public virtual Sube Sube { get; set; }
    //public virtual ISet<CariCategory> ChildCategories
    //{
    //  get { return _childCategories; }
    //  set { _childCategories = value; }
    //}
    public virtual ICollection<CariCategory> ChildCategories {
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
