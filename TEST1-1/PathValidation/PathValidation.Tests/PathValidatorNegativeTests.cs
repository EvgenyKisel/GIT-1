using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PathValidation.Tests
{
  [TestClass]
  public class PathValidatorNegativeTests
  {
    [TestMethod]
    public void CheckEndOfThePath_FilePathWithDotAtTheEnd_falseValue()
    {
      Assert.AreEqual(false, new PathValidator("C:\\qwerty.").CheckEndOfThePath());
    }

    [TestMethod]
    public void CheckEndOfThePath_FilePathWithSpaceAtTheEnd_falseValue()
    {
      Assert.AreEqual(false, new PathValidator("C:\\qwerty ").CheckEndOfThePath());
    }
    
    [TestMethod]
    public void CheckInvalidCharacters_FilePathWithInvalidCharacterAtTheFolderName_falseValue()
    {
      Assert.AreEqual(false, new PathValidator("C:\\qwe?rty\\qwerty.txt").CheckInvalidCharacters());
    }

    [TestMethod]
    public void CheckInvalidCharacters_FilePathWithInvalidCharacterAtTheFileName_falseValue()
    {
      Assert.AreEqual(false, new PathValidator("C:\\qwerty\\*qwerty.txt").CheckInvalidCharacters());
    }

    [TestMethod]
    public void CheckInvalidNames_FilePathWithInvalidLowerFolderName_falseValue()
    {
      Assert.AreEqual(false, new PathValidator("C:\\con\\qwerty.txt").CheckInvalidNames());
    }

    [TestMethod]
    public void CheckInvalidNames_FilePathWithInvalidUpperFolderName_falseValue()
    {
      Assert.AreEqual(false, new PathValidator("C:\\PRN\\qwerty.txt").CheckInvalidNames());
    }

    [TestMethod]
    public void CheckInvalidNames_FilePathWithInvalidUpperAndLowerFolderName_falseValue()
    {
      Assert.AreEqual(false, new PathValidator("C:\\nUl\\qwerty.txt").CheckInvalidNames());
    }

    [TestMethod]
    public void CheckInvalidNames_FilePathWithInvalidLowerFileName_falseValue()
    {
      Assert.AreEqual(false, new PathValidator("C:\\qwerty\\com1.txt").CheckInvalidNames());
    }

    [TestMethod]
    public void CheckInvalidNames_FilePathWithInvalidUpperFileName_falseValue()
    {
      Assert.AreEqual(false, new PathValidator("C:\\qwerty\\LPT5.txt").CheckInvalidNames());
    }

    [TestMethod]
    public void CheckInvalidNames_FilePathWithInvalidUpperAndLowerFileName_falseValue()
    {
      Assert.AreEqual(false, new PathValidator("C:\\qwerty\\AuX.txt").CheckInvalidNames());
    }
    
    [TestMethod]
    public void CheckDotsInThePath_FilePathWithFiveDotsAtTheFolderName_falseValue()
    {
      Assert.AreEqual(false, new PathValidator("C:\\.....\\AuX.txt").CheckDotsInThePath());
    }

    [TestMethod]
    public void CheckDotsInThePath_FilePathWithFiveDotsAndWordAtTheFolderName_falseValue()
    {
      Assert.AreEqual(false, new PathValidator("C:\\...b..\\AuX.txt").CheckDotsInThePath());
    }

    [TestMethod]
    public void CheckDotsInThePath_FilePathWithFiveDotsAtTheFileName_falseValue()
    {
      Assert.AreEqual(false, new PathValidator("C:\\qwerty\\......txt").CheckDotsInThePath());
    }

    [TestMethod]
    public void CheckStartOfThePath_FilePathWithTwoColons_falseValue()
    {
      Assert.AreEqual(false, new PathValidator("C::\\qwerty\\qwerty.txt").CheckStartOfThePath());
    }

    [TestMethod]
    public void CheckStartOfThePath_FilePathWithThreeDotsAtTheStart_falseValue()
    {
      Assert.AreEqual(false, new PathValidator("...\\qwerty\\qwerty.txt").CheckStartOfThePath());
    }

    [TestMethod]
    public void CheckStartOfThePath_FilePathWithSpaceAfterDiskName_falseValue()
    {
      Assert.AreEqual(false, new PathValidator("C :\\qwerty\\qwerty.txt").CheckStartOfThePath());
    }
  }
}