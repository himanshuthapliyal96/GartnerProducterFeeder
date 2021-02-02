using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GartnerProductFeeder.ProductFeeder
{
  /// <summary>
  /// Product class is the representation of product in database
  /// </summary>
  public class Product
  {
    /// <summary>
    /// Name of product
    /// </summary>
    public string name { get; set; }
    /// <summary>
    /// Catagores pf product
    /// </summary>
    public string[] Categories { get; set; }
    /// <summary>
    /// Development tools associated with the product
    /// </summary>
    public string[] DevelopmentTools { get; set; }
  }
}
