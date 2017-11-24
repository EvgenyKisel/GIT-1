using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Automobiles.Tests
{
  [TestClass]
  public class AutomobileTests
  {
    [ExpectedException(typeof(UncorrectPriceException))]
    [TestMethod]
    public void Automobile_invalidPrice_exception()
    {
      Automobile auto = new Automobile("bmw", "q", "q", -5);
    }

    [TestMethod]
    public void Automobile_correctMark_successfulInitialize()
    {
      Assert.AreEqual("bmw", new Automobile("bmw", "q", "q", 1000).Mark);
    }

    [TestMethod]
    public void Automobile_correctPrice_successfulInitialize()
    {
      Assert.AreEqual(1000, new Automobile("bmw", "q", "q", 1000).Price);
    }

    [TestMethod]
    public void Automobile_correctModel_successfulInitialize()
    {
      Assert.AreEqual("q", new Automobile("bmw", "q", "w", 1000).Model);
    }

    [TestMethod]
    public void Automobile_correctType_successfulInitialize()
    {
      Assert.AreEqual("w", new Automobile("bmw", "q", "w", 1000).Type);
    }

    [TestMethod]
    public void Automobile_falsePrice_failInitialize()
    {
      Assert.AreNotEqual("bmw", new Automobile(" ", "q", "q", 1000).Mark);
    }
  }
}