using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace WordPress
{
  /// <summary>
  /// This is entry point to program.
  /// </summary>
  class EntryPoint
  {
    static void Main(string[] args)
    {
      IWebDriver browser = new ChromeDriver();
      browser.Manage().Window.Maximize();
      browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      User user = new User("admin", "password", "evgeny@gmail.com");
      LoginPage loginPage = new LoginPage(browser);
      loginPage.OpenLoginPage();
      loginPage.InputUserName(user);
      loginPage.InputPassword(user);
      loginPage.PushLogInButton();
    }
  }
}