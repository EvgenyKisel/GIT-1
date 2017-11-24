using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Automobiles.Tests
{
  [TestClass]
  public class AutomobilesListTests
  {
    [TestMethod]
    public void SortAutomobilesByPrice_AutomobilesWithDifferentPrices_SortedAutomobiles()
    {
      List<Automobile> automobiles = new List<Automobile>()
      {
        new Automobile("volvo","q", "q", 2000),
        new Automobile("volvo", "q", "q", 100),
        new Automobile("volvo", "q", "q", 1000),
      };
      Automobile[] sortedAutomobiles = new Automobile[] { automobiles[1], automobiles[2], automobiles[0] };
      List<Automobile> auto = new AutomobilesList().SortAutomobilesByPrice(automobiles);
      int i = 0;
      foreach (var element in auto)
      {
        Assert.AreEqual(element, sortedAutomobiles[i++]);
      }
    }

    [TestMethod]
    public void SortAutomobilesWithEqualPriceByType_AutomobilesWithDifferentTypes_SortedAutomobiles()
    {
      List<Automobile> automobiles = new List<Automobile>()
      {
        new Automobile("volvo","q", "q", 1000),
        new Automobile("volvo", "q", "z", 1000),
        new Automobile("volvo", "q", "a", 1000),
      };
      Automobile[] sortedAutomobiles = new Automobile[] { automobiles[2], automobiles[0], automobiles[1] };
      List<Automobile> auto = new AutomobilesList().SortAutomobilesWithEqualPriceByType(automobiles);
      int i = 0;
      foreach (var element in auto)
      {
        Assert.AreEqual(element, sortedAutomobiles[i++]);
      }
    }

    [TestMethod]
    public void SortAutomobilesWithEqualPriceAndTypeByMark_AutomobilesWithDifferentMarks_SortedAutomobiles()
    {
      List<Automobile> automobiles = new List<Automobile>()
      {
        new Automobile("volvo", "q", "a", 1000),
        new Automobile("bmw", "q", "a", 1000),
        new Automobile("lada", "q", "a", 1000),
      };
      Automobile[] sortedAutomobiles = new Automobile[] { automobiles[1], automobiles[2], automobiles[0] };
      List<Automobile> auto = new AutomobilesList().SortAutomobilesWithEqualPriceAndTypeByMark(automobiles);
      int i = 0;
      foreach (var element in auto)
      {
        Assert.AreEqual(element, sortedAutomobiles[i++]);
      }
    }
  }
}