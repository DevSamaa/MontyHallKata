using System.Collections.Generic;

namespace MontyHallKata
{
    public interface IChangeStrategy
    {
        public void ChangeSelection(List<Door> allDoors, DoorSelector doorSelector);
        
        public string GetFinalScore(ScoreBoard scoreBoard);
    }
}