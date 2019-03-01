using AspNetCoreBackend.Business;
using Autofac;

namespace AspNetCoreBackend.Configs
{
    public class BusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RegionBusiness>().AsSelf();
            builder.RegisterType<ProvinciaBusiness>().AsSelf();
        }
    }
}
