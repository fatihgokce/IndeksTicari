using System;
using System.Collections;
using System.Collections.Generic;

using Indeks.Data.Base;

namespace Indeks.Data.BusinessObjects
{
  public partial class Sube : BusinessBase<string>
  {
    #region Declarations

    private string _adres = null;
    private string _subeIsmi = null;
    private bool? _aktif = null;
    private string _vergiDairesi = null;
    private string _vergiNo = null;

    //private IList<Cari> _caris = new List<Cari>();
    //private IList<FaturaNo> _faturaNos = new List<FaturaNo>();
    //private IList<Stok> _stoks = new List<Stok>();

    //private IList<Kullanici> _users = new List<Kullanici>();
    //private IList<FatIrsUst> _fatIrsUsts = new List<FatIrsUst>();
    #endregion

    #region Constructors

    public Sube() { }

    #endregion

    #region Methods

    public override int GetHashCode()
    {
      System.Text.StringBuilder sb = new System.Text.StringBuilder();
      sb.Append(this.GetType().FullName);
      sb.Append(_adres);
      sb.Append(_subeIsmi);
      sb.Append(_merkezmi);
      sb.Append(_aktif);
      sb.Append(_vergiDairesi);
      sb.Append(_vergiNo);
      return sb.ToString().GetHashCode();
    }

    #endregion

    #region Properties
    public virtual string VergiDairesi
    {
      get { return _vergiDairesi; }
      set { _vergiDairesi = value; }
    }
    public virtual string VergiNo
    {
      get { return _vergiNo; }
      set { _vergiNo = value; }
    }

    public virtual string Adres
    {
      get { return _adres; }
      set
      {
        OnAdresChanging();
        _adres = value;
        OnAdresChanged();
      }
    }
    partial void OnAdresChanging();
    partial void OnAdresChanged();
    public virtual string SubeIsmi
    {
      get { return _subeIsmi; }
      set { _subeIsmi = value; }
    }
    private bool? _merkezmi = null;
    public virtual bool? Merkezmi
    {
      get { return _merkezmi; }
      set
      {
        OnMerkezmiChanging();
        _merkezmi = value;
        OnMerkezmiChanged();
      }
    }
    partial void OnMerkezmiChanging();
    partial void OnMerkezmiChanged();

    public virtual bool? Aktif
    {
      get { return _aktif; }
      set
      {
        OnAktifChanging();
        _aktif = value;
        OnAktifChanged();
      }
    }
    partial void OnAktifChanging();
    partial void OnAktifChanged();

    //public virtual IList<Cari> Caris
    //{
    //  get { return _caris; }
    //  set
    //  {
    //    OnCarisChanging();
    //    _caris = value;
    //    OnCarisChanged();
    //  }
    //}
    //partial void OnCarisChanging();
    //partial void OnCarisChanged();
    //public virtual IList<FaturaNo> FaturaNos
    //{
    //  get { return _faturaNos; }
    //  set
    //  {
    //    OnFatNosChanging();
    //    _faturaNos = value;
    //    OnFatNosChanged();
    //  }
    //}
    //partial void OnFatNosChanging();
    //partial void OnFatNosChanged();

    //public virtual IList<Stok> Stoks
    //{
    //  get { return _stoks; }
    //  set
    //  {
    //    OnStoksChanging();
    //    _stoks = value;
    //    OnStoksChanged();
    //  }
    //}
    //partial void OnStoksChanging();
    //partial void OnStoksChanged();
    //public virtual IList<Kullanici> Users
    //{
    //  get { return _users; }
    //  set
    //  {
    //    OnUsersChanging();
    //    _users = value;
    //    OnUsersChanged();
    //  }
    //}
    //partial void OnUsersChanging();
    //partial void OnUsersChanged();
    //public virtual IList<FatIrsUst> FatIrsUsts
    //{
    //  get { return _fatIrsUsts; }
    //  set
    //  {

    //    _fatIrsUsts = value;

    //  }
    //}
    public override string ToString()
    {
      return Id.ToString();
    }

    #endregion
  }
}
