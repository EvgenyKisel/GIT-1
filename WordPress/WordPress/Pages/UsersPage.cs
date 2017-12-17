using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WordPress.Pages.Admin
{
  /// <summary>
  /// This is class for users page.
  /// </summary>
  public class UsersPage
  {
    //http://localhost:8080/wp-admin/users.php
    private By usersBy = By.XPath("//div[contains(text(), 'Users')]");
    private By addNewButtonBy = By.XPath("//a[contains(text(), 'Add New')][preceding-sibling::h1]");
    private By messageBy = By.XPath("//div[@id='message']/p");

    public IWebDriver Browser { get; set; }

    /// <summary>
    /// This is constructor for AdminHomePage.
    /// </summary>
    /// <param name="browser"> Driver, with wich works </param>
    public UsersPage(IWebDriver browser)
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
    /// This method clicks on add new user button.
    /// </summary>
    public AdditionNewUserPage AddNewUser()
    {
      Browser.FindElement(addNewButtonBy).Click();
      return new AdditionNewUserPage(Browser);
    }

    /// <summary>
    /// This method gets action information.
    /// </summary>
    /// <returns> Message </returns>
    public string GetInfirmation()
    {
      return Browser.FindElement(messageBy).Text;
    }
  }
}