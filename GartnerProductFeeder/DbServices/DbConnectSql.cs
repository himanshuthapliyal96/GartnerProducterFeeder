using System;
using System.Collections.Generic;
using GartnerProductFeeder.ProductFeeder;
using Microsoft.Extensions.Configuration;

namespace GartnerProductFeeder.DbServices
{
  /// <summary>
  /// Need to use singleton pattern to create a single connection throught the life
  /// </summary>
  public class DbConnectSql:IDbConnect
  {

    private  readonly string _dbConnectionString;
    private static object _mySqlConn;
    public DbConnectSql(IConfiguration configuration)
    {
      _dbConnectionString = configuration.GetConnectionString("Database");
      this.Connect();
    }

    public void Connect()
    {
      if(_mySqlConn == null) _mySqlConn = new object();
    }

    public bool Create(IList<Product> productList)
    {
      try
      {
        if (string.IsNullOrEmpty(_dbConnectionString)) throw new Exception("Invalid connection string!!");
        Console.WriteLine("Saving data to MySql database!!!!!");
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
        throw;
      }
   
      return true;
    }

    public bool Delete()
    {
      throw new NotImplementedException();
    }

    public bool Update()
    {
      throw new NotImplementedException();
    }
  }
}
