using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Indeks.Data.Base;
namespace Indeks.Data.BusinessObjects {
    public class ILce:BusinessBase<int> {
        public virtual string Adi { get; set; }
        public virtual int ILKodu { get; set; }

        public override int GetHashCode() {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(this.GetType().FullName);
            sb.Append(Adi);
            sb.Append(ILKodu);
            return sb.ToString().GetHashCode();
        }
    }
}
