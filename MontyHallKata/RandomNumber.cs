using System;

namespace MontyHallKata
{
    public class RandomNumber
    {

        public int Generate()
        {
            var random = new Random();
            return random.Next(1,4);
        }
    }
}