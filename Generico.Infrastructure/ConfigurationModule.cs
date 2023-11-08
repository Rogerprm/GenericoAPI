using Generico.Domain.Cadastro.Repository;
using Generico.Infrastructure.Context;
using Generico.Infrastructure.Database;
using Generico.Infrastructure.Repository;
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

            services.AddScoped(typeof(Repository<>));
            services.AddScoped<IClienteRepository, ClienteRepository>();
            return services;
        }
    }
}
