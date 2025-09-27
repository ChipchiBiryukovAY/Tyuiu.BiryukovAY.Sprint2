using System;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BiryukovAY.Sprint2.Task4.V17.Lib
{
    public class DataService : ISprint2Task4V17
    {
        public double Calculate(double x, double y)
        {
            if (x == 0)
            {
                throw new ArgumentException("x не может быть равен 0 (деление на ноль)");
            }

            double z = (x - 22 > Math.Sqrt(y))
                ? Math.Pow(6 + 2 / x, y)
                : y + 12 / (x * x);

            return Math.Round(z, 3);
        }
    }
}
