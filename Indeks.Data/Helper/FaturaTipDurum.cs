using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indeks.Data.Helper {
    public struct FaturaTipDurum {
        public bool Vadeli { get; set; }
        public bool Pesin { get; set; }
        public bool Iade { get; set; }
        public bool KrediKarti { get; set; }
    }
}
