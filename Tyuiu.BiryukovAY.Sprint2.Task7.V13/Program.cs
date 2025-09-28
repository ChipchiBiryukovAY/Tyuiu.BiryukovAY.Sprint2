using System;
using Tyuiu.BiryukovAY.Sprint2.Task7.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Write("Введите X: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите Y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        bool result = ds.CheckDotInShadedArea(x, y);
        Console.WriteLine($"Результат: {result}");
    }
} 