using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GetsMA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.GetsMA.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestDistanceBetweenPoints()
        {
            DataService ds = new DataService();
            int result = ds.DistanceBetweenPoints(0, 0, 3, 4);
            Assert.AreEqual(5, result);  // √(3²+4²) = 5
        }
    }
}
