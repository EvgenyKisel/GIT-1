using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleType.Tests
{
  [TestClass]
  public class InputerTests
  {

    [TestMethod]
    public void InputSide_string5_int5expected()
    {
      //arrange
      string input = "5";
      int expected = 5;

      //act
      int actual = int.Parse(input);

      //assert
      Assert.AreEqual(expected, actual);
    }

    [ExpectedException(typeof(FormatException))]
    [TestMethod]
    public void InputSide_string5_expectedException()
    {
      string input = " ";
      int actual = int.Parse(input);
    }
  }
}