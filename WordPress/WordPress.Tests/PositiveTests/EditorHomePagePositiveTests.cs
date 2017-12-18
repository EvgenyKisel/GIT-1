using NUnit.Framework;

namespace WordPress.Tests.PositiveTests
{
  [TestFixture]
  public class EditorHomePagePositiveTests : HomePageTests
  {
    [SetUp]
    public void TestInitialize()
    {
      User user = new User("Editor", "editor", "editor@gmail.com", Role.EDITOR);
      HomePage = LogInAs(user) as Pages.EditorHomePage;
    }

    [Test]
    public void TestHomePageUrlForEditor()
    {
      Assert.AreEqual(URL_HOME_PAGE, HomePage.GetUrl());
    }

    [Test]
    public void TestEditorLogOut()
    {
      TestCorrectLogOut();
    }
  }
}