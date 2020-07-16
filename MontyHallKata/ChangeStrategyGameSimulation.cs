using System.Collections.Generic;

namespace MontyHallKata
{
    public class ChangeStrategyGameSimulation : GameSimulation
    {
        public override void ChangeStrategy(List<Door> allDoors)
        {
            var oldDoor = allDoors.Find(door => door.Chosen);
            var newDoor = allDoors.Find(door => door.Open == false && door.Chosen == false);
            newDoor.Chosen = true;
            oldDoor.Chosen = false;
        }

        public override string GetFinalScore(WinnerChecker winnerChecker)
        {
            return $"The score using the ChangeStrategy is: {winnerChecker.GetScore()}";
        }
    }
}