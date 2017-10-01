using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shop.Tests
{
    [TestClass]
    public class InputerTests
    {
        [TestMethod]
        public void InputDouble_string5_double5expected()
        {
            //arrange
            string input = "5";
            double expected = 5;

            //act
            double actual = double.Parse(input);

            //assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void InputInteger_string5_int5expected()
        {
            //arrange
            string input = "5";
            int expected = 5;

            //act
            int actual = int.Parse(input);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}