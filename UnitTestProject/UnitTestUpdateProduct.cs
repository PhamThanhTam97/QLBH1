using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBH;
using QLBH.TestProduct;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestUpdateProduct
    {
        [TestMethod]
        public void Test_Update_Product1()
        {
            string actual = UpdateProduct.CheckUpdate("010", "Chan ga", "20000");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Update_Product2_With_TenSP_Null()
        {
            string actual = UpdateProduct.CheckUpdate("009", "", "20000");
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Update_Product_With_DonGia_Null()
        {
            string actual = UpdateProduct.CheckUpdate("009", "Chan ga", "");
            string expected = "2";
            Assert.AreEqual(expected, actual);
        }

    }
}
