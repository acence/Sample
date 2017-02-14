namespace Sample.Web.Configuration
{
    using Autofac;
    using Autofac.Integration.Mvc;
    using System;
    using System.Reflection;
    using System.Web.Mvc;

    public class DependencyConfig
    {
        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();
            Logic.Configuration.DependencyConfig.RegisterDependencies(builder);
            
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsImplementedInterfaces();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}