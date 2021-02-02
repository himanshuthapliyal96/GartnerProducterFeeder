using System.Collections.Generic;
using GartnerProductFeeder.DbServices;
using GartnerProductFeeder.ProductFeeder;
using GartnerProductFeeder.ProductFeeder.Factory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GartnerProductFeeder.Controllers
{
  public class GartnerProductController : Controller
  {
    private readonly IConfiguration configuration;
    private readonly IDbConnect connection;
    GartnerProductController(IConfiguration config,IDbConnect conn)
    {
      configuration = config;
      connection = conn;

    }

    [HttpPost]
    public bool FeedProducts(string source)
    {
      return ProductService.FeedProduct(source, configuration, connection);
    }

  }
}
