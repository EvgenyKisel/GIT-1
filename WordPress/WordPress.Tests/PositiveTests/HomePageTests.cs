using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace WordPress.Tests.PositiveTests
{
  [TestClass]
  public class HomePageTests
  {
    private static readonly string URL_LOGINPAHE_PAGE_AFTER_LOGGEOUT = "http://localhost:8080/wp-login.php?loggedout=true";
    private IWebDriver Browser { get; set; }
    private Pages.AdminHomePage HomePage { get; set; }
    private Pages.LoginPage LoginPage { get; set; }

    [TestInitialize]
    public void TestInitialize()
    {
      Browser = new ChromeDriver();
      Browser.Manage().Window.Maximize();
      Browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      User user = new User("admin", "password", "evgeny@gmail.com", Role.ADMINISTRATOR);
      LoginPage = new Pages.LoginPage(Browser, user);
      LoginPage.OpenLoginPage();
      LoginPage.InputUserName();
      LoginPage.InputPassword();
      HomePage = (Pages.AdminHomePage)LoginPage.PushLogInButton();
    }

    [TestCleanup]
    public void TestCleanup()
    {
      Browser.Close();
    }

    [TestMethod]
    public void TestCorrectLogOut()
    {
      HomePage.GoToProfileBar();
      HomePage.LogOut();
      Assert.AreEqual(URL_LOGINPAHE_PAGE_AFTER_LOGGEOUT, Browser.Url);
      Logger.PrintLogInformation(new TestResult().LogOutput);
    }
  }
}