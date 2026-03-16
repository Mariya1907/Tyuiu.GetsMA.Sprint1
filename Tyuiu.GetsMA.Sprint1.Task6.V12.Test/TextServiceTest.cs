using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GetsMA.Sprint1.Task6.V12.Lib;

namespace Tyuiu.GetsMA.Sprint1.Task6.V12.Test
{
    [TestClass]
    public sealed class TextServiceTest
    {
        [TestMethod]
        public void TestCheckLastWordRepetiton() 
        {
            TextService ts = new TextService();

            // ✅ ПРАВИЛЬНОЕ ИМЯ МЕТОДА ИЗ ИНТЕРФЕЙСА!
            Assert.IsTrue(ts.CheckLastWordRepetiton("Привет мир Привет"));
            Assert.IsFalse(ts.CheckLastWordRepetiton("Привет мир"));
            Assert.IsFalse(ts.CheckLastWordRepetiton(""));
            Assert.IsFalse(ts.CheckLastWordRepetiton("Привет"));
        }
    }
}
