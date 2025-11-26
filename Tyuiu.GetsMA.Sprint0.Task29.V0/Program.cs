using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GetsMA.Sprint0.Task29.V0.Lib;

namespace Tyuiu.GetsMA.Sprint0.Task29.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("* Спринт #0                          *");
            Console.WriteLine("* Тема: Организация структуры проекта*");
            Console.WriteLine("* Задание Task29                     *");
            Console.WriteLine("*************************************");
            Console.WriteLine("* Условие: вычислить выражение      *");
            Console.WriteLine("* 2*9 + 7*2                          *");
            Console.WriteLine("*************************************");

            DataService ds = new DataService();
            int result = ds.Calculate();

            Console.WriteLine("Ответ: " + result);
            Console.ReadKey();
        }
    }
}
