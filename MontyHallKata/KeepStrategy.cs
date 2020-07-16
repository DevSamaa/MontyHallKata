using System.Collections.Generic;

namespace MontyHallKata
{
    public class KeepStrategy : IChangeStrategy
    {
        public void ChangeSelection(List<Door> allDoors, DoorSelector doorSelector)
        {
            
        }

        public string GetFinalScore(WinnerChecker winnerChecker)
        {
            return $"The score using the KeepStrategy is: {winnerChecker.GetScore()}";
        }
    }
}