using System;
using Tyuiu.BiryukovAY.Sprint2.Task5.V15.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Write("Введите номер дня (1-365): ");
        int k = int.Parse(Console.ReadLine());

        string result = ds.FindDayName(k);
        Console.WriteLine($"Это {result}");
    }
}