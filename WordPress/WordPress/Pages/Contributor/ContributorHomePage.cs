using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WordPress.Pages
{
  public class ContributorHomePage
  {
    private By profileBarBy = By.XPath("//*[@id='wp-admin-bar-my-account']/a");
    public By logOutBy = By.XPath("//*[@id='wp-admin-bar-logout']/a[contains(text(),'Log Out')]");

    public IWebDriver Browser { get; set; }

    /// <summary>
    /// This is constructor for AdminHomePage.
    /// </summary>
    /// <param name="browser"> Driver, with wich works </param>
    public ContributorHomePage(IWebDriver browser)
    {
      PageFactory.InitElements(browser, this);
      Browser = browser;
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
    /// This method clicks on profile bar.
    /// </summary>
    public void GoToProfileBar()
    {
      Browser.FindElement(profileBarBy).Click();
    }

    /// <summary>
    /// This method log out drom the profile.s
    /// </summary>
    public void LogOut()
    {
      Browser.FindElement(logOutBy).Click();
    }
  }
}