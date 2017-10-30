﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleType.Tests
{
  [TestClass]
  public class BuilderTests
  {

    [TestMethod]
    public void DetermineTriangleType_twoEqualNumbersAndOneAnother_isoscalesTypeExpected()
    {
      //arrange
      Sides sides = new Sides
      {
        sideA = 4,
        sideB = 4,
        sideC = 6
      };
      Type expected = Type.ISOSCELES;

      //act
      Builder triangleBuilder = new Builder();
      Type actual = triangleBuilder.DetermineTriangleType(sides);

      //assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DetermineTriangleType_threeEqualNumbers_equilateralorTypeExpected()
    {
      //arrange
      Sides sides = new Sides
      {
        sideA = 4,
        sideB = 4,
        sideC = 4
      };
      Type expected = Type.EQUILATERALOR;

      //act
      Builder triangleBuilder = new Builder();
      Type actual = triangleBuilder.DetermineTriangleType(sides);

      //assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void DetermineTriangleType_threeAnyNumbersAndOneAnother_commonTypeExpected()
    {
      //arrange
      Sides sides = new Sides
      {
        sideA = 4,
        sideB = 5,
        sideC = 6
      };
      Type expected = Type.COMMON;

      //act
      Builder triangleBuilder = new Builder();
      Type actual = triangleBuilder.DetermineTriangleType(sides);

      //assert
      Assert.AreEqual(expected, actual);
    }
  }
}