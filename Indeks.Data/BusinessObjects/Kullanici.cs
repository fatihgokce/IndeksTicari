using System;
using System.Collections;
using System.Collections.Generic;

using Indeks.Data.Base;
using System.Security.Cryptography;
using System.Text;

namespace Indeks.Data.BusinessObjects
{
  public partial class Kullanici : BusinessBase<int>
  {
    #region Declarations
    private string _userName = null;
    private string _password = null;
    private bool? _adminmi = null;
    private Sube _sube = null;
    #endregion
    #region Constructors
    public Kullanici() { }
    #endregion
    #region Methods
    public override int GetHashCode()
    {
      System.Text.StringBuilder sb = new System.Text.StringBuilder();
      sb.Append(this.GetType().FullName);
      sb.Append(_userName);
      sb.Append(_password);
      sb.Append(_adminmi);
      sb.Append(SubelerdeOrtak);
      return sb.ToString().GetHashCode();
    }
    #endregion
    #region Properties
    public virtual bool? SubelerdeOrtak { get; set; }
    public virtual string UserName
    {
      get { return _userName; }
      set
      {
        OnUserNameChanging();
        _userName = value;
        OnUserNameChanged();
      }
    }
    partial void OnUserNameChanging();
    partial void OnUserNameChanged();
    public virtual string Password
    {
      get { return _password; }
      set
      {
        OnPasswordChanging();
        //if (!string.IsNullOrEmpty(value))
        _password =value;
        OnPasswordChanged();
      }
    }
    partial void OnPasswordChanging();
    partial void OnPasswordChanged();

    public virtual bool? Adminmi
    {
      get { return _adminmi; }
      set
      {
        OnAdminmiChanging();
        _adminmi = value;
        OnAdminmiChanged();
      }
    }
    partial void OnAdminmiChanging();
    partial void OnAdminmiChanged();
    public virtual Sube Sube
    {
      get { return _sube; }
      set
      {
        OnSubeChanging();
        _sube = value;
        OnSubeChanged();
      }
    }
    partial void OnSubeChanging();
    partial void OnSubeChanged();
    public static string Encryt(string input)
    {
      System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
      byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
      bs = x.ComputeHash(bs);
      System.Text.StringBuilder s = new System.Text.StringBuilder();
      foreach (byte b in bs)
      {
        s.Append(b.ToString("X2"));
      }
      string retvalue = s.ToString();
      //if (retvalue.Length >= 16)
      //  retvalue = retvalue.Substring(0, 16);
      return retvalue;
      //byte[] ByteData = Encoding.ASCII.GetBytes(input);
      //MD5 oMd5 = MD5.Create(); //MD5 nesnesini oluşturduk
      //byte[] HashData = oMd5.ComputeHash(ByteData); //Hash değeri hesaplanıyor..
      //StringBuilder oSb = new StringBuilder();
      //for (int x = 0; x < HashData.Length; x++)
      //{
      //  oSb.Append(HashData[x].ToString("x2"));
      //}
      //return oSb.ToString();
      
    }
    #endregion
  }
}
