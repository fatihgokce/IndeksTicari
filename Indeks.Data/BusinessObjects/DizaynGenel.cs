using System;
using System.Collections.Generic;

using System.Text;
using Indeks.Data.Base;
namespace Indeks.Data.BusinessObjects
{
  public class DizaynGenel:BusinessBase<int>
  {
    private IList<DizaynKalem> _dizaynKalems = new List<DizaynKalem>();

    public virtual IList<DizaynKalem> DizaynKalems
    {
      get { return _dizaynKalems; }
      set { _dizaynKalems = value; }
    }
    public virtual byte SatSay { get; set; }
    public virtual byte SutSay { get; set; }
    public virtual byte? MaxKalemAdedi { get; set; }
    public virtual byte? KalBasSat { get; set; }
    public virtual string TopKalSonunda { get; set; }
    public virtual byte? TopBasSat { get; set; }
    public virtual byte BasimAdedi { get; set; }
    public virtual bool BaskiOnizleme { get; set; }
    public virtual float FontBuyukluk { get; set; }
    public virtual string FontAdi { get; set; }
    public virtual string YaziciAdi { get; set; }
    public virtual bool Yataymi { get; set; }
    public virtual Dizayn Dizayn { get; set; }
    public override int GetHashCode()
    {
      System.Text.StringBuilder sb = new System.Text.StringBuilder();
      sb.Append(this.GetType().FullName);
      sb.Append(SatSay);
      sb.Append(SutSay);
      sb.Append(MaxKalemAdedi);
      sb.Append(KalBasSat);
      sb.Append(TopKalSonunda);
      sb.Append(BasimAdedi);
      sb.Append(BaskiOnizleme);
      sb.Append(FontBuyukluk);
      sb.Append(FontAdi);
      sb.Append(YaziciAdi);
      sb.Append(TopBasSat);
      sb.Append(Yataymi);
      return sb.ToString().GetHashCode();
    }
  }
}
