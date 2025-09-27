using System;
using Tyuiu.BiryukovAY.Sprint2.Task4.V17.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Write("Введите x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        try
        {
            double result = ds.Calculate(x, y);
            Console.WriteLine($"z = {result:F3}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}