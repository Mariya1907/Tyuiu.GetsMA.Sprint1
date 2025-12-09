using Tyuiu.GetsMA.Sprint1.Task0.V29.Lib;

internal class Program
{
    static void Main()
    {
        ISprint1Task0V29 ds = new DataService();
        Console.WriteLine(ds.Calculate());
    }
}
