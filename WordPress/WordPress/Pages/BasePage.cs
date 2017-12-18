using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace WordPress.Pages
{
  public abstract class BasePage
  {

    private By profileBarBy = By.XPath("//*[@id='wp-admin-bar-my-account']/a");
    private By logOutBy = By.XPath("//*[@id='wp-admin-bar-logout']/a[contains(text(),'Log Out')]");
    private By usersBy = By.XPath("//div[contains(text(), 'Users')]");

    internal IWebDriver Browser { get; }

    public BasePage(IWebDriver webDriver)
    {
      Browser = webDriver;
    }

    /// <summary>
    /// This method gets url of the page.
    /// </summary>
    /// <returns> Url of the page </returns>
    public string GetUrl()
    {
      return Browser.Url;
    }

    /// <summary>
    /// This method goes to profile bar.
    /// </summary>
    public void GoToProfileBar()
    {
      new Actions(Browser).MoveToElement(Browser.FindElement(profileBarBy)).Perform();
    }

    /// <summary>
    /// This method logs out from the profile.
    /// </summary>
    public void LogOut()
    {
      new WebDriverWait(Browser, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(logOutBy));
      Browser.FindElement(logOutBy).Click();
    }
  }
}