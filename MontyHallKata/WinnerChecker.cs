using System.Collections.Generic;
using System.Linq;

namespace MontyHallKata
{
    public class WinnerChecker
    {
        // TODO change this!! but watch out for the tests!
        // public int Score { get; private set;}

        private int Score { get; set;}

        public void KeepScore(List<Door> allDoors)
        {
            var isWinner = allDoors.Any(door => door.Winner && door.Chosen);

            if (isWinner)
            {
                Score++;
            }
        }

        public int GetScore() => Score;
    }
}