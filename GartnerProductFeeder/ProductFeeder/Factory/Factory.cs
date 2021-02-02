using System;
using GartnerProductFeeder.ProductFeeder.Sources;

namespace GartnerProductFeeder.ProductFeeder.Factory
{
  /// <summary>
  /// This class is to establish a factory pattern in GartnerProductFeeder 
  /// </summary>
  public class Factory
  {
    /// <summary>
    /// Returns a valid factory object for a valid source
    /// </summary>
    /// <param name="source"></param>
    /// <returns></returns>
    public static IProductSource GetFactoryObject(string source)
    {
      switch (source.ToLower())
      {
        case "capterra":
          return new YamlFeeder();
        case "softwareadvice":
          return  new JsonFeeder();
        default:throw new Exception($"Source:{source} is not supported in GartnerFeeder!!");
      }
    }
  }
}
