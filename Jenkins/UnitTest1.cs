using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Jenkins
{
    //[TestClass]
    [TestFixture]
    public class UnitTest1
    {
        //[TestMethod]
        [Test]
        public void TestMethod1()
        {
            Console.WriteLine("start test");
            int i = 0;
            i = 1 / i;
            Console.WriteLine("done test");
        }
    }
}
