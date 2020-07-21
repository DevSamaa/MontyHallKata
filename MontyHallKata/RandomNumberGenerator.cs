using System;

namespace MontyHallKata
{
    public class RandomNumberGenerator :IRandomNumberGenerator
    {
        public int Generate()
        {
           return Generate(1, 4);
        }

        public int Generate(int incomingMin, int incomingMax)
        {
            var random = new Random();
            return random.Next(incomingMin,incomingMax);
        }
    }
}