using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleType.Tests
{
  [TestClass]
  public class CheckerTests
  {
    Random random = new Random();
    private const int RANDOMMAXVALUE = 10;

    [TestMethod]
    public void NegativityCheck_threeDoubleSidesAboveZero_trueValueExpected()
    {
      //arrange
      Sides sides = new Sides
      {
        sideA = random.Next(RANDOMMAXVALUE),
        sideB = random.Next(RANDOMMAXVALUE),
        sideC = random.Next(RANDOMMAXVALUE)
      };
    
      //act
      Checker checker = new Checker();
      bool actual = checker.NegativityCheck(sides);
      bool expected = true;

      //assert
      Assert.AreEqual(expected, actual);
    }
  }
}