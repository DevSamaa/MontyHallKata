using System;
using System.Linq;
using MontyHallKata;
using Xunit;

namespace MontyHallTests
{
    public class GameShowTests
    {
        [Fact]
        public void NewAllDoorsShouldContain3Doors()
        {
            //arrange
            //action
            var gameShow = new GameShow();
            var amountOfDoors = gameShow.AllDoors.Count();
            
            //assert
            Assert.Equal(3, amountOfDoors);
        }

        [Fact]
        public void ThirdDoorShouldBeNumber3()
        {
            var gameShow = new GameShow();
            var thirdDoor = gameShow.AllDoors[2].Number;

            Assert.Equal(3, thirdDoor);
        }
        
        
    }
}