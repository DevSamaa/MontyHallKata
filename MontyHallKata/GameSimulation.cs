using System;
using System.Collections.Generic;

namespace MontyHallKata
{
    public abstract class GameSimulation
    {
        public abstract void ChangeStrategy(List<Door> allDoors);

        public abstract string GetFinalScore(WinnerChecker winnerChecker);
        
        public void Run()
        {
            var randomNumber = new RandomNumber();
            var doorSelector = new DoorSelector();
            var winnerChecker = new WinnerChecker();

            for (int i = 1; i <= 1000; i++)
            {
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
                ChangeStrategy(allDoors);
                
                winnerChecker.KeepScore(allDoors);  
            }
            Console.WriteLine(GetFinalScore(winnerChecker));
        }
    }
}

