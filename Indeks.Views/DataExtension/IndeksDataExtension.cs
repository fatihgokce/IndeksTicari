using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Indeks.Data.ManagerObjects;
using Indeks.Data.Base;
using NHibernate;
using NHibernate.Criterion;
using LinqExp = System.Linq.Expressions;

namespace Indeks.Views.DataExtension {
    public static class IndeksDataExtension {
        public static List<T>GetListSubeKodu<T,Idt>(this IManagerBase<T,Idt> data,string subeKodu)where T:BusinessBase<T>
        {
            return data.Session.QueryOver<T>().List().Take(data.GetMaxResult) as List<T>; 
        }
    }
}
