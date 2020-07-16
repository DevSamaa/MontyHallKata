using System;

namespace MontyHallKata
{
    class Program
    {
        static void Main(string[] args)
        {
            var keepStrategy = new KeepStrategy();
            var gameSimulation = new GameSimulation(keepStrategy);
            gameSimulation.Run();

           var changeStrategy = new ChangeStrategy();
           gameSimulation = new GameSimulation(changeStrategy);
           gameSimulation.Run();
        }
    }
}