using System;
using System.Collections;
using System.Collections.Generic;
using Indeks.Data.Base;
namespace Indeks.Data.BusinessObjects
{
  public partial class Cari : BusinessBase<string>
  {
    #region Declarations
    private string _cariIsim = null;
    private string _cariTel = null;
    private string _cariAdes = null;
    private string _cariEmail = null;
    private string _cariTip = string.Empty;
    private Sube _sube = null;
    //private IList<FatirsUst> _fatirsUsts = new List<FatirsUst>();
    private IList<CariHareket> _cariHarekets = new List<CariHareket>();
    #endregion
    #region Constructors

    public Cari() { }
    #endregion
    #region Methods
    public override int GetHashCode()
    {
      System.Text.StringBuilder sb = new System.Text.StringBuilder();
      sb.Append(this.GetType().FullName);
      sb.Append(_cariIsim);
      sb.Append(_cariTel);
      sb.Append(_cariAdes);
      sb.Append(_cariEmail);
      sb.Append(_cariTip);
      sb.Append(VergiDairesi);
      sb.Append(VergiNumarasi);
      sb.Append(_cariTip);
      sb.Append(CepTel);
      sb.Append(YetkiliKisi);
      sb.Append(Aktif);
      sb.Append(SubelerdeOrtak);
      sb.Append(SatisFiyatKod);
      sb.Append(AlisFiyatKod);
      return sb.ToString().GetHashCode();
    }
    #endregion
    #region Properties
    public virtual bool? SubelerdeOrtak { get; set; }
    public virtual string SatisFiyatKod { get; set; }
    public virtual string AlisFiyatKod { get; set; }
    public virtual DateTime? KayitTarih { get; set; }
    public virtual string YetkiliKisi { get; set; }
    public virtual string VergiDairesi {get;set;}
    public virtual string VergiNumarasi { get; set; }
    public virtual string Fax { get; set; }
    public virtual string WebAdresi { get; set; }
    public virtual CariCategory Grup1 { get; set; }
    public virtual CariCategory Grup2 { get; set; }
    public virtual CariCategory Grup3 { get; set; }
    public virtual CariCategory Grup4 { get; set; }
    public virtual string Il { get; set; }
    public virtual string Ilce { get; set; }
    public virtual string CepTel { get; set; }
    public virtual bool? Aktif { get; set; }
    public virtual IList<CariHareket> CariHarekets
    {
      get { return _cariHarekets; }
      set { _cariHarekets = value; }
    }
    public virtual string CariTip
    {
      get { return _cariTip; }
      set { _cariTip = value; }
    }
    public virtual string CariIsim
    {
      get { return _cariIsim; }
      set
      {
        _cariIsim = value;
      }
    }
    public virtual string CariTel
    {
      get { return _cariTel; }
      set
      {
        OnCariTelChanging();
        _cariTel = value;
        OnCariTelChanged();
      }
    }
    partial void OnCariTelChanging();
    partial void OnCariTelChanged();

    public virtual string CariAdres
    {
      get { return _cariAdes; }
      set
      {
        OnCariAdresChanging();
        _cariAdes = value;
        OnCariAdresChanged();
      }
    }
    partial void OnCariAdresChanging();
    partial void OnCariAdresChanged();

    public virtual string CariEmail
    {
      get { return _cariEmail; }
      set
      {
        OnCariEmailChanging();
        _cariEmail = value;
        OnCariEmailChanged();
      }
    }
    partial void OnCariEmailChanging();
    partial void OnCariEmailChanged();

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

    //public virtual IList<FatirsUst> FatirsUsts
    //    {
    //        get { return _fatirsUsts; }
    //        set
    //  {
    //    OnFatirsUstsChanging();
    //    _fatirsUsts = value;
    //    OnFatirsUstsChanged();
    //  }
    //    }
    //partial void OnFatirsUstsChanging();
    //partial void OnFatirsUstsChanged();
    //public virtual void AddFatirsUst(FatirsUst fatirsUst)
    //{
    //  if (fatirsUst != null && !FatirsUsts.Contains(fatirsUst))
    //    FatirsUsts.Add(fatirsUst);
    //}
    //public virtual void RemoveFatirsUst(FatirsUst fatirsUst)
    //{
    //  if (FatirsUsts.Contains(fatirsUst))
    //    FatirsUsts.Remove(fatirsUst);
    //}

    #endregion
  }
}
