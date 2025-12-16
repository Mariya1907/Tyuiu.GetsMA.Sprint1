using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GetsMA.Sprint1.Task1.V19.Lib;
using System;

namespace Tyuiu.GetsMA.Sprint1.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTests
    {
        [TestMethod]
        public void Calculate_ValidInput_ReturnsCorrectResult()
        {
            var dataService = new DataService();
            double x = 2, y = 3;
            double expected = (x + 10 * y) / (x * y);

            double result = dataService.Calculate(x, y);

            Assert.AreEqual(expected, result, 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Calculate_ZeroInput_ThrowsException()
        {
            var dataService = new DataService();
            dataService.Calculate(0, 5);
        }
    }
}


