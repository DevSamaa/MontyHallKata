using System;

namespace MontyHallKata
{
    class Program
    {
        static void Main(string[] args)
        {
            var rounds = 1000;
            
            var keepStrategy = new KeepStrategy();
            var gameSimulation = new GameSimulation(keepStrategy);
            gameSimulation.Run(rounds);

           var changeStrategy = new ChangeStrategy();
           gameSimulation = new GameSimulation(changeStrategy);
           gameSimulation.Run(rounds);
        }
    }
}