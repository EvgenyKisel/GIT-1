using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shop.Tests
{
    [TestClass]
    public class GoodsBuilderTests
    {
        [TestMethod]
        public void CreateGoods_typeNameCountPrice_Goodsexpected()
        {
            //arrange
            string type = "notebook";
            string name = "lenovo";
            int count = 1;
            double price = 1000;

            //act
            Goods actualGoods = new Goods(type,name,count,price);

            //assert
            Assert.AreEqual(actualGoods.Type, type);
            Assert.AreEqual(actualGoods.Name, name);
            Assert.AreEqual(actualGoods.Count, count);
            Assert.AreEqual(actualGoods.Price, price);
        }
    }
}