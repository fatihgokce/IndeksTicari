using System;
using System.Collections.Generic;

using System.Text;
using Indeks.Data.Base;
namespace Indeks.Data.BusinessObjects
{
  public enum KasaGelirGider:byte
  {
    Gider=0,Gelir
  }
  //Tipi gösterir. Banka ise 'B', Cari ise 'C', Çek ise 'E', Fatura ise 'F', Muhtelif ise 'M', Senet ise 'S', Transfer ise 'T' değerini gösterir.

  public enum KasaHarTip : byte
  {
    //BankaParaCekme=1,BankaParaYatirma,CariTahsil,CariOdeme,MalAlis,MalSatis,Cek,Senet,Muhtelif,Transfer
    Banka,Cari,Cek,Fatura,Senet,Muhtelif,Transfer,Ozel
  }
  public class KasaHareket:BusinessBase<int>
  {
    private string _gelirGider = null;
    private string _tip = null;
    private string _fisNo = null;
    private int? _kulNo = null;
    private double? _kdvTutar = null;
    private double? _kdvOrani = null;
    private Kasa _kasa = null;
    public override int GetHashCode()
    {
      System.Text.StringBuilder sb = new System.Text.StringBuilder();
      sb.Append(this.GetType().FullName);
      sb.Append(_gelirGider);
      sb.Append(_tip);
      sb.Append(_kulNo);
      sb.Append(_kdvOrani);
      sb.Append(_kdvTutar);
      sb.Append(Aciklama);
      sb.Append(Tarih);
      sb.Append(DirektSatis);
      sb.Append(CekSenetId);
      sb.Append(OzelGelirGiderKod);
      return sb.ToString().GetHashCode();
    }
    public virtual string OzelGelirGiderKod { get; set; }
    public virtual Sube Sube { get; set; }
    public virtual string DirektSatis { get; set; }
    public virtual DateTime? Tarih { get; set; }
    public virtual string Aciklama { get; set; }
    public virtual double Tutar { get; set; }
    public virtual int? CekSenetId { get; set; }
    public virtual string GelirGider
    {
      get { return _gelirGider; }
      set { _gelirGider = value; }
    }
    public virtual string Tip
    {
      get { return _tip; }
      set { _tip = value; }
    }
    public virtual string FisNo
    {
      get { return _fisNo; }
      set { _fisNo = value; }
    }
    public virtual int? KulNo
    {
      get { return _kulNo; }
      set { _kulNo = value; }
    }
    public virtual double? KdvOrani
    {
      get { return _kdvOrani; }
      set { _kdvOrani = value; }
    }
    public virtual double? KdvTutar
    {
      get { return _kdvTutar; }
      set { _kdvTutar = value; }
    }
    public virtual Kasa Kasa
    {
      get { return _kasa; }
      set { _kasa = value; }
    }
//    Tipi gösterir. Banka ise 'B', Cari ise 'C', Çek ise 'E', Fatura ise 'F', Muhtelif ise 'M', Senet ise 'S', Transfer ise 'T' değerini gösterir.
    public static string DetermineGelirGider(KasaGelirGider gelirGider) {
        if (KasaGelirGider.Gelir == gelirGider)
            return "G";
        else
            return "C";
    }
    public static string DetermineTip(KasaHarTip harTip)
    {
       //BankaParaCekme=1,BankaParaYatirma,CariTahsil,CariOdeme,MalAlis,MalSatis,Cek,Senet,Muhtelif,Transfer
      
      //if (harTip == KasaHarTip.BankaParaCekme)
      //  return "1";
      //else if (harTip == KasaHarTip.BankaParaYatirma)
      //  return "2";
      //else if (harTip == KasaHarTip.CariTahsil)
      //  return "3";
      //else if (harTip == KasaHarTip.CariOdeme)
      //  return "4";
      //else if (harTip == KasaHarTip.MalAlis)
      //  return "5";
      //else if (harTip == KasaHarTip.MalSatis)
      //  return "6";
      //else
      //  return "M";
      //Tipi gösterir. Banka ise 'B', Cari ise 'C', Çek ise 'E', Fatura ise 'F', Muhtelif ise 'M', Senet ise 'S', Transfer ise 'T' değerini gösterir.
        if (harTip == KasaHarTip.Banka)
            return "B";
        else if (harTip == KasaHarTip.Cari)
            return "C";
        else if (harTip == KasaHarTip.Fatura)
            return "F";
        else if (harTip == KasaHarTip.Cek)
            return "E";
        else if (harTip == KasaHarTip.Senet)
            return "S";
        else if (harTip == KasaHarTip.Muhtelif)
            return "M";
        else if (harTip == KasaHarTip.Transfer)
            return "T";
        else if (harTip == KasaHarTip.Ozel)
            return "O";
      return "";

    }
  }
}
