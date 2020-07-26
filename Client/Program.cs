using BreadGiverApp.Client.Auth;
using BreadGiverApp.Client.Repositorios;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BreadGiverApp.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            ConfigureServices(builder.Services);
            builder.Services.AddScoped<AuthenticationStateProvider, ProveedorAutenticacion>();
            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();

            await builder.Build().RunAsync();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IRepositorio, Repositorio>();
        }
    }
}
