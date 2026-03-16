using System;
using Tyuiu.GetsMA.Sprint1.Task6.V12;
using Tyuiu.GetsMA.Sprint1.Task6.V12.Lib;

class Program
{
    static void Main()
    {
        TextService textService = new TextService();

        Console.WriteLine("Task6 v12 =====================================");
        Console.WriteLine("Введите текст:");
        string? text = Console.ReadLine();

        bool result = textService.CheckLastWordRepetiton(text!);
        Console.WriteLine($"Результат: {result}");

        Console.WriteLine("Нажмите любую клавишу для завершения...");
        Console.ReadKey();  // ← ЭТО РЕШАЕТ ПРОБЛЕМУ!
    }
}
