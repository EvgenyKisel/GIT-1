using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace WordPress.Pages
{
  /// <summary>
  /// This is user base page.
  /// </summary>
  public class BasePage
  {
    private static By profileBarBy = By.XPath("//*[@id='wp-admin-bar-site-name']/a");//*[@id='wp-admin-bar-my-account']/a");
    private static By logOutBy = By.XPath("//a[contains(text(), 'Log out')]");//*[@id='wp-admin-bar-logout']/a[contains(text(),'Log Out')]");
    private static By usersBy = By.XPath("//div[contains(text(), 'Users')]");

    public IWebDriver Browser { get; set; }

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
      //new Actions(Browser).MoveToElement(Browser.FindElement(profileBarBy));
      Browser.FindElement(profileBarBy).Click();
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