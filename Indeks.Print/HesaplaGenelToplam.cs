using System;
using System.Collections.Generic;
using System.Text;
using Indeks.Data.Report;
namespace Indeks.Print
{
    public class KalemToplamlari { 
    //bool _kdvDahil;
    //    StokHarRpr _kalem;
       
        
    //    public KalemToplamlari(StokHarRpr kalem, bool kdvDahil) {
    //        _kdvDahil = kdvDahil;
    //        _kalem = kalem;
    //        //SatirIskontosu = ToplamSatirIsk();
    //        //KdvTutar = KalemKdvHesapla();
    //        //BrutTutar = BrutHesapla();
    //        //AraToplam = AraToplamHesapla();
    //    }

        public static double AraToplamHesapla(StokHarRpr kalem, bool kdvDahil) {
            return BrutHesapla(kalem,kdvDahil) - KalemKdvHesapla(kalem,kdvDahil) + ToplamSatirIsk(kalem,kdvDahil);
        }
        public static double BrutHesapla(StokHarRpr kalem, bool kdvDahil) {
            double res = 0;
            if (kdvDahil) {
                res = KalemTutar(kalem) - ToplamSatirIsk(kalem,kdvDahil) ;
            } else {
                res = KalemTutar(kalem) + KalemKdvHesapla(kalem,kdvDahil) - ToplamSatirIsk(kalem,kdvDahil);            
            }           
            return res;
        }
        private static double KalemTutar(StokHarRpr kalem) {
            return kalem.Fiyat * kalem.Miktar;
        }
        public static double KalemKdvHesapla(StokHarRpr kalem, bool kdvDahil) {
            if (kdvDahil) {
                return ((KalemTutar(kalem)-ToplamSatirIsk(kalem,kdvDahil)) * kalem.KdvOrani) / (100 + kalem.KdvOrani);
            } else
                return ((KalemTutar(kalem)-ToplamSatirIsk(kalem,kdvDahil)) * kalem.KdvOrani) / 100;
        }
        private static double KalemKdvsizTutar(StokHarRpr kalem, bool kdvDahil) {
            double tutar = 0;
            if (kdvDahil)
                tutar = (kalem.Fiyat * kalem.Miktar) - (kalem.Fiyat * kalem.Miktar * kalem.KdvOrani) / 100;
            else
                tutar = kalem.Fiyat * kalem.Miktar;
            return tutar;
        }
        public static double ToplamSatirIsk(StokHarRpr kalem, bool kdvDahil) {
            double toplam = 0;
            double res = KalemKdvsizTutar(kalem,kdvDahil);
            if (kalem.Isk1 > 0) {
                toplam += (res * kalem.Isk1) / 100;
                res = res - (res * kalem.Isk1) / 100;
            }
            if (kalem.Isk2 > 0) {
                toplam += (res * kalem.Isk2) / 100;
                res = res - (res * kalem.Isk2) / 100;
            }
            if (kalem.Isk3 > 0) {
                toplam += (res * kalem.Isk3) / 100;
                res = res - (res * kalem.Isk3) / 100;
            }
            if (kalem.Isk4 > 0) {
                toplam += (res * kalem.Isk4) / 100;
                res = res - (res * kalem.Isk4) / 100;
            }
            if (kalem.Isk5 > 0) {
                toplam += (res * kalem.Isk5) / 100;
                res = res - (res * kalem.Isk5) / 100;
            }
            return toplam;
        }

    }
  public class HesaplaGenelToplam
  {
    IList<StokHarRpr> _listStokHar;

    public IList<StokHarRpr> ListStokHar
    {
      get { return _listStokHar; }
      set { _listStokHar = value; }
    }
    private bool _kdvDahil;

    public bool KdvDahil
    {
      get { return _kdvDahil; }
      set { _kdvDahil = value; }
    }
    private double KalemKdvsizTutar(StokHarRpr kalem) {
        double tutar = 0;
        if (KdvDahil)
            tutar = (kalem.Fiyat * kalem.Miktar) - (kalem.Fiyat * kalem.Miktar * kalem.KdvOrani) / 100;
        else
            tutar = kalem.Fiyat * kalem.Miktar;
        return tutar;
    }
    public HesaplaGenelToplam(IList<StokHarRpr> listeStokHar, bool kdvDahil)
    {
      _kdvDahil = kdvDahil;
      _listStokHar = listeStokHar;
    }
    
    private double SatisAlisFiyat(StokHarRpr sh)
    {
      return sh.Fiyat * sh.HareketMiktar;
    }
    private double KalemKdvHesapla(StokHarRpr sh)
    {
      if (_kdvDahil)
      {
        return (SatisAlisFiyat(sh) * sh.KdvOrani) / (100 + sh.KdvOrani);
      }
      else
        return (SatisAlisFiyat(sh) * sh.KdvOrani) / 100;
    }
    public double BrutHesapla()
    {
      double res = 0;
      foreach (StokHarRpr sh in _listStokHar)
      {
        if (_kdvDahil)
          res += SatisAlisFiyat(sh);
        else
          res += SatisAlisFiyat(sh) + KalemKdvHesapla(sh);
      }
      return res;
    }
    private double KalemBrutHes(StokHarRpr sh)
    {
      if (_kdvDahil)
        return SatisAlisFiyat(sh);
      else
        return SatisAlisFiyat(sh) + KalemKdvHesapla(sh); ;
    }
    private double NetTutar(StokHarRpr sh)
    {
      return KalemBrutHes(sh) - KalemKdvHesapla(sh);
    }
    public double SatirIskantosuToplam()
    {
    
      double toplam = 0;
      foreach (StokHarRpr sh in _listStokHar)
      {
          //KalemToplamlari kalem = new KalemToplamlari(sh,KdvDahil);
          toplam += KalemToplamlari.ToplamSatirIsk(sh,KdvDahil);
      }
      return toplam;
    }
    public double ToplamaKdvHesapla()
    {
      double toplam = 0;
      foreach (StokHarRpr sh in _listStokHar)
      {
          //KalemToplamlari kalem = new KalemToplamlari(sh, KdvDahil);
          toplam += KalemToplamlari.KalemKdvHesapla(sh,KdvDahil);
      }
      return toplam;
    }
    public double GenelToplam()
    {
      return AraToplam() + ToplamaKdvHesapla();
    }
    public double AraToplam()
    {
        double toplam = 0;
        foreach (StokHarRpr sh in _listStokHar) {
            //KalemToplamlari kalem = new KalemToplamlari(sh, KdvDahil);
            toplam += KalemToplamlari.AraToplamHesapla(sh,KdvDahil);
        }
        return toplam;
    }
  }
}
