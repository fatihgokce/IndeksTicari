using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Indeks.Data.Base;
namespace Indeks.Data.BusinessObjects {
    public enum SenetDurum {
        Beklemede = 1, TahsilEdildi, CiroEdildi,
        BankayaTahsileVerildi, TahsilBankaHesaba,
        IadeEdildi, BankaTeminatVerildi, Karsiliksiz,
        Odendi, GeriAlindi
    }
    public enum SenetTip { Verilen,Alinan}
    public class Senet:BusinessBase<int> {
        public virtual string CariKodu { get; set; }
        public virtual SenetTip SenetTip { get; set; }
        public virtual SenetDurum SenetDurum { get; set; }
        public virtual DateTime IslemTarih { get; set; }
        public virtual DateTime VadeTarih { get; set; }
        public virtual double Tutar { get; set; }
        public virtual string SenetNo { get; set; }
        public virtual string AsilSahibi { get; set; }
        public virtual string Kefil1 { get; set; }
        public virtual string Kefil2 { get; set; }
        public virtual string Aciklama { get; set; }
        public virtual string DurumKasaKod { get; set; }
        public virtual string DurumCariKod { get; set; }
        public virtual string DurumBankaHesapNo { get; set; }
        public virtual DateTime KayitTarih { get; set; }
        public virtual Sube Sube { get; set; }
        public override int GetHashCode() {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append(this.GetType().FullName);
            sb.Append(SenetTip);
            sb.Append(SenetDurum);
            sb.Append(IslemTarih);
            sb.Append(VadeTarih);
            sb.Append(Tutar);
            sb.Append(SenetNo);
            sb.Append(AsilSahibi);
            sb.Append(Kefil1);
            sb.Append(Kefil2);
            sb.Append(Aciklama);           
            sb.Append(DurumKasaKod);
            sb.Append(DurumCariKod);
            sb.Append(DurumBankaHesapNo);
            sb.Append(KayitTarih);
            return sb.ToString().GetHashCode();
        }

    }
}
