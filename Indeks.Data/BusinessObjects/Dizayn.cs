using System;
using System.Collections.Generic;

using System.Text;
using Indeks.Data.Base;
namespace Indeks.Data.BusinessObjects
{
  public enum DizaynTipi:byte
  {
    SatisFatura=1,SatisIrsaliye
  };
  public class Dizayn : BusinessBase<int>
  {
    public virtual Sube Sube { get; set; }
    public virtual DizaynTipi DizaynTipi { get; set; }
    public virtual string DizaynAdi { get; set; }
    public override int GetHashCode()
    {
      System.Text.StringBuilder sb = new System.Text.StringBuilder();
      sb.Append(this.GetType().FullName);
      sb.Append(DizaynTipi);
      sb.Append(DizaynAdi);
      return sb.ToString().GetHashCode();
    }
    public override string ToString()
    {
      return DizaynAdi;
    }
  }
}
