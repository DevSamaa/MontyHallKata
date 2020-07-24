using System.Collections.Generic;

namespace MontyHallKata
{
    public class KeepStrategy : IChangeStrategy
    {
        public void ChangeSelection(List<Door> allDoors)
        {
            
        }

        public string GetFinalScore(ScoreBoard scoreBoard)
        {
            return $"The score using the KeepStrategy is: {scoreBoard.Score}";
        }
    }
}