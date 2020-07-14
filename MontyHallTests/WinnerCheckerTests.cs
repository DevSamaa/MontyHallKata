using System.Collections.Generic;
using System.Linq;
using MontyHallKata;
using Xunit;

namespace MontyHallTests
{
    public class WinnerCheckerTests
    {

        [Fact]
        public void ShouldIncreaseScore()
        {
            var gameStage = new GameStage();
            gameStage.AllDoors[1].Winner = true;
            gameStage.AllDoors[1].Chosen = true;

           var winnerChecker= new WinnerChecker();
           var oldScore = winnerChecker.GetScore();
           winnerChecker.KeepScore(gameStage.AllDoors);
           var newScore =winnerChecker.GetScore();
           
           Assert.True(oldScore == 0);
           Assert.True(newScore == 1);
        }
    }
}