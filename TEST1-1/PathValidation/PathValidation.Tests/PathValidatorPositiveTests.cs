using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PathValidation.Tests
{
  [TestClass]
  public class PathValidatorPositiveTests
  {
    [TestMethod]
    public void CheckEndOfThePath_FilePathWithoutSpaceAtTheEnd_trueValue()
    {
      Assert.AreEqual(true, new PathValidator("C:\\qwerty").CheckEndOfThePath());
    }

    [TestMethod]
    public void CheckInvalidCharacters_FilePathWithoutInvalidCharacters_trueValue()
    {
      Assert.AreEqual(true, new PathValidator("C:\\qwerty\\qwerty.txt").CheckInvalidCharacters());
    }

    [TestMethod]
    public void CheckInvalidNames_FilePathWithoutInvalidName_trueValue()
    {
      Assert.AreEqual(true, new PathValidator("C:\\qwerty\\qwerty.txt").CheckInvalidNames());
    }

    [TestMethod]
    public void CheckInvalidNames_FilePathWithInvalidNameAndWordAtTheFolderNameStart_trueValue()
    {
      Assert.AreEqual(true, new PathValidator("C:\\Wcon\\qwerty.txt").CheckInvalidNames());
    }

    [TestMethod]
    public void CheckInvalidNames_FilePathWithInvalidNameAndWordAtTheFolderNameEnd_trueValue()
    {
      Assert.AreEqual(true, new PathValidator("C:\\hAux\\qwerty.txt").CheckInvalidNames());
    }

    [TestMethod]
    public void CheckInvalidNames_FilePathWithInvalidNameAndWordAtTheFileNameStart_trueValue()
    {
      Assert.AreEqual(true, new PathValidator("C:\\qwerty\\dLPT7.txt").CheckInvalidNames());
    }

    [TestMethod]
    public void CheckInvalidNames_FilePathWithInvalidNameAndWordAtTheFileNameEnd_trueValue()
    {
      Assert.AreEqual(true, new PathValidator("C:\\qwerty\\com56.txt").CheckInvalidNames());
    }

    [TestMethod]
    public void CheckDotsInThePath_FilePathWithoutManyDots_trueValue()
    {
      Assert.AreEqual(true, new PathValidator("C:\\qwerty\\qwerty.txt").CheckDotsInThePath());
    }

    [TestMethod]
    public void CheckStartOfThePath_CorrectRelativeFilePathWithTwoDots_trueValue()
    {
      Assert.AreEqual(true, new PathValidator("..\\qwerty\\qwerty.txt").CheckStartOfThePath());
    }

    [TestMethod]
    public void CheckStartOfThePath_CorrectRelativeFilePathWithDot_trueValue()
    {
      Assert.AreEqual(true, new PathValidator(".\\qwerty\\qwerty.txt").CheckStartOfThePath());
    }
  }
}