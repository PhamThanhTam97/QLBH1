using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBH;
using QLBH.TestBill;
namespace UnitTestBill
{
    [TestClass]
    public class UnitTestUpdate
    {
        [TestMethod]
        public void Test_Update_Bill()
        {
            string actual = CheckUpdateBill.CheckUpdate("010", "030", "004", "11-03-2019", "11-05-2019");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Update_MaNVnull()
        {
            string actual = CheckUpdateBill.CheckUpdate("010", "", "004", "11-03-2019", "11-05-2019");
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Update_MaKHnull()
        {
            string actual = CheckUpdateBill.CheckUpdate("010", "030", "", "11-03-2019", "11-05-2019");
            string expected = "2";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Update_NgayLapnull()
        {
            string actual = CheckUpdateBill.CheckUpdate("010", "030", "004", "", "11-05-2019");
            string expected = "3";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Update_NgayNhannull()
        {
            string actual = CheckUpdateBill.CheckUpdate("010", "030", "004", "11-03-2019", "");
            string expected = "4";
            Assert.AreEqual(expected, actual);
        }
    }
}
