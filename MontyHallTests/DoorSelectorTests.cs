using MontyHallKata;
using Xunit;

namespace MontyHallTests
{
    public class DoorSelectorTests
    {
        [Fact]
        public void ShouldChangeDoorWinnerToTrue()
        {
            var gameShow = new GameStage();
            var doorSelector = new DoorSelector();
            
            //pick a door, check that it's winner = false
            var thirdDoor = gameShow.AllDoors.Find(door => door.Number == 3);
            
            Assert.False(thirdDoor.Winner);
            
            //run the method
            doorSelector.ChangePropertyWinner(3,gameShow.AllDoors);

            //winner should now be true
            Assert.True(thirdDoor.Winner);
        }
        
        [Fact]
        public void ShouldChangeDoorChosenToTrue()
        {
            var gameShow = new GameStage();
            var doorSelector = new DoorSelector();
            
            //pick a door, check that it's winner = false
            var thirdDoor = gameShow.AllDoors.Find(door => door.Number == 3);
            
            Assert.False(thirdDoor.Chosen);
            
            //run the method
            doorSelector.ChangePropertyChosen(3,gameShow.AllDoors);

            //winner should now be true
            Assert.True(thirdDoor.Chosen);
        }

        [Fact]
        public void ShouldOpenADoorOtherThan0()
        {
            var gameShow = new GameStage();
            var doorSelector = new DoorSelector();

            gameShow.AllDoors[0].Winner = true;
            gameShow.AllDoors[0].Chosen = true;
            
            doorSelector.ChangePropertyOpen(gameShow.AllDoors);
            
            Assert.True(gameShow.AllDoors[1].Open == true || gameShow.AllDoors[2].Open==true);
            Assert.True(gameShow.AllDoors[1].Open != gameShow.AllDoors[2].Open);
            Assert.False(gameShow.AllDoors[0].Open);
        }

        [Fact]
        public void ShouldChoseDoor3()
        {
            var gameShow = new GameStage();
            var doorSelector = new DoorSelector();
            
            gameShow.AllDoors[0].Chosen = true;
            gameShow.AllDoors[1].Open = true;

            doorSelector.ChangeStrategy(gameShow.AllDoors);
            
            Assert.True(gameShow.AllDoors[2].Chosen);
            Assert.False(gameShow.AllDoors[0].Chosen);
        }
    }
}

