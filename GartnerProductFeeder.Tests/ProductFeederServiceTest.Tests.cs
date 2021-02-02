
using System;
using GartnerProductFeeder.DbServices;
using GartnerProductFeeder.ProductFeeder;
using Microsoft.Extensions.Configuration;
using Moq;
using NUnit.Framework;

namespace GartnerProductFeeder.Tests
{
  /// <summary>
  /// Test to verify the functionality of GartnerProduct feeder
  /// </summary>
  class ProductFeederServiceTest
  {
    private Mock<IConfiguration> _configuration;
    private Mock<IDbConnect> _dbConnect;
    [Test]
    public void FeedProjectWithInValidInputs()
    {
    
      _configuration = new Mock<IConfiguration>(MockBehavior.Strict);
      _configuration.Setup(c => c.GetSection(It.IsAny<String>())).Returns(new Mock<IConfigurationSection>().Object);
      _dbConnect = new Mock<IDbConnect>(MockBehavior.Strict);
      Exception ex;
      ex = Assert.Throws<Exception>(
        delegate { ProductService.FeedProduct("xxxxxx", null, _dbConnect.Object);}
      );
      Assert.True(ex.Message.Contains("Invalid configuration object!"));
     ex = Assert.Throws<Exception>(
        delegate { ProductService.FeedProduct("xxxxxx", _configuration.Object,null); }
      );
     Assert.True(ex.Message.Contains("Invalid connection object!"));
     ex = Assert.Throws<Exception>(
        delegate { ProductService.FeedProduct("xxxxxx", _configuration.Object, _dbConnect.Object); }
      );
     Assert.True(ex.Message.Contains($"Source:xxxxxx is not supported in GartnerFeeder!!"));
     ex = Assert.Throws<Exception>(
        delegate { ProductService.FeedProduct("capterra", _configuration.Object, _dbConnect.Object); }
      );
     Assert.True(ex.Message.Contains($"Source File does not exist at"));
    }

    [Ignore("not needed right now, will be congigured later")]
    [Test]
    public void FeedProjectWithValidInputs()
    {
      _configuration = new Mock<IConfiguration>(MockBehavior.Strict);
      _dbConnect = new Mock<IDbConnect>(MockBehavior.Strict);
      _configuration.Setup(c => c.GetSection(It.IsAny<String>())).Returns(new Mock<IConfigurationSection>().Object);
      Assert.AreEqual(true, ProductService.FeedProduct("capterra", _configuration.Object, _dbConnect.Object));
    }
  }
}
