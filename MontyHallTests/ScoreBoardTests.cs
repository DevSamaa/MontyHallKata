using System.Collections.Generic;
using System.Linq;
using MontyHallKata;
using Xunit;

namespace MontyHallTests
{
    public class ScoreBoardTests
    {
        [Fact]
        public void IncrementScoreShouldWork()
        {
            var scoreBoard = new ScoreBoard();
            var initialScore = scoreBoard.Score;
            scoreBoard.IncrementScore();
            var newScore = scoreBoard.Score;
            
            Assert.Equal(1, newScore);
           
        }
    }
}

