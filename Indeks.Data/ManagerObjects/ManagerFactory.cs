using System;
using System.Collections.Generic;
using System.Text;
using Indeks.Data.Base;
namespace Indeks.Data.ManagerObjects
{
    public interface IManagerFactory
    {
	  // Get Methods
	  ICariManager GetCariManager();	
	  IFatIrsUstManager GetFatirsUstManager();		
      //IFaturaNoManager GetFaturaNoManager();		
	  IKurManager GetKurManager();		
	  IStokHareketManager GetStokHareketManager();		
	  IStokManager GetStokManager();	

	  ISubeManager GetSubeManager();
      IKullaniciManager GetKullaniciManager();
      ICariHareketManager GetCariHareketManager();
      IKasaManager GetKasaManager();
      IKasaHarManager GetKasaHarManager();
      ICariCategoryManager GetCariCategoryManager();
      IStokCategoryManager GetStokCategoryManager();
      IDizaynManager GetDizaynManager();
      IDizaynGenelManager GetDizaynGenelManager();
      IDizaynKalemManager GetDizaynKalemManager();
      ISiparisKalemManager GetSiparisKalemManager();
      ISiparisUstManager GetSiparisUstManager();
      IBankaHesapManager GetBankaHesapManager();
      IHesapHareketManager GetHesapHareketManager();
      IStokBirimManager GetStokBirimManager();
      ICekManager GetCekManager();
      ISenetManager GetSenetManager();
      IAyarlarManager GetAyarlarManager(string subeKodu);
      IOzelGelirGiderManager GetOzelGelirGiderManager();
      IBankaManager GetBankaManager();
      IILManager GetILManager();
      IPostManager GetPostManager();
    }

    public class ManagerFactory : IManagerFactory
    {
      #region Constructors
      //public ManagerFactory()
      //{
      //}
      public ManagerFactory(string conSring,SqlServerType sqlType)
      {
        DataBaseInfo.ConString = conSring;
        DataBaseInfo.SqlType = sqlType;
      }
      #endregion
      #region Get Methods
      public IPostManager GetPostManager() {
          return new PostManager();
      }
      public IILManager GetILManager() {
          return new ILManager();
      }
      public IBankaManager GetBankaManager() {
          return new BankaManager();
      }
      public IOzelGelirGiderManager GetOzelGelirGiderManager() {
          return new OzelGelirGiderManager();
      } 
      public IAyarlarManager GetAyarlarManager(string subeKodu) {
          return new AyarlarManager(subeKodu);
      }
      public ISenetManager GetSenetManager() {
          return new SenetManager();
      }
      public ICekManager GetCekManager() {
          return new CekManager();
      }
      public IStokBirimManager GetStokBirimManager()
      {
        return new StokBirimManager();
      }
      public IBankaHesapManager GetBankaHesapManager()
      {
        return new BankaHesapManager();
      }
      public IHesapHareketManager GetHesapHareketManager()
      {
        return new HesapHareketManager();
      }
      public ISiparisKalemManager GetSiparisKalemManager()
      {
        return new SiparisKalemManager(); 
      }
      public ISiparisUstManager GetSiparisUstManager()
      {
        return new SiparisUstManager();
      }
      public IDizaynKalemManager GetDizaynKalemManager()
      {
        return new DizaynKalemManager();
      }
      public IDizaynManager GetDizaynManager()
      {
        return new DizaynManager();
      }
      public IDizaynGenelManager GetDizaynGenelManager()
      {
        return new DizaynGenelManager();
      }
      public IStokCategoryManager GetStokCategoryManager()
      {
        return new StokCategoryManager();
      }
      public ICariCategoryManager GetCariCategoryManager()
      {
        return new CariCategoryManager();
      }
		  public ICariManager GetCariManager()
      {
        return new CariManager();
      }
		
      public IFatIrsUstManager GetFatirsUstManager()
      {
        return new FatIrsUstManager();
      }
      //public IFaturaNoManager GetFaturaNoManager()
      //{
      //  return new FaturaNoManager();
      //}
      public IKurManager GetKurManager()
      {
        return new KurManager();
      }
      public IStokHareketManager GetStokHareketManager()
      {
        return new StokHareketManager();
      }
      public IStokManager GetStokManager()
      {
        return new StokManager();
      } 
      public ISubeManager GetSubeManager()
      {
        return new SubeManager();
      }
      public IKullaniciManager GetKullaniciManager()
      {
        return new KullaniciManager();
      }
      public ICariHareketManager GetCariHareketManager()
      {
        return new CariHareketManager();
      }
      public IKasaManager GetKasaManager()
      {
        return new KasaManager();
      }
      public IKasaHarManager GetKasaHarManager()
      {
        return new KasaHarManager();
      }
      #endregion
    }
}
