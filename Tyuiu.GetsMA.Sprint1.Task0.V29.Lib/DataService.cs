namespace Tyuiu.GetsMA.Sprint1.Task0.V29.Lib
{
    public interface ISprint1Task0V29
    {
        double Calculate();
    }


    public class DataService : ISprint1Task0V29
    {
        public double Calculate()
        {
            return 2 * 9 + 7 * 2;
        }
    }
}