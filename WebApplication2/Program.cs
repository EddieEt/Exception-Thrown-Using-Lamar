using System.Threading.Tasks;

using Lamar.Microsoft.DependencyInjection;

using Microsoft.AspNetCore.Hosting;

namespace WebApplication2
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await CreateWebHostBuilder(args).Build().RunAsync();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            // When using the extension overload to include a registry here, the error is thrown.

            return new WebHostBuilder().UseLamar(new WebApplicationRegistry())
                                       .UseKestrel()
                                       .UseStartup<Startup>();
        }
    }
}