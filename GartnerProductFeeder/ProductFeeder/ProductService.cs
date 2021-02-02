using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GartnerProductFeeder.DbServices;
using Microsoft.Extensions.Configuration;

namespace GartnerProductFeeder.ProductFeeder
{
  /// <summary>
  /// Product service is responsible for database communication and save the data to the database
  /// </summary>
  public class ProductService
  {
    /// <summary>
    /// Feeds the data into database as per given configurations and connections
    /// </summary>
    /// <param name="source">source of feeder</param>
    /// <param name="configuration">configuration*appsettings can be consumed via this object*</param>
    /// <param name="connection">dbConnection object</param>
    /// <returns></returns>
    public static bool FeedProduct(string source,IConfiguration configuration, IDbConnect connection)
    {
      if (connection == null) throw new Exception("Invalid connection object!");
      if (configuration == null) throw new Exception("Invalid configuration object!");
      string productLocation = configuration.GetSection("ProductsSourcePath").Value;
      IProductSource sourceObject = Factory.Factory.GetFactoryObject(source);
      IList<Product> products = sourceObject.GetProducts(productLocation);
      return connection.Create(products);
    }
  }
}
