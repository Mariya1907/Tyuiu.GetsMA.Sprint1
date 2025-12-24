using Tyuiu.GetsMA.Sprint1.Task7.V19.Lib;

namespace Tyuiu.GetsMA.Sprint1.Task7.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressionTest()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);

            Assert.AreEqual(18.409, res);
        }
    }
}

