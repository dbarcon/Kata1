using AwesomeAssertions;
using NUnit.Framework;
using ConsoleApp1;
using NSubstitute;

namespace TestProject1;

public class Tests
{

    [Test]
    public void WhenGameReceivesorrectNumberThePlayerWins()
    {
        var game = new Game();
        var result = game.Guess(5);
        result.Should().Be("Win");
    }
}

public class Game
{
    public string Guess(int i)
    {
        return "Win";
    }
}
