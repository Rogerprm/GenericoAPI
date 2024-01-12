using Generico.Application.Cadastro.Services;
using Generico.Application.Registro.Service;
using Generico.Blazor.Client.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


var app = builder.Build();
var baseUrl = "https://localhost:7240";

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseUrl) });

//builder.Services.AddScoped<IClienteService, ClienteService>();
//builder.Services.AddScoped<IRegistroBolsaFamiliaService, RegistroBolsaFamiliaService>();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
