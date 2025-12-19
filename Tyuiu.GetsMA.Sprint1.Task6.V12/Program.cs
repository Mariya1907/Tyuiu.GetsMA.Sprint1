using System;
using Tyuiu.GetsMA.Sprint1.Task6.V12.Lib;

namespace Tyuiu.GetsMA.Sprint1.Task6.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            TextService ts = new TextService();
            bool result = ts.IsLastWordRepeated(text);

            if (result)
                Console.WriteLine("Последнее слово встречается в строке еще раз.");
            else
                Console.WriteLine("Последнее слово НЕ встречается в строке еще раз.");

            Console.ReadKey();
        }
    }
}
