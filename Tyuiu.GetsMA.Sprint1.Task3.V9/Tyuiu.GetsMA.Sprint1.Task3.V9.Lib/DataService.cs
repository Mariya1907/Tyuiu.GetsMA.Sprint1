using System;

namespace Tyuiu.GetsMA.Sprint1.Task3.V9.Lib
{
    public interface IDataService
    {
        double CalculateSphereVolume(int radius);
    }

    public class DataService : IDataService
    {
        public double CalculateSphereVolume(int radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть больше 0");

            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
            return Math.Round(volume, 3);
        }
    }
}
