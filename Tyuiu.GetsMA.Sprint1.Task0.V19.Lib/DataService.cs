using System;

namespace Tyuiu.GetsMA.Sprint1.Task1.V19.Lib
{
    public interface IDataService
    {
        double Calculate(double x, double y);
    }

    public class DataService : IDataService
    {
        public double Calculate(double x, double y)
        {
            if (x == 0 || y == 0)
                throw new ArgumentException("x и y не могут быть равны 0, чтобы избежать деления на ноль.");

            return (x + 10 * y) / (x * y);
        }
    }
}
