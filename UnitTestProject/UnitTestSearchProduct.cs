using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBH;
using QLBH.TestProduct;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestSearchProduct
    {
        [TestMethod]
        public void Test_Search_Product_Success()
        {
            string actual = SearchProduct.CheckSearchProduct("004");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Search_Product_Null()
        {
            string actual = SearchProduct.CheckSearchProduct(string.Empty);
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Search_Product_NotFind()
        {
            string actual = SearchProduct.CheckSearchProduct("111");
            string expected = "2";
            Assert.AreEqual(expected, actual);
        }

    }
}
