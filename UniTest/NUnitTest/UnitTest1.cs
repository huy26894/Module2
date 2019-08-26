using NUnit.Framework;
using UniTest.Calculator;

namespace Tests
{
    public class Tests
    {
        Calculator cal;
        [SetUp]
        public void Setup()
        {
            cal = new Calculator();
        }

        [Test]
        public void AddTest()
        {
            Assert.AreEqual(10, cal.Add(5, 5));
        }
        [TestCase(10,10,20)]
        [TestCase(20, 5, 25)]
        [TestCase(5, 7, 12)]

        public void AddTests(int a,int b,int c)
        {
            Assert.AreEqual(c, cal.Add(a, b));
        }
    }
}