using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GetsMA.Sprint1.Task1.V19.Lib
{
    public class DataService : ISprint1Task1V19
    {
        public double Calculate(double x, double y)
        {
            if (x == 0 || y == 0)
                throw new ArgumentException("x и y не должны быть равны 0");

            return (x + 10 * y) / (x * y);
        }
    }
}

