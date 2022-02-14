using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Microsoft.Extensions.DependencyInjection;
using NgrxExample.Enttites;
using NHibernate.Cache;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NgrxExample.Extention
{
    public static class NhibernateExtention
    {
        public static IServiceCollection AddNHibernate(this IServiceCollection services, string connectionString)
        {
            var configuration = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                .ConnectionString(connectionString).ShowSql)
                .Cache(c => c.UseQueryCache().UseSecondLevelCache().ProviderClass<HashtableCacheProvider>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<baidangMapping>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<chuyenmucMapping>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<luotxemMapping>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<taikhoanMapping>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<theloaiMapping>())
                .ExposeConfiguration(cf => new SchemaUpdate(cf).Execute(false, false));

            var sessionFactory = configuration.BuildSessionFactory();

            services.AddSingleton(sessionFactory);
            services.AddScoped(factory => sessionFactory.OpenSession());

            return services;
        }
    }
}
