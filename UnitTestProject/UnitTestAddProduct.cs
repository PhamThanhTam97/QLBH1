using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBH.TestProduct;
//using System.Windows.Forms;
using QLBH;


namespace UnitTestProject
{
    [TestClass]
    public class UnitTestAddProduct
    {
        [TestMethod]
        public void Test_Add_Product_Success()
        {
            string actual = AddProduct.kt_themsp("015", "Trứng Cút", "20000");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Add_Product_With_MaSP_NULL()
        {
            string actual = AddProduct.kt_themsp("", "Banh gio co tam", "10000");
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Add_Product_With_TenSP_NULL()
        {
            string actual = AddProduct.kt_themsp("008", "", "10000");
            string expected = "2";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Add_Product_With_DonGia_NULL()
        {
            string actual = AddProduct.kt_themsp("008", "Trứng muối", "");
            string expected = "3";
            Assert.AreEqual(expected, actual);
        }


    }
}
