using System;
using System.Collections.Generic;

using System.Text;
using Indeks.Data.Base;
namespace Indeks.Data.BusinessObjects
{
  public class SiparisUst:BusinessBase<int>
  {
    public virtual DateTime? VadeTarih { get; set; }
    public virtual string CariKodu { get; set; }
    public virtual double? KdvTutar { get; set; }
    public virtual double? BrutTutar { get; set; }
    public virtual double? GenelToplam { get; set; }
    public virtual double? SatirIsk { get; set; }    
    public virtual FTIRSIP Ftirsip { get; set; }
    public virtual string FatirsNo { get; set; }
    public virtual System.DateTime Tarih { get; set; }
    public virtual System.DateTime TeslimTarih { get; set; }
    //siparişten faturalaştırılan faturalar için
    public virtual bool Kapatilmis { get; set; }
    public virtual bool KdvDahilmi { get; set; }
    public virtual Sube Sube { get; set; }  
  
    #region Methods
    public override int GetHashCode()
    {
      System.Text.StringBuilder sb = new System.Text.StringBuilder();
      sb.Append(this.GetType().FullName);
      sb.Append(VadeTarih);
      sb.Append(CariKodu);
      sb.Append(KdvTutar);
      sb.Append(BrutTutar);
      sb.Append(GenelToplam);
      sb.Append(SatirIsk);
      sb.Append(Ftirsip);
      sb.Append(FatirsNo);
      sb.Append(Tarih);
      sb.Append(TeslimTarih);
      sb.Append(Kapatilmis);
      sb.Append(KdvDahilmi);   
    
      return sb.ToString().GetHashCode();
    }
    #endregion
  }
}
