using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using Indeks.Data.Report;
namespace Indeks.Views
{
  //struct HesaplaGenelToplam
  //{
  //  IList<StokHarRpr> _listStokHar;
  //  private bool _kdvDahil;
  //  public HesaplaGenelToplam(IList<StokHarRpr>listeStokHar,bool kdvDahil)
  //  {
  //    _kdvDahil = kdvDahil;
  //    _listStokHar = listeStokHar;
  //  }
  //  private double SatisAlisFiyat(StokHarRpr sh)
  //  {
  //    return sh.Fiyat * sh.Miktar;
  //  }
  //  private double KalemKdvHesapla(StokHarRpr sh)
  //  {
  //    if (_kdvDahil)
  //    {
  //      return (SatisAlisFiyat(sh) * sh.KdvOrani) / (100 +sh.KdvOrani);
  //    }
  //    else
  //      return (SatisAlisFiyat(sh) * sh.KdvOrani) / 100;      
  //  }
  //  public double BrutHesapla()
  //  {
  //    double res = 0;
  //    foreach (StokHarRpr sh in _listStokHar)
  //    {
  //      if (_kdvDahil)
  //        res += SatisAlisFiyat(sh);
  //      else
  //        res += SatisAlisFiyat(sh) + KalemKdvHesapla(sh);
  //    }
  //    return res;
  //  }
  //  private double KalemBrutHes(StokHarRpr sh)
  //  {
  //    if (_kdvDahil)
  //      return SatisAlisFiyat(sh);
  //    else
  //      return SatisAlisFiyat(sh) + KalemKdvHesapla(sh); ;
  //  }
  //  private double NetTutar(StokHarRpr sh)
  //  {
  //    return KalemBrutHes(sh) - KalemKdvHesapla(sh);
  //  }
  //  public double SatirIskantosuToplam()
  //  {
  //    double res = 0;
  //    double toplam = 0;         
  //    foreach (StokHarRpr sh in _listStokHar)
  //    {
  //      res = NetTutar(sh);
  //      if (sh.Isk1 > 0)
  //      {
  //        toplam+=(res*sh.Isk1)/100;
  //        res = res - (res * sh.Isk1) / 100;
  //      }
  //      if (sh.Isk2 > 0)
  //      {
  //        toplam += (res * sh.Isk2) / 100;
  //        res = res - (res * sh.Isk2) / 100;
  //      }
  //      if (sh.Isk3 > 0)
  //      {
  //        toplam += (res * sh.Isk3) / 100;
  //        res = res - (res * sh.Isk3) / 100;
  //      }
  //    }
  //    return toplam;
  //  }
  //  public double ToplamaKdvHesapla()
  //  {
  //    double toplam = 0;
  //    foreach(StokHarRpr sh in _listStokHar)
  //    {
  //      if (_kdvDahil)
  //        toplam += (SatisAlisFiyat(sh)*sh.KdvOrani)/(100+sh.KdvOrani);
  //      else
  //        toplam+=(SatisAlisFiyat(sh)*sh.KdvOrani)/100;
  //    }
  //    return toplam;   
  //  }
  //  public double GenelToplam()
  //  {
  //    return AraToplam() + ToplamaKdvHesapla();
  //  }
  //  public double AraToplam()
  //  {
  //    return BrutHesapla() - (ToplamaKdvHesapla() + SatirIskantosuToplam());
  //  }
  //}
}
