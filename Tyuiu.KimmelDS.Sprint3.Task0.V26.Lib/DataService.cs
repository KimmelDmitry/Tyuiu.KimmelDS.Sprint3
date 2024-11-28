using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KimmelDS.Sprint3.Task0.V26.Lib
{
    public class DataService : ISprint3Task0V26
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double product = 1.0;

            for (int k = 1; k <= 9; k++)
            {
                product *= Math.Pow(2, k) / (k + 1);
            }

            double angleInRadians = 1.8 * (Math.PI / 180);
            product *= Math.Cos(angleInRadians);

            return product;
        }
    }
}
