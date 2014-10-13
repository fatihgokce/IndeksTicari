using System;
using System.Collections.Generic;

using System.Text;

namespace Indeks.Data.Base
{
    public enum SqlServerType : byte {
        SqlLite,
        SQL2005 
    }


  internal static class DataBaseInfo
  {
    public static string ConString { get; set; }
    public static SqlServerType SqlType { get; set; }
  }
}
