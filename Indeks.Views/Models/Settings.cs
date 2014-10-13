using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indeks.Views.Models {
    public enum IndeksPaket
    {Eko=1,Pro
    }
    public enum DataBase { 
    MsSql,SqlLite
    }
    public class Settings {
        public IndeksPaket Paket { get; set; }
        public string ConnectionString { get; set; }
        public string DataBase { get; set; }
        public string Kurulum { get; set; }
    }   
}
