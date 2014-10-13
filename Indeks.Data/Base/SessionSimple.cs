using System;
using System.Collections.Generic;

using System.Text;

using System.Reflection;
using Indeks.Data.BusinessObjects;
using NHibernate;

using NHibernate.Cfg;
using Env=NHibernate.Cfg.Environment;
using System.Diagnostics;
namespace Indeks.Data.Base
{
  public class SessionSimple
  {
    private ISessionFactory sessionFactory;
    ISession session;
    public void CloseSession()
    {
      if (session != null && session.IsOpen)
      {
        session.Flush();
        session.Close();
      }      
    }
    public ISession GetSession()
    {
      InitSessionFactory();
      session= sessionFactory.OpenSession();
      return session;
    }
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
    //    <session-factory>
    //  <property name="show_sql">true</property>
    //  <property name="connection.provider">NHibernate.Connection.DriverConnectionProvider</property>
    //  <property name="dialect">NHibernate.Dialect.MsSql2005Dialect</property>
    //  <property name="connection.driver_class">NHibernate.Driver.SqlClientDriver</property>
    //  <property name="connection.connection_string">Server=FATIH;Initial Catalog=HAN2009;Password=sapass;User ID=sa</property>
    //  <property name="proxyfactory.factory_class">NHibernate.ByteCode.Castle.ProxyFactoryFactory, NHibernate.ByteCode.Castle</property>
    //  <mapping assembly="Indeks.Data"/>

    //  <!-- NHibernate 2.1 -->


    //</session-factory>
//      Configuration cfg = new Configuration()
//    .addResource("Item.hbm.xml")
//    .addResource("Bid.hbm.xml");
//An alternative way is to specify the mapped class and allow Hibernate to find the mapping document for you:

//Configuration cfg = new Configuration()
//    .addClass(org.hibernate.auction.Item.class)
//    .addClass(org.hibernate.auction.Bid.class);
      Stopwatch sw = Stopwatch.StartNew();
      Configuration con = new Configuration();
      con.SetProperty("connection.provider", "NHibernate.Connection.DriverConnectionProvider");
      con.SetProperty(Env.Dialect, "NHibernate.Dialect.MsSql2005Dialect");
      con.SetProperty("connection.driver_class", "NHibernate.Driver.SqlClientDriver");
      con.SetProperty(Env.ConnectionString, DataBaseInfo.ConString);
      con.SetProperty(Env.ProxyFactoryFactoryClass, "NHibernate.ByteCode.Castle.ProxyFactoryFactory, NHibernate.ByteCode.Castle");
      //con.SetProperty(Env.DefaultSchema,"HAN2009");
      con.AddClass(typeof(Sube));//.AddAssembly("Indeks.Data");
      //con.SetProperty(Env.PropertyBytecodeProvider, "NHibernate.ByteCode.Castle");
      //con.SetProperty(Env., "NHibernate.ByteCode.Castle");
    
      sessionFactory = con.BuildSessionFactory();
      int a = sw.Elapsed.Milliseconds;
      a = 3;
      //sessionFactory = Fluently.Configure()

      //                     .Database(MsSqlConfiguration.MsSql2005
      //                     .ConnectionString(c => c
      //                     .Is(DataBaseInfo.ConString))
      //                     .Dialect("NHibernate.Dialect.MsSql2005Dialect").Provider("NHibernate.Connection.DriverConnectionProvider")
      //                     .Driver("NHibernate.Driver.SqlClientDriver")
      //                     .DefaultSchema("HAN2009")
      //                     .ProxyFactoryFactory("NHibernate.ByteCode.Castle.ProxyFactoryFactory, NHibernate.ByteCode.Castle")
      //                     .ShowSql())
      //                     .Mappings(m=>m.HbmMappings.AddClasses(typeof(Sube)))
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
  }
}
