using System;

namespace MontyHallKata
{
    class Program
    {
        static void Main(string[] args)
        {
            var keepStrategyGameSimulation = new KeepStrategyGameSimulation();
            keepStrategyGameSimulation.Run();

           var changeStrategyGameSimulation = new ChangeStrategyGameSimulation();
           changeStrategyGameSimulation.Run();
        }
    }
}