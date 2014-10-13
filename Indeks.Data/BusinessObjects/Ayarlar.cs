using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Indeks.Data.Base;
namespace Indeks.Data.BusinessObjects {    
    public class Ayarlar {
        public virtual string Ad { get; set; }
        public virtual string Deger1 { get; set; }
        public virtual string Deger2 { get; set; }
        public virtual string SubeKodu { get; set; }
        public virtual bool? SubelerdeOrtak { get; set; }
        public override int GetHashCode() {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(this.GetType().FullName);
            sb.Append(Ad);
            sb.Append(SubeKodu);
            sb.Append(Deger1);
            sb.Append(Deger2);
            sb.Append(SubelerdeOrtak);
            return sb.ToString().GetHashCode();
        }
        public override bool Equals(object obj) {
            Ayarlar ayar = obj as Ayarlar;
            if (ayar == null)
                return false;
            return (ayar != null)                                                  // 1) Object is not null.
                                                                               // 2) Object is of same Type.
                && (MatchingIds(ayar) || MatchingHashCodes(ayar));   // 3) Ids or Hashcodes match.
        }
        private bool MatchingIds(Ayarlar obj) {
            return (this.Ad != null && !this.Ad.Equals(default(string)))                 // 1) this.Id is not null/default.
                && (obj.Ad != null && !obj.Ad.Equals(default(string)))                   // 1.5) obj.Id is not null/default.
                && (this.Ad.Equals(obj.Ad) && this.SubeKodu.Equals(obj.SubeKodu));                                        // 2) Ids match.
        }
        private bool MatchingHashCodes(object obj) {
            return this.GetHashCode().Equals(obj.GetHashCode());                    // 1) Hashcodes match.
        }
    }
}
