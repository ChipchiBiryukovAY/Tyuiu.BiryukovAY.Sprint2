using System;
using Tyuiu.BiryukovAY.Sprint2.Task3.V10.Lib;
namespace Tyuiu.BiryukovAY.Sprint2.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        private const double Delta = 0.001;
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double result = ds.Calculate(2);

            Assert.IsFalse(double.IsNaN(result));
            Assert.IsFalse(double.IsInfinity(result));
        }
    }
}
