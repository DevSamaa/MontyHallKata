using System.Collections.Generic;
using System.Linq;

namespace MontyHallKata
{
    public class WinnerChecker
    {
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