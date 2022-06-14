using DemoApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using Assert = NUnit.Framework.Assert;

namespace DemoTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Program calc = new Program();

             var res = calc.Sum(2, 3);

            Assert.AreEqual(5, res);
        }
    }
}
