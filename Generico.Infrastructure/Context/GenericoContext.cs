using Generico.Domain.Cadastro;
using Generico.Domain.Registro;
using Microsoft.EntityFrameworkCore;

namespace Generico.Infrastructure.Context
{
    public class GenericoContext: DbContext
    {
        public GenericoContext(DbContextOptions<GenericoContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CepModel> Ceps { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<RegistroBolsaFamilia> RegistrosBolsaFamilia { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GenericoContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
