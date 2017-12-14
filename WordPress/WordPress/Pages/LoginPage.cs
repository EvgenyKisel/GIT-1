using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WordPress
{
  class LoginPage
  {
    public static readonly string USERNAMELOCATOR = "#user_login";
    public static readonly string PASSWORDLOCATOR = "#user_pass";
    public static readonly string LOGINBUTTONLOCATOR = "//input[@type='submit']";
    public static readonly string REMEMBERMECHECKBOXLOCATOR = "#rememberme";

    public IWebDriver Browser { get; set; }
    public IWebElement WebElement { get; set; }

    public LoginPage(IWebDriver browser)
    {
      if (!browser.Url.Contains("login"))
      {
        throw new NoSuchFrameException();
      }
      PageFactory.InitElements(browser, this);
      Browser = browser;
    }
  }
}