using System;
using Tyuiu.BiryukovAY.Sprint2.Task5.V15.Lib;
namespace Tyuiu.BiryukovAY.Sprint2.Task5.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual("понедельник", ds.FindDayName(1));
        }
    }
}
