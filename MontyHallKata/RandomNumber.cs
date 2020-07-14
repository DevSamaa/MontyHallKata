using System;

namespace MontyHallKata
{
    public class RandomNumber
    {
        public int MinValue;
        public int MaxValue;
        
        public RandomNumber()
        {
            MinValue = 1;
            MaxValue = 4;
        }
        
        public RandomNumber(int incomingMin, int incomingMax)
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