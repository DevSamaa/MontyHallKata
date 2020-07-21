using System;
using System.Collections.Generic;

namespace MontyHallKata
{
    public class GameSimulation
    {
        private IChangeStrategy _changeStrategy;
        public GameSimulation(IChangeStrategy changeStrategy)
        {
            _changeStrategy = changeStrategy;
        }
        
        public void Run(int rounds)
        {
            var scoreBoard = new ScoreBoard();
            var randomNumber = new RandomNumberGenerator();

            for (int i = 1; i <= rounds; i++)
            {
                if (PlayARound(randomNumber))
                {
                    scoreBoard.IncrementScore();
                }
                
            }
            Console.WriteLine(_changeStrategy.GetFinalScore(scoreBoard));
            
        }

        public bool PlayARound(IRandomNumberGenerator randomNumberGenerator)
        {
            var doorSelector = new DoorSelector(randomNumberGenerator);
            var winnerChecker = new WinnerChecker();

            var gameStage = new GameStage();
            var allDoors = gameStage.AllDoors;
                
            //set a winning door
            var num =randomNumberGenerator.Generate();
            doorSelector.SetWinningDoor(allDoors);
            
            //set the chosen (by user) door
            num =randomNumberGenerator.Generate();
            doorSelector.SetChosenDoor(num, allDoors);
            
            // determine which door to open (the computer)
            doorSelector.SetOpenDoor(allDoors);
                
            //apply change strategy
            _changeStrategy.ChangeSelection(allDoors, doorSelector);
            
            // winnerChecker.KeepScore(allDoors);  
            return winnerChecker.IsWinner(allDoors);

        }
    }
}
