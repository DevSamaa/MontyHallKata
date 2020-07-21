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
        public void DoorsOneTwoAndThreeShouldExist()
        {
            var gameShow = new GameStage();
            var door1 = gameShow.AllDoors[0].Number;
            var door2 = gameShow.AllDoors[1].Number;
            var door3 = gameShow.AllDoors[2].Number;

            Assert.Equal(1, door1);
            Assert.Equal(2, door2);
            Assert.Equal(3, door3);
        }

        
        
        
    }
}