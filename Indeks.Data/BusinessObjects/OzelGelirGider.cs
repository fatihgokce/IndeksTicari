using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Indeks.Data.Base;
namespace Indeks.Data.BusinessObjects {
    public enum GelirGider { 
    Gider=0,Gelir
    }
    public class OzelGelirGider:BusinessBase<string> {
        public virtual string Ismi { get; set; }
        public virtual double? KdvOrani { get; set; }
        public virtual GelirGider GelirGider { get; set; }
        public override int GetHashCode() {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append(this.GetType().FullName);
            sb.Append(Ismi);
            sb.Append(KdvOrani);
            sb.Append(GelirGider);
            return sb.ToString().GetHashCode();
        }
    }
}
