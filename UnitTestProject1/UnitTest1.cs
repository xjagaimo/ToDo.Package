using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ToDo.Package;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Pkg1 pkg = new Pkg1();
            DateTime date1 = new DateTime(2010, 10, 22, 10, 0, 0);
            //bool worked = false;
            Assert.IsTrue(pkg.testTime(date1));
            //Assert.AreEqual(worked, pkg.testTime(date1));
            
        }
    }
}
