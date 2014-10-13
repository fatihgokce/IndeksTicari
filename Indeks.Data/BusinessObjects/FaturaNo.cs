using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using Indeks.Data.Base;

namespace Indeks.Data.BusinessObjects
{
  //public enum FatNoTip:byte
  //{
  //  Fatura=1,Irsaliye,Siparis
  //}
  //public partial class FaturaNo : BusinessBase<int>
  //{
  //  #region Declarations

  //  private string _tip = null;
  //  private string _numara = null;

  //  private Sube _sube = null;


  //  #endregion

  //  #region Constructors

  //  public FaturaNo() { }

  //  #endregion

  //  #region Methods

  //  public override int GetHashCode()
  //  {
  //    System.Text.StringBuilder sb = new System.Text.StringBuilder();

  //    sb.Append(this.GetType().FullName);
  //    sb.Append(_tip);
  //    sb.Append(_numara);
  //    return sb.ToString().GetHashCode();
  //  }

  //  #endregion

  //  #region Properties

  //  public virtual string Tip
  //  {
  //    get { return _tip; }
  //    set
  //    {
  //      OnTipChanging();
  //      _tip = value;
  //      OnTipChanged();
  //    }
  //  }
  //  partial void OnTipChanging();
  //  partial void OnTipChanged();

  //  public virtual string Numara
  //  {
  //    get { return _numara; }
  //    set
  //    {
  //      OnNumaraChanging();
  //      _numara = value;
  //      OnNumaraChanged();
  //    }
  //  }
  //  partial void OnNumaraChanging();
  //  partial void OnNumaraChanged();

  //  public virtual Sube Sube
  //  {
  //    get { return _sube; }
  //    set
  //    {
  //      OnSubeChanging();
  //      _sube = value;
  //      OnSubeChanged();
  //    }
  //  }
  //  partial void OnSubeChanging();
  //  partial void OnSubeChanged();

  //  #endregion
  //}
}