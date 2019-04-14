using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBH;
using QLBH.TestBill;
namespace UnitTestBill
{
    [TestClass]
    public class UnitTestAddBill
    {

        [TestMethod]
        public void Test_Them_HD()
        {
            string actual = TestBill.kt_themhd("012", "001", "004", "11-24-2019", "11-25-2019");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Them_HD_MaHD_Null()
        {
            string actual = TestBill.kt_themhd("", "002", "10000", "11-03-2019", "11-05-2019");
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Them_HD_MaNV_Null()
        {
            string actual = TestBill.kt_themhd("022", "", "10000", "11-03-2019", "11-05-2019");
            string expected = "2";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Them_HD_MaKH_null()
        {
            string actual = TestBill.kt_themhd("022", "002", "", "11-22-2019", "11-25-2019");
            string expected = "3";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Them_HD_NgayLap_Null()
        {
            string actual = TestBill.kt_themhd("022", "002", "004", "", "11-25-2019");
            string expected = "4";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Them_HD_NgayNhan_Null()
        {
            string actual = TestBill.kt_themhd("022", "002", "004", "11-22-2019", "");
            string expected = "5";
            Assert.AreEqual(expected, actual);
        }
    }
}
