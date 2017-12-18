using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WordPress.Tests.PositiveTests
{
  [TestClass]
  public class SubscriberHomePageTests
  {
    private static readonly string URL_HOME_PAGE = "http://localhost:8080/wp-admin/profile.php";
    private IWebDriver Browser { get; set; }
    private Pages.SubscriberHomePage HomePage { get; set; }

    [TestInitialize]
    public void TestInitialize()
    {
      Logger.GetLoggerInstance();
      Browser = new ChromeDriver();
      Browser.Manage().Window.Maximize();
      Browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      User user = new User("Subscriber", "subscriber", "subscriber@gmail.com", Role.SUBSCRIBER);
      Pages.LoginPage loginPage = new Pages.LoginPage(Browser, user);
      loginPage.OpenLoginPage();
      loginPage.InputUserName();
      loginPage.InputPassword();
      HomePage = (Pages.SubscriberHomePage)loginPage.PushLogInButton();
    }

    [TestCleanup]
    public void TestCleanup()
    {
      Browser.Close();
    }

    [TestMethod]
    public void TestCorrectURLofSubscriberHomePage()
    {
      Assert.AreEqual(URL_HOME_PAGE, HomePage.GetUrl());
      Logger.PrintLogInformation(new TestResult().LogOutput);
    }
  }
}