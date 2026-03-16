using System;
using Tyuiu.GetsMA.Sprint1.Task2.V9.Lib;

namespace Tyuiu.GetsMA.Sprint1.Task2.V9 
{
    class Program  // ← НЕ Class1!
    {
        static void Main(string[] args)  // ← static void Main!
        {
            DataService ds = new DataService();

            int a = 6, b = 4;
            int x = 30 / 6 + 4;
            a++;
            x += b += a;

            Console.WriteLine($"Результат: {x}");
            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();  // ✅ Замени ReadKey()
        }
    }
}

