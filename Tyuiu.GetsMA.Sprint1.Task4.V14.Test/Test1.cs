using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GetsMA.Sprint1.Task4.V14.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestCalculate()
    {
        DataService ds = new DataService();
        double result = ds.Calculate(2, 3);  // 2^3 = 8
        Assert.AreEqual(8, result, 0.1);
    }
}

