using System;
using Tyuiu.GetsMA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.GetsMA.Sprint1.Task5.V1.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты первой точки:");
            Console.Write("x1 = ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты второй точки:");
            Console.Write("x2 = ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();
            int distance = ds.DistanceBetweenPoints(x1, y1, x2, y2);

            Console.WriteLine($"Расстояние между точками: {distance}");
            Console.ReadKey();
        }
    }
}
