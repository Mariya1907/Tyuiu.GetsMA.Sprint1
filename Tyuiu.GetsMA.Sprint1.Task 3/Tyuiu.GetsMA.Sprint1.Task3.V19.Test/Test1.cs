using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GetsMA.Sprint1.Task3.V19.Lib;

namespace Tyuiu.GetsMA.Sprint1.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 2;
            double x2 = 1;
            double y1 = 2;
            double y2 = 1;
            var res = ds.ElephCanMove(x1, x2, y1, y2);
            Assert.IsTrue(res);  
        }
    }
}
