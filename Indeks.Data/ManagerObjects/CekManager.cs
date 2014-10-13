using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using Indeks.Data.BusinessObjects;
using Indeks.Data.Base;
using NHibernate.Criterion;
using System.Data;
using Indeks.Data.Helper;
namespace Indeks.Data.ManagerObjects {
    public interface ICekManager : IManagerBase<Cek, int> { 
    IList<Cek> GetListBySUBE_KODU(string subeKodu);
    IList<Cek> GetListWithSearhKey(string subeKodu,string searchKey,CekDurum?cekDurum);
    DataTable CekRaporu(string subeKodu, string cariKodu, DateTime islemBasTar, DateTime islemBitTar,
        DateTime vadeBasTar, DateTime vadeBitTar);
    List<Cek> GetListCekByVadeTarih(string subeKodu,DateTime vadeDate);
    double TahsilEdilcekCekToplami(string subeKodu, DateTime? beginDate, DateTime? endDate);
    double OdencekCekToplami(string subeKodu, DateTime? beginDate, DateTime? endDate);
    }
    public class CekManager:ManagerBase<Cek,int>,ICekManager {
        #region ICekManager Members
        public double OdencekCekToplami(string subeKodu, DateTime? beginDate, DateTime? endDate) {
            if (beginDate.HasValue && endDate.HasValue)
                return Session.QueryOver<Cek>().Where(x => x.Sube.Id == subeKodu
                   && x.IslemTarih.IsBetween(beginDate.Value).And(endDate.Value)
                   && x.CekTip == CekTip.Verilen &&
                   x.CekDurum == CekDurum.Beklemede
                   )
                   .Select(
                      Projections.Sum<Cek>(x => x.Tutar)
                      ).SingleOrDefault<double>();
            else
                return Session.QueryOver<Cek>().Where(x => x.Sube.Id == subeKodu
                  && x.CekTip == CekTip.Verilen &&
                 x.CekDurum==CekDurum.Beklemede
                  )
                  .Select(
                     Projections.Sum<Cek>(x => x.Tutar)
                     ).SingleOrDefault<double>();
        }
        public double TahsilEdilcekCekToplami(string subeKodu, DateTime? beginDate, DateTime? endDate) {
            if (beginDate.HasValue && endDate.HasValue)
                return Session.QueryOver<Cek>().Where(x => x.Sube.Id == subeKodu
                   && x.IslemTarih.IsBetween(beginDate.Value).And(endDate.Value)
                   && x.CekTip==CekTip.Alinan && 
                   (x.CekDurum==CekDurum.BankaTeminatVerildi || x.CekDurum==CekDurum.BankayaTahsileVerildi
                   || x.CekDurum==CekDurum.Beklemede )
                   )
                   .Select(
                      Projections.Sum<Cek>(x => x.Tutar)
                      ).SingleOrDefault<double>();
            else
                return Session.QueryOver<Cek>().Where(x => x.Sube.Id == subeKodu
                  && x.CekTip == CekTip.Alinan &&
                  (x.CekDurum == CekDurum.BankaTeminatVerildi || x.CekDurum == CekDurum.BankayaTahsileVerildi
                  || x.CekDurum == CekDurum.Beklemede)
                  )
                  .Select(
                     Projections.Sum<Cek>(x => x.Tutar)
                     ).SingleOrDefault<double>();
        }
        public List<Cek> GetListCekByVadeTarih(string subeKodu,DateTime vadeDate) {
            return Session.QueryOver<Cek>().Where(x =>
                x.Sube.Id == subeKodu && x.VadeTarih == vadeDate && x.CekDurum==CekDurum.Beklemede).List() as List<Cek>;
        }
        public DataTable CekRaporu(string subeKodu, string cariKodu, DateTime islemBasTar, DateTime islemBitTar,
        DateTime vadeBasTar, DateTime vadeBitTar) {
            StringBuilder query = new StringBuilder(
           @"select c.CekNo,c.CariKodu,cari.CARI_ISIM CariAd,
c.CekTip,c.CekDurum,c.Banka,c.HesapNo,
c.VadeTarih,c.IslemTarih,c.Tutar 
from Cek c inner join Cari cari on c.CariKodu=cari.CARI_KODU ");           
          
            query.AppendFormat(" where c.SUBE_KODU='{0}' ", subeKodu);
            if (!string.IsNullOrEmpty(cariKodu))
                query.AppendFormat(" and c.CariKodu='{0}'",cariKodu);
            query.AppendFormat(" and {0} between '{1}' and  '{2}'", SqlTypeHelper.GetDate("c.IslemTarih"),
                islemBasTar.JustDate().ToString("yyyy-MM-dd"),islemBitTar.JustDate().ToString("yyyy-MM-dd"));
            query.AppendFormat(" and {0} between '{1}' and  '{2}'", SqlTypeHelper.GetDate("c.VadeTarih"),
                vadeBasTar.JustDate().ToString("yyyy-MM-dd"), vadeBitTar.JustDate().ToString("yyyy-MM-dd"));        
            
          
            IDbConnection con = Session.Connection;
            IDbCommand cmd = con.CreateCommand();
            cmd.CommandText = query.ToString();

            IDataReader dr = null;

            DataTable dt = new DataTable();
            dt.Columns.AddRange(
                                new DataColumn[]
                          {
                            new DataColumn("CekNo"),
                            new DataColumn("CariKodu"),
                            new DataColumn("CariAd"),
                            new DataColumn("CekTip"),                           
                            new DataColumn("CekDurum"),
                            new DataColumn("Banka"),
                             new DataColumn("HesapNo"),
                              new DataColumn("VadeTarih",typeof(DateTime)),
                              new DataColumn("IslemTarih",typeof(DateTime)),
                            new DataColumn("Tutar",typeof(double))
                            
                            
                          });
            try {
                dr = cmd.ExecuteReader();
                while (dr.Read()) {
                    DataRow dar = dt.NewRow();
                    dar["CekNo"] = dr["CekNo"].ToStringOrEmpty();
                    dar["CariKodu"] = dr["CariKodu"].ToStringOrEmpty();
                    dar["CariAd"] = dr["CariAd"].ToStringOrEmpty();
                    dar["CekTip"] = dr["CekTip"].ToStringOrEmpty();
                    dar["CekDurum"] = dr["CekDurum"].ToStringOrEmpty();
                    dar["Banka"] = dr["Banka"].ToStringOrEmpty();
                    dar["HesapNo"] = dr["HesapNo"].ToStringOrEmpty();
                    dar["VadeTarih"] = dr["VadeTarih"].ToDate();
                    dar["IslemTarih"] = dr["IslemTarih"].ToDate();
                    dar["Tutar"] = dr["Tutar"].ToDouble();

                    dt.Rows.Add(dar);
                }
            } catch (Exception exc) { throw exc; } finally {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
            }

            return dt; 
        }
        public IList<Cek> GetListBySUBE_KODU(string subeKodu) {
            return Session.QueryOver<Cek>().Where(x => x.Sube.Id == subeKodu).OrderBy(x=>x.KayitTarih).Desc.Take(GetMaxResult).List();
        }
        public IList<Cek> GetListWithSearhKey(string subeKodu, string searchKey,CekDurum?cekDurum) {
            if (cekDurum.HasValue)
                return Session.QueryOver<Cek>().Where(x => x.Sube.Id == subeKodu && x.CekDurum == cekDurum.Value).And(x =>
                    x.CariKodu.IsLike(searchKey, MatchMode.Anywhere)
                    || x.Banka.IsLike(searchKey, MatchMode.Anywhere)
                    || x.SubeAdi.IsLike(searchKey, MatchMode.Anywhere)
                    || x.AsilSahibi.IsLike(searchKey, MatchMode.Anywhere)).Take(GetMaxResult).List();
            else
                return Session.QueryOver<Cek>().Where(x => x.Sube.Id == subeKodu).And(x =>
                    x.CariKodu.IsLike(searchKey, MatchMode.Anywhere)
                    || x.Banka.IsLike(searchKey, MatchMode.Anywhere)
                    || x.SubeAdi.IsLike(searchKey, MatchMode.Anywhere)
                    || x.AsilSahibi.IsLike(searchKey, MatchMode.Anywhere)).Take(GetMaxResult).List();
               
        }
        #endregion
    }
}
