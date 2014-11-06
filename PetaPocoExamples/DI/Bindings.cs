using Autofac;
using PetaPoco;

namespace PetaPocoExamples.DI
{
    public class Bindings : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterAssemblyTypes(GetType().Assembly);
            builder.RegisterType<UnitOfWork>().AsSelf().InstancePerRequest();
            builder.Register<IUnitOfWork>(x => x.Resolve<UnitOfWork>()).ExternallyOwned();
            builder.RegisterType<DatabaseFactory>().As<IDatabaseFactory>();

            builder.Register(x => x.Resolve<IUnitOfWork>().GetCurrentSession()).As<Database>().ExternallyOwned();
        } 
    }
}