using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WordPress.Pages
{
  /// <summary>
  /// This is class for subscriber home page.
  /// </summary>
  public class SubscriberHomePage : BasePage
  {
    private By dashboardBy = By.XPath("//li[@id='menu - dashboard']");
    
    /// <summary>
    /// This is constructor for AdminHomePage.
    /// </summary>
    /// <param name="browser"> Driver, with wich works </param>
    public SubscriberHomePage(IWebDriver browser)
    {
      PageFactory.InitElements(browser, this);
      Browser = browser;
    }

    /// <summary>
    /// This method goes to dashboard.
    /// </summary>
    public DashboardPage GoToDashboard()
    {
      Browser.FindElement(dashboardBy).Click();
      return new DashboardPage(Browser);
    }
  }
}