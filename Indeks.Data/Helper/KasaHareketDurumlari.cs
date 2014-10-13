using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indeks.Data.Helper {
    public class KasaHareketDurumlari {
        public bool MalAlis { get; set; }
        public bool MalSatis { get; set; }
        public bool CaridenTahsilat { get; set; }
        public bool CariyeOdeme { get; set; }
        public bool BankayaYatan { get; set; }
        public bool BankadanCekilen { get; set; }
        public bool CekGelir { get; set; }
        public bool CekGider { get; set; }
        public bool SenetGelir { get; set; }
        public bool SenetGider { get; set; }
        public bool OzelGelir { get; set; }
        public bool OzelGider { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
    }
   

}
