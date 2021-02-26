using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;


namespace BackEnd2
{
    public class Program
    {
        // Main function
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        // IHostBuilder is an interface to configurate web host
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
