using System;
using System.Collections.Generic;

using System.Text;

namespace Indeks.Data.Report
{
  public class StokHarRpr
  {
    public virtual string Barkod { get; set; }
    public virtual int Id { get; set; }
    public virtual string StokKodu { get; set; }
    public virtual string StokAdi { get; set; }
    public virtual double HareketMiktar { get; set; }
    public virtual string HareketBirim { get; set; }
    public virtual double Miktar { get; set; }
    public virtual double Fiyat { get; set; }
    public virtual double Isk1 { get; set; }
    public virtual double Isk2 { get; set; }
    public virtual double Isk3 { get; set; }
    public virtual double Isk4 { get; set; }
    public virtual double Isk5 { get; set; }
    public virtual double Tutar { get; set; }
    public virtual double KdvOrani { get; set; }
    private StokHarRpr() { }
    public StokHarRpr(string barkod,int id, string stKodu, string stAdi,double harMiktar,string harBirim, double miktar, double fiyat, double isk1, double isk2, double isk3,
      double isk4, double isk5,double tutar
      ,double kdvOrani)
    {
      HareketMiktar = harMiktar; HareketBirim = harBirim;
      Barkod = barkod;
      Id = id; this.KdvOrani = kdvOrani;
      StokKodu = stKodu;
      StokAdi = stAdi; Miktar = miktar; Fiyat = fiyat; Isk1 = isk1; Isk2 = isk2; Isk3 = isk3; Isk4 = isk4; Isk5 = isk5;
      Tutar = tutar;
     
    }
  }
}
