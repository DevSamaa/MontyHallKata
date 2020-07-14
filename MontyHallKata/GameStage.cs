using System.Collections.Generic;
using System.Linq;

namespace MontyHallKata
{
    public class GameStage
    {
        public List<Door> AllDoors;

        public GameStage()
        {
            AllDoors = new List<Door>();
            // 3 door objects numbered 1,2 and 3 are created
            for (int i = 0; i < 3; i++)
            {
                var newDoor = new Door(i+1);
                AllDoors.Add(newDoor);
            }
        }
        
       
    }
}