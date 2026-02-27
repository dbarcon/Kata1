using AwesomeAssertions;
using NUnit.Framework;
using ConsoleApp1;
using NSubstitute;

namespace TestProject1;

public class RandomNumberTests
{
    private Game game;

    [SetUp]
    public void Setup()
    {
        var randomNumberGenerator = Substitute.For<RandomNumberGenerator>();
        game = new Game(randomNumberGenerator);
    }

    [Test]
    public void WhenGameReceivesTheCorrectNumberThePlayerWins()
    {
        var result = game.Guess(5);
        
        result.Should().Be("Win");
    }

    [Test]
    public void WhenGameReceivesAHigherNumberTheGameReturnsLower()
    {
        var result = game.Guess(6);
        
        result.Should().Be("Lower");
    }

    [Test]
    public void WhenGameReceivesALowerNumberTheGameReturnsHigher()
    {
        var result = game.Guess(4);

        result.Should().Be("Higher");
    }
    
    [Test]
    public void WhenThePlayerGuessesTheWrongNumberThreeTimesTheGameReturnsYouLost()
    {
        game.Guess(6);
        game.Guess(4);
        var result = game.Guess(10);
        
        result.Should().Be("You lost");
    }
}
