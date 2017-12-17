using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WordPress.Pages
{
  /// <summary>
  /// This is class for contributor home page.
  /// </summary>
  public class ContributorHomePage : BasePage
  {
    /// <summary>
    /// This is constructor for ContributorHomePage.
    /// </summary>
    /// <param name="browser"> Driver, with wich works </param>
    public ContributorHomePage(IWebDriver browser)
    {
      PageFactory.InitElements(browser, this);
      Browser = browser;
    }
  }
}