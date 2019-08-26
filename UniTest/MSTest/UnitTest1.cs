using Microsoft.VisualStudio.TestTools.UnitTesting;
using UniTest.Calculator;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        public Calculator cal = new Calculator();
        [TestMethod]
        public void AddTest()
        {
            Assert.IsTrue(cal.Add(5, 5) == 10);
            Assert.IsTrue(cal.Add(4, 1) == 5);
            Assert.IsTrue(cal.Add(2, 'a') == 99);
            Assert.AreEqual(10, cal.Add(5, 5));
        }

        public void SubtractTest()
        {
            Assert.IsTrue(cal.Subtract(5, 5) == 0);
            Assert.IsTrue(cal.Subtract(4, 1) == 3);
            Assert.IsTrue(cal.Subtract('a', 2) == 95);
            Assert.AreEqual(10, cal.Add(20, 10));
        }
    }
}
