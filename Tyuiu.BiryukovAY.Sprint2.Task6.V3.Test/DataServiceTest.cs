using System;
using Tyuiu.BiryukovAY.Sprint2.Task6.V3.Lib;
namespace Tyuiu.BiryukovAY.Sprint2.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Понедельник", ds.FindDayName(1));
        }
    }
}
