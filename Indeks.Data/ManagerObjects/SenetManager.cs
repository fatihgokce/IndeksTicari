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
    public interface ISenetManager : IManagerBase<Senet, int> {
        IList<Senet> GetListSUBE_KODU(string subeKodu);
        IList<Senet> GetListWithSearchKey(string subeKodu, string searchKey, SenetDurum? senetDurum);
        DataTable SenetRaporu(string subeKodu, string cariKodu, DateTime islemBasTar, DateTime islemBitTar,
        DateTime vadeBasTar, DateTime vadeBitTar);
        List<Senet> GetListSenetByVadeTarih(string subeKodu, DateTime vadeDate);
        double TahsilEdilcekSenetToplami(string subeKodu, DateTime? beginDate, DateTime? endDate);
        double OdencekSenetToplami(string subeKodu, DateTime? beginDate, DateTime? endDate);
    }
    public class SenetManager:ManagerBase<Senet,int>,ISenetManager {
        #region ISenetManager Members
        public double OdencekSenetToplami(string subeKodu, DateTime? beginDate, DateTime? endDate) {
            if (beginDate.HasValue && endDate.HasValue)
                return Session.QueryOver<Senet>().Where(x => x.Sube.Id == subeKodu
                   && x.IslemTarih.IsBetween(beginDate.Value).And(endDate.Value)
                   && x.SenetTip == SenetTip.Verilen &&
                   x.SenetDurum == SenetDurum.Beklemede
                   )
                   .Select(
                      Projections.Sum<Senet>(x => x.Tutar)
                      ).SingleOrDefault<double>();
            else
                return Session.QueryOver<Senet>().Where(x => x.Sube.Id == subeKodu
                  && x.SenetTip == SenetTip.Verilen &&
                 x.SenetDurum == SenetDurum.Beklemede
                  )
                  .Select(
                     Projections.Sum<Senet>(x => x.Tutar)
                     ).SingleOrDefault<double>();
        }
        public double TahsilEdilcekSenetToplami(string subeKodu, DateTime? beginDate, DateTime? endDate) {
            if (beginDate.HasValue && endDate.HasValue)
                return Session.QueryOver<Senet>().Where(x => x.Sube.Id == subeKodu
                   && x.IslemTarih.IsBetween(beginDate.Value).And(endDate.Value)
                   && x.SenetTip == SenetTip.Alinan &&
                   (x.SenetDurum == SenetDurum.BankaTeminatVerildi || x.SenetDurum == SenetDurum.BankayaTahsileVerildi
                   || x.SenetDurum == SenetDurum.Beklemede)
                   )
                   .Select(
                      Projections.Sum<Senet>(x => x.Tutar)
                      ).SingleOrDefault<double>();
            else
                return Session.QueryOver<Senet>().Where(x => x.Sube.Id == subeKodu
                  && x.SenetTip == SenetTip.Alinan &&
                  (x.SenetDurum == SenetDurum.BankaTeminatVerildi || x.SenetDurum == SenetDurum.BankayaTahsileVerildi
                  || x.SenetDurum == SenetDurum.Beklemede)
                  )
                  .Select(
                     Projections.Sum<Senet>(x => x.Tutar)
                     ).SingleOrDefault<double>();
        }
        public List<Senet> GetListSenetByVadeTarih(string subeKodu, DateTime vadeDate) {
            return Session.QueryOver<Senet>().Where(x => x.Sube.Id == subeKodu
                && x.VadeTarih == vadeDate && x.SenetDurum==SenetDurum.Beklemede).List() as List<Senet>;
        }
        public DataTable SenetRaporu(string subeKodu, string cariKodu, DateTime islemBasTar, DateTime islemBitTar,
       DateTime vadeBasTar, DateTime vadeBitTar) {
            StringBuilder query = new StringBuilder(
           @"select s.SenetNo,s.CariKodu,cari.CARI_ISIM CariAd,
s.SenetTip,s.SenetDurum,
s.VadeTarih,s.IslemTarih,s.Tutar 
from Senet s inner join Cari cari on s.CariKodu=cari.CARI_KODU ");

            query.AppendFormat(" where s.SUBE_KODU='{0}' ", subeKodu);
            if (!string.IsNullOrEmpty(cariKodu))
                query.AppendFormat(" and s.CariKodu='{0}'", cariKodu);
            query.AppendFormat(" and {0} between '{1}' and  '{2}'", SqlTypeHelper.GetDate("s.IslemTarih"),
                islemBasTar.JustDate().ToString("yyyy-MM-dd"), islemBitTar.JustDate().ToString("yyyy-MM-dd"));
            query.AppendFormat(" and {0} between '{1}' and  '{2}'", SqlTypeHelper.GetDate("s.VadeTarih"),
                vadeBasTar.JustDate().ToString("yyyy-MM-dd"), vadeBitTar.JustDate().ToString("yyyy-MM-dd"));


            IDbConnection con = Session.Connection;
            IDbCommand cmd = con.CreateCommand();
            cmd.CommandText = query.ToString();

            IDataReader dr = null;

            DataTable dt = new DataTable();
            dt.Columns.AddRange(
                                new DataColumn[]
                          {
                            new DataColumn("SenetNo"),
                            new DataColumn("CariKodu"),
                            new DataColumn("CariAd"),
                            new DataColumn("SenetTip"),                           
                            new DataColumn("SenetDurum"),                         
                              new DataColumn("VadeTarih",typeof(DateTime)),
                              new DataColumn("IslemTarih",typeof(DateTime)),
                            new DataColumn("Tutar",typeof(double))                            
                            
                          });
            try {
                dr = cmd.ExecuteReader();
                while (dr.Read()) {
                    DataRow dar = dt.NewRow();
                    dar["SenetNo"] = dr["SenetNo"].ToStringOrEmpty();
                    dar["CariKodu"] = dr["CariKodu"].ToStringOrEmpty();
                    dar["CariAd"] = dr["CariAd"].ToStringOrEmpty();
                    dar["SenetTip"] = dr["SenetTip"].ToStringOrEmpty();
                    dar["SenetDurum"] = dr["SenetDurum"].ToStringOrEmpty();                   
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
        public IList<Senet> GetListSUBE_KODU(string subeKodu) {
            return Session.QueryOver<Senet>().Where(x=>x.Sube.Id==subeKodu).List();
        }

        public IList<Senet> GetListWithSearchKey(string subeKodu, string searchKey, SenetDurum? senetDurum) {
            if (senetDurum.HasValue)
                return Session.QueryOver<Senet>().Where(x => x.Sube.Id == subeKodu && x.SenetDurum == senetDurum.Value).And(x =>
                    x.Kefil1.IsLike(searchKey, MatchMode.Anywhere)
                    || x.Kefil2.IsLike(searchKey, MatchMode.Anywhere)
                    || x.Aciklama.IsLike(searchKey, MatchMode.Anywhere)
                    || x.AsilSahibi.IsLike(searchKey, MatchMode.Anywhere)).Take(GetMaxResult).List();
            else
                return Session.QueryOver<Senet>().Where(x => x.Sube.Id == subeKodu).And(x =>
                    x.Kefil1.IsLike(searchKey, MatchMode.Anywhere)
                    || x.Kefil2.IsLike(searchKey, MatchMode.Anywhere)
                    || x.Aciklama.IsLike(searchKey, MatchMode.Anywhere)
                    || x.AsilSahibi.IsLike(searchKey, MatchMode.Anywhere)).Take(GetMaxResult).List();
        }
        #endregion
    }
}
