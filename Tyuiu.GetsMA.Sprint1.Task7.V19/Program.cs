using System;
using Tyuiu.GetsMA.Sprint1.Task7.V19;
using Tyuiu.GetsMA.Sprint1.Task7.V19.Lib;

class Program
{
    static void Main()
    {
        DataService ds = new DataService();
        Console.WriteLine("Task7 v19");
        Console.WriteLine("x = ");
        double x = double.Parse(Console.ReadLine()!);
        double y = ds.Calculate(x);
        Console.WriteLine($"y = {y}");
        Console.ReadKey();
    }
}

