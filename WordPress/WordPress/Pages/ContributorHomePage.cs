using OpenQA.Selenium;

namespace WordPress.Pages
{
  /// <summary>
  /// This is class for contributor home page.
  /// </summary>
  public class ContributorHomePage : HomePage
  {
    /// <summary>
    /// This is constructor for ContributorHomePage.
    /// </summary>
    /// <param name="browser"> Driver, with wich works </param>
    public ContributorHomePage(IWebDriver browser) : base(browser) { }
  }
}