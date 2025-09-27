using System;
using Tyuiu.BiryukovAY.Sprint2.Task0.V26.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        bool[] results = ds.GetCompareOperations(1045, 975);

        Console.WriteLine("Результат операций сравнения:");
        foreach (bool result in results)
        {
            Console.WriteLine(result);
        }
    }
}