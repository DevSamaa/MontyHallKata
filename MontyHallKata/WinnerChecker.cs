using System.Collections.Generic;
using System.Linq;

namespace MontyHallKata
{
    public class WinnerChecker
    {
        public bool IsWinner(List<Door> allDoors)
        {
            return allDoors.Any(door => door.Winner && door.Chosen);
        }
    }
}