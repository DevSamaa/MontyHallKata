using System;

namespace MontyHallKata
{
    class Program
    {
        //TODO move keep and change strategy into their own class "gameshow"
        static void Main(string[] args)
        {
            KeepStrategy();
            ChangeStrategy();
        }

        public static void KeepStrategy()
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
            
                winnerChecker.KeepScore(allDoors);  
            }
            Console.WriteLine($"The score using the KeepStrategy is: {winnerChecker.GetScore()}");
        }
        
        public static void ChangeStrategy()
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
                doorSelector.ChangeStrategy(allDoors);
            
                winnerChecker.KeepScore(allDoors);  
            }
            Console.WriteLine($"The score using the ChangeStrategy is: {winnerChecker.GetScore()}");
        }
    }
}