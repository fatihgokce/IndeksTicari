using System;
using System.Collections.Generic;
using System.Text;
using Indeks.Data.Base;
using Indeks.Data.BusinessObjects;
using Indeks.Data.ManagerObjects;
using System.Drawing.Printing;
using Indeks.Data.Report;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
namespace Indeks.Print
{
  public class PrintFatIrs
  {
    IManagerFactory _mngFac;
    Dizayn _dizayn;
    HesaplaGenelToplam _genelToplam;
    FatIrsUst _fatIrsUst;
    IList<StokHarRpr> _stokListe;
    IDizaynGenelManager _mngDizGenel;
    ICariManager _mngCari;
    ICariHareketManager _mngCariHar;
    IDizaynKalemManager _mngKal;
    PrintDocument printDoc = new PrintDocument();
    DizaynGenel _dizGenel;
    Font font;
    float BirimHarf;
    public PrintFatIrs(IManagerFactory mngFac, FatIrsUst fatIrsUst,Dizayn dizayn,IList<StokHarRpr>stokListe,HesaplaGenelToplam genelToplam)
    {
      _mngFac = mngFac;
      _fatIrsUst = fatIrsUst;
      _dizayn = dizayn;
      _genelToplam = genelToplam;
      _stokListe = stokListe;
      _mngDizGenel = _mngFac.GetDizaynGenelManager();
      _mngCari = _mngFac.GetCariManager();
      _mngCariHar = _mngFac.GetCariHareketManager();
      _mngKal = _mngFac.GetDizaynKalemManager();
      if (_fatIrsUst.KdvDahilmi.Value)
        ChangePrice();
      printDoc.PrintPage+=new PrintPageEventHandler(OnPrintDoc);
    }
    void ChangePrice()
    {
      //if (_kdvDahil)
      //{
      //  return (SatisAlisFiyat(sh) * sh.KdvOrani) / (100 + sh.KdvOrani);// kdv
      //}
      _genelToplam.KdvDahil = false;
      double kdv = 0;
      foreach (StokHarRpr rpr in _stokListe)
      {
        kdv = (rpr.Fiyat) * rpr.KdvOrani / (rpr.KdvOrani + 100);
        rpr.Fiyat = rpr.Fiyat - kdv;
        rpr.Tutar = rpr.Fiyat * rpr.HareketMiktar;        
      }
      _genelToplam.ListStokHar = _stokListe;
    }
    public void Print()
    {
      _dizGenel = _mngDizGenel.GetByDizaynNo(_dizayn.Id);    

      printDoc.PrinterSettings.PrinterName = _dizGenel.YaziciAdi;
      if(_dizGenel.Yataymi)
          printDoc.DefaultPageSettings.Landscape = true;
      PrintPreviewDialog dia = new PrintPreviewDialog();
      dia.Document = printDoc;
 
      if (_dizGenel.BaskiOnizleme)
      {
        dia.Show();
        //if (res != DialogResult.Cancel)
        //  printDoc.Print();
      }
      else
        printDoc.Print();
    }
     //if (cmbSahaYeri.SelectedIndex == 0)
     // {        
     //   cmbAlanIsim.Items.AddRange(new string[] { "Aciklama", "FaturaNo", "FaturaTarih", "IrsaliyeNo", "SevkTarih", "CariAdSoyad", "CariAdres", "CariKod" });
     // }
     // else if (cmbSahaYeri.SelectedIndex == 1)
     // {
     //   cmbAlanIsim.Items.AddRange(new string[] { "Aciklama", "Yalniz", "IndirimToplam", "FaturaToplam", "KdvToplam" });
       
     // }
     // else
     // {
     //   cmbAlanIsim.Items.AddRange(new string[] { "StokKodu", "StokIsim", "Kdv", "Adet", "BirimFiyat", "Tutar","Barkod" });
     // }
    void Yaz(Graphics e, DizaynKalem kal, string input)
    {
      float yPozisyon;
      if (kal.Uzunluk.HasValue)
      {
        if (kal.Uzunluk.Value == 0)
        {
          e.DrawString(input, font, Brushes.Black, BirimHarf * kal.Sutun, BirimHarf * kal.Satir);
        }
        else
        {
          if (input.Length > kal.Uzunluk)
          {
            int payda = input.Length / kal.Uzunluk.Value;
            yPozisyon = BirimHarf * kal.Satir;
            for (int i = 0; i < payda; i++)
            {
              string sf = input.Substring(i * kal.Uzunluk.Value, kal.Uzunluk.Value);
              e.DrawString(sf, font, Brushes.Black, BirimHarf * kal.Sutun, yPozisyon);
              yPozisyon += BirimHarf;
            }
            int kalan = input.Length % kal.Uzunluk.Value;
            if (kalan != 0)
            {
              string f = input.Substring(input.Length - kalan);
              e.DrawString(f, font, Brushes.Black, BirimHarf * kal.Sutun, yPozisyon);
            }
          }
          else
          {
            e.DrawString(input, font, Brushes.Black, BirimHarf * kal.Sutun, BirimHarf * kal.Satir);
          }
        }
      }
      else
      {
        e.DrawString(input, font, Brushes.Black, BirimHarf * kal.Sutun, BirimHarf * kal.Satir);
      }
    }
    float Yaz(Graphics e, byte Satir,byte Sutun,byte?Uzunluk, string input)
    {
      float yPozisyon=0;
      if (Uzunluk.HasValue)
      {
        if (Uzunluk.Value == 0)
        {
          e.DrawString(input, font, Brushes.Black, BirimHarf * Sutun, BirimHarf * Satir);
        }
        else
        {
          if (input.Length > Uzunluk)
          {
            int payda = input.Length / Uzunluk.Value;
            yPozisyon = BirimHarf * Satir;
            for (int i = 0; i < payda; i++)
            {
              string sf = input.Substring(i * Uzunluk.Value, Uzunluk.Value);
              e.DrawString(sf, font, Brushes.Black, BirimHarf * Sutun, yPozisyon);
              yPozisyon += BirimHarf;
            }
            int kalan = input.Length % Uzunluk.Value;
            if (kalan != 0)
            {
              string f = input.Substring(input.Length - kalan);
              e.DrawString(f, font, Brushes.Black, BirimHarf * Sutun, yPozisyon);
            }
          }
          else
          {
            e.DrawString(input, font, Brushes.Black, BirimHarf * Sutun, BirimHarf * Satir);
          }
        }
      }
      else
      {
        e.DrawString(input, font, Brushes.Black, BirimHarf * Sutun, BirimHarf * Satir);
      }
      return yPozisyon;
    }
    private void OnPrintDoc(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
      font = new Font(_dizGenel.FontAdi,_dizGenel.FontBuyukluk);
      float yPozisyon = 0;
      float leftMargin = 0; //e.MarginBounds.Left; 
      float topMargin = 0;//e.MarginBounds.Top; 
      //1-Ust
      //2-Alt
      //3-Kalem
      BirimHarf = font.GetHeight(e.Graphics);
      List<DizaynKalem>kalemList= _mngKal.GetByDizaynGenelNo(_dizGenel.Id);
      List<DizaynKalem>ustKalem= kalemList.FindAll(x=>x.SahaYeri=="1");
      List<DizaynKalem> altKalem = kalemList.FindAll(x => x.SahaYeri == "2");
      List<DizaynKalem> kalemKalem = kalemList.FindAll(x => x.SahaYeri == "3");
      Cari cari = null;
      if (!string.IsNullOrEmpty(_fatIrsUst.CariKodu))
        cari = _mngCari.GetById(_fatIrsUst.CariKodu,false);
      UstBilgileriniYaz(e, ustKalem, cari);     
      AltBilgileriniYaz(e, altKalem);   
      KalemBilgileriniYaz(e, kalemKalem);
     
    }
    string SubString(string str,int? uzunluk) {
        if (uzunluk.HasValue && uzunluk.Value > 0 && str.Length > uzunluk.Value) {
            return str.Substring(0, uzunluk.Value);
        } else
            return str;

    }
    private void KalemBilgileriniYaz(System.Drawing.Printing.PrintPageEventArgs e, List<DizaynKalem> listeKalem) {
        //cmbAlanIsim.Items.AddRange(new string[] { "StokKodu", "StokIsim", "Kdv", "Adet", "BirimFiyat", "Tutar" });
       
        while (listeKalem.Count>0) {
            DizaynKalem kalStokKodu = listeKalem.Find(x => x.AlanIsim == "StokKodu");
            DizaynKalem kalStokIsim = listeKalem.Find(x => x.AlanIsim == "StokIsim");
            DizaynKalem kalKdv = listeKalem.Find(x => x.AlanIsim == "Kdv");
            DizaynKalem kalAdet = listeKalem.Find(x => x.AlanIsim == "Adet");
            DizaynKalem kalBirFiyat = listeKalem.Find(x => x.AlanIsim == "BirimFiyat");
            DizaynKalem kalTutar = listeKalem.Find(x => x.AlanIsim == "Tutar");
            DizaynKalem kalBirim = listeKalem.Find(x => x.AlanIsim == "Birim");
            DizaynKalem kalBarkod = listeKalem.Find(x => x.AlanIsim == "Barkod");
            byte max=listeKalem.Max(x=>x.Satir);
            byte min=listeKalem.Min(x=>x.Satir);
            byte satirFark=(byte)(max-min);
            satirFark+=1;
            listeKalem.Remove(kalStokKodu);
            listeKalem.Remove(kalStokIsim);
            listeKalem.Remove(kalKdv);
            listeKalem.Remove(kalAdet);
            listeKalem.Remove(kalBirFiyat);
            listeKalem.Remove(kalTutar);
            listeKalem.Remove(kalBirim);
            listeKalem.Remove(kalBarkod);
            byte s = 0;
            foreach (StokHarRpr rpr in _stokListe) {
               
                //float yposIsim = 0;
                //float yposStok = 0;
                //float yposBarkod = 0;
                string input = "";
                //if (kalStokKodu!=null)
                //    yposStok = Yaz(e.Graphics, (byte)(s + kalStokKodu.Satir), kalStokKodu.Sutun, kalStokKodu.Uzunluk, rpr.StokKodu);
                //if (kalBarkod!=null)
                //    yposBarkod = Yaz(e.Graphics, (byte)(s + kalBarkod.Satir), kalBarkod.Sutun, kalBarkod.Uzunluk, rpr.Barkod);
                //if (kalStokIsim!=null)
                //    yposIsim = Yaz(e.Graphics, (byte)(s + kalStokIsim.Satir), kalStokIsim.Sutun, kalStokIsim.Uzunluk, rpr.StokAdi);
                if (kalStokKodu != null) {
                    Yaz(e.Graphics, (byte)(s + kalStokKodu.Satir), kalStokKodu.Sutun, kalStokKodu.Uzunluk,SubString(rpr.StokKodu,kalStokKodu.Uzunluk));

                }
                if (kalBarkod != null)
                    Yaz(e.Graphics, (byte)(s + kalBarkod.Satir), kalBarkod.Sutun, kalBarkod.Uzunluk,SubString(rpr.Barkod,kalBarkod.Uzunluk));
                if (kalStokIsim != null)
                    Yaz(e.Graphics, (byte)(s + kalStokIsim.Satir), kalStokIsim.Sutun, kalStokIsim.Uzunluk,SubString(rpr.StokAdi,kalStokIsim.Uzunluk));
                if (kalKdv!=null) {
                    if (kalKdv.Ondalik.HasValue) {
                        if (kalKdv.Ondalik.Value > 0)
                            input = rpr.KdvOrani.ToString("F" + kalKdv.Ondalik.Value.ToString());
                        else
                            input = rpr.KdvOrani.ToString();
                    } else
                        input = rpr.KdvOrani.ToString();
                    Yaz(e.Graphics, (byte)(s + kalKdv.Satir), kalKdv.Sutun, kalKdv.Uzunluk, input);
                }
                if (kalAdet!=null)
                    Yaz(e.Graphics, (byte)(s + kalAdet.Satir), kalAdet.Sutun, kalAdet.Uzunluk, rpr.HareketMiktar.ToString());
                input = "";
                if (kalBirFiyat!=null) {
                    if (kalBirFiyat.Ondalik.HasValue) {
                        if (kalBirFiyat.Ondalik.Value > 0)
                            input = rpr.Fiyat.ToString("F" + kalBirFiyat.Ondalik.Value.ToString());
                        else
                            input = rpr.Fiyat.ToString();
                    } else
                        input = rpr.Fiyat.ToString();
                    Yaz(e.Graphics, (byte)(s + kalBirFiyat.Satir), kalBirFiyat.Sutun, kalBirFiyat.Uzunluk, input);
                }
                input = "";
                if (kalTutar != null) {
                    if (kalTutar.Ondalik.HasValue) {
                        if (kalTutar.Ondalik.Value > 0)
                            input = rpr.Tutar.ToString("F" + kalTutar.Ondalik.Value.ToString());
                        else
                            input = rpr.Tutar.ToString("F2");
                    } else
                        input = rpr.Tutar.ToString("F2");
                    Yaz(e.Graphics, (byte)(s + kalTutar.Satir), kalTutar.Sutun, kalTutar.Uzunluk, input);
                }
                if (kalBirim!=null) {
                    Yaz(e.Graphics, (byte)(s + kalBirim.Satir), kalBirim.Sutun, kalBirim.Uzunluk, rpr.HareketBirim);
                }
                //if (yposStok>0 || yposIsim>0 || yposBarkod>0) {
                //    float which = 0;
                //    byte satir = 0;
                //    if (yposStok >= yposBarkod && yposStok >= yposIsim) { 
                //        which = yposStok;
                //        satir = kalStokKodu.Satir;
                //    } else if (yposIsim >= yposBarkod && yposIsim >= yposStok) {
                //        which = yposIsim;
                //        satir = kalStokIsim.Satir;
                //    } else {
                //        which = yposBarkod;
                //        satir = kalBarkod.Satir;
                //    }
                //    float tempY = BirimHarf * (byte)(s + satir);
                //    if (which > tempY) {
                //        while (which > tempY) {
                //            tempY += BirimHarf;
                //            s++;
                //        }
                //        s++;
                //    } else
                //        s++;
                //} else
                s = (byte)(s + satirFark);
                

            }//StokHarRpr
        }
    }

    private void AltBilgileriniYaz(System.Drawing.Printing.PrintPageEventArgs e, List<DizaynKalem> altKalem) {
        foreach (DizaynKalem kal in altKalem) {
            if (kal.AlanIsim == "Aciklama") {
                Yaz(e.Graphics, kal, kal.Aciklama);
            } else if (kal.AlanIsim == "VadeTarih" && _fatIrsUst.VadeTarih.HasValue) {
                if (kal.BaslikYaz) {
                    string input = kal.Aciklama + _fatIrsUst.VadeTarih.Value.ToShortDateString();
                    Yaz(e.Graphics, kal, input);
                } else
                    Yaz(e.Graphics, kal, _fatIrsUst.VadeTarih.Value.ToShortDateString());
            } else if (kal.AlanIsim == "Yalniz") {
                DizaynKalem genelToplam = altKalem.Find(x => x.AlanIsim == "GenelToplam");
                string s_genelToplam = "";
                if (genelToplam != null) {
                    if (genelToplam.Ondalik.Value > 0)
                        s_genelToplam = _genelToplam.GenelToplam().ToString("F" + genelToplam.Ondalik.Value.ToString());
                    else
                        s_genelToplam = _genelToplam.GenelToplam().ToString("F2");

                } else
                    s_genelToplam = _genelToplam.GenelToplam().ToString("F2");
                CevirSayiHarfe cevir = new CevirSayiHarfe(s_genelToplam);
                string input = cevir.Cevir();
                if (kal.BaslikYaz)
                    input = string.Format("{0} {1}", kal.Aciklama, input);
                Yaz(e.Graphics, kal, input);
            } else if (kal.AlanIsim == "IndirimToplam") {
                string input = "";
                if (kal.Ondalik.HasValue) {
                    if (kal.Ondalik.Value > 0)
                        input = _genelToplam.SatirIskantosuToplam().ToString("F" + kal.Ondalik.Value.ToString());
                    else
                        input = _genelToplam.SatirIskantosuToplam().ToString("F2");
                } else
                    input = _genelToplam.SatirIskantosuToplam().ToString("F2");
                if (kal.BaslikYaz) {
                    input = kal.Aciklama + " " + input;
                    Yaz(e.Graphics, kal, input);
                } else
                    Yaz(e.Graphics, kal, input);
            } else if (kal.AlanIsim == "GenelToplam") {
                string input = "";
                if (kal.Ondalik.HasValue) {
                    if (kal.Ondalik.Value > 0)
                        input = _genelToplam.GenelToplam().ToString("F" + kal.Ondalik.Value.ToString());
                    else
                        input = _genelToplam.GenelToplam().ToString("F2");
                } else
                    input = _genelToplam.GenelToplam().ToString("F2");
                if (kal.BaslikYaz) {
                    input = kal.Aciklama + " " + input;
                    Yaz(e.Graphics, kal, input);
                } else
                    Yaz(e.Graphics, kal, input);
            } else if (kal.AlanIsim == "FaturaToplam") {
                string input = "";
                if (kal.Ondalik.HasValue) {
                    if (kal.Ondalik.Value > 0)
                        input = _genelToplam.AraToplam().ToString("F" + kal.Ondalik.Value.ToString());
                    else
                        input = _genelToplam.AraToplam().ToString("F2");
                } else
                    input = _genelToplam.AraToplam().ToString("F2");
                if (kal.BaslikYaz) {
                    input = kal.Aciklama + " " + input;
                    Yaz(e.Graphics, kal, input);
                } else
                    Yaz(e.Graphics, kal, input);
            } else if (kal.AlanIsim == "KdvToplam") {
                bool flag = true;
                List<StokHarRpr> yeniListe;
                List<StokHarRpr> liste = new List<StokHarRpr>();
                foreach (StokHarRpr rpr in _stokListe)
                    liste.Add(rpr);

                byte satir = 0;
                while (flag && liste[0] != null) {
                    StokHarRpr kdv = liste[0];
                    yeniListe = new List<StokHarRpr>();
                    liste.Add(kdv);
                    for (int i = 1; i < liste.Count; i++) {
                        if (kdv.KdvOrani == liste[i].KdvOrani)
                            yeniListe.Add(liste[i]);
                    }
                    liste.RemoveAll(x => x.KdvOrani == kdv.KdvOrani);

                    if (yeniListe.Count == 0) {
                        flag = false;
                        break;
                    }
                    HesaplaGenelToplam hes = new HesaplaGenelToplam(yeniListe, _genelToplam.KdvDahil);
                    string input = "KDV% " + yeniListe[0].KdvOrani.ToString() + "    :";
                    if (kal.Ondalik.HasValue) {
                        if (kal.Ondalik.Value > 0)
                            input += hes.ToplamaKdvHesapla().ToString("F" + kal.Ondalik.Value.ToString());
                        else
                            input += hes.ToplamaKdvHesapla().ToString("F2");
                    } else
                        input += hes.ToplamaKdvHesapla().ToString("F2");
                    if (kal.BaslikYaz) {
                        input += kal.Aciklama + " " + input;
                        Yaz(e.Graphics, (byte)(satir + kal.Satir), kal.Sutun, kal.Uzunluk, input);
                        Yaz(e.Graphics, kal, input);
                    } else
                        Yaz(e.Graphics, (byte)(satir + kal.Satir), kal.Sutun, kal.Uzunluk, input);
                    satir++;
                    if (liste.Count == 0) {
                        flag = false;
                        break;
                    }

                }

            }
        }
    }

    private void UstBilgileriniYaz(System.Drawing.Printing.PrintPageEventArgs e, List<DizaynKalem> ustKalem, Cari cari) {
        //cmbAlanIsim.Items.AddRange(new string[] { "Aciklama", "FaturaNo", "FaturaTarih", "FaturaSaat", "IrsaliyeNo", "SevkTarih", "SevkSaat", "CariAdSoyad", "CariAdres", "CariKod", "VergiDairesi", "VergiNumarasi", "CariTelefon", "CariBakiye" });
        foreach (DizaynKalem kal in ustKalem) {
            if (kal.AlanIsim == "Aciklama") {
                Yaz(e.Graphics, kal, kal.Aciklama);
            } else if (kal.AlanIsim == "FaturaNo") {
                if (kal.BaslikYaz) {
                    string input = kal.Aciklama + _fatIrsUst.FatirsNo;
                    Yaz(e.Graphics, kal, input);
                } else
                    Yaz(e.Graphics, kal, _fatIrsUst.FatirsNo);

            } else if (kal.AlanIsim == "FaturaTarih") {
                if (kal.BaslikYaz) {
                    string input = kal.Aciklama + _fatIrsUst.Tarih.ToShortDateString();
                    Yaz(e.Graphics, kal, input);
                } else
                    Yaz(e.Graphics, kal, _fatIrsUst.Tarih.ToShortDateString());
            } else if (kal.AlanIsim == "FaturaSaat") {
                if (kal.BaslikYaz) {
                    string input = kal.Aciklama + _fatIrsUst.Tarih.ToShortTimeString();
                    Yaz(e.Graphics, kal, input);
                } else
                    Yaz(e.Graphics, kal, _fatIrsUst.Tarih.ToShortTimeString());
            } else if (kal.AlanIsim == "IrsaliyeNo") {
                if (kal.BaslikYaz) {
                    string input = kal.Aciklama + _fatIrsUst.IrsaliyeNo;
                    Yaz(e.Graphics, kal, input);
                } else
                    Yaz(e.Graphics, kal, _fatIrsUst.IrsaliyeNo);
            } else if (kal.AlanIsim == "SevkTarih" && _fatIrsUst.SevkTarihi.HasValue) {
                if (kal.BaslikYaz) {
                    string input = kal.Aciklama + _fatIrsUst.SevkTarihi.Value.ToShortDateString();
                    Yaz(e.Graphics, kal, input);
                } else
                    Yaz(e.Graphics, kal, _fatIrsUst.SevkTarihi.Value.ToShortDateString());
            } else if (kal.AlanIsim == "SevkSaat" && _fatIrsUst.SevkTarihi.HasValue) {
                if (kal.BaslikYaz) {
                    string input = kal.Aciklama + _fatIrsUst.SevkTarihi.Value.ToShortTimeString();
                    Yaz(e.Graphics, kal, input);
                } else
                    Yaz(e.Graphics, kal, _fatIrsUst.SevkTarihi.Value.ToShortTimeString());
            } else if (kal.AlanIsim == "CariAdSoyad" && cari != null) {
                if (kal.BaslikYaz) {
                    string input = kal.Aciklama + cari.CariIsim;
                    Yaz(e.Graphics, kal, input);
                } else
                    Yaz(e.Graphics, kal, cari.CariIsim);
            } else if (kal.AlanIsim == "CariAdres" && cari != null) {
                if (kal.BaslikYaz) {
                    string input = kal.Aciklama + cari.CariAdres;
                    Yaz(e.Graphics, kal, input);
                } else
                    Yaz(e.Graphics, kal, cari.CariAdres);
            } else if (kal.AlanIsim == "CariKod" && cari != null) {
                if (kal.BaslikYaz) {
                    string input = kal.Aciklama + cari.Id;
                    Yaz(e.Graphics, kal, input);
                } else
                    Yaz(e.Graphics, kal, cari.Id);
            } else if (kal.AlanIsim == "VergiDairesi" && cari != null) {
                if (kal.BaslikYaz) {
                    string input = kal.Aciklama + cari.VergiDairesi;
                    Yaz(e.Graphics, kal, input);
                } else
                    Yaz(e.Graphics, kal, cari.VergiDairesi);
            } else if (kal.AlanIsim == "VergiNumarasi" && cari != null) {
                if (kal.BaslikYaz) {
                    string input = kal.Aciklama + cari.VergiNumarasi;
                    Yaz(e.Graphics, kal, input);
                } else
                    Yaz(e.Graphics, kal, cari.VergiNumarasi);
            } else if (kal.AlanIsim == "CariTelefon" && cari != null) {
                if (kal.BaslikYaz) {
                    string input = kal.Aciklama + cari.CariTel;
                    Yaz(e.Graphics, kal, input);
                } else
                    Yaz(e.Graphics, kal, cari.CariTel);
            } else if (kal.AlanIsim == "CariBakiye" && cari != null) {
                string input = "";
                double d = _mngCariHar.GetCariHesapBakiyesi(_fatIrsUst.Sube.Id, cari.Id);
                if (kal.Ondalik.HasValue) {
                    if (kal.Ondalik.Value > 0)
                        input = d.ToString("F" + kal.Ondalik.Value.ToString());
                    else
                        input = d.ToString("F2");
                } else
                    input = d.ToString("F2");
                if (kal.BaslikYaz) {
                    input = kal.Aciklama + " " + input;
                    Yaz(e.Graphics, kal, input);
                } else
                    Yaz(e.Graphics, kal, input);
            }
        }//ust
    }
  }
}
