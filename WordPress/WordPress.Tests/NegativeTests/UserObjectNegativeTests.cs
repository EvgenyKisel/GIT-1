using System;
using NUnit.Framework;

namespace WordPress.Tests
{
  public class UserObjectNegativeTests
  {
    private static readonly string[] sourseList =
    {
        "!user",
        "us/er",
        "us\'er",
        "user*",
        "us+er"
    };
    
    [Test, TestCaseSource("sourseList")]
    public void UserConstructor_invalidSymbols_expectedErrors(string sourseList)
    {
      Assert.Throws<FormatException>(()=> new Objects.Author(sourseList, "password", "email@email.com"));
    }
  }
}