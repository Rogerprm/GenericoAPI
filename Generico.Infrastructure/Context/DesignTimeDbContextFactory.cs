using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico.Infrastructure.Context
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<GenericoContext>
    {
        public GenericoContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<GenericoContext>()
                .AddEnvironmentVariables()
                .Build();

            var builder = new DbContextOptionsBuilder<GenericoContext>();
            var connectionString =
                config.GetConnectionString("Default");
            builder.UseSqlServer(connectionString);
            Console.WriteLine(connectionString);
            return new GenericoContext(builder.Options);
        }
    }
}
