using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WordPress.Tests
{
  [TestClass]
  public abstract class BasePageTests
  {
    protected IWebDriver Browser { get; private set; }

    [TestInitialize]
    public void BaseInitialize()
    {
      Browser = new ChromeDriver();
      Browser.Manage().Window.Maximize();
      Browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
    }

    [TestCleanup]
    public void TestCleanup()
    {
      Browser.Close();
    }

    /// <summary>
    /// This method initializes the user on the site.
    /// </summary>
    /// <param name="user"> User </param>
    /// <returns> User home page </returns>
    protected Pages.HomePage LogInAs(User user)
    {
      Pages.LoginPage loginPage = new Pages.LoginPage(Browser, user);
      loginPage.OpenLoginPage();
      loginPage.InputUserName();
      loginPage.InputPassword();
      return loginPage.PushLogInButton();
    }
  }
}