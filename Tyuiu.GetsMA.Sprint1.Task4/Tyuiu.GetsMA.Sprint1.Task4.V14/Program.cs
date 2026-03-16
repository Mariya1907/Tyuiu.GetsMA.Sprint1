using Tyuiu.GetsMA.Sprint1.Task4.V14.Lib;

Console.Write("x = ");
string inputX = Console.ReadLine();
if (string.IsNullOrEmpty(inputX))
{
    Console.WriteLine("ќшибка! ¬ведите число.");
    return;
}
double x = double.Parse(inputX);

Console.Write("y = ");
string inputY = Console.ReadLine();
if (string.IsNullOrEmpty(inputY))
{
    Console.WriteLine("ќшибка! ¬ведите число.");
    return;
}
double y = double.Parse(inputY);

DataService ds = new DataService();
Console.WriteLine($"x^y = {ds.Calculate(x, y):F2}");
