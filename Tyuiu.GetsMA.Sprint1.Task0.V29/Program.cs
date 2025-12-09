using System;
using Tyuiu.GetsMA.Sprint1.Task0.V29.Lib;


ISprint1Task0V29 service = new DataService();
int result = service.Calculate();
Console.WriteLine("Ответ: " + result);

namespace Tyuiu.GetsMA.Sprint1.Task0.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("* Спринт #1                          *");
            Console.WriteLine("* Тема: Алгоритмы                    *");
            Console.WriteLine("* Задание: Task0 Вариант 29          *");
            Console.WriteLine("*************************************");
            Console.WriteLine("* Условие: вычислить выражение       *");
            Console.WriteLine("* 2*9 + 7*2                           *");
            Console.WriteLine("*************************************");

            DataService ds = new DataService();
            int result = ds.Calculate();

            Console.WriteLine("Ответ: " + result);
        }
    }
}
