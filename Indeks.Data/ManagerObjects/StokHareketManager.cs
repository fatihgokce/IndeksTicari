using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using Indeks.Data.BusinessObjects;
using Indeks.Data.Base;
using NHibernate.Criterion;
using Indeks.Data.Report;
using System.Data.SqlClient;
using System.Data;
using NHibernate.Transform;
using Indeks.Data.Helper;
using System.Linq;
namespace Indeks.Data.ManagerObjects
{
  public partial interface IStokHareketManager : IManagerBase<StokHareket, int>
  {
    // Get Methods  
    IList<StokHarRpr> GetByFisNoAndSubeKodu(string fisNo, string subeKodu, FTIRSIP ftirsip);
    IList<StokHarRpr> GetByFisNoAndSubeKodu(string fisNo,string subeKodu);
    IList<StokHareket> GetByStokHareket_DOVTIP(System.Int32 kur);
    IList<StokHareket> GetBySTOK_KODU(System.String stok);
    double GetStokMiktar(string stokKodu);
    void UpdateStokHarByFisNoAndFtirsip(string fisNo, FTIRSIP ftirsip, FTIRSIP desFtirsip,string desFisNo);
    DataTable StokHareketDokumu(string subeKodu,string stokKodu,string GCKod, DateTime startDate, DateTime finishDate);
    DataTable StokHareketDokumu(string subeKodu, string stokKodu, string GCKod);
    string GetLastArtiOneFisNoBySubeKodu(string subeKodu);
    DataTable StokAlisSatisRapor(string subeKodu, string stokKodu, DateTime startDate, DateTime finishDate,string GCKod);
    DataTable StokDurumRapor(string subeKodu, string stokKodu);
    DataTable StokDurumRapor(string subeKodu);
    void TopluHareketSil(string fisNo, FTIRSIP ftirsip);
    DataTable StokOrtalamaAlisSatisFiyatlariRaporu(string subeKodu, string GCKod);
    DataTable StokOrtalamaAlisSatisFiyatlariRaporu(string subeKodu, string GCKod, string stokKodu, DateTime? startDate, DateTime? finishDate);
    DataTable StokMalMaliyetRaporu(string subeKodu);
    DataTable StokMalMaliyetRaporu(string subeKodu, string stokKodu);
    DataTable StokMalMaliyetRaporu(string subeKodu, string stokKodu, DateTime? startDate, DateTime? finishDate);
    DataTable StokMalMaliyetRaporu(string subeKodu, string stokKodu,string stokGrup, DateTime? startDate, DateTime? finishDate);
    double OrtalamaAlisFiyatinaGoreStokDegeri(string subeKodu, DateTime? beginDate, DateTime? endDate);
  }
  partial class StokHareketManager : ManagerBase<StokHareket, int>, IStokHareketManager
  {
    #region Constructors
    public StokHareketManager()
      : base()
    {
    }
    #endregion   
    public double OrtalamaAlisFiyatinaGoreStokDegeri(string subeKodu, DateTime? beginDate, DateTime? endDate) {
        DataTable data = StokMalMaliyetRaporu(subeKodu, "", beginDate, endDate);
        double toplam = 0;
        for (int i=0;i<data.Rows.Count;i++) {
            var item = data.Rows[i];
            double oa = double.Parse(item["OrtalamaAlisFiyat"].ToStringOrEmpty("0"));
            double mik = double.Parse(item["KalanMiktar"].ToStringOrEmpty("0"));
            double deger = oa * mik;
            toplam += deger;
        }
        return toplam;
    }
    public DataTable StokMalMaliyetRaporu(string subeKodu) {
        return StokMalMaliyetRaporu(subeKodu,"");
    }
    public DataTable StokMalMaliyetRaporu(string subeKodu, string stokKodu) {
        return StokMalMaliyetRaporu(subeKodu,stokKodu,null,null);
    }
    public DataTable StokMalMaliyetRaporu(string subeKodu, string stokKodu, DateTime? startDate, DateTime? finishDate) {
        return StokMalMaliyetRaporu(subeKodu,stokKodu,"",startDate,finishDate);
    }
    public DataTable StokMalMaliyetRaporu(string subeKodu, string stokKodu,string stokGrup, DateTime? startDate, DateTime? finishDate) {
        IDbConnection con = Session.Connection;
        IDbCommand cmd = con.CreateCommand();
        StringBuilder query = new StringBuilder();
        query.AppendFormat(@" SELECT st.STOK_KODU StokKodu,st.STOK_ADI StokIsmi,
sum(case when sh.GCKOD='G' then sh.GCMIK else 0 end) as AlışMiktar,
sum(case when sh.GCKOD='C' then sh.GCMIK else 0 end) as SatişMiktar,
sum(case when sh.GCKOD='G' then (sh.BIRIM_FIYAT*sh.GCMIK)
end)/
sum(case when (sh.GCMIK<>0 and sh.GCKOD='G') then sh.GCMIK  end ) as OrtalamaAlışFiyat
,
sum(case when sh.GCKOD='C' then (sh.BIRIM_FIYAT*sh.GCMIK)
end)/
sum(case when (sh.GCMIK<>0 and sh.GCKOD='C') then sh.GCMIK  end ) as OrtalamaSatışFiyat
FROM  StokHareket sh INNER JOIN
                      Stok st ON sh.STOK_KODU = st.STOK_KODU
where (st.SUBE_KODU='{0}' or st.SubelerdeOrtak=1)
 ", subeKodu);
        if (!string.IsNullOrEmpty(stokGrup)) {
            IStokCategoryManager mng=new StokCategoryManager();
            StokCategory sc=mng.GetById(stokGrup,false);
            StringBuilder qin = new StringBuilder();
            List<string> ary = mng.GetCategoryOfAllSubCategory(sc).Select(x => x.Id).ToList();
            ary.Insert(0,string.Format("{0}" ,stokGrup));
            foreach (var item in ary) {
                qin.AppendFormat("'{0}'",item); qin.Append(",");
            }
            qin.Remove(qin.Length - 1, 1);
            query.AppendFormat(" and (st.Grup1 in({0}) or st.Grup2 in({0}) or st.Grup3 in({0}) or st.Grup4 in({0}) )",qin);

        }
        if (startDate.HasValue && finishDate.HasValue)
            query.AppendFormat(" and {0} between '{1}' and '{2}'  ", SqlTypeHelper.GetDate("sh.TARIH"), startDate.Value.JustDate().ToString("yyyy-MM-dd"), finishDate.Value.JustDate().ToString("yyyy-MM-dd"));
        if (!string.IsNullOrEmpty(stokKodu))
            query.AppendFormat(" and st.STOK_KODU='{0}'", stokKodu);
        query.Append(" group by st.STOK_KODU,st.STOK_ADI");
        cmd.CommandText = query.ToString();
        IDataReader dread = null;
        DataTable dt = new DataTable();
        try {
            dread = cmd.ExecuteReader();
            dt.Columns.AddRange(
                                new DataColumn[]
                          {
                            new DataColumn("StokKodu",typeof(string)),
                             new DataColumn("StokIsmi",typeof(string)),
                            new DataColumn("AlisMiktar",typeof(double)),
                             new DataColumn("SatisMiktar",typeof(double)),
                              new DataColumn("KalanMiktar",typeof(double)),
                            new DataColumn("OrtalamaAlisFiyat",typeof(double)),
                           new DataColumn("OrtalamaSatisFiyat",typeof(double)),
                           new DataColumn("AlisTutar",typeof(double)),
                           new DataColumn("SatisTutar",typeof(double)),
                           new DataColumn("YuzdeKarOranı",typeof(double)),
                           new DataColumn("KalanMalinMaliyeti",typeof(double))
                          }
                               );
            while (dread.Read()) {
                DataRow dr = dt.NewRow();
                dr[0] = dread[0].ToStringOrEmpty();
                dr[1] = dread[1].ToStringOrEmpty();
                dr[2] = dread[2].ToStringOrEmpty("0");
                dr[3] = dread[3].ToStringOrEmpty("0");
                dr[4] = (double.Parse(dread[2].ToStringOrEmpty("0")) - double.Parse(dread[3].ToStringOrEmpty("0"))).ToString("F2");
                dr[5] =double.Parse( dread[4].ToStringOrEmpty("0")).ToString("F2");
                dr[6] =double.Parse(dread[5].ToStringOrEmpty("0")).ToString("F2");
                dr[7] =(double.Parse(dr[2].ToStringOrEmpty("0")) * double.Parse(dr[5].ToStringOrEmpty("0"))).ToString("F2");
                dr[8] = (double.Parse(dr[3].ToStringOrEmpty("0")) * double.Parse(dr[6].ToStringOrEmpty("0"))).ToString("F2");                
                double oa=double.Parse(dr[5].ToStringOrEmpty("0"));
                double os=double.Parse(dr[6].ToStringOrEmpty("0"));
                dr[9] = (((os-oa)/oa)*100).ToString("F2");
                dr[10] = (oa * double.Parse(dr[4].ToString())).ToStringOrEmpty("0");
                dt.Rows.Add(dr);
            }
        } catch (Exception exc) { throw exc; } finally {
            if (dread != null && !dread.IsClosed)
                dread.Close();
        }
        return dt;
    }
      public DataTable StokOrtalamaAlisSatisFiyatlariRaporu(string subeKodu, string GCKod) {
        return StokOrtalamaAlisSatisFiyatlariRaporu(subeKodu, GCKod, "", null, null);
    }
    public DataTable StokOrtalamaAlisSatisFiyatlariRaporu(string subeKodu, string GCKod, string stokKodu, DateTime? startDate, DateTime? finishDate) {
        IDbConnection con = Session.Connection;
        IDbCommand cmd = con.CreateCommand();
        StringBuilder query = new StringBuilder();
        query.AppendFormat(@" SELECT st.STOK_KODU StokKodu,st.STOK_ADI StokIsmi,Miktar=sum(sh.GCMIK),OrtalamaFiyat=(
sum(sh.BIRIM_FIYAT*sh.GCMIK)/sum(sh.GCMIK)),
ToplamFiyat=sum(sh.GCMIK)*(
sum(sh.BIRIM_FIYAT*sh.GCMIK)/sum(sh.GCMIK))
FROM  StokHareket sh INNER JOIN
      Stok st ON sh.STOK_KODU = st.STOK_KODU
where (st.SUBE_KODU={0} or st.SubelerdeOrtak=1) and sh.GCKOD='{1}'
group by st.STOK_KODU,st.STOK_ADI ", subeKodu, GCKod);
        if(startDate.HasValue && finishDate.HasValue)
            query.AppendFormat(" {0} between '{1}' and '{2}'  ", SqlTypeHelper.GetDate("sh.TARIH"), startDate.Value.JustDate().ToString("yyyy-MM-dd"), finishDate.Value.JustDate().ToString("yyyy-MM-dd"));
        if (!string.IsNullOrEmpty(stokKodu))
            query.AppendFormat(" and st.STOK_KODU='{0}'",stokKodu);
        cmd.CommandText = query.ToString();
        IDataReader dread = null;
        DataTable dt = new DataTable();
        try {
            dread = cmd.ExecuteReader();
            dt.Columns.AddRange(
                                new DataColumn[]
                          {
                            new DataColumn("StokKodu",typeof(string)),
                             new DataColumn("StokIsmi",typeof(string)),
                            new DataColumn("Miktar",typeof(double)),
                             new DataColumn("OrtalamaFiyat",typeof(double)),
                            new DataColumn("ToplamFiyat",typeof(double))
                          
                          }
                               );
            while (dread.Read()) {
                DataRow dr = dt.NewRow();
                dr[0] = dread[0].ToStringOrEmpty();
                dr[1] = dread[1].ToStringOrEmpty();
                dr[2] = dread[2].ToStringOrEmpty("0");
                dr[3] = dread[3].ToStringOrEmpty("0");
                dr[4] = dread[4].ToStringOrEmpty("0"); 
                dt.Rows.Add(dr);
            }
        } catch (Exception exc) { throw exc; } finally {
            if (dread != null && !dread.IsClosed)
                dread.Close();
        }
        return dt;
    }
    public DataTable StokDurumRapor(string subeKodu) {
        return StokDurumRapor(subeKodu,"");
    }
    public DataTable StokDurumRapor(string subeKodu,string stokKodu)
    {       
        StringBuilder query = new StringBuilder();
        query.Append(@"select st.STOK_KODU,st.STOK_ADI,
sum(
(case when sh.GCKod='G' then sh.GCMik else 0 end)-
(case when sh.GCKod='C' then sh.GCMik else 0 end)
) as stokMiktar
from StokHareket sh inner join Stok st on (sh.STOK_KODU=st.STOK_KODU)
");
        query.AppendFormat(" where (st.SUBE_KODU='{0}' or st.SubelerdeOrtak=1)",subeKodu);
        if (!string.IsNullOrEmpty(stokKodu))
            query.AppendFormat(" and st.STOK_KODU='{0}'",stokKodu);
        query.Append("group by st.STOK_ADI,st.STOK_KODU");
        IDbConnection con = Session.Connection;
        IDbCommand cmd = con.CreateCommand();
        IDataReader dataRead = null;
        cmd.CommandText = query.ToString();
        DataTable dt = new DataTable();
        try {
            dataRead = cmd.ExecuteReader();
            dt.Columns.AddRange(
                                new DataColumn[]
                          {
                            new DataColumn("StokKodu"),
                            new DataColumn("StokAdı"),
                            new DataColumn("Miktar",typeof(double))
                          }
                               );
            while (dataRead.Read()) {
                DataRow dr = dt.NewRow();
                dr["StokKodu"] = dataRead[0].ToStringOrEmpty();
                dr["StokAdı"] = dataRead[1].ToStringOrEmpty();
                dr["Miktar"] = dataRead[2].ToStringOrEmpty("0");
                dt.Rows.Add(dr);
            }

            
        } catch (Exception exc) { throw exc; } 
        finally {
            if (dataRead != null && !dataRead.IsClosed)
                dataRead.Close();
        }
      return dt;
    }
    public DataTable StokAlisSatisRapor(string subeKodu, string stokKodu, DateTime startDate, DateTime finishDate,string GCKod)
    {

//      string query = @"select sh.Stok.Id,sh.FisNo,sh.StharHtur,sh.StharGckod,sh.GCMiktar,sh.BirimFiyat,sh.Tarih from StokHareket sh where 
//                     sh.Stok.Sube.Id=:subeKodu and sh.Tarih between :startDate and :finishDate";
      StringBuilder query=new StringBuilder();
      query.Append("select sh.Stok.Id,sh.Stok.StokAdi,sh.HareketBirim,sh.GCMiktar,sh.BirimFiyat,sh.Tarih from StokHareket sh where sh.StharGckod=:gcKod and (sh.Stok.Sube.Id=:subeKodu  or sh.Stok.SubelerdeOrtak=1)  and sh.Tarih between :startDate and :finishDate");
      if (!string.IsNullOrEmpty(stokKodu))
        query.Append(" and sh.Stok.Id=:skodu");
      query.Append(" order by sh.Tarih desc");
      IQuery qry = Session.CreateQuery(query.ToString()).SetString("gcKod",GCKod)
                                                        .SetString("subeKodu", subeKodu).SetDateTime("startDate", startDate.JustDate()).SetDateTime("finishDate",finishDate.JustDate());
      if (!string.IsNullOrEmpty(stokKodu))
        qry.SetString("skodu",stokKodu); 
          
    
       

      IList<object[]> liste = qry.List<object[]>();
      DataTable dt = new DataTable();
      dt.Columns.AddRange(
                          new DataColumn[]
                          {
                            new DataColumn("StokKodu"),
                            new DataColumn("StokAdı"),
                            new DataColumn("Birim"),
                            new DataColumn("Miktar",typeof(double)),
                            new DataColumn("BirimFiyat",typeof(double)),
                            new DataColumn("Tutar",typeof(double)),
                            new DataColumn("Tarih",typeof(DateTime))
                          }
                         );

      foreach (object[] objarray in liste)
      {
        DataRow dr = dt.NewRow();
        dr["StokKodu"] = objarray[0].ToStringOrEmpty();
        dr["StokAdı"] = objarray[1].ToStringOrEmpty();
        dr["Birim"] = objarray[2].ToStringOrEmpty();
        dr["Miktar"] = objarray[3].ToStringOrEmpty("0");
        dr["BirimFiyat"] = objarray[4].ToStringOrEmpty("0");
        dr["Tutar"] = double.Parse(objarray[3].ToStringOrEmpty("0")) * double.Parse(objarray[4].ToStringOrEmpty("0"));
        dr["Tarih"] = objarray[5].ToStringOrEmpty();
          //int i = 0;
        //object obj in objarray[];
        //foreach (object obj in objarray)
        //{
        //  dr[i] = obj.ToStringOrEmpty();
        //  i++;
        //}
        dt.Rows.Add(dr);
      }
      return dt;
    }
    public double GetStokMiktar(string stokKodu)
    {
      //IQuery qry = Session.GetNamedQuery("spStokMiktarName").SetParameter("StokKodu", stokKodu);
        IDbCommand cmd = Session.Connection.CreateCommand();
        string query = @"select 
sum(
(case when sh.GCKod='G' then sh.GCMik else 0 end)-
(case when sh.GCKod='C' then sh.GCMik else 0 end)
)
from StokHareket sh
where sh.STOK_KODU='{0}'".With(stokKodu);
        cmd.CommandText = query;
        object res= cmd.ExecuteScalar();
        if (res != null && !string.IsNullOrEmpty(res.ToString()))
            return double.Parse(res.ToString());
        else
            return 0;
      //return qry.UniqueResult<double>();
    }
    public IList<StokHarRpr> GetByFisNoAndSubeKodu(string fisNo, string subeKodu,FTIRSIP ftirsip)
    {
      //ICriteria criteria = Session.CreateCriteria(typeof(StokHareket)).Add(Expression.Eq("FisNo",fisNo));
        string kdvOrani = "";
        if (ftirsip == FTIRSIP.AlisFat || ftirsip == FTIRSIP.AlisIrs || ftirsip == FTIRSIP.SaticiSip)
            kdvOrani = "sh.Stok.AlisKdvOrani";
        else
            kdvOrani = "sh.Stok.SatisKdvOrani";
      IQuery criter = Session.CreateQuery("select new StokHarRpr(sh.Stok.Barkod1,sh.Id,sh.Stok.Id,sh.Stok.StokAdi,sh.HareketMiktar,sh.HareketBirim,sh.GCMiktar,sh.BirimFiyat,sh.Isk1,sh.Isk2,sh.Isk3,sh.Isk4,sh.Isk5,sh.HareketMiktar*sh.BirimFiyat,sh.Kdv) from StokHareket sh where sh.FisNo=:fis and sh.FTIRSIP=:ftirsip and sh.Sube.Id=:subeKodu").SetString("fis", fisNo).SetString("subeKodu",subeKodu).SetEnum("ftirsip", ftirsip);
      return criter.List<StokHarRpr>();
      //ICriteria fatirsUstCriteria = criteria.CreateCriteria("FatirsUst");
      //fatirsUstCriteria.Add(NHibernate.Criterion.Expression.Eq("Id", fatirsUst));

      //return criteria.List<StokHareket>();
    }
    public IList<StokHarRpr> GetByFisNoAndSubeKodu(string fisNo, string subeKodu)
    {
      IQuery criter = Session.CreateQuery("select new StokHarRpr(sh.Stok.Barkod1,sh.Id,sh.Stok.Id,sh.Stok.StokAdi,sh.HareketMiktar,sh.HareketBirim,sh.GCMiktar,sh.BirimFiyat,sh.Isk1,sh.Isk2,sh.Isk3,sh.Isk4,sh.Isk5,sh.HareketMiktar*sh.BirimFiyat,sh.Kdv) from StokHareket sh where sh.FisNo=:fis and sh.Sube.Id=:sk").SetString("fis", fisNo).SetString("sk", subeKodu);
      return criter.List<StokHarRpr>();
    }

    public IList<StokHareket> GetByStokHareket_DOVTIP(System.Int32 kur)
    {
      ICriteria criteria = Session.CreateCriteria(typeof(StokHareket));
      ICriteria kurCriteria = criteria.CreateCriteria("Kur");
      kurCriteria.Add(NHibernate.Criterion.Expression.Eq("Id", kur));
      return criteria.List<StokHareket>();
    }
    public IList<StokHareket> GetBySTOK_KODU(System.String stok)
    {
      ICriteria criteria = Session.CreateCriteria(typeof(StokHareket));
      ICriteria stokCriteria = criteria.CreateCriteria("Stok");
      stokCriteria.Add(NHibernate.Criterion.Expression.Eq("Id", stok));
      return criteria.List<StokHareket>();
    }
    public void TopluHareketSil(string fisNo, FTIRSIP ftirsip)
    {
      byte ftir = (byte)ftirsip;
      IDbConnection con = Session.Connection;
      IDbCommand cmd = con.CreateCommand();
      string query = "delete from StokHareket where FTIRSIP=" + ftir + " and FisNo='" + fisNo + "' ";
      cmd.CommandText = query;
      //IDbTransaction trs = con.BeginTransaction();
      cmd.Connection = con;
      cmd.ExecuteNonQuery();
      //cmd.Transaction = trs;
      //try
      //{
      //  cmd.ExecuteNonQuery();
        //trs.Commit();
      //}
      //catch
      //{
      //  trs.Rollback();
      //  throw;
      //}
    }
    public void UpdateStokHarByFisNoAndFtirsip(string fisNo, FTIRSIP ftirsip,FTIRSIP desFtirsip,string desFisNo)
    {
      byte b=(byte)ftirsip;
      byte b2 = (byte)desFtirsip;
      IDbConnection con = Session.Connection;
      IDbCommand cmd = con.CreateCommand();
   
      IDbTransaction trs =con.BeginTransaction();
       string query = "update StokHareket set HTUR='F',FTIRSIP="+b2+",FisNo='"+desFisNo+"' where FisNo='" + fisNo + "' and  FTIRSIP=" + b + " ";

       cmd.CommandText = query;
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
      finally
      {
        //con.Close();
      }
    }
    public DataTable StokHareketDokumu(string subeKodu, string stokKodu, string GCKod) {
        StringBuilder query = new StringBuilder();
        query.Append(@"select sh.Stok.Id,sh.Stok.StokAdi,sh.FisNo,sh.StharHtur,sh.StharGckod,sh.GCMiktar,sh.BirimFiyat,sh.HareketBirim,sh.Tarih from StokHareket sh where 
                     (sh.Stok.Sube.Id=:subeKodu or sh.Stok.SubelerdeOrtak=1)");
        if (!string.IsNullOrEmpty(stokKodu))
            query.Append(" and sh.Stok.Id=:stokId");
        if (!string.IsNullOrEmpty(GCKod))
            query.Append(" and sh.StharGckod=:gcKod");
        query.Append(" order by sh.Tarih desc");
        IQuery qry = Session.CreateQuery(query.ToString()).SetString("subeKodu", subeKodu);
        if (!string.IsNullOrEmpty(stokKodu))
            qry = qry.SetString("stokId", stokKodu);
        if (!string.IsNullOrEmpty(GCKod))
            qry = qry.SetString("gcKod", GCKod);
        IList<object[]> liste = qry.List<object[]>();
        DataTable dt = new DataTable();
        dt.Columns.AddRange(
                            new DataColumn[]
                          {
                            new DataColumn("StokKodu"),new DataColumn("StokAdı"),
                            new DataColumn("FisNo"),new DataColumn("Tip"),
                            new DataColumn("GCKod",typeof(string)),new DataColumn("GCMiktar",typeof(double)),
                            new DataColumn("BirimFiyat",typeof(double)),
                              new DataColumn("Birim"),
                             new DataColumn("Tutar",typeof(double)),
                            new DataColumn("Tarih",typeof(DateTime))
                          }
                           );

        foreach (object[] objarray in liste) {
            DataRow dr = dt.NewRow();
            dr["StokKodu"] = objarray[0].ToStringOrEmpty();
            dr["StokAdı"] = objarray[1].ToStringOrEmpty();
            dr["FisNo"] = objarray[2].ToStringOrEmpty();
            dr["Tip"] = objarray[3].ToStringOrEmpty();
            dr["GCKod"] = objarray[4].ToStringOrEmpty();
            dr["GCMiktar"] = objarray[5].ToStringOrEmpty("0");
            dr["BirimFiyat"] = objarray[6].ToStringOrEmpty("0");
            dr["Birim"] = objarray[7].ToStringOrEmpty("");
            dr["Tutar"] = double.Parse(objarray[5].ToStringOrEmpty("0")) * double.Parse(objarray[6].ToStringOrEmpty("0"));
            dr["Tarih"] = objarray[8].ToStringOrEmpty();
            dt.Rows.Add(dr);
        }
        return dt;
    }
    public DataTable StokHareketDokumu(string subeKodu,string stokKodu,string GCKod, DateTime startDate, DateTime finishDate)
    {
        StringBuilder query = new StringBuilder();
        query.Append(@"select sh.Stok.Id,sh.Stok.StokAdi,sh.FisNo,sh.StharHtur,sh.StharGckod,sh.GCMiktar,sh.BirimFiyat,sh.HareketBirim,sh.Tarih from StokHareket sh where 
                     (sh.Stok.Sube.Id=:subeKodu or sh.Stok.SubelerdeOrtak=1) and sh.Tarih between :startDate and :finishDate");
        if (!string.IsNullOrEmpty(stokKodu))
            query.Append(" and sh.Stok.Id=:stokId");
        if (!string.IsNullOrEmpty(GCKod))
            query.Append(" and sh.StharGckod=:gcKod");
        query.Append(" order by sh.Tarih desc");
      IQuery qry = Session.CreateQuery(query.ToString()).SetString("subeKodu",subeKodu).SetDateTime("startDate", startDate.JustDate())
         .SetDateTime("finishDate", finishDate.JustDate());
      if (!string.IsNullOrEmpty(stokKodu))
          qry = qry.SetString("stokId",stokKodu);
      if (!string.IsNullOrEmpty(GCKod))
          qry = qry.SetString("gcKod",GCKod);
      IList<object[]> liste = qry.List<object[]>();
      DataTable dt = new DataTable();
      dt.Columns.AddRange(
                          new DataColumn[]
                          {
                            new DataColumn("StokKodu"),new DataColumn("StokAdı"),
                            new DataColumn("FisNo"),new DataColumn("Tip"),
                            new DataColumn("GCKod",typeof(string)),new DataColumn("GCMiktar",typeof(double)),
                            new DataColumn("BirimFiyat",typeof(double)),
                              new DataColumn("Birim"),
                             new DataColumn("Tutar",typeof(double)),
                            new DataColumn("Tarih",typeof(DateTime))
                          }
                         );

      foreach (object[] objarray in liste)
      {
        DataRow dr = dt.NewRow();       
        dr["StokKodu"] = objarray[0].ToStringOrEmpty();
        dr["StokAdı"] = objarray[1].ToStringOrEmpty();
        dr["FisNo"] = objarray[2].ToStringOrEmpty();
        dr["Tip"] = objarray[3].ToStringOrEmpty();
        dr["GCKod"] = objarray[4].ToStringOrEmpty();
        dr["GCMiktar"] = objarray[5].ToStringOrEmpty("0");
        dr["BirimFiyat"] = objarray[6].ToStringOrEmpty("0");
        dr["Birim"] = objarray[7].ToStringOrEmpty("");
        dr["Tutar"] = double.Parse(objarray[5].ToStringOrEmpty("0")) * double.Parse(objarray[6].ToStringOrEmpty("0"));
        dr["Tarih"] = objarray[8].ToStringOrEmpty();
        dt.Rows.Add(dr);
      }
      return dt;
    }
    // direkt satiş için
    public string GetLastArtiOneFisNoBySubeKodu(string subeKodu)
    {
      ICriteria criteria = Session.CreateCriteria(typeof(StokHareket)).SetProjection(Projections.Max("FisNo"))
                                  .Add(Expression.Eq("DirektSatis","E")).SetMaxResults(1);
      ICriteria subeCriteria = criteria.CreateCriteria("Sube");
      subeCriteria.Add(NHibernate.Criterion.Expression.Eq("Id", subeKodu));
      string fisNo = criteria.UniqueResult<string>();

      if (!string.IsNullOrEmpty(fisNo))
      {

        for (int i = fisNo.Length - 1; i > 0; i--)
        {
          if (char.IsDigit(fisNo[i]))
          {
            int deger = int.Parse(fisNo[i].ToString());
            deger = deger + 1;
            if (deger > 9)
            {
              fisNo = fisNo.Remove(i, 1);
              fisNo = fisNo.Insert(i, "0");
            }
            else
            {
              fisNo = fisNo.Remove(i, 1);
              fisNo = fisNo.Insert(i, deger.ToString());
              break;
            }
          }
          else
          {
            break;
          }
        }
      }
      else
        fisNo = subeKodu.ToString() + "ds0000000000";
      return fisNo;
    }
    
  }
}
