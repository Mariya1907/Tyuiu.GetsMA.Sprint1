using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GetsMA.Sprint1.Task3.V19.Lib;

namespace Tyuiu.GetsMA.Sprint1.Task3.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1";
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                                  *");
            Console.WriteLine("* Тема: Операторы составного присвоения                                                                      *");
            Console.WriteLine("* Задание #3                                                                                                 *");
            Console.WriteLine("* Вариант #19                                                                                                *");
                                                                              
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Написать программу, которая печатает true или false в зависимости от того,                                 *");
            Console.WriteLine("* может ли шахматная фигура «Слон» с одного заданного поля шахматной доски перейти за один ход на другое.    *");
            Console.WriteLine("* Пользователь задаёт координаты двух ячеек шахматной доски(x1 и y1, x2 и y2, каждое в диапазоне от 1 до 8). *");
            Console.WriteLine("*                                                                                                            *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");

            double x1;
            Console.WriteLine("Введите координату Слона на оси  Ox =");
            x1 = Convert.ToDouble(Console.ReadLine());

            double y1;
            Console.WriteLine("Введите координату Слона на оси  Oy =");
            y1 = Convert.ToDouble(Console.ReadLine());

            double x2;
            Console.WriteLine("Введите координату поля, на которое должен за один ход перейти Cлон, на оси  Ox =");
            x2 = Convert.ToDouble(Console.ReadLine());

            double y2;
            Console.WriteLine("Введите координату поля, на которое должен за один ход перейти Cлон, на оси  Oy =");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");

            Console.WriteLine(ds.ElephCanMove(x1, x2, y1, y2));
            Console.ReadKey();
        }
    }
}