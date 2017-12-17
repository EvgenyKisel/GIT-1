using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace WordPress.Pages
{
  /// <summary>
  /// This is class for users page.
  /// </summary>
  public class UsersPage
  {
    private static By addNewButtonBy = By.XPath("//a[contains(text(), 'Add New')][preceding-sibling::h1]");
    private static By messageBy = By.XPath("//div[@id='message']/p");
    private static By confirmDeletionButtonBy = By.CssSelector("#submit");

    public IWebDriver Browser { get; private set; }

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

    public void DeleteUser(string userNameForDeletion)
    {
      By userBy = By.XPath($"//td[@data-colname='Username']//a[contains(text(), '{userNameForDeletion}')]");
      new Actions(Browser).MoveToElement(Browser.FindElement(userBy));
      By deleteButtonBy = By.XPath($"//td[@data-colname='Username']//a[contains(text(), {userNameForDeletion})]/../..//span[@class='delete']");
      new WebDriverWait(Browser, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(deleteButtonBy));
      Browser.FindElement(deleteButtonBy).Click();
      Browser.FindElement(confirmDeletionButtonBy).Click();
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