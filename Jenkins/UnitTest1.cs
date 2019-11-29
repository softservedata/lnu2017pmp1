using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
//using log4net;
//using log4net.Config;
using NLog;

namespace Jenkins
{
    //[TestClass]
    [TestFixture]
    public class UnitTest1
    {
        //public static ILog log = LogManager.GetLogger(typeof(UnitTest1)); // for Log4net
        //public static Logger log = LogManager.GetCurrentClassLogger(); // for NLog
        public static Logger log = LogManager.GetLogger("rolling0"); // for NLog

        //[TestMethod]
        [Test]
        public void TestMethod1()
        {
            //BasicConfigurator.Configure();
            //XmlConfigurator.Configure();
            //
            log.Trace("NLOG: Trace Level test");
            log.Debug("2*Debug Level test");
            log.Info("2*Info Level");
            log.Warn("2*Warn Level");
            log.Error("2*Error Level test");
            log.Fatal("2*Fatal Level");
            //
            Console.WriteLine("start test");
            //int i = 0;
            double i = 10;
            i = 1 / i;
            Console.WriteLine("i = " + i);
            Console.WriteLine("done test");
        }
    }
}
