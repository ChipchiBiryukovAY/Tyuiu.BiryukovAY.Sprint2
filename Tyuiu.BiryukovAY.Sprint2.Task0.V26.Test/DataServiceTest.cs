using System;
using Tyuiu.BiryukovAY.Sprint2.Task0.V26.Lib;
namespace Tyuiu.BiryukovAY.Sprint2.Task0.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetCompareOperations_ReturnsCorrectArray()
        {
            DataService ds = new DataService();
            bool[] result = ds.GetCompareOperations(1045, 975);
            bool[] expected = { false, false, false, true, true, true };

            CollectionAssert.AreEqual(expected, result);
        }
    }
}