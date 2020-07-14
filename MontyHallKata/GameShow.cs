using System.Collections.Generic;

namespace MontyHallKata
{
    public class GameShow
    {
        public List<Door> AllDoors;

        public GameShow()
        {
            AllDoors = new List<Door>();
            // 3 door objects numbered 1,2 and 3
            for (int i = 0; i < 3; i++)
            {
                var newDoor = new Door(i+1);
                AllDoors.Add(newDoor);
            }
            
        }
    }
}