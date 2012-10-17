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
        public void testParseDate()
        {
            DateTime defValue = new DateTime(0001, 1, 1);
            String input = "22/03/2012";
            DateTime output = Util.ParseDate(defValue, input);
            Assert.AreEqual(new DateTime(2012, 03, 22), output);

        }
    }
}
