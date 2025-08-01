using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using DesafioFullStackFront.Context;
namespace DesafioFullStackFront
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            //injetando PilotoContext no container de inje��o de depend�ncia
            builder.Services.AddScoped<PilotoContext>();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5110/") });

            await builder.Build().RunAsync();
        }
    }
}
