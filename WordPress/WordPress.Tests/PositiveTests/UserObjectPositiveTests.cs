﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordPress.Tests
{
  [TestClass]
  public class UserObjectPositiveTests
  {
    [TestMethod]
    public void UserConstructor_validUserName_successfulInitialization()
    {
      Assert.AreEqual("u-s _e@.r", new Objects.Author("u-s _e@.r", "password", "email@email.com").UserName);
    }

    [TestMethod]
    public void UserConstructor_validEmail_successfulInitialization()
    {
      Assert.AreEqual("email.em-a_il@email.com", new Objects.Author("user", "password", "email.em-a_il@email.com").Email);
    }
  }
}