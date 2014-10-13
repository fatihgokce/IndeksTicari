using System;
using System.Collections.Generic;

using System.Text;
using Indeks.Data.Base;
namespace Indeks.Data.BusinessObjects
{
  public class DizaynKalem:BusinessBase<int>
  {
    public virtual DizaynGenel DizaynGenel { get; set; }
    public virtual string SahaYeri { get; set; }
    public virtual bool BaslikYaz { get; set; }
    public virtual string Aciklama { get; set; }
    public virtual byte Satir { get; set; }
    public virtual byte Sutun { get; set; }
    public virtual byte? Uzunluk { get; set; }
    public virtual byte? Ondalik { get; set; }
    //public virtual byte AlanNo { get; set; }
    public virtual string AlanIsim { get; set; }
    public override int GetHashCode()
    {
      System.Text.StringBuilder sb = new System.Text.StringBuilder();
      sb.Append(this.GetType().FullName);
      sb.Append(SahaYeri);
      sb.Append(BaslikYaz);
      sb.Append(Aciklama);
      sb.Append(Satir);
      sb.Append(Sutun);
      sb.Append(Uzunluk);
      sb.Append(Ondalik);
      //sb.Append(AlanNo);
      sb.Append(AlanIsim);     
      return sb.ToString().GetHashCode();
    }
  }
}
