using System;
using System.Collections.Generic;
using System.Text;
using Indeks.Data.Base;
namespace Indeks.Data.BusinessObjects
{
  public class StokBirim:BusinessBase<int>
  {
    public virtual string Birim { get; set; }
    public override int GetHashCode()
    {
      System.Text.StringBuilder sb = new System.Text.StringBuilder();
      sb.Append(this.GetType().FullName);
      sb.Append(Birim);      
      return sb.ToString().GetHashCode();
    }
  }
}
