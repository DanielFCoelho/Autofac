using Autofac;
using Domain.Repositories;
using Infra.Repositories;

namespace Infra.Containers
{
    public class InfraInjectionContainer : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CarRepository>().As<ICarRepository>().InstancePerLifetimeScope();
            builder.RegisterType<RentRepository>().As<IRentRepository>().InstancePerLifetimeScope();
        }
    }
}
