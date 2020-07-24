using System.Collections.Generic;

namespace MontyHallKata
{
    public class ChangeStrategy : IChangeStrategy
    {
        public void ChangeSelection(List<Door> allDoors)
        {
                var oldDoor = allDoors.Find(door => door.Chosen);
                var newDoor = allDoors.Find(door => door.Open == false && door.Chosen == false);
                newDoor.Chosen = true;
                oldDoor.Chosen = false;
        }

        
        public  string GetFinalScore(ScoreBoard scoreBoard)
        {
            return $"The score using the ChangeStrategy is: {scoreBoard.Score}";
        }
    }
}

