using System;
using Tyuiu.BiryukovAY.Sprint2.Task2.V12.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Write("Введите X: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Введите Y: ");
        int y = int.Parse(Console.ReadLine());

        bool result = ds.CheckDotInShadedArea(x, y);
        Console.WriteLine($"Результат: {result}");
    }
}