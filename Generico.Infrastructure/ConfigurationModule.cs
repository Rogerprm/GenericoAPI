using Generico.Domain.Account.Repository;
using Generico.Domain.Cadastro.Repository;
using Generico.Domain.Registro;
using Generico.Infrastructure.Context;
using Generico.Infrastructure.Database;
using Generico.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
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
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IRegistroBolsaFamiliaRepository, RegistroBolsaFamiliaRepository>();
            return services;
        }
    }
}
