using System;
using Tyuiu.BiryukovAY.Sprint2.Task7.V13.Lib;

namespace Tyuiu.BiryukovAY.Sprint2.Task7.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.IsTrue(ds.CheckDotInShadedArea(0, 0));
        }
    }
} 
 