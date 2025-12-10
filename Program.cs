using Tyuiu.GetsMA.Sprint1.Task2.V9.Lib;
using System;

var dataService = new DataService();

Console.Write("Введите радиус шара: ");
int radius = Convert.ToInt32(Console.ReadLine());

try
{
    double volume = dataService.CalculateSphereVolume(radius);
    Console.WriteLine($"Объём шара: {volume}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}
