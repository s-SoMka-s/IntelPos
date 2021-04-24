using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace IntelPos
{
    public static class DbInjections
    {
        public static IServiceCollection AddDb(this IServiceCollection services)
        {
            var postgresConntectionString = "intelpos";
            services.AddDbContext<SqlContext>(options => options.UseNpgsql(postgresConntectionString), ServiceLifetime.Transient);

            return services;
        }
    }
}
