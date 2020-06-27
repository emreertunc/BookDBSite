using Blazor.FileReader;
using ClientClassLibrary.Helpers;
using ClientClassLibrary.Repository;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace KitapSitesi.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            builder.Services.AddSingleton(new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            ConfigureServices(builder.Services);

            await builder.Build().RunAsync();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IHttpService, HttpService>();
            services.AddScoped<IKitapturRepository, KitapturRepository>();
            services.AddScoped<IKisiRepository, KisiRepository>();
            services.AddScoped<IKitaplarRepository, KitaplarRepository>();
            services.AddFileReaderService(options => options.InitializeOnFirstCall = true);
        }
    }

}
