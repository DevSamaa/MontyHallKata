using MontyHallKata;
using Xunit;

namespace MontyHallTests
{
    public class WinnerCheckerTests
    {

        [Fact]
        public void WinningAndChosenDoorAreSameShouldReturnTrue()
        {
             var gameStage = new GameStage();
             var winnerChecker= new WinnerChecker();
             
             var alldoors = gameStage.AllDoors;
            alldoors[1].Winner = true;
            alldoors[1].Chosen = true;
            var result =winnerChecker.IsWinner(alldoors);

            Assert.True(result);

        }
        
        [Fact]
        public void WinningAndChosenDoorAreDifferentShouldReturnFalse()
        {
            var gameStage = new GameStage();
            var winnerChecker= new WinnerChecker();
             
            var alldoors = gameStage.AllDoors;
            alldoors[1].Winner = true;
            alldoors[2].Chosen = true;
            var result =winnerChecker.IsWinner(alldoors);

            Assert.False(result);

        }
    }
}