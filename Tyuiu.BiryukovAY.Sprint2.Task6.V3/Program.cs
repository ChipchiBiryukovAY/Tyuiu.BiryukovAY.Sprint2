using System;
using Tyuiu.BiryukovAY.Sprint2.Task6.V3.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Write("Введите номер дня недели (1-7): ");
        int day = int.Parse(Console.ReadLine());

        string result = ds.FindDayName(day);
        Console.WriteLine($"Это {result}");
    }
} 