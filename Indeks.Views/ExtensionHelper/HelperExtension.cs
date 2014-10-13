using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Collections;
using Indeks.Data.Base;
namespace Indeks.Views
{
  public delegate TResult Func<T, TResult>(T arg);

  public static class HelperExtension
  {
      public static string With(this string format, params object[] args) {
          return string.Format(format, args);
      }
      public static List<string> ToStringList(this List<KodIsim> liste,int maxKodUzunluk,string ayirac) {

          List<string> list = new List<string>();
          foreach (KodIsim item in liste) {
              string str = item.Kod;
              str = str.PadRight(maxKodUzunluk);
              str += string.Format("{0}",item.Isim);
              list.Add(str); 
          }
          return list;
      }
      public static DateTime JustDate(this DateTime date) {
          date = DateTime.Parse(date.ToString("d"));
          return date;
      }
      public static DateTime ToDate(this string value) {
          return DateTime.Parse(value);
      }
    public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value)
    { 

      foreach (var v in source)
        if (v.Equals(value))
          return true;
      return false;
    }
    public static void Replace<TSource>(this List<TSource> source, TSource value, TSource replaceWith) where TSource : class
    {
      for (int i = 0; i < source.Count; i++)
      {
        if (source[i] == value)
          source[i] = replaceWith;
      }
    }
    public static void AddNullControlData<T>(this System.Windows.Forms.ListViewItem.ListViewSubItemCollection item,Nullable<T> src) where T:struct
    {
      if (src.HasValue)
        item.Add(src.ToString());
      else
        item.Add("");
    }
    public static T ParseStruct<T>(this string txt,Func<string,T> func)where T:struct
    {
      if (string.IsNullOrEmpty(txt))
        return default(T);
      else
        return func(txt);
    }
    public static T ParseStruct<T>(this object obj, Func<string, T> func) where T : struct {
        if (obj==null)
            return default(T);
        else
            return func(obj.ToString());
    }
    public static Nullable<T>  ParseNullable<T>(this string txt,Func<string,Nullable<T>> func) where T : struct
    {      
      if(!string.IsNullOrEmpty(txt))
        return func(txt);
      else
        return null;
    }
    public static T GetValueOrZero<T>(this Nullable<T> d) where T : struct
    {
      if (d.HasValue)
        return (T)d ;
      else
      {

        return (T)Convert.ChangeType(0, typeof(T));
      }
    }
    public static string ProperyToStringOrEmpty<T>(this T obj, Func<T,string> func)where T:class
    {      
      if (obj != null)
        return func(obj);
      else
        return "";
    }
    public static void IfEqualToSetTrue<T>(this T obj,string source,string destination,Action<bool> doAction) where T : class {
        if (source == destination)
            doAction(true);
      
    }
    public static string ToStringOrEmpty(this object obj)
    {
      if (obj != null)
        return obj.ToString();
      else
        return "";
    }
    public static string ToStringOrEmpty(this object obj, string defaultValue) {
        if (obj != null) {
            if (string.IsNullOrEmpty(obj.ToString()))
                return defaultValue;
            else
                return obj.ToString();
        } else
            return defaultValue;
    }
    public static string FromNullableToString<T>(this Nullable<T> d) where T : struct
    {
      if (d.HasValue)
        return d.Value.ToString();
      else
        return "";
      
    }
    public static string ToString<T>(this T number,int digits)where T:struct
    {
      System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("tr-TR");
      string[] ary = number.ToString().Split(new char[] { ',' });
      string format = "F" + digits.ToString();

      if (ary.Length==1)
        return FromNumberToString(number,format);
      if (digits >= ary[1].Length)
        return FromNumberToString(number,format);
      string str = ary[1].Substring(digits);
      bool artir = false;
      for (int i = str.Length - 1; i > -1; i--)
      {
        int y = int.Parse(str[i].ToString());
        if (i == 0 && y >= 5)
        {
          artir = true;
          break;
        }
        if (y >= 5)
        {
          int sayi = int.Parse(str[i - 1].ToString());
          sayi++;
          str = str.Remove(i - 1, 1);
          str = str.Insert(i - 1, sayi.ToString());
        }
      }
      if (artir)
      {
        str = ary[1].Substring(0, digits);
        int sayi = int.Parse(str[digits - 1].ToString());
        sayi++;
        str = str.Remove(digits - 1, 1);
        str = str.Insert(digits - 1, sayi.ToString());
        return ary[0] + "," + str;
      }
      else
      {        
        return FromNumberToString(number,format);      
      }
    }
    public static string FromNumberToString<T>(this T d, string format) where T : struct
    {
      if (typeof(T) == typeof(double))
      {
        double val = (double)Convert.ChangeType(d, typeof(double));
        return val.ToString(format);
      }
      else if (typeof(T) == typeof(float))
      {
        float val = (float)Convert.ChangeType(d, typeof(float));
        return val.ToString(format);
      }
      else
        return d.ToString();
    }
    public static string FromNumberToString<T>(this T d, int digit) where T : struct
    {
      if (typeof(T) == typeof(double))
      {
        double val = (double)Convert.ChangeType(d, typeof(double));
        return val.ToString(digit);
      }
      else if (typeof(T) == typeof(float))
      {
        float val = (float)Convert.ChangeType(d, typeof(float));
        return val.ToString(digit);
      }
      else
        return d.ToString();
    }
    public static string FromNullableToString<T>(this Nullable<T> d,string format) where T : struct
    {
      if (d.HasValue)
      {
        if(typeof(T)==typeof(double))
        {
          double val= (double)Convert.ChangeType(d.Value, typeof(double));
          return val.ToString(format);
        }
        else if(typeof(T)==typeof(float))
        {
          float val = (float)Convert.ChangeType(d.Value, typeof(float));
          return val.ToString(format);
        } 
        else
          return d.Value.ToString();
      }
      else
        return "";
    }
    public static string FromNullableToString<T>(this Nullable<T> d,int digit) where T : struct
    {
      if (d.HasValue)
      {
        if (typeof(T) == typeof(double))
        {
          double val = (double)Convert.ChangeType(d.Value, typeof(double));
          return val.ToString(digit);
        }
        else if (typeof(T) == typeof(float))
        {
          float val = (float)Convert.ChangeType(d.Value, typeof(float));
          return val.ToString(digit);
        }
        else
          return d.Value.ToString(digit);
      }
      else
        return "";
    }
    public static void Replace(this DataTable table, string columnName, string value, string replaceWith)
    {
      for (int i = 0;i<table.Rows.Count; i++)
      {
        string dr = table.Rows[i][columnName].ToStringOrEmpty();
        if (!string.IsNullOrEmpty(dr) && dr.Trim() == value)
        {
          table.Rows[i][columnName] = replaceWith;
        }
      }
    }
    public static void Replace<T>(this List<T> liste,string propertyName,object value,object replcaWith)
    {
      foreach (T item in liste)
      {
        object obj=item.GetType().GetProperty(propertyName).GetValue(item,null);
        if (obj.ToString().Trim() == value.ToString())
        {
          item.GetType().GetProperty(propertyName).SetValue(item, replcaWith, null);
        }
      }
    }
    public static DataTable ToDataTable<T>(this IList<T> list)
    {
      DataTable dt = new DataTable();
      PropertyInfo[] pi = typeof(T).GetProperties();
      // Loop through each property, and add it as a column to the datatable
      foreach (PropertyInfo p in pi)
      {
        // The the type of the property
        Type columnType = p.PropertyType;
        
        // We need to check whether the property is NULLABLE
        if (p.PropertyType.IsGenericType && p.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
        {// If it is NULLABLE, then get the underlying type. eg if "Nullable<int>" then this will return just "int"
          columnType = p.PropertyType.GetGenericArguments()[0];
        }
                // Add the column definition to the datatable.
        dt.Columns.Add(new DataColumn(p.Name, columnType));
      }

      // For each object in the list, loop through and add the data to the datatable.
      foreach (object obj in list)
      {
        object[] row = new object[pi.Length];
        int i = 0;

        foreach (PropertyInfo p in pi)
        {
          row[i++] = p.GetValue(obj, null);
        }

        dt.Rows.Add(row);
      }

      return dt;
    }
    //public static DataTable ToDataTable<T>(this IList<T> data)
    //{
    //  PropertyDescriptorCollection props =
    //      TypeDescriptor.GetProperties(typeof(T));
    //  DataTable table = new DataTable();
    //  for (int i = 0; i < props.Count; i++)
    //  {
    //    PropertyDescriptor prop = props[i];
        
    //    table.Columns.Add(prop.Name, prop.PropertyType);
    //  }
    //  object[] values = new object[props.Count];
    //  foreach (T item in data)
    //  {
    //    for (int i = 0; i < values.Length; i++)
    //    {
    //      values[i] = props[i].GetValue(item);
    //    }
    //    table.Rows.Add(values);
    //  }
    //  return table;
    //}
  }
}
