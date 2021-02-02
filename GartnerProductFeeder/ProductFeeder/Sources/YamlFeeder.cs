using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GartnerProductFeeder.ProductFeeder.Sources
{
  /// <summary>
  /// Yaml feeder is responsible for feeding files of type yaml
  /// </summary>
  public class YamlFeeder:IProductSource
  {
    /// <summary>
    /// Reads a yaml at a given location and desearilize it to list of product
    /// </summary>
    /// <param name="sourceLocation">location of yaml</param>
    /// <returns></returns>
    public List<Product> GetProducts(string sourceLocation)
    {
      if (!File.Exists(sourceLocation)) throw new Exception($"Source File does not exist at {sourceLocation}");
      Console.WriteLine($"Converting file to products from Loc:{sourceLocation}");
      return  new List<Product>();
    }
  }
}
