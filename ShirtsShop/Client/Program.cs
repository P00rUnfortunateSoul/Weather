using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using ShirtsShop.Client.Services;
using ShirtsShop.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace ShirtsShop.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["AppSettings:BaseAPIUrl"]) });

            builder.Services.AddTransient(sp => builder.Configuration.GetSection("AppSettings").Get<AppSettings>());

            builder.Services.AddScoped<IShirtService, ShirtService>();

            await builder.Build().RunAsync();
        }
    }
}
