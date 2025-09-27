using System;
using Tyuiu.BiryukovAY.Sprint2.Task3.V10.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Write("Введите x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        double result = ds.Calculate(x);
        Console.WriteLine($"y = {result:F3}");
    }
}