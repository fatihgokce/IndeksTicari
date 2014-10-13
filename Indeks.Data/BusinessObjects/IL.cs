using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Indeks.Data.Base;
namespace Indeks.Data.BusinessObjects {
    public class IL:BusinessBase<int> {
        public virtual string Adi { get; set; }

        public override int GetHashCode() {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(this.GetType().FullName);
            sb.Append(Adi);
            return sb.ToString().GetHashCode();
        }
    }
}
