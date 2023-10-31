using Generico.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Generico.Infrastructure
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterRepository(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<GenericoContext>(c =>
            {
                c.UseSqlServer(connectionString);
            });
            return services;
        }
    }
}
