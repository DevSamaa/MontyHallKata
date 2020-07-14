using System.Collections.Generic;
using System.Linq;
using MontyHallKata;
using Xunit;

namespace MontyHallTests
{
    public class RandomNumberTests
    {

        [Fact]
        public void GeneratorShouldReturnNumberBetween1And3()
        {
            var randomNumber = new RandomNumber();
            var result = randomNumber.Generate();
            
            Assert.True(result >0 && result <4);
        }

        [Fact]
        public void AllNumbersFrom1To3ShouldBeGenerated()
        {
            var listOfNumbers = new List<int>();
            
            var randomNumber = new RandomNumber();

            for (int i = 0; i < 100; i++)
            {
                listOfNumbers.Add(randomNumber.Generate());
            }
            
            Assert.Contains(1, listOfNumbers);
            Assert.Contains(2, listOfNumbers);
            Assert.Contains(3, listOfNumbers);

        }
    }
}