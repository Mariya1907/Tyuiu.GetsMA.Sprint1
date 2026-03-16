using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GetsMA.Sprint1.Task4.V14.Lib
{
    public class DataService : ISprint1Task4V14
    {
        public double Calculate(double x, double y) 
        {
            return Math.Pow(x, y);  // x^y
        }
    }
}
