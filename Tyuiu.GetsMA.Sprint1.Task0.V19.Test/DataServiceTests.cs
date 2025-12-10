using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GetsMA.Sprint1.Task1.V19.Lib;
using System;

namespace Tyuiu.GetsMA.Sprint1.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTests
    {
        [TestMethod]
        public void Calculate_ValidInput_ReturnsCorrectResult()
        {
            IDataService dataService = new DataService();
            double x = 2;
            double y = 3;
            double expected = (x + 10 * y) / (x * y); // (2 + 30)/6 = 5.3333

            double result = dataService.Calculate(x, y);

            Assert.AreEqual(expected, result, 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Calculate_ZeroInput_ThrowsException()
        {
            IDataService dataService = new DataService();
            dataService.Calculate(0, 5);
        }
    }
}
