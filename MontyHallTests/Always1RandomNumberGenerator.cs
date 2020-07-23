using MontyHallKata;

namespace MontyHallTests
{
    public class Always1RandomNumberGenerator :IRandomNumberGenerator 
    {
        public int Generate()
        {
            return 1;
        }
    }
}