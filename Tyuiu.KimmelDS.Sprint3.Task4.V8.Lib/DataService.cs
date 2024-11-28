using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KimmelDS.Sprint3.Task4.V8.Lib
{
    public class DataService : ISprint3Task4V8
    {
        public double Calculate(int startValue, int stopValue)
        {
            double result = 1; 

            for (double x = startValue; x <= stopValue; x++) 
            {
                try
                {
                    if (x == 0)
                    {
                        break; 
                    }
                    double y = (x / Math.Sin(x)) + 0.5;
                    result *= y;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine($"Ошибка: Деление на ноль при x = {x}");
                }
            }
            return Math.Round(result, 3); 
        }
    }
}
