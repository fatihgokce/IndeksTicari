using System;
using System.Collections.Generic;
using System.Text;
using Indeks.Data.BusinessObjects;
using Indeks.Data.ManagerObjects;
namespace Indeks.Views
{
  public static class UserInfo
  {
    private static Kullanici _kullanici;
    private static Sube _sube;
    public static Kullanici Kullanici
    {
      get { return UserInfo._kullanici; }
      set { UserInfo._kullanici = value; }
    }   
    public static Sube Sube
    {
      get 
      {
        // Daha Sonra Silineçek
        //IManagerFactory managerFac = new ManagerFactory();
        //ISubeManager managerSube = managerFac.GetSubeManager();
        //_sube = managerSube.GetById(1,false);
        return UserInfo._sube;
      }
      set { UserInfo._sube = value; }
    }
    public static string Encryt(string input)
    {
      System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
      byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
      bs = x.ComputeHash(bs);
      System.Text.StringBuilder s = new System.Text.StringBuilder();
      foreach (byte b in bs)
      {
        s.Append(b.ToString("X2").ToUpper());
      }
      string retvalue = s.ToString();
      if (retvalue.Length >= 16)
        retvalue = retvalue.Substring(0, 16);

      return retvalue;
    }
    

  }
}
