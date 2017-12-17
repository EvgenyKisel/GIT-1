using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace WordPress.Pages
{
  /// <summary>
  /// This is class for login page.
  /// </summary>
  public class LoginPage
  {
    private static readonly string URL_LOGIN_PAGE = "http://localhost:8080/wp-login.php";

    private By userNameBy = By.CssSelector("#user_login");
    private By passwordBy = By.CssSelector("#user_pass");
    public By logInButtonBy = By.XPath("//input[@type='submit']");
    public By rememberMeCheckBoxBy = By.CssSelector("#rememberme");
    public By logInErrorBy = By.XPath("//div[@id='login_error']");

    public IWebDriver Browser { get; set; }
    public User CurrentUser { get; set; }

    /// <summary>
    /// This is constructor for login page.
    /// </summary>
    /// <param name="browser"> Driver, with wich works </param>
    /// <param name="user"> Current user </param>
    public LoginPage(IWebDriver browser, User user)
    {
      PageFactory.InitElements(browser, this);
      Browser = browser;
      CurrentUser = user;
    }

    /// <summary>
    /// This method opens login page.
    /// </summary>
    public void OpenLoginPage()
    {
      Browser.Navigate().GoToUrl(URL_LOGIN_PAGE);
    }

    /// <summary>
    /// This method finds position for user name and inputted it.
    /// </summary>
    public void InputUserName()
    {
      Browser.FindElement(userNameBy).SendKeys(CurrentUser.UserName);
    }

    /// <summary>
    /// This method finds position for password and inputs it.
    /// </summary>
    public void InputPassword()
    {
      Browser.FindElement(passwordBy).SendKeys(CurrentUser.Password);
    }

    /// <summary>
    /// This method clicks on rememberme check box.
    /// </summary>
    public void ClickOnRememberMeCheckBox()
    {
      Browser.FindElement(rememberMeCheckBoxBy).Click();
    }

    /// <summary>
    /// This method pushes login button.
    /// </summary>
    /// <returns> Home page corresponding to the user </returns>
    public object PushLogInButton()
    {
      Browser.FindElement(logInButtonBy).Click();
      switch (CurrentUser.UserRole)
      {
        case Role.SUBSCRIBER:
          return new SubscriberHomePage(Browser);
        case Role.CONTRIBUTOR:
          return new ContributorHomePage(Browser);
        case Role.AUTHOR:
          return new AuthorHomePage(Browser);
        case Role.EDITOR:
          return new EditorHomePage(Browser);
        case Role.ADMINISTRATOR:
          return new AdminHomePage(Browser);
        default:
          throw new ArgumentException();
      }
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
    /// This method catches login error.
    /// </summary>
    /// <returns> Error message </returns>
    public string CatchLoginError()
    {
      return Browser.FindElement(logInErrorBy).Text;
    }
  }
}
