using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GetsMA.Sprint1.Task0.V29.Lib;

namespace Tyuiu.GetsMA.Sprint1.Task0.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
            ISprint1Task0V29 ds = new DataService();
            int res = ds.Calculate();
            Assert.AreEqual(32, res); // Тест проверяет именно DataService
        }
    }
}
