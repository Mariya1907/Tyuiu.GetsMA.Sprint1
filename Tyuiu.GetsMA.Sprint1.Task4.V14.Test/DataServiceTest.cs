using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GetsMA.Sprint1.Task4.V14.Lib;

namespace Tyuiu.GetsMA.Sprint1.Task4.V14.Test  // ← ДОБАВЬ!
{
    [TestClass]  // ← ДОБАВЬ!
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 2;
            double wait = 0.062;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res, 0.001);  // ← delta для double!
        }
    }
}
