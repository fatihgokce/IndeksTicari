using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using NHibernate.Criterion;
using Indeks.Data.Utils;
using LinqExp = System.Linq.Expressions;
namespace Indeks.Data.Base
{
   
  public interface IManagerBase<T, IdT>
  {

    T GetById(IdT id, bool shouldLock);
    List<T> GetAll();
    List<T> GetByExample(T exampleInstance, params string[] propertiesToExclude);
    T GetUniqueByExample(T exampleInstance, params string[] propertiesToExclude);
    T  Save(T entity);
    T  SaveOrUpdate(T entity);
    void Delete(T entity);
    void CommitChanges();
    void CommitTransaction();
    void CommitTransactionAndCloseSession();
    void BeginTransaction();
    void CloeseSession();
    List<T> GetAllStateless();
    T SingleOrDefault<T>(LinqExp.Expression<Func<T, bool>> expression)where T:class;
    List<T> GetList<T>(LinqExp.Expression<Func<T, bool>> expression)where T:class;
    int GetMaxResult { get; }
    ISession Session { get; }
  }
  public abstract class ManagerBase<T, IdT> : IManagerBase<T, IdT>
  {
    /// <summary>
    /// Loads an instance of type TypeOfListItem from the DB based on its ID.
    public int GetMaxResult { get { return 50; } }
    
    public T SingleOrDefault<T>(LinqExp.Expression<Func<T, bool>> expression) where T : class {
        return Session.QueryOver<T>().Where(expression).SingleOrDefault();
    }
    public List<T> GetList<T>(LinqExp.Expression<Func<T, bool>> expression)where T:class  {
        return Session.QueryOver<T>().Where(expression).List<T>() as List<T>;
    }
    public virtual T GetById(IdT id, bool shouldLock)
    {
      T entity;

      if (shouldLock)
      {
        entity = (T)Session.Get(persitentType, id, LockMode.Upgrade);
      }
      else
      {
        entity = (T)Session.Get(persitentType,id);
      }

      return entity;
    }

    /// <summary>
    /// Loads every instance of the requested type with no filtering.
    /// </summary>
    public virtual List<T> GetAll()
    {

      return GetByCriteria();
      
      
    }
    public List<T> GetAllStateless()
    {

      return StatelessSession.CreateCriteria(persitentType).List<T>() as List<T> ;

      //ICriteria criteria = Session.CreateCriteria(persitentType);

      ////foreach (ICriterion criterium in criterion)
      ////{
      ////  criteria.Add(criterium);
      ////}

      //return criteria.List<T>() as List<T>;
    }
    /// <summary>
    /// Loads every instance of the requested type using the supplied <see cref="ICriterion" />.
    /// If no <see cref="ICriterion" /> is supplied, this behaves like <see cref="GetAll" />.
    /// </summary>
    public List<T> GetByCriteria(params ICriterion[] criterion)
    {
      ICriteria criteria = Session.CreateCriteria(persitentType);

      foreach (ICriterion criterium in criterion)
      {
        criteria.Add(criterium);
      }

      return criteria.List<T>() as List<T>;
    }

    public List<T> GetByExample(T exampleInstance, params string[] propertiesToExclude)
    {
      ICriteria criteria = Session.CreateCriteria(persitentType);
      Example example = Example.Create(exampleInstance);

      foreach (string propertyToExclude in propertiesToExclude)
      {
        example.ExcludeProperty(propertyToExclude);
      }

      criteria.Add(example);

      return criteria.List<T>() as List<T>;
    }

    /// <summary>
    /// Looks for a single instance using the example provided.
    /// </summary>
    /// <exception cref="NonUniqueResultException" />
    public T GetUniqueByExample(T exampleInstance, params string[] propertiesToExclude)
    {
      List<T> foundList = GetByExample(exampleInstance, propertiesToExclude);

      if (foundList.Count > 1)
      {
        throw new NonUniqueResultException(foundList.Count);
      }

      if (foundList.Count > 0)
      {
        return foundList[0];
      }
      else
      {
        return default(T);
      }
    }

    /// <summary>
    /// For entities that have assigned ID's, you must explicitly call Save to add a new one.
    /// See http://www.hibernate.org/hib_docs/reference/en/html/mapping.html#mapping-declaration-id-assigned.
    /// </summary>
    public virtual T Save(T entity)
    {
      Session.Save(entity);
      return entity;
    }

    /// <summary>
    /// For entities with automatatically generated IDs, such as identity, SaveOrUpdate may 
    /// be called when saving a new entity.  SaveOrUpdate can also be called to update any 
    /// entity, even if its ID is assigned.
    /// </summary>
    public virtual T SaveOrUpdate(T entity)
    {
      Session.SaveOrUpdate(entity);
      return entity;
    }

    public void Delete(T entity)
    {
      Session.Delete(entity);
    }

    /// <summary>
    /// Commits changes regardless of whether there's an open transaction or not
    /// </summary>
    public void CommitChanges()
    {
      if (NHibernateSessionManager.Instance.HasOpenTransaction())
      {
        NHibernateSessionManager.Instance.CommitTransaction();
      }
      else
      {
        // If there's no transaction, just flush the changes
        NHibernateSessionManager.Instance.GetSession().Flush();
      }
    }
    public void BeginTransaction()
    {
      NHibernateSessionManager.Instance.BeginTransaction();
    }
    public void CommitTransaction()
    {
      NHibernateSessionManager.Instance.CommitTransaction();
      
    }
    public void CommitTransactionAndCloseSession()
    {
      try
      {
        NHibernateSessionManager.Instance.CommitTransaction();
      }
      finally
      {
        NHibernateSessionManager.Instance.CloseSession();
      }
    }
    public void CloeseSession()
    {
      NHibernateSessionManager.Instance.CloseSession();
    }
    /// <summary>
    /// Exposes the ISession used within the DAO.
    /// </summary>
    public ISession Session
    {
      get
      {
        return NHibernateSessionManager.Instance.GetSession();
      }
    }
    protected IStatelessSession StatelessSession
    {
      get
      {
        return NHibernateSessionManager.Instance.StatelessSession;
      }
    }

    private Type persitentType = typeof(T);
  }
}
