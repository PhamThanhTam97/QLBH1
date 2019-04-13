using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBH;
using QLBH.TestProduct;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestDeleteProduct
    {
        [TestMethod]
        public void Test_Delete_Product()
        {
            string actual = DeleteProduct.CheckDetele("015");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }
    }
}
