using Tyuiu.GetsMA.Sprint1.Task1.V19.Lib;

var data = new DataService();

Console.Write("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите y: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Результат: {data.Calculate(x, y)}");
