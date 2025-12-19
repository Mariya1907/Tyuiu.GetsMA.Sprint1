using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GetsMA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.GetsMA.Sprint1.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestDistanceBetweenPoints()
        {
            DataService ds = new DataService();
            // Тестируем расстояние между (0,0) и (3,4) → ожидаем 5
            Assert.AreEqual(5, ds.DistanceBetweenPoints(0, 0, 3, 4));
        }
    }
}

