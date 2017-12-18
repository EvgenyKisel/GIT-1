using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WordPress.Tests.PositiveTests
{
  [TestClass]
  public class AdminHomePageTests
  {
    private static readonly string URL_HOME_PAGE = "http://localhost:8080/wp-admin/";
    private IWebDriver Browser { get; set; }
    private Pages.AdminHomePage HomePage { get; set; }

    [TestInitialize]
    public void TestInitialize()
    {
      Logger.GetLoggerInstance();
      Browser = new ChromeDriver();
      Browser.Manage().Window.Maximize();
      Browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      User user = new User("admin", "password", "evgeny@gmail.com", Role.ADMINISTRATOR);
      Pages.LoginPage loginPage = new Pages.LoginPage(Browser, user);
      loginPage.OpenLoginPage();
      loginPage.InputUserName();
      loginPage.InputPassword();
      HomePage  = (Pages.AdminHomePage)loginPage.PushLogInButton();
    }

    [TestCleanup]
    public void TestCleanup()
    {
      Browser.Close();
    }

    [TestMethod]
    public void TestCorrectURLofAdminHomePage()
    {
      Assert.AreEqual(URL_HOME_PAGE, HomePage.GetUrl());
      Logger.PrintLogInformation(new TestResult().LogOutput);
    }
  }
}