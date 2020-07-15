using System.Collections.Generic;

namespace MontyHallKata
{
    public class KeepStrategyGameSimulation :GameSimulation
    {
        public override void ChangeStrategy(List<Door> allDoors, DoorSelector doorSelector)
        {
            
        }

        public override string GetFinalScore(WinnerChecker winnerChecker)
        {
            return $"The score using the KeepStrategy is: {winnerChecker.GetScore()}";
        }
    }
}