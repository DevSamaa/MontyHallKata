using MontyHallKata;
using Xunit;

namespace MontyHallTests
{
    public class DoorSelectorTests
    {
        [Fact]
        public void ShouldChangeDoorWinnerToTrue()
        {
            var gameStage = new GameStage();
            var doorSelector = new DoorSelector();
            
            //pick a door, check that it's winner = false
            var thirdDoor = gameStage.AllDoors.Find(door => door.Number == 3);
            
            Assert.False(thirdDoor.Winner);
            
            //run the method
            doorSelector.ChangePropertyWinner(3,gameStage.AllDoors);

            //winner should now be true
            Assert.True(thirdDoor.Winner);
        }
        
        [Fact]
        public void ShouldChangeDoorChosenToTrue()
        {
            var gameStage = new GameStage();
            var doorSelector = new DoorSelector();
            
            //pick a door, check that it's winner = false
            var thirdDoor = gameStage.AllDoors.Find(door => door.Number == 3);
            
            Assert.False(thirdDoor.Chosen);
            
            //run the method
            doorSelector.ChangePropertyChosen(3,gameStage.AllDoors);

            //winner should now be true
            Assert.True(thirdDoor.Chosen);
        }

        [Fact]
        public void ShouldOpenADoorOtherThan0()
        {
            var gameStage = new GameStage();
            var doorSelector = new DoorSelector();

            gameStage.AllDoors[0].Winner = true;
            gameStage.AllDoors[0].Chosen = true;
            
            doorSelector.ChangePropertyOpen(gameStage.AllDoors);
            
            Assert.True(gameStage.AllDoors[1].Open == true || gameStage.AllDoors[2].Open==true);
            Assert.True(gameStage.AllDoors[1].Open != gameStage.AllDoors[2].Open);
            Assert.False(gameStage.AllDoors[0].Open);
        }

        [Fact]
        public void ShouldChoseDoor3()
        {
            var gameStage = new GameStage();
            var doorSelector = new DoorSelector();
            
            gameStage.AllDoors[0].Chosen = true;
            gameStage.AllDoors[1].Open = true;

            doorSelector.ChangeStrategy(gameStage.AllDoors);
            
            Assert.True(gameStage.AllDoors[2].Chosen);
            Assert.False(gameStage.AllDoors[0].Chosen);
        }
    }
}

