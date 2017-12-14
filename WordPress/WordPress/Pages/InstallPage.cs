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
    private By siteTitleBy = By.XPath("//input[@name='weblog_title']");
    private By userNameBy = By.XPath("//input[@name ='user_name']");
    private By passwordBy = By.CssSelector("[type=password]");
    private By emailBy = By.XPath("//input[contains(@name,'email')]");
    private By privacyCheckBoxBy = By.XPath("//input[@type='checkbox']");
    private By installButtonBy = By.XPath("//input[@type='submit']");

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
      Browser.FindElement(siteTitleBy).SendKeys(SITETITLE);
    }

    /// <summary>
    /// This method finds position for user name and inputted it.
    /// </summary>
    public void EnterUserName()
    {
      WebElement = Browser.FindElement(userNameBy);
      WebElement.Clear();
      WebElement.SendKeys(USERNAME);
    }

    /// <summary>
    /// This method finds two positions for passwords and inputted them.
    /// </summary>
    public void EnterPasswords()
    {
      ReadOnlyCollection<IWebElement> passwordsPathes = Browser.FindElements(passwordBy);
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
      Browser.FindElement(emailBy).SendKeys(EMAIL);
    }

    public void AcceptPrivacy()
    {
      Browser.FindElement(privacyCheckBoxBy);
    }

    /// <summary>
    /// This method push submit button.
    /// </summary>
    public void PushSubmitButton()
    {
      Browser.FindElement(installButtonBy).Click();
    }
  }
}