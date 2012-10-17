using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using BuyLocalBonds.BackEnd;

namespace TestBLB
{
    [TestFixture]
    class TestUtility
    {
        [TestFixtureSetUp]
        public static void overallInit()
        {
            Console.WriteLine("could do common initialization here");
        }

        [TestFixtureTearDown]
        public static void overallTeardown()
        {
            Console.WriteLine("could do common cleanup here");
        }

        [SetUp]
        public void setUp()
        {
            
        }

        [TearDown]
        public void tearDown()
        {
           
        }

        [Test]
        public void testParseDateCorrect()
        {

            DateTime defValue = new DateTime(0001, 1, 1);
            String input = "22/12/2344";
            DateTime out1 = Util.ParseDate(defValue, input);
            Assert.AreEqual(out1, new DateTime(2344, 12, 22));

        }

        [Test]
        public void testParseDateNotCorrect()
        {

            DateTime defValue = new DateTime(0001, 1, 1);
            String input = "22/13/2344";
            DateTime out1 = Util.ParseDate(defValue, input);
            Assert.AreEqual(out1, defValue);

        }
    }
}
