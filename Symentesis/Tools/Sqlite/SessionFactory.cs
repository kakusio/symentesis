using System.IO;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using Symentesis.Entitties;

namespace Symentesis.Tools.Sqlite
{
    public sealed class SessionFactory
    {

        private static readonly SessionFactory _instance = new SessionFactory();
        private static ISession _session;

        private SessionFactory()
        {

            var fromAssemblyOf = AutoMap.AssemblyOf<Paciente>(new StoreConfiguration())
                .Conventions.AddFromAssemblyOf<Paciente>()
                .UseOverridesFromAssemblyOf<Paciente>();
            var sessionFactory = Fluently.Configure()
                .Database(SQLiteConfiguration.Standard.UsingFile("sysmentesisProject.db"))
                .ExposeConfiguration(BuildSchema)
                .Mappings(m => m.AutoMappings.Add(fromAssemblyOf))
                .BuildSessionFactory();
            _session = sessionFactory.OpenSession();
        }

        public static SessionFactory Instance
        {
            get { return _instance; }
        }

        public ISession GetSession()
        {
            return _session;
        }

        private static void BuildSchema(Configuration config)
        {
            new SchemaExport(config).Create(false, true);
        }

        public void ResetDataBase()
        {
            //                 delete the existing db
            if (File.Exists("firstProject.db")) File.Delete("firstProject.db");
        }
    }
}