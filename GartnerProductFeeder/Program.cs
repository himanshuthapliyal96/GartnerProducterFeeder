using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using GartnerProductFeeder.DbServices;
using GartnerProductFeeder.ProductFeeder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace GartnerProductFeeder
{
  public class Program
  {
    public static void Main(string[] args)
    {
      if (args.Length >=3)
      {
        try
        {
          var builder = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddEnvironmentVariables()
          .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

          //test repos
          IConfigurationRoot configuration = builder.Build();
          var services = new ServiceCollection();
          services.AddSingleton<IDbConnect>(s => new DbConnectSql(configuration));
          var provider = services.BuildServiceProvider();
          IDbConnect connection = provider.GetService<IDbConnect>();
          switch (args[0].ToLower())
          {
            case "import":
              configuration.GetSection("ProductsSourcePath").Value = args[2];
              ProductService.FeedProduct(args[1], configuration, connection);
              break;
          }
        }
        catch (Exception e)
        {
          Console.WriteLine(e);
          throw;
        }

      }
      else
      {
        CreateHostBuilder(args).Build().Run();
      }
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
              webBuilder.UseStartup<Startup>();
            });
  }
}
