using System;
using System.Linq;
using MontyHallKata;
using Xunit;

namespace MontyHallTests
{
    public class GameStageTests
    {
        [Fact]
        public void NewAllDoorsShouldContain3Doors()
        {
            //arrange
            //action
            var gameShow = new GameStage();
            var amountOfDoors = gameShow.AllDoors.Count();
            
            //assert
            Assert.Equal(3, amountOfDoors);
        }

        [Fact]
        public void ThirdDoorShouldBeNumber3()
        {
            var gameShow = new GameStage();
            var thirdDoor = gameShow.AllDoors[2].Number;

            Assert.Equal(3, thirdDoor);
        }

        
        
        
    }
}