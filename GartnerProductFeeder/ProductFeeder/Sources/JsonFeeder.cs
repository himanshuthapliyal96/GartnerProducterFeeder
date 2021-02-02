using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GartnerProductFeeder.ProductFeeder.Sources
{
  /// <summary>
  /// Json feeder is responsible for feeding files of type json
  /// </summary>
  public class JsonFeeder : IProductSource
  {
    /// <summary>
    /// Desearilize a json at a given location to list of product
    /// </summary>
    /// <param name="sourceLocation">location of json file</param>
    /// <returns></returns>
    public List<Product> GetProducts(string sourceLocation)
    {
      if(!File.Exists(sourceLocation)) throw new Exception($"Source File does not exist at {sourceLocation}");
      Console.WriteLine($"Converting file to products from Loc:{sourceLocation}");
      return new List<Product>();
    }
  }
}
