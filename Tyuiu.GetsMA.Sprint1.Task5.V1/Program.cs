using System;
using Tyuiu.GetsMA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.GetsMA.Sprint1.Task5.V1 

{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
            Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x1, x2, y1, y2;
            Console.WriteLine("Введите значение x1:");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y1:");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение x2:");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y2:");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.DistanceBetweenDots(x1, y1, x2, y2));
        }
    }
}

