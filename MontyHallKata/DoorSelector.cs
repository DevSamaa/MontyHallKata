using System.Collections.Generic;

namespace MontyHallKata
{
    public class DoorSelector
    {
        //doorNumber comes from the RandomNumber.Generate()
        public void ChangePropertyWinner(int randomNumber, List<Door> allDoors)
        {
            var currentDoor =allDoors.Find(door => door.Number == randomNumber);
            
            currentDoor.Winner = true;
        }
        
        public void ChangePropertyChosen(int randomNumber, List<Door> allDoors)
        {
            var currentDoor =allDoors.Find(door => door.Number == randomNumber);
            
            currentDoor.Chosen = true;
        }
    }
}