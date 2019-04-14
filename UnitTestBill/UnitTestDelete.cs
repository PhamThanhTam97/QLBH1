using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBH;
using QLBH.TestBill;

namespace UnitTestBill
{
    [TestClass]
    public class UnitTestDelete
    {
        [TestMethod]
        public void Test_Delete_bill()
        {
            string actual = CheckDelete.kt_delete("010");
            string expected = "0";
            Assert.AreEqual(expected, actual);
        }
    }
}
