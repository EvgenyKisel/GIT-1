using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;

namespace RepeatedValuesCount.Tests
{
  [TestClass]
  public class ListOfValuesTests
  {
    [TestMethod]
    public void CountRepeatedElements_EmptyCollection_0value()
    {
      Assert.AreEqual(0, new ListOfValues().CountRepeatedElements(new ArrayList { }));
    }

    [TestMethod]
    public void CountRepeatedElements_CollectionWithTwoDifferentNumbers_0value()
    {
      Assert.AreEqual(0, new ListOfValues().CountRepeatedElements(new ArrayList { 1, 2 }));
    }

    [TestMethod]
    public void CountRepeatedElements_CollectionWithTwoSameNumbers_1value()
    {
      Assert.AreEqual(1, new ListOfValues().CountRepeatedElements(new ArrayList { 1, 1 }));
    }

    [TestMethod]
    public void CountRepeatedElements_CollectionWithThreeRepeatedNumbers_3value()
    {
      Assert.AreEqual(3, new ListOfValues().CountRepeatedElements(new ArrayList { 1, 1, 1, 6, 2, 2, 2, 6, 5, 12 }));
    }
  }
}