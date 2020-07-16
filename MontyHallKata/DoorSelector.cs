using System.Collections.Generic;
using System.Linq;

namespace MontyHallKata
{
    public class DoorSelector
    {
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

        public void ChangePropertyOpen(List<Door> allDoors)
        {
           var eligibleDoors= allDoors.Where(door => door.Winner == false && door.Chosen == false).ToList();
           
           if (eligibleDoors.Count() == 1)
           {
               eligibleDoors[0].Open = true;
           }

           if (eligibleDoors.Count() > 1)
           {
               var randomNumber = new RandomNumber(1,3).Generate();
               eligibleDoors[randomNumber - 1].Open = true;
           }
        }

      
    }
}