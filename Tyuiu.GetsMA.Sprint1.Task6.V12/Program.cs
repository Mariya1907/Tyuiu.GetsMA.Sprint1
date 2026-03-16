using System;
using Tyuiu.GetsMA.Sprint1.Task6.V12;
using Tyuiu.GetsMA.Sprint1.Task6.V12.Lib;

class Program
{
    static void Main()
    {
        TextService textService = new TextService();
        Console.WriteLine("Введите текст:");
        string? text = Console.ReadLine();

        // ✅ ПРАВИЛЬНОЕ ИМЯ МЕТОДА!
        bool result = textService.CheckLastWordRepetiton(text!);

        Console.WriteLine($"Результат: {result}");
    }
}
