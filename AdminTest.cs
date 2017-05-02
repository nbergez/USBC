using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using USBC1;

namespace USBC1UnitTest
{
    [TestClass]
    public class AdminTest
    {
        [TestMethod]
        public void LoggerOuputDifferent()
        {
            Admin admin1 = new Admin(new LoggerTheFirst());
            Admin admin2 = new Admin(new LoggerTheSecond());

            Assert.AreNotEqual(admin1.Logger.GetType(), admin2.Logger.GetType());
        }
    }
}
