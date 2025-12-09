using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GetsMA.Sprint1.Task0.V29.Lib.Net8;

namespace Tyuiu.GetsMA.Sprint1.Task0.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
            var ds = new DataService();
            int res = ds.Calculate();
            Assert.AreEqual(32, res);
        }
    }
}

