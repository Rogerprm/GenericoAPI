using Generico.Application.Cadastro.Services;
using Generico.Domain.Cadastro.Repository;
using Generico.Infrastructure.Context;
using Generico.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

namespace Generico.Front
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddAutoMapper(typeof(Generico.Application.ConfigurationModule).Assembly);

            builder.Services.AddDbContext<GenericoContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
            });

            builder.Services.AddScoped<IClienteService, ClienteService>();
            builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}