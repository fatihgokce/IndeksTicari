using System;
using System.Collections.Generic;

using System.Text;
using Indeks.Data.Base;

namespace Indeks.Data.BusinessObjects
{
  public enum HesapHareketTuru
  {
    ParaYatirma =1,ParaCekme,GelenHavale,GonderilenHavale,KrediKarti,
      CekOdeme,CekTahsil,SenetTahsil
  }
  public class HesapHareket:BusinessBase<int>
  {
    public virtual DateTime Tarih{get;set;}
    public virtual string DekontNo { get; set; }
    public virtual double Tutar { get; set; }
    public virtual string Aciklama { get; set; }
    public virtual HesapHareketTuru HareketTuru { get; set; }
    public virtual string KasaKod { get; set; }
    public virtual int? KasaHarId { get; set; }
    public virtual string CariKod { get; set; }
    public virtual int? CariHarId { get; set; }
    public virtual string FisNo { get; set; }
    public virtual int? CekSenetId { get; set; }
    public virtual BankaHesap BankaHesap { get; set; }
    public virtual Sube Sube { get; set; }
    #region Methods
    public override int GetHashCode()
    {      
      System.Text.StringBuilder sb = new System.Text.StringBuilder();
      sb.Append(this.GetType().FullName);
      sb.Append(Tarih);
      sb.Append(DekontNo);
      sb.Append(Tutar);
      sb.Append(Aciklama);
      sb.Append(HareketTuru);
      sb.Append(FisNo);
      sb.Append(CekSenetId);
      return sb.ToString().GetHashCode();
    }
   
    #endregion
  }
}
