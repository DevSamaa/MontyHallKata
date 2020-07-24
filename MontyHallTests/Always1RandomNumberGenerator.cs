using MontyHallKata;

namespace MontyHallTests
{
    public class Always1RandomNumberGenerator :IRandomNumberGenerator 
    {
        public int Generate()
        {
            return 1;
        }

        public int Generate(int minValue, int maxValue)
        {
            return 1;
        }
    }
}