using System.Collections.Generic;
using System.Linq;
using MontyHallKata;
using Xunit;

namespace MontyHallTests
{
    public class ScoreBoardTests
    {
//TODO maybe make this into 2 seperate tests, one for winner checker and one for scoreboard
        [Fact]
        public void IfWinnerShouldIncreaseScore()
        {
            var gameStage = new GameStage();
            var scoreBoard = new ScoreBoard();
            var winnerChecker= new WinnerChecker();
            var alldoors = gameStage.AllDoors;
            alldoors[1].Winner = true;
            alldoors[1].Chosen = true;


           var oldScore = scoreBoard.Score;
          
           if (winnerChecker.IsWinner(alldoors))
           {
               scoreBoard.IncrementScore(); 
           }
          
           var newScore =scoreBoard.Score;
           
           Assert.True(oldScore == 0);
           Assert.True(newScore == 1);
        }
    }
}