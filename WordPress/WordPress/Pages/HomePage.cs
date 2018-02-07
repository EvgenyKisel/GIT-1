using OpenQA.Selenium;

namespace WordPress.Pages
{
  /// <summary>
  /// This is user home page.
  /// </summary>
  public class HomePage : BasePage
  {
    /// <summary>
    /// This is constructor for HomePage.
    /// </summary>
    /// <param name="browser"> Driver, with wich works </param>
    public HomePage(IWebDriver browser) : base(browser) { }
  }
}