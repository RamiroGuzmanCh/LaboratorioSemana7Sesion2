using System.Numerics;
using TestingSale;

namespace UnitTestSale
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Sale precio=new Sale();
            double result = precio.GetFulllDiscount(1000.00, true);
            Assert.AreEqual(800.00, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Sale precio = new Sale();
            double result = precio.GetFullTaxes(100.00, true);
            Assert.AreEqual(100,18, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Sale precio = new Sale();
            double result = precio.GetFulllDiscount(10000.00, false);
            Assert.AreEqual(10000, result);
        }

     
    }
}
