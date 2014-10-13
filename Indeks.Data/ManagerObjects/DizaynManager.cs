using System;
using System.Collections.Generic;

using System.Text;
using Indeks.Data.BusinessObjects;
using Indeks.Data.Base;
using NHibernate.Criterion;
namespace Indeks.Data.ManagerObjects
{
  public interface IDizaynManager : IManagerBase<Dizayn, int>
  {
   
  }
  public class DizaynManager : ManagerBase<Dizayn,int>, IDizaynManager
  {
  }
}
