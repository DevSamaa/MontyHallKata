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

            for (int i = 1; i <= rounds; i++)
            {
                if (PlayARound())
                {
                    scoreBoard.KeepScore();
                }
                
            }
            Console.WriteLine(_changeStrategy.GetFinalScore(scoreBoard));
            
        }

        private bool PlayARound()
        {
            var randomNumber = new RandomNumber();
            var doorSelector = new DoorSelector();
            var winnerChecker = new WinnerChecker();

            var gameStage = new GameStage();
            var allDoors = gameStage.AllDoors;
                
            //set a winning door
            var num =randomNumber.Generate();
            doorSelector.ChangePropertyWinner(num,allDoors);
            
            //set the chosen (by user) door
            num =randomNumber.Generate();
            doorSelector.ChangePropertyChosen(num, allDoors);
            
            // determine which door to open (the computer)
            doorSelector.ChangePropertyOpen(allDoors);
                
            //apply change strategy
            _changeStrategy.ChangeSelection(allDoors, doorSelector);
            
            // winnerChecker.KeepScore(allDoors);  
            return winnerChecker.IsWinner(allDoors);

        }
    }
}



//figure out how to mock the randomNumber class