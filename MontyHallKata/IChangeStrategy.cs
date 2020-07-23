using System.Collections.Generic;

namespace MontyHallKata
{
    public interface IChangeStrategy
    {
        public void ChangeSelection(List<Door> allDoors);
        
        public string GetFinalScore(ScoreBoard scoreBoard);
    }
}