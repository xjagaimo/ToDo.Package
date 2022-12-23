using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ToDo.Package.Rexiar;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()       //to test testTime()
        {
            Pkg1 pkg = new Pkg1();
            DateTime date1 = new DateTime(2010, 10, 22, 10, 0, 0);

            Assert.IsTrue(pkg.testTime(date1));
        }

        [TestMethod]
        public void TestMethod2()           //to test dateConverter()
        {
            Pkg1 pkg = new Pkg1();
            DateTime date1 = new DateTime(2010, 10, 22, 10, 0, 0);
            string datetime = "22/10/2010 10:00:00";

            Assert.AreEqual(pkg.dateConverter(datetime), date1);
        }
    }
}
