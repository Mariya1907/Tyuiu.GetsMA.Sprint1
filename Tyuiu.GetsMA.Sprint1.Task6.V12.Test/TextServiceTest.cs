using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GetsMA.Sprint1.Task6.V12.Lib;

namespace Tyuiu.GetsMA.Sprint1.Task6.V12.Test
{
    [TestClass]
    public sealed class TextServiceTest
    {
        [TestMethod]
        public void TestIsLastWordRepeated()
        {
            TextService ts = new TextService();

            Assert.IsTrue(ts.IsLastWordRepeated("Привет мир Привет"));
            Assert.IsFalse(ts.IsLastWordRepeated("Привет мир"));
            Assert.IsFalse(ts.IsLastWordRepeated(""));
            Assert.IsFalse(ts.IsLastWordRepeated("Привет"));
        }
    }
}
