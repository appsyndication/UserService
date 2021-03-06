using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using AppSyndication.Shared.Models;

namespace AppSyndication.UserService.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var developmentUrl = $"{ServiceLocationConstants.DevelopmentScheme}://{ServiceLocationConstants.DevelopmentHostname}:{ServiceLocationConstants.UserServiceDevelopmentPort}/";

            Console.Title = "AppSyndication User Service: " + developmentUrl;

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseUrls(developmentUrl) // this will be overridden by next line when run behind IIS.
                .UseAzureAppServices()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
