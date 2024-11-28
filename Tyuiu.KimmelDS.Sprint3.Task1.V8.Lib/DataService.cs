using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KimmelDS.Sprint3.Task1.V8.Lib
{
    public class DataService : ISprint3Task1V8
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double result = 0;
            for (int k = startValue; k <= stopValue; k++)
            {
                result += Math.Pow(1 / (Math.Cos(k) + Math.Pow(value, k)), k);
            }
            return value;
        }
    }
}
