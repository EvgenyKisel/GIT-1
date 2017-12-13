using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.ObjectModel;

namespace WordPress
{
  /// <summary>
  /// This is class for install page.
  /// </summary>
  class InstallPage
  {
    private static readonly string SITETITLELOCATOR = "//input[@name='weblog_title']";
    private static readonly string USERNAMELOCATOR = "//input[@name ='user_name']";
    private static readonly string PASSWORDLOCATOR = "[type=password]"; ////input[@type='password']
    private static readonly string EMAILLOCATOR = "//input[contains(@name,'email')]";
    private static readonly string PRIVACYLOCATOR = "//input[@type='checkbox']";
    private static readonly string INSTALLBUTTONLOCATOR = "//input[@type='submit']";

    private static readonly string URLPART = "install";
    private static readonly string SITETITLE = "Site 1";
    private static readonly string USERNAME = "admin";
    private static readonly string PASSWORD = "password";
    private static readonly string EMAIL = "evgeny@gmail.com";

    public IWebDriver Browser { get; set; }
    public IWebElement WebElement { get; set; }

    /// <summary>
    /// This is constructor for install page.
    /// </summary>
    /// <param name="browser">  </param>
    public InstallPage(IWebDriver browser)
    {
      if (!browser.Url.Contains(URLPART))
      {
        throw new NoSuchFrameException();
      }
      PageFactory.InitElements(browser, this);
      Browser = browser;
    }

    /// <summary>
    /// This method finds position for site title and inputted it.
    /// </summary>
    public void EnterSiteTitle()
    {
      Browser.FindElement(By.XPath(SITETITLELOCATOR)).SendKeys(SITETITLE);      
    }

    /// <summary>
    /// This method finds position for user name and inputted it.
    /// </summary>
    public void EnterUserName()
    {
      WebElement = Browser.FindElement(By.XPath(USERNAMELOCATOR));
      WebElement.Clear();
      WebElement.SendKeys(USERNAME);
    }

    /// <summary>
    /// This method finds two positions for passwords and inputted them.
    /// </summary>
    public void EnterPasswords()
    {
      ReadOnlyCollection<IWebElement> passwordsPathes = Browser.FindElements(By.CssSelector(PASSWORDLOCATOR));
      foreach (IWebElement passwordPath in passwordsPathes)
      {
        passwordPath.SendKeys(PASSWORD);
      }
    }

    /// <summary>
    /// This method finds position for email and inputted it.
    /// </summary>
    public void EnterEmail()
    {
      Browser.FindElement(By.XPath(EMAILLOCATOR)).SendKeys(EMAIL);
    }

    public void AcceptPrivacy()
    {
      Browser.FindElement(By.XPath(PRIVACYLOCATOR));
    }

    /// <summary>
    /// This method push submit button.
    /// </summary>
    public void PushSubmitButton()
    {
      Browser.FindElement(By.XPath(INSTALLBUTTONLOCATOR)).Click();
    }
  }
}