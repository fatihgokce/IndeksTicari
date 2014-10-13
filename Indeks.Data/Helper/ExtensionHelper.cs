using System;
using System.Collections.Generic;

using System.Text;
using Indeks.Data.Base;
//override the .net 3.5 compiler services for .net 2.0 compatibility
//see: http://kohari.org/2008/04/04/extension-methods-in-net-20/
namespace System.Runtime.CompilerServices
{
  [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
  public class ExtensionAttribute : Attribute
  {
  }
}
namespace Indeks.Data.Helper
{   
  public static class ExtensionHelper
  {
      public static string With(this string format, params object[] args) {
          return string.Format(format, args);
      }
      public static DateTime JustDate(this DateTime date) {
          date = DateTime.Parse(date.ToString("d"));
          return date;
      }
    public static string ToStringOrEmpty(this object obj)
    {
      if (obj != null)
        return obj.ToString();
      else
        return "";
    }
    public static void ConditionAppend(this StringBuilder sb, bool condition, string value) {
        if (condition)
            sb.Append(value);
    }
    public static void ConditionAppend(this StringBuilder sb, bool condition, string value, Action action) {
        if (condition) {
            sb.Append(value);
            action();
        }
    }
    public static string ToDouble(this object obj) {
        return double.Parse(obj.ToStringOrEmpty("0")).ToString("F2");
    }
    public static string ToDate(this object obj) {
        if (obj == null || string.IsNullOrEmpty(obj.ToString()))
            return "";
        else
            return Convert.ToDateTime(obj.ToStringOrEmpty("0")).ToString("d");
    }
    public static string ToStringOrEmpty(this object obj,string defaultValue) {
        if (obj != null) {
            if (string.IsNullOrEmpty(obj.ToString()))
                return defaultValue;
            else
                return obj.ToString();
        } else
            return defaultValue;
    }
    //public static string ToEqualDatabaseValue(this StHarHTur item)
    //{
    //  string retVal="";
    //  switch (item)
    //  {
    //    case StHarHTur.Devir:retVal="D";break;
    //    case StHarHTur.Fatura:retVal="F";break;
    //    case StHarHTur.Irsaliye:retVal="I";break;
    //  }
    //  return retVal;
    //}
    //public static string ToEqualDatabaseValue(this FatNoTip item)
    //{
    //  string retVal = "";
    //  switch (item)
    //  {
    //    case FatNoTip.Fatura: retVal = "F"; break;
    //    case FatNoTip.Irsaliye: retVal = "I"; break;
    //    case FatNoTip.Siparis: retVal = "S"; break;
    //  }
    //  return retVal;
    //}
  }
}
