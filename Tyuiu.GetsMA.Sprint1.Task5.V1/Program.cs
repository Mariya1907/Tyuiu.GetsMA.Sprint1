using System;
using Tyuiu.GetsMA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.GetsMA.Sprint1.Task5.V1  // ✅ Правильный namespace!
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Class Math                                                        *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет расстояние между двумя точками    *");
            Console.WriteLine("***************************************************************************");

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

            int distance = ds.DistanceBetweenPoints(x1, y1, x2, y2);

            Console.WriteLine("\n***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Расстояние между точками: {distance}");

            Console.WriteLine("\nНажмите Enter для выхода...");
            Console.ReadLine();  // ✅ ReadLine() вместо ReadKey()
        }
    }
}
