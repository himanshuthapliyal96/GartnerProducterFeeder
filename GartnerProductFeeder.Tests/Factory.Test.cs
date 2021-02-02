using System;
using System.Collections.Generic;
using System.Text;
using GartnerProductFeeder.ProductFeeder;
using GartnerProductFeeder.ProductFeeder.Factory;
using GartnerProductFeeder.ProductFeeder.Sources;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace GartnerProductFeeder.Tests
{
  /// <summary>
  /// Test to verfy factory class
  /// </summary>
  class FactoryTest
  {
    [Test]
    public void TestToVerifyFactory()
    {
      Assert.True(Factory.GetFactoryObject("capterra") is YamlFeeder);
      Assert.True(Factory.GetFactoryObject("softwareadvice") is JsonFeeder);
      Exception ex = Assert.Throws<Exception>(
        delegate { Factory.GetFactoryObject("xxxxxx"); }
      );
      Assert.True(ex.Message.Contains($"Source:xxxxxx is not supported in GartnerFeeder!!"));
    }
  }
}
