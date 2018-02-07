using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace WordPress.Pages
{
  /// <summary>
  /// This is class for adding new user to the wordpress.
  /// </summary>
  public class AdditionNewUserPage : BasePage
  {
    private By newUserLoginBy = By.CssSelector("#user_login");
    private By newUserEmailBy = By.CssSelector("#email");
    private By showPasswordButtonBy = By.XPath("//button[contains(text(), 'Show password')]");
    private By newUserPasswordBy = By.CssSelector("#pass1-text");
    private By weakPasswordConformationCheckBoxBy = By.CssSelector(".pw-checkbox");
    private By newUserRoleSelectorBy = By.CssSelector("#role");
    private By newUserSubscriberRoleBy = By.XPath("//select[@name='role']/option[contains(@value, 'subscriber')]");
    private By newUserContributorRoleBy = By.XPath("//select[@name='role']/option[contains(@value, 'contributor')]");
    private By newUserAuthorRoleBy = By.XPath("//select[@name='role']/option[contains(@value, 'author')]");
    private By newUserEditorRoleBy = By.XPath("//select[@name='role']/option[contains(@value, 'editor')]");
    private By newUserAdministratorRoleBy = By.XPath("//select[@name='role']/option[contains(@value, 'administrator')]");
    private By addNewUserButtonBy = By.XPath("//input[@type='submit']");

    /// <summary>
    /// This is constructor for AdditionNewUserPage.
    /// </summary>
    /// <param name="browser"> Driver, with wich works </param>
    public AdditionNewUserPage(IWebDriver browser) : base(browser) { }

    /// <summary>
    /// This method sets new user's login.
    /// </summary>
    public void SetNewUserLogin(string login)
    {
      Browser.FindElement(newUserLoginBy).SendKeys(login);
    }

    /// <summary>
    /// This method sets new user's email.
    /// </summary>
    public void SetNewUserEmail(string email)
    {
      Browser.FindElement(newUserEmailBy).SendKeys(email);
    }

    /// <summary>
    /// This method clicks on password button.
    /// </summary>
    public void ClickOnPasswordButton()
    {
      Browser.FindElement(showPasswordButtonBy).Click();
    }

    /// <summary>
    /// This method sets new user's password.
    /// </summary>
    public void SetNewUserPasssword(string password)
    {
      Browser.FindElement(newUserPasswordBy).SendKeys(password);
    }

    /// <summary>
    /// This method clicks on weak password confirmation, if it's necessary.
    /// </summary>
    public void AcceptIfPasswordIsWeak()
    {
      if (Browser.FindElement(weakPasswordConformationCheckBoxBy).Displayed)
      {
        Browser.FindElement(weakPasswordConformationCheckBoxBy).Click();
      }
    }

    /// <summary>
    /// This method clicks on role selector.
    /// </summary>
    public void GoToUserRoleSelector()
    {
      new Actions(Browser).MoveToElement(Browser.FindElement(newUserRoleSelectorBy)).Perform();
      Browser.FindElement(newUserRoleSelectorBy).Click();
    }

    /// <summary>
    /// This method sets new user role.
    /// </summary>
    /// <param name="newUserRole"> User role </param>
    public void SetNewUserRole(Role role)
    {
      new WebDriverWait(Browser, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(newUserAdministratorRoleBy));
      switch (role)
      {
        case Role.SUBSCRIBER:
          Browser.FindElement(newUserSubscriberRoleBy).Click();
          break;
        case Role.CONTRIBUTOR:
          Browser.FindElement(newUserContributorRoleBy).Click();
          break;
        case Role.AUTHOR:
          Browser.FindElement(newUserAuthorRoleBy).Click();
          break;
        case Role.EDITOR:
          Browser.FindElement(newUserEditorRoleBy).Click();
          break;
        case Role.ADMINISTRATOR:
          Browser.FindElement(newUserAdministratorRoleBy).Click();
          break;
        default:
          Logger.GetLoggerInstance();
          Logger.PrintLogInformation("uncorrect role");
          break;
      }
    }

    /// <summary>
    /// This method clicks on add new user button.
    /// </summary>
    public void SubmitNewUserAdding()
    {
      Browser.FindElement(addNewUserButtonBy).Click();
    }
  }
}