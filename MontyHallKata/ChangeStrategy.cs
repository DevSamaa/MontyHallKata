using System.Collections.Generic;

namespace MontyHallKata
{
    public class ChangeStrategy : IChangeStrategy
    {
        public void ChangeSelection(List<Door> allDoors, DoorSelector doorSelector)
        {
                var oldDoor = allDoors.Find(door => door.Chosen);
                var newDoor = allDoors.Find(door => door.Open == false && door.Chosen == false);
                newDoor.Chosen = true;
                oldDoor.Chosen = false;
        }

        
        public  string GetFinalScore(WinnerChecker winnerChecker)
        {
            return $"The score using the ChangeStrategy is: {winnerChecker.GetScore()}";
        }
    }
}