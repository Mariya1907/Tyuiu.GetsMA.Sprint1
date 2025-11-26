using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.GetsMA.Sprint0.Task29.V0.Lib;

namespace Tyuiu.GetsMA.Sprint0.Task29.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
            DataService ds = new DataService();
            int res = ds.Calculate();
            Assert.AreEqual(32, res);
        }
    }
}


