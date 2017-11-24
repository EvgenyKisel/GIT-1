using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeaBattle.Tests
{
  [TestClass]
  public class PlaygroundCreatorTests
  {
    [TestMethod]
    public void AddShipToField_correctCoordinate_add()
    {
      new PlaygroundCreator().AddShipToField(new Coordinate('A', 1));
    }
  }
}