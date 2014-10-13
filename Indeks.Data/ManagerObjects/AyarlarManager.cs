using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using Indeks.Data.BusinessObjects;
using Indeks.Data.Base;
using NHibernate.Criterion;
namespace Indeks.Data.ManagerObjects {
    public interface IAyarlarManager : IManagerBase<Ayarlar, string> {
        void EkleAyar(Ayarlar ayar);
        IEnumerable<Ayarlar> Ayarlar { get; }
        void Save();
        bool OtomatikCariKaydet { get; set; }
        string DatabaseYedeklemeYeri { get; set; }
        string VarSayilanFaturaTipi { get; set; }
        void LoadValues();
    }
    public class AyarlarManager:ManagerBase<Ayarlar,string>,IAyarlarManager {
        private IDictionary<string, Ayarlar> _ayarlar;
        private string _subeKodu;
        public AyarlarManager(string subeKodu) {
            _subeKodu = subeKodu;
            _ayarlar = new Dictionary<string, Ayarlar>();
            LoadValues();
        }
        private AyarlarManager() { }
        public void LoadValues() {
            IList<Ayarlar> liste = Session.QueryOver<Ayarlar>().Where(x => x.SubeKodu == _subeKodu || x.SubelerdeOrtak == true).List();
            _ayarlar.Clear();
            foreach (Ayarlar ayar in liste)
                _ayarlar.Add(ayar.Ad,ayar);
        }
        //public overrAde Ayarlar Save(Ayarlar entity) {
        //    return base.Save(entity);
        //}
        public IEnumerable<Ayarlar> Ayarlar {
            get {
                foreach (var key in _ayarlar.Keys) {
                    yield return new Ayarlar { Ad = key, Deger1 = _ayarlar[key].Deger1, SubeKodu=_subeKodu };
                }
            }
        }
        public void EkleAyar(Ayarlar ayar) {
            if (!_ayarlar.ContainsKey(ayar.Ad))
                _ayarlar.Add(ayar.Ad, ayar);
            else
                _ayarlar[ayar.Ad] = ayar;
        }
        public void Save() {
            foreach (var item in _ayarlar) {
                Ayarlar ayar = SingleOrDefault<Ayarlar>(x => x.Ad == item.Key && (x.SubeKodu==_subeKodu || x.SubelerdeOrtak==true));
                if (ayar == null)
                    ayar = new Ayarlar() { Ad = item.Key, SubeKodu =_subeKodu};
                ayar.Deger1 = item.Value.Deger1;
                ayar.SubelerdeOrtak = item.Value.SubelerdeOrtak;
                SaveOrUpdate(ayar);                
            }
        }
        public bool OtomatikCariKaydet {
            get { return GetSetting("OtomatikCariKaydet", false); }
            set { SetSetting("OtomatikCariKaydet", value); }
        }
        public string DatabaseYedeklemeYeri {
            get {
                return GetSetting("YedeklemeYeri","");
            }
            set {
                SetSetting("YedeklemeYeri",value,true);
            }
        }
        public string VarSayilanFaturaTipi {
            get {
                return GetSetting("VarSayilanFaturaTipi", "");
            }
            set {
                SetSetting("VarSayilanFaturaTipi", value, true);
            }
        }
        #region getstring
        private string GetSetting(string key, string defaultValue ) 
        {
            try {
                var value = GetSetting(key);
                if (String.IsNullOrEmpty(value)) return defaultValue;
                return value;
            }
            catch {
                return defaultValue;
            }
        }

        private int GetSetting(string key, int defaultValue)
        {
            try
            {
                string intString = GetSetting(key);
                return Convert.ToInt32(intString);
            }
            catch
            {
                return defaultValue;
            }
        }

        private string GetSetting(string key)
        {
            return _ayarlar[key].Deger1;
        }
        
        public bool GetSetting( string key, bool defaultValue ) {                        
            try {                
                return Convert.ToBoolean( GetSetting( key ) );
            }
            catch {
                return defaultValue;
            }
        }
        #endregion

        #region SetSetting
        public void SetSetting(string key, string value) {
            if (_ayarlar.ContainsKey(key) == false)
                _ayarlar.Add(key, new Ayarlar { Deger1 = value });
            else {
                _ayarlar[key].Deger1 = value;
            }
        }
        public void SetSetting(string key, string value,bool subelerdeOrtak) {
            if (_ayarlar.ContainsKey(key) == false)
                _ayarlar.Add(key, new Ayarlar { Deger1 = value,SubelerdeOrtak=subelerdeOrtak });
            else {
                _ayarlar[key].Deger1 = value;
            }
        }
        public void SetSetting(string key, bool value)
        {
            SetSetting(key, value == true ? Boolean.TrueString : Boolean.FalseString);
        }

        public void SetSetting(string key, int value)
        {
            SetSetting(key, Convert.ToString(value));
        }
        public void SetSetting(string key, bool value,bool subelerdeOrtak) {
            SetSetting(key, value == true ? Boolean.TrueString : Boolean.FalseString,subelerdeOrtak);
        }
        public void SetSetting(string key, int value,bool subelerdeOrtak) {
            SetSetting(key, Convert.ToString(value),subelerdeOrtak);
        }
        #endregion

    }
}
