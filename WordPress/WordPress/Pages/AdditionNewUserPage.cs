using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.ObjectModel;

namespace WordPress.Pages
{
  /// <summary>
  /// This is class for adding new user to the wordpress.
  /// </summary>
  public class AdditionNewUserPage
  {
    //http://localhost:8080/wp-admin/user-new.php
    private By newUserLoginBy = By.CssSelector("#user_login");
    private By newUserEmailBy = By.CssSelector("#email");
    private By showPasswordButtonBy = By.XPath("//button[contains(text(), 'Show password')]");
    private By newUserPasswordBy = By.CssSelector("#pass1-text");
    private By weakPasswordConformationCheckBoxBy = By.CssSelector(".pw-checkbox");
    private By newUserRoleSelectorBy = By.CssSelector("#role");
    private By newUserRolesBy = By.XPath("//select[@name='role']/option");
    private By addNewUserButtonBy = By.XPath("//input[@type='submit']");

    public IWebDriver Browser { get; private set; }

    /// <summary>
    /// This is constructor for AdditionNewUserPage.
    /// </summary>
    /// <param name="browser"> Driver, with wich works </param>
    public AdditionNewUserPage(IWebDriver browser)
    {
      PageFactory.InitElements(browser, this);
      Browser = browser;
    }

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
      Browser.FindElement(newUserRoleSelectorBy).Click();
    }

    /// <summary>
    /// This method sets new user role.
    /// </summary>
    /// <param name="newUserRole"> User role </param>
    public void SetNewUserRole(Role role)
    {
      ReadOnlyCollection<IWebElement> userRoles = Browser.FindElements(newUserRolesBy);
      switch (role)
      {
        case Role.SUBSCRIBER:
          userRoles[1].Click();
          break;
        case Role.CONTRIBUTOR:
          userRoles[2].Click();
          break;
        case Role.AUTHOR:
          userRoles[3].Click();
          break;
        case Role.EDITOR:
          userRoles[4].Click();
          break;
        case Role.ADMINISTRATOR:
          userRoles[5].Click();
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

    /// <summary>
    /// This method gets url of the page.
    /// </summary>
    /// <returns> Url of the page </returns>
    public string GetUrl()
    {
      return Browser.Url;
    }
  }
}