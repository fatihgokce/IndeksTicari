using System;
using System.Collections.Generic;

using System.Text;
using Indeks.Data.Base;
namespace Indeks.Data.BusinessObjects
{
  public class BankaHesap:BusinessBase<int>
  {
    public virtual string HesapNo { get; set; }
    public virtual string BankaAdi { get; set; }
    public virtual string HesapSahibi { get; set; }
    public virtual string SubeAdi { get; set; }
    public virtual string ParaBirimi { get; set; }
    public virtual Sube Sube { get; set; }
    #region Methods
    public override int GetHashCode()
    {
      System.Text.StringBuilder sb = new System.Text.StringBuilder();
      sb.Append(this.GetType().FullName);
      sb.Append(BankaAdi);
      sb.Append(HesapSahibi);
      sb.Append(ParaBirimi);
      sb.Append(HesapNo);
      sb.Append(SubeAdi);      
      return sb.ToString().GetHashCode();
    }
    #endregion
  }
}
