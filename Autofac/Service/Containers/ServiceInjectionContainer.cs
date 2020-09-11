using Autofac;
using Domain.Services;

namespace Service.Containers
{
    public class ServiceInjectionContainer : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CarApplicationService>().As<ICarApplicationService>().InstancePerLifetimeScope();
            builder.RegisterType<RentApplicationService>().As<IRentApplicationService>().InstancePerLifetimeScope();
        }
    }
}
