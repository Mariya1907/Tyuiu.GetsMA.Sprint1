using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GetsMA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.GetsMA.Sprint1.Task5.V1.Test

{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 9.5;
            double x2 = 21.3;
            double y1 = 23.3;
            double y2 = 25.2;
            int wait = 12;
            var res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidExpression2()
        {
            DataService ds = new DataService();
            double x1 = 5;
            double x2 = 2;
            double y1 = 3;
            double y2 = 1;
            int wait = 4;
            var res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            Assert.AreEqual(wait, res);
        }
    }
}
