using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Indeks.Data.Base;
namespace Indeks.Data.BusinessObjects {
    public class Post:BusinessBase<int> {
        public virtual double KesintiOran { get; set; }
        public virtual DateTime HesabaGecisTarih { get; set; }
        public virtual BankaHesap Hesap { get; set; }


        public override int GetHashCode() {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(this.GetType().FullName);
            sb.Append(KesintiOran);
            sb.Append(HesabaGecisTarih);
            return sb.ToString().GetHashCode();
        }
    }
}
