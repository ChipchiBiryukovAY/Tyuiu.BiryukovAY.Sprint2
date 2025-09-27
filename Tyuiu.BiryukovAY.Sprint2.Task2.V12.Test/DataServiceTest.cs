using System;
using Tyuiu.BiryukovAY.Sprint2.Task2.V12.Lib;
namespace Tyuiu.BiryukovAY.Sprint2.Task2.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.IsTrue(ds.CheckDotInShadedArea(4, 5));
        }
    }
}
