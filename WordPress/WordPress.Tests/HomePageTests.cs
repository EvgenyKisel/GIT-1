using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordPress.Tests.PositiveTests
{
  [TestClass]
  public abstract class HomePageTests : BasePageTests
  {
    protected static readonly string URL_HOME_PAGE = "http://localhost:8080/wp-admin/";
    private static readonly string URL_LOGINPAHE_PAGE_AFTER_LOGGEOUT = "http://localhost:8080/wp-login.php?loggedout=true";
    protected Pages.HomePage HomePage { get; set; }

    /// <summary>
    /// This method exits from current user profile.
    /// </summary>
    protected void TestCorrectLogOut()
    {
      HomePage.GoToProfileBar();
      HomePage.LogOut();
      Assert.AreEqual(URL_LOGINPAHE_PAGE_AFTER_LOGGEOUT, Browser.Url);
      Logger.PrintLogInformation(new TestResult().TestContextMessages);
    }
  }
}