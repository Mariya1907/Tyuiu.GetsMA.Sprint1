using Tyuiu.GetsMA.Sprint1.Task4.V14.Lib;

DataService ds = new DataService();

Console.Write("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите y: ");
double y = Convert.ToDouble(Console.ReadLine());

double result = ds.Calculate(x, y);
Console.WriteLine($"Результат: {result}");
