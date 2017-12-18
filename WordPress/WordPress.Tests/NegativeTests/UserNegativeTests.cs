using System;
using NUnit.Framework;

namespace WordPress.Tests
{
  public class UserNegativeTests
  {
    private static readonly string[] sourseListWithInvalidEmails =
    {
        "email.com",
        "@email.com",
        "email!",
        " "
    };

    private static readonly string[] sourseListWithInvalidNames =
    {
        "(&)",
        "!*~",
        "имя"
    };

    [Test, TestCaseSource("sourseListWithInvalidEmails")]
    public void UserConstructor_invalidEmail_expectedErrors(string sourseListWithInvalidEmails)
    {
      Assert.Throws<FormatException>(()=> new User("user", "password", sourseListWithInvalidEmails, Role.ADMINISTRATOR));
    }

    [Test, TestCaseSource("sourseListWithInvalidNames")]
    public void UserConstructor_invalidName_expectedErrors(string sourseListWithInvalidNames)
    {
      Assert.Throws<FormatException>(() => new User(sourseListWithInvalidNames, "password", "email@email.com", Role.ADMINISTRATOR));
    }
  }
}