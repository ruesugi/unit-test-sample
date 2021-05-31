using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample;

namespace SampleTest
{
    [TestClass]
    public class CalculationTest
    {
        [TestMethod]
        public void 足し算のテスト()
        {
            Calculation calculation = new Calculation();
            Assert.AreEqual(3, calculation.Add(1, 2));
        }

        [TestMethod]
        public void 失敗するテスト()
        {
            Calculation calculation = new Calculation();
            Assert.AreEqual(0, calculation.Add(1, 2));
        }
    }
}
