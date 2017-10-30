using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleType.Tests
{
  [TestClass]
  public class InputerTests
  {

    [TestMethod]
    public void InputSide_stringValue_doubleExpected()
    {
      //arrange
      string input = "5.5";
      double expected = 5.5;

      //act
      double actual = double.Parse(input);

      //assert
      Assert.AreEqual(expected, actual);
    }

    [ExpectedException(typeof(FormatException))]
    [TestMethod]
    public void InputSide_anyString_expectedException()
    {
      string input = " ";
      double actual = double.Parse(input);
    }
  }
}