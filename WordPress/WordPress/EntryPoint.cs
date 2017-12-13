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
      browser.Navigate().GoToUrl("http://localhost:8080/wp-admin/install.php");
      browser.Manage().Window.Maximize();
      browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
      InstallPage installPage = new InstallPage(browser);
      installPage.EnterSiteTitle();
      installPage.EnterUserName();
      installPage.EnterPasswords();
      installPage.EnterEmail();
      installPage.AcceptPrivacy();
      installPage.PushSubmitButton();
    }
  }
}