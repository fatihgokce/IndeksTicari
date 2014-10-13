using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indeks.Data.Helper {
    public class CariHareketleriDurumu {
        public bool NakitTahsilat { get; set; }
        public bool NakitOdeme { get; set; }
        public bool AlinanMal { get; set; }
        public bool AlinanMalIadesi { get; set; }
        public bool SatilanMal { get; set; }
        public bool SatilanMalIadesi { get; set; }
        public bool AlinanCek { get; set; }
        public bool VerilenCek { get; set; }
        public bool CekCirosu { get; set; }
        public bool AlinanCekIade { get; set; }
        public bool VerilenCekGeriAlinmasi { get; set; }
        public bool KarsiliksizCek { get; set; }
        public bool AlinanSenet { get; set; }
        public bool VerilenSenet { get; set; }
        public bool SenetCirosu { get; set; }
        public bool AlinanSenetIade { get; set; }
        public bool VerilenSenetGeriAlinmasi { get; set; }
        public bool KarsiliksizSenet { get; set; }

        public bool GelenHavale { get; set; }
        public bool GonderilenHavale { get; set; }
        public bool Veresiye { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
