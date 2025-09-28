using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BiryukovAY.Sprint2.Task7.V13.Lib
{
    public class DataService : ISprint2Task7V13
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool insideCircle = (x * x + y * y) <= 1;
            bool belowLineY1 = y <= 1;
            bool aboveLineYEqualsXMinus1 = y >= (x - 1);

            return insideCircle && belowLineY1 && aboveLineYEqualsXMinus1;
        }
    }
}
 