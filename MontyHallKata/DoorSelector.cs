using System.Collections.Generic;
using System.Linq;

namespace MontyHallKata
{
    public class DoorSelector
    {

        private IRandomNumberGenerator _randomNumberGenerator;

        public DoorSelector(IRandomNumberGenerator randomNumberGenerator)
        {
            _randomNumberGenerator = randomNumberGenerator;
        }

        public void SetWinningDoor( List<Door> allDoors)
        {
            var randomNumber = _randomNumberGenerator.Generate();
            var currentDoor =allDoors.Find(door => door.Number == randomNumber);
            
            currentDoor.Winner = true;
        }
        
        public void SetChosenDoor(List<Door> allDoors)
        {
            var randomNumber = _randomNumberGenerator.Generate();
            var currentDoor =allDoors.Find(door => door.Number == randomNumber);
            
            currentDoor.Chosen = true;
        }

        public void SetOpenDoor(List<Door> allDoors)
        {
           var eligibleDoors= allDoors.Where(door => door.Winner == false && door.Chosen == false).ToList();
           
           if (eligibleDoors.Count() == 1)
           {
               eligibleDoors[0].Open = true;
           }

           if (eligibleDoors.Count() > 1)
           {
               var newNumber = _randomNumberGenerator.Generate(0,2); 
               eligibleDoors[newNumber].Open = true;
           }
        }

       //TODO see if you can do this witout eligible doors, but not a pressing issue.

      
    }
}