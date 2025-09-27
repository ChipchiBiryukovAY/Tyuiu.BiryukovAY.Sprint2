using System;
using Tyuiu.BiryukovAY.Sprint2.Task4.V17.Lib;
namespace Tyuiu.BiryukovAY.Sprint2.Task4.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        private const double Delta = 0.001;
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double result = ds.Calculate(30, 10);

            double expected = Math.Pow(6 + 2.0 / 30, 10);
            Assert.AreEqual(expected, result, Delta);
        }
    }
}
