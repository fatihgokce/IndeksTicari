using System;
using System.Collections.Generic;
using System.Text;
using Indeks.Data.BusinessObjects;
using Indeks.Data.Base;
using NHibernate;
using NHibernate.Criterion;
using System.Data;
using Indeks.Data.Helper;
namespace Indeks.Data.ManagerObjects
{
  public interface IStokBirimManager : IManagerBase<StokBirim, int>
  {
    void TopluHareketBirimDegistir(string yeniBirim,string eskiBirim);
  }
  public class StokBirimManager:ManagerBase<StokBirim,int>,IStokBirimManager
  {

    #region IStokBirimManager Members
    public void TopluHareketBirimDegistir(string yeniBirim, string eskiBirim)
    {
     
      IDbConnection con = Session.Connection;
      IDbCommand cmd = con.CreateCommand();
      string query = "update  Stok set AnaBirim='"+yeniBirim+"' where AnaBirim='"+eskiBirim+"' ;";
      query += "update  Stok set AltBirim1='" + yeniBirim + "' where AltBirim1='" + eskiBirim + "'; ";
      query += "update  Stok set AltBirim2='" + yeniBirim + "' where AltBirim2='" + eskiBirim + "'; ";
      query += "update  Stok set AltBirim3='" + yeniBirim + "' where AltBirim3='" + eskiBirim + "'; ";
      query += "update  StokHareket set HareketBirim='" + yeniBirim + "' where HareketBirim='" + eskiBirim + "'; ";
      query += "update  SiparisKalem set HareketBirim='" + yeniBirim + "' where HareketBirim='" + eskiBirim + "'; ";
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
    #endregion
  }
}
