using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordPress.Tests.PositiveTests
{
  [TestClass]
  public class AuthorHomePagePositiveTests : HomePageTests
  {
    [TestInitialize]
    public void TestInitialize()
    {
      User user = new User("Author", "author", "author@gmail.com", Role.AUTHOR);
      HomePage = LogInAs(user) as Pages.AuthorHomePage;
    }

    [TestMethod]
    public void TestHomePageUrlForAuthor()
    {
      Assert.AreEqual(URL_HOME_PAGE, HomePage.GetUrl());
      Logger.PrintLogInformation(new TestResult().LogOutput);
    }

    [TestMethod]
    public void TestAuthorLogOut()
    {
      TestCorrectLogOut();
    }
  }
}