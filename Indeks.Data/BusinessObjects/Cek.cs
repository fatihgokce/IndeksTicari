using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Indeks.Data.Base;

namespace Indeks.Data.BusinessObjects {
    public enum CekDurum { 
    Beklemede=1,TahsilEdildi,CiroEdildi,
        BankayaTahsileVerildi,TahsilBankaHesaba,
        IadeEdildi,BankaTeminatVerildi,Karsiliksiz,
        Odendi,GeriAlindi
    }
    public enum CekTip { Verilen,Alinan}
    public class Cek:BusinessBase<int> {
        public virtual CekTip CekTip { get; set; }
        public virtual CekDurum CekDurum { get; set; } 
        public virtual string CariKodu { get; set; }
        public virtual DateTime IslemTarih { get; set; }
        public virtual DateTime VadeTarih { get; set; }
        public virtual string Banka { get; set; }
        public virtual string SubeAdi { get; set; }
        public virtual string HesapNo { get; set; }
        public virtual string CekNo { get; set; }
        public virtual string AsilSahibi { get; set; }
        public virtual string Aciklama { get; set; }
        public virtual double Tutar { get; set; }
        public virtual DateTime KayitTarih { get; set; }
        public virtual string DurumKasaKod { get; set; }
        public virtual string DurumCariKod { get; set; }
        public virtual string DurumBankaHesapNo { get; set; }
        public virtual Sube Sube { get; set; }
        public override int GetHashCode() {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append(this.GetType().FullName);
            sb.Append(CekTip);
            sb.Append(CekDurum);
            sb.Append(CariKodu);
            sb.Append(IslemTarih);
            sb.Append(VadeTarih);
            sb.Append(Banka);
            sb.Append(SubeAdi);
            sb.Append(HesapNo);
            sb.Append(CekNo);
            sb.Append(AsilSahibi);
            sb.Append(Aciklama);
            sb.Append(Tutar);
            sb.Append(DurumKasaKod);
            sb.Append(DurumCariKod);
            sb.Append(DurumBankaHesapNo);
            sb.Append(KayitTarih);
            return sb.ToString().GetHashCode();
        }
    }
}
