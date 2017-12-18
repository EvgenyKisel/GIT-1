using OpenQA.Selenium;

namespace WordPress.Pages
{
  /// <summary>
  /// This is class for subscriber home page.
  /// </summary>
  public class SubscriberHomePage : HomePage
  {
    private By dashboardBy = By.XPath("//li[@id='menu - dashboard']");

    /// <summary>
    /// This is constructor for AdminHomePage.
    /// </summary>
    /// <param name="browser"> Driver, with wich works </param>
    public SubscriberHomePage(IWebDriver browser) : base(browser) { }

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