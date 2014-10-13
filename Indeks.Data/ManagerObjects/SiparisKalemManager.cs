using System;
using System.Collections.Generic;

using System.Text;
using NHibernate;
using Indeks.Data.BusinessObjects;
using Indeks.Data.Base;
using NHibernate.Criterion;
using Indeks.Data.Report;
using System.Data;
namespace Indeks.Data.ManagerObjects
{
  public partial interface ISiparisKalemManager : IManagerBase<SiparisKalem, int>
  {
    // Get Methods
    //IList<FatIrsUst> GetByCARI_KODU(System.String cari);
    //List<string> GetByBelgeTipAndSubeKodu(string subeKodu, FTIRSIP ftirsip, string fatNo);
    //FatIrsUst GetByBelgeNoBelgeTipAndSubeKodu(string belgeNo, FTIRSIP ftirsip, string subeKodu);
    //string GetLastArtiOneFatIrsNoBySubeKoduAndFtirsip(string subeKodu, FTIRSIP ftirsip);
    //List<FatIrsUst> GetListByFtirsip(FTIRSIP ftirsip);
    //List<FatIrsUst> GetListByCriter(FatIrsUst fat, DateTime? dtTarBas, DateTime? dtTarBit, DateTime? dtVadeBas, DateTime? dtVadeBit);
    IList<StokHarRpr> GetByFisNoAndSubeKodu(string fisNo, string subeKodu, FTIRSIP ftirsip);
    void TopluKalemSil(string fisNo, FTIRSIP ftirsip);
  }
  class SiparisKalemManager: ManagerBase<SiparisKalem, int>, ISiparisKalemManager
  {
    public void TopluKalemSil(string fisNo, FTIRSIP ftirsip)
    {
      byte ftir = (byte)ftirsip;
      IDbConnection con = Session.Connection;
      IDbCommand cmd = con.CreateCommand();
      string query = "delete from SiparisKalem where FTIRSIP=" + ftir + " and FisNo='" + fisNo + "' ";
      cmd.CommandText = query;
      IDbTransaction trs = con.BeginTransaction();
      cmd.Connection = con;
      cmd.Transaction = trs;
      try
      {
        cmd.ExecuteNonQuery();
        trs.Commit();
      }
      catch
      {
        trs.Rollback();
        throw;
      }
    }
    public IList<StokHarRpr> GetByFisNoAndSubeKodu(string fisNo, string subeKodu, FTIRSIP ftirsip)
    {
        //IQuery criter = Session.CreateQuery("select new StokHarRpr(sh.Stok.Barkod1,sh.Id,sh.Stok.Id,sh.Stok.StokAdi,sh.HareketMiktar,sh.HareketBirim,sh.GCMiktar,sh.BirimFiyat,sh.Isk1,sh.Isk2,sh.Isk3,sh.Isk4,sh.Isk5,sh.HareketMiktar*sh.BirimFiyat,sh.Kdv) from StokHareket sh where sh.FisNo=:fis and sh.Sube.Id=:sk").SetString("fis", fisNo).SetString("sk", subeKodu);
        IQuery criter = Session.CreateQuery("select new StokHarRpr(sh.Stok.Barkod1,sh.Id,sh.Stok.Id,sh.Stok.StokAdi,sh.HareketMiktar,sh.HareketBirim,sh.GCMik,sh.BirimFiyat,sh.Isk1,sh.Isk2,sh.Isk3,sh.Isk4,sh.Isk5,sh.HareketMiktar*sh.BirimFiyat,sh.KdvOrani) from SiparisKalem sh where sh.FisNo=:fis and sh.Ftirsip=:ftirsip and sh.Sube.Id=:subeKodu").SetString("fis", fisNo).SetString("subeKodu", subeKodu).SetEnum("ftirsip", ftirsip);
      return criter.List<StokHarRpr>();    
    }
  }
}
