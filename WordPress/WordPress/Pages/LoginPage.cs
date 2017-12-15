using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WordPress
{
  /// <summary>
  /// This is class for login page.
  /// </summary>
  class LoginPage
  {
    private static readonly string URL_LOGIN_PAGE = "http://localhost:8080/wp-login.php";

    private By userNameBy = By.CssSelector("#user_login");
    private By passwordBy = By.CssSelector("#user_pass");
    public By logInButtonBy = By.XPath("//input[@type='submit']");
    public By rememberMeCheckBoxBy = By.CssSelector("#rememberme");

    public IWebDriver Browser { get; set; }

    /// <summary>
    /// This is constructor for login page.
    /// </summary>
    /// <param name="browser"> Driver, with wich works </param>
    public LoginPage(IWebDriver browser)
    {
      PageFactory.InitElements(browser, this);
      Browser = browser;
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
    /// <param name="user"> Concrete user </param>
    public void InputUserName(User user)
    {
      Browser.FindElement(userNameBy).SendKeys(user.UserName);
    }

    /// <summary>
    /// This method finds position for password and inputs it.
    /// </summary>
    /// <param name="user"> Concrete user </param>
    public void InputPassword(User user)
    {
      Browser.FindElement(passwordBy).SendKeys(user.Password);
    }

    /// <summary>
    /// This method clicks on rememberme check box.
    /// </summary>
    public void ClickOnRememberMeCheckBox()
    {
      Browser.FindElement(rememberMeCheckBoxBy).Click();
    }

    /// <summary>
    /// This method push log in button.
    /// </summary>
    public void PushLogInButton()
    {
      Browser.FindElement(logInButtonBy).Click();
    }
  }
}