using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading;
using System.Diagnostics;

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

        //[Test]
        //public void TestException()
        //{
        //    throw new Exception("Test Exception");
        //}

        //[Test]
        //public void TestAssert()
        //{
        //    Assert.Fail("Test Assert");
        //}

        [Test]
        public void TestHang()
        {
            Thread.Sleep(10000);
        }

    }
}
