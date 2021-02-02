using System.Collections.Generic;

namespace GartnerProductFeeder.ProductFeeder
{
  public interface IProductSource
  {
    /// <summary>
    /// deasearlize/reads the source, covert a list of product and return to the callee
    /// </summary>
    /// <param name="sourceLocation">location of source</param>
    /// <returns></returns>
    public List<Product> GetProducts(string sourceLocation);
  }
}