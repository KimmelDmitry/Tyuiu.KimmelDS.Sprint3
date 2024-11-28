using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KimmelDS.Sprint3.Task3.V2.Lib
{
    public class DataService : ISprint3Task3V2
    {
        public int GetMaxCharCount(string value, char item)
        {
            int count = 0;
            int max = 0;
            var before = new char();
            foreach (char c in value)
            {
                if (c != before) count = 0;
                if (c == item)
                {
                    count++;
                    before = c;
                    max = max < count ? count : max;
                }
            }
            return max;
        }
    }
}
