using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBH;


namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Nhap_Dung_Tai_Khoan()
        {
            string actual = checklogin.ktdangnhap("admin", "123");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Nhap_Thieu_ID_and_Pass()
        {
            string actual = checklogin.ktdangnhap("", "");
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Nhap_Thieu_ID()
        {
            string actual = checklogin.ktdangnhap("", "123");
            string expected = "2";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Nhap_Thieu_Pass()
        {

            string actual = checklogin.ktdangnhap("admin", "");
            string expected = "3";
            Assert.AreEqual(expected, actual);
        }
    }
}
