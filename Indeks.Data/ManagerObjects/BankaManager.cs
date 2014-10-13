using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using Indeks.Data.BusinessObjects;
using Indeks.Data.Base;
using NHibernate.Criterion;
using NHibernate.Transform;
namespace Indeks.Data.ManagerObjects {
    public interface IBankaManager : IManagerBase<Banka, int> { }
    public class BankaManager:ManagerBase<Banka,int>,IBankaManager {
    }
}
