using System;
using NUnit.Framework;

namespace WordPress.Tests
{
  public class UserNegativeTests
  {
    private static readonly string[] sourceListWithInvalidEmails =
    {
        "email.com",
        "@email.com",
        "email!",
        " "
    };

    private static readonly string[] sourceListWithInvalidNames =
    {
        "(&)",
        "!*~",
        "имя"
    };

    [Test, TestCaseSource("sourceListWithInvalidEmails")]
    public void UserConstructor_invalidEmail_expectedErrors(string sourceListWithInvalidEmails)
    {
      Assert.Throws<FormatException>(()=> new User("user", "password", sourceListWithInvalidEmails, Role.ADMINISTRATOR));
    }

    [Test, TestCaseSource("sourceListWithInvalidNames")]
    public void UserConstructor_invalidName_expectedErrors(string sourceListWithInvalidNames)
    {
      Assert.Throws<FormatException>(() => new User(sourceListWithInvalidNames, "password", "email@email.com", Role.ADMINISTRATOR));
    }
  }
}