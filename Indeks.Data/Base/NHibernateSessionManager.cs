using System.Web;
using System.Runtime.Remoting.Messaging;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Cache;

using System.Reflection;
using NHibernate.Dialect;
using NHibernate.Driver;
using System;
namespace Indeks.Data.Base
{
 

  /// <summary>
  /// Handles creation and management of sessions and transactions.  It is a singleton because 
  /// building the initial session factory is very expensive. Inspiration for this class came 
  /// from Chapter 8 of Hibernate in Action by Bauer and King.  Although it is a sealed singleton
  /// you can use TypeMock (http://www.typemock.com) for more flexible testing.
  /// </summary>
  public sealed class NHibernateSessionManager
  {

    #region Thread-safe, lazy Singleton

    /// <summary>
    /// This is a thread-safe, lazy singleton.  See http://www.yoda.arachsys.com/csharp/singleton.html
    /// for more details about its implementation.
    /// </summary>
    public static NHibernateSessionManager Instance
    {
      get
      {
        return Nested.NHibernateSessionManager;
      }
    }

    /// <summary>
    /// Initializes the NHibernate session factory upon instantiation.
    /// </summary>
    private NHibernateSessionManager()
    {
      InitSessionFactory();
    }

    /// <summary>
    /// Assists with ensuring thread-safe, lazy singleton
    /// </summary>
    private class Nested
    {
      static Nested() { }
      internal static readonly NHibernateSessionManager NHibernateSessionManager =
          new NHibernateSessionManager();
    }

    #endregion

    private void InitSessionFactory()
    {
     // sessionFactory = new Configuration().Configure().SetProperty(NHibernate.Cfg.Environment.ConnectionString).BuildSessionFactory();
      //"Server=FATIH;Initial Catalog=HAN2009;Password=sapass;User ID=sa"
  //    public InMemoryDatabaseTest(Assembly assemblyContainingMapping)
  //{
  //  if (Configuration == null)
  //  {
  //    Configuration = new Configuration()
  //      .SetProperty(Environment.ReleaseConnections,"on_close")
  //      .SetProperty(Environment.Dialect, typeof (SQLiteDialect).AssemblyQualifiedName)
  //      .SetProperty(Environment.ConnectionDriver, typeof(SQLite20Driver).AssemblyQualifiedName)
  //      .SetProperty(Environment.ConnectionString, "data source=:memory:")
  //      .SetProperty(Environment.ProxyFactoryFactoryClass, typeof (ProxyFactoryFactory).AssemblyQualifiedName)
  //      .AddAssembly(assemblyContainingMapping);

  //    SessionFactory = Configuration.BuildSessionFactory();
  //  }

  //  session = SessionFactory.OpenSession();

  //  new SchemaExport(Configuration).Execute(true, true, false, true, session.Connection, Console.Out);
  //}
   
      Configuration cf= new Configuration();
        cf.SetProperty(NHibernate.Cfg.Environment.ReleaseConnections, "on_close") ;           
       // .SetProperty(NHibernate.Cfg.Environment.Dialect, typeof(MsSql2005Dialect).AssemblyQualifiedName)
        //.SetProperty(NHibernate.Cfg.Environment.ConnectionDriver, typeof(SqlClientDriver).AssemblyQualifiedName)
        if (DataBaseInfo.SqlType == SqlServerType.SQL2005) {
            cf.SetProperty(NHibernate.Cfg.Environment.Dialect, typeof(MsSql2005Dialect).AssemblyQualifiedName);
            cf.SetProperty(NHibernate.Cfg.Environment.ConnectionDriver, typeof(SqlClientDriver).AssemblyQualifiedName);
        } else {
            cf.SetProperty(NHibernate.Cfg.Environment.Dialect, typeof(SQLiteDialect).AssemblyQualifiedName);
            cf.SetProperty(NHibernate.Cfg.Environment.ConnectionDriver, typeof(SQLite20Driver).AssemblyQualifiedName);
        }
        cf.SetProperty(NHibernate.Cfg.Environment.ConnectionString,DataBaseInfo.ConString);
        //cf.SetProperty(NHibernate.Cfg.Environment.ProxyFactoryFactoryClass, typeof(NHibernate.ByteCode.Castle.ProxyFactoryFactory).AssemblyQualifiedName);
        cf.AddAssembly(Assembly.Load("Indeks.Data"));
        cf.SetProperty(NHibernate.Cfg.Environment.ShowSql,"true");
      //cf.Imports.Keys.Add("StokHarRpr");
    
      sessionFactory = cf.BuildSessionFactory();


      //sessionFactory = Fluently.Configure()
                                 
      //                     .Database(MsSqlConfiguration.MsSql2005
      //                     .ConnectionString(c => c
      //                     .Is(DataBaseInfo.ConString))
      //                     .Dialect("NHibernate.Dialect.MsSql2005Dialect").Provider("NHibernate.Connection.DriverConnectionProvider")
      //                     .Driver("NHibernate.Driver.SqlClientDriver")        
                           
      //                     .ProxyFactoryFactory("NHibernate.ByteCode.Castle.ProxyFactoryFactory, NHibernate.ByteCode.Castle")                  
      //                     .ShowSql())
                           
      //                     .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.Load("Indeks.Data")))
      //                     .Mappings(M => M.HbmMappings.AddFromAssembly(Assembly.Load("Indeks.Data")))                   
      //                     .BuildSessionFactory();





      //Configuration cfg = null;
      //IFormatter serializer = new BinaryFormatter();

      ////first time
      //cfg = new Configuration().Configure();

      //using (Stream stream = File.OpenWrite("Configuration.serialized"))
      //{
      //  serializer.Serialize(stream, configuration);
      //}

      ////other times
      //using (Stream stream = File.OpenRead("Configuration.serialized"))
      //{
      //  cfg = serializer.Deserialize(stream) as Configuration;
      //} 
    }

    /// <summary>
    /// Allows you to register an interceptor on a new session.  This may not be called if there is already
    /// an open session attached to the HttpContext.  If you have an interceptor to be used, modify
    /// the HttpModule to call this before calling BeginTransaction().
    /// </summary>
    public void RegisterInterceptor(IInterceptor interceptor)
    {
      ISession session = ContextSession;

      if (session != null && session.IsOpen)
      {
        throw new CacheException("You cannot register an interceptor once a session has already been opened");
      }

      GetSession(interceptor);
    }

    public ISession GetSession()
    {
      return GetSession(null);
    }
    IStatelessSession statelessSession = null;
    public IStatelessSession StatelessSession
    {
      get
      {
        if (statelessSession == null)
          statelessSession = sessionFactory.OpenStatelessSession();
        return statelessSession;
      }
    }
    /// <summary>
    /// Gets a session with or without an interceptor.  This method is not called directly; instead,
    /// it gets invoked from other public methods.
    /// </summary>
    private ISession GetSession(IInterceptor interceptor)
    {
      ISession session = ContextSession;

      if (session == null)
      {
        if (interceptor != null)
        {
          session = sessionFactory.OpenSession(interceptor);
        }
        else
        {
          session = sessionFactory.OpenSession();
        }
        ContextSession = session;
      }
      return session;
    }

    /// <summary>
    /// Flushes anything left in the session and closes the connection.
    /// </summary>
    public void CloseSession()
    {
      ISession session = ContextSession;
      if (session != null && session.IsOpen)
      {       
        session.Close();
        ContextSession = null;       
      }      
    }
    public void FlushSession()
    {
      ISession session = ContextSession;
      if (session != null && session.IsOpen)
      {
        session.Flush();        
      }    
    }
    public void BeginTransaction()
    {
      ITransaction transaction = ContextTransaction;

      if (transaction == null)
      {
        transaction = GetSession().BeginTransaction();
        ContextTransaction = transaction;
      }
    }

    public void CommitTransaction()
    {
      ITransaction transaction = ContextTransaction;

      try {
          if (HasOpenTransaction()) {
              FlushSession();
              transaction.Commit();
              ContextTransaction = null;
          }
      } catch (HibernateException exc) {
          RollbackTransaction();
          ContextTransaction = null;
          throw exc;
      } catch (AssertionFailure exc) {
          RollbackTransaction();
          ContextTransaction = null;
          throw exc;
      } catch (Exception exc) {
          RollbackTransaction();
          ContextTransaction = null;
          throw exc;
      }
    }

    public bool HasOpenTransaction()
    {
      ITransaction transaction = ContextTransaction;

      return transaction != null && !transaction.WasCommitted && !transaction.WasRolledBack;
    }

    public void RollbackTransaction()
    {
      ITransaction transaction = ContextTransaction;

      try
      {
        if (HasOpenTransaction())
        {
          transaction.Rollback();
        }

        ContextTransaction = null;
      }
      finally
      {
        CloseSession();
      }
    }

    /// <summary>
    /// If within a web context, this uses <see cref="HttpContext" /> instead of the WinForms 
    /// specific <see cref="CallContext" />.  Discussion concerning this found at 
    /// http://forum.springframework.net/showthread.php?t=572.
    /// </summary>
    private ITransaction ContextTransaction
    {
      get
      {
        //if (IsInWebContext())
        //{
        //  return (ITransaction)HttpContext.Current.Items[TRANSACTION_KEY];
        //}
        //else
        //{
          return (ITransaction)CallContext.GetData(TRANSACTION_KEY);
        //}
      }
      set
      {
        //if (IsInWebContext())
        //{
        //  HttpContext.Current.Items[TRANSACTION_KEY] = value;
        //}
        //else
        //{
          CallContext.SetData(TRANSACTION_KEY, value);
        //}
      }
    }

    /// <summary>
    /// If within a web context, this uses <see cref="HttpContext" /> instead of the WinForms 
    /// specific <see cref="CallContext" />.  Discussion concerning this found at 
    /// http://forum.springframework.net/showthread.php?t=572.
    /// </summary>
    private ISession ContextSession
    {
      get
      {
        //if (IsInWebContext())
        //{
        //  return (ISession)HttpContext.Current.Items[SESSION_KEY];
        //}
        //else
        //{
          return (ISession)CallContext.GetData(SESSION_KEY);
        //}
      }
      set
      {
        //if (IsInWebContext())
        //{
        //  HttpContext.Current.Items[SESSION_KEY] = value;
        //}
        //else
        //{
          CallContext.SetData(SESSION_KEY, value);
        //}
      }
    }

    //private bool IsInWebContext()
    //{
    //  return HttpContext.Current != null;
    //}

    private const string TRANSACTION_KEY = "CONTEXT_TRANSACTION";
    private const string SESSION_KEY = "CONTEXT_SESSION";
    private ISessionFactory sessionFactory;
  }
}
