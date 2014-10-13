using System;
using System.Collections;
using System.Collections.Generic;

using Indeks.Data.Base;

namespace Indeks.Data.BusinessObjects
{
  public partial class Kur : BusinessBase<int>
  {
    #region Declarations
    private string _isim = null;
    //private IList<Stok> _stokSatisDov = new List<Stok>();
    //private IList<Stok> _stokAlisDov = new List<Stok>();
    #endregion
    #region Constructors
    public Kur() { }
    #endregion
    #region Methods
    public override int GetHashCode()
    {
      System.Text.StringBuilder sb = new System.Text.StringBuilder();

      sb.Append(this.GetType().FullName);
      sb.Append(_isim);

      return sb.ToString().GetHashCode();
    }
    #endregion
    #region Properties
    public virtual string Isim
    {
      get { return _isim; }
      set
      {
        OnIsimChanging();
        _isim = value;
        OnIsimChanged();
      }
    }
    partial void OnIsimChanging();
    partial void OnIsimChanged();
    //public virtual IList<Stok> StokSatisDov
    //{
    //  get { return _stokSatisDov; }
    //  set
    //  {
    //    OnStoks1Changing();
    //    _stokSatisDov = value;
    //    OnStoks1Changed();
    //  }
    //}
    //partial void OnStoks1Changing();
    //partial void OnStoks1Changed();
    //public virtual IList<Stok> StokAlisDov
    //{
    //  get { return _stokAlisDov; }
    //  set
    //  {
    //    OnStoks2Changing();
    //    _stokAlisDov = value;
    //    OnStoks2Changed();
    //  }
    //}
    //partial void OnStoks2Changing();
    //partial void OnStoks2Changed();
    #endregion
  }
}
