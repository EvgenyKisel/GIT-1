using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordPress.Tests
{
  [TestClass]
  public class UserPositiveTests
  {
    [TestMethod]
    public void UserConstructor_validUserName_successfulInitialization()
    {
      Assert.AreEqual("u-s _e@.r", new User("u-s _e@.r", "password", "email@email.com", Role.ADMINISTRATOR).UserName);
    }

    [TestMethod]
    public void UserConstructor_validEmail_successfulInitialization()
    {
      Assert.AreEqual("email.em-a_il@email.com", new User("user", "password", "email.em-a_il@email.com", Role.ADMINISTRATOR).Email);
    }
  }
}