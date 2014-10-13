using System;
using System.Collections;
using System.Collections.Generic;

using Indeks.Data.Base;

namespace Indeks.Data.BusinessObjects
{
  public enum FTIRSIP : byte
  {
    SatisFat = 1, AlisFat, SatisIrs, AlisIrs, MusSip, SaticiSip,DirektSatis
  }
  public enum FatTipi : byte
  {
    KapaliFat = 1, AcikFat, MuhtelifFat, IadeFat,KrediKarti, ZayiIadeFat
  }
  public class FatIrsUst : BusinessBase<int>
  {
    #region Declarations
    private FTIRSIP _ftirsip;
    private string _fatirsNo = null;
    private System.DateTime _tarih;
    private FatTipi _fatTipi;
    private bool? _kdvDahilmi = null;
    //private Cari _cari = null;
    private Sube _sube = null;
    //private IList<StokHareket> _stokHarekets = new List<StokHareket>();		
    #endregion
    #region Constructors
    public FatIrsUst() { }
    #endregion
    #region Methods
    public override int GetHashCode()
    {
      System.Text.StringBuilder sb = new System.Text.StringBuilder();
      sb.Append(this.GetType().FullName);
      sb.Append(_ftirsip);
      sb.Append(_fatirsNo);
      sb.Append(_tarih);
      sb.Append(_fatTipi);
      sb.Append(_kdvDahilmi);
      sb.Append(CariKodu);
      sb.Append(KdvTutar);
      sb.Append(BrutTutar);
      sb.Append(GenelToplam);
      sb.Append(SatirIsk);
      sb.Append(KasaKodu);
      sb.Append(Irsaliyeli);
      sb.Append(IrsaliyeNo);
      sb.Append(VadeTarih);
      sb.Append(HesapNo);
      sb.Append(SevkTarihi);
      sb.Append(Kapatilmis);
      return sb.ToString().GetHashCode();
    }
    #endregion
    #region Properties
    public virtual string HesapNo { get; set; }
    public virtual DateTime? VadeTarih { get; set; }
    public virtual string CariKodu { get; set; }
    public virtual double? KdvTutar { get; set; }
    public virtual double? BrutTutar { get; set; }
    public virtual double? GenelToplam { get; set; }
    public virtual double? SatirIsk { get; set; }
    public virtual string KasaKodu { get; set; }
    public virtual bool Irsaliyeli { get; set; }
    public virtual string IrsaliyeNo { get; set; }
    public virtual DateTime? SevkTarihi { get; set; }
    //İrsaliyeden faturalaştırılan faturalar için S kodlanır
    public virtual string Kapatilmis { get; set; }
    public virtual FTIRSIP Ftirsip
    {
      get { return _ftirsip; }
      set
      {
        _ftirsip = value;
      }
    }
    public virtual string FatirsNo
    {
      get { return _fatirsNo; }
      set
      {
        _fatirsNo = value;
      }
    }
    public virtual System.DateTime Tarih
    {
      get { return _tarih; }
      set
      {
        _tarih = value;
      }
    }


    public virtual FatTipi FatTipi
    {
      get { return _fatTipi; }
      set
      {
        _fatTipi = value;
      }
    }
    public virtual bool? KdvDahilmi
    {
      get { return _kdvDahilmi; }
      set
      {
        _kdvDahilmi = value;
      }
    }

    //public virtual Cari Cari
    //    {
    //        get { return _cari; }
    //  set
    //  {
    //    OnCariChanging();
    //    _cari = value;
    //    OnCariChanged();
    //  }
    //    }
    //partial void OnCariChanging();
    //partial void OnCariChanged();
    public virtual Sube Sube
    {
      get { return _sube; }
      set
      {
        _sube = value;
      }
    }
    //public virtual IList<StokHareket> StokHarekets
    //    {
    //        get { return _stokHarekets; }
    //        set
    //  {
    //    OnStokHareketsChanging();
    //    _stokHarekets = value;
    //    OnStokHareketsChanged();
    //  }
    //    }
    //partial void OnStokHareketsChanging();
    //partial void OnStokHareketsChanged();
    //public virtual void AddStokHareket(StokHareket stokHareket)
    //{
    //  if (stokHareket != null && !StokHarekets.Contains(stokHareket))
    //    StokHarekets.Add(stokHareket);
    //}
    //public virtual void RemoveStokHareket(StokHareket stokHareket)
    //{
    //  if (StokHarekets.Contains(stokHareket))
    //    StokHarekets.Remove(stokHareket);
    //}
    #endregion
  }
}
