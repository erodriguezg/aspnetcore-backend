using AspNetCoreBackend.Entities;
using AspNetCoreBackend.Repositories;
using Autofac;

namespace AspNetCoreBackend.Configs
{
    public class RepositoriesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RegionRepository>().AsSelf().As<IRepository<Region, long>>();
            builder.RegisterType<ProvinciaRepository>().AsSelf().As<IRepository<Provincia, long>>();
        }
    }
}
