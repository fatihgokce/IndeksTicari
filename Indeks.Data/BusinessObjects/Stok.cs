using System;
using System.Collections;
using System.Collections.Generic;

using Indeks.Data.Base;

namespace Indeks.Data.BusinessObjects
{
  public partial class Stok : BusinessBase<string>
  {
    #region Declarations
    private string _stokAdi = null;
    private double? _kdvOrani = null;
    private int? _azamiMiktar = null;
    private int? _asgariMiktar = null;

    private string _barkod1 = null;
    private string _barkod2 = null;
    private string _barkod3 = null;
   
  

    //private Kur _satDovTipi = null;
    //private Kur _alisDovTipi = null; 
    private Sube _sube = null;

    private IList<StokHareket> _stokHarekets = new List<StokHareket>();

    #endregion
    #region Constructors

    public Stok() { }

    #endregion
    #region Methods
    public override int GetHashCode()
    {
      System.Text.StringBuilder sb = new System.Text.StringBuilder();

      sb.Append(this.GetType().FullName);
      sb.Append(_stokAdi);
      sb.Append(_kdvOrani);
      sb.Append(_azamiMiktar);
      sb.Append(_asgariMiktar);

      sb.Append(_barkod1);
      sb.Append(_barkod2);
      sb.Append(_barkod3);
      sb.Append(AlisFiyat1);
      sb.Append(AlisFiyat2);
      sb.Append(AlisFiyat3);
      sb.Append(SatisFiyat1);
      sb.Append(SatisFiyat2);
      sb.Append(SatisFiyat3);
      sb.Append(AnaBirim);
      sb.Append(AltBirim1);
      sb.Append(AltBirim2);
      sb.Append(AltBirim3);
      sb.Append(Carpan1);
      sb.Append(Carpan2);
      sb.Append(Carpan3);
      sb.Append(KayitTarih);
      sb.Append(SubelerdeOrtak);
      sb.Append(Aktif);
      sb.Append(AlisKdvOrani);
      sb.Append(SatisKdvOrani);
      return sb.ToString().GetHashCode();
    }
    #endregion
    #region Properties
    public virtual double AlisKdvOrani { get; set; }
    public virtual double SatisKdvOrani { get; set; }
    public virtual bool? SubelerdeOrtak { get; set; }
    public virtual double? AlisFiyat1 { get; set; }
    public virtual double? AlisFiyat2 { get; set; }
    public virtual double? AlisFiyat3 { get; set; }
    public virtual double? SatisFiyat1 { get; set; }
    public virtual double? SatisFiyat2 { get; set; }
    public virtual double? SatisFiyat3 { get; set; }
    public virtual string AnaBirim { get; set; }
    public virtual string AltBirim1 { get; set; }
    public virtual double? Carpan1 { get; set; }
    public virtual string AltBirim2 { get; set; }
    public virtual double? Carpan2 { get; set; }
    public virtual string AltBirim3 { get; set; }
    public virtual double? Carpan3 { get; set; }
    public virtual DateTime? KayitTarih { get; set; }
    public virtual StokCategory Grup1 { get; set; }
    public virtual StokCategory Grup2 { get; set; }
    public virtual StokCategory Grup3 { get; set; }
    public virtual StokCategory Grup4 { get; set; }
    public virtual StokCategory Grup5 { get; set; }
    public virtual bool? Aktif { get; set; }
    public virtual string StokAdi
    {
      get { return _stokAdi; }
      set
      {
        OnStokAdiChanging();
        _stokAdi = value;
        OnStokAdiChanged();
      }
    }
    partial void OnStokAdiChanging();
    partial void OnStokAdiChanged();

    public virtual double? KdvOrani
    {
      get { return _kdvOrani; }
      set
      {
        _kdvOrani = value;
      }
    }
    public virtual int? AzamiMiktar
    {
      get { return _azamiMiktar; }
      set
      {
        OnAzamiMiktarChanging();
        _azamiMiktar = value;
        OnAzamiMiktarChanged();
      }
    }
    partial void OnAzamiMiktarChanging();
    partial void OnAzamiMiktarChanged();

    public virtual int? AsgariMiktar
    {
      get { return _asgariMiktar; }
      set
      {
        OnAsgariMiktarChanging();
        _asgariMiktar = value;
        OnAsgariMiktarChanged();
      }
    }
    partial void OnAsgariMiktarChanging();
    partial void OnAsgariMiktarChanged();



    public virtual string Barkod1
    {
      get { return _barkod1; }
      set
      {
        OnBarkod1Changing();
        _barkod1 = value;
        OnBarkod1Changed();
      }
    }
    partial void OnBarkod1Changing();
    partial void OnBarkod1Changed();

    public virtual string Barkod2
    {
      get { return _barkod2; }
      set
      {
        OnBarkod2Changing();
        _barkod2 = value;
        OnBarkod2Changed();
      }
    }
    partial void OnBarkod2Changing();
    partial void OnBarkod2Changed();

    public virtual string Barkod3
    {
      get { return _barkod3; }
      set
      {
        OnBarkod3Changing();
        _barkod3 = value;
        OnBarkod3Changed();
      }
    }
    partial void OnBarkod3Changing();
    partial void OnBarkod3Changed();

   

    //public virtual Kur SatDovTipi
    //{
    //  get { return _satDovTipi; }
    //  set
    //  {
    //    OnKur1Changing();
    //    _satDovTipi = value;
    //    OnKur1Changed();
    //  }
    //}
    //partial void OnKur1Changing();
    //partial void OnKur1Changed();

    //public virtual Kur AlisDovTipi
    //{
    //  get { return _alisDovTipi; }
    //  set
    //  {
    //    OnKur2Changing();
    //    _alisDovTipi = value;
    //    OnKur2Changed();
    //  }
    //}
    //partial void OnKur2Changing();
    //partial void OnKur2Changed();
    public virtual Sube Sube
    {
      get { return _sube; }
      set
      {
        OnSubeChanging();
        _sube = value;
        OnSubeChanged();
      }
    }
    partial void OnSubeChanging();
    partial void OnSubeChanged();

    public virtual IList<StokHareket> StokHarekets
    {
      get { return _stokHarekets; }
      set
      {
        OnStokHareketsChanging();
        _stokHarekets = value;
        OnStokHareketsChanged();
      }
    }
    partial void OnStokHareketsChanging();
    partial void OnStokHareketsChanged();
    public virtual void AddStokHareket(StokHareket stokHareket)
    {
      if (stokHareket != null && !StokHarekets.Contains(stokHareket))
        StokHarekets.Add(stokHareket);
    }
    public virtual void RemoveStokHareket(StokHareket stokHareket)
    {
      if (StokHarekets.Contains(stokHareket))
        StokHarekets.Remove(stokHareket);
    }
    #endregion
  }
}
