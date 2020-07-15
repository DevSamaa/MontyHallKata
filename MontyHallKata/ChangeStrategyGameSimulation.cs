using System.Collections.Generic;

namespace MontyHallKata
{
    public class ChangeStrategyGameSimulation : GameSimulation
    {
        public override void ChangeStrategy(List<Door> allDoors, DoorSelector doorSelector)
        {
            doorSelector.ChangeStrategy(allDoors);
        }

        public override string GetFinalScore(WinnerChecker winnerChecker)
        {
            return $"The score using the ChangeStrategy is: {winnerChecker.GetScore()}";
        }
    }
}