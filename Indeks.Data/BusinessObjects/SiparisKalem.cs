using System;
using System.Collections.Generic;

using System.Text;
using Indeks.Data.Base;
namespace Indeks.Data.BusinessObjects
{
  public class SiparisKalem:BusinessBase<int>
  {

    public virtual double? GCMik { get; set; }
    public virtual string GCKod{get;set;}
    public virtual DateTime Tarih { get; set; }
    public virtual double? BirimFiyat { get; set; }
    public virtual string FisNo { get; set; }
    public virtual double? KdvOrani { get; set; }
    public virtual double? Isk1 { get; set; }
    public virtual double? Isk2 { get; set; }
    public virtual double? Isk3 { get; set; }
    public virtual double? Isk4 { get; set; }
    public virtual double? Isk5 { get; set; }
    public virtual FTIRSIP Ftirsip { get; set; }
    public virtual string HareketBirim { get; set; }
    public virtual double? HareketMiktar { get; set; }
    public virtual Stok Stok{get;set;}
    public virtual Sube Sube { get; set; }
    #region Methods
    public override int GetHashCode()
    {
      System.Text.StringBuilder sb = new System.Text.StringBuilder();
      sb.Append(this.GetType().FullName);
      sb.Append(GCMik);
      sb.Append(GCKod);
      sb.Append(Tarih);
      sb.Append(BirimFiyat);
      sb.Append(FisNo);
      sb.Append(KdvOrani);
      sb.Append(Isk1);
      sb.Append(Isk2);
      sb.Append(Isk3);
      sb.Append(Isk4);
      sb.Append(Isk5);
      sb.Append(FisNo);     
      sb.Append(Ftirsip);
      sb.Append(HareketBirim);
      sb.Append(HareketMiktar);
      return sb.ToString().GetHashCode();
    }
    #endregion

  }
}
