using System;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BiryukovAY.Sprint2.Task1.V19.Lib
{
    public class DataService : ISprint2Task1V19
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] results = new bool[6];

            results[0] = (a > b) && (c < d);

            results[1] = (a == b) || (c > d);

            results[2] = (a != b) ^ (b > c);

            results[3] = (a < b) & (c < d);

            results[4] = !(a == c);

            results[5] = (a >= d) | (b >= c);

            return results;
        }
    }
}
