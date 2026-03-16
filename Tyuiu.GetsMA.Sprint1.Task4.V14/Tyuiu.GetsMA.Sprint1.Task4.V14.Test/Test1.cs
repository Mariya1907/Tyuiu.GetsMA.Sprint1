using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GetsMA.Sprint1.Task4.V14.Lib;

namespace Tyuiu.GetsMA.Sprint1.Task4.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(2, 1);
            Assert.AreEqual(0.721, result);
        }
    }
}
