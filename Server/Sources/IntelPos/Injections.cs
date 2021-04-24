using Autofac;
using Microsoft.Extensions.DependencyInjection;

namespace IntelPos
{
    public class Injections
    {
        public static void AddServices(IServiceCollection services)
        {
            services.AddDb();
        }

        public static void AddServices(ContainerBuilder builder)
        {
        }
    }
}
