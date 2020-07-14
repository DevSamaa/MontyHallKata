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
    }
}