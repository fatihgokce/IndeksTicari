using System;
using System.Collections.Generic;
using System.Text;

namespace Indeks.Print
{
  public static class HelperExtension
  {
    public static string ToString<T>(this T number, int digits) where T : struct
    {
      System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("tr-TR");
      string[] ary = number.ToString().Split(new char[] { ',' });
      string format = "F" + digits.ToString();

      if (ary.Length == 1)
        return FromNumberToString(number, format);
      if (digits >= ary[1].Length)
        return FromNumberToString(number, format);
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
        return FromNumberToString(number, format);
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
  }
}
