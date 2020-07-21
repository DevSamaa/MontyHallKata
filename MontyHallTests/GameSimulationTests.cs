using MontyHallKata;
using NSubstitute;
using Xunit;

namespace MontyHallTests
{
    public class GameSimulationTests
    {
        [Fact]
        public void PlayingAWinningRoundShouldReturnTrueWithDouble()
        {
            var gameSimulation = new GameSimulation(new KeepStrategy());
            var mockRandomNumber = new Always1RandomNumberGenerator();
            var result = gameSimulation.PlayARound(mockRandomNumber);
            Assert.True(result);
        }

        [Fact]
        public void PlayingAWinningRoundShouldReturnTrueWithKeepStrategy()
        {
            var gameSimulation = new GameSimulation(new KeepStrategy());
            var mockRandomNumber = Substitute.For<IRandomNumberGenerator>();
            mockRandomNumber.Generate().Returns(1);
            var result = gameSimulation.PlayARound(mockRandomNumber);
            Assert.True(result);
        }
        
        [Fact]
        public void PlayingALosingRoundShouldReturnFalseWithKeepStrategy()
        {
            var gameSimulation = new GameSimulation(new KeepStrategy());
            var mockRandomNumber = Substitute.For<IRandomNumberGenerator>();
            mockRandomNumber.Generate().Returns(1,3);
            var result = gameSimulation.PlayARound(mockRandomNumber);
            Assert.False(result);
        }
        
        
        [Fact]
        public void PlayingAWinningRoundShouldReturnTrueWithChangeStrategy()
        {
            var gameSimulation = new GameSimulation(new ChangeStrategy());
            var mockRandomNumber = Substitute.For<IRandomNumberGenerator>();
            mockRandomNumber.Generate().Returns(1,3);
            var result = gameSimulation.PlayARound(mockRandomNumber);
            Assert.True(result);
        }
        
        [Fact]
        public void PlayingALosingRoundShouldReturnFalseWithChangeStrategy()
        {
            var gameSimulation = new GameSimulation(new ChangeStrategy());
            var mockRandomNumber = Substitute.For<IRandomNumberGenerator>();
            mockRandomNumber.Generate().Returns(1,1);
            var result = gameSimulation.PlayARound(mockRandomNumber);
            Assert.False(result);
        }
    }
}

//TODO figure out if I can mock the changestrategy and keepstrategy in the game simulation tests