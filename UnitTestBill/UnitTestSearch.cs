using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBH;
using QLBH.TestBill;

namespace UnitTestBill
{
    [TestClass]
    public class UnitTestSearch
    {
        [TestMethod]
        public void Test_Search_Bill_TimThay()
        {
            string actual = CheckSearch.kt_searchBill("002");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Search_Bill_Rong()
        {
            string actual = CheckSearch.kt_searchBill(string.Empty);
            string expected = "1";
            Assert.AreEqual(expected, actual);
        }

    }
}
