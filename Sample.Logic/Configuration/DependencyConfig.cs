namespace Sample.Logic.Configuration
{
    using Autofac;
    using AutoMapper;
    using System.Reflection;

    public class DependencyConfig
    {
        public static void RegisterDependencies(ContainerBuilder builder)
        {
            Database.Configuration.DependencyConfig.RegisterDependencies(builder);
            
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsImplementedInterfaces();
            builder.Register(c => AutoMapperConfig.ConfigureMappings()).AsSelf().SingleInstance();

            builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve)).As<IMapper>().InstancePerLifetimeScope();

        }
    }
}
