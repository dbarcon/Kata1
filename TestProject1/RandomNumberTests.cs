using AwesomeAssertions;
using NUnit.Framework;
using ConsoleApp1;
using NSubstitute;

namespace TestProject1;

public class RandomNumberTests
{

    [Test]
    public void WhenGameReceivesTheCorrectNumberThePlayerWins()
    {
        var game = new Game();
        
        var result = game.Guess(5);
        
        result.Should().Be("Win");
    }

    [Test]
    public void WhenGameReceivesAHigherNumberTheGameReturnsLower()
    {
        var game = new Game();
        
        var result = game.Guess(6);
        
        result.Should().Be("Lower");
    }
}