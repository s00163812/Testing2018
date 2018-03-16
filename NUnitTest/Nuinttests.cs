using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using InsurancePremiums;

namespace NUnitTest
{
    public class Nuinttests
    {
        public Class1 client;

            [SetUp]
            public void Init()
        {
            client = new Class1();

        }


        [Test]
         public void Test1()
        {
            double expected = 5;
            double actual = client.CalcPremium(18, "female");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test2()
        {
            double expected = 5;
            double actual = client.CalcPremium(30, "female");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test3()
        {
            double expected = 0;
            double actual = client.CalcPremium(16, "female");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test4()
        {
            double expected = 3.5;
            double actual = client.CalcPremium(32, "female");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test5()
        {
            double expected = 3.5 * 0.5;
            double actual = client.CalcPremium(51, "female");
            Assert.AreEqual(expected, actual);
        }



        [Test]
        public void Test6()
        {
            double expected = 6;
            double actual = client.CalcPremium(18, "male");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test7()
        {
            double expected = 5;
            double actual = client.CalcPremium(37, "male");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test8()
        {
            double expected = 0;
            double actual = client.CalcPremium(17, "male");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test9()
        {
            double expected = 5 * 0.5;
            double actual = client.CalcPremium(51, "male");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test10()
        {
            double expected = 6;
            double actual = client.CalcPremium(25, "male");
            Assert.AreEqual(expected, actual);
        }
    }
}
