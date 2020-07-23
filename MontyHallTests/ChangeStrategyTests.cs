using MontyHallKata;
using Xunit;

namespace MontyHallTests
{
    public class ChangeStrategyTests
    {
        [Fact]
        public void ShouldChoseDoor3()
        {
            var gameStage = new GameStage();
            var changeStrategy = new ChangeStrategy();
            
            gameStage.AllDoors[0].Chosen = true;
            gameStage.AllDoors[1].Open = true;

            changeStrategy.ChangeSelection(gameStage.AllDoors);

            Assert.True(gameStage.AllDoors[2].Chosen);
            Assert.False(gameStage.AllDoors[0].Chosen);
        }
    }
}