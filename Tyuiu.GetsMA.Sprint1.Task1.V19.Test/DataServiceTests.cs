using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GetsMA.Sprint1.Task1.V19.Lib;

namespace Tyuiu.GetsMA.Sprint1.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTests
    {
        [TestMethod]
        public void Calculate_ValidInput_ReturnsCorrectResult()
        {
            // ❌ УБЕРИ IDataService!
            DataService dataService = new DataService();  // ✅ ПРЯМО DataService!
            double x = 2;
            double y = 3;
            double expected = 5.333;

            double result = dataService.Calculate(x, y);
            Assert.AreEqual(expected, result, 0.001);
        }

        [TestMethod]
        public void Calculate_ZeroInput_ThrowsException()
        {
            DataService dataService = new DataService();  // ✅ ПРЯМО DataService!

            Assert.ThrowsException<ArgumentException>(() =>
                dataService.Calculate(0, 5));
        }
    }
}
