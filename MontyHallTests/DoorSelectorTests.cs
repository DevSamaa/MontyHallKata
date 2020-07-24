using System.Linq;
using MontyHallKata;
using NSubstitute;
using Xunit;

namespace MontyHallTests
{
    public class DoorSelectorTests
    {
        [Fact]
        public void ShouldChangeDoorWinnerToTrue()
        {
            var gameStage = new GameStage();
            var mockRandomNumber = Substitute.For<IRandomNumberGenerator>();
            mockRandomNumber.Generate().Returns(3);
            var doorSelector = new DoorSelector(mockRandomNumber);
            
            //pick a door, check that it's winner = false
            var thirdDoor = gameStage.AllDoors.Find(door => door.Number == 3);
            
            Assert.False(thirdDoor.Winner);
            
            //run the method
            doorSelector.SetWinningDoor(gameStage.AllDoors);

            //winner should now be true
            Assert.True(thirdDoor.Winner);
        }
        
        [Fact]
        public void ShouldChangeDoorChosenToTrue()
        {
            var gameStage = new GameStage();
            var mockRandomNumber = Substitute.For<IRandomNumberGenerator>();
            mockRandomNumber.Generate().Returns(3);
            var doorSelector = new DoorSelector(mockRandomNumber);
            
            //pick a door, check that it's winner = false
            var thirdDoor = gameStage.AllDoors.Find(door => door.Number == 3);
            
            Assert.False(thirdDoor.Chosen);
            
            //run the method
            doorSelector.SetChosenDoor(gameStage.AllDoors);

            //winner should now be true
            Assert.True(thirdDoor.Chosen);
        }

        [Fact]
        public void ShouldOpen3rdDoor()
        {
            var gameStage = new GameStage();
            var mockRandomNumber = Substitute.For<IRandomNumberGenerator>();
            mockRandomNumber.Generate(0,2).Returns(1);
            var doorSelector = new DoorSelector(mockRandomNumber);

            gameStage.AllDoors[0].Winner = true;
            gameStage.AllDoors[0].Chosen = true;
            
            doorSelector.SetOpenDoor(gameStage.AllDoors);
          
            Assert.True(gameStage.AllDoors[2].Open); //third door should be open
            Assert.False(gameStage.AllDoors[0].Open); //checking that winnning/chosen door should not be open
        }

        
    }
}

