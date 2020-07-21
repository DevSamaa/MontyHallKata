using MontyHallKata;

namespace MontyHallTests
{
    public class Always1RandomNumber :IRandomNumber 
    {
        public int Generate()
        {
            return 1;
        }
    }
}