using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using Indeks.Data.BusinessObjects;
using Indeks.Data.Base;
using NHibernate.Criterion;
namespace Indeks.Data.ManagerObjects {
    public interface IOzelGelirGiderManager : IManagerBase<OzelGelirGider, string> {
      
    }
    public class OzelGelirGiderManager:ManagerBase<OzelGelirGider,string>,IOzelGelirGiderManager {
    }
}
