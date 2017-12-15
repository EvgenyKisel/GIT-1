using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace WordPress.Tests
{
  [TestClass]
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
    [ExpectedException(typeof(FormatException))]
    [Test, TestCaseSource("sourseList")]
    public void UserConstructor_invalidSymbols_expectedErrors(string[] sourseList)
    {
      //new User(sourseList, "password", "email@email.com");
    }
  }
}