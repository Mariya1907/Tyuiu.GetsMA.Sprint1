using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GetsMA.Sprint1.Task2.V9.Lib;
using System;

namespace Tyuiu.GetsMA.Sprint1.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTests
    {
        [TestMethod]
        public void CalculateSphereVolume_ValidRadius_ReturnsCorrectResult()
        {
            var dataService = new DataService();
            int radius = 3;
            double expected = Math.Round((4.0 / 3.0) * Math.PI * Math.Pow(radius, 3), 3);

            double result = dataService.CalculateSphereVolume(radius);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateSphereVolume_ZeroOrNegativeRadius_ThrowsException()
        {
            var dataService = new DataService();
            dataService.CalculateSphereVolume(0);
        }
    }
}
