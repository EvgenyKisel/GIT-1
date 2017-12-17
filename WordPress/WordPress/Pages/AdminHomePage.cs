using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WordPress.Pages
{
  public class AdminHomePage : HomePage
  {
    private By usersBy = By.XPath("//div[contains(text(), 'Users')]");

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
    /// This method log out drom the profile.s
    /// </summary>
    public Admin.UsersPage GoToUsers()
    {
      Browser.FindElement(usersBy).Click();
      return new Admin.UsersPage(Browser);
    }
  }
}