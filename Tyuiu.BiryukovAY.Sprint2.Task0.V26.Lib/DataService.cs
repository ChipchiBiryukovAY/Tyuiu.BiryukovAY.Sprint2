using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BiryukovAY.Sprint2.Task0.V26.Lib
{
    public class DataService : ISprint2Task0V26
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[6];

            result[0] = x == y; 
            result[1] = x != x;   
            result[2] = x < y;  
            result[3] = x > y;    
            result[4] = x <= x;    
            result[5] = x >= x;     

            return result;
        }
    }
}