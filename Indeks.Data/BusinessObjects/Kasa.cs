using System;
using System.Collections.Generic;

using System.Text;
using Indeks.Data.Base;
namespace Indeks.Data.BusinessObjects
{
  public enum DovizTipi : byte
  {
    TL,EURO,DOLAR
  }
  public class Kasa:BusinessBase<string>
  {
    private string _kasaIsmi = null;
    private DateTime? _sonDevirTarih = null;
    private double? _sonDevirTutar = null;
    private Sube _sube = null;
    private DovizTipi? _dovizTipi;   
    private IList<KasaHareket> _kasaHarekets = new List<KasaHareket>();
    public override int GetHashCode()
    {
      System.Text.StringBuilder sb = new System.Text.StringBuilder();
      sb.Append(this.GetType().FullName);
      sb.Append(_kasaIsmi);
      sb.Append(_sonDevirTarih);
      sb.Append(_dovizTipi);
      sb.Append(_sonDevirTutar);
      sb.Append(KayitTarih);
      sb.Append(SubelerdeOrtak);
      return sb.ToString().GetHashCode();
    }
    public virtual bool? SubelerdeOrtak { get; set; }
    public virtual DateTime KayitTarih { get; set; }
    public virtual DovizTipi? DovizTipi
    {
      get { return _dovizTipi; }
      set { _dovizTipi = value; }
    }
    public virtual string KasaIsmi
    {
      get { return _kasaIsmi; }
      set { _kasaIsmi = value; }
    }
    public virtual DateTime? SonDevirTarih
    {
      get { return _sonDevirTarih; }
      set { _sonDevirTarih = value; }
    }
    public virtual double? SonDevirTutar
    {
      get { return _sonDevirTutar; }
      set { _sonDevirTutar = value; }
    }
    public virtual Sube Sube
    {
      get { return _sube; }
      set { _sube = value; }
    }
    public virtual IList<KasaHareket> KasaHarekets
    {
      get { return _kasaHarekets; }
      set { _kasaHarekets = value; }
    }
    public virtual void AddKasaHareket(KasaHareket kasaHareket)
    {
      if (kasaHareket != null && !KasaHarekets.Contains(kasaHareket))
        KasaHarekets.Add(kasaHareket);
    }
    public virtual void RemoveKasaHareket(KasaHareket kasaHareket)
    {
      if (KasaHarekets.Contains(kasaHareket))
        KasaHarekets.Remove(kasaHareket);
    }
  }
}
