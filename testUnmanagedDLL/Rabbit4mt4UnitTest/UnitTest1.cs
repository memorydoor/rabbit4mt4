using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Rabbit4mt4UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void test_InitializeMQConnection()
        {
            string result = Rabbit4mt4DLL.Test.InitializeMQConnection("localhost", "guest", "guest", "/", "topic_logs", "mt4_demo01_123456");
            System.Diagnostics.Debug.WriteLine("Matrix has you...");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void test_GetMessageFromQueue()
        {
            string result = Rabbit4mt4DLL.Test.InitializeMQConnection("localhost", "guest", "guest", "/", "topic_logs", "mt4_demo01_123456");
            System.Diagnostics.Debug.WriteLine(result);
            var message = Rabbit4mt4DLL.Test.GetMessageFromQueue("candle.wait.for.validate");
            
            Assert.AreEqual(1, message);
        }


        [TestMethod]
        public void test_SendMessageToQueue()
        {
            string result = Rabbit4mt4DLL.Test.InitializeMQConnection("localhost", "guest", "guest", "/", "topic_logs", "mt4_demo01_123456");

            var message = Rabbit4mt4DLL.Test.SendMessageToQueue("mt4CommandsResponse", "{\"command\":\"SyncCandle\",\"response\":\"\"}");

            Assert.AreEqual(1, message);
        }
    }


}
