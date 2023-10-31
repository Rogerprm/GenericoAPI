using Microsoft.EntityFrameworkCore;

namespace Generico.Infrastructure.Context
{
    public class GenericoContext: DbContext
    {
        public GenericoContext(DbContextOptions<GenericoContext> options) : base(options)
        {

        }
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
