using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WordPress
{
  /// <summary>
  /// This is class for login page.
  /// </summary>
  public class EditorLoginPage
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
    public EditorLoginPage(IWebDriver browser, User user)
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
    /// <param name="user"> Concrete user </param>
    public void InputUserName()
    {
      Browser.FindElement(userNameBy).SendKeys(CurrentUser.UserName);
    }

    /// <summary>
    /// This method finds position for password and inputs it.
    /// </summary>
    /// <param name="user"> Concrete user </param>
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
    /// This method push log in button.
    /// </summary>
    public Pages.EditorHomePage PushLogInButton()
    {
      Browser.FindElement(logInButtonBy).Click();
      return new Pages.EditorHomePage(Browser);
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