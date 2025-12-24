namespace Tyuiu.GetsMA.Sprint1.Task7.V19.Lib
{
    public class DataService : ISprint1Task7V19
    {
        public double Calculate(double x)
        {
            double z = x - 7.0 / x
                       + Math.Sin(x)
                       + Math.Abs(Math.Pow(x, 4) - Math.Pow(x, 5));

            return Math.Round(z, 3);
        }
    }
}
