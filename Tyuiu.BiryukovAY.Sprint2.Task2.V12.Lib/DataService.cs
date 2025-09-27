using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BiryukovAY.Sprint2.Task2.V12.Lib
{
    public class DataService : ISprint2Task2V12
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (x >= 3 && x <= 5 && y >= 3 && y <= 7)
                return true;

            if (x >= 6 && x <= 12 && y >= 5 && y <= 8)
                return true;

            if (x >= 9 && x <= 12 && y >= 3 && y <= 4)
                return true;

            if (x == 13 && y >= 6 && y <= 8)
                return true;

            if (x >= 6 && x <= 7 && y >= 9 && y <= 11)
                return true;

            if (x >= 3 && x <= 5 && y == 11)
                return true;

            if (x == 7 && y == 12)
                return true;

            if (x >= 11 && x <= 12 && y >= 9 && y <= 12)
                return true;

            return false;
        }
    }
}
