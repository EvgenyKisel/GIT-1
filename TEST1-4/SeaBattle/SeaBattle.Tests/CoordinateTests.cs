using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeaBattle.Tests
{
  [TestClass]
  public class CoordinateTests
  {
    [TestMethod]
    public void Coordinate_correctLetter_successfullInitialize()
    {
      Assert.AreEqual('A', new Coordinate('A', 1).Letter);
    }

    [TestMethod]
    public void Coordinate_correctNumber_successfullInitialize()
    {
      Assert.AreEqual(1, new Coordinate('A', 1).Number);
    }

    [ExpectedException(typeof(InvalidLetterException))]
    [TestMethod]
    public void Coordinate_uncorrectLetter_unsuccessfullInitialize()
    {
      new Coordinate('Z', 1);
    }

    [ExpectedException(typeof(InvalidNumberException))]
    [TestMethod]
    public void Coordinate_uncorrectNumber_unsuccessfullInitialize()
    {
      new Coordinate('A', 0);
    }
  }
}