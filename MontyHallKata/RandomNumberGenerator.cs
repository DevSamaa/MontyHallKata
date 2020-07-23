using System;

namespace MontyHallKata
{
    public class RandomNumberGenerator :IRandomNumberGenerator
    {
        public int MinValue;
        public int MaxValue;
        
        public RandomNumberGenerator()
        {
            MinValue = 1;
            MaxValue = 4;
        }
        
        public RandomNumberGenerator(int incomingMin, int incomingMax)
        {
            MinValue = incomingMin;
            MaxValue = incomingMax;
        }

        public int Generate()
        {
            var random = new Random();
            return random.Next(MinValue,MaxValue);
        }
    }
}