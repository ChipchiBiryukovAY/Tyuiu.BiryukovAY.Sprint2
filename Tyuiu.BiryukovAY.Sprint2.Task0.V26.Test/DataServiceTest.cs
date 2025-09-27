using Tyuiu.BiryukovAY.Sprint2.Task0.V26.Lib;
namespace Tyuiu.BiryukovAY.Sprint2.Task0.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetCompareOperations_WithX1045Y975_ReturnsCorrectSequence()
        {
            // Arrange
            DataService ds = new DataService();
            bool[] expected = { false, false, false, true, true, true };

            // Act
            bool[] result = ds.GetCompareOperations(1045, 975);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }
    }
}