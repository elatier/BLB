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
        public void testConstructor()
        {
           // b = new Bond("123", "name1", 123.123);
            Assert.AreEqual("123", b.Cusip);
            Assert.AreEqual("name1", b.Name);
           // Assert.AreEqual(123.123, b.Price);
        }

    }
}
