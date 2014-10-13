using System;
using System.Collections.Generic;
using System.Text;
using Indeks.Data.BusinessObjects;
namespace Indeks.Views
{
  public class HesaplaToplam
  {
    public bool KdvDahil { get; set; }
    public Stok Stok { get; set; }   
    public double? Fiyat { get; set; }
    public double Miktar { get; set; }
    public List<double?> IskontoOranlari=new List<double?>();
    //public double ToplamBrut { get; set; }
    //public double SatirIskantosuToplam { get; set; }
    //public double GenelToplam { get; set; }
    //public double AraToplam { get; set; }
    //public double KdvToplam { get; set; }
    //  private double _netTutar;
  
    public FTIRSIP Ftirsip { get; set; }
      public HesaplaToplam(FTIRSIP ftirsip) {
        this.Ftirsip = ftirsip;
       
    }
      private double SatisAlisFiyat() {
          return Fiyat.Value * Miktar;
      }
     
    public double BrutHesapla()
    {
      bool haveFiyat=HaveFiyat();
      if (haveFiyat)
      {
        if (KdvDahil)
          return SatisAlisFiyat();
        else
          return SatisAlisFiyat() + KdvHesapla();
      }
      else
      {
        return 0;
      }

    }
    private double NetTutar()
    {
      return BrutHesapla() - KdvHesapla();
    }
    public double SatirIskantosuToplam()
    {
      double res = NetTutar();
      double toplam=0;
      for (int i = 0; i < IskontoOranlari.Count; i++)
      {
        double? d=IskontoOranlari[i];
        if(d.HasValue && d.Value>0)
        {
          toplam += (res*d.Value)/100;
          res=res-(res*d.Value)/100;
        }
        
      }
      return toplam;
    }
    public double GenelToplam()
    {
      return AraToplam() + KdvHesapla();
    }
    public double AraToplam()
    {
      return BrutHesapla()-(KdvHesapla() + SatirIskantosuToplam());
    }
    public double KdvHesapla()
    {
      if (HaveFiyat())
      {
        if (KdvDahil)
        {
            return ((SatisAlisFiyat() - SatirIskantosuToplam()) * KdvOrani()) / (100 + KdvOrani());
        }
        else
          return ((SatisAlisFiyat()-SatirIskantosuToplam()) * KdvOrani()) / 100;

      }
      else
        return 0;
    }
    
    private double KdvOrani() {
        double kdv = 0;
        if (Ftirsip == FTIRSIP.AlisFat || Ftirsip == FTIRSIP.AlisIrs || Ftirsip==FTIRSIP.SaticiSip) {
            kdv = Stok.AlisKdvOrani;
        } else
            kdv = Stok.SatisKdvOrani;
        return kdv;    
    }
    private bool HaveFiyat()
    {
      if (Fiyat.HasValue)
        return true;
      else
        return false;
    }
  }
}

