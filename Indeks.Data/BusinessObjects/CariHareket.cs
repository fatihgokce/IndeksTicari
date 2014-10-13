using System;
using System.Collections.Generic;

using System.Text;
using Indeks.Data.Base;
namespace Indeks.Data.BusinessObjects
{
  public enum CariHarTuru
  {
    Devir=1,
    NakitTahsilat,NakitOdeme,
    AlinanMal,SatilanMal,AlinanMalIadesi
    ,SatilanMalIadesi,
    AlinanCek,VerilenCek,CekCirosu,AlinanCekIade,
    VerilenCekGeriAlinmasi, KarsiliksizCek, AlinanSenet,
    VerilenSenet,SenetCirosu,AlinanSenetIade,
    VerilenSenetGeriAlinmasi,
    KarsiliksizSenet,Veresiye,
    GelenHavale,GonderilenHavale
  }
  public class CariHareket:BusinessBase<int>
  {
      //private static Dictionary<CariHarTuru, string> _mapHarTuru;

      //public CariHareket()
      //    : base() {
      //    _mapHarTuru = new Dictionary<CariHarTuru, string>
      //    {
      //       {CariHarTuru.Devir,"1"},
      //       {CariHarTuru.Devir,"2"},
      //       {CariHarTuru.Devir,"3"},
      //       {CariHarTuru.Devir,"4"},
      //       {CariHarTuru.Devir,"5"},
      //       {CariHarTuru.Devir,"6"},
      //       {CariHarTuru.Devir,"7"},
      //       {CariHarTuru.Devir,"8"},
      //       {CariHarTuru.Devir,"9"},
      //       {CariHarTuru.Devir,"10"},
      //       {CariHarTuru.Devir,"11"},
      //       {CariHarTuru.Devir,"12"},
      //    };
      //}
   
    public virtual string FisNo { get; set; }
    public virtual double Borc { get; set; }
    public virtual double Alacak { get; set; }
    public virtual DateTime Tarih { get; set; }
    public virtual Cari Cari { get; set; }
    // A-Devir(1),B-Fatura(2),C-IadeFatura(3),D-Kasa(4),E-MüsteriSeneti(5),F-BorçSeneti(6),G-MüşteriÇeki,
    //L-Muhtelif,K-Dekont,J-KarşılıksızÇek,I-ProtestoluSenet,J-KarşılıksızÇek,I-PretostuluSenet,H-BorçÇeki
    public virtual CariHarTuru? HareketTuru { get; set; }
    public virtual DateTime? VadeTarih { get; set; }
    public virtual string Aciklama { get; set; }
    public virtual int? CekSenetId { get; set; }
    public virtual Sube Sube { get; set; }
    public override int GetHashCode()
    {
      System.Text.StringBuilder sb = new System.Text.StringBuilder();

      sb.Append(this.GetType().FullName);
      sb.Append(FisNo);
      sb.Append(Alacak);
      sb.Append(Borc);
      sb.Append(Tarih);
      sb.Append(HareketTuru);
      sb.Append(VadeTarih);
      sb.Append(Aciklama);
      sb.Append(CekSenetId);
      return sb.ToString().GetHashCode();
    }
  }
}
