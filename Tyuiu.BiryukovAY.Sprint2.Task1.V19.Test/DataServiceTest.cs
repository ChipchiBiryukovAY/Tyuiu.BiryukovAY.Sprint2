using System;
using Tyuiu.BiryukovAY.Sprint2.Task1.V19.Lib;
namespace Tyuiu.BiryukovAY.Sprint2.Task1.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            bool[] result = ds.GetLogicOperations(696, 354, 423, 957);

            Assert.IsTrue(result[0]);
        }
    }
}
