using System;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BiryukovAY.Sprint2.Task3.V10.Lib
{
    public class DataService : ISprint2Task3V10
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 0)
            {
                if (x == 4)
                {
                    throw new ArgumentException("Функция не определена при x = 4 (деление на ноль)");
                }
                double baseValue = (x + 15) / (x - 4);
                y = x - Math.Pow(baseValue, x);
            }
            else if (x == 0)
            {
                double xSquared = x * x;
                double numerator = xSquared + Math.Cos(xSquared) - 3;
                double denominator = xSquared - Math.Sin(xSquared) + 2;
                y = numerator / denominator;
            }
            else if (x > -14)
            {
                double xSquared = x * x;
                double baseValue = 5 + 1 / xSquared;
                y = Math.Pow(baseValue, x);
            }
            else
            {
                double term1 = x;
                double term2 = 10 * x;
                double baseValue = 1 / x;
                double term3 = Math.Pow(baseValue, x);
                y = term1 + term2 - term3;
            }

            return Math.Round(y, 3);
        }
    }
}