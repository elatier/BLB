using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using BuyLocalBonds.BackEnd;

namespace TestBLB
{

    [TestFixture]
    public class TestBond
    {
        private Bond b;

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
            b = new Bond();
        }

        [TearDown]
        public void tearDown()
        {
            b = null;
        }

        [Test]
        public void testNotNull()
        {
            Assert.NotNull(b);
        }

        [Test]
        public void testDefaultConstructorValues()
        {

            Assert.AreEqual(new DateTime(0001, 1, 1), b.Maturity_date_low);
            Assert.AreEqual(new DateTime(9999, 12, 31), b.Maturity_date_high);
        }

    }
}
