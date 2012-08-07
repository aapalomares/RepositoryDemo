using System;
using System.Diagnostics;
using System.Threading;
using NUnit.Framework;

namespace WindowsFormsApplicationRemote
{
    [TestFixture]
    class WindowsTest
    {
        [Test]
        public void TestSuccess()
        {
            Trace.TraceInformation("Test trace.");
        }

        [Test]
        public void TestException()
        {
            throw new Exception("Test Exception");
        }

        [Test]
        public void TestAssert()
        {
            Assert.Fail("Test Assert");
        }

        [Test]
        public void TestHang()
        {
            Thread.Sleep(10000);
        }


        [Test]
        public void TestCompare()
        {
            string valueOne, valueTwo;

            valueOne = "One";
            valueTwo = "One";

            Assert.AreEqual(valueOne, valueTwo);
        }
    }
}
