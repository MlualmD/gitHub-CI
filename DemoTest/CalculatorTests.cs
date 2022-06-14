<<<<<<< HEAD
<<<<<<< HEAD
 using DemoApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using Assert = NUnit.Framework.Assert;

namespace DemoTest
{
    [TestFixture]
   public class CalculatorTests : Calculator
        {

            [Test]
            public void TestCanDoUnitTesting()
            {
               Assert.True(true); 
            }
            [Test]
            public void TestRes()
            {
                int n1 = 5;
                int n2 = 2;
              
               Assert.AreEqual(n1 - n2, Calculator.Subtract(n1, n2));
            }
            [Test]

            public void TestSum()
            {
                int n1 = 10;
                int n2 = 3;
                Assert.AreEqual(n1 + n2, Calculator.Add(n1, n2));
            }

            [Test]
            public void TestDiv()
            {
                int n1 = 10;
                int n2 = 2;
                Assert.AreEqual(n1 / n2, Calculator.Divide(n1, n2));
            }

            [Test]
            public void TestMul()
            {
                int n1 = 3;
                int n2 = 3;
               Assert.AreEqual(n1 * n2, Calculator.Multiply(n1, n2));
            }


        }
    
}
=======
Hello Universe! 6/14/2022 7:10:13 PM
>>>>>>> 35b91023b2bfaa7d87df55c7e5749d2fad9594e5
=======
Succeeded
>>>>>>> 131ac0ee7a52d6f2c20b3e6d26a12a7d2f48f1f8
