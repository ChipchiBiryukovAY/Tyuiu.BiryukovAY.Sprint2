using System;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BiryukovAY.Sprint2.Task5.V15.Lib
{
    public class DataService : ISprint2Task5V15
    {
        public string FindDayName(int k)
        {
            if(k < 1 || k > 365)
        {
                throw new ArgumentException("k должно быть в диапазоне от 1 до 365");
            }

            int dayOfWeek = (k - 1) % 7;
            string dayName;
            switch (dayOfWeek)
            {
                case 0:
                    dayName = "понедельник";
                    break;
                case 1:
                    dayName = "вторник";
                    break;
                case 2:
                    dayName = "среда";
                    break;
                case 3:
                    dayName = "четверг";
                    break;
                case 4:
                    dayName = "пятница";
                    break;
                case 5:
                    dayName = "суббота";
                    break;
                case 6:
                    dayName = "воскресенье";
                    break;
                default:
                    throw new InvalidOperationException("Некорректный день недели");
            }

            return dayName;
        }
    }
}
