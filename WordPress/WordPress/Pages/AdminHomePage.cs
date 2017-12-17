using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WordPress.Pages
{
  /// <summary>
  /// This is class for admin home page.
  /// </summary>
  public class AdminHomePage : BasePage
  {
    private static By usersBy = By.XPath("//div[contains(text(), 'Users')]");

    /// <summary>
    /// This is constructor for AdminHomePage.
    /// </summary>
    /// <param name="browser"> Driver, with wich works </param>
    public AdminHomePage(IWebDriver browser)
    {
      PageFactory.InitElements(browser, this);
      Browser = browser;
    }

    /// <summary>
    /// This method logs out drom the profile.
    /// </summary>
    public UsersPage GoToUsers()
    {
      Browser.FindElement(usersBy).Click();
      return new UsersPage(Browser);
    }
  }
}