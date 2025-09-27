using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BiryukovAY.Sprint2.Task0.V26.Lib
{
    public class DataService : ISprint2Task0V26
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            int difference = x - y; 

            bool[] results = new bool[6];

            results[0] = x == y + 69; 

            results[1] = x != y + 70; 

            results[2] = x < y + 70; 

            results[3] = x > y + 69; 

            results[4] = x <= y + 70; 

            results[5] = x >= y + 70; 

            return results;
        }
    }
}