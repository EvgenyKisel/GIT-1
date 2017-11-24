using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleType.Tests
{
  [TestClass]
  public class CheckerTests
  {
    Random random = new Random();
    private const int RANDOMMAXVALUE = 10;
    private const int RANDOMMINVALUE = 1;
    private const int NEGATIVEMULTIPLIER = -1;

    [TestMethod]
    public void PositivityCheck_oneOrMoreDoubleSidesBelowZero_falseValueExpected()
    {
      //arrange
      Sides sides = new Sides
      {
        sideA = random.Next(RANDOMMINVALUE, RANDOMMAXVALUE) * NEGATIVEMULTIPLIER,
        sideB = random.Next(RANDOMMINVALUE, RANDOMMAXVALUE),
        sideC = random.Next(RANDOMMINVALUE, RANDOMMAXVALUE)
      };

      //act
      Checker checker = new Checker();
      bool actual = checker.PositivityCheck(sides);
      bool expected = false;

      //assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void PositivityCheck_threeDoubleSidesAboveZero_trueValueExpected()
    {
      //arrange
      Sides sides = new Sides
      {
        sideA = random.Next(RANDOMMINVALUE,RANDOMMAXVALUE),
        sideB = random.Next(RANDOMMINVALUE,RANDOMMAXVALUE),
        sideC = random.Next(RANDOMMINVALUE,RANDOMMAXVALUE)
      };

      //act
      Checker checker = new Checker();
      bool actual = checker.PositivityCheck(sides);
      bool expected = true;

      //assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CheckTriangleExistence_threeSidesWhereAmountOfAnyTwoValuesMoreThanOther_trueValueExpected()
    {
      //arrange
      Sides sides = new Sides
      {
        sideA = 4,
        sideB = 5,
        sideC = 6
      };
        
      //act
      Checker checker = new Checker();
      bool actual = checker.CheckTriangleExistence(sides);
      bool expected = true;

      //assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CheckTriangleExistence_threeSidesAmountOfAnyTwoValuesLessThanOther_falseValueExpected()
    {
      //arrange
      Sides sides = new Sides
      {
        sideA = 100,
        sideB = 5,
        sideC = 6
      };

      //act
      Checker checker = new Checker();
      bool actual = checker.CheckTriangleExistence(sides);
      bool expected = false;

      //assert
      Assert.AreEqual(expected, actual);
    }
  }
}