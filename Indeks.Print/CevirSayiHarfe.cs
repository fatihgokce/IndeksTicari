using System;
using System.Collections.Generic;
using System.Text;

namespace Indeks.Print
{
  class CevirSayiHarfe
  {
    private string _sayi;
    public CevirSayiHarfe(string sayi)
    {
      _sayi = sayi;
    }
    public string Cevir()
    {
      string[] ary = _sayi.Split(',');
      string tl = ary[0];

      StringBuilder ifade = new StringBuilder("");
      int basamak = tl.Length;
      for (int i = 0; i < tl.Length; i++)
      {
        string bas = "";
        string harf = "";
        if (basamak <= 2)
        {
          if (basamak == 1 && tl[i] != '0')
            harf = RakamHarf(tl[i]);
          else
            bas = Onlar(tl[i]);
        }
        else if((basamak==3 || basamak==4) && tl[i]!='0')
        {
          bas = Basamak(basamak);
          harf = RakamHarf(tl[i]);
        } else if (basamak == 5 && tl[i]!='0') {
            bas =Onlar(tl[i]);
            harf ="";
        } else if (basamak == 6 && tl[i]!='0') {
            bas = Yüzler(tl[i]) ;
            harf = "";
        } 
        if (harf == "bir" && basamak == 1)
          ifade.Append(harf);
        else
        {
          if (harf != "bir")
            ifade.Append(harf);
          ifade.Append(bas);
        }
        basamak--;
      }
      ifade.Append(" TL");
      if (ary.Length == 2)
      {
        string kr = ary[1];
        ifade.Append(", ");
        ifade.Append(Onlar(kr[0]));
        if (kr.Length>1 && kr[1] != '0')
          ifade.Append(RakamHarf(kr[1]));
        ifade.Append(" kr dir");
      }
      else
        ifade.Append(" dir");
      return ifade.ToString();
    }
    //public string GetirKurus()
    //{

    //}
  
    private string Basamak(int uzunluk)
    {
      if (uzunluk == 3)
        return "yüz";
      else if (uzunluk == 4)
        return "bin";
      else if (uzunluk == 5)
        return "onbin";
      else if (uzunluk == 6)
        return "yüzbin";
      else if (uzunluk == 7)
        return "milyon";
      else if (uzunluk == 8)
        return "onmilyon";
      else if (uzunluk == 9)
        return "yüzmilyon";
      else if (uzunluk == 10)
        return "milyar";
      return "";
    }
    private string RakamHarf(char rakam)
    {
      string retVal = "";
      switch (rakam)
      {
        //case '0': retVal = "sıfır"; break;
        case '1': retVal = "bir"; break;
        case '2': retVal = "iki"; break;
        case '3': retVal = "üç"; break;
        case '4': retVal = "dört"; break;
        case '5': retVal = "beş"; break;
        case '6': retVal = "altı"; break;
        case '7': retVal = "yedi"; break;
        case '8': retVal = "sekiz"; break;
        case '9': retVal = "dokuz"; break;
      }
      return retVal;
    }
    private string Onlar(char rakam)
    {
      string retVal = "";
      switch (rakam)
      {
        case '1': retVal = "on"; break;
        case '2': retVal = "yirmi"; break;
        case '3': retVal = "otuz"; break;
        case '4': retVal = "kırk"; break;
        case '5': retVal = "elli"; break;
        case '6': retVal = "atmış"; break;
        case '7': retVal = "yetmiş"; break;
        case '8': retVal = "seksen"; break;
        case '9': retVal = "doksan"; break;
      }
      return retVal;
    }
    private string Yüzler(char rakam) {
        string retVal = "";
        switch (rakam) {
            case '1': retVal = "yüz"; break;
            case '2': retVal = "ikiyüz"; break;
            case '3': retVal = "üçyüz"; break;
            case '4': retVal = "dörtyüz"; break;
            case '5': retVal = "beşyüz"; break;
            case '6': retVal = "atıyüz"; break;
            case '7': retVal = "yediyüz"; break;
            case '8': retVal = "sekizyüz"; break;
            case '9': retVal = "dokuzyüz"; break;
        }
        return retVal;
    }
    //private string Basamak(int basamakUzunluk)
    //{
    //  string retVal="";
    //  switch (basamakUzunluk)
    //  {
    //    case 2: retVal = onlar[index]; break;
    //      case 
    //  }
    //}
  }
}
