using MontyHallKata;
using NSubstitute;
using Xunit;

namespace MontyHallTests
{
    public class GameSimulationTests
    {
        private readonly IRandomNumberGenerator _mockRandomNumber;

        public GameSimulationTests()
        {
            _mockRandomNumber = Substitute.For<IRandomNumberGenerator>();
        }
        [Fact]
        public void PlayingAWinningRoundShouldReturnTrueWithDouble()
        {
            var gameSimulation = new GameSimulation(new KeepStrategy());
            var mockRandomNumber = new Always1RandomNumberGenerator();
            var result = gameSimulation.PlayARound(mockRandomNumber);
            Assert.True(result);
        }

        // [Fact]
        // public void PlayingAWinningRoundShouldReturnTrueWithKeepStrategy()
        // {
        //     var gameSimulation = new GameSimulation(new KeepStrategy());
        //    
        //     _mockRandomNumber.Generate().Returns(1,1);
        //     var result = gameSimulation.PlayARound(_mockRandomNumber);
        //     Assert.True(result);
        // }
        //
        // [Fact]
        // public void PlayingALosingRoundShouldReturnFalseWithKeepStrategy()
        // {
        //     var gameSimulation = new GameSimulation(new KeepStrategy());
        //     _mockRandomNumber.Generate().Returns(1,3);
        //     var result = gameSimulation.PlayARound(_mockRandomNumber);
        //     Assert.False(result);
        // }

        [Theory]
        [InlineData(1, 1, true)]
        [InlineData(1, 3, false)]
        public void PlayARoundShouldReturnExpectedResult(int firstMockNumber, int secondMockNumber, bool expectedResult)
        {
            var gameSimulation = new GameSimulation(new KeepStrategy());
            _mockRandomNumber.Generate().Returns(firstMockNumber, secondMockNumber);
            var result = gameSimulation.PlayARound(_mockRandomNumber);
            Assert.Equal(expectedResult, result);
        }

        //TODO repeat the same thing for the next 2 tests
        
        [Fact]
        [Trait("Category","IntegrationTest")]
        public void PlayingAWinningRoundShouldReturnTrueWithChangeStrategy()
        {
            var gameSimulation = new GameSimulation(new ChangeStrategy());
            _mockRandomNumber.Generate().Returns(1,3);
            var result = gameSimulation.PlayARound(_mockRandomNumber);
            Assert.True(result);
        }
        
        [Fact]
        public void PlayingALosingRoundShouldReturnFalseWithChangeStrategy()
        {
            var gameSimulation = new GameSimulation(new ChangeStrategy());
            _mockRandomNumber.Generate().Returns(1,1);
            var result = gameSimulation.PlayARound(_mockRandomNumber);
            Assert.False(result);
        }
    }
}

//TODO figure out if I can mock the changestrategy and keepstrategy in the game simulation tests
//note keep.ChangeSelection doesn't have anything in it, so it doesn't need to be mocked
//change.ChangeSelection doesn't return anything so what's the benefit of mocking it?