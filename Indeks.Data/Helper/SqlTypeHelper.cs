using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Indeks.Data.Base;
namespace Indeks.Data.Helper {
    public static class SqlTypeHelper {
        public static string GetDate(string param) {
            if (DataBaseInfo.SqlType == SqlServerType.SQL2005) {
                return "{0}".With(param);
            } else
                return "date({0})".With(param);
        }
            public static string GetYear(string param) {
            if (DataBaseInfo.SqlType == SqlServerType.SQL2005) {
                return "YEAR({0})".With(param);
            } else
                return "strftime('%Y',{0})".With(param);
      }
            public static string GetMonth(string param) {
                if (DataBaseInfo.SqlType == SqlServerType.SQL2005) {
                    return "MONTH({0})".With(param);
                } else
                    return "strftime('%m',{0})".With(param);
            }

    }
}
