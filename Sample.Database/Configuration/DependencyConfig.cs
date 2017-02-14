namespace Sample.Database.Configuration
{
    using Autofac;
    using System.Reflection;

    public class DependencyConfig
    {
        public static void RegisterDependencies(ContainerBuilder builder)
        {            
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsImplementedInterfaces();
        }
    }
}
