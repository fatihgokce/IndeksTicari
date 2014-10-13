using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Indeks.Data.Base;
using Indeks.Data.BusinessObjects;
namespace Indeks.Data.ManagerObjects {
    public interface IPostManager : IManagerBase<Post, int> { 
    }
    public class PostManager:ManagerBase<Post,int>,IPostManager {
    }
}
