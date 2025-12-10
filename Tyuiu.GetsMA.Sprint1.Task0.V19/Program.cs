using System;
using Tyuiu.GetsMA.Sprint1.Task1.V19.Lib;

namespace Tyuiu.GetsMA.Sprint1.Task0.V19
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Программа вычисляет (x + 10*y)/(x*y)");

            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Введите y: ");
            double y = double.Parse(Console.ReadLine());

            IDataService dataService = new DataService();

            try
            {
                double result = dataService.Calculate(x, y);
                Console.WriteLine($"Результат: {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
