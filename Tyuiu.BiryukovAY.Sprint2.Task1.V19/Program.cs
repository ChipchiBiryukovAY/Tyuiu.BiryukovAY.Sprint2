using System;
using Tyuiu.BiryukovAY.Sprint2.Task1.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        bool[] results = ds.GetLogicOperations(696, 354, 423, 957);

        Console.WriteLine("Результаты логических операций:");
        foreach (bool result in results)
        {
            Console.WriteLine(result);
        }
    }
}