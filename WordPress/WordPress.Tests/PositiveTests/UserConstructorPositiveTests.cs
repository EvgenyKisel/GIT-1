using NUnit.Framework;

namespace WordPress.Tests
{
  [TestFixture]
  public class UserPositiveTests
  {
    [Test]
    public void UserConstructor_validUserName_successfulInitialization()
    {
      Assert.AreEqual("u-s _e@.r", new User("u-s _e@.r", "password", "email@email.com", Role.ADMINISTRATOR).UserName);
    }

    [Test]
    public void UserConstructor_validEmail_successfulInitialization()
    {
      Assert.AreEqual("email.em-a_il@email.com", new User("user", "password", "email.em-a_il@email.com", Role.ADMINISTRATOR).Email);
    }
  }
}