using Autofac;
using Autofac.Integration.WebApi;
using MacAddresses.Data.Services.DataServices;
using MacAddresses.Data.Services.ValidationServices;
using System.Reflection;
using System.Web.Http;

namespace MacAddresses.App_Start
{
    public class AutofacWebApiConfig
    {
        public static IContainer Container;
        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }
        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<MacAddressService>().As<IMacAddressService>().InstancePerRequest();
            builder.RegisterType<MacAddressValidationService>().As<IMacAddressValidationService>().InstancePerRequest();

            Container = builder.Build();

            return Container;
        }
    }
}