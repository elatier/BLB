using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using BuyLocalBonds.BackEnd;

namespace TestBLB
{
    [TestFixture]
    class TestBend
    {
        BEnd b;

        [TestFixtureSetUp]
        public static void overallInit()
        {

        }

        [TestFixtureTearDown]
        public static void overallTeardown()
        {
            Console.WriteLine("could do common cleanup here");
        }

        [SetUp]
        public void setUp()
        {
            b = new BEnd();
        }

        [TearDown]
        public void tearDown()
        {
            b = null;
        }

        [TestCase("a","123456789a"), ExpectedException("System.Exception")]
        [TestCase("-123", "123456789adsa")]
        [TestCase("aaa", "123456789")]
        [TestCase("1", "123456789a")]
        [TestCase("", "")]
        [TestCase(null, null)]
        public void testGetClientBondQuantity(string client_id, string cusip)
        {
            //test with incorrect clien_id
            b.GetClientBondQuantity(client_id,cusip);
            
        }

    }
}
