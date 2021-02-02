using System;
using System.Collections.Generic;
using GartnerProductFeeder.DbServices;
using GartnerProductFeeder.ProductFeeder;
using GartnerProductFeeder.ProductFeeder.Factory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GartnerProductFeeder.Controllers
{
  [Route("api/[controller]")]
  public class GartnerProductController : Controller
  {
    private readonly IConfiguration configuration;
    private readonly IDbConnect connection;
    public GartnerProductController(IConfiguration config,IDbConnect conn)
    {
      configuration = config;
      connection = conn;

    }

    [HttpPost]
    [Route("{source}")]
    public bool FeedProducts(string source)
    {
      try
      {
        return ProductService.FeedProduct(source, configuration, connection);
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
        throw;
      }
      
    }

  }
}
