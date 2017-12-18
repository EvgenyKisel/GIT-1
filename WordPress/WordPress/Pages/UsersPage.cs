using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace WordPress.Pages
{
  /// <summary>
  /// This is class for users page.
  /// </summary>
  public class UsersPage : BasePage
  {
    private By addNewButtonBy = By.XPath("//a[contains(text(), 'Add New')][preceding-sibling::h1]");
    private By messageBy = By.XPath("//div[@id='message']/p");
    private By confirmDeletionButtonBy = By.CssSelector("#submit");
    private string pathToUser = "//td[@data-colname='Username']//a[contains(text(), '{0}')]";
    private string pathToDeleteButton = "//td[@data-colname='Username']//a[contains(text(), '{0}')]/../..//span[@class='delete']/a";

    /// <summary>
    /// This is constructor for AdminHomePage.
    /// </summary>
    /// <param name="browser"> Driver, with wich works </param>
    public UsersPage(IWebDriver browser) : base(browser) { }

    /// <summary>
    /// This method clicks on add new user button.
    /// </summary>
    public AdditionNewUserPage AddNewUser()
    {
      Browser.FindElement(addNewButtonBy).Click();
      return new AdditionNewUserPage(Browser);
    }

    /// <summary>
    /// This method deletes user.
    /// </summary>
    /// <param name="userNameForDeletion"> Inputted name </param>
    public void DeleteUser(string userNameForDeletion)
    {
      new Actions(Browser).MoveToElement(Browser.FindElement(By.XPath(String.Format(pathToUser, userNameForDeletion)))).Perform();
      By deleteButtonBy = By.XPath(String.Format(pathToDeleteButton, userNameForDeletion));
      new WebDriverWait(Browser, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(deleteButtonBy));
      Browser.FindElement(deleteButtonBy).Click();
      Browser.FindElement(confirmDeletionButtonBy).Click();
    }

    /// <summary>
    /// This method gets action information.
    /// </summary>
    /// <returns> Message </returns>
    public string GetInfirmationWindowMessage()
    {
      return Browser.FindElement(messageBy).Text;
    }
  }
}