using System.Collections.Generic;
using GartnerProductFeeder.ProductFeeder;

namespace GartnerProductFeeder.DbServices
{
  /// <summary>
  /// IDbConnect is a sample interface to perform CRUD operations
  /// </summary>
  public interface IDbConnect
  {
    public void Connect();

    public bool Create(IList<Product> productList);

    public bool Delete();

    public bool Update();

  }
}
