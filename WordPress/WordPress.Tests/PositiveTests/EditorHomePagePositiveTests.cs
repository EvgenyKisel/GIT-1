using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordPress.Tests.PositiveTests
{
  [TestClass]
  public class EditorHomePagePositiveTests : HomePageTests
  {
    [TestInitialize]
    public void TestInitialize()
    {
      User user = new User("Editor", "editor", "editor@gmail.com", Role.EDITOR);
      HomePage = LogInAs(user) as Pages.EditorHomePage;
    }

    [TestMethod]
    public void TestHomePageUrlForEditor()
    {
      Assert.AreEqual(URL_HOME_PAGE, HomePage.GetUrl());
      Logger.PrintLogInformation(new TestResult().LogOutput);
    }

    [TestMethod]
    public void TestEditorLogOut()
    {
      TestCorrectLogOut();
    }
  }
}