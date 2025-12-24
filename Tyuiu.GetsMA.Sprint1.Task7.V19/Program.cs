using Tyuiu.GetsMA.Sprint1.Task7.V19.Lib;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Sprint1.Task7.V19";
        Console.WriteLine("Введите значение x:");

        double x = Convert.ToDouble(Console.ReadLine());

        DataService ds = new DataService();
        double result = ds.Calculate(x);

        Console.WriteLine("Результат = " + result);
        Console.ReadKey();
    }
}
